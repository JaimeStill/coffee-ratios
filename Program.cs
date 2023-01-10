double COFFEE_RATIO = 8;
double WATER_RATIO = 150;

Console.WriteLine("Coffee | Water");
Console.WriteLine("-------|------");

for (double i = 1; i <= 10; i += 0.5) {
    Console.WriteLine($"{i * COFFEE_RATIO:#.#}g | {i * WATER_RATIO}g");
}
