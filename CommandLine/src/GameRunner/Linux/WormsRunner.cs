﻿using System;
using System.Threading.Tasks;

namespace Worms.GameRunner.Linux
{
    internal class WormsRunner : IWormsRunner
    {
        public Task RunWorms(params string[] wormsArgs)
        {
            return Task.Factory.StartNew(() => throw new PlatformNotSupportedException());
        }
    }
}
