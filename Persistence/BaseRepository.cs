using pizza_management.Models;

namespace pizza_management.Patterns;

public class BaseRepository : IDisposable
{
    protected PizzaContext context;
    protected bool disposed = false;
    public BaseRepository(PizzaContext context)
    {
        this.context=context;
    }

    public void Dispose()
    {
        Dispose(true);
            GC.SuppressFinalize(this);
    }
    protected virtual void Dispose(bool disposing)
    {
        if (!this.disposed)
        {
            if (disposing)
            {
                context.Dispose();
            }
        }
        this.disposed = true;
    }
}