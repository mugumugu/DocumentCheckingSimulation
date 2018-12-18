using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class ruleMaker : MonoBehaviour {

	private characterGenerator document;

	public bool setAgeLimit = false;
	public int ageLimit;
	public bool ageCeil;

	public string[] banned_individuals = {"Darryl"};

	public bool setNationBan = false;
	public string[] banned_nations = { "foo", "bar" };

	void Start(){
		document = GetComponent<characterGenerator>();
	}

	bool hasError;

	public int createdNew;
	// Update is called once per frame
	public void validateData(){
		hasError = false;

		if(setAgeLimit){
			if(validateAge(int.Parse(document.string_age))){
				hasError = true;
				Debug.Log("Underage!");
			}
		}

		if(setNationBan){
			if(validateNation(document.string_Origin)){
				hasError = true;
				Debug.Log("Invalid Nation");
			}
		}

		if(validateExpiry(document.string_visa_expiry)!="valid"){
			hasError = true;
			Debug.Log("Invalid Visa");
		}

		if(hasError)
			Debug.Log("Error");
		else
			Debug.Log("Ok");
	}


	bool validateNation(string x){
		if (banned_nations.Contains(x))
			return true;
		else
			return false;
	}

	bool validateAge(int a){
		if(setAgeLimit){
			if(ageCeil){
				if(a>=ageLimit)		// Ban age more than X
					return true;
				else
					return false;
			}else if(!ageCeil){		// Bane age less than X
				if(a<=18)
					return true;
				else
					return false;
			}else{
				return false;
			}
		}else{
			return false;
		}
	}
	
	string validateExpiry(string a){
		string[] k = a.Split('/');
		// DateTime oDate = Convert.ToDateTime(iDate);

		int y =	Int32.Parse(k[2]);
		// float xpire = 1987 - oDate.Year;

		float xpire = document.fictionalYear - y;
		// Debug.Log(Mathf.Sign(xpire).ToString());
		if((Mathf.Sign(xpire)<=-1f))
			return "valid";
		else
			return "expired";
	}


}
