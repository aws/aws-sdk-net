using Amazon.S3;
using Amazon.S3.Transfer;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Text;
using System.Linq;
using Amazon.Runtime;
using System.Net.Http;

namespace S3DownloadTester
{
    // ArrayPool event listener for diagnostics
    public class ArrayPoolEventListener : EventListener
    {
        private long _rentCount = 0;
        private long _returnCount = 0;
        private long _allocateCount = 0;
        private long _allocatedBytes = 0;
        
        public long RentCount => _rentCount;
        public long ReturnCount => _returnCount;
        public long AllocateCount => _allocateCount;
        public long AllocatedBytes => _allocatedBytes;
        
        // Derived metrics
        public long RentFromPoolCount => Math.Max(0, _rentCount - _allocateCount); // Reused from pool
        public long OutstandingCount => _rentCount - _returnCount; // Currently unreturned

        public ArrayPoolEventListener() { }

        protected override void OnEventSourceCreated(EventSource eventSource)
        {
            if (eventSource.Name == "System.Buffers.ArrayPoolEventSource")
            {
                // Note: Don't log here - it can trigger ArrayPool events
                EnableEvents(eventSource, EventLevel.Verbose, EventKeywords.All);
            }
        }

        protected override void OnEventWritten(EventWrittenEventArgs eventData)
        {
            // Note: Cannot log here in debug mode - Console.WriteLine uses ArrayPool, causing stack overflow

            switch (eventData.EventName)
            {
                case "BufferRented":
                case "Rent":
                    Interlocked.Increment(ref _rentCount);
                    // Track large buffer rents
                    if (eventData.Payload?.Count > 0 && eventData.Payload[0] is int rentSize && rentSize >= 1024*1024)
                    {
                        // Use Debug.WriteLine to avoid ArrayPool recursion
                        System.Diagnostics.Debug.WriteLine($"[ArrayPool] Large rent: {rentSize/1024}KB");
                    }
                    break;
                case "BufferReturned":
                case "Return":
                    Interlocked.Increment(ref _returnCount);
                    break;
                case "BufferAllocated":
                case "Allocate":
                    Interlocked.Increment(ref _allocateCount);
                    if (eventData.Payload?.Count > 0)
                    {
                        for (int i = 0; i < eventData.Payload.Count; i++)
                        {
                            if (eventData.Payload[i] is int allocSize && allocSize > 0 && allocSize < 100_000_000)
                            {
                                Interlocked.Add(ref _allocatedBytes, allocSize);
                                // Log large allocations
                                if (allocSize >= 1024*1024)
                                {
                                    System.Diagnostics.Debug.WriteLine($"[ArrayPool] Large alloc: {allocSize/1024}KB");
                                }
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

    // HTTP connection tracker
    public class HttpConnectionTracker
    {
        private static int _activeConnections = 0;
        private static int _totalConnections = 0;
        
        public static void ConnectionOpened()
        {
            Interlocked.Increment(ref _activeConnections);
            Interlocked.Increment(ref _totalConnections);
        }
        
        public static void ConnectionClosed()
        {
            Interlocked.Decrement(ref _activeConnections);
        }
        
        public static string GetStats() => $"HTTP: Active={_activeConnections}, Total={_totalConnections}";
    }

    // Finalizer tracker to detect leaked objects
    public class FinalizerTracker
    {
        private static int _pendingFinalizers = 0;
        
        public static void RegisterFinalizable()
        {
            Interlocked.Increment(ref _pendingFinalizers);
        }
        
        public static void Finalized()
        {
            Interlocked.Decrement(ref _pendingFinalizers);
        }
        
        public static string GetStats() => $"Finalizers: Pending={_pendingFinalizers}";
    }

    // Custom HttpClientFactory for AWS SDK tracking
    public class TrackingHttpClientFactory : HttpClientFactory
    {
        private static int _activeRequests = 0;
        private static int _totalRequests = 0;
        private static long _totalBytesReceived = 0;
        
        public static string GetStats() => $"HTTP: Active={_activeRequests}, Total={_totalRequests}, Received={_totalBytesReceived/1024/1024:N0}MB";
        
        public override HttpClient CreateHttpClient(IClientConfig clientConfig)
        {
            var handler = new TrackingHttpHandler();
            return new HttpClient(handler);
        }
        
        private class TrackingHttpHandler : HttpClientHandler
        {
            protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                Interlocked.Increment(ref _activeRequests);
                Interlocked.Increment(ref _totalRequests);
                
                try
                {
                    var response = await base.SendAsync(request, cancellationToken);
                    
                    // Track response size
                    if (response.Content?.Headers?.ContentLength.HasValue == true)
                    {
                        Interlocked.Add(ref _totalBytesReceived, response.Content.Headers.ContentLength.Value);
                    }
                    
                    return response;
                }
                finally
                {
                    Interlocked.Decrement(ref _activeRequests);
                }
            }
        }
    }

    public class GCEventListener : EventListener
    {
        public int HeapExpandCount = 0;
        public int GCCount = 0;
        public long LastHeapSize = 0;
        private bool _debugMode = false;

        public GCEventListener(bool debugMode = false)
        {
            _debugMode = debugMode;
        }

        protected override void OnEventSourceCreated(EventSource source)
        {
            if (source.Name == "Microsoft-Windows-DotNETRuntime")
            {
                if (_debugMode)
                    Console.WriteLine("[DEBUG] Found DotNETRuntime EventSource, enabling GC events");
                EnableEvents(source, EventLevel.Informational, (EventKeywords)0x1); // GC keyword
            }
        }

        protected override void OnEventWritten(EventWrittenEventArgs e)
        {
            if (e.EventName?.Contains("GCStart") == true)
            {
                Interlocked.Increment(ref GCCount);
            }
            else if (e.EventName?.Contains("HeapStats") == true && e.Payload?.Count > 0)
            {
                if (e.Payload[0] is long heapSize && heapSize > LastHeapSize * 1.1)
                {
                    Interlocked.Increment(ref HeapExpandCount);
                    var oldSize = LastHeapSize;
                    LastHeapSize = heapSize;
                    Console.WriteLine($"[GC] Heap expanded: {oldSize / 1024.0 / 1024.0 / 1024.0:F2} GB -> {heapSize / 1024.0 / 1024.0 / 1024.0:F2} GB");
                }
            }
        }

        public override string ToString() => $"GCs={GCCount}, HeapExpands={HeapExpandCount}, LastHeap={LastHeapSize / 1024.0 / 1024.0 / 1024.0:F2}GB";
    }

    // VMA tracker for Linux diagnostics
    public class VMATracker
    {
        private int _initialVMACount;
        private int _peakVMACount;
        private int _maxMapCount = 65530;
        private int _lastSnapshotVMACount = 0;
        private string _snapshotDir;

        public VMATracker(string snapshotDir = "/tmp")
        {
            _snapshotDir = snapshotDir;
            _initialVMACount = GetCurrentVMACount();
            _peakVMACount = _initialVMACount;
            _lastSnapshotVMACount = _initialVMACount;
            
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

        // Snapshot VMAs if growth exceeds threshold
        public void SnapshotIfGrowth(int threshold = 5000)
        {
            var current = GetCurrentVMACount();
            if (current - _lastSnapshotVMACount > threshold)
            {
                try
                {
                    var filename = $"{_snapshotDir}/maps_vma{current}_{DateTime.Now:HHmmss}.txt";
                    File.Copy("/proc/self/maps", filename);
                    Console.WriteLine($"[VMA] Snapshot saved: {filename}");
                    _lastSnapshotVMACount = current;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[VMA] Snapshot failed: {ex.Message}");
                }
            }
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

    // GC Heap detailed stats
    public static class GCHeapTracker
    {
        public static string GetStats()
        {
            var gcInfo = GC.GetGCMemoryInfo();
            var sb = new StringBuilder();
            
            sb.AppendLine($"      Committed: {gcInfo.TotalCommittedBytes / 1024.0 / 1024.0 / 1024.0:F2} GB");
            sb.AppendLine($"      HeapSize: {gcInfo.HeapSizeBytes / 1024.0 / 1024.0 / 1024.0:F2} GB");
            sb.AppendLine($"      MemoryLoad: {gcInfo.MemoryLoadBytes / 1024.0 / 1024.0 / 1024.0:F2} GB");
            sb.AppendLine($"      Fragmented: {gcInfo.FragmentedBytes / 1024.0 / 1024.0:F0} MB");
            sb.AppendLine($"      PauseTime%: {gcInfo.PauseTimePercentage:F2}%");
            
            for (int i = 0; i < gcInfo.GenerationInfo.Length && i < 4; i++)
            {
                var gen = gcInfo.GenerationInfo[i];
                sb.AppendLine($"      Gen{i}: Size={gen.SizeAfterBytes / 1024.0 / 1024.0:F0}MB, Frag={gen.FragmentationAfterBytes / 1024.0 / 1024.0:F0}MB");
            }
            
            return sb.ToString().TrimEnd();
        }

        public static string GetOneLiner()
        {
            var gcInfo = GC.GetGCMemoryInfo();
            return $"Committed={gcInfo.TotalCommittedBytes / 1024.0 / 1024.0 / 1024.0:F1}GB, Heap={gcInfo.HeapSizeBytes / 1024.0 / 1024.0 / 1024.0:F1}GB, Frag={gcInfo.FragmentedBytes / 1024.0 / 1024.0:F0}MB";
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
            bool verboseAll = args.Contains("--verbose") || args.Contains("-v");
            bool debugArrayPool = verboseAll || args.Contains("--debug-arraypool");
            bool debugGC = verboseAll || args.Contains("--debug-gc");
            bool verboseHeap = verboseAll || args.Contains("--verbose-heap");

            // Initialize diagnostics
            var arrayPoolListener = new ArrayPoolEventListener();
            var gcListener = new GCEventListener(debugGC);
            var vmaTracker = new VMATracker();

            // Catch unhandled exceptions
            AppDomain.CurrentDomain.UnhandledException += (s, e) =>
            {
                Console.WriteLine($"\n[FATAL] Unhandled: {e.ExceptionObject}");
                Console.WriteLine($"  VMAs: {vmaTracker}");
                Console.WriteLine($"  GC: {GCHeapTracker.GetOneLiner()}");
                try { File.Copy("/proc/self/maps", $"/tmp/maps_fatal_{DateTime.Now:HHmmss}.txt"); } catch { }
            };
            
            Console.WriteLine("S3 Download Tester");
            Console.WriteLine("==================");
            Console.WriteLine($"Bucket: {BucketName}");
            Console.WriteLine($"Key: {Key}");
            Console.WriteLine($"Download Directory: {DownloadDirectory}");
            Console.WriteLine($"API: {(useStreamApi ? "OpenStreamWithResponseAsync" : "DownloadWithResponseAsync")}");
            Console.WriteLine($"Debug flags: ArrayPool={debugArrayPool}, GC={debugGC}, VerboseHeap={verboseHeap}");
            Console.WriteLine();

            Directory.CreateDirectory(DownloadDirectory);

            string fileName = Path.GetFileName(Key);
            string filePath = Path.Combine(DownloadDirectory, fileName);

            Console.WriteLine($"Downloading to: {filePath}");
            Console.WriteLine();
            Console.WriteLine("Initial Diagnostics:");
            Console.WriteLine($"  VMAs: {vmaTracker}");
            Console.WriteLine($"  ArrayPool: {arrayPoolListener}");
            Console.WriteLine($"  GC Events: {gcListener}");
            Console.WriteLine($"  GC Heap: {GCHeapTracker.GetOneLiner()}");
            Console.WriteLine();

            var stopwatch = Stopwatch.StartNew();
            using var cts = new CancellationTokenSource(TimeSpan.FromHours(40));

            var transferConfig = new TransferUtilityConfig
            {
                ConcurrentServiceRequests = 10
            };

            Console.WriteLine("Transfer Utility Configuration:");
            Console.WriteLine($"  Concurrent Service Requests: {transferConfig.ConcurrentServiceRequests}");
            Console.WriteLine($"  Max In-Memory Parts: 50 (for stream API)");
            Console.WriteLine();
            Console.WriteLine("Starting download...");
            Console.WriteLine();

            try
            {
                // Create S3 client with HTTP tracking
                var s3config = new AmazonS3Config()
                {
                    HttpClientFactory = new TrackingHttpClientFactory()
                };
                
                using var s3Client = new AmazonS3Client(s3config);
                var transferUtility = new TransferUtility(s3Client, transferConfig);

                if (useStreamApi)
                {
                    await DownloadUsingStreamAsync(transferUtility, filePath, cts.Token, vmaTracker, arrayPoolListener, gcListener, verboseHeap);
                }
                else
                {
                    await DownloadUsingDownloadWithResponseAsync(transferUtility, filePath, cts.Token);
                }

                stopwatch.Stop();
                Console.WriteLine();
                Console.WriteLine("Download completed successfully!");
                Console.WriteLine($"Total elapsed time: {stopwatch.Elapsed}");
                
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
                Console.WriteLine($"[ERROR] {ex.GetType().Name}: {ex.Message}");
                Console.WriteLine($"Elapsed: {stopwatch.Elapsed}");
                Console.WriteLine();
                Console.WriteLine("=== CRASH DIAGNOSTICS ===");
                Console.WriteLine($"VMAs: {vmaTracker}");
                Console.WriteLine($"ArrayPool: {arrayPoolListener}");
                Console.WriteLine($"GC Events: {gcListener}");
                Console.WriteLine($"GC Heap: {GCHeapTracker.GetOneLiner()}");
                
                // Full inner exception chain
                var inner = ex;
                int depth = 0;
                while (inner != null && depth < 5)
                {
                    Console.WriteLine($"\n[Exception {depth}] {inner.GetType().FullName}");
                    Console.WriteLine($"  Message: {inner.Message}");
                    Console.WriteLine($"  Stack:\n{inner.StackTrace}");
                    inner = inner.InnerException;
                    depth++;
                }
                
                // Save VMA snapshot
                try
                {
                    var path = $"/tmp/maps_error_{DateTime.Now:HHmmss}.txt";
                    File.Copy("/proc/self/maps", path);
                    Console.WriteLine($"\nVMA snapshot: {path}");
                }
                catch { }
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
                Console.WriteLine($"  Parts Count: {response.PartsCount}");
            if (response.Headers?["Content-Length"] != null)
                Console.WriteLine($"  Content Length: {response.Headers["Content-Length"]}");
        }

        private static async Task DownloadUsingStreamAsync(
            TransferUtility transferUtility, 
            string filePath, 
            CancellationToken cancellationToken, 
            VMATracker vmaTracker, 
            ArrayPoolEventListener arrayPoolListener,
            GCEventListener gcListener,
            bool verboseHeap)
        {
            Console.WriteLine("Using OpenStreamWithResponseAsync API...");
            Console.WriteLine("NOTE: Stream mode only reads data (no file write) to test pure streaming performance");
            Console.WriteLine();
            
            var request = new TransferUtilityOpenStreamRequest
            {
                BucketName = BucketName,
                Key = Key,
                MaxInMemoryParts = 50,
            };

            var response = await transferUtility.OpenStreamWithResponseAsync(request, cancellationToken);
            
            Console.WriteLine($"Response metadata:");
            Console.WriteLine($"  ETag: {response.ETag}");
            Console.WriteLine($"  Last Modified: {response.LastModified}");
            if (response.PartsCount.HasValue)
                Console.WriteLine($"  Parts Count: {response.PartsCount}");
            
            long? contentLength = null;
            if (response.Headers?["Content-Length"] != null)
            {
                if (long.TryParse(response.Headers["Content-Length"], out long parsedLength))
                {
                    contentLength = parsedLength;
                    Console.WriteLine($"  Content Length: {FormatBytes(parsedLength)}");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Reading stream...");

            var downloadStart = Stopwatch.StartNew();
            int lastVmaCount = vmaTracker.CurrentCount;
            
            using (var stream = response.ResponseStream)
            {
                byte[] buffer = new byte[8 * 1024 * 1024]; 
                int bytesRead;
                long totalBytesRead = 0;
                long lastReportedBytes = 0;

                while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                {
                    totalBytesRead += bytesRead;

                    if (totalBytesRead - lastReportedBytes >= 100 * 1024 * 1024)
                    {
                        var elapsedSeconds = downloadStart.Elapsed.TotalSeconds;
                        var speedBytesPerSecond = totalBytesRead / elapsedSeconds;
                        
                        // Snapshot VMAs if significant growth
                        vmaTracker.SnapshotIfGrowth(5000);
                        
                        if (contentLength.HasValue)
                        {
                            var remainingBytes = contentLength.Value - totalBytesRead;
                            var etaSeconds = remainingBytes / speedBytesPerSecond;
                            var eta = TimeSpan.FromSeconds(etaSeconds);
                            
                            Console.WriteLine($"  Progress: {FormatBytes(totalBytesRead)} / {FormatBytes(contentLength.Value)} ({(double)totalBytesRead / contentLength.Value * 100:F2}%)");
                            Console.WriteLine($"    Speed: {FormatThroughputGbps(speedBytesPerSecond)} | Elapsed: {FormatTimeSpan(downloadStart.Elapsed)} | ETA: {FormatTimeSpan(eta)}");
                            Console.WriteLine($"    GC: {GetGCStats()}");
                            Console.WriteLine($"    GC Events: {gcListener}");
                            Console.WriteLine($"    VMAs: {vmaTracker}");
                            Console.WriteLine($"    ArrayPool: {arrayPoolListener}");
                            Console.WriteLine($"    {TrackingHttpClientFactory.GetStats()}");
                            
                            // Debug logging every 500MB
                            if (totalBytesRead % (500 * 1024 * 1024) == 0)
                            {
                                LogSuspiciousThreads();
                                LogArrayPoolLeaks();
                                LogMemoryPressure();
                                LogBufferFlow(arrayPoolListener, totalBytesRead, downloadStart.Elapsed);
                            }
                            
                            if (verboseHeap)
                            {
                                Console.WriteLine($"    GC Heap Detail:");
                                Console.WriteLine(GCHeapTracker.GetStats());
                                AnalyzeVMAvsGCHeap();
                            }
                        }
                        else
                        {
                            Console.WriteLine($"  Progress: {FormatBytes(totalBytesRead)}");
                            Console.WriteLine($"    Speed: {FormatThroughputGbps(speedBytesPerSecond)} | Elapsed: {FormatTimeSpan(downloadStart.Elapsed)}");
                            Console.WriteLine($"    GC: {GetGCStats()}");
                            Console.WriteLine($"    GC Events: {gcListener}");
                            Console.WriteLine($"    VMAs: {vmaTracker}");
                            Console.WriteLine($"    ArrayPool: {arrayPoolListener}");
                            Console.WriteLine($"    {TrackingHttpClientFactory.GetStats()}");
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
            var fragPercent = gcMemInfo.HeapSizeBytes > 0 ? gcMemInfo.FragmentedBytes * 100.0 / gcMemInfo.HeapSizeBytes : 0;
            
            return $"Gen0={gen0Count}, Gen1={gen1Count}, Gen2={gen2Count} | Heap={totalHeapMB:N0}MB | Gen2={gen2SizeMB:N0}MB | Frag={fragPercent:F1}%";
        }

        private static void AnalyzeVMAvsGCHeap()
        {
            try
            {
                var gcInfo = GC.GetGCMemoryInfo();
                var maps = File.ReadAllLines("/proc/self/maps");
                
                int rwAnon1to10MB = 0;
                int reservedAnon = 0;
                int vma64KB = 0;
                int vmaUnder1MB = 0;
                int vma10to100MB = 0;
                int vmaOver100MB = 0;
                long totalRwAnon = 0;
                long totalReserved = 0;
                
                // Categorize all VMAs by size and type
                var vmaCategories = new Dictionary<string, int>();
                var vmaSizes = new List<long>();
                
                foreach (var line in maps)
                {
                    var parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    var addrs = parts[0].Split('-');
                    long size = Convert.ToInt64(addrs[1], 16) - Convert.ToInt64(addrs[0], 16);
                    var perms = parts[1];
                    
                    vmaSizes.Add(size);
                    
                    // Categorize by permissions and backing
                    string category;
                    if (parts.Length < 6) // anonymous
                    {
                        category = $"{perms} anon";
                        if (perms == "rw-p") // read-write private = committed heap
                        {
                            totalRwAnon += size;
                            if (size == 64*1024) vma64KB++;
                            else if (size < 1024*1024) vmaUnder1MB++;
                            else if (size <= 10*1024*1024) rwAnon1to10MB++;
                            else if (size <= 100*1024*1024) vma10to100MB++;
                            else vmaOver100MB++;
                        }
                        else if (perms == "---p") // reserved address space
                        {
                            totalReserved += size;
                            reservedAnon++;
                        }
                    }
                    else
                    {
                        var backing = parts[5];
                        if (backing.Contains(".so") || backing.Contains("lib"))
                            category = $"{perms} lib";
                        else if (backing.Contains("["))
                            category = $"{perms} {backing}";
                        else
                            category = $"{perms} file";
                    }
                    
                    vmaCategories[category] = vmaCategories.GetValueOrDefault(category, 0) + 1;
                }
                
                // Calculate statistics
                vmaSizes.Sort();
                var medianSize = vmaSizes[vmaSizes.Count / 2];
                var avgSize = vmaSizes.Average();
                
                Console.WriteLine($"    [ENHANCED VMA vs GC Analysis]");
                Console.WriteLine($"      Total VMAs: {maps.Length:N0}");
                Console.WriteLine($"      VMA Size Stats: Median={medianSize/1024:N0}KB, Avg={avgSize/1024:N0}KB");
                Console.WriteLine($"      ");
                Console.WriteLine($"      Anonymous Memory Breakdown:");
                Console.WriteLine($"        64KB VMAs: {vma64KB:N0} (likely ArrayPool small buffers)");
                Console.WriteLine($"        <1MB VMAs: {vmaUnder1MB:N0} (small allocations)");
                Console.WriteLine($"        1-10MB VMAs: {rwAnon1to10MB:N0} (GC segments + large ArrayPool)");
                Console.WriteLine($"        10-100MB VMAs: {vma10to100MB:N0} (very large segments)");
                Console.WriteLine($"        >100MB VMAs: {vmaOver100MB:N0} (huge segments)");
                Console.WriteLine($"      ");
                Console.WriteLine($"      Memory Totals:");
                Console.WriteLine($"        rw-p anon (committed): {totalRwAnon/1024.0/1024.0/1024.0:F1}GB");
                Console.WriteLine($"        ---p anon (reserved):  {totalReserved/1024.0/1024.0/1024.0:F1}GB across {reservedAnon:N0} VMAs");
                Console.WriteLine($"        GC Committed:          {gcInfo.TotalCommittedBytes/1024.0/1024.0/1024.0:F1}GB");
                Console.WriteLine($"      ");
                
                var diff = Math.Abs(totalRwAnon - (long)gcInfo.TotalCommittedBytes);
                var matchPercent = 100.0 - (diff * 100.0 / Math.Max(totalRwAnon, (long)gcInfo.TotalCommittedBytes));
                Console.WriteLine($"      GC vs VMA Match: {matchPercent:F1}% (if >90%, GC is creating most VMAs)");
                
                // Show top VMA categories
                Console.WriteLine($"      ");
                Console.WriteLine($"      Top VMA Categories:");
                foreach (var kvp in vmaCategories.OrderByDescending(x => x.Value).Take(8))
                {
                    Console.WriteLine($"        {kvp.Key}: {kvp.Value:N0} VMAs");
                }
                
                // ArrayPool correlation analysis
                Console.WriteLine($"      ");
                Console.WriteLine($"      ArrayPool Correlation:");
                var potentialArrayPoolVMAs = vma64KB + vmaUnder1MB + rwAnon1to10MB;
                Console.WriteLine($"        Potential ArrayPool VMAs: {potentialArrayPoolVMAs:N0}");
                Console.WriteLine($"        Non-GC VMAs: {maps.Length - potentialArrayPoolVMAs - reservedAnon:N0}");
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"    [Enhanced VMA vs GC Analysis] Error: {ex.Message}");
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
            double bitsPerSecond = bytesPerSecond * 8;
            double gbps = bitsPerSecond / 1_000_000_000;
            
            if (gbps >= 1)
                return $"{gbps:N2} Gbps";
            else if (gbps >= 0.001)
                return $"{bitsPerSecond / 1_000_000:N2} Mbps";
            else
                return $"{bitsPerSecond / 1_000:N2} Kbps";
        }

        private static string FormatTimeSpan(TimeSpan timeSpan)
        {
            if (timeSpan.TotalDays >= 1)
                return $"{(int)timeSpan.TotalDays}d {timeSpan.Hours}h {timeSpan.Minutes}m";
            else if (timeSpan.TotalHours >= 1)
                return $"{(int)timeSpan.TotalHours}h {timeSpan.Minutes}m {timeSpan.Seconds}s";
            else if (timeSpan.TotalMinutes >= 1)
                return $"{(int)timeSpan.TotalMinutes}m {timeSpan.Seconds}s";
            else
                return $"{timeSpan.Seconds}s";
        }

        private static void LogSuspiciousThreads()
        {
            try
            {
                var threads = Process.GetCurrentProcess().Threads.Cast<ProcessThread>()
                    .Where(t => t.TotalProcessorTime.TotalSeconds > 1)
                    .OrderByDescending(t => t.TotalProcessorTime.TotalSeconds)
                    .Take(3);
                
                foreach (var thread in threads)
                {
                    Console.WriteLine($"    Thread {thread.Id}: CPU={thread.TotalProcessorTime.TotalSeconds:F1}s, State={thread.ThreadState}");
                }
            }
            catch { }
        }

        private static void LogArrayPoolLeaks()
        {
            try
            {
                // Force GC to see if it helps with ArrayPool returns
                var before = GC.GetTotalMemory(false);
                GC.Collect(2, GCCollectionMode.Forced, true);
                GC.WaitForPendingFinalizers();
                var after = GC.GetTotalMemory(false);
                
                Console.WriteLine($"    [DEBUG] Forced GC: {(before-after)/1024/1024:F1}MB freed");
            }
            catch { }
        }

        private static void LogMemoryPressure()
        {
            try
            {
                var workingSet = Process.GetCurrentProcess().WorkingSet64;
                var privateMemory = Process.GetCurrentProcess().PrivateMemorySize64;
                var gcMemory = GC.GetTotalMemory(false);
                
                Console.WriteLine($"    [MEMORY] WorkingSet={workingSet/1024/1024/1024:F1}GB, Private={privateMemory/1024/1024/1024:F1}GB, GC={gcMemory/1024/1024/1024:F1}GB");
                
                // Check if we're approaching memory limits
                var memInfo = GC.GetGCMemoryInfo();
                if (memInfo.MemoryLoadBytes > memInfo.TotalCommittedBytes * 2)
                {
                    Console.WriteLine($"    [WARNING] High memory pressure detected!");
                }
            }
            catch { }
        }

        private static void LogBufferFlow(ArrayPoolEventListener arrayPoolListener, long totalBytesRead, TimeSpan elapsed)
        {
            try
            {
                var outstanding = arrayPoolListener.OutstandingCount;
                var allocated = arrayPoolListener.AllocatedBytes;
                
                // Calculate rates
                var downloadRateMBps = totalBytesRead / elapsed.TotalSeconds / 1024 / 1024;
                var bufferGrowthRate = outstanding / elapsed.TotalSeconds;
                var memoryGrowthRateGBps = (allocated / 1024.0 / 1024.0 / 1024.0) / elapsed.TotalSeconds;
                
                Console.WriteLine($"    [BUFFER FLOW]");
                Console.WriteLine($"      Download Rate: {downloadRateMBps:F1} MB/s");
                Console.WriteLine($"      Buffer Growth: {bufferGrowthRate:F0} buffers/sec");
                Console.WriteLine($"      Memory Growth: {memoryGrowthRateGBps:F2} GB/sec");
                Console.WriteLine($"      Buffer Efficiency: {totalBytesRead / (double)allocated * 100:F1}% (should be ~100%)");
                
                // Predict time to VMA exhaustion
                var currentVMAs = GetCurrentVMACount();
                if (currentVMAs > 0)
                {
                    var vmaGrowthRate = currentVMAs / elapsed.TotalSeconds;
                    var timeToLimit = (65530 - currentVMAs) / vmaGrowthRate;
                    Console.WriteLine($"      VMA Growth: {vmaGrowthRate:F1} VMAs/sec");
                    if (timeToLimit > 0 && timeToLimit < 3600)
                        Console.WriteLine($"      Time to VMA limit: {TimeSpan.FromSeconds(timeToLimit):mm\\:ss}");
                }
            }
            catch { }
        }

        private static int GetCurrentVMACount()
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
    }
}
