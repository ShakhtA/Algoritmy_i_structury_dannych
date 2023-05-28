void HeapiFy(int[] arr, int sizeArray, int root)
{
    int largest = root;
    int left = 2 * root + 1;
    int right = 2 * root + 2;

    if ((left < sizeArray) && (arr[largest] < arr[left]))
        largest = left;
    if ((right < sizeArray) && (arr[largest] < arr[right]))
        largest = right;

    if (root != largest)
    {
        int temp = arr[root];
        arr[root] = arr[largest];
        arr[largest] = temp;
        HeapiFy(arr, sizeArray, largest);
    }
}

void HeapSort(int[] arr)
{
    for (int i = arr.Length / 2 -1; i >= 0; i-- )
        HeapiFy(arr, arr.Length, i);
    for (int i = arr.Length - 1; i > 0; i--)
    {
        int temp = arr[0];
        arr[0] = arr[i];
        arr[i] = temp;
        HeapiFy(arr, i, 0);
    }
}




