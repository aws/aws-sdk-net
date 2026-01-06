# S3 Download Tester

A .NET 8.0 console application for testing AWS S3 download performance using the AWS SDK's TransferUtility with enhanced response APIs.

## Features

- **Two Download APIs:**
  - `DownloadWithResponseAsync` - Downloads directly to disk with parallel multipart downloads
  - `OpenStreamWithResponseAsync` - Streams data with in-memory buffering
  
- **High-Performance Configuration:**
  - Configurable concurrent HTTP requests (default: 100)
  - Configurable in-memory part buffering (default: 1024 parts)
  - 40-hour cancellation token timeout
  
- **Comprehensive Timing:**
  - Stopwatch-based performance measurement
  - Formatted output in milliseconds and human-readable duration
  
- **Progress Monitoring:**
  - Real-time progress reporting for stream API
  - File size and metadata display

## Quick Start

### Build the Project

```bash
cd S3DownloadTester
dotnet build
```

### Run with Default Settings

```bash
# Using DownloadWithResponseAsync (default)
dotnet run

# Using OpenStreamWithResponseAsync
dotnet run --stream
```

## Configuration Script with Automatic Speed Test

### Calculate Optimal Settings for Your System

The included `calculate-optimal-config.sh` script automatically detects your system's network bandwidth and available memory, then calculates optimal configuration values.

#### Usage on Linux

```bash
# Make the script executable (only needed once)
chmod +x calculate-optimal-config.sh

# Run the script
./calculate-optimal-config.sh
```

**The script now includes automatic speed testing!**

When you run the script, you'll be prompted with three options:
1. **Run automatic speed test** (recommended) - Automatically tests your internet speed
2. **Enter speed manually** - Enter your known network speed
3. **Use interface speed** - Use the detected network interface link speed

The automatic speed test tries multiple methods in order:
- `speedtest-cli` (if installed) - Most accurate
- `fast-cli` (Netflix's speed test, if installed)
- Simple curl-based test - Downloads from public CDN endpoints

#### Installing Speed Test Tools (Optional)

For the most accurate results, install `speedtest-cli`:

```bash
# Ubuntu/Debian
sudo apt-get install speedtest-cli

# CentOS/RHEL
sudo yum install speedtest-cli

# Or via pip
pip install speedtest-cli

# Alternative: fast-cli (Netflix)
npm install -g fast-cli
```

**Note:** The script works without these tools installed - it will fall back to a simple curl-based test or manual entry.

#### Example Script Output

```
==========================================
S3 Download Configuration Calculator
==========================================

Detecting system configuration...
Detected Available Memory: 490.29 GiB
Detected Network Interface Speed: 200.00 Gbps (link speed)

==========================================
Network Speed Detection
==========================================

Would you like to run an actual speed test? (recommended)
  This will test your real download speed from the internet.

Options:
  1) Yes - Run automatic speed test (~30 seconds)
  2) No - Enter speed manually
  3) Skip - Use interface speed (200.00 Gbps)

Choice [1/2/3]: 1

Running speed test...
Running speedtest-cli (this may take 30-60 seconds)...
✓ Speed test completed: 180.50 Gbps

==========================================
Configuration Input
==========================================
Enter network bandwidth in Gbps [tested: 180.50]: 
Enter part size (e.g., 8MB, 5GB, 5GiB) [default: 8MB]: 5GiB

==========================================
Calculations
==========================================
Network Bandwidth: 180.50 Gbps = 21.0102 GiB/s
Part Size: 5GiB = 5.000 GiB

Time to download one part: 0.2380 seconds
Calculated concurrent requests: 42

==========================================
RECOMMENDED CONFIGURATION
==========================================

Add to your C# code:

var transferConfig = new TransferUtilityConfig
{
    ConcurrentServiceRequests = 42
};

var request = new TransferUtilityOpenStreamRequest
{
    BucketName = "your-bucket",
    Key = "your-key",
    MaxInMemoryParts = 68
};
```

## Manual Configuration

Edit `Program.cs` to customize the configuration:

```csharp
// Configure TransferUtility for high performance
var transferConfig = new TransferUtilityConfig
{
    ConcurrentServiceRequests = 100  // Adjust based on network bandwidth
};

// For OpenStreamWithResponseAsync
var request = new TransferUtilityOpenStreamRequest
{
    BucketName = BucketName,
    Key = Key,
    MaxInMemoryParts = 1024  // Adjust based on available memory
};
```

### Configuration Guidelines

#### ConcurrentServiceRequests
- **Purpose:** Number of parallel HTTP requests to S3
- **Formula:** `min(100, bandwidth_gbps / 10)`
- **Range:** 10-100 for most scenarios
- **Examples:**
  - 1 Gbps network: 10-20 requests
  - 10 Gbps network: 50-100 requests
  - 100+ Gbps network: 100 requests (maximum recommended)

#### MaxInMemoryParts
- **Purpose:** Number of parts to buffer in memory (OpenStreamWithResponseAsync only)
- **Formula:** `available_memory_gb * 128` (for default 8MB parts)
- **Formula (custom):** `(available_memory_gb * 0.7) / part_size_gib`
- **Examples:**
  - 8 GB available: MaxInMemoryParts = 1024 (8GB memory)
  - 16 GB available: MaxInMemoryParts = 2048 (16GB memory)
  - 32 GB available: MaxInMemoryParts = 4096 (32GB memory)

## Default Configuration

The project is pre-configured for:
- **Bucket:** `hagrid-garrett-test`
- **Key:** `test-uploads//hagrid/50TB`
- **Download Path:** `/hagrid/50TB`
- **Concurrent Requests:** 100
- **Max In-Memory Parts:** 1024 (for stream API)
- **Cancellation Timeout:** 40 hours

## Monitoring on Linux

While the download is running, monitor system resources:

```bash
# Memory usage (updates every second)
watch -n 1 free -h

# Network bandwidth per process
sudo nethogs

# Network traffic overview
sudo iftop

# CPU and process statistics
htop
```

## Performance Estimates

Use the configuration script to calculate expected download times:

### Example: 50 TB file with 200 Gbps network
- Theoretical: ~31 minutes
- Realistic (with overhead): 35-45 minutes

### Example: 50 TB file with 10 Gbps network
- Theoretical: ~10.3 hours
- Realistic (with overhead): 11-13 hours

## Architecture

### DownloadWithResponseAsync
- Downloads directly to disk using multipart downloads
- Automatically uses parallel requests for large files
- Returns response metadata (ETag, Last Modified, etc.)

### OpenStreamWithResponseAsync
- Returns a readable stream with intelligent buffering
- Downloads parts in parallel and buffers in memory
- Allows streaming consumption while downloading continues
- Memory-efficient with configurable buffer limits

## Troubleshooting

### Out of Memory Errors
Reduce `MaxInMemoryParts`:
```csharp
MaxInMemoryParts = 512  // Reduce from 1024
```

### Network Not Saturated
Increase `ConcurrentServiceRequests`:
```csharp
ConcurrentServiceRequests = 150  // Increase from 100
```

### Connection Exhaustion
Reduce `ConcurrentServiceRequests`:
```csharp
ConcurrentServiceRequests = 50  // Reduce from 100
```

## Requirements

- .NET 8.0 SDK
- AWS credentials configured (via environment variables, AWS CLI, or IAM role)
- Linux environment (for optimal performance and monitoring)
- `bc` utility (for configuration script calculations)
- Optional: `speedtest-cli` or `fast-cli` for automatic speed testing

## Project Structure

```
S3DownloadTester/
├── Program.cs                      # Main application
├── S3DownloadTester.csproj         # Project file
├── calculate-optimal-config.sh     # Configuration calculator with auto speed test
└── README.md                       # This file
```

## License

This project uses the AWS SDK for .NET, which is licensed under the Apache License 2.0.
