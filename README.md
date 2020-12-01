# AExTechnical

This application uses text files structured as per the
challenge spec; IP address followed by a colon, then a 
space and finally a comma separated list of values for each row.

Drop files like mentioned above in the bin/Debug/data folder
and use the file names in the console without the extensions to test. 

#Example

Enter name of first file:
>fileUno
Enter name of second file:
>fileDos
file1 (sorted, no duplicates): 1.2.3.4: 1,3,4 1.2.3.5: 6,7,8,9
file2 (sorted, no duplicates): 1.2.3.4: 4,5,6 1.2.3.6: 1
combined: 1.2.3.4: 1,3,4,5,6 1.2.3.5: 6,7,8,9 1.2.3.6: 1




fileUno.txt
1.2.3.4: 1,3,4
1.2.3.5: 9,8,7,6

fileDos.txt
1.2.3.4: 4,5,6
1.2.3.6: 1,1,1
