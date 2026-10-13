// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Введите число: ");
// int number = int.Parse(Console.ReadLine());
// if (number > 0) {
//     Console.WriteLine("Число положительное.");
// }
// else if (number < 0) {
//     Console.WriteLine("Число отрицательное.");
// }
// else {
//     Console.WriteLine("Число равно нулю.");
// }

// Console.Write("Введите балл (0-100): ");
// int score = int.Parse(Console.ReadLine());
// if (score >= 91) {
//     Console.WriteLine("Оценка: Отлично (5)");
// }
// else if (score >= 71) {
//     Console.WriteLine("Оценка: Хорошо (4)"):
// }
// else if (score >= 51) {
//     Condole.WriteLine("Оценка: Удолетворительно (3)");
// }
// else {
//     Console.WriteLine("Оценка: Неудолетворительно (2)");
// }




// Console.Write("Введите количество посещений (из 19): ");
// int attendance = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите свой средний балл по практике: ");
// double practiceGpa = double.Parse(Console.ReadLine());
// bool goodAttendance = attendance >= 14;
// bool goodGrades = practiceGpa >= 3.0;

// if (goodAttendance && goodGrades) {
//     Console.WriteLine("+ Допуск к экзамену разрешен.");
// }
// else if (!goodAttendance && goodGrades) {
//     Console.WriteLine("- Недостаточно посещений. Нужно отработать пропуски.");
// }
// else if (goodAttendance && !goodGrades) {
//     Console.WriteLine("- Низкий балл по практике. Нужно пересдать работы.");
// }
// else {
//     Console.WriteLine("- Проблемы и с посещаемостью, и с оценками. Срочно к приподавателю.");
// }



// str result1;
// if (score >= 60)
//     result1 = "Зачет";
// else:
//     result1 = "Незачет";
// strintg result2 = score >= 60 ? "Зачет" : "Незачет";

// Console.WriteLine("Введите ваш возраст: ");
// int age = int.Parse(Console.ReadLine());
// string ageGroup = age >= 18 ? "Совершенно летний": "Несовершеннолетний";
// Console.WriteLine($"Вы {ageGroup}.");
// Console.Write("\nВведите температуру за окном(C): ");
// double temp = double.Parse(Console.ReadLine());
// string weather = temp >= 20 ? "тепло" : (temp >= 0 ? "Прохладно" : "Мороз");
// Console.WriteLine($"За окном {weather}.");

// Console.Write("\nВведите число: ");
// int n = int.Parse(Console.ReadLine());
// string parity = n % 2 == 0 ? "четное" : "нечетное";
// Console.WriteLine($"Число {n} - {parity}.");

// Console.WriteLine("Меню");
// Console.WriteLine("1. Посмотреть расписание");
// Console.WriteLine("2. Посмотреть оценки");
// Console.WriteLine("3. Связаться с преподавателем");
// Console.WriteLine("4. Выйти");
// Console.Write("Выберите пункт (1-4): ");

// String choice = Console.ReadLine();
// switch (choice) {
//     case "1":
//         Console.WriteLine("Расписание: ИСП-244, кабю 102, 08:30");
//         break;
//     case "2":
//         Console.WriteLine("Ваши оценки: ИРСПО - 20, РПМ -35");
//         break;
//     case "3":
//         Console.WriteLine("Email: denis.leuntev92@yandex.ru");
//         break;
//     default:
//         Console.WriteLine($"Ошибка: пункт '{choice}' не существует. Введите число от 1 до 4");
//         break;
// }
// Console.WriteLine("Введите от 1 до 12 (номер месяца) что бы увидеть время года");
// String mes = Console.ReadLine();

// switch (mes) {
//     case "12":
//     case "1":
//     case "2":
//         Console.WriteLine("Зима");
//         break;
//     case "3":
//     case "4":
//     case "5":
//         Console.WriteLine("Весна");
//         break;
//     case "6":
//     case "7":
//     case "8":
//         Console.WriteLine("Лето");
//         break;
//     case "9":
//     case "10":
//     case "11":
//         Console.WriteLine("Осень");
//         break;
// }

// 🎉
// 🔥 🌡 🌀 ❄ , , , , ↑, ↓

Random random = new Random();
int secret = random.Next(1, 101);

int attempts = 0;
bool guessed = false;

Console.WriteLine("Угадай число (1-100)");
Console.WriteLine("Я загадал число. попробуй угадать");



String GetHint(int difference) {
    switch (difference) {
        case <= 3:
            return "Горячо";
        case <= 10:
            return "Тепло";
        case <= 25:
            return "Прохладно";
        default:
            return "Холодно";
    }
}

while (!guessed) {
    Console.Write($"Попытка {attempts + 1}. Твой вариант: ");
    string input = Console.ReadLine();
    if (!int.TryParse(input, out int guess)) {
        Console.WriteLine("Введите целое число, а не текст");
        continue;
    }
    if (guess < 1 || guess > 100) {
        Console.WriteLine("Число должно входить в диапозон");
        continue;
    }

    if (guess < secret) {
        int diff = secret - guess;
        string hint = GetHint(diff);
        Console.WriteLine($"Больше {hint}\n");
    }
    else if (guess > secret) {
        int diff = guess - secret ;
        string hint = GetHint(diff);
        Console.WriteLine($"Меньше {hint}\n");
    }
    else {
        guessed = true;
    }
}
string result = attempts <= 7 ? $"Отличный результат! Всего {attempts} попыток." : $"Число найдено за {attempts} попыток. Можно лучше!";

Console.WriteLine($"Правильно, Загаданое число: {secret}");
Console.WriteLine($"{result}");
