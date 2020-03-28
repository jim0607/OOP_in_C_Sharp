C# variables or primitive data types: 

var, bool, string, int, uint  (unsigned int, meaning only positive int), short, long, ushort, ulong, float, double 

Eg: float num1 = 3.14f; var num2 = 3.14d; int num3 = int.MaxValue 

If we look at the last example, we will notice that we treat everything as an object in C#, even including very primitive data types.    .MaxValue is just a method or property of int object. 

The above primitive data types just like atoms in Chemistry class and cannot be dis-constructed into smaller pieces.  These primitive data types are what makes the more complicated structures and objects. 

Create a constant number: const float pi = 3.14fl; 

2. Dictionary:
 - 新建一个Dictionary, key是int, value是一个DLLNode: Dictionary<int, DLLNode> dict = new Dictionary<int, DLLNode>();
 - check if key is in a dicitonary: dict.ContainsKey(key)
 - size of dictionary: dict.Count() (相当于len(dict))
 - remove a (key, value) pair in dictionary: dict.Remove(key);
 
 
 3. Queue:
 - 新建一个Queue: Queue <int> q = new Queue <int> ();
 - q.Equeue(val) (相当于q.append(val));  q.Dequeu() (相当于q.pop());   q.Count() (相当于len(q))
