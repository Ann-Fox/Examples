// Собрать строку с числами от a до b, a ≤ b

string NumberFor(int a, int b)
{
  string result = String.Empty;
  for (int i = a; i <= b; i++)
  {
    result += $"{i} ";
  }
  return result;
}

string NumbersRec(int a, int b)
{
  if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
  else return String.Empty;

  // На одну итерацию меньше.
  // if (a < b) return $"{a} " + NumbersRec(a + 1, b);
  // else return $"{b}";
}

Console.WriteLine(NumberFor(1, 10));
Console.WriteLine(NumbersRec(1, 10));