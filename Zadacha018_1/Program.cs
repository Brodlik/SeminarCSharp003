string [] ranges = 
{
    "x>0, y>0",
    "x<0, y>0",
    "x<0, y<0",
    "x>0, y<0",
};
Console.WriteLine ("Введите номер четверти: ");
int quater = Convert.ToInt32(Console.ReadLine());
if (quater>=0 && quater<=4)
Console.WriteLine (ranges[quater-1]);
else
{
    Console.WriteLine ("Нет такой четверти");
}