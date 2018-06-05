﻿/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */

using System.Collections.Generic;
using Bind.Structures;

namespace Bind
{
    internal interface ISpecificationReader
    {
        void ReadDelegates(string file, DelegateCollection delegates, string apiname, string apiversion);
        void ReadEnums(string file, EnumCollection enums, string apiname, string apiversion);
        Dictionary<string, string> ReadAPITypeMap(string file);
        Dictionary<string, string> ReadLanguageTypeMap(string file);
    }
}
