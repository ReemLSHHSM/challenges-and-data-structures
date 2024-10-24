using C_BASICS.Trees;

public class Binary_Tree
{
    public TNode Root;
    public List<int> list;  // List for storing tree data

    public Binary_Tree(int data)
    {
        Root = new TNode(data);  // Initialize Root node
    }

    public void PreOrder(TNode node) // PreOrder Traversal
    {
        if (node == null) return;
        Console.Write(node.Data);
        PreOrder(node.Left);
        PreOrder(node.Right);
    }

    public void PostOrder(TNode node) // PostOrder Traversal
    {
        if (node == null) return;
        PostOrder(node.Left);
        PostOrder(node.Right);
        Console.WriteLine(node.Data);
    }

    public void InOrder(TNode node) // InOrder Traversal
    {
        if (node == null) return;
        InOrder(node.Left);
        Console.WriteLine(node.Data);
        InOrder(node.Right);
    }

    public void print(TNode node) // Helper method for printing the tree
    {
        if (node == null) return;
        Console.WriteLine(node.Data);
        print(node.Left);
        print(node.Right);
    }

 
    public TNode ConvertToBST()
    {
        if (this.Root == null)
        {
            return null;
        }

        list = new List<int>(); 
        ConvertToList(this.Root);
        list.Sort();
        return ConvertToBST(list, 0, list.Count - 1);  
    }

    public void ConvertToList(TNode node)
    {
        if (node == null)
        {
            return;
        }

        list.Add(node.Data);
        ConvertToList(node.Left);
        ConvertToList(node.Right);
    }

    public TNode ConvertToBST(List<int> list, int start, int end)
    {
        if (start > end)
        {
            return null;
        }

        int mid = start + (end - start) / 2;
        TNode node = new TNode(list[mid]);  

        node.Left = ConvertToBST(list, start, mid - 1);
        node.Right = ConvertToBST(list, mid + 1, end);

        return node;
    }
}
