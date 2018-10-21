using System.Collections.Generic;

namespace GamerServer.Repositories
{
    public interface IWebApiRepository<Request, Response>
    {
        Response Add(Request request);
        Response Update(int id, Request request);
        Response Delete(int id);
        Response Get(int id);
        IEnumerable<Response> Get();
    }
}
