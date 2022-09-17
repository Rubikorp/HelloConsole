int[] array = {1, 2, 3, 31, 4, 56, 2, 12};

int n = array.Length;
int find = 2;

int index = 0;

while (index < n) {
    if(array[index] == find) {
        Console.WriteLine(index);
        break;
    }

    index++;
}