using Microsoft.EntityFrameworkCore;

namespace Microsoft.AspNetCore.Hosting
{
    public interface ISeeder<T> where T : DbContext
    {
        void Seed(T DbContext);
    }
}
