using Amazon;
using Amazon.Echo;
using Amazon.Echo.Model;
using Amazon.Echo.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Util;
using BenchmarkDotNet.Attributes;
using System;
using System.Text;

namespace CborPerformanceBenchmarksRunner.EchoBenchmarks;

public class LongListOfStringsBenchmarks : AllTypesBenchmarks
{
    public override string TestCase { get; } = "Long list of strings";


    public override void GenerateRequest()
    {
        request = new EchoOperationRequest
        {
            ListOfStringsMember = Enumerable.Range(0, 264)
                                            .Select(_ => GenerateRandomASCIIString(64))
                                            .ToList(),
        };
    }
}