/*using System;


class MainClass {

  public static string StringChallenge(string str) {

    // code goes here 
    char[] charArray = new char[str.Length];
    for(int i = 0; i <= str.Length-1; i++) {
    charArray[i] = str[i];
    }

    for(int i = 0; i<=charArray.Length-1; i++) {

        if(char.IsUpper(charArray[i])) {
            charArray[i] = char.ToLower(charArray[i]);
        }
        
        else if(char.IsLower(charArray[i])) {
            charArray[i] = char.ToUpper(charArray[i]);
        }
    }

    str = new string(charArray);

    return str;

  }

  static void Main() {  

    // keep this function call here
    Console.WriteLine(StringChallenge("Hello"));
    
  } 

}
*/

using System;

class MainClass {

  public static int ArrayChallenge(int[] arr) {

    // code goes here  
    for (int i = 0;i<= arr.Length-1 ; i++){
        if(arr[i] == 1){
            for(int j = 0; j<i ;j++){
                j
            }
        }
    }
    
    return arr[0];

  }

  static void Main() {  

    // keep this function call here
    Console.WriteLine(ArrayChallenge(new int[] {1, 0, 0, 0, 2, 2, 2}));
    
  } 

}