## Итоговая работа по первому блоку

### Белотелов Максим, группа 3595

### **Условие задачи**:
Написать программу, которая из имеющегося массива строк формирует массив строк, длина которых меньше либо равна 3 символа.

### **Решение**
Для решения задачи использутся язык С#.
В программе используются три метода:
1. >string[ ] InputArrayOfStrings( )
    
    Метод предназначен для формирования массива из строк, введенных пользователем. Метод не принимает аргументов и возвращает массив из строк. Для окончания ввода пользователь должен ввести пустую строку.

2. >void PrintArrayOfStrings(string[ ] array)

    Метод предназначен для вывода массива строк. В качестве аргумента принимает массив строк, содержимое которого необходимо вывести, возвращаемого значения нет. 

3. > string[] FindThreeSymbolsStrings(string[] inputArray)

    Метод предназначен для формирования массива из строк исходного массива, длина которых 3 или меньше символов. Принимает на вход массив строк и возвращает массив строк.

Задача решается последовательным вызовом перечисленных методов.