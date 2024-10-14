using SharedKernel;

namespace Domain.Todos;

public static class TodoItemErrors
{
    public static Error NotFound(Guid todoItemId) => Error.NotFound(
        "TodoItems.NotFound",
        $"The to-do item with the Id = '{todoItemId}' was not found");
}
