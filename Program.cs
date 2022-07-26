Console.Title = "TempConv";

Console.WriteLine("Input your parameters \"(degrees) (scale) -> (conversionScale)\"");
var input = Console.ReadLine().ToLower().Split();

var degrees = double.Parse(input[0]);
char inputScale = char.Parse(input[1].ToLower()), outScale = char.Parse(input[2]);

var converted = (double)0; // Degrees are converted from the input scale to degrees per Celsius
switch (inputScale)
{
    case 'f':
        converted = (degrees - 32) / 1.8;
        break;
    case 'c':
        converted = degrees;
        break;
    case 'k':
        converted = degrees - 274.15;
        break;
    case 'r':
        converted = (degrees / 1.8) - 273.15;
        break;
    default:
        throw new ArgumentException("Input scale undermined");
}

var result = (double)0; // Those degrees per Celsius are then converted to any other scale 
switch (outScale)
{
    case 'f':
        result = (converted * 1.8) + 32;
        break;
    case 'c':
        result = converted;
        break;
    case 'k':
        result = converted + 274.15;
        break;
    case 'r':
        result = (converted + 273.15) * 1.8;
        break;
    default:
        throw new ArgumentException("Output scale undermined");
}

Console.WriteLine("{0:F2} degrees {1} -> {2:F2} degrees {3}", degrees, inputScale, result, outScale);