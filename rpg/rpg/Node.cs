using System;

class Node
{
    public string skillname;

    public Node Left;

    public Node(string name)
    {
        this.skillname = name;
    }

    public override string ToString()
    {
        return skillname;
    }
}