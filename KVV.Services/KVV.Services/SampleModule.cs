using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KVV.Services.Repositories;

namespace KVV.Services {
    public class SampleModule : Nancy.NancyModule {
        IClubRepository _clubRepository;

        public SampleModule() :this(new ClubRepository()) { }

        public SampleModule(IClubRepository clubRepository) {
            _clubRepository = clubRepository;

            var clubs = _clubRepository.GetClubs();
            Get["/"] = _ => View["index", clubs];

        }
    }
}