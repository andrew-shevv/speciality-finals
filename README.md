## Решение задачи:

Нам задан массив строк, где необходимо найти все элементы, длина которых меньше или равна 3, и записать эти элементы в новый массив.

Для решения задачи я решил создать пустой массив (lessArray), по размерам соответствующий заданному, в который и буду записывать подходящие элементы.
Дальше, используя цикл for(i = 0; i < array.Length; i++), я проверяю все элементы заданного массива на соответствие условию задачи:
Если элемент подходит, он записывается в новый массив по соответствующему индексу.
В случае, если элемент не подходит, к счетчику прибавляется единица (этот счетчик будет использован позже).

По окончании цикла, новый массив заполняется всеми элементами, имеющими три или менее символа, однако, в большинстве случаев, результирующий массив будет иметь пустые значения в последних элементах. Для этого я и использовал счетчик, который записывал количество элементов заданного массива, не подходящих по условию задачи. С помощью функции Array.Resize(ref lessArray, lessArray.Length - count), я обрезаю результирующий массив, убирая пустые элементы.

После этого результирующий массив выводится в консоль.