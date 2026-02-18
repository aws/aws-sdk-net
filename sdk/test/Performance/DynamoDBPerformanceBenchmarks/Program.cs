using Amazon.DynamoDBv2;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Exporters.Csv;
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Attributes;

namespace AWSSDK.Benchmarks.MockedDynamoDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var (clientMode, overrides, benchmarkNames, remainingArgs) = ParseArguments(args);
            var effectiveOverrides = overrides ?? CreateDefaultOverrides();
            ConfigureRuntime(clientMode, effectiveOverrides);

            var config = ManualConfig.Create(DefaultConfig.Instance);
            var summaryStyle = new SummaryStyle(
                cultureInfo: System.Globalization.CultureInfo.InvariantCulture,
                printUnitsInHeader: false,
                timeUnit: Perfolizer.Horology.TimeUnit.Millisecond, sizeUnit: SizeUnit.B);
            config.WithSummaryStyle(summaryStyle);
            var csvConfig = new SummaryStyle(
                cultureInfo: System.Globalization.CultureInfo.InvariantCulture,
                printUnitsInHeader: false,
                timeUnit: Perfolizer.Horology.TimeUnit.Millisecond, sizeUnit: SizeUnit.B);
            var csvExporter = new CsvExporter(CsvSeparator.CurrentCulture, csvConfig);
            config.AddExporter(csvExporter);

            config.AddColumn(StatisticColumn.P50);
            config.AddColumn(StatisticColumn.P90);
            config.AddColumn(StatisticColumn.P95);

            var switcher = benchmarkNames?.Length > 0
                ? BenchmarkSwitcher.FromTypes(ResolveBenchmarkTypes(benchmarkNames))
                : BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly);

            switcher.Run(remainingArgs, config);
        }

        private static (string? clientMode, BenchmarkParameterOverrides? overrides, string[]? benchmarkNames, string[] remainingArgs) ParseArguments(string[] args)
        {
            string? clientMode = null;
            BenchmarkParameterOverrides? overrides = null;
            string[]? benchmarkNames = null;
            var remainingArgs = new List<string>(args.Length);
            for (var i = 0; i < args.Length; i++)
            {
                var arg = args[i];
                if (arg.StartsWith("--client=", StringComparison.OrdinalIgnoreCase))
                {
                    clientMode = arg["--client=".Length..];
                    continue;
                }

                if (string.Equals(arg, "--client", StringComparison.OrdinalIgnoreCase) && i + 1 < args.Length)
                {
                    clientMode = args[++i];
                    continue;
                }

                if (TryParseValue(arg, i + 1 < args.Length ? args[i + 1] : null, "--benchmarks", out var benchmarksValue, out var consumedNext))
                {
                    benchmarkNames = benchmarksValue.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
                    if (consumedNext)
                    {
                        i++;
                    }
                    continue;
                }

                if (TryParseOverride(arg, i + 1 < args.Length ? args[i + 1] : null, out var applyOverride, out consumedNext))
                {
                    overrides ??= new BenchmarkParameterOverrides();
                    applyOverride(overrides);
                    if (consumedNext)
                    {
                        i++;
                    }
                    continue;
                }

                remainingArgs.Add(arg);
            }

            return (clientMode, overrides, benchmarkNames, remainingArgs.ToArray());
        }

        private static Type[] ResolveBenchmarkTypes(string[] benchmarkNames)
        {
            var benchmarks = typeof(Program).Assembly
                .GetTypes()
                .Where(type => type.IsClass
                    && type.GetMethods().Any(method => method.GetCustomAttributes(typeof(BenchmarkAttribute), inherit: true).Any()))
                .ToArray();

            var selected = benchmarks
                .Where(type => benchmarkNames.Any(name => string.Equals(type.Name, name, StringComparison.OrdinalIgnoreCase)
                    || string.Equals(type.FullName, name, StringComparison.OrdinalIgnoreCase)))
                .ToArray();

            if (selected.Length == 0)
            {
                throw new InvalidOperationException("No benchmarks matched the provided --benchmarks values.");
            }

            return selected;
        }

        private static bool TryParseOverride(string arg, string? nextArg, out Action<BenchmarkParameterOverrides> applyOverride, out bool consumedNext)
        {
            applyOverride = _ => { };
            consumedNext = false;

            if (TryParseValue(arg, nextArg, "--itemSize", out var value, out consumedNext)
                && Enum.TryParse<BenchmarkItemSize>(value, ignoreCase: true, out var itemSize))
            {
                applyOverride = overrides => overrides.ItemSize = itemSize;
                return true;
            }

            if (TryParseValue(arg, nextArg, "--attributeCount", out value, out consumedNext)
                && Enum.TryParse<BenchmarkAttributeCount>(value, ignoreCase: true, out var attributeCount))
            {
                applyOverride = overrides => overrides.AttributeCount = attributeCount;
                return true;
            }

            if (TryParseValue(arg, nextArg, "--expressionStyle", out value, out consumedNext)
                && Enum.TryParse<BenchmarkExpressionStyle>(value, ignoreCase: true, out var expressionStyle))
            {
                applyOverride = overrides => overrides.ExpressionStyle = expressionStyle;
                return true;
            }

            if (TryParseValue(arg, nextArg, "--objectComplexity", out value, out consumedNext)
                && Enum.TryParse<BenchmarkObjectComplexity>(value, ignoreCase: true, out var objectComplexity))
            {
                applyOverride = overrides => overrides.ObjectComplexity = objectComplexity;
                return true;
            }

            if (TryParseValue(arg, nextArg, "--converterUsage", out value, out consumedNext)
                && Enum.TryParse<BenchmarkConverterUsage>(value, ignoreCase: true, out var converterUsage))
            {
                applyOverride = overrides => overrides.ConverterUsage = converterUsage;
                return true;
            }

            if (TryParseValue(arg, nextArg, "--annotationStyle", out value, out consumedNext)
                && Enum.TryParse<BenchmarkAnnotationStyle>(value, ignoreCase: true, out var annotationStyle))
            {
                applyOverride = overrides => overrides.AnnotationStyle = annotationStyle;
                return true;
            }

            return false;
        }

        private static bool TryParseValue(string arg, string? nextArg, string key, out string value, out bool consumedNext)
        {
            consumedNext = false;
            value = string.Empty;

            if (arg.StartsWith(key + "=", StringComparison.OrdinalIgnoreCase))
            {
                value = arg[(key.Length + 1)..];
                return true;
            }

            if (string.Equals(arg, key, StringComparison.OrdinalIgnoreCase) && !string.IsNullOrWhiteSpace(nextArg))
            {
                value = nextArg;
                consumedNext = true;
                return true;
            }

            return false;
        }

        private static BenchmarkParameterOverrides CreateDefaultOverrides()
        {
            return new BenchmarkParameterOverrides
            {
                ItemSize = BenchmarkItemSize.Large,
                AttributeCount = BenchmarkAttributeCount.Count200,
                ObjectComplexity = BenchmarkObjectComplexity.Nested,
                AnnotationStyle = BenchmarkAnnotationStyle.PolymorphicFlatten,
                ConverterUsage = BenchmarkConverterUsage.Mixed,
                ExpressionStyle = BenchmarkExpressionStyle.Compound
            };
        }

        private static void ConfigureRuntime(string? clientMode, BenchmarkParameterOverrides overrides)
        {
            BenchmarkContextRuntimeOptions.Configure(options =>
            {
                if (string.Equals(clientMode, "mocked", StringComparison.OrdinalIgnoreCase))
                {
                    options.ClientFactory = MockDynamoDbClientFactory.Create;
                }
                else if (string.Equals(clientMode, "aws", StringComparison.OrdinalIgnoreCase)
                    || string.Equals(clientMode, "real", StringComparison.OrdinalIgnoreCase)
                    || string.Equals(clientMode, "live", StringComparison.OrdinalIgnoreCase))
                {
                    options.ClientFactory = _ => new AmazonDynamoDBClient();
                }

                options.ParameterOverrides = overrides;
            });

            BenchmarkTableRuntimeOptions.Configure(options =>
            {
                if (string.Equals(clientMode, "mocked", StringComparison.OrdinalIgnoreCase))
                {
                    options.ClientFactory = MockDynamoDbClientFactory.Create;
                }
                else if (string.Equals(clientMode, "aws", StringComparison.OrdinalIgnoreCase)
                    || string.Equals(clientMode, "real", StringComparison.OrdinalIgnoreCase)
                    || string.Equals(clientMode, "live", StringComparison.OrdinalIgnoreCase))
                {
                    options.ClientFactory = _ => new AmazonDynamoDBClient();
                }

                options.ParameterOverrides = overrides;
            });
        }
    }
}
