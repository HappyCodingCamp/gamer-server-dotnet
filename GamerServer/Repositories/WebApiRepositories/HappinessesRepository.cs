using System.Collections.Generic;
using System.Linq;
using GamerServer.Models.Api;
using GamerServer.Models.Db;

namespace GamerServer.Repositories.WebApiRepositories
{
    public class HappinessesRepository : IWebApiRepository<HappinessRequest, HappinessResponse>
    {
        private GamerAiContext _dbContext;

        public HappinessesRepository(GamerAiContext dbContext)
        {
            _dbContext = dbContext;
        }

        public HappinessResponse Add(HappinessRequest request)
        {
            Happiness entity = EntityFromRequest(request);

            _dbContext.Happinesses.Add(entity);
            _dbContext.SaveChanges();

            return ResponseFromEntity(entity);
        }

        public HappinessResponse Update(int id, HappinessRequest request)
        {
            Happiness entity = GetById(id);

            if (entity == null)
            {
                return null;
            }
            
            entity.Level = request.Level;
            _dbContext.SaveChanges();

            return ResponseFromEntity(entity);
        }

        public HappinessResponse Delete(int id)
        {
            Happiness entity = GetById(id);
            
            if (entity == null)
            {
                return null;
            }

            HappinessResponse response = ResponseFromEntity(entity);

            _dbContext.Remove(entity);
            _dbContext.SaveChanges();

            return response;
        }

        public HappinessResponse Get(int id)
        {
            Happiness entity = GetById(id);

            if (entity == null)
            {
                return null;
            }

            return ResponseFromEntity(entity);
        }

        public IEnumerable<HappinessResponse> Get()
        {
            return _dbContext.Happinesses
                .ToList()
                .Select(ResponseFromEntity);
        }

        private Happiness GetById(int id)
        {
            return _dbContext.Happinesses.FirstOrDefault(e => e.HappinessId == id);
        }
        
        private Happiness EntityFromRequest(HappinessRequest request)
        {
            return new Happiness
            {
                Level = request.Level
            };
        }

        private HappinessResponse ResponseFromEntity(Happiness entity)
        {
            return new HappinessResponse
            {
                Id = entity.HappinessId,
                Level = entity.Level
            };
        }
    }
}