// Разворот двухсвязного списка

public class List
{
    public class Node
    {
        Node head;
        Node tail;

        public void reverse()
        {
            Node currentNode = head;
            while (currentNode != null)
            {
                next = currentNode.next;
                prev = currentNode.prev;
                currentNode.next = prev;
                currentNode.prev = next;
                if (prev == null)
                    tail = currentNode;
                if (next == null)
                    head == currentNode;
                currentNode = currentNode.next;
            }
        }

        int value;
        Node next;
        Node prev;
    }
}
