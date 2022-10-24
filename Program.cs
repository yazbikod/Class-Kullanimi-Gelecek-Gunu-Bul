using Class_HaftaGunu;


Haftagunu.GunBelirle();

Console.Write("Kaç gün eklenecek: ");
int hesapgunu = Convert.ToInt32(Console.ReadLine());

hesapgunu += Haftagunu.GetGun();

switch (hesapgunu % 7)
{
    case 1: Console.WriteLine("Next Day: Pazartesi"); break;
    case 2: Console.WriteLine("Next Day: Salı"); break;
    case 3: Console.WriteLine("Next Day: Çarşamba"); break;
    case 4: Console.WriteLine("Next Day: Perşembe"); break;
    case 5: Console.WriteLine("Next Day: Cuma"); break;
    case 6: Console.WriteLine("Next Day: Cumartesi"); break;
    case 7: Console.WriteLine("Next Day: Pazar"); break;
    default: Console.WriteLine("Yanlış değer girdiniz!"); break;
}