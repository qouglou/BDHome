# Windows приложение для баз данных – ADO.NET
  Проект создан и представлен как учебный, в котором реализовано приложение для баз данных – ADO.NET, использующий инструментарий MS SQL Server, WinForms, C#

# Технология ADO.NET

  ADO.NET (ActiveX Data Object для .NET) — технология, предоставляющая доступ и управление данными, хранящимся в базе данных или других источниках, основанных на платформе .NET Framework и входящая в состав .NET Framework, представляет собой набор библиотек. ADO.NET нацелена на автономную работу с помощью объектов DataSet. Объекты DataSet представляют локальные копии взаимосвязанных таблиц данных, каждая из которых содержит набор строк и столбцов. Объекты DataSet позволяют вызывающей сборке работать с содержимым DataSet, изменять его, не требуя подключения к источнику данных, и отправлять обратно блоки измененных данных для обработки с помощью соответствующего адаптера данных. Типы, составляющие ADO.NET, используют протокол управления памятью CLR, принадлежат к той же системе типов (классы, интерфейсы, перечисления, структуры и делегаты), и доступ к ним возможен с помощью любого языка .NET.

# Запросы с параметрами (визуальные инструменты для баз данных)
  В некоторых случаях нужно создать запрос, который можно использовать многократно, на каждый раз с разными значениями. Например: можно часто запускать запрос, чтобы найти все title_ids , записанные одним автором, можно выполнять один запрос для каждого поиска, меняя только идентификатор автора.

  Чтобы создать запрос, который в разное время может иметь разные значения, используются параметры запроса. Параметр — это заполнитель для значения, которое предоставляется при запуске запроса. Инструкция SQL с параметром может выглядеть следующим образом, где «?» представляет параметр для идентификатора автора:
<code>
SELECT title_id
FROM titleauthor
WHERE (au_id = ?)
</code>

  Параметры можно использовать как метки-заполнители для литеральных значений — текстовых или числовых. Наиболее часто параметры используются в качестве меток-заполнителей в условиях поиска отдельных строк или групп строк (то есть в предложениях WHERE и HAVING инструкций SQL).

  Параметр можно использовать в качестве меток-заполнителей в выражениях. Например, можно вычислять цены со скидками, предоставляя различное значение скидки при каждом запуске запроса. Для этого нужно указать следующее выражение:
<code>(price * ?)</code>  

  Можно задать два типа параметров: неименованные и именованные. Неименованный параметр — это восклицательный знак, который можно подставлять в любое место запроса, в котором нужно запросить соответствующее литеральное значение. Например, если неименованный параметр используется для поиска идентификатора автора в таблице titleauthor , то полученная в результате инструкция на панели SQL может выглядеть следующим образом:
<code>
SELECT title_id  
FROM titleauthor  
WHERE (au_id = ?) 
</code>

  При выполнении запроса в конструкторе запросов и представленийв диалоговом окне Параметры запроса появляется "?" в качестве имени параметра.
  Можно также присвоить имя параметру. Именованные параметры особенно полезны, если в запросе имеется несколько параметров.
 
 Например, если именованный параметр используется для поиска имени и фамилии автора в таблице authors:
 <code>
use [Globin]
GO
CREATE PROCEDURE dbo.selectdata @Name nvarchar(30) = NULL, @Lname nvarchar(30) = NULL
AS
SELECT * FROM authors where au_lname = ISNULL(@Name, au_lname) AND au_fname = ISNULL(@Lname, au_fname)
GO
 </code>
  Окно вывода данных из таблицы 
 <div id="header" align="center">
  <img src="https://user-images.githubusercontent.com/64438506/227513931-2091a1ae-eefc-4255-82e9-43ec8e7b50b1.png" width="700"/>
</div>

# Вывод таблицы и поиск автора

Для вывода таблицы authors в окне программы была добавлена кнопка “Загрузить таблицу”. Результат ее нажатия показан на рисунке ниже.
 <div id="header" align="center">
  <img src="https://user-images.githubusercontent.com/64438506/227514074-d395986b-d69c-493b-b0de-b7b1aa6c9a5a.png" width="700"/>
</div>

Реализация метода, который выводит таблицу authors через кнопку "Загрузить таблицу", показана ниже
 <div id="header" align="center">
  <img src="https://user-images.githubusercontent.com/64438506/227514342-b5e80dd5-181e-4340-a3db-d2dc94ae824d.png" width="700"/>
</div>

Вывод конкретного автора с помощью <b>хранимой процедуры </b> с методом реализации хранимой процедуры показаны ниже
 <div id="header" align="center">
  <img src="https://user-images.githubusercontent.com/64438506/227514715-6a850b6b-47ab-4247-8466-2c16898ffb21.png" width="700"/>
</div>
 <div id="header" align="center">
  <img src="https://user-images.githubusercontent.com/64438506/227514778-2ec78fab-2cec-4a49-ba7d-8e0ec6edc58e.png" width="700"/>
</div>

Вывод конкретного автора с помощью <b>запроса, заданного в коде </b> с методом реализации показаны ниже
 <div id="header" align="center">
  <img src="https://user-images.githubusercontent.com/64438506/227515085-144ddaec-8a53-42a8-9f73-1abbb60a59f5.png" width="700"/>
</div>
 <div id="header" align="center">
  <img src="https://user-images.githubusercontent.com/64438506/227515129-3ca0bbd5-13b0-42cc-8b9d-6d2eabf22de6.png" width="700"/>
</div>

# Ввод запроса
В окно программы была добавлена строка ввода запроса:
 <div id="header" align="center">
  <img src="https://user-images.githubusercontent.com/64438506/227515415-bcf47802-bd04-4e69-8a7a-3d4c79947759.png" width="700"/>
</div>
И выполнен следующий запрос:
 <div id="header" align="center">
  <img src="https://user-images.githubusercontent.com/64438506/227515452-900b4731-491f-4a92-a6a5-5eb45bb6da94.png" width="700"/>
</div>
После выполнения запроса в программе отобразились авторы, проживающие в РФ:
 <div id="header" align="center">
  <img src="https://user-images.githubusercontent.com/64438506/227515587-acd8a146-99e8-4aa2-b926-f3f3197c847e.png" width="700"/>
</div>
Реализация строки, в которую вводится запрос:
<div id="header" align="center">
  <img src="https://user-images.githubusercontent.com/64438506/227515936-a5f5374a-4fc4-404e-9942-5c7328699eb6.png" width="700"/>
</div>

# Обработка ошибок
В программу была добавлена область вывода ошибок. Если ошибок нет, то выводится соответствующее сообщение “Ошибок нет”:
<div id="header" align="center">
  <img src="https://user-images.githubusercontent.com/64438506/227516005-99f02b45-1b71-402e-b188-2596a4434626.png" width="700"/>
</div>
Пример вывода окна с ошибками, при пустом запросе:
<div id="header" align="center">
  <img src="https://user-images.githubusercontent.com/64438506/227516149-e30a07b1-ab73-4cdb-bc71-edf21c9f2c0c.png" width="700"/>
</div>
Для показа работоспособности окна вывода ошибок был добавлен “неправильный” запрос, который вызовет ошибки:
<div id="header" align="center">
  <img src="https://user-images.githubusercontent.com/64438506/227516511-f1e52262-5df4-4d02-973e-691865715fdb.png" width="700"/>
</div>
Запрос, исполнение которого вызовет ошибку:
<div id="header" align="center">
  <img src="https://user-images.githubusercontent.com/64438506/227516548-f55ac21a-dcc0-4ba8-9f3f-7f767bf3169f.png" width="700"/>
</div>
Сообщение об ошибке в дополнительном окошке:
<div id="header" align="center">
  <img src="https://user-images.githubusercontent.com/64438506/227516588-ae1da77c-5411-44c7-b4ba-e32586225067.png" width="700"/>
</div>
Для большей наглядности, была добавлена хранимая процедура, которая должна вызвать ошибку:
<code>
USE [Globin]
GO
CREATE PROCEDURE [dbo].[wrong_procedure] @Name nvarchar(40) = NULL, @Lname nvarchar(20) = NULL, @Phone char(12)
AS
INSERT INTO authors values (100, @Name, @Lname, @Phone, NULL, NULL, NULL, NULL, 1)
GO
</code>
Передаваемые параметры в хранимую процедуру, вызывающую ошибки:
<div id="header" align="center">
  <img src="https://user-images.githubusercontent.com/64438506/227516858-9cb2f053-2815-4ed4-ac9a-aa497c0856ec.png" width="700"/>
</div>
Окно с выводом ошибки, вызванное выполнением хранимой “неправильной” процедуры:
<div id="header" align="center">
  <img src="https://user-images.githubusercontent.com/64438506/227516971-b9bac9e7-7d05-49c2-9b02-dc19718e0737.png" width="700"/>
</div>
Вывод сообщения об ошибке выполнения хранимой “неправильной” процедуры:
<div id="header" align="center">
  <img src="https://user-images.githubusercontent.com/64438506/227517054-9cd1dad2-de0b-40ff-839f-b70705414b01.png" width="700"/>
</div>
