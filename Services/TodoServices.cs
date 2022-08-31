//export services
namespace Services;

public interface ITodoServices{
    List<Todo> GetAll(); // geting all current todos

    Todo Create(string title); // creating new todo
}            // TodoServices Var for ITodoServices
public class TodoServices : ITodoServices //Function For New Todo
{
    private List<Todo> _todos = new List<Todo>();//private only in this class
    public Todo Create(string title)// public is also outside the class
    {
        var todo = new Todo { Title = title, IsCompleted = false };
        _todos.Add(todo);
        return todo;
    }

    public List<Todo> GetAll()
    {
       return _todos;
    }
}