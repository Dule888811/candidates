﻿using Candidates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Candidates.Repository.IRepository
{
   public interface ICandidatesRepository
    {
        IQueryable<Candidate> Get();
        void AddCandidate(Candidate candidate);
    }
}
