namespace Todo.Models;
public static class Respository
{
    private static int _currentId = 1;
    private static List<Todo> _todolist = new List<Todo>();
    public static IEnumerable<Todo> todolist => _todolist; //return veef todolist

    //viet ham tuowgn tac voi no

    public static void AddTodo(Todo _todo)
    {
        _todo.Id = _currentId;
        _todolist.Add(_todo);
        _currentId ++;

    }

    //xoas
    public static void RemoveTodo( int Id)
    {
       var _itemIndex = _todolist.FindIndex(d=> d.Id == Id);
       if(_itemIndex >0){
           _todolist.RemoveAt(_itemIndex);
       }
    }

    //capnhat
    public static void UpdateTodo(int Id, Todo _todo)
    {
        var _current = _todolist.FirstOrDefault<Todo>(d => d.Id == _todo.Id); //firstordefault tim 1 cai, find la tim nhieu
        if (_current != null)
        {
            _current.Content = _todo.Content;
            _current.Time = _todo.Time;
        }
    }

    //checked da hoan thanh
    public static void CheckDone(int Id){
        var _item = _todolist.FirstOrDefault<Todo>(d=>d.Id == Id);
        if(_item !=null){
            _item.isDone = true;
        }
    }

}