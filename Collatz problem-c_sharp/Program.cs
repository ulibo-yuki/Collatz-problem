namespace Program{
  class Program{
    static void Main(string[] args){
      Console.WriteLine("値を入力してください。");
      var input = Console.ReadLine();
      var n =0;
      if (string.IsNullOrEmpty(input)){
        Console.WriteLine("正しい値を入力してください。");
        //再入力は後日。
      }else{
        n = int.Parse(input);
      }

      while (n != 1){
        int k = Even_Odd(n);
        if (k == 0){
          //偶数の場合
          n /= 2;
        }if (k == 1){
          //奇数の場合
          n *= 3;
          n += 1;
        }
        Console.WriteLine(n);
      }
      Console.WriteLine("1に収束しました。");
      Console.ReadLine();
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