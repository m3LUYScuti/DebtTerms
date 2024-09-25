using System.ComponentModel.Design;

Console.WriteLine("Sesxis misagebad sheiyvanet tqveni monacemebi");
Console.WriteLine("Asaki:");

int Asaki = int.Parse(Console.ReadLine());

Console.WriteLine("Wliuri Shemosavali $shi (chaweret mxolod cifrebi)");

int Shemosavali = int.Parse(Console.ReadLine());

if (Asaki <= 17)

    Console.WriteLine("Arasrulwlovanze sesxi ar gaicema");

else if (Shemosavali >= 25000)
{
    Console.WriteLine("Sesxi dagimtkicdat");
}
else if (Shemosavali <= 25000)
{
    Console.WriteLine("Sesxistvis arasakmarisi wliuri Shemosavali");
    Console.WriteLine("Imistvis rom aigot sesxi sachiroa tanamonawile");
    Console.WriteLine("Gyavt tu ara tanamonawile? (upasuxed mxolod 'Ki' da 'Ara' ) ");
    string tanamonawile = Console.ReadLine();
    if (tanamonawile == "Ki")
        Console.WriteLine("Tqven shegidzliat TanamonawilesTan ertad aigot sesxi");

    else if (tanamonawile == "Ara")
        Console.WriteLine("Samwuxarod sesxze uari getqvat");
}
else Console.WriteLine("Gtxovt swored sheiyvanot pasuxi");

Console.ReadLine(); 