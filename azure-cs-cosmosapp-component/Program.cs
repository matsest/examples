﻿// Copyright 2016-2019, Pulumi Corporation.  All rights reserved.

using System.Threading.Tasks;

using Pulumi;
using Pulumi.Azure.Core;

class Program
{
    static Task<int> Main(string[] args)
    {
        return Deployment.RunAsync(VmScaleSets.Run);
    }
}