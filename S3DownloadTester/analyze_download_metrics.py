#!/usr/bin/env python3
"""
S3 Download Metrics Analyzer
Parses log output and creates visualizations to understand memory and VMA issues
"""

import re
import sys
import matplotlib.pyplot as plt
import matplotlib.dates as mdates
from datetime import datetime, timedelta
import argparse

class DownloadMetrics:
    def __init__(self):
        self.timestamps = []
        self.progress_gb = []
        self.speed_gbps = []
        self.heap_mb = []
        self.gen2_mb = []
        self.vma_current = []
        self.vma_percent = []
        self.arraypool_rent = []
        self.arraypool_pooled = []  # NEW: Reused from pool
        self.arraypool_return = []
        self.arraypool_allocate = []
        self.arraypool_outstanding = []
        self.arraypool_allocated_mb = []
        
        # NEW: HTTP tracking metrics
        self.http_active = []
        self.http_total = []
        self.http_received_mb = []
        
        # NEW: Buffer flow analysis metrics
        self.download_rate_mbps = []
        self.buffer_growth_rate = []
        self.memory_growth_rate_gbps = []
        self.buffer_efficiency = []
        self.vma_growth_rate = []
        # NEW: Enhanced VMA analysis metrics
        self.vma_total = []
        self.vma_median_kb = []
        self.vma_avg_kb = []
        self.vma_64kb = []
        self.vma_under1mb = []
        self.vma_1to10mb = []
        self.vma_10to100mb = []
        self.vma_over100mb = []
        self.vma_rw_anon = []
        self.vma_reserved_anon = []
        self.vma_gc_match_percent = []
        
    def parse_log_file(self, filename):
        """Parse the log file and extract metrics"""
        print(f"Parsing log file: {filename}")
        
        with open(filename, 'r') as f:
            lines = f.readlines()
        
        # Collect metrics for each progress report
        start_time = None
        i = 0
        
        while i < len(lines):
            line = lines[i]
            
            # Look for Progress line as the start of a data point
            progress_match = re.search(r'Progress: ([\d.]+) (GB|MB)', line)
            if progress_match:
                # Found a progress line - now collect all metrics for this data point
                value = float(progress_match.group(1))
                unit = progress_match.group(2)
                progress = value if unit == 'GB' else value / 1024.0
                
                # Initialize variables for this data point
                speed_gbps = None
                timestamp = None
                heap = None
                gen2 = None
                vma_current = None
                vma_percent = None
                rent = None
                ret = None
                allocate = None
                allocated_mb = None
                http_active = None
                http_total = None
                http_received = None
                
                # Look ahead at the next few lines for associated metrics
                for j in range(i, min(i + 10, len(lines))):
                    next_line = lines[j]
                    
                    # Speed and elapsed time
                    if speed_gbps is None:
                        speed_match = re.search(r'Speed: ([\d.]+) (Gbps|Mbps)', next_line)
                        if speed_match:
                            speed = float(speed_match.group(1))
                            unit = speed_match.group(2)
                            speed_gbps = speed if unit == 'Gbps' else speed / 1000.0
                            
                            elapsed_match = re.search(r'Elapsed: ([\dhms ]+)', next_line)
                            if elapsed_match:
                                elapsed_str = elapsed_match.group(1)
                                elapsed = self._parse_timespan(elapsed_str)
                                if start_time is None:
                                    start_time = datetime.now()
                                timestamp = start_time + elapsed
                    
                    # GC metrics
                    if heap is None:
                        gc_match = re.search(r'GC: Gen0=(\d+), Gen1=(\d+), Gen2=(\d+) \| Heap=([\d,]+)MB \| Gen2=([\d,]+)MB', next_line)
                        if gc_match:
                            heap = float(gc_match.group(4).replace(',', ''))
                            gen2 = float(gc_match.group(5).replace(',', ''))
                    
                    # VMA metrics
                    if vma_current is None and vma_percent is None:
                        vma_match = re.search(r'VMAs: Current=([\d-]+) \(([\d.]+)%\)', next_line)
                        if vma_match:
                            vma_current = int(vma_match.group(1)) if vma_match.group(1) != '-1' else None
                            vma_percent = float(vma_match.group(2))
                    
                    # ArrayPool metrics - NEW FORMAT: Rent=X (Pooled=Y, New=Z), Return=A, Outstanding=B, AllocatedMB=C
                    if rent is None:
                        # Try new format first
                        arraypool_match = re.search(r'ArrayPool: Rent=([\d,]+) \(Pooled=([\d,]+), New=([\d,]+)\), Return=([\d,]+), Outstanding=([\d,]+), AllocatedMB=([\d,]+\.?\d*)', next_line)
                        if arraypool_match:
                            rent = int(arraypool_match.group(1).replace(',', ''))
                            pooled = int(arraypool_match.group(2).replace(',', ''))
                            allocate = int(arraypool_match.group(3).replace(',', ''))  # "New" in new format
                            ret = int(arraypool_match.group(4).replace(',', ''))
                            outstanding = int(arraypool_match.group(5).replace(',', ''))
                            allocated_mb = float(arraypool_match.group(6).replace(',', ''))
                        else:
                            # Fall back to old format for backwards compatibility
                            arraypool_match = re.search(r'ArrayPool: Rent=([\d,]+), Return=([\d,]+), Allocate=([\d,]+), AllocatedMB=([\d,]+\.?\d*)', next_line)
                            if arraypool_match:
                                rent = int(arraypool_match.group(1).replace(',', ''))
                                ret = int(arraypool_match.group(2).replace(',', ''))
                                allocate = int(arraypool_match.group(3).replace(',', ''))
                                allocated_mb = float(arraypool_match.group(4).replace(',', ''))
                                pooled = max(0, rent - allocate)  # Calculate pooled for old format
                                outstanding = rent - ret  # Calculate outstanding for old format
                    
                    # HTTP tracking metrics - NEW
                    if http_active is None:
                        http_match = re.search(r'HTTP: Active=(\d+), Total=(\d+), Received=([\d,]+)MB', next_line)
                        if http_match:
                            http_active = int(http_match.group(1))
                            http_total = int(http_match.group(2))
                    # Enhanced VMA analysis - NEW
                    if 'Total VMAs:' in next_line:
                        vma_total_match = re.search(r'Total VMAs: ([\d,]+)', next_line)
                        if vma_total_match:
                            vma_total = int(vma_total_match.group(1).replace(',', ''))
                    
                    if 'VMA Size Stats:' in next_line:
                        vma_stats_match = re.search(r'Median=([\d,]+)KB, Avg=([\d,]+)KB', next_line)
                        if vma_stats_match:
                            vma_median = int(vma_stats_match.group(1).replace(',', ''))
                            vma_avg = int(vma_stats_match.group(2).replace(',', ''))
                    
                    if '1-10MB VMAs:' in next_line:
                        vma_breakdown_match = re.search(r'1-10MB VMAs: ([\d,]+)', next_line)
                        if vma_breakdown_match:
                            vma_1to10mb = int(vma_breakdown_match.group(1).replace(',', ''))
                    
                    if '10-100MB VMAs:' in next_line:
                        vma_large_match = re.search(r'10-100MB VMAs: ([\d,]+)', next_line)
                        if vma_large_match:
                            vma_10to100mb = int(vma_large_match.group(1).replace(',', ''))
                    
                    if 'rw-p anon:' in next_line:
                        rw_anon_match = re.search(r'rw-p anon: ([\d,]+) VMAs', next_line)
                        if rw_anon_match:
                            vma_rw_anon = int(rw_anon_match.group(1).replace(',', ''))
                    
                    if 'GC vs VMA Match:' in next_line:
                        gc_match_match = re.search(r'GC vs VMA Match: ([\d.]+)%', next_line)
                        if gc_match_match:
                            vma_gc_match = float(gc_match_match.group(1))
                    
                    # Stop if we hit the next Progress line
                    if j > i and re.search(r'Progress: ([\d.]+) (GB|MB)', next_line):
                        break
                
                # Only add this data point if we have all required metrics
                if timestamp is not None and speed_gbps is not None:
                    self.timestamps.append(timestamp)
                    self.progress_gb.append(progress)
                    self.speed_gbps.append(speed_gbps)
                    
                    # Optional metrics - use last known value or None
                    if heap is not None:
                        self.heap_mb.append(heap)
                        self.gen2_mb.append(gen2)
                    else:
                        # Use last value if available, otherwise 0
                        self.heap_mb.append(self.heap_mb[-1] if self.heap_mb else 0)
                        self.gen2_mb.append(self.gen2_mb[-1] if self.gen2_mb else 0)
                    
                    # DEBUG: Check array lengths after heap append
                    if len(self.timestamps) != len(self.heap_mb):
                        print(f"⚠️  DESYNC at line {i}: timestamps={len(self.timestamps)}, heap_mb={len(self.heap_mb)}")
                        print(f"   Progress={progress}, heap={'found' if heap is not None else 'missing'}")
                    
                    if vma_current is not None or vma_percent is not None:
                        self.vma_current.append(vma_current)
                        self.vma_percent.append(vma_percent if vma_percent is not None else 0)
                    else:
                        self.vma_current.append(self.vma_current[-1] if self.vma_current else None)
                        self.vma_percent.append(self.vma_percent[-1] if self.vma_percent else 0)
                    
                    if rent is not None:
                        self.arraypool_rent.append(rent)
                        self.arraypool_pooled.append(pooled)
                        self.arraypool_return.append(ret)
                        self.arraypool_allocate.append(allocate)
                        self.arraypool_outstanding.append(outstanding)
                        self.arraypool_allocated_mb.append(allocated_mb)
                    else:
                        self.arraypool_rent.append(self.arraypool_rent[-1] if self.arraypool_rent else 0)
                        self.arraypool_pooled.append(self.arraypool_pooled[-1] if self.arraypool_pooled else 0)
                        self.arraypool_return.append(self.arraypool_return[-1] if self.arraypool_return else 0)
                        self.arraypool_allocate.append(self.arraypool_allocate[-1] if self.arraypool_allocate else 0)
                        self.arraypool_outstanding.append(self.arraypool_outstanding[-1] if self.arraypool_outstanding else 0)
                        self.arraypool_allocated_mb.append(self.arraypool_allocated_mb[-1] if self.arraypool_allocated_mb else 0)
                    
                    # HTTP metrics - NEW
                    if http_active is not None:
                        self.http_active.append(http_active)
                        self.http_total.append(http_total)
                        self.http_received_mb.append(http_received)
                    else:
                        self.http_active.append(self.http_active[-1] if self.http_active else 0)
                        self.http_total.append(self.http_total[-1] if self.http_total else 0)
                        self.http_received_mb.append(self.http_received_mb[-1] if self.http_received_mb else 0)
            
            i += 1
        
        print(f"Parsed {len(self.timestamps)} data points")
        print(f"Array lengths: timestamps={len(self.timestamps)}, heap_mb={len(self.heap_mb)}, gen2_mb={len(self.gen2_mb)}")
        print(f"               vma_current={len(self.vma_current)}, arraypool_outstanding={len(self.arraypool_outstanding)}")
        
    def _parse_timespan(self, timespan_str):
        """Parse timespan like '1m 21s' or '3d 0h 20m' to timedelta"""
        total_seconds = 0
        
        # Days
        days_match = re.search(r'(\d+)d', timespan_str)
        if days_match:
            total_seconds += int(days_match.group(1)) * 86400
        
        # Hours
        hours_match = re.search(r'(\d+)h', timespan_str)
        if hours_match:
            total_seconds += int(hours_match.group(1)) * 3600
        
        # Minutes
        minutes_match = re.search(r'(\d+)m', timespan_str)
        if minutes_match:
            total_seconds += int(minutes_match.group(1)) * 60
        
        # Seconds
        seconds_match = re.search(r'(\d+)s', timespan_str)
        if seconds_match:
            total_seconds += int(seconds_match.group(1))
        
        return timedelta(seconds=total_seconds)
    
    def plot_metrics(self, output_file='download_metrics.png'):
        """Create comprehensive visualization"""
        fig, axes = plt.subplots(3, 2, figsize=(16, 12))
        fig.suptitle('S3 Download Metrics Analysis - VMA Exhaustion', fontsize=16, fontweight='bold')
        
        # 1. Progress and Speed
        ax1 = axes[0, 0]
        ax1_twin = ax1.twinx()
        ax1.plot(self.timestamps, self.progress_gb, 'b-', linewidth=2, label='Progress (GB)')
        ax1_twin.plot(self.timestamps, self.speed_gbps, 'g--', linewidth=2, label='Speed (Gbps)')
        ax1.set_xlabel('Time')
        ax1.set_ylabel('Progress (GB)', color='b')
        ax1_twin.set_ylabel('Speed (Gbps)', color='g')
        ax1.tick_params(axis='y', labelcolor='b')
        ax1_twin.tick_params(axis='y', labelcolor='g')
        ax1.set_title('Download Progress & Speed')
        ax1.grid(True, alpha=0.3)
        
        # 2. Memory Usage (Heap)
        ax2 = axes[0, 1]
        ax2.plot(self.timestamps, self.heap_mb, 'r-', linewidth=2, label='Total Heap')
        ax2.plot(self.timestamps, self.gen2_mb, 'orange', linewidth=2, label='Gen2')
        ax2.set_xlabel('Time')
        ax2.set_ylabel('Memory (MB)')
        ax2.set_title('GC Heap Memory Usage')
        ax2.legend()
        ax2.grid(True, alpha=0.3)
        
        # Add danger zone annotation
        max_heap = max(self.heap_mb) if self.heap_mb else 0
        if max_heap > 100000:  # Over 100GB
            ax2.axhspan(100000, max(self.heap_mb), alpha=0.2, color='red', label='Danger Zone')
            ax2.text(self.timestamps[len(self.timestamps)//2], max_heap * 0.9, 
                    'EXCESSIVE\nMEMORY', ha='center', fontsize=12, fontweight='bold', color='red')
        
        # 3. VMA Usage - THE KEY METRIC
        ax3 = axes[1, 0]
        valid_vmas = [(t, v) for t, v in zip(self.timestamps, self.vma_current) if v is not None]
        if valid_vmas:
            times, vmas = zip(*valid_vmas)
            ax3.plot(times, vmas, 'purple', linewidth=3, label='VMA Count')
        ax3.axhline(y=65530, color='red', linestyle='--', linewidth=2, label='Kernel Limit (65,530)')
        ax3.axhspan(60000, 65530, alpha=0.2, color='red')
        ax3.set_xlabel('Time')
        ax3.set_ylabel('VMA Count')
        ax3.set_title('⚠️ VMA Exhaustion (Crash at 100%)')
        ax3.legend()
        ax3.grid(True, alpha=0.3)
        
        # Add crash annotation if we hit the limit
        if any(v and v >= 65530 for v in self.vma_current if v is not None):
            crash_idx = next(i for i, v in enumerate(self.vma_current) if v and v >= 65530)
            ax3.annotate('CRASH!', 
                        xy=(self.timestamps[crash_idx], 65530),
                        xytext=(self.timestamps[crash_idx], 55000),
                        arrowprops=dict(facecolor='red', shrink=0.05, width=3),
                        fontsize=14, fontweight='bold', color='red',
                        bbox=dict(boxstyle='round', facecolor='red', alpha=0.3))
        
        # 4. VMA Percentage
        ax4 = axes[1, 1]
        ax4.plot(self.timestamps, self.vma_percent, 'purple', linewidth=3)
        ax4.axhline(y=100, color='red', linestyle='--', linewidth=2, label='100% Limit')
        ax4.axhspan(90, 100, alpha=0.2, color='red')
        ax4.set_xlabel('Time')
        ax4.set_ylabel('VMA Usage (%)')
        ax4.set_title('VMA Usage Percentage (Crash Zone)')
        ax4.set_ylim([0, 105])
        ax4.grid(True, alpha=0.3)
        ax4.legend()
        
        # 5. ArrayPool - Outstanding Buffers
        ax5 = axes[2, 0]
        ax5.plot(self.timestamps, [x/1000 for x in self.arraypool_outstanding], 'brown', linewidth=2)
        ax5.set_xlabel('Time')
        ax5.set_ylabel('Outstanding Buffers (thousands)')
        ax5.set_title('ArrayPool Outstanding Buffers (Rent - Return)')
        ax5.grid(True, alpha=0.3)
        
        # Add annotation for excessive buffers
        max_outstanding = max(self.arraypool_outstanding) if self.arraypool_outstanding else 0
        if max_outstanding > 100000:
            ax5.text(self.timestamps[len(self.timestamps)//2], max_outstanding/2000, 
                    f'Peak: {max_outstanding:,} buffers\n~{max_outstanding * 64 / 1024 / 1024:.0f} GB!', 
                    ha='center', fontsize=10, fontweight='bold', 
                    bbox=dict(boxstyle='round', facecolor='yellow', alpha=0.5))
        
        # 6. ArrayPool - Pool Efficiency
        ax6 = axes[2, 1]
        # Show pooled (reused) vs allocate (new) - stacked area chart
        if self.arraypool_pooled:
            ax6.fill_between(self.timestamps, 0, [x/1000 for x in self.arraypool_pooled], 
                            alpha=0.6, color='green', label='Pooled (Reused - No VMA)')
            ax6.fill_between(self.timestamps, [x/1000 for x in self.arraypool_pooled], 
                            [(p+a)/1000 for p, a in zip(self.arraypool_pooled, self.arraypool_allocate)],
                            alpha=0.6, color='red', label='Allocate (NEW - Creates VMA)')
        ax6.set_xlabel('Time')
        ax6.set_ylabel('Buffer Requests (thousands)')
        ax6.set_title('ArrayPool Efficiency: Reuse vs New Allocation')
        ax6.legend(fontsize=9)
        ax6.grid(True, alpha=0.3)
        
        # Add efficiency annotation
        if self.arraypool_rent[-1] > 0:
            pool_efficiency = (self.arraypool_pooled[-1] / self.arraypool_rent[-1]) * 100
            color = 'green' if pool_efficiency > 80 else 'orange' if pool_efficiency > 50 else 'red'
            ax6.text(self.timestamps[len(self.timestamps)//2], max(self.arraypool_rent)/2000, 
                    f'Pool Efficiency: {pool_efficiency:.1f}%\n({self.arraypool_pooled[-1]:,} reused / {self.arraypool_rent[-1]:,} total)', 
                    ha='center', fontsize=10, fontweight='bold', 
                    bbox=dict(boxstyle='round', facecolor=color, alpha=0.3))
        
        # Format time axis for all plots
        for ax in axes.flat:
            ax.xaxis.set_major_formatter(mdates.DateFormatter('%H:%M:%S'))
            plt.setp(ax.xaxis.get_majorticklabels(), rotation=45, ha='right')
        
        plt.tight_layout()
        plt.savefig(output_file, dpi=300, bbox_inches='tight')
        print(f"\n✓ Visualization saved to: {output_file}")
        
        # Show the plot
        plt.show()
    
    def print_summary(self):
        """Print summary statistics"""
        if not self.timestamps:
            print("No data to summarize")
            return
        
        print("\n" + "="*70)
        print("DOWNLOAD METRICS SUMMARY")
        print("="*70)
        
        print(f"\n📊 Progress:")
        print(f"   Total downloaded: {self.progress_gb[-1]:.2f} GB")
        print(f"   Average speed: {sum(self.speed_gbps)/len(self.speed_gbps):.2f} Gbps")
        print(f"   Duration: {self.timestamps[-1] - self.timestamps[0]}")
        
        print(f"\n💾 Memory:")
        print(f"   Peak heap: {max(self.heap_mb):,.0f} MB ({max(self.heap_mb)/1024:.1f} GB)")
        print(f"   Peak Gen2: {max(self.gen2_mb):,.0f} MB")
        
        print(f"\n🗺️  VMAs:")
        valid_vmas = [v for v in self.vma_current if v is not None]
        if valid_vmas:
            print(f"   Peak VMAs: {max(valid_vmas):,} ({max(self.vma_percent):.1f}%)")
            print(f"   Max limit: 65,530")
            if max(valid_vmas) >= 65530:
                print(f"   ⚠️  STATUS: CRASHED - Hit VMA limit!")
            elif max(self.vma_percent) > 90:
                print(f"   ⚠️  STATUS: DANGER - Approaching limit!")
            else:
                print(f"   ✓ STATUS: Safe")
        
        print(f"\n🌐 HTTP Requests:")
        if self.http_total:
            print(f"   Total requests: {self.http_total[-1]:,}")
            print(f"   Peak active: {max(self.http_active):,}")
            print(f"   Data received: {self.http_received_mb[-1]:,} MB")
            if self.progress_gb[-1] > 0:
                efficiency = (self.http_received_mb[-1] / 1024) / self.progress_gb[-1] * 100
                print(f"   HTTP efficiency: {efficiency:.1f}% (should be ~100%)")
        
        print(f"\n🔄 ArrayPool:")
        if self.arraypool_outstanding:
            max_out = max(self.arraypool_outstanding)
            print(f"   Peak outstanding: {max_out:,} buffers")
            print(f"   Estimated memory: {max_out * 64 / 1024:.0f} MB ({max_out * 64 / 1024 / 1024:.1f} GB)")
            print(f"   Total rent requests: {self.arraypool_rent[-1]:,}")
            print(f"   Pool reuse (no VMA): {self.arraypool_pooled[-1]:,}")
            print(f"   New allocations (VMA): {self.arraypool_allocate[-1]:,}")
            print(f"   Total allocated: {self.arraypool_allocated_mb[-1]:,.0f} MB")
            
            # Calculate and display pool efficiency
            if self.arraypool_rent[-1] > 0:
                pool_efficiency = (self.arraypool_pooled[-1] / self.arraypool_rent[-1]) * 100
                status = "✓ Excellent" if pool_efficiency > 80 else "⚠️ Poor" if pool_efficiency < 20 else "○ Moderate"
                print(f"   Pool efficiency: {pool_efficiency:.1f}% {status}")
        
        print(f"\n💡 Diagnosis:")
        if max(self.vma_percent) >= 100:
            print("   ❌ VMA EXHAUSTION CRASH OCCURRED")
            print("   Root cause: 64KB default chunk size creating millions of allocations")
            print("   Solution: Set ChunkBufferSize = 8 * 1024 * 1024 (8MB)")
        elif max(self.vma_percent) > 80:
            print("   ⚠️  High risk of VMA exhaustion")
            print("   Recommendation: Reduce chunk size or increase vm.max_map_count")
        else:
            print("   ✓ VMA usage is acceptable")
        
        print("\n" + "="*70 + "\n")


def main():
    parser = argparse.ArgumentParser(description='Analyze S3 download metrics from log file')
    parser.add_argument('logfile', help='Path to log file')
    parser.add_argument('-o', '--output', default='download_metrics.png', 
                       help='Output file for plot (default: download_metrics.png)')
    parser.add_argument('--no-plot', action='store_true', help='Skip creating plot')
    
    args = parser.parse_args()
    
    metrics = DownloadMetrics()
    metrics.parse_log_file(args.logfile)
    metrics.print_summary()
    
    if not args.no_plot:
        metrics.plot_metrics(args.output)


if __name__ == '__main__':
    main()
