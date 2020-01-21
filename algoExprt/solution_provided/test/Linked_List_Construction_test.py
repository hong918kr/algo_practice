import Linked_List_Construction as program
import unittest


class StartNode:
	def __init__(self, value):
		self.value = value
		self.prev = None
		self.next = None

nodeClass = StartNode
if hasattr(program, "Node"):
	nodeClass = program.Node

class Node(nodeClass):
	pass

def expectEmpty(self, linkedList):
	self.assertEqual(linkedList.head, None)
	self.assertEqual(linkedList.tail, None)

def expectHeadTail(self, linkedList, head, tail):
	self.assertEqual(linkedList.head, head)
	self.assertEqual(linkedList.tail, tail)

def expectSingleNode(self, linkedList, node):
	self.assertEqual(linkedList.head, node)
	self.assertEqual(linkedList.tail, node)

def getNodeValuesHeadToTail(linkedList):
	values = []
	node = linkedList.head
	while node is not None:
		values.append(node.value)
		node = node.next
	return values


def getNodeValuesTailToHead(linkedList):
	values = []
	node = linkedList.tail
	while node is not None:
		values.append(node.value)
		node = node.prev
	return values


def removeNodes(linkedList, nodes):
	for node in nodes:
		linkedList.remove(node)



class TestProgram(unittest.TestCase):
	def test_case_1(self):
		linkedList = program.DoublyLinkedList()
		node = Node(1)

		linkedList.setHead(node)
		expectSingleNode(self, linkedList, node)
		linkedList.remove(node)
		expectEmpty(self, linkedList)
		linkedList.setTail(node)
		expectSingleNode(self,linkedList,node)
		linkedList.removeNodesWithValue(1)
		expectEmpty(self, linkedList)
		linkedList.insertAtPosition(1,node)




if __name__ == "__main__":
	unittest.main()



