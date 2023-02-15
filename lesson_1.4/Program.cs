Console.Write("Введите имя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша"){
    Console.WriteLine("Ура, Маша!");
}
else{
    Console.Write("Привет, " + username);
}