
string name = "Iwona";
bool female = false;
int age = 15;

if (female==true)
{
    if (age>=30)
    {
        Console.WriteLine($"Jesteś kobietą o imieniu {name} i masz 30 lat z hakiem ;)");
    }
    else
    {
        Console.WriteLine($"Jesteś kobietą o imieniu {name} przed trzydziestką.");
    }

    if(name=="Iwona" && age==46)
    {
        Console.WriteLine($"Dokładnie: Kobieta o imieniu {name} w wieku {age} lat.");
    }
}

if (female==false)
{
    if (age>=18)
    {
        Console.WriteLine("Jesteś pełnoletnim mężczyzną.");
    }
    else
    {
        Console.WriteLine(" Jesteś jeszcze chłopaku niepełnoletni.");
    }
}