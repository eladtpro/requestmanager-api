﻿using System;

namespace RequestManager.Model
{
    [Flags]
    public enum DistributionType
    {
        Default = 0,
        Broadcust = 1,
        Manager = 2,
        Silent = 4
    }
}