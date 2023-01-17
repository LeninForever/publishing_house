# publishing_house
Desktop-приложение для работы с базой даннных литературного издательства.
База данных представляет собой 9 таблиц, в которых содержится информация о книгах, авторах, художниках, редакторах и книжных магазинах. Также две служебные таблицы с логами операций.
В приложении имеется две роли: обычный пользователь и администратор. (Роли реализованы на стороне СУБД)
Обычный пользователь может получать данные из всех таблиц (кроме таблиц с логами), делать выборки по различным критериям, сортировать данные, а также выводить их на печать.
Администратор обладает возможностями обычного пользователя, а также может изменять данные и имеет доступ к таблицам с логами.
Написано приложение в качестве курсовой работы в крайне сжатые сроки, поэтому код написан сплошным полотном.
Дата: 03.01.2022-10.01.2022
