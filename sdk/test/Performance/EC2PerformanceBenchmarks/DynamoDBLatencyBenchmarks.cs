/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using Amazon;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Toolchains.InProcess.Emit;

namespace AWSSDK.Benchmarks
{
    /// <summary>
    /// BenchmarkDotNet benchmarks for DynamoDB latency (PutItem and GetItem).
    /// 
    /// Each [Benchmark] method is a single PutItem or GetItem call.
    /// BenchmarkDotNet measures per-operation latency and reports mean, p50, p90, p95
    /// with 100 measurement iterations (network operation minimum).
    ///
    /// Template specification:
    ///   - Table: Provisioned capacity (5000 RCU / 5000 WCU)
    ///   - Item size: 1 KiB per item
    ///   - Client state: Warm (single reused client instance)
    ///   - Concurrency: Sequential (one request at a time)
    ///   - 100 measurement iterations, 10 warmup
    ///
    /// GlobalSetup creates the table if needed (or uses DYNAMODB_BENCHMARK_TABLE env var)
    /// and seeds 100 items so GetItem has data to read.
    ///
    /// Usage:
    ///   dotnet run -c Release -- --filter *DynamoDBLatency*
    /// </summary>
    /// <summary>
    /// BenchmarkDotNet config for DynamoDB latency benchmarks.
    /// Uses InProcessEmitToolchain to avoid assembly resolution issues with v4 SDK
    /// (CreateDefaultClientConfig MissingMethodException in out-of-process BDN runner).
    /// </summary>
    public class DynamoDBLatencyConfig : ManualConfig
    {
        public DynamoDBLatencyConfig()
        {
            // Performance Baselines Report used: IterationCount=10000, WarmupCount=10
            // Optimized for CI/build system runtime: IterationCount=100
            AddJob(Job.Default
                .WithToolchain(InProcessEmitToolchain.Instance)
                .WithStrategy(RunStrategy.Monitoring)
                .WithWarmupCount(10)
                .WithIterationCount(100)
                .WithInvocationCount(1)
                .WithUnrollFactor(1));
            AddDiagnoser(BenchmarkDotNet.Diagnosers.MemoryDiagnoser.Default);
        }
    }

    [Config(typeof(DynamoDBLatencyConfig))]
    public class DynamoDBLatencyBenchmarks
    {
        private IAmazonDynamoDB _dynamoClient = null!;
        private string _dataPayload = null!;
        private int _currentKeyIndex;
        private ResourceMonitor _resourceMonitor = null!;
        private string _tableName = null!;
        private bool _createdTable;

        [GlobalSetup]
        public void Setup()
        {
            _dynamoClient = new AmazonDynamoDBClient();

            // Use existing table from environment variable, or create one
            _tableName = Environment.GetEnvironmentVariable("DYNAMODB_BENCHMARK_TABLE")
                ?? $"dotnet-sdk-perf-{DateTime.UtcNow:yyyyMMddHHmmss}";
            _createdTable = false;

            // Create table if it doesn't exist
            try
            {
                _dynamoClient.DescribeTableAsync(_tableName).GetAwaiter().GetResult();
                Console.WriteLine($"Using existing table '{_tableName}'.");
            }
            catch (ResourceNotFoundException)
            {
                Console.WriteLine($"Creating DynamoDB table '{_tableName}' (5000 RCU / 5000 WCU)...");
                _dynamoClient.CreateTableAsync(new CreateTableRequest
                {
                    TableName = _tableName,
                    AttributeDefinitions = new List<AttributeDefinition>
                    {
                        new AttributeDefinition { AttributeName = "pk", AttributeType = ScalarAttributeType.S }
                    },
                    KeySchema = new List<KeySchemaElement>
                    {
                        new KeySchemaElement { AttributeName = "pk", KeyType = KeyType.HASH }
                    },
                    ProvisionedThroughput = new ProvisionedThroughput
                    {
                        ReadCapacityUnits = 5000,
                        WriteCapacityUnits = 5000
                    }
                }).GetAwaiter().GetResult();
                _createdTable = true;

                // Wait for table to become active
                Console.WriteLine("Waiting for table to become active...");
                while (true)
                {
                    var desc = _dynamoClient.DescribeTableAsync(_tableName).GetAwaiter().GetResult();
                    if (desc.Table.TableStatus == TableStatus.ACTIVE) break;
                    Thread.Sleep(2000);
                }
                Console.WriteLine("Table is active.");
            }

            _dataPayload = new string('x', 1024); // 1 KiB
            _currentKeyIndex = 0;

            // Seed 100 items for GetItem benchmark (matches iteration count)
            Console.WriteLine("Seeding 100 items...");
            for (int i = 0; i < 100; i++)
            {
                _dynamoClient.PutItemAsync(new PutItemRequest
                {
                    TableName = _tableName,
                    Item = new Dictionary<string, AttributeValue>
                    {
                        ["pk"] = new AttributeValue { S = $"item-{i}" },
                        ["data"] = new AttributeValue { S = _dataPayload }
                    }
                }).GetAwaiter().GetResult();
            }
            Console.WriteLine("Seeding complete.");

            // Start resource monitoring (CPU + memory sampling at 100ms intervals)
            _resourceMonitor = new ResourceMonitor(intervalMs: 100);
            _resourceMonitor.Start();
            Console.WriteLine("[ResourceMonitor] Started sampling CPU and memory at 100ms intervals.");
        }

        [IterationSetup]
        public void IterationSetup()
        {
            // Cycle through keys so each iteration uses a different item
            _currentKeyIndex = (_currentKeyIndex + 1) % 100;
        }

        [GlobalCleanup]
        public void Cleanup()
        {
            // Stop resource monitoring and report results
            _resourceMonitor?.Stop();
            if (_resourceMonitor != null)
            {
                Console.WriteLine(_resourceMonitor.GetSummary("DynamoDBLatency"));
            }

            _dynamoClient?.Dispose();
        }

        /// <summary>Single PutItem operation with 1 KiB item.</summary>
        [Benchmark]
        public async Task DynamoDB_PutItem()
        {
            await _dynamoClient.PutItemAsync(new PutItemRequest
            {
                TableName = _tableName,
                Item = new Dictionary<string, AttributeValue>
                {
                    ["pk"] = new AttributeValue { S = $"item-{_currentKeyIndex}" },
                    ["data"] = new AttributeValue { S = _dataPayload }
                }
            });
        }

        /// <summary>Single GetItem operation for 1 KiB item.</summary>
        [Benchmark]
        public async Task DynamoDB_GetItem()
        {
            await _dynamoClient.GetItemAsync(new GetItemRequest
            {
                TableName = _tableName,
                Key = new Dictionary<string, AttributeValue>
                {
                    ["pk"] = new AttributeValue { S = $"item-{_currentKeyIndex}" }
                }
            });
        }
    }
}
