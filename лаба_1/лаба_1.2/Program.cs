public class Solution
{
    // метод поиска всех уникальных комбинаций
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        IList<IList<int>> result = new List<IList<int>>();  // Создание списка для хранения комбинаций
        Array.Sort(candidates); // Сортировка массива candidates
        Backtrack(result, new List<int>(), candidates, target, 0); // Вызов метода поиска комбинаций
        return result;
    }

    // метод поиска комбинаций
    private void Backtrack(IList<IList<int>> result, List<int> tempList, int[] candidates, int targetCopy, int start)
    {
        if (targetCopy < 0)
        {
            return;
        }
        else if (targetCopy == 0)
        {
            result.Add(new List<int>(tempList));
        }
        else //продолжаем поиск комбинаций
        {
            for (int i = start; i < candidates.Length; i++)
            {
                if (i > start && candidates[i] == candidates[i - 1]) // Пропускаем дубликаты
                {
                    continue;
                }
                tempList.Add(candidates[i]);  // Добавляем число в временный список
                Backtrack(result, new List<int>(tempList), candidates, targetCopy - candidates[i], i + 1); // Рекурсивно вызываем Backtrack с обновленными параметрами
                tempList.RemoveAt(tempList.Count - 1); // Удаляем последнее число из временного списка
            }
        }
    }

    // данные + вывод
    static void Main()
    {
        int[] candidates = { 2, 3, 6, 7, 1 }; // массив
        int target = 15; //цель
        Solution solution = new Solution(); //ссылка
        
        IList<IList<int>> combinations = solution.CombinationSum(candidates, target);  // Вызываем метод CombinationSum для поиска комбинаций

        // Вывод
        Console.WriteLine($"Комбинации для {target}: ");
        foreach (var combination in combinations) //проходимся по комбинации
        {
            Console.WriteLine(string.Join(" ", combination)); //разделяем прорбелом
        }
    }
}