## Two Number Sum (Solution)

### Question

Write a function that takes in a non-empty array of distinct integers and an integer representing a target sum. If any two numbers in the input array sum up to the
target sum, the function should return them in an array, in sorted order. If no two numbers sum up to the target sum, the function should return an empty array.
Assume that there will be at most one pair of numbers summing up to the target sum.

`Sample input: [3, 5, -4, 8, 11, 1, -1, 6], 10
Sample output: [-1, 11]`



### Explanation



### Code Part
First Solution
[ O( n^2 ) Time || O( 1 ) Space ]
--> Go with `Brute Force`
```python
def twoNumberSum(array, targetSum):
	for i in range( len(array) - 1 ):
		firstNum = array[i]
		for j in range( i+1, len(array) ):
			secondNum = array[j]
			if (firstNum + secondNum) == targetSum:
				return [firstNum, secondNum]
	return []



```
--
Second Solution
[ O( n ) Time || O( n ) Space ]
--> Using `Dictionary`
```python
def twoNumberSum(array, targetSum):
	nums = {}
	for num in array:
		potentialMatch = targetSum - num
		if potentialMatch in nums:
			return sorted([potentialMatch, num])
		else:
			nums[num] = True
	return []
```
--
Third Solution
[ O( nlog(n) ) Time || O( 1 ) Space ]
--> Using `Binary Search`
```python
def twoNumberSum(array, targetSum):
	# it takes nlog(n)
	array.sort()

	# two pointer (first, last)
	left = 0
	right = len(array) - 1 

	# if left go over the right 
	# then all elem in arr is checked !
	while left < right:
		currentSum = array[left] + array[right]
		if currentSum == targetSum:
			return [array[left], array[right]]
		elif currentSum < targetSum:
			left += 1
		elif currentSum > targetSum:
			right -= 1
	return []


```
