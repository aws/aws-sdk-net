using Amazon.DynamoDBv2;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Attributes;

namespace AWSSDK.Benchmarks.MockedDynamoDB
{
    internal class Program
    {
        private const string ClientArgName = "--client";
        private const string BenchmarksArgName = "--benchmarks";
        private const string ItemSizeArgName = "--itemSize";
        private const string AttributeCountArgName = "--attributeCount";
        private const string ExpressionStyleArgName = "--expressionStyle";
        private const string ObjectComplexityArgName = "--objectComplexity";
        private const string ConverterUsageArgName = "--converterUsage";
        private const string AnnotationStyleArgName = "--annotationStyle";

        private const string MockedClientMode = "mocked";
        private static readonly string[] RealClientModes = ["aws", "real", "live"];
        private const string RealBenchmarkPrefix = "Real";

        static void Main(string[] args)
        {
            var (clientMode, overrides, benchmarkNames, remainingArgs) = ParseArguments(args);
            var effectiveOverrides = overrides ?? CreateDefaultOverrides();
            ConfigureRuntime(clientMode, effectiveOverrides);

            var config = CreateBenchmarkConfig();
            var selectedBenchmarks = benchmarkNames?.Length > 0
                ? ResolveBenchmarkTypes(benchmarkNames)
                : ResolveBenchmarkTypesForClient(clientMode);

            if (selectedBenchmarks.Length == 1)
            {
                BenchmarkRunner.Run(selectedBenchmarks[0], config, remainingArgs);
                return;
            }

            BenchmarkSwitcher.FromTypes(selectedBenchmarks).Run(remainingArgs, config);
        }

        private static IConfig CreateBenchmarkConfig()
        {
            var config = ManualConfig.Create(DefaultConfig.Instance);
            var summaryStyle = new SummaryStyle(
                cultureInfo: System.Globalization.CultureInfo.InvariantCulture,
                printUnitsInHeader: false,
                timeUnit: Perfolizer.Horology.TimeUnit.Millisecond,
                sizeUnit: SizeUnit.B);

            config.WithSummaryStyle(summaryStyle);
            config.AddColumn(StatisticColumn.P50);
            config.AddColumn(StatisticColumn.P90);
            config.AddColumn(StatisticColumn.P95);
            return config;
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
                if (arg.StartsWith(ClientArgName + "=", StringComparison.OrdinalIgnoreCase))
                {
                    clientMode = arg[(ClientArgName.Length + 1)..];
                    continue;
                }

                if (string.Equals(arg, ClientArgName, StringComparison.OrdinalIgnoreCase) && i + 1 < args.Length)
                {
                    clientMode = args[++i];
                    continue;
                }

                if (TryParseValue(arg, i + 1 < args.Length ? args[i + 1] : null, BenchmarksArgName, out var benchmarksValue, out var consumedNext))
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
            var benchmarks = GetAllBenchmarkTypes();

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

        private static Type[] ResolveBenchmarkTypesForClient(string? clientMode)
        {
            var benchmarks = GetAllBenchmarkTypes();

            if (IsMockedMode(clientMode))
            {
                return benchmarks.Where(type => !IsRealBenchmark(type)).ToArray();
            }

            if (IsRealMode(clientMode))
            {
                return benchmarks.Where(IsRealBenchmark).ToArray();
            }

            return benchmarks;
        }

        private static Type[] GetAllBenchmarkTypes()
        {
            return typeof(Program).Assembly
                .GetTypes()
                .Where(type => type.IsClass
                    && type.GetMethods().Any(method => method.GetCustomAttributes(typeof(BenchmarkAttribute), inherit: true).Any()))
                .ToArray();
        }

        private static bool IsRealBenchmark(Type type) => type.Name.StartsWith(RealBenchmarkPrefix, StringComparison.OrdinalIgnoreCase);

        private static bool IsMockedMode(string? clientMode) => string.Equals(clientMode, MockedClientMode, StringComparison.OrdinalIgnoreCase);

        private static bool IsRealMode(string? clientMode) =>
            RealClientModes.Any(mode => string.Equals(clientMode, mode, StringComparison.OrdinalIgnoreCase));

        private static bool TryParseOverride(string arg, string? nextArg, out Action<BenchmarkParameterOverrides> applyOverride, out bool consumedNext)
        {
            applyOverride = _ => { };
            consumedNext = false;

            if (TryParseEnumValue<BenchmarkItemSize>(arg, nextArg, ItemSizeArgName, out var itemSize, out consumedNext))
            {
                applyOverride = overrides => overrides.ItemSize = itemSize;
                return true;
            }

            if (TryParseEnumValue<BenchmarkAttributeCount>(arg, nextArg, AttributeCountArgName, out var attributeCount, out consumedNext))
            {
                applyOverride = overrides => overrides.AttributeCount = attributeCount;
                return true;
            }

            if (TryParseEnumValue<BenchmarkExpressionStyle>(arg, nextArg, ExpressionStyleArgName, out var expressionStyle, out consumedNext))
            {
                applyOverride = overrides => overrides.ExpressionStyle = expressionStyle;
                return true;
            }

            if (TryParseEnumValue<BenchmarkObjectComplexity>(arg, nextArg, ObjectComplexityArgName, out var objectComplexity, out consumedNext))
            {
                applyOverride = overrides => overrides.ObjectComplexity = objectComplexity;
                return true;
            }

            if (TryParseEnumValue<BenchmarkConverterUsage>(arg, nextArg, ConverterUsageArgName, out var converterUsage, out consumedNext))
            {
                applyOverride = overrides => overrides.ConverterUsage = converterUsage;
                return true;
            }

            if (TryParseEnumValue<BenchmarkAnnotationStyle>(arg, nextArg, AnnotationStyleArgName, out var annotationStyle, out consumedNext))
            {
                applyOverride = overrides => overrides.AnnotationStyle = annotationStyle;
                return true;
            }

            return false;
        }

        private static bool TryParseEnumValue<TEnum>(
            string arg,
            string? nextArg,
            string key,
            out TEnum parsedValue,
            out bool consumedNext)
            where TEnum : struct, Enum
        {
            parsedValue = default;
            consumedNext = false;

            if (TryParseValue(arg, nextArg, key, out var value, out consumedNext)
                && Enum.TryParse<TEnum>(value, ignoreCase: true, out parsedValue))
            {
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
            var useMockedClient = IsMockedMode(clientMode);
            var useRealClient = IsRealMode(clientMode);

            BenchmarkContextRuntimeOptions.Configure(options =>
            {
                if (useMockedClient)
                {
                    options.ClientFactory = MockDynamoDbClientFactory.Create;
                }
                else if (useRealClient)
                {
                    options.ClientFactory = _ => new AmazonDynamoDBClient();
                }

                options.ParameterOverrides = overrides;
            });

            BenchmarkTableRuntimeOptions.Configure(options =>
            {
                if (useMockedClient)
                {
                    options.ClientFactory = MockDynamoDbClientFactory.Create;
                }
                else if (useRealClient)
                {
                    options.ClientFactory = _ => new AmazonDynamoDBClient();
                }

                options.ParameterOverrides = overrides;
            });
        }
    }
}
