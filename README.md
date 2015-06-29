# MiniDatabase

This program is coded in c # .

You will need visual studio 2013 to run .There are 2 different tables in the program.
Registration and registration inquiry.Fill in the fields to enter and save the record.
The records are saved in C://Temp/Db.csv location entered.If this folder does not exist, create it in the C:// directory.
Use Notepad++ to open the file Db.csv
Search query is done by selecting the desired area on the other statements made.
We want to make the search field with the ComboBox.

General description of the project, is available below.


In this exercise you have to load a very simple database consisting of a single table. The database is stored in CSV format in a text file. Every line in that file has the following format:

Username;First Name;Last Name;Department;Account End Date;Telephone Number

Here is a concrete example:

cemadgzl;Ali;Veli;Sales;2015-12-31;+90 533 12345678


Implement the following interface (remember you can use any language, this is only pseudo-code):

int loadData(string filename):

Opens the database file given via filename and reads all records line by line into appropriate data structures in memory.

Returns the number of records loaded.

record[] findByName(string firstname, string lastname):

Searches for matching records in memory and returns an array of matching record instances. The array  sorted by end date.

record[] findByDepartment(string department):

Searches for all entries that match the given department name and returns an array of records. The array  sorted by first name and last name.

record[] findByTelephoneNumber(string telephoneNumber):

Searches for matching records in memory and returns an array of matching record instances. Typically, the array will contain only a single record, we don’t expect two records to have the same telephone number, but it is possible.

record[] findByEndDate(date intervalStart, date IntervalEnd):

Searches for accounts that will expire within the interval given by intervalStart and intervalEnd. It is up to you to decide if the range should be inclusive or exclusive. Returns an array of records matching the search criteria. The array  sorted by end date.


