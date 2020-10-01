public int[] BubbleSort (int[] array)
{
	var counter;
	
	do
	{
		counter = 0;
		var temp = new int();
		for (int i = 0; i < array.Length - 1; i++)
		{
			if (array[i] > array[i + 1])
			{
				temp = array[i];
				array[i] = array[i + 1];
				array[i + 1] = temp;
				counter++;
			}
		}
	}while (counter != 0)
}
