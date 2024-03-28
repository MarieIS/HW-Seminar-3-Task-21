double GetDistance(double x1, double y1, double z1, double x2, double y2, double z2){
    return Math.Sqrt(Math.Pow((x2-x1), 2)+Math.Pow((y2-y1), 2)+Math.Pow((z2-z1), 2));
}

double GetCoordinate(string message){
    Console.Write(message);
    return Convert.ToDouble(Console.ReadLine());
}

double xA = GetCoordinate("set X1: ");
double yA = GetCoordinate("set Y1: ");
double zA = GetCoordinate("set Z1: ");
double xB = GetCoordinate("set X2: ");
double yB = GetCoordinate("set Y2: ");
double zB = GetCoordinate("set Z2: ");
double distance = GetDistance(xA, yA, zA, xB, yB, zB);
Console.WriteLine($"the distance is {distance}");