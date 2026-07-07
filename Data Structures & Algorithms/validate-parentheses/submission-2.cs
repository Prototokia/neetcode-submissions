 public class Solution {
     public bool IsValid(string s) {
         var stack = new Stack<char>();

         foreach (var ch in s) {
             if (ch == '[' || ch == '(' | ch == '{') {
                 stack.Push(ch);
             }

             if (ch == ']') {
                 if (stack.Count == 0)
                     return false;
                 if (stack.Pop() != '[')
                     return false;
             }

             if (ch == ')') {
                 if (stack.Count == 0)
                     return false;
                 if (stack.Pop() != '(')
                     return false;
             }

             if (ch == '}') {
                 if (stack.Count == 0)
                     return false;
                 if (stack.Pop() != '{')
                     return false;
             }

         }

         if (stack.Count > 0 && (stack.Peek() == '(' || stack.Peek() == '[' || stack.Peek() == '{'))
             return false; ;
         return true;

     }
 }