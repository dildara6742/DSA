namespace DataStructures;

public class LinkedList
{
    private Node Head { get; set; }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    public LinkedList() {
    }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.

    public int Get(int index)
    {
        if (this.Head != null)
        {

            int i = 0;

            // List with single node.
            if (index == 0)
                return this.Head.Value;

            // List with multiple nodes.
            Node current = this.Head;
            while (i < index)
            {
                if (current.Next == null)
                {
                    return -1;
                }
                current = current.Next;
                i++;
            }

            if (current == null)
            {
                return -1;
            }

            return current.Value;
        }
        else
        {
            return -1;
        }
    }
    
    public void AddAtHead(int val) {
        
        Node newNode = new Node();
        newNode.Value = val;
        
        // If the list is null
        if (this.Head != null)
        {
            newNode.Next = this.Head;
        }
        
        this.Head = newNode;
    }
    
    public void AddAtTail(int val) {
        
        Node newNode = new Node();
        newNode.Value = val;
        
        if (this.Head == null)
        {
            this.Head = newNode;
        }
        else
        {
            Node current = this.Head;
            while(current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }
    
    public void AddAtIndex(int index, int val)
    {
        if (index == 0)
        {
            AddAtHead(val);
        }
        else
        {
            if (this.Head != null && index > 0)
            {
                int i = 0;
                // List with multiple nodes.
                Node current = this.Head;
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                Node prev = null;
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                while (i <= index)
                {
                    if (i == index)
                    {
                        Node newNode = new Node();
                        newNode.Value = val;
#pragma warning disable CS8601 // Possible null reference assignment.
                        newNode.Next = current;
#pragma warning restore CS8601 // Possible null reference assignment.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                        prev.Next = newNode;
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                        break;
                    }
                    else
                    {
                        i++;
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                        prev = current;
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

#pragma warning disable CS8602 // Dereference of a possibly null reference.
                        if(current.Next == null)
                        {
                            if(i == index)
                            {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                                current = current.Next;
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                            }
                            else
                            {
                                break;
                            }
                        }
                        else
                        {
                            current = current.Next;
                        }
#pragma warning restore CS8602 // Dereference of a possibly null reference.

                    }
                }
            }
        }
    }
    
    public void DeleteAtIndex(int index) {
        if (this.Head != null)
        {
            int i = 0;
            
            // List with single node.
            if(index == 0)
                this.Head = this.Head.Next;
            
            // List with multiple nodes.
            Node current = this.Head;
            while(i < index && current.Next != null)
            {
                if( i == index-1)
                {   
                    if(current.Next == null)
                    {
                        current.Next = null;
                    }
                    else
                    {
                        current.Next = current.Next.Next;
                    }
                    break;
                }
                i++;
                current = current.Next;
            }
        }
    }

    public void Traverse()
    {
        Console.Write("List Values:");
        Node current = this.Head;
        while (current != null)
        {
            Console.Write(current.Value + ", ");
            current = current.Next;
        }
        Console.WriteLine();
    }
}

public class Node
{
    public int Value { get; set; }
    public Node Next { get; set; }
}
