double COFFEE_RATIO = 6.4;
double WATER_RATIO = 100;

for (double i = 1; i <= 10; i += 0.5) {
    Console.WriteLine(i);
    Console.WriteLine($"Coffee: {i * COFFEE_RATIO:#.#}g");
    Console.WriteLine($"Water: {i * WATER_RATIO}g");

    if (i < 10)
        Console.WriteLine();
}