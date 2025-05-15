using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
   [TestMethod]
// Scenario: Add items with different priorities and verify they come out in priority order
// Expected Result: High (3), Medium (2), Low (1)
// Defect(s): The bounds of the loop in the Dequeue function were not reaching the first or last item. The original code in Dequeue wasn't actually dequeueing the indexes.
public void TestPriorityQueue_1()
{
    var priorityQueue = new PriorityQueue();
    
    priorityQueue.Enqueue("Low", 1);
    priorityQueue.Enqueue("Medium", 2);
    priorityQueue.Enqueue("High", 3);
    
    Assert.AreEqual("High", priorityQueue.Dequeue());
    Assert.AreEqual("Medium", priorityQueue.Dequeue());
    Assert.AreEqual("Low", priorityQueue.Dequeue());
}

   [TestMethod]
// Scenario: Add items with same priority and verify FIFO order within same priority
// Expected Result: Items with equal priority should maintain FIFO order
// Defect(s): The comparison in dequeue used a '>=' instead of a '>'. This would break FIFO by taking the later item of equal priority.

public void TestPriorityQueue_2()
{
    var priorityQueue = new PriorityQueue();
    
    priorityQueue.Enqueue("First", 1);
    priorityQueue.Enqueue("Second", 1);
    priorityQueue.Enqueue("High Priority", 2);
    priorityQueue.Enqueue("Third", 1);
    
    Assert.AreEqual("High Priority", priorityQueue.Dequeue());
    
    Assert.AreEqual("First", priorityQueue.Dequeue());
    Assert.AreEqual("Second", priorityQueue.Dequeue());
    Assert.AreEqual("Third", priorityQueue.Dequeue());
}

    // Add more test cases as needed below.
}