namespace Program{
  class Program{
    static void Main(string[] args){
      bool rep_program = false;
      do{
        bool rep_input =false;
        var n =0;
        Console.WriteLine("値を入力してください。");
        do{
          var input = Console.ReadLine();
          if (string.IsNullOrEmpty(input)){
          Console.WriteLine("正しい値を入力してください。");
          rep_input = true;
          }else{
          n = int.Parse(input);
          rep_input = false;
          if (n == 0){
            Console.WriteLine("0は整数ではありません。");
            rep_input = true;
          }
          }
        }while(rep_input == true);

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
        Console.WriteLine("もう一度計算しますか? y/n");
        var rep = Console.ReadLine();
        if (rep != null){
          if (rep == "y"){
            rep_program = true;
          }else{
            rep_program = false;
            Environment.Exit(0);
          }
        }else{
          Console.WriteLine("正しい値(y/n)を入力してください。");
        }
      }while(rep_program == true);
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