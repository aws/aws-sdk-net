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
                timeUnit: Perfolizer.Horology.TimeUnit.Millisecond, sizeUnit: SizeUnit.B);
            config.WithSummaryStyle(summaryStyle);
            //When exporting results, use milliseconds so that when pushing to cloudwatch we only have to parse ms
            var csvConfig = new SummaryStyle(
                cultureInfo: System.Globalization.CultureInfo.InvariantCulture,
                printUnitsInHeader: false,
                timeUnit: Perfolizer.Horology.TimeUnit.Millisecond, sizeUnit: SizeUnit.B);
            var csvExporter = new CsvExporter(CsvSeparator.CurrentCulture, csvConfig);
            config.AddExporter(csvExporter);

            config.AddColumn(StatisticColumn.P50);
            config.AddColumn(StatisticColumn.P90);
            config.AddColumn(StatisticColumn.P95);

            BenchmarkRunner.Run<SQSBenchmarks>(config);
            BenchmarkRunner.Run<SNSBenchmarks>(config);
            BenchmarkRunner.Run<CloudwatchBenchmarks>(config);
            BenchmarkRunner.Run<CloudwatchLogsBenchmarks>(config);
            BenchmarkRunner.Run<MarshallAndUnmarshallBenchmarks>(config);
            BenchmarkRunner.Run<S3Benchmarks>(config);
            BenchmarkRunner.Run<DynamoBenchmarks>(config);




        }
    }
}