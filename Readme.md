# Итоговая контрольная работа по основному блоку

## 

**Шаг 1:** Инициализируем исходный массив `source` строками "Hello", "2", "world" и ":-)".

**Шаг 2:** Используем цикл `for`, чтобы найти количество строк в `source`, длина которых меньше или равна 3 символам. Для этого мы используем оператор `if`, чтобы проверить, является ли длина строки `source[i]` меньше или равна 3. Если да, то мы увеличиваем значение `count` на 1.

**Шаг 3:** Инициализируем новый массив `result` размером `count`. Этот массив будет содержать строки из `source`, длина которых меньше или равна 3 символам.

**Шаг 4:** Используем цикл `for`, чтобы пройти по `source` в обратном порядке. Для каждой строки мы используем оператор `if`, чтобы проверить, является ли ее длина меньше или равна 3. Если да, то мы добавляем строку в `result` в конец массива. После добавления строки мы уменьшаем значение `count` на 1, чтобы избежать повторного добавления строки.

**Шаг 5:** Используем метод `Join()`, чтобы объединить элементы `result` в строку, разделенную запятыми. Затем мы выводим эту строку на консоль.

**Пример:**
