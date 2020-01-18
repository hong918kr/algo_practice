# Given Solution Decode String


There are 2 main cases when iterating through the string. If we encounter a letter, add that letter to our result string. If we encounter a number, it means we should start decoding that part of the string until we reach an end bracket.

First parse the number, and then for the first open bracket, we keep track of the bracket count until we've found the matching closing bracket (as there can be nested brackets), and then recursively solve that string by calling `decodeString` again. Then for the resulting string returned we multiply that by the number of times specified and add that to the result string.


```python

def decodeString(s):
  res = ""
  i = 0
  while i < len(s):
    if s[i].isalpha():
      res += s[i]
      i += 1
      continue

    if s[i].isdigit():
      # get the number
      num = 0
      while s[i].isdigit():
        num = num * 10 + int(s[i])
        i += 1
      # parse string in bracket
      bracket = 1
      i += 1
      innerstr = ""
      while bracket > 0:
        if s[i] == '[':
          bracket += 1
        if s[i] == ']':
          bracket -= 1
        innerstr += s[i]
        i += 1
      res = res + num * decodeString(innerstr[:-1])

  return res

print decodeString('2[a2[b]c]')
# abbcabbc

```


The time complexity of this solution is `O(n)`, as string iteration is used. The space complexity of this solution is `O(n)` to store the new result string.




