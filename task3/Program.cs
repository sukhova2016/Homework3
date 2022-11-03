static void distance(float x1, float y1,
                     float z1, float x2,
                     float y2, float z2)                  
{
    double d = Math.Sqrt(Math.Pow(x2 - x1, 2) +
                         Math.Pow(y2 - y1, 2) +
                         Math.Pow(z2 - z1, 2));
    Console.WriteLine("Distance is \n" + d);
    return;
}
    float x1 = 7;
    float y1 = -5;
    float z1 = 0;
    float x2 = 1;
    float y2 = -1;
    float z2 = -9;
    distance(x1, y1, z1,
             x2, y2, z2);  
