using Dragon.Data;
using Dragon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragon.Services
{
    public class DragonService
    {
        private readonly Guid _userId;

        public DragonService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateDragon(DragonCreate model)
        {
            var entity =
                new DragonEntity()
                {
                    OwnerId = _userId,
                    DragonName = model.DragonName,
                    DragonColor = model.DragonColor,
                    DragonDescription = model.DragonDescription,
                    BirthOfDragon = DateTimeOffset.Now
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Dragons.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<DragonListItem> GetDragons()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Dragons
                        .Where(e => e.OwnerId == _userId)
                        .Select(
                            e =>
                                new DragonListItem
                                {
                                    DragonId = e.DragonId,
                                    DragonName = e.DragonName,
                                    BirthOfDragon = e.BirthOfDragon,
                                    DragonColor = e.DragonColor,
                                    DragonDescription = e.DragonDescription

                                }
                        );
                return query.ToArray();
            }
        }
    }
}
