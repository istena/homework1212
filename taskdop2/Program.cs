// Площадь треугольника
double fync (double xa,double ya,double xb,double yb){
    double ab=Math.Pow(Math.Pow((xb-xa),2)+Math.Pow((yb-ya),2),0.5);
    return ab;
}
double fync1 (double a,double b,double c){
    double p=0.5*(a+b+c);
    double s=Math.Pow(p*(p-a)*(p-b)*(p-c),0.5);
    return s;
}
Console.Clear();
Console.Write("Введите x a: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y a: ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите  x b: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y b: ");
double yb = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите  x c: ");
double xc = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y c: ");
double yc = Convert.ToDouble(Console.ReadLine());
double ab=fync (xa,ya,xb,yb);
double ac=fync (xa,ya,xc,yc);
double bc=fync (xc,yc,xb,yb);
double s=fync1 (ab,ac,bc);

Console.Write($"Площадь равна {s} ");
