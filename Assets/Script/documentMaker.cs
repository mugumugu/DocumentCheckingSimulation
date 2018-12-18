using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class documentMaker : MonoBehaviour {

	public GameObject visa,current;
	private characterGenerator characterGenerator;
	public Swipe swipeControls;
	public ruleMaker ruleMaker;
	public AudioSource audioSource;
	public AudioClip[] slipDocument;

	public TextMeshPro tally;

	int added = 0;
	void Start(){
		swipeControls = GetComponent<Swipe>();
		characterGenerator = GetComponent<characterGenerator>();
		ruleMaker = GetComponent<ruleMaker>();
		audioSource = GetComponent<AudioSource>();
		createCharacter();
	}

	public void createCharacter(){
		characterGenerator.Generate();	

		GameObject x = Instantiate(visa,transform.position,transform.rotation,null);
				   x.name = "newVisa"+added;
		
		Transform detailContent = x.transform.transform.Find("main");
		TextMeshPro name = detailContent.Find("name").GetComponent<TextMeshPro>(),
				 issue = detailContent.Find("issue").GetComponent<TextMeshPro>(),
				 expiry = detailContent.Find("expiry").GetComponent<TextMeshPro>(),
				 nation = detailContent.Find("nation").GetComponent<TextMeshPro>();

        if(name??false)
			name.text = characterGenerator.string_name.ToUpper();

        if(nation??false)
			nation.text = characterGenerator.string_Origin.ToUpper();

        if(issue??false)
			expiry.text = characterGenerator.string_visa_expiry.ToUpper();

        if(expiry??false)
			issue.text = characterGenerator.string_visa_issue.ToUpper();

		string newTally = "000";

		if(added.ToString().Length==1)
			newTally = "00"+added;
		if(added.ToString().Length==2)
			newTally = "0"+added;

		if(tally??false)
			tally.text = newTally;

		tweener k = x.GetComponent<tweener>();
			k.enabled = true;
			k.originalPos = transform;
			k.moveInt = 0;

		playSlip();
		x.SetActive(true);
		current = x;
	}

	void playSlip(){
		int slipRand = Random.Range(0,slipDocument.Length);
		audioSource.PlayOneShot(slipDocument[slipRand]);
	}

	void Update(){
		if(swipeControls.SwipeUp){
			current.GetComponent<tweener>().moveInt = 2;
			playSlip();
			InvokeRepeating("checkIfDestroyed", 0f, 0.2f);
		}
	}


	void checkIfDestroyed(){
		if(current==null){
			// Debug.Log("is-now-null");
			CancelInvoke();
			ruleMaker.validateData();
			added+=1;
			createCharacter();
		}
	}
}
