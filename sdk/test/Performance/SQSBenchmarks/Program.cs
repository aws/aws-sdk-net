using BenchmarkDotNet.Running;

if (args.Length > 0 && args[0] == "--verify-retry")
{
    await SQSBenchmarks.RetryVerification.RunAsync();
    return;
}

BenchmarkSwitcher.FromAssembly(typeof(SQSBenchmarks.SendMessageBenchmark).Assembly).Run(args);
