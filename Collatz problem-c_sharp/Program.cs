namespace Program{
  class Program{
    static void Main(string[] args){
      bool rep_program = false;
      do{
        bool rep_input =false;
        int n = 1;
        Console.WriteLine("値を入力してください。");
        do{
          var input = Console.ReadLine();

          if (string.IsNullOrEmpty(input)){
            Console.WriteLine("正しい値を入力して下さい。1以上の整数。");
            rep_input = true;
          }else if(int.TryParse(input, out n)){
            rep_input = false;

            if (n <= 0){
            Console.WriteLine("正しい値を入力してください。1以上の整数。");
            rep_input = true;
          }
          }else{
            Console.WriteLine("正しい値を入力して下さい。1以上の整数。");
            rep_input = true;
          }
        }while(rep_input == true);

        while (n != 1){
          if (n % 2 == 0){
            //偶数の場合
            n /= 2;
          }else{
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
  }
}