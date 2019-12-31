﻿using System.Collections.Generic;

namespace SEP.Data.Common
{
    public interface IQueryHandler
    {
        QueryHandler.Condition GetID();
        bool CheckID(KeyValuePair<string, object> item);
        string GetCondition();
        string GetEntity();
        string GetAllCondition();
        string GetListPropertyName();
        string GetListValue();
    }
}