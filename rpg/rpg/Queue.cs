using System;

class Queue
{
    private Node root;
    public void Push(Node node)
    {
        if (root == null)
        {
            root = node;
        }
        else
        {
            Node ptr = root;
            while (ptr.Left != null)
            {
                ptr = ptr.Left;
            }
            ptr.Left = node;
        }
    }
    public Node Pop()
    {
        Node node = root;
        if (root != null)
        {
            root = root.Left;
            node.Left = null;
        }
        return node;
    }
}