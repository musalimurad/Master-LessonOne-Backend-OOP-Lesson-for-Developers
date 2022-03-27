

//variables

string categoryTag = "Kateqoriler";
int studentCount = 3000;
double interestRate = 4.50;
bool isLogin = false;
double yesterdayCovid19 = 20.15;
double todayCovid19 = 25.20;

//Control Flows

if (isLogin==true)
{
    Console.WriteLine("Giris olunub");
}
else
{
    Console.WriteLine("giris olunmayib");
}

if (yesterdayCovid19 > todayCovid19)
{
    Console.WriteLine("covid19 yoluxanlar azalib");
}
else if (todayCovid19 > yesterdayCovid19)
{
    Console.WriteLine("covid19 yoluxanlar artib");

}
else
{
    Console.WriteLine("deyisiklik yoxdur");
}