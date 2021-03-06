﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace EFCore.Sharding.Util
{
    internal static class AnnotationHelper
    {
        public static string GetDbTableName(Type type)
        {
            var tableAttribute = type.GetCustomAttribute<TableAttribute>();
            string tableName;
            if (tableAttribute != null)
                tableName = tableAttribute.Name;
            else
                tableName = type.Name;

            return tableName;
        }
    }
}
