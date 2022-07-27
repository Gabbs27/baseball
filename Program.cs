public int CalPoints(string[] ops){

    var s = new Stack<int>();
    foreach (var op in ops)
    {
if (int.TryParse(op, out int val))
        s.Push(val);
else if (op == "+")
{
    int elem1 = s.Pop();
    int elem2 = s.Pop();
    s.Push(elem2);
    s.Push(elem1);
    s.Push(elem1+elem2);
    
}
else if(op == "D")
{
    s.Push(s.Peek()*2);
    
}
else if(op == "c")
{
    s.Pop();
    
    }
    return s.Sum();
   
}
}


