using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue items with different priorities (Low, High, Medium).
    // Expected Result: High priority item is removed.
    // Defect(s) Found: The item was not actually removed from the queue after Dequeue.
    public void TestPriorityQueue_HighestPriority()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("Low", 1);
        pq.Enqueue("High", 5);
        pq.Enqueue("Medium", 3);

        var result = pq.Dequeue();
        Assert.AreEqual("High", result);
    }
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        Assert.Fail("Implement the test case and then remove this.");
    }

    [TestMethod]
    // Scenario: Enqueue two items with the same high priority (A, B).
    // Expected Result: The first one added (A) should be removed first (FIFO).
    // Defect(s) Found: The code picked the last high-priority item because of the >= operator.
    public void TestPriorityQueue_FIFO()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("A", 5);
        pq.Enqueue("B", 5);

        var result = pq.Dequeue();
        Assert.AreEqual("A", result);
    } 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        Assert.Fail("Implement the test case and then remove this.");
    }

    [TestMethod]
    // Scenario: Enqueue an item and try to dequeue. Then dequeue an empty queue.
    // Expected Result: Item returned, then InvalidOperationException thrown.
    // Defect(s) Found: Loop boundary (Count - 1) prevents finding the item if it's the last one.
    public void TestPriorityQueue_EmptyAndBoundary()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("OnlyItem", 1);
        
        Assert.AreEqual("OnlyItem", pq.Dequeue());

        try {
            pq.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        } catch (InvalidOperationException e) {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
    }
}
