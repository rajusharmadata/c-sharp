using System.Reflection.Metadata.Ecma335;

class Prime{
   public bool PrimeNUM(int n){
       bool ans = true; 
        // exepation case ;
       for(int i = 2;i<n;i++){
            if (n%2==0){
                return false;// This line is the main logic error
       }
       }

    return ans;
       
    }
}