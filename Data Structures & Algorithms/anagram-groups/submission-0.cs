public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var groups = new Dictionary<string, List<string>>();

        foreach (var str in strs) {
            char[] count = new char[26];

            foreach (var ch in str) {
                count[ch - 'a']++;
            }

            string key = new string(count);

            if (!groups.ContainsKey(key))
                groups[key] = new List<string>();
            
            groups[key].Add(str);
        }

        return new List<List<string>>(groups.Values);
    }
}
