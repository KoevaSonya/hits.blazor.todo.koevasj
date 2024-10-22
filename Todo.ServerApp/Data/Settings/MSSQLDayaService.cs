using Microsoft.EntityFrameworkCore;
using Todo.ServerApp.Data.Interfaces;

namespace Todo.ServerApp.Data.Settings
{
    public class MSSQLDayaService(ApplicationDbContext context) : IDataService

    {
        public async Task<IEnumerable<TaskItem>> GetTaskItemsAsync()
        {
            
            return await context.TasksItems.ToArrayAsync();
        }
    }
}
