﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ploeh.Samples.UserManagement
{
    public interface IUserLookupErrorVisitor<TResult>
    {
        TResult VisitInvalidId { get; }
        TResult VisitNotFound { get; }
    }
}
