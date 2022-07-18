﻿using MapplesInterop.Classes.Core;
using MapplesInterop.Structs.MapplesStructs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MapplesInterop.Interfaces
{
    public interface IProcessManager
    {
        Process NewProcess(string lpApplication, string lpArguments, bool startSuspended = false);
        bool BlockDLLs(bool status);
        bool SetPPID(int pid);
        bool SetSpawnTo(string lpApplication, string lpCommandLine = null, bool x64 = true);
        ApplicationStartupInfo GetStartupInfo(bool x64 = true);
    }
}
