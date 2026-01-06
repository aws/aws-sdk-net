#!/bin/bash

# S3 Download Optimal Configuration Calculator
# Calculates optimal ConcurrentServiceRequests and MaxInMemoryParts values

echo "=========================================="
echo "S3 Download Configuration Calculator"
echo "=========================================="
echo ""

# Function to convert human-readable size to GiB
parse_size_to_gib() {
    local size=$1
    local num=$(echo "$size" | sed 's/[^0-9.]//g')
    local unit=$(echo "$size" | sed 's/[0-9.]//g' | tr '[:lower:]' '[:upper:]')
    
    case "$unit" in
        T|TB|TIB)
            echo "scale=3; $num * 1024" | bc
            ;;
        G|GB|GIB)
            echo "$num"
            ;;
        M|MB|MIB)
            echo "scale=3; $num / 1024" | bc
            ;;
        K|KB|KIB)
            echo "scale=3; $num / 1024 / 1024" | bc
            ;;
        *)
            # Assume bytes
            echo "scale=3; $num / 1024 / 1024 / 1024" | bc
            ;;
    esac
}

# Get available memory in GiB
get_available_memory_gib() {
    if [[ -f /proc/meminfo ]]; then
        local mem_kb=$(grep MemAvailable /proc/meminfo | awk '{print $2}')
        echo "scale=2; $mem_kb / 1024 / 1024" | bc
    else
        echo "0"
    fi
}

# Get network interface with highest speed
get_network_interface_speed_gbps() {
    local max_speed=0
    
    # Check all network interfaces
    for iface in /sys/class/net/*/speed; do
        if [[ -f "$iface" ]]; then
            local speed=$(cat "$iface" 2>/dev/null)
            if [[ $speed =~ ^[0-9]+$ ]] && [[ $speed -gt $max_speed ]]; then
                max_speed=$speed
            fi
        fi
    done
    
    # Convert Mbps to Gbps
    if [[ $max_speed -gt 0 ]]; then
        echo "scale=2; $max_speed / 1000" | bc
    else
        echo "0"
    fi
}

# Run speedtest using speedtest-cli
run_speedtest_cli() {
    if command -v speedtest-cli &> /dev/null; then
        echo "Running speedtest-cli (this may take 30-60 seconds)..." >&2
        local result=$(speedtest-cli --simple 2>/dev/null | grep "Download:" | awk '{print $2}')
        if [[ -n "$result" ]]; then
            # Convert Mbit/s to Gbps
            echo "scale=2; $result / 1000" | bc
        else
            echo "0"
        fi
    else
        echo "0"
    fi
}

# Run speedtest using fast-cli (Netflix's speed test)
run_fast_cli() {
    if command -v fast &> /dev/null; then
        echo "Running fast-cli (this may take 10-20 seconds)..." >&2
        local result=$(fast --upload false 2>/dev/null | grep -oP '\d+(\.\d+)?' | head -1)
        if [[ -n "$result" ]]; then
            # Convert Mbps to Gbps
            echo "scale=2; $result / 1000" | bc
        else
            echo "0"
        fi
    else
        echo "0"
    fi
}

# Simple curl-based speed test using a fast CDN
run_simple_speed_test() {
    echo "Running simple speed test (downloading 100MB test file)..." >&2
    
    # Try multiple fast test files
    local test_urls=(
        "http://speedtest.tele2.net/100MB.zip"
        "http://ipv4.download.thinkbroadband.com/100MB.zip"
        "http://proof.ovh.net/files/100Mb.dat"
    )
    
    local best_speed=0
    
    for url in "${test_urls[@]}"; do
        # Download for max 10 seconds and calculate speed
        local output=$(curl -w "%{speed_download}" -o /dev/null -s --max-time 10 "$url" 2>/dev/null)
        if [[ -n "$output" ]] && [[ "$output" != "0" ]]; then
            # Convert bytes/sec to Gbps: (bytes/s * 8) / 1e9
            local speed_gbps=$(echo "scale=2; ($output * 8) / 1000000000" | bc 2>/dev/null)
            if [[ -n "$speed_gbps" ]] && [[ $(echo "$speed_gbps > $best_speed" | bc 2>/dev/null) -eq 1 ]]; then
                best_speed=$speed_gbps
            fi
        fi
    done
    
    if [[ -n "$best_speed" ]] && [[ $(echo "$best_speed > 0" | bc 2>/dev/null) -eq 1 ]]; then
        echo "$best_speed"
    else
        echo "0"
    fi
}

# Try to detect actual network speed using various methods
detect_network_speed() {
    local speed=0
    
    # Method 1: Try speedtest-cli (most accurate)
    speed=$(run_speedtest_cli)
    if [[ $(echo "$speed > 0" | bc) -eq 1 ]]; then
        echo "$speed"
        return
    fi
    
    # Method 2: Try fast-cli
    speed=$(run_fast_cli)
    if [[ $(echo "$speed > 0" | bc) -eq 1 ]]; then
        echo "$speed"
        return
    fi
    
    # Method 3: Try simple curl-based test
    speed=$(run_simple_speed_test)
    if [[ $(echo "$speed > 0" | bc) -eq 1 ]]; then
        echo "$speed"
        return
    fi
    
    echo "0"
}

# Get user inputs with defaults
echo "Detecting system configuration..."
echo ""

# Detect available memory
AVAILABLE_MEMORY_GIB=$(get_available_memory_gib)
echo "Detected Available Memory: ${AVAILABLE_MEMORY_GIB} GiB"

# Detect network interface speed
INTERFACE_SPEED=$(get_network_interface_speed_gbps)
if [[ $(echo "$INTERFACE_SPEED > 0" | bc) -eq 1 ]]; then
    echo "Detected Network Interface Speed: ${INTERFACE_SPEED} Gbps (link speed)"
fi

echo ""
echo "=========================================="
echo "Network Speed Detection"
echo "=========================================="
echo ""
echo "Would you like to run an actual speed test? (recommended)"
echo "  This will test your real download speed from the internet."
echo ""
echo "Options:"
echo "  1) Yes - Run automatic speed test (~30 seconds)"
echo "  2) No - Enter speed manually"
echo "  3) Skip - Use interface speed (${INTERFACE_SPEED} Gbps)"
echo ""
echo -n "Choice [1/2/3]: "
read SPEED_TEST_CHOICE

TESTED_NETWORK_GBPS=0
case "$SPEED_TEST_CHOICE" in
    1|"")
        echo ""
        echo "Running speed test..."
        TESTED_NETWORK_GBPS=$(detect_network_speed)
        if [[ $(echo "$TESTED_NETWORK_GBPS > 0" | bc) -eq 1 ]]; then
            echo "✓ Speed test completed: ${TESTED_NETWORK_GBPS} Gbps"
        else
            echo "✗ Speed test failed. Will prompt for manual entry."
        fi
        ;;
    3)
        if [[ $(echo "$INTERFACE_SPEED > 0" | bc) -eq 1 ]]; then
            TESTED_NETWORK_GBPS=$INTERFACE_SPEED
            echo "Using interface speed: ${TESTED_NETWORK_GBPS} Gbps"
        else
            echo "No interface speed detected. Will prompt for manual entry."
        fi
        ;;
esac

echo ""
echo "=========================================="
echo "Configuration Input"
echo "=========================================="

# Get network bandwidth from user
if [[ $(echo "$TESTED_NETWORK_GBPS > 0" | bc) -eq 1 ]]; then
    echo -n "Enter network bandwidth in Gbps [tested: ${TESTED_NETWORK_GBPS}]: "
else
    echo -n "Enter network bandwidth in Gbps: "
fi
read NETWORK_GBPS
if [[ -z "$NETWORK_GBPS" ]] && [[ $(echo "$TESTED_NETWORK_GBPS > 0" | bc) -eq 1 ]]; then
    NETWORK_GBPS=$TESTED_NETWORK_GBPS
elif [[ -z "$NETWORK_GBPS" ]]; then
    NETWORK_GBPS=10  # Default to 10 Gbps
fi

# Get part size
echo -n "Enter part size (e.g., 8MB, 5GB, 5GiB) [default: 8MB]: "
read PART_SIZE_INPUT
if [[ -z "$PART_SIZE_INPUT" ]]; then
    PART_SIZE_INPUT="8MB"
fi

# Convert part size to GiB
PART_SIZE_GIB=$(parse_size_to_gib "$PART_SIZE_INPUT")

echo ""
echo "=========================================="
echo "Calculations"
echo "=========================================="

# Calculate bandwidth in GiB/s
# For Gbps (decimal): divide by 8 to get GB/s, then convert to GiB/s
# Approximation: 1 Gbps ≈ 0.1164 GiB/s
BANDWIDTH_GIBS=$(echo "scale=4; $NETWORK_GBPS * 0.1164" | bc)

echo "Network Bandwidth: ${NETWORK_GBPS} Gbps = ${BANDWIDTH_GIBS} GiB/s"
echo "Part Size: ${PART_SIZE_INPUT} = ${PART_SIZE_GIB} GiB"
echo ""

# Calculate time to download one part
TIME_PER_PART=$(echo "scale=4; $PART_SIZE_GIB / $BANDWIDTH_GIBS" | bc)
echo "Time to download one part: ${TIME_PER_PART} seconds"

# Calculate concurrent requests
# For small parts (<1s), use more concurrency
# For large parts (>1s), use less concurrency
if [[ $(echo "$TIME_PER_PART < 1" | bc) -eq 1 ]] && [[ $(echo "$TIME_PER_PART > 0" | bc) -eq 1 ]]; then
    # Fast parts: need more in flight to keep pipeline full
    CONCURRENT_BASE=$(echo "scale=0; (1 / $TIME_PER_PART * 10) / 1" | bc)
elif [[ $(echo "$TIME_PER_PART >= 1" | bc) -eq 1 ]]; then
    # Slow parts: fewer needed
    CONCURRENT_BASE=$(echo "scale=0; (50 / $TIME_PER_PART) / 1" | bc)
else
    CONCURRENT_BASE=50
fi

# Cap between 10 and 100
if [[ $(echo "$CONCURRENT_BASE < 10" | bc) -eq 1 ]]; then
    CONCURRENT_REQUESTS=10
elif [[ $(echo "$CONCURRENT_BASE > 100" | bc) -eq 1 ]]; then
    CONCURRENT_REQUESTS=100
else
    CONCURRENT_REQUESTS=$CONCURRENT_BASE
fi

echo "Calculated concurrent requests: ${CONCURRENT_REQUESTS}"

# Calculate MaxInMemoryParts
# Use 70% of available memory conservatively
CONSERVATIVE_MEMORY=$(echo "scale=2; $AVAILABLE_MEMORY_GIB * 0.70" | bc)
MAX_IN_MEMORY_PARTS=$(echo "scale=0; ($CONSERVATIVE_MEMORY / $PART_SIZE_GIB) / 1" | bc)

# Ensure at least 10 parts can be buffered
if [[ $(echo "$MAX_IN_MEMORY_PARTS < 10" | bc) -eq 1 ]]; then
    MAX_IN_MEMORY_PARTS=10
fi

MEMORY_USAGE=$(echo "scale=2; $MAX_IN_MEMORY_PARTS * $PART_SIZE_GIB" | bc)

echo "Conservative memory allocation (70%): ${CONSERVATIVE_MEMORY} GiB"
echo "Max parts in memory: ${MAX_IN_MEMORY_PARTS}"
echo "Memory usage: ${MEMORY_USAGE} GiB"

echo ""
echo "=========================================="
echo "RECOMMENDED CONFIGURATION"
echo "=========================================="
echo ""
echo "Add to your C# code:"
echo ""
echo "var transferConfig = new TransferUtilityConfig"
echo "{"
echo "    ConcurrentServiceRequests = ${CONCURRENT_REQUESTS}"
echo "};"
echo ""
echo "var request = new TransferUtilityOpenStreamRequest"
echo "{"
echo "    BucketName = \"your-bucket\","
echo "    Key = \"your-key\","
echo "    MaxInMemoryParts = ${MAX_IN_MEMORY_PARTS}"
echo "};"
echo ""
echo "=========================================="
echo "Performance Estimates"
echo "=========================================="

# Ask for file size to calculate download time
echo -n "Enter total file size for time estimate (e.g., 50TB) [optional, press Enter to skip]: "
read FILE_SIZE_INPUT
if [[ -n "$FILE_SIZE_INPUT" ]]; then
    FILE_SIZE_GIB=$(parse_size_to_gib "$FILE_SIZE_INPUT")
    
    DOWNLOAD_TIME_SECONDS=$(echo "scale=0; ($FILE_SIZE_GIB / $BANDWIDTH_GIBS) / 1" | bc)
    DOWNLOAD_TIME_MINUTES=$(echo "scale=0; ($DOWNLOAD_TIME_SECONDS / 60) / 1" | bc)
    DOWNLOAD_TIME_HOURS=$(echo "scale=2; $DOWNLOAD_TIME_MINUTES / 60" | bc)
    
    echo ""
    echo "File Size: ${FILE_SIZE_INPUT} (${FILE_SIZE_GIB} GiB)"
    echo "Estimated download time at full speed:"
    echo "  - Seconds: ${DOWNLOAD_TIME_SECONDS}"
    echo "  - Minutes: ${DOWNLOAD_TIME_MINUTES}"
    echo "  - Hours: ${DOWNLOAD_TIME_HOURS}"
    echo ""
    echo "Note: Add 10-20% overhead for realistic time"
fi

echo ""
echo "=========================================="
echo "Monitoring Commands"
echo "=========================================="
echo ""
echo "During download, monitor with:"
echo "  Memory: watch -n 1 free -h"
echo "  Network: nethogs (per-process bandwidth)"
echo "  Network: iftop (overall traffic)"
echo "  Process: htop"
echo ""
