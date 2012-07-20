using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Simple.Data;
using KVV.Services.Models;

namespace KVV.Services.Repositories {
    public class ClubRepository : IClubRepository {
        public dynamic GetClubs() {
            var db = Database.Open();
            return db.TblClub
                .All()
                .Select(db.TblClub.sClubID.As("Id"), db.TblClub.sClubNaam.As("Name"));
                
        }
    }
}