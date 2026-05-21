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
using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Toolchains.InProcess.Emit;

namespace AWSSDK.Benchmarks
{
    /// <summary>
    /// BenchmarkDotNet benchmarks for S3 throughput (PutObject and GetObject).
    ///
    /// Template specification:
    ///   - Bucket: S3 Express One Zone directory bucket
    ///   - Object size: 256 KiB per object
    ///   - Batch size: 10,000 operations per iteration
    ///   - Concurrency: 64 (SDK optimal)
    ///   - Checksum: Disabled
    ///   - 3 measurement iterations, 2 warmup (each iteration is a full 10,000-op batch)
    ///
    /// Each [Benchmark] method runs a full batch of 10,000 concurrent operations.
    /// BenchmarkDotNet measures the total time per batch. Throughput (Gbps) can be
    /// calculated from: (10,000 × 256KiB × 8) / time_seconds / 1,000,000,000
    ///
    /// GlobalSetup creates an S3 Express bucket if S3_BENCHMARK_BUCKET is not set.
    /// GlobalCleanup deletes the bucket if it was auto-created.
    /// Run PutObject first to populate objects, then GetObject reuses them.
    ///
    /// Usage:
    ///   dotnet run -c Release -- --filter *S3Throughput*
    /// </summary>
    /// <summary>
    /// BenchmarkDotNet config for S3 throughput benchmarks.
    /// Uses InProcessEmitToolchain to avoid assembly resolution issues with v4 SDK.
    /// </summary>
    public class S3ThroughputConfig : ManualConfig
    {
        public S3ThroughputConfig()
        {
            // Performance Baselines Report used: same config (WarmupCount=2, IterationCount=3)
            // but with InProcessEmitToolchain.Instance (default timeout). Extended timeout added
            // because each iteration runs 10,000 concurrent S3 operations which can take 60+ seconds.
            var toolchain = new InProcessEmitToolchain(TimeSpan.FromHours(2), logOutput: true);
            AddJob(Job.Default
                .WithToolchain(toolchain)
                .WithStrategy(RunStrategy.Monitoring)
                .WithWarmupCount(2)
                .WithIterationCount(3)
                .WithInvocationCount(1)
                .WithUnrollFactor(1));
            AddDiagnoser(BenchmarkDotNet.Diagnosers.MemoryDiagnoser.Default);
        }
    }

    [Config(typeof(S3ThroughputConfig))]
    public class S3ThroughputBenchmarks
    {
        private IAmazonS3 _s3Client = null!;
        private byte[] _objectData = null!;
        private const int ObjectSize = 256 * 1024; // 256 KiB
        private const int TotalObjects = 10_000;
        private const int Concurrency = 64;
        private ResourceMonitor _resourceMonitor = null!;
        private string _bucketName = null!;
        private bool _createdBucket;

        [GlobalSetup]
        public void Setup()
        {
            _s3Client = new AmazonS3Client(new AmazonS3Config
            {
                RequestChecksumCalculation = RequestChecksumCalculation.WHEN_REQUIRED
            });

            // Determine AZ for S3 Express bucket creation.
            // Uses S3_BENCHMARK_AZ env var, or derives from the SDK's resolved region.
            var region = _s3Client.Config.RegionEndpoint?.SystemName ?? "us-west-2";
            var az = Environment.GetEnvironmentVariable("S3_BENCHMARK_AZ") ?? region switch
            {
                "us-west-2" => "usw2-az1",
                "us-east-1" => "use1-az4",
                "us-east-2" => "use2-az1",
                "eu-west-1" => "euw1-az1",
                _ => "usw2-az1"
            };

            // Use existing bucket from environment variable, or create one
            _bucketName = Environment.GetEnvironmentVariable("S3_BENCHMARK_BUCKET")!;
            _createdBucket = false;

            if (string.IsNullOrEmpty(_bucketName))
            {
                // Generate a unique S3 Express directory bucket name
                var suffix = Guid.NewGuid().ToString("N")[..8];
                _bucketName = $"dotnet-perf-{suffix}--{az}--x-s3";

                Console.WriteLine($"Creating S3 Express bucket '{_bucketName}' in {region} ({az})...");
                _s3Client.PutBucketAsync(new PutBucketRequest
                {
                    BucketName = _bucketName,
                    PutBucketConfiguration = new PutBucketConfiguration
                    {
                        BucketInfo = new BucketInfo { DataRedundancy = DataRedundancy.SingleAvailabilityZone, Type = BucketType.Directory },
                        Location = new LocationInfo { Name = az, Type = LocationType.AvailabilityZone }
                    }
                }).GetAwaiter().GetResult();
                _createdBucket = true;
                Console.WriteLine("Bucket created.");
            }
            else
            {
                Console.WriteLine($"Using existing bucket '{_bucketName}'.");
            }

            _objectData = new byte[ObjectSize];
            Random.Shared.NextBytes(_objectData);

            // Warm up credentials and S3 Express session, and pre-populate objects for GetObject
            Console.WriteLine("Warming up S3 Express session and seeding objects...");
            _s3Client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = "warmup-object",
                InputStream = new MemoryStream(_objectData)
            }).GetAwaiter().GetResult();

            // Pre-populate all objects so GetObject has data to read
            Console.WriteLine($"Seeding {TotalObjects} objects (256 KiB each)...");
            using var seedSemaphore = new SemaphoreSlim(Concurrency);
            var seedTasks = new Task[TotalObjects];
            for (int i = 0; i < TotalObjects; i++)
            {
                seedSemaphore.Wait();
                var key = $"bench/obj-{i}";
                seedTasks[i] = Task.Run(async () =>
                {
                    try
                    {
                        await _s3Client.PutObjectAsync(new PutObjectRequest
                        {
                            BucketName = _bucketName,
                            Key = key,
                            InputStream = new MemoryStream(_objectData)
                        });
                    }
                    finally
                    {
                        seedSemaphore.Release();
                    }
                });
            }
            Task.WhenAll(seedTasks).GetAwaiter().GetResult();
            Console.WriteLine("Seeding complete. S3 Express session ready.");

            _resourceMonitor = new ResourceMonitor(intervalMs: 100);
        }

        [GlobalCleanup]
        public void Cleanup()
        {
            // Delete auto-created bucket and its objects
            if (_createdBucket && _s3Client != null)
            {
                Console.WriteLine($"Cleaning up bucket '{_bucketName}'...");
                try
                {
                    // Delete objects in batches
                    var listResponse = _s3Client.ListObjectsV2Async(new ListObjectsV2Request
                    {
                        BucketName = _bucketName,
                        MaxKeys = 1000
                    }).GetAwaiter().GetResult();

                    while (listResponse.S3Objects.Count > 0)
                    {
                        _s3Client.DeleteObjectsAsync(new DeleteObjectsRequest
                        {
                            BucketName = _bucketName,
                            Objects = listResponse.S3Objects.Select(o => new KeyVersion { Key = o.Key }).ToList()
                        }).GetAwaiter().GetResult();

                        if (listResponse.IsTruncated != true) break;
                        listResponse = _s3Client.ListObjectsV2Async(new ListObjectsV2Request
                        {
                            BucketName = _bucketName,
                            MaxKeys = 1000,
                            ContinuationToken = listResponse.NextContinuationToken
                        }).GetAwaiter().GetResult();
                    }

                    _s3Client.DeleteBucketAsync(_bucketName).GetAwaiter().GetResult();
                    Console.WriteLine("Bucket deleted.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Warning: Failed to clean up bucket: {ex.Message}");
                }
            }

            _s3Client?.Dispose();
        }

        [Benchmark]
        public async Task S3_PutObject_Batch()
        {
            // Start resource monitoring for this iteration
            _resourceMonitor.Start();

            using var semaphore = new SemaphoreSlim(Concurrency);
            var tasks = new Task[TotalObjects];

            for (int i = 0; i < TotalObjects; i++)
            {
                await semaphore.WaitAsync();
                var key = $"bench/obj-{i}";
                tasks[i] = Task.Run(async () =>
                {
                    try
                    {
                        await _s3Client.PutObjectAsync(new PutObjectRequest
                        {
                            BucketName = _bucketName,
                            Key = key,
                            InputStream = new MemoryStream(_objectData)
                        });
                    }
                    finally
                    {
                        semaphore.Release();
                    }
                });
            }

            await Task.WhenAll(tasks);

            // Stop and report resource usage for this iteration
            _resourceMonitor.Stop();
            Console.WriteLine(_resourceMonitor.GetSummary("S3_PutObject_Batch"));
        }

        [Benchmark]
        public async Task S3_GetObject_Batch()
        {
            // Start resource monitoring for this iteration
            _resourceMonitor.Start();

            using var semaphore = new SemaphoreSlim(Concurrency);
            var tasks = new Task[TotalObjects];

            for (int i = 0; i < TotalObjects; i++)
            {
                await semaphore.WaitAsync();
                var key = $"bench/obj-{i}";
                tasks[i] = Task.Run(async () =>
                {
                    try
                    {
                        using var response = await _s3Client.GetObjectAsync(new GetObjectRequest
                        {
                            BucketName = _bucketName,
                            Key = key
                        });
                        // Consume the stream to measure full download
                        await response.ResponseStream.CopyToAsync(Stream.Null);
                    }
                    finally
                    {
                        semaphore.Release();
                    }
                });
            }

            await Task.WhenAll(tasks);

            // Stop and report resource usage for this iteration
            _resourceMonitor.Stop();
            Console.WriteLine(_resourceMonitor.GetSummary("S3_GetObject_Batch"));
        }
    }
}
