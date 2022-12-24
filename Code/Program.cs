string[] array = { "hello", "2", "world", ":))" };

int new_size = 0;
int max_lenght = 3;
string[] temp_array = new string[array.Length];

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= max_lenght)
    {
        temp_array[i] = array[i];
        new_size++;
    }
}

string[] new_array = new string[new_size];
int new_index = 0;

for (int i = 0; i < temp_array.Length; i++)
{
    if(temp_array[i] != null)
    {
        new_array[new_index] = temp_array[i];
        new_index++;
    }
}