﻿using MapplesInterop.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Pipes;
using MapplesInterop.Classes.Api;
using MapplesInterop.Classes.Core;

namespace MapplesInterop.Interfaces
{
    public interface IApi
    {
        T GetLibraryFunction<T>(Library library, string functionName, bool canLoadFromDisk = true, bool resolveForwards = true) where T : Delegate;
        T GetLibraryFunction<T>(Library library, short ordinal, bool canLoadFromDisk = true, bool resolveForwards = true) where T : Delegate;
        T GetLibraryFunction<T>(Library library, string functionHash, long key, bool canLoadFromDisk=true, bool resolveForwards = true) where T : Delegate;

        string NewUUID();

        RSAKeyGenerator NewRSAKeyPair(int szKey);

        // Maybe other formats in the future?
        ICryptographySerializer NewEncryptedJsonSerializer(string uuid, Type cryptoType, string key = "");
        
    }
}
