using AWSSDK.Benchmarks;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Exporters.Csv;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet;
using Amazon.EC2;
using BenchmarkDotNet.Reports;

namespace AWSSDK.Benchmarks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var config = ManualConfig.Create(DefaultConfig.Instance);
            var summaryStyle = new SummaryStyle(
                cultureInfo: System.Globalization.CultureInfo.InvariantCulture,
                printUnitsInHeader: false,
                timeUnit: Perfolizer.Horology.TimeUnit.Millisecond, sizeUnit: Perfolizer.Metrology.SizeUnit.B);
            config.WithSummaryStyle(summaryStyle);
            //When exporting results, use milliseconds so that when pushing to cloudwatch we only have to parse ms
            var csvConfig = new SummaryStyle(
                cultureInfo: System.Globalization.CultureInfo.InvariantCulture,
                printUnitsInHeader: false,
                timeUnit: Perfolizer.Horology.TimeUnit.Millisecond, sizeUnit: Perfolizer.Metrology.SizeUnit.B);
            var csvExporter = new CsvExporter(CsvSeparator.CurrentCulture, csvConfig);
            config.AddExporter(csvExporter);

            config.AddColumn(StatisticColumn.P50);
            config.AddColumn(StatisticColumn.P90);
            config.AddColumn(StatisticColumn.P95);

            // Use BenchmarkSwitcher to support --filter across all benchmark classes.
            // This allows running specific benchmarks via:
            //   dotnet run -c Release -- --filter *EndpointResolution*
            //   dotnet run -c Release -- --filter *Marshall*
            //   dotnet run -c Release -- --filter *S3*
            // Without --filter, all benchmarks will run.
            BenchmarkSwitcher.FromTypes(new[]
            {
                typeof(EndpointResolutionBenchmarks),
                typeof(DynamoDBLatencyBenchmarks),
                typeof(S3ThroughputBenchmarks),
                typeof(MarshallAndUnmarshallBenchmarks),
                typeof(SQSBenchmarks),
                typeof(SNSBenchmarks),
                typeof(CloudwatchBenchmarks),
                typeof(CloudwatchLogsBenchmarks),
                typeof(S3Benchmarks),
                typeof(DynamoBenchmarks)
            }).Run(args, config);
        }
    }
}