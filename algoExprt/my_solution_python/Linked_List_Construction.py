class Node:
	def __init__(self, value):
		self.value = value
		self.prev = None
		self.next = None

class DoublyLinkedList:
	def __init__(self):
		self.head = None
		self.tail = None

	def setHead(self, node):
		if self.head is None:
			self.head = node
			

	def setTail(self, node):
		pass
	
	def insertBefore(self, node, nodeToInsert):
		pass
	
	def insertAfter(self, node, nodeToInsert):
		pass
	
	def insertAtPosition(self, position, nodeToInsert):
		pass
	
	def removeNodesWithValue(self, value):
		pass
	
	def remove(self, node):
		pass
	
	def containsNodeWithValue(self, value):
		pass
	