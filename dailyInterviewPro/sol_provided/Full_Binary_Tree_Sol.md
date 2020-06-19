# Given Solution Full Binary Tree


Some intuition for this problem is to solve it recursively per node, and if that node has two children or none, return the same node. If that node has 1 child, then we still have to recursively call its child (as that child could have nodes with 0 or 2 children). The assumption is the recursive call returns the correct left and right node, so we reassign the right and left nodes if the node has 2 children. With 1 children, we return the result of `fullBinaryTree(child)`.


```python

from collections import deque

class Node(object):
  def __init__(self, value, left=None, right=None):
    self.left = left
    self.right = right
    self.value = value
  def __str__(self):
    q = deque()
    q.append(self)
    result = ''
    while len(q):
      num = len(q)
      while num > 0:
        n = q.popleft()
        result += str(n.value)
        if n.left:
          q.append(n.left)
        if n.right:
          q.append(n.right)
        num = num - 1
      if len(q):
        result += "\n"

    return result

def fullBinaryTree(node):
  if not node:
    return None

  left = fullBinaryTree(node.left)
  right = fullBinaryTree(node.right)

  if ((left and right) or (not left and not right)):
    node.left = left
    node.right = right
    return node

  if left:
    return left

  if right:
    return right


# Given this tree:
#     1
#    / \ 
#   2   3
#  /   / \
# 0   9   4

# We want a tree like:
#     1
#    / \ 
#   0   3
#      / \
#     9   4

tree = Node(1)
tree.left = Node(2)
tree.right = Node(3)
tree.right.right = Node(4)
tree.right.left = Node(9)
tree.left.left = Node(0)
print fullBinaryTree(tree)
# 1
# 03
# 94

```


The time complexity of this solution is O`(n)` as every node is recursively called.

The space complexity of this solution is `O(logn)`, where `logn` is the height of the tree as each recursive call puts some memory on the stack.



