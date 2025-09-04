using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;

public class ServiceColumn : IColumn
{
    public virtual string Id => nameof(ServiceColumn);
    public virtual string ColumnName => "Service";
    public bool AlwaysShow => true;
    public ColumnCategory Category => ColumnCategory.Job;
    public virtual int PriorityInCategory => 0;
    public bool IsNumeric => false;
    public UnitType UnitType => UnitType.Dimensionless;

    public string Legend => "";

    public bool IsAvailable(Summary summary) => true;

    public virtual string GetValue(Summary summary, BenchmarkCase benchmarkCase)
    {
        var benchmarkObject = (BaseBenchmarks)Activator.CreateInstance(benchmarkCase.Descriptor.Type);
        return benchmarkObject.Service;
    }

    public string GetValue(Summary summary, BenchmarkCase benchmarkCase, SummaryStyle style)
        => GetValue(summary, benchmarkCase);

    public override string ToString() => ColumnName;

    public bool IsDefault(Summary summary, BenchmarkCase benchmarkCase)
    {
        return false;
    }
}

public class TestCaseColumn : ServiceColumn
{
    public override string Id => nameof(TestCaseColumn);
    public override string ColumnName => "Test Case";

    public override string GetValue(Summary summary, BenchmarkCase benchmarkCase)
    {
        var benchmarkObject = (BaseBenchmarks)Activator.CreateInstance(benchmarkCase.Descriptor.Type);
        var testCase = benchmarkObject.TestCase;

        return testCase;
    }
}

public class BenchmarkColumn : ServiceColumn
{
    public override string Id => nameof(BenchmarkColumn);
    public override string ColumnName => "Benchmark";
    public override string GetValue(Summary summary, BenchmarkCase benchmarkCase)
    {
        var displayInfo = benchmarkCase.Descriptor.WorkloadMethodDisplayInfo.Replace(" (ms)", "").Replace("'", "").Replace("'", "");
        return displayInfo;
    }
}