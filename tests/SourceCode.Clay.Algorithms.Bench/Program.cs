#region License

// Copyright (c) K2 Workflow (SourceCode Technology Holdings Inc.). All rights reserved.
// Licensed under the MIT License. See LICENSE file in the project root for full license information.

#endregion

using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;

namespace SourceCode.Clay.Algorithms.Bench
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var bench = new HuffmanBench();
            Summary summary = BenchmarkRunner.Run<HuffmanBench>();
        }
    }
}
