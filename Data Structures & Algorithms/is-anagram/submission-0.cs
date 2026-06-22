public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }

        var dictS = new Dictionary<char, int>();
        var dictT = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++) {
            if (!dictS.ContainsKey(s[i])) {
                dictS.Add(s[i], 1);
            }
            else {
                dictS[s[i]]++;
            }
        }

        for (int i = 0; i < t.Length; i++) {
            if (!dictT.ContainsKey(t[i])) {
                dictT.Add(t[i], 1);
            }
            else {
                dictT[t[i]]++;
            }
        }

        if (dictS.Count == dictT.Count) {
            foreach (var key in dictS.Keys) {
                if (!dictT.ContainsKey(key) || dictS[key] != dictT[key]) {
                    return false;
                }
            }
            return true;
        }
        else {
            return false;
        }
    }
}

