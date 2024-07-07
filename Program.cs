// See https://aka.ms/new-console-template for more information
/*
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

string[] array = {"Hello", "world", "2", "32", "the", "dog", "Russia"};
string [] result = new string[array.Length]; 
int index = 0;
for(int i = 0; i < array.Length - 1; i++) {
    if(array[i].Length <= 3) {
        result[index++] = array[i];
    }
}

