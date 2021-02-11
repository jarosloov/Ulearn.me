//  В поисках степени двойки    //
private static int GetMinPowerOfTwoLargerThan(int number)
{
	int result = 1;
	if (result > number)
		return result;
	int rank = 1;
	while (number >= result)
		result = (int)Math.Pow(2,rank++);
	return result;       
}