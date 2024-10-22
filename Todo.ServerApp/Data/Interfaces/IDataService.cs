namespace Todo.ServerApp.Data.Interfaces
{
    public interface IDataService
    {
        Task<IEnumerable<TaskItem>> GetTaskItemsAsync();
    }
}
