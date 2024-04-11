internal class Program
{
    private static void Main(string[] args)
    {
        int c;
        int d;
        Shoting();
        c = Add();
        d = Sub(5,4,2);
          }
//Phuong thuc khong tham so va khong gia tri tra ve
private static void Shoting()
{
    Console.WriteLine("Ban sung");
}
//Phuong thuc khong tham so va co gia tri tra ve
private static int Add()
{
    return 20;
}
//Phuong thuc co gia tri tra ve va co tham so
private static int Sub ( int a. int b, int c)
{
    return ((a-b)*c);
}
}