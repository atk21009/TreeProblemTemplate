﻿using TreeProblemTemplate;

FootballRosterTree footballDataBase = new FootballRosterTree();
        
footballDataBase.Insert(57, "Orlando", "Brown");
footballDataBase.Insert(73, "Nick", "Allegretti");
footballDataBase.Insert(27, "Ugo", "Amadi");
footballDataBase.Insert(39, "Zayne", "Anderson");
footballDataBase.Insert(81, "Blake", "Bell");
footballDataBase.Insert(80, "Kendall", "Blanton");
footballDataBase.Insert(32, "Nick", "Bolton");
footballDataBase.Insert(30, "Dicaprio", "Bootle");
footballDataBase.Insert(12, "Shane", "Buechele");
footballDataBase.Insert(45, "Michael", "Burton");
footballDataBase.Insert(26, "Deon", "Bush");
footballDataBase.Insert(49, "Matt", "Bushman");
footballDataBase.Insert(7, "Harrison", "Butker");
footballDataBase.Insert(54, "Leo", "Chenal");
footballDataBase.Insert(48, "Cole", "Christiansen");
footballDataBase.Insert(55, "Frank", "Clark");
footballDataBase.Insert(43, "Jack", "Cochrane");
footballDataBase.Insert(6, "Bryan", "Cook");
footballDataBase.Insert(51, "Mike", "Danna");
footballDataBase.Insert(8, "Carlos", "Dunlap");
footballDataBase.Insert(89, "Jerrion", "Ealy");
footballDataBase.Insert(25, "Clyde", "Edwards-Helaire");
footballDataBase.Insert(88, "Jody", "Fortson");
footballDataBase.Insert(46, "Jordan", "Franks");
footballDataBase.Insert(50, "Willie", "Gay");
footballDataBase.Insert(34, "Melvin", "Gordon");
footballDataBase.Insert(83, "Noah", "Gray");
footballDataBase.Insert(17, "Mecole", "Hardman");
footballDataBase.Insert(47, "Darius", "Harris");
footballDataBase.Insert(4, "Chad", "Henne");
footballDataBase.Insert(94, "Malik", "Herring");
footballDataBase.Insert(92, "Phil", "Hoskins");
footballDataBase.Insert(52, "Creed", "Humphrey");
footballDataBase.Insert(13, "Nazeeh", "Johnson");
footballDataBase.Insert(95, "Chris", "Jones");
footballDataBase.Insert(2, "Ronald", "Jones");
footballDataBase.Insert(59, "Joshua", "Kaindoh");
footballDataBase.Insert(56, "George", "Karlaftis");
footballDataBase.Insert(87, "Travis", "Kelce");
footballDataBase.Insert(85, "Marcus", "Kemp");
footballDataBase.Insert(75, "Darian", "Kinnard");
footballDataBase.Insert(15, "Patrick", "Mahomes");
footballDataBase.Insert(21, "Trent", "McDuffie");
footballDataBase.Insert(24, "Skyy", "Moore");
footballDataBase.Insert(67, "Lucas", "Niang");
footballDataBase.Insert(91, "Derrick", "Nnadi");
footballDataBase.Insert(14, "Chris", "Oladokun");
footballDataBase.Insert(10, "Isiah", "Pacheco");
footballDataBase.Insert(22, "La'Mical", "Perine");
footballDataBase.Insert(14, "Cornell", "Powell");
footballDataBase.Insert(20, "Justin", "Reid");
footballDataBase.Insert(61, "Austin", "Reiter");
footballDataBase.Insert(8, "Justyn", "Ross");
footballDataBase.Insert(99, "Khalen", "Saunders");
footballDataBase.Insert(71, "Danny", "Shelton");
footballDataBase.Insert(65, "Trey", "Smith");
footballDataBase.Insert(82, "Ihmir", "Smith-Marsette");
footballDataBase.Insert(9, "JuJu", "Smith-Schuster");
footballDataBase.Insert(38, "L'Jarius", "Sneed");
footballDataBase.Insert(22, "Juan", "Thornhill");
footballDataBase.Insert(62, "Joe", "Thuney");
footballDataBase.Insert(19, "Kadarius", "Toney");
footballDataBase.Insert(5, "Tommy", "Townsend");
footballDataBase.Insert(11, "Marquez", "Valdes-Scantling");
footballDataBase.Insert(70, "Prince", "Tega Wanogho");
footballDataBase.Insert(35, "Jaylen", "Watson");
footballDataBase.Insert(84, "Justin", "Watson");
footballDataBase.Insert(98, "Tershawn", "Wharton");
footballDataBase.Insert(66, "Brandon", "Williams");
footballDataBase.Insert(23, "Joshua", "Williams");
footballDataBase.Insert(41, "James", "Winchester");
footballDataBase.Insert(77, "Andrew", "Wylie");
footballDataBase.Insert(1, "Jerick", "McKinnon");

foreach (var number in footballDataBase)
{
    Console.WriteLine($"{number.Item1} - {number.Item2} {number.Item3}");
}
Console.WriteLine("Max depth: " + footballDataBase.MaxDepth(footballDataBase.Root));