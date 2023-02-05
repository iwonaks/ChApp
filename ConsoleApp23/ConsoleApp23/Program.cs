int liczba = 488243;

string liczbaString = liczba.ToString();
char [] liczbaTab = liczbaString.ToArray();

int licznik0 = 0;
int licznik1 = 0;
int licznik2 = 0;
int licznik3 = 0;
int licznik4 = 0;
int licznik5 = 0;
int licznik6 = 0;
int licznik7 = 0;
int licznik8 = 0;
int licznik9 = 0;


foreach (char c in liczbaTab)
{
    if(c=='0')
    { licznik0++; }

    if (c=='0')
    { licznik0++; }

    if (c=='1')
    { licznik1++; }

    if (c=='2')
    { licznik2++; }

    if (c=='3')
    { licznik3++; }

    if (c=='4')
    { licznik4++; }

    if (c=='5')
    { licznik5++; }

    if (c=='6')
    { licznik6++; }

    if (c=='7')
    { licznik7++; }

    if (c=='8')
    { licznik8++; }

    if (c=='9')
    { licznik9++; }
}
Console.WriteLine("Twoja liczba to:  " + liczba + "\n skałada się z następujących ilości cyf");
Console.WriteLine("0-->" + licznik0 + "\n" + "1-->" + licznik1 + "\n" +"2-->" + licznik2 + "\n" +"3-->" + licznik3 + "\n" +"4-->" + licznik4 + "\n" +"5-->" + licznik5 + "\n" +"6-->" + licznik6 + "\n" +"7-->" + licznik7 + "\n" +"8-->" + licznik8 + "\n" +"9-->" + licznik9);