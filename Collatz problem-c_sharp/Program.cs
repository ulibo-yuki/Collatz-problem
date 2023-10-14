namespace Program{
  class Program{
    static void Main(string[] args){
      Console.WriteLine("値を入力してください。");
      int n = int.Parse(Console.ReadLine());
      if (n == null || n == 1){
        Console.WriteLine("正しい値を入力してください。");
        n = int.Parse(Console.ReadLine());
      }

      while (n != 1){
        int k = Even_Odd(n);
        if (k == 0){
          n /= 2;
        }if (k == 1){
          n *= 3;
          n += 2;
        }
        Console.WriteLine(n);
        
      }
      Console.WriteLine("end.");
      
    }

    private static int Even_Odd (int i){
      i %= 2;
      if (i == 0){
        return 0;
      }else{
        return 1;
      }
    }
  }
}