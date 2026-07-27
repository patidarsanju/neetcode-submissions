public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder sb = new();

        if(strs.Count == 0) return "";

        foreach(var str in strs){
            sb.Append(str.Length).Append( "#").Append( str);
        }
        return sb.ToString(); 
    }

    public List<string> Decode(string s) {
         var result= new List<String>();

         if(string.IsNullOrEmpty(s)) return result;

         ReadOnlySpan<Char> span = s.AsSpan();

          int i = 0;
          
          while(i< span.Length)
          {
            int del = span.Slice(i).IndexOf('#') + i; 
            int length = int.Parse(span.Slice(i, del-i));
            int strIndex = del+1; 
            result.Add(span.Slice(strIndex, length).ToString());
             
             i = strIndex +length;
          }
       return result;
   }
}
