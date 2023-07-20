Dictionary<string, string> lenguaje = new Dictionary<string, string>() { 
    { "A", "4"},
    { "B", "I3"},
    { "C", "["},
    { "D", ")"},
    { "MI", "3"},
    { "F", "|="},
    { "GRA", "&"},
    { "H", "#"},
    { "I", "1"},
    { "J", ",_|"},
    { "K", ">|"},
    { "L", "1"},
    { "MET", "/\\/\\"},
    { "NORT", "^/"},
    { "O", "0"},
    { "PAG", "|*"},
    { "Q", "(_,)"},
    { "R", "I2"},
    { "S", "5"},
    { "T", "7"},
    { "TU", "(_)"},
    { "V", "\\/"},
    { "W", "\\/\\/"},
    { "X", "><"},
    { "Y", "j"},
    { "Z", "2"}};

    string ins = Console.ReadLine().ToString();
    string txtEncryptado = string.Empty;

    foreach (var item in lenguaje)
    {
        ins = ins.ToLower().Replace(item.Key.ToLower(), item.Value);
    }
    
    Console.WriteLine(ins);
    Console.WriteLine(txtEncryptado);


