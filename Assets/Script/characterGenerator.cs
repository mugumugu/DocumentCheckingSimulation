using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class characterGenerator : MonoBehaviour {
    public int fictionalYear;

    public float seed,
                 heightModifier = 3f;

    float previousSeed;
    
    public string string_name,
                string_birthday,
                string_age,
                string_Origin,
                string_visa_issue,
                string_visa_expiry;

    public bool hasSeal_visa = true,
                hasSeal_work = true;

    string[] fname = { "Thomas", "William", "Jacob", "Liam", "Felix", "Nathan", "Samuel", "Logan", "Alexis", "Noah", "Olivier", "Raphael", "Gabriel", "Emile", "Leo", "Charles", "Antoine", "Benjamin", "Adam", "Édouard", "Xavier", "Victor", "Zack", "Mathis", "Jayden", "Theo", "Elliot", "Zachary", "Louis", "James", "Anthony", "Alexandre", "Lucas", "Justin", "Arthur", "Tristan", "Loïc", "Ethan", "Henri", "Nolan", "Nicolas", "Arnaud", "Jeremy", "Hugo", "Dylan", "Laurent", "Eli", "Vincent", "Isaac", "Etienne", "Philippe", "Malik", "David", "Alex", "Ryan", "Maxime", "Hubert", "Ludovic", "Eloi", "Damien", "Hayden", "Evan", "Zackary", "Milan", "Mathéo", "Jules", "Simon", "Caleb", "Rayan", "Eliot", "Rafael", "Derek", "Tyler", "Eliott", "Matteo", "Jake", "Jordan", "Loik", "Michael", "Louka", "Jackson", "Julien", "Leonard", "Joshua", "Daniel", "Mathias", "Emrick", "Lyam", "Mayson", "Brandon", "Mathieu", "Rémi", "Sam", "Aiden", "Alexander", "Theodore", "Enzo", "Mikael", "Christophe", "Tommy", "Walter", "Arthur", "Samuel", "Clarence", "Ernest", "Oscar", "Alfred", "Perry", "Wesley", "Percy", "Amos", "Rufus", "Eli", "Owen", "Silas", "Kylo", "Creed", "Benicio", "Adonis", "Fox", "Kye", "Hakeem", "Shepherd", "Wilder", "Zayn", "Mikael", "Eason", "Karim", "Franco", "Apollo", "Zyaire", "Kingsley", "Bridger", "Grey", "Alistair", "James", "John", "Robert", "Michael", "William", "David", "Richard", "Joseph", "Thomas", "Charles", "Noah", "Liam", "Mason", "Jacob", "William", "Ethan", "James", "Elijah", "Michael", "Benjamin" },
             lname = { "Gruber", "Huber", "Baue", "Wagne", "Mülle", "Pichle", "Steine", "Mose", "Maye", "Hofe", "Leitne", "Berge", "Fuch", "Ede", "Fische", "Schmi", "Winkle", "Webe", "Schwar", "Maie", "Schneide", "Reite", "May", "Schmid", "Wimme", "Egge", "Brunne", "Lan", "Baumgartne", "Aue", "Binde", "Lechne", "Wol", "Wallne", "Aigne", "Ebne", "Kolle", "Lehne", "Haa", "Schuste", "Heili", "Müller", "Schmidt", "Schneider", "Fischer", "Weber", "Mayer", "Wagner", "Becker", "Schulz", "Hoffmann", "Schäfer", "Koch", "Bauer", "Richter", "Klein", "WolfSchröder", "Neumann", "Schwarz", "Zimmermann", "Braun", "Krüger", "Hofmann", "Hartmann", "Lange", "Schmitt", "Werner", "Schmitz", "Krause", "Meier", "Lehmann", "Schmid", "Schulze", "Maier", "Köhler", "Herrmann", "König", "Walter", "Mayer", "Huber", "Kaiser", "Fuchs", "Peters", "Lang", "Scholz", "Möller", "Weiß", "Jung", "Hahn", "Schubert", "Vogel", "Friedrich", "Keller", "Günther", "Frank", "Berger", "Winkler", "Roth", "Beck", "Lorenz", "Baumann", "Franke", "Albrecht", "Schuster", "Simon", "Ludwig", "Böhm", "Winter", "Kraus", "Martin", "Schumacher", "Krämer", "Vogt", "Stein", "Jäger", "Otto", "Sommer", "Groß", "Seidel", "Heinrich", "Brandt", "Haas", "Schreiber", "Graf", "Schulte", "Dietrich", "Ziegler", "Kuhn", "Kühn", "Pohl", "Horn", "Busch", "Bergmann", "Thomas", "Voigt", "Sauer", "Arnold", "Wolff", "Pfeiffer", "Abe", "Adachi", "Akagi", "Akamine", "Aki", "Akiyama", "Amano", "Amari", "Amaya", "Ando", "Anno", "Anzai", "Aoki", "Aoyama", "Arai", "Arakaki", "Arakawa", "Araki", "Arata", "Araya", "Arima", "Arita", "Asa", "Asai", "Asano", "Asato", "Ashikaga", "Azuma", "Baba", "Ban", "Bando", "Chiba", "Chinen", "Chino", "Date", "Doi", "Domen", "Eguchi", "Endo", "Enomoto", "Eto", "Fujii", "Fujikawa", "Fujimori", "Fujimoto", "Fujimura", "Fujino", "Fujioka", "Fujita", "Fujiwara", "Fukuda", "Fukuhara", "Fukui", "Fukumoto", "Fukunaga", "Fukushima", "Funai", "Furukawa", "Furuta", "Furutani", "Furuya", "Fuse", "Gima", "Go", "Goda", "Goto", "Goya", "Hada", "Haga", "Hagiwara", "Hamada", "Hamamoto", "Hamasaki", "Handa", "Hano", "Hara", "Harada", "Hase", "Hasegawa", "Hashimoto", "Hata", "Hatanaka", "Hattori", "Hayakawa", "Hayashi", "Hayashida", "Higa", "Higashi", "Higuchi", "Hino", "Hirabayashi", "Hirai", "Hirano", "Hiraoka", "Hirata", "Hirayama", "Hironaka", "Hirose", "Hirota", "Hoga", "Hokama", "Honda", "Hora", "Hori", "Horie", "Horiuchi", "Hoshino", "Ichikawa", "Ida", "Ide", "Igarashi", "Ige", "Iha", "Iida", "Ike", "Ikeda", "Ikehara", "Imada", "Imai", "Imamura", "Inaba", "Inouye", "Isa", "Iseri", "Ishibashi", "Ishida", "Ishihara", "Ishii", "Ishikawa", "Ishimoto", "Isobe", "Ito", "Itoh", "Iwai", "Iwamoto", "Iwasaki", "Iwata", "Izumi", "Jin", "Jo", "Juba", "Kaba", "Kagawa", "Kai", "Kajiwara", "Kamei", "Kamiya", "Kanai", "Kanda", "Kaneko", "Kanemoto", "Kaneshiro", "Kanno", "Kano", "Kasai", "Kase", "Kataoka", "Katayama", "Kato", "Kawabata", "Kawaguchi", "Kawahara", "Kawai", "Kawakami", "Kawamoto", "Kawamura", "Kawano", "Kawasaki", "Kawashima", "Kawata", "Kaya", "Kibe", "Kida", "Kido", "Kikuchi", "Kimoto", "Kimura", "Kinoshita", "Kishi", "Kishimoto", "Kita", "Kitagawa", "Kitamura", "Kiyabu", "Kobashigawa", "Kobayashi", "Kobe", "Koda", "Kodama", "Koga", "Koike", "Koizumi", "Kojima", "Komatsu", "Kon", "Konda", "Kondo", "Konishi", "Konno", "Kono", "Konya", "Koyama", "Koyanagi", "Kuba", "Kubo", "Kubota", "Kudo", "Kumagai", "Kuno", "Kuramoto", "Kurata", "Kure", "Kurihara", "Kuroda", "Kurokawa", "Kuse", "Kusumoto", "Kuwahara", "Machi", "Machida", "Mae", "Maeda", "Maekawa", "Maita", "Maki", "Makino", "Mano", "Maruyama", "Masaki", "Mase", "Masuda", "Matsubara", "Matsuda", "Matsui", "Matsumoto", "Matsumura", "Matsunaga", "Matsuno", "Matsuo", "Matsuoka", "Matsushima", "Matsushita", "Matsuura", "Matsuyama", "Matsuzaki", "Mayeda", "Mihara", "Mikami", "Miki", "Minami", "Minamoto", "Mino", "Mita", "Miura", "Miya", "Miyagawa", "Miyahara", "Miyahira", "Miyake", "Miyamoto", "Miyasaki", "Miyasato", "Miyashiro", "Miyashita", "Miyata", "Miyazaki", "Miyoshi", "Mizuno", "Mochizuki", "Mori", "Morikawa", "Morimoto", "Morine", "Morino", "Morioka", "Morishige", "Morishita", "Morita", "Moriyama", "Mukai", "Mura", "Murai", "Murakami", "Muramoto", "Muranaka", "Murano", "Muraoka", "Murata", "Murayama", "Muto", "Nagai", "Nagamine", "Nagano", "Nagao", "Nagasawa", "Nagata", "Naito", "Nakada", "Nakagawa", "Nakahara", "Nakai", "Nakajima", "Nakama", "Nakamoto", "Nakamura", "Nakanishi", "Nakano", "Nakao", "Nakashima", "Nakasone", "Nakata", "Nakatani", "Nakatomi", "Nakayama", "Nakazawa", "Namba", "Nii", "Nishi", "Nishida", "Nishihara", "Nishikawa", "Nishimoto", "Nishimura", "Nishioka", "Nishiyama", "Nitta", "Niwa", "No", "Noda", "Noguchi", "Nomura", "Nonaka", "Noya", "Oba", "Obara", "Obi", "Oda", "Oe", "Ogasawara", "Ogata", "Ogata", "Ogawa", "Ogino", "Ogura", "Oh", "Ohara", "Ohashi", "Ohta", "Oishi", "Oka", "Okabe", "Okada", "Okamoto", "Okamura", "Okane", "Okano", "Okawa", "Okazaki", "Oki", "Okimoto", "Okino", "Okita", "Okubo", "Okuda", "Okuma", "Okumura", "Okura", "Omori", "Omura", "Onaga", "Onishi", "Ono", "Orio", "Osada", "Osaki", "Ose", "Oshima", "Oshima", "Oshiro", "Oshiro", "Oshiro", "Oshita", "Ota", "Otake", "Otani", "Otani", "Otsuka", "Ouchi", "Oyama", "Oyama", "Oye", "Ozaki", "Ozawa", "Sada", "Sadow", "Saeki", "Saiki", "Saito", "Sakaguchi", "Sakai", "Sakamoto", "Sakata", "Sako", "Sakuma", "Sakurai", "Sama", "Sanda", "Sando", "Sano", "Sasaki", "Sasaki", "Sato", "Satow", "Sawa", "Sawada", "Sawaya", "Sazama", "Seki", "Sekiguchi", "Seno", "Seo", "Sera", "Seta", "Seto", "Shiba", "Shibata", "Shibuya", "Shima", "Shimabukuro", "Shimada", "Shimamoto", "Shimizu", "Shimoda", "Shimomura", "Shinohara", "Shinsato", "Shintani", "Shirai", "Shiraishi", "Shiraki", "Shiro", "Shiroma", "Shishido", "Shoda", "Shoji", "Soda", "Soga", "Soma", "Sone", "Sonoda", "Suda", "Sugai", "Sugawara", "Sugihara", "Sugimoto", "Sugita", "Sugiyama", "Suko", "Sumida", "Sunada", "Suto", "Suzuki", "Tabata", "Tachibana", "Tada", "Tagawa", "Taguchi", "Tahara", "Taira", "Tajima", "Takagi", "Takahashi", "Takai", "Takaki", "Takamoto", "Takano", "Takara", "Takashima", "Takata", "Takayama", "Takeda", "Takei", "Takemoto", "Takenaka", "Takeshita", "Taketa", "Takeuchi", "Tamaki", "Tamanaha", "Tamashiro", "Tamura", "Tanabe", "Tanaka", "Tani", "Tanigawa", "Taniguchi", "Tanimoto", "Tanji", "Tano", "Tao", "Tashiro", "Tengan", "Terada", "Teramoto", "Teruya", "Teshima", "Tobe", "Toda", "Tokuda", "Tokunaga", "Toma", "Tominaga", "Tomita", "Tone", "Toyama", "Toyoda", "Tsuchida", "Tsuchiya", "Tsuda", "Tsuji", "Tsukamoto", "Tsutsui", "Tsutsumi", "Uchida", "Uchiyama", "Ueda", "Uehara", "Uemura", "Ueno", "Umeda", "Umemoto", "Uno", "Usui", "Uyeda", "Uyehara", "Uyemura", "Uyeno", "Wada", "Wakabayashi", "Watanabe", "Yagi", "Yamada", "Yamagata", "Yamaguchi", "Yamakawa", "Yamamoto", "Yamamura", "Yamanaka", "Yamane", "Yamaoka", "Yamasaki", "Yamashiro", "Yamashita", "Yamauchi", "Yamazaki", "Yanagi", "Yano", "Yasuda", "Yasui", "Yasutake", "Yogi", "Yokota", "Yokoyama", "Yonamine", "Yoneda", "Yoshida", "Yoshihara", "Yoshikawa", "Yoshimoto", "Yoshimura", "Yoshinaga", "Yoshino", "Yoshioka", "Smith", "Johnson", "Williams", "Jones", "Brown", "Davis", "Miller", "Wilson", "Moore", "Taylor", "Anderson", "Thomas", "Jackson", "White", "Harris", "Martin", "Thompson", "Garcia", "Martinez", "Robinson", "Clark", "Rodriguez", "Lewis", "Lee", "Walker", "Hall", "Allen", "Young", "Hernandez", "King", "Wright", "Lopez", "Hill", "Scott", "Green", "Adams", "Baker", "Gonzalez", "Nelson", "Carter", "Mitchell", "Perez", "Roberts", "Turner", "Phillips", "Campbell", "Parker", "Evans", "Edwards", "Collins", "Stewart", "Sanchez", "Morris", "Rogers", "Reed", "Cook", "Morgan", "Bell", "Murphy", "Bailey", "Rivera", "Cooper", "Richardson", "Cox", "Howard", "Ward", "Torres", "Peterson", "Gray", "Ramirez", "James", "Watson", "Brooks", "Kelly", "Sanders", "Price", "Bennett", "Wood", "Barnes", "Ross", "Henderson", "Coleman", "Jenkins", "Perry", "Powell", "Long", "Patterson", "Hughes", "Flores", "Washington", "Butler", "Simmons", "Foster", "Gonzales", "Bryant", "Alexander", "Russell", "Griffin", "Diaz", "Hayes", "Myers", "Ford", "Hamilton", "Graham", "Sullivan", "Wallace", "Woods", "Cole", "West", "Jordan", "Owens", "Reynolds", "Fisher", "Ellis", "Harrison", "Gibson", "Mcdonald", "Cruz", "Marshall", "Ortiz", "Gomez", "Murray", "Freeman", "Wells", "Webb", "Simpson", "Stevens", "Tucker", "Porter", "Hunter", "Hicks", "Crawford", "Henry", "Boyd", "Mason", "Morales", "Kennedy", "Warren", "Dixon", "Ramos", "Reyes", "Burns", "Gordon", "Shaw", "Holmes", "Rice", "Robertson", "Hunt", "Black", "Daniels", "Palmer", "Mills", "Nichols", "Grant", "Knight", "Ferguson", "Rose", "Stone", "Hawkins", "Dunn", "Perkins", "Hudson", "Spencer", "Gardner", "Stephens", "Payne", "Pierce", "Berry", "Matthews", "Arnold", "Wagner", "Willis", "Ray", "Watkins", "Olson", "Carroll", "Duncan", "Snyder", "Hart", "Cunningham", "Bradley", "Lane", "Andrews", "Ruiz", "Harper", "Fox", "Riley", "Armstrong", "Carpenter", "Weaver", "Greene", "Lawrence", "Elliott", "Chavez", "Sims", "Austin", "Peters", "Kelley", "Franklin", "Lawson", "Fields", "Gutierrez", "Ryan", "Schmidt", "Carr", "Vasquez", "Castillo", "Wheeler", "Chapman", "Oliver", "Montgomery", "Richards", "Williamson", "Johnston", "Banks", "Meyer", "Bishop", "Mccoy", "Howell", "Alvarez", "Morrison", "Hansen", "Fernandez", "Garza", "Harvey", "Little", "Burton", "Stanley", "Nguyen", "George", "Jacobs", "Reid", "Kim", "Fuller", "Lynch", "Dean", "Gilbert", "Garrett", "Romero", "Welch", "Larson", "Frazier", "Burke", "Hanson", "Day", "Mendoza", "Moreno", "Bowman", "Medina", "Fowler", "Brewer", "Hoffman", "Carlson", "Silva", "Pearson", "Holland", "Douglas", "Fleming", "Jensen", "Vargas", "Byrd", "Davidson", "Hopkins", "May", "Terry", "Herrera", "Wade", "Soto", "Walters", "Curtis", "Neal", "Caldwell", "Lowe", "Jennings", "Barnett", "Graves", "Jimenez", "Horton", "Shelton", "Barrett", "O'brien", "Castro", "Sutton", "Gregory", "Mckinney", "Lucas", "Miles", "Craig", "Rodriquez", "Chambers", "Holt", "Lambert", "Fletcher", "Watts", "Bates", "Hale", "Rhodes", "Pena", "Beck", "Newman", "Haynes", "Mcdaniel", "Mendez", "Bush", "Vaughn", "Parks", "Dawson", "Santiago", "Norris", "Hardy", "Love", "Steele", "Curry", "Powers", "Schultz", "Barker", "Guzman", "Page", "Munoz", "Ball", "Keller", "Chandler", "Weber", "Leonard", "Walsh", "Lyons", "Ramsey", "Wolfe", "Schneider", "Mullins", "Benson", "Sharp", "Bowen", "Daniel", "Barber", "Cummings", "Hines", "Baldwin", "Griffith", "Valdez", "Hubbard", "Salazar", "Reeves", "Warner", "Stevenson", "Burgess", "Santos", "Tate", "Cross", "Garner", "Mann", "Mack", "Moss", "Thornton", "Dennis", "Mcgee", "Farmer", "Delgado", "Aguilar", "Vega", "Glover", "Manning", "Cohen", "Harmon", "Rodgers", "Robbins", "Newton", "Todd", "Blair", "Higgins", "Ingram", "Reese", "Cannon", "Strickland", "Townsend", "Potter", "Goodwin", "Walton", "Rowe", "Hampton", "Ortega", "Patton", "Swanson", "Joseph", "Francis", "Goodman", "Maldonado", "Yates", "Becker", "Erickson", "Hodges", "Rios", "Conner", "Adkins", "Webster", "Norman", "Malone", "Hammond", "Flowers", "Cobb", "Moody", "Quinn", "Blake", "Maxwell", "Pope", "Floyd", "Osborne", "Paul", "Mccarthy", "Guerrero", "Lindsey", "Estrada", "Sandoval", "Gibbs", "Tyler", "Gross", "Fitzgerald", "Stokes", "Doyle", "Sherman", "Saunders", "Wise", "Colon", "Gill", "Alvarado", "Greer", "Padilla", "Simon", "Waters", "Nunez", "Ballard", "Schwartz", "Mcbride", "Houston", "Christensen", "Klein", "Pratt", "Briggs", "Parsons", "Mclaughlin", "Zimmerman", "French", "Buchanan", "Moran", "Copeland", "Roy", "Pittman", "Brady", "Mccormick", "Holloway", "Brock", "Poole", "Frank", "Logan", "Owen", "Bass", "Marsh", "Drake", "Wong", "Jefferson", "Park", "Morton", "Abbott", "Sparks", "Patrick", "Norton", "Huff", "Clayton", "Massey", "Lloyd", "Figueroa", "Carson", "Bowers", "Roberson", "Barton", "Tran", "Lamb", "Harrington", "Casey", "Boone", "Cortez", "Clarke", "Mathis", "Singleton", "Wilkins", "Cain", "Bryan", "Underwood", "Hogan", "Mckenzie", "Collier", "Luna", "Phelps", "Mcguire", "Allison", "Bridges", "Wilkerson", "Nash", "Summers", "Atkins", "Wilcox", "Pitts", "Conley", "Marquez", "Burnett", "Richard", "Cochran", "Chase", "Davenport", "Hood", "Gates", "Clay", "Ayala", "Sawyer", "Roman", "Vazquez", "Dickerson", "Hodge", "Acosta", "Flynn", "Espinoza", "Nicholson", "Monroe", "Wolf", "Morrow", "Kirk", "Randall", "Anthony", "Whitaker", "O'connor", "Skinner", "Ware", "Molina", "Kirby", "Huffman", "Bradford", "Charles", "Gilmore", "Dominguez", "O'neal", "Bruce", "Lang", "Combs", "Kramer", "Heath", "Hancock", "Gallagher", "Gaines", "Shaffer", "Short", "Wiggins", "Mathews", "Mcclain", "Fischer", "Wall", "Small", "Melton", "Hensley", "Bond", "Dyer", "Cameron", "Grimes", "Contreras", "Christian", "Wyatt", "Baxter", "Snow", "Mosley", "Shepherd", "Larsen", "Hoover", "Beasley", "Glenn", "Petersen", "Whitehead", "Meyers", "Keith", "Garrison", "Vincent", "Shields", "Horn", "Savage", "Olsen", "Schroeder", "Hartman", "Woodard", "Mueller", "Kemp", "Deleon", "Booth", "Patel", "Calhoun", "Wiley", "Eaton", "Cline", "Navarro", "Harrell", "Lester", "Humphrey", "Parrish", "Duran", "Hutchinson", "Hess", "Dorsey", "Bullock", "Robles", "Beard", "Dalton", "Avila", "Vance", "Rich", "Blackwell", "York", "Johns", "Blankenship", "Trevino", "Salinas", "Campos", "Pruitt", "Moses", "Callahan", "Golden", "Montoya", "Hardin", "Guerra", "Mcdowell", "Carey", "Stafford", "Gallegos", "Henson", "Wilkinson", "Booker", "Merritt", "Miranda", "Atkinson", "Orr", "Decker", "Hobbs", "Preston", "Tanner", "Knox", "Pacheco", "Stephenson", "Glass", "Rojas", "Serrano", "Marks", "Hickman", "English", "Sweeney", "Strong", "Prince", "Mcclure", "Conway", "Walter", "Roth", "Maynard", "Farrell", "Lowery", "Hurst", "Nixon", "Weiss", "Trujillo", "Ellison", "Sloan", "Juarez", "Winters", "Mclean", "Randolph", "Leon", "Boyer", "Villarreal", "Mccall", "Gentry", "Carrillo", "Kent", "Ayers", "Lara", "Shannon", "Sexton", "Pace", "Hull", "Leblanc", "Browning", "Velasquez", "Leach", "Chang", "House", "Sellers", "Herring", "Noble", "Foley", "Bartlett", "Mercado", "Landry", "Durham", "Walls", "Barr", "Mckee", "Bauer", "Rivers", "Everett", "Bradshaw", "Pugh", "Velez", "Rush", "Estes", "Dodson", "Morse", "Sheppard", "Weeks", "Camacho", "Bean", "Barron", "Livingston", "Middleton", "Spears", "Branch", "Blevins", "Chen", "Kerr", "Mcconnell", "Hatfield", "Harding", "Ashley", "Solis", "Herman", "Frost", "Giles", "Blackburn", "William", "Pennington", "Woodward", "Finley", "Mcintosh", "Koch", "Best", "Solomon", "Mccullough", "Dudley", "Nolan", "Blanchard", "Rivas", "Brennan", "Mejia", "Kane", "Benton", "Joyce", "Buckley", "Haley", "Valentine", "Maddox", "Russo", "Mcknight", "Buck", "Moon", "Mcmillan", "Crosby", "Berg", "Dotson", "Mays", "Roach", "Church", "Chan", "Richmond", "Meadows", "Faulkner", "O'neill", "Knapp", "Kline", "Barry", "Ochoa", "Jacobson", "Gay", "Avery", "Hendricks", "Horne", "Shepard", "Hebert", "Cherry", "Cardenas", "Mcintyre", "Whitney", "Waller", "Holman", "Donaldson", "Cantu", "Terrell", "Morin", "Gillespie", "Fuentes", "Tillman", "Sanford", "Bentley", "Peck", "Key", "Salas", "Rollins", "Gamble", "Dickson", "Battle", "Santana", "Cabrera", "Cervantes", "Howe", "Hinton", "Hurley", "Spence", "Zamora", "Yang", "Mcneil", "Suarez", "Case", "Petty", "Gould", "Mcfarland", "Sampson", "Carver", "Bray", "Rosario", "Macdonald", "Stout", "Hester", "Melendez", "Dillon", "Farley", "Hopper", "Galloway", "Potts", "Bernard", "Joyner", "Stein", "Aguirre", "Osborn", "Mercer", "Bender", "Franco", "Rowland", "Sykes", "Benjamin", "Travis", "Pickett", "Crane", "Sears", "Mayo", "Dunlap", "Hayden", "Wilder", "Mckay", "Coffey", "Mccarty", "Ewing", "Cooley", "Vaughan", "Bonner", "Cotton", "Holder", "Stark", "Ferrell", "Cantrell", "Fulton", "Lynn", "Lott", "Calderon", "Rosa", "Pollard", "Hooper", "Burch", "Mullen", "Fry", "Riddle", "Levy", "David", "Duke", "O'donnell", "Guy", "Michael", "Britt", "Frederick", "Daugherty", "Berger", "Dillard", "Alston", "Jarvis", "Frye", "Riggs", "Chaney", "Odom", "Duffy", "Fitzpatrick", "Valenzuela", "Merrill", "Mayer", "Alford", "Mcpherson", "Acevedo", "Donovan", "Barrera", "Albert", "Cote", "Reilly", "Compton", "Raymond", "Mooney", "Mcgowan", "Craft", "Cleveland", "Clemons", "Wynn", "Nielsen", "Baird", "Stanton", "Snider", "Rosales", "Bright", "Witt", "Stuart", "Hays", "Holden", "Rutledge", "Kinney", "Clements", "Castaneda", "Slater", "Hahn", "Emerson", "Conrad", "Burks", "Delaney", "Pate", "Lancaster", "Sweet", "Justice", "Tyson", "Sharpe", "Whitfield", "Talley", "Macias", "Irwin", "Burris", "Ratliff", "Mccray", "Madden", "Kaufman", "Beach", "Goff", "Cash", "Bolton", "Mcfadden", "Levine", "Good", "Byers", "Kirkland", "Kidd", "Workman", "Carney", "Dale", "Mcleod", "Holcomb", "England", "Finch", "Head", "Burt", "Hendrix", "Sosa", "Haney", "Franks", "Sargent", "Nieves", "Downs", "Rasmussen", "Bird", "Hewitt", "Lindsay", "Le", "Foreman", "Valencia", "O'neil", "Delacruz", "Vinson", "Dejesus", "Hyde", "Forbes", "Gilliam", "Guthrie", "Wooten", "Huber", "Barlow", "Boyle", "Mcmahon", "Buckner", "Rocha", "Puckett", "Langley", "Knowles", "Cooke", "Velazquez", "Whitley", "Noel", "Vang" },
             countries = { "Hoenigberg", "Leopona", "The Union", "Westland", "Mideah", "Yoharon", "Cheulgi", "Great Abby" };

    // Use this for initialization
    public void Generate ()
    {
        seed = UnityEngine.Random.Range(0, 200);
        makeCharacter();
    }

    private void Update()
    {
        // if (previousSeed != seed)
        // {
        //     makeCharacter();
        //     previousSeed = seed;
        // }
    }

    public void makeCharacter()
    {
        string_name = generateName();
        string_birthday = generateBday();
        string_age = CalculateAge(generateBday(),fictionalYear);
        string_Origin = countries[generateCountry()];
        string_visa_issue = generateVisaIssue();
        string_visa_expiry = generateVisaExpiry();
        hasSeal_visa = generateSeal();
    }

    string generateName(){
        int f = UnityEngine.Random.Range(0, fname.Length),
            l = UnityEngine.Random.Range(0, lname.Length);

        string name = fname[f].ToString() + " " + lname[l].ToString();

        return name;
    }

    int generateCountry(){
        int origin = UnityEngine.Random.Range(0, countries.Length);
        return origin;
    }

    string generateBday(){
        int m = UnityEngine.Random.Range(1, 12),
            d = UnityEngine.Random.Range(1, 30),
            y = UnityEngine.Random.Range(1948, 1970);

        string bday = m.ToString() + "/" + d.ToString() + "/" + y.ToString();
        return bday;
    }
    private static string CalculateAge(string dob,int k)
    {  
        char[] delimiters = {'/', ','};
        string[] d = dob.Split(delimiters);

        int age = 0;
            age = k - int.Parse(d[2]);

        if (k < int.Parse(d[2]))
            age = age - 1;
    
        return age.ToString();
    } 

    string generateVisaIssue(){
        int iss_m = UnityEngine.Random.Range(1, 12),
            iss_d = UnityEngine.Random.Range(1, 30),
            iss_y = UnityEngine.Random.Range(1980, 1985);
        string issue = iss_m.ToString() + "/" + iss_d.ToString() + "/" + iss_y.ToString();
        return issue;
    }

    string generateVisaExpiry(){
        int exp_m = UnityEngine.Random.Range(1, 12),
            exp_d = UnityEngine.Random.Range(1, 30),
            exp_y = UnityEngine.Random.Range(1985, 1990);

        string expire = exp_m.ToString() + "/" + exp_d.ToString() + "/" + exp_y.ToString();

        return expire;
    }

    bool generateSeal(){
        if (UnityEngine.Random.Range(0, 1)==1) 
            return false;
        else
            return true;
    }
}
