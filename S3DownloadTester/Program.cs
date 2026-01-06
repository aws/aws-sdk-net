using Amazon.S3;
using Amazon.S3.Transfer;
using System.Diagnostics;
using System.Diagnostics.Tracing;

namespace S3DownloadTester
{
    // ArrayPool event listener for diagnostics
    public class ArrayPoolEventListener : EventListener
    {
        private long _rentCount = 0;
        private long _returnCount = 0;
        private long _allocateCount = 0;
        private long _allocatedBytes = 0;
        private bool _debugMode = false;
        
        public long RentCount => _rentCount;
        public long ReturnCount => _returnCount;
        public long AllocateCount => _allocateCount;
        public long AllocatedBytes => _allocatedBytes;
        
        // Derived metrics
        public long RentFromPoolCount => Math.Max(0, _rentCount - _allocateCount); // Reused from pool
        public long OutstandingCount => _rentCount - _returnCount; // Currently unreturned

        public ArrayPoolEventListener(bool debugMode = false)
        {
            _debugMode = debugMode;
        }

        protected override void OnEventSourceCreated(EventSource eventSource)
        {
            // ArrayPoolEventSource is the internal name
            if (eventSource.Name == "System.Buffers.ArrayPoolEventSource")
            {
                if (_debugMode)
                {
                    Console.WriteLine($"[DEBUG] Found ArrayPoolEventSource, enabling events");
                }
                EnableEvents(eventSource, EventLevel.Verbose, EventKeywords.All);
            }
        }

        protected override void OnEventWritten(EventWrittenEventArgs eventData)
        {
            // Debug: Log all events to see what's actually firing
            if (_debugMode && eventData.EventSource.Name == "System.Buffers.ArrayPoolEventSource")
            {
                Console.WriteLine($"[DEBUG] Event: {eventData.EventName}, Payload count: {eventData.Payload?.Count ?? 0}");
            }

            // Try both possible event name formats
            switch (eventData.EventName)
            {
                case "BufferRented":
                case "Rent":
                    Interlocked.Increment(ref _rentCount);
                    break;
                case "BufferReturned":
                case "Return":
                    Interlocked.Increment(ref _returnCount);
                    break;
                case "BufferAllocated":
                case "Allocate":
                    // This fires when ArrayPool allocates a NEW buffer (not reusing)
                    Interlocked.Increment(ref _allocateCount);
                    // Try different payload positions
                    if (eventData.Payload?.Count > 0)
                    {
                        for (int i = 0; i < eventData.Payload.Count; i++)
                        {
                            if (eventData.Payload[i] is int size && size > 0 && size < 100_000_000)
                            {
                                Interlocked.Add(ref _allocatedBytes, size);
                                break;
                            }
                        }
                    }
                    break;
            }
        }

        public override string ToString()
        {
            return $"Rent={RentCount:N0} (Pooled={RentFromPoolCount:N0}, New={AllocateCount:N0}), Return={ReturnCount:N0}, Outstanding={OutstandingCount:N0}, AllocatedMB={AllocatedBytes / 1024.0 / 1024.0:N2}";
        }
    }

    // VMA tracker for Linux diagnostics
    public class VMATracker
    {
        private int _initialVMACount;
        private int _peakVMACount;
        private int _maxMapCount = 65530; // default

        public VMATracker()
        {
            _initialVMACount = GetCurrentVMACount();
            _peakVMACount = _initialVMACount;
            
            // Read max_map_count on initialization
            try
            {
                var maxMapStr = File.ReadAllText("/proc/sys/vm/max_map_count").Trim();
                _maxMapCount = int.Parse(maxMapStr);
            }
            catch { }
        }

        public int InitialCount => _initialVMACount;
        public int PeakCount => _peakVMACount;
        public int CurrentCount => GetCurrentVMACount();
        public int GrowthFromStart => CurrentCount - _initialVMACount;
        public int MaxMapCount => _maxMapCount;

        public void Update()
        {
            var current = GetCurrentVMACount();
            if (current > _peakVMACount)
                _peakVMACount = current;
        }

        private int GetCurrentVMACount()
        {
            try
            {
                return File.ReadAllLines("/proc/self/maps").Length;
            }
            catch
            {
                return -1;
            }
        }

        public override string ToString()
        {
            Update();
            if (CurrentCount < 0)
                return "N/A (not on Linux)";
            
            var currentPercent = (CurrentCount * 100.0) / _maxMapCount;
            var peakPercent = (PeakCount * 100.0) / _maxMapCount;
            
            return $"Current={CurrentCount} ({currentPercent:F1}%), Peak={PeakCount} ({peakPercent:F1}%), Growth={GrowthFromStart:+0;-0;0}, Max={_maxMapCount}";
        }
    }

    class Program
    {
        private const string BucketName = "hagrid-garrett-test";
        private const string Key = "test-uploads//hagrid/50TB";
        private const string DownloadDirectory = "/hagrid";

        static async Task Main(string[] args)
        {
            bool useStreamApi = args.Contains("--stream");

            // Initialize diagnostics (set debug=true to see all ArrayPool events)
            bool debugArrayPool = args.Contains("--debug-arraypool");
            var arrayPoolListener = new ArrayPoolEventListener(debugArrayPool);
            var vmaTracker = new VMATracker();
            
            if (debugArrayPool)
            {
                Console.WriteLine("ArrayPool debug mode enabled - will show all events");
            }

            // Amazon.AWSConfigs.LoggingConfig.LogResponses = Amazon.ResponseLoggingOption.Always;
            // Amazon.AWSConfigs.LoggingConfig.LogTo = Amazon.LoggingOptions.Console;
            // Amazon.AWSConfigs.LoggingConfig.LogMetrics = true;
            // Amazon.AWSConfigs.AddTraceListener("Amazon", new System.Diagnostics.ConsoleTraceListener());

            Console.WriteLine("S3 Download Tester");
            Console.WriteLine("==================");
            Console.WriteLine($"Bucket: {BucketName}");
            Console.WriteLine($"Key: {Key}");
            Console.WriteLine($"Download Directory: {DownloadDirectory}");
            Console.WriteLine($"API: {(useStreamApi ? "OpenStreamWithResponseAsync" : "DownloadWithResponseAsync")}");
            Console.WriteLine();

            // Ensure download directory exists
            Directory.CreateDirectory(DownloadDirectory);

            // Create file path - extract filename from key
            string fileName = Path.GetFileName(Key);
            string filePath = Path.Combine(DownloadDirectory, fileName);

            Console.WriteLine($"Downloading to: {filePath}");
            Console.WriteLine();
            Console.WriteLine("Diagnostics:");
            Console.WriteLine($"  Initial VMAs: {vmaTracker.InitialCount}");
            Console.WriteLine($"  Initial ArrayPool: {arrayPoolListener}");
            Console.WriteLine();
            Console.WriteLine("Starting download...");
            Console.WriteLine();

            var stopwatch = Stopwatch.StartNew();

            // Create cancellation token with 40-hour timeout
            using var cts = new CancellationTokenSource(TimeSpan.FromHours(40));
            Console.WriteLine($"Cancellation token timeout: 40 hours");
            Console.WriteLine();

            // Configure TransferUtility for high performance with reasonable memory usage
            var transferConfig = new TransferUtilityConfig
            {
                ConcurrentServiceRequests = 10
            };

            Console.WriteLine("Transfer Utility Configuration:");
            Console.WriteLine($"  Concurrent Service Requests: {transferConfig.ConcurrentServiceRequests}");
            Console.WriteLine($"  Max In-Memory Parts: 128 (for stream API)");
            Console.WriteLine();

            try
            {
                var s3config = new AmazonS3Config{
                //    BufferSize = 8 * 1024 * 1024    
                };
                using var s3Client = new AmazonS3Client(s3config);
                var transferUtility = new TransferUtility(s3Client, transferConfig);

                if (useStreamApi)
                {
                    await DownloadUsingStreamAsync(transferUtility, filePath, cts.Token, vmaTracker, arrayPoolListener);
                }
                else
                {
                    await DownloadUsingDownloadWithResponseAsync(transferUtility, filePath, cts.Token);
                }

                stopwatch.Stop();

                Console.WriteLine();
                Console.WriteLine("Download completed successfully!");
                Console.WriteLine($"Total elapsed time: {stopwatch.ElapsedMilliseconds:N0} ms");
                Console.WriteLine($"Formatted time: {stopwatch.Elapsed}");
                
                // Display file info
                if (File.Exists(filePath))
                {
                    var fileInfo = new FileInfo(filePath);
                    Console.WriteLine($"File size: {FormatBytes(fileInfo.Length)}");
                }
            }
            catch (Exception ex)
            {
                stopwatch.Stop();
                Console.WriteLine();
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine($"Elapsed time before error: {stopwatch.ElapsedMilliseconds:N0} ms");
                Console.WriteLine();
                Console.WriteLine("Stack trace:");
                Console.WriteLine(ex.StackTrace);
                return;
            }
        }

        private static async Task DownloadUsingDownloadWithResponseAsync(TransferUtility transferUtility, string filePath, CancellationToken cancellationToken)
        {
            Console.WriteLine("Using DownloadWithResponseAsync API...");
            
            var request = new TransferUtilityDownloadRequest
            {
                BucketName = BucketName,
                Key = Key,
                FilePath = filePath
            };

            var response = await transferUtility.DownloadWithResponseAsync(request, cancellationToken);
            
            Console.WriteLine($"Response metadata:");
            Console.WriteLine($"  ETag: {response.ETag}");
            Console.WriteLine($"  Last Modified: {response.LastModified}");
            if (response.PartsCount.HasValue)
            {
                Console.WriteLine($"  Parts Count: {response.PartsCount}");
            }
            
            // Try to get Content-Length from Headers
            if (response.Headers != null && response.Headers["Content-Length"] != null)
            {
                Console.WriteLine($"  Content Length: {response.Headers["Content-Length"]}");
            }
            if (response.Headers != null && response.Headers["Content-Type"] != null)
            {
                Console.WriteLine($"  Content Type: {response.Headers["Content-Type"]}");
            }
        }

        private static async Task DownloadUsingStreamAsync(TransferUtility transferUtility, string filePath, CancellationToken cancellationToken, VMATracker vmaTracker, ArrayPoolEventListener arrayPoolListener)
        {
            Console.WriteLine("Using OpenStreamWithResponseAsync API...");
            Console.WriteLine("NOTE: Stream mode only reads data (no file write) to test pure streaming performance");
            Console.WriteLine();
            
            var request = new TransferUtilityOpenStreamRequest
            {
                BucketName = BucketName,
                Key = Key,
                MaxInMemoryParts = 50,
                // MultipartDownloadType = MultipartDownloadType.RANGE, // comment out to use default 5GB
                // PartSize = 8 * 1024 * 1024,
                // ChunkBufferSize = 2 * 1024 * 1024 * 1000
            };

            var response = await transferUtility.OpenStreamWithResponseAsync(request, cancellationToken);
            
            Console.WriteLine($"Response metadata:");
            Console.WriteLine($"  ETag: {response.ETag}");
            Console.WriteLine($"  Last Modified: {response.LastModified}");
            if (response.PartsCount.HasValue)
            {
                Console.WriteLine($"  Parts Count: {response.PartsCount}");
            }
            
            // Try to get Content-Length from Headers
            long? contentLength = null;
            if (response.Headers != null && response.Headers["Content-Length"] != null)
            {
                if (long.TryParse(response.Headers["Content-Length"], out long parsedLength))
                {
                    contentLength = parsedLength;
                    Console.WriteLine($"  Content Length: {FormatBytes(parsedLength)}");
                }
            }
            if (response.Headers != null && response.Headers["Content-Type"] != null)
            {
                Console.WriteLine($"  Content Type: {response.Headers["Content-Type"]}");
            }

            Console.WriteLine();
            Console.WriteLine("Reading stream (consuming data without writing to disk)...");

            // Read from stream only (no file write) - tests pure streaming performance
            var downloadStart = Stopwatch.StartNew();
            using (var stream = response.ResponseStream)
            {
                byte[] buffer = new byte[8 * 1024 * 1024]; 
                int bytesRead;
                long totalBytesRead = 0;
                long lastReportedBytes = 0;

                while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                {
                    // Just consume the data - no disk write
                    totalBytesRead += bytesRead;

                    // Report progress every 100 MB
                    if (totalBytesRead - lastReportedBytes >= 100 * 1024 * 1024)
                    {
                        var elapsedSeconds = downloadStart.Elapsed.TotalSeconds;
                        var speedBytesPerSecond = totalBytesRead / elapsedSeconds;
                        
                         if (contentLength.HasValue)
                        {
                            var remainingBytes = contentLength.Value - totalBytesRead;
                            var etaSeconds = remainingBytes / speedBytesPerSecond;
                            var eta = TimeSpan.FromSeconds(etaSeconds);
                            
                            Console.WriteLine($"  Progress: {FormatBytes(totalBytesRead)} / {FormatBytes(contentLength.Value)} ({(double)totalBytesRead / contentLength.Value * 100:F2}%)");
                            Console.WriteLine($"    Speed: {FormatThroughputGbps(speedBytesPerSecond)} | Elapsed: {FormatTimeSpan(downloadStart.Elapsed)} | ETA: {FormatTimeSpan(eta)}");
                            Console.WriteLine($"    GC: {GetGCStats()}");
                            Console.WriteLine($"    VMAs: {vmaTracker}");
                            Console.WriteLine($"    ArrayPool: {arrayPoolListener}");
                        }
                        else
                        {
                            Console.WriteLine($"  Progress: {FormatBytes(totalBytesRead)}");
                            Console.WriteLine($"    Speed: {FormatThroughputGbps(speedBytesPerSecond)} | Elapsed: {FormatTimeSpan(downloadStart.Elapsed)}");
                            Console.WriteLine($"    GC: {GetGCStats()}");
                            Console.WriteLine($"    VMAs: {vmaTracker}");
                            Console.WriteLine($"    ArrayPool: {arrayPoolListener}");
                        }
                        lastReportedBytes = totalBytesRead;
                    }
                }

                downloadStart.Stop();
                Console.WriteLine($"  Final: {FormatBytes(totalBytesRead)} read in {FormatTimeSpan(downloadStart.Elapsed)}");
                if (downloadStart.Elapsed.TotalSeconds > 0)
                {
                    var avgSpeed = totalBytesRead / downloadStart.Elapsed.TotalSeconds;
                    Console.WriteLine($"  Average Speed: {FormatThroughputGbps(avgSpeed)}");
                }
            }
        }

        private static string GetGCStats()
        {
            var gcMemInfo = GC.GetGCMemoryInfo();
            var gen0Count = GC.CollectionCount(0);
            var gen1Count = GC.CollectionCount(1);
            var gen2Count = GC.CollectionCount(2);
            
            var totalHeapMB = GC.GetTotalMemory(false) / 1024.0 / 1024.0;
            var gen2SizeMB = gcMemInfo.GenerationInfo[2].SizeAfterBytes / 1024.0 / 1024.0;
            var fragPercent = gcMemInfo.FragmentedBytes * 100.0 / gcMemInfo.HeapSizeBytes;
            
            return $"Gen0={gen0Count}, Gen1={gen1Count}, Gen2={gen2Count} | Heap={totalHeapMB:N0}MB | Gen2={gen2SizeMB:N0}MB | Frag={fragPercent:F1}%";
        }

        private static string GetVMAStats()
        {
            try
            {
                // Read /proc/self/maps to get VMA information
                var maps = File.ReadAllLines("/proc/self/maps");
                var totalVMAs = maps.Length;
                
                // Count different types and sizes
                int anonCount = 0;
                int libraryCount = 0;
                int stackCount = 0;
                int heapCount = 0;
                
                // Size distribution for anonymous mappings
                int anon_under64KB = 0;
                int anon_64KB_1MB = 0;
                int anon_1MB_10MB = 0;
                int anon_10MB_100MB = 0;
                int anon_over100MB = 0;
                
                foreach (var line in maps)
                {
                    var parts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    
                    // Parse address range
                    var addressRange = parts[0].Split('-');
                    long startAddr = Convert.ToInt64(addressRange[0], 16);
                    long endAddr = Convert.ToInt64(addressRange[1], 16);
                    long sizeBytes = endAddr - startAddr;
                    
                    if (parts.Length >= 6)
                    {
                        var name = parts[5];
                        if (name.Contains("[stack"))
                            stackCount++;
                        else if (name.Contains("[heap"))
                            heapCount++;
                        else if (name.StartsWith("/"))
                            libraryCount++;
                    }
                    else
                    {
                        // No name = anonymous mapping - categorize by size
                        anonCount++;
                        
                        if (sizeBytes < 65536)
                            anon_under64KB++;
                        else if (sizeBytes < 1048576)
                            anon_64KB_1MB++;
                        else if (sizeBytes < 10485760)
                            anon_1MB_10MB++;
                        else if (sizeBytes < 104857600)
                            anon_10MB_100MB++;
                        else
                            anon_over100MB++;
                    }
                }
                
                // Read vm.max_map_count
                int maxMapCount = 65530; // default
                try
                {
                    var maxMapStr = File.ReadAllText("/proc/sys/vm/max_map_count").Trim();
                    maxMapCount = int.Parse(maxMapStr);
                }
                catch { }
                
                var percent = (totalVMAs * 100.0) / maxMapCount;
                
                return $"Total={totalVMAs}/{maxMapCount} ({percent:F1}%) | Anon={anonCount} (<64K:{anon_under64KB} 1-10M:{anon_1MB_10MB} 10-100M:{anon_10MB_100MB} >100M:{anon_over100MB})";
            }
            catch (Exception ex)
            {
                // On non-Linux systems or if /proc isn't available
                return $"N/A (Error: {ex.Message})";
            }
        }

        private static string FormatBytes(long bytes)
        {
            string[] suffixes = { "B", "KB", "MB", "GB", "TB" };
            int suffixIndex = 0;
            double size = bytes;

            while (size >= 1024 && suffixIndex < suffixes.Length - 1)
            {
                size /= 1024;
                suffixIndex++;
            }

            return $"{size:N2} {suffixes[suffixIndex]}";
        }

        private static string FormatThroughputGbps(double bytesPerSecond)
        {
            // Convert bytes/s to bits/s, then to Gbps using decimal (SI) units
            double bitsPerSecond = bytesPerSecond * 8;
            double gbps = bitsPerSecond / 1_000_000_000; // 10^9 for Gbps
            
            if (gbps >= 1)
            {
                return $"{gbps:N2} Gbps";
            }
            else if (gbps >= 0.001)
            {
                double mbps = bitsPerSecond / 1_000_000; // 10^6 for Mbps
                return $"{mbps:N2} Mbps";
            }
            else
            {
                double kbps = bitsPerSecond / 1_000; // 10^3 for Kbps
                return $"{kbps:N2} Kbps";
            }
        }

        private static string FormatTimeSpan(TimeSpan timeSpan)
        {
            if (timeSpan.TotalDays >= 1)
            {
                return $"{(int)timeSpan.TotalDays}d {timeSpan.Hours}h {timeSpan.Minutes}m";
            }
            else if (timeSpan.TotalHours >= 1)
            {
                return $"{(int)timeSpan.TotalHours}h {timeSpan.Minutes}m {timeSpan.Seconds}s";
            }
            else if (timeSpan.TotalMinutes >= 1)
            {
                return $"{(int)timeSpan.TotalMinutes}m {timeSpan.Seconds}s";
            }
            else
            {
                return $"{timeSpan.Seconds}s";
            }
        }

    }
}
