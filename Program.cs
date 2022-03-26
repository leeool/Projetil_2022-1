const double gravidade = 9.80665;
double velocidade, angulo, angulorad, alcance, alturamax;

Console.Write("Entre com a velocidade, em m/s..: ");
velocidade = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Entre com o ângulo, em graus....: ");
angulo = Convert.ToDouble(Console.ReadLine()!);

angulorad = angulo * Math.PI / 180;

alcance = (Math.Pow(velocidade, 2) * Math.Sin(angulorad * 2)) / gravidade;
alturamax = Math.Pow(velocidade * Math.Sin(angulorad), 2) / (2 * gravidade);

Console.WriteLine($"Alcance........: {alcance:N2}");
Console.WriteLine($"Altura máxima..: {alturamax:N2}");
