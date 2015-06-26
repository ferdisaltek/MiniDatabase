# MiniDatabase

In this exercise you have to load a very simple database consisting of a single table. The database is stored in CSV format in a text file. Every line in that file has the following format:

<Username>;<First Name>;<Last Name>;<Department>;<Account End Date>;<Telephone Number>

Here is a concrete example:

cemadgzl;Ali;Veli;Sales;2015-12-31;+90 533 12345678

You can make the following assumptions about the input data:

  - The file will be stored in UTF-8 format and may contain non-ASCII characters in some fields.
   
  - The username field may only contain alphanumeric ASCII characters and will be between 6 and 10 characters long.
  
  - The first name and last name fields may contain sequences of alphabetic characters and will not be longer than 30 bytes UTF-8 encoded each.
  
  - The department field may contain any valid printable character and will not be longer than 20 bytes UTF-8 encoded.
  
  - The telephone numbers will be in the format shown above with the leading international prefix, spaces are allowed between the digits, but no other special characters. The field has a maximum capacity of 25 characters.
  
  - The account end date will be in ISO notation <year>-<month>-<day> as shown in the example.
  
Implement the following interface (remember you can use any language, this is only pseudo-code):

int loadData(string filename):

Opens the database file given via filename and reads all records line by line into appropriate data structures in memory.

Returns the number of records loaded.

record[] findByName(string firstname, string lastname):

Searches for matching records in memory and returns an array of matching record instances. The array should be sorted by end date.

record[] findByDepartment(string department):

Searches for all entries that match the given department name and returns an array of records. The array should be sorted by first name and last name.

record[] findByTelephoneNumber(string telephoneNumber):

Searches for matching records in memory and returns an array of matching record instances. Typically, the array will contain only a single record, we don’t expect two records to have the same telephone number, but it is possible.

record[] findByEndDate(date intervalStart, date IntervalEnd):

Searches for accounts that will expire within the interval given by intervalStart and intervalEnd. It is up to you to decide if the range should be inclusive or exclusive. Returns an array of records matching the search criteria. The array should be sorted by end date.

Additional Notes:

Assume that the working data set is kept resident in memory. Try to find ways to make look-ups fast, i.e. don’t do a linear search over all data sets every time.
