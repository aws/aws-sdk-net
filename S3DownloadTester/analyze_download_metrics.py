#!/usr/bin/env python3
"""
Enhanced VMA Exhaustion Analyzer
Creates critical visualizations from log file data
"""

import matplotlib.pyplot as plt
import numpy as np
import re
import sys
import argparse

def parse_vma_data_from_log(filename):
    """Parse VMA and ArrayPool data from log file"""
    
    with open(filename, 'r') as f:
        content = f.read()
    
    # Find the most recent data points
    vma_data = {
        'total_vmas': 0,
        'vma_limit': 65530,
        'percent_used': 0,
        'categories': {},
        'size_breakdown': {},
        'memory': {},
        'arraypool': {}
    }
    
    # Extract VMA current count and percentage
    vma_matches = re.findall(r'VMAs: Current=(\d+) \(([\d.]+)%\)', content)
    if vma_matches:
        latest_vma = vma_matches[-1]
        vma_data['total_vmas'] = int(latest_vma[0])
        vma_data['percent_used'] = float(latest_vma[1])
    
    # Extract VMA categories from enhanced analysis
    category_patterns = {
        'rw-p anon': r'rw-p anon: ([\d,]+) VMAs',
        '---p anon': r'---p anon: ([\d,]+) VMAs',
        'Files': r'r--p file: (\d+) VMAs',
        'Libraries': r'r--p lib: (\d+) VMAs'
    }
    
    for category, pattern in category_patterns.items():
        matches = re.findall(pattern, content)
        if matches:
            vma_data['categories'][category] = int(matches[-1].replace(',', ''))
    
    # Extract VMA size breakdown
    size_patterns = {
        '64KB VMAs': r'64KB VMAs: (\d+)',
        '<1MB VMAs': r'<1MB VMAs: (\d+)',
        '1-10MB VMAs': r'1-10MB VMAs: ([\d,]+)',
        '10-100MB VMAs': r'10-100MB VMAs: ([\d,]+)',
        '>100MB VMAs': r'>100MB VMAs: (\d+)'
    }
    
    for size_cat, pattern in size_patterns.items():
        matches = re.findall(pattern, content)
        if matches:
            vma_data['size_breakdown'][size_cat] = int(matches[-1].replace(',', ''))
    
    # Extract memory data
    gc_matches = re.findall(r'GC Committed:\s+([\d.]+)GB', content)
    if gc_matches:
        vma_data['memory']['gc_committed_gb'] = float(gc_matches[-1])
    
    rw_anon_matches = re.findall(r'rw-p anon \(committed\): ([\d.]+)GB', content)
    if rw_anon_matches:
        vma_data['memory']['rw_anon_gb'] = float(rw_anon_matches[-1])
    
    reserved_matches = re.findall(r'---p anon \(reserved\):\s+([\d.]+)GB', content)
    if reserved_matches:
        vma_data['memory']['reserved_gb'] = float(reserved_matches[-1])
    
    # Extract ArrayPool data
    arraypool_matches = re.findall(r'ArrayPool: Rent=([\d,]+) \(Pooled=([\d,]+), New=([\d,]+)\), Return=([\d,]+), Outstanding=([\d,]+), AllocatedMB=([\d,]+\.?\d*)', content)
    if arraypool_matches:
        latest_pool = arraypool_matches[-1]
        vma_data['arraypool'] = {
            'rent': int(latest_pool[0].replace(',', '')),
            'pooled': int(latest_pool[1].replace(',', '')),
            'new': int(latest_pool[2].replace(',', '')),
            'return': int(latest_pool[3].replace(',', '')),
            'outstanding': int(latest_pool[4].replace(',', '')),
            'allocated_mb': float(latest_pool[5].replace(',', ''))
        }
        vma_data['memory']['arraypool_virtual_tb'] = vma_data['arraypool']['allocated_mb'] / 1024 / 1024
    
    return vma_data

def create_vma_crisis_visualization(vma_data):
    """Create visualization based on parsed VMA data"""
    
    fig, axes = plt.subplots(2, 3, figsize=(20, 12))
    fig.suptitle('🚨 CRITICAL VMA EXHAUSTION ANALYSIS 🚨\nS3 Download Creating Massive Memory Pressure', 
                 fontsize=16, fontweight='bold', color='red')
    
    # 1. VMA Usage Gauge
    ax1 = axes[0, 0]
    current = vma_data['total_vmas']
    limit = vma_data['vma_limit']
    percent = vma_data['percent_used']
    
    # Create gauge chart
    theta = np.linspace(0, np.pi, 100)
    
    # Color zones
    green_zone = theta[theta <= np.pi * 0.6]
    yellow_zone = theta[(theta > np.pi * 0.6) & (theta <= np.pi * 0.8)]
    red_zone = theta[theta > np.pi * 0.8]
    
    ax1.fill_between(green_zone, 0, 1, color='green', alpha=0.3, label='Safe')
    ax1.fill_between(yellow_zone, 0, 1, color='yellow', alpha=0.3, label='Warning')
    ax1.fill_between(red_zone, 0, 1, color='red', alpha=0.3, label='DANGER')
    
    # Current position
    current_angle = np.pi * (percent / 100)
    ax1.plot([current_angle, current_angle], [0, 1], 'black', linewidth=5)
    ax1.plot(current_angle, 1, 'ro', markersize=15)
    
    ax1.set_xlim(0, np.pi)
    ax1.set_ylim(0, 1.2)
    ax1.set_title(f'VMA Usage: {current:,} / {limit:,}\n{percent:.1f}% - CRITICAL!', 
                  fontweight='bold', color='red')
    ax1.text(np.pi/2, 0.5, f'{percent:.1f}%', ha='center', va='center', 
             fontsize=20, fontweight='bold', color='red')
    ax1.set_xticks([])
    ax1.set_yticks([])
    
    # 2. VMA Categories Pie Chart
    ax2 = axes[0, 1]
    if vma_data['categories']:
        categories = list(vma_data['categories'].keys())
        sizes = list(vma_data['categories'].values())
        colors = ['red', 'orange', 'lightblue', 'gray']
        
        wedges, texts, autotexts = ax2.pie(sizes, labels=categories, colors=colors[:len(sizes)], 
                                           autopct='%1.1f%%', startangle=90)
        ax2.set_title('VMA Categories\n(GC Heap Dominates)', fontweight='bold')
    
    # 3. VMA Size Distribution
    ax3 = axes[0, 2]
    if vma_data['size_breakdown']:
        size_categories = list(vma_data['size_breakdown'].keys())
        size_counts = list(vma_data['size_breakdown'].values())
        
        bars = ax3.bar(range(len(size_categories)), size_counts, 
                       color=['lightblue', 'blue', 'orange', 'red', 'darkred'])
        ax3.set_xticks(range(len(size_categories)))
        ax3.set_xticklabels(size_categories, rotation=45, ha='right')
        ax3.set_ylabel('VMA Count')
        ax3.set_title('VMA Size Distribution\n(1-10MB segments dominate)', fontweight='bold')
        
        # Add value labels
        for bar, count in zip(bars, size_counts):
            if count > 0:
                ax3.text(bar.get_x() + bar.get_width()/2, bar.get_height() + max(size_counts)*0.01,
                        f'{count:,}', ha='center', fontweight='bold')
    
    # 4. Memory Explosion
    ax4 = axes[1, 0]
    if vma_data['memory']:
        memory_types = ['GC Heap\n(Physical)', 'ArrayPool\n(Virtual)', 'Reserved\n(Virtual)']
        memory_sizes = [
            vma_data['memory'].get('gc_committed_gb', 0), 
            vma_data['memory'].get('arraypool_virtual_tb', 0) * 1024,  # Convert TB to GB
            vma_data['memory'].get('reserved_gb', 0)
        ]
        colors = ['blue', 'red', 'orange']
        
        bars = ax4.bar(memory_types, memory_sizes, color=colors)
        ax4.set_ylabel('Memory (GB)')
        ax4.set_title('Memory Allocation (Virtual vs Physical)\nArrayPool = VIRTUAL!', fontweight='bold', color='red')
        ax4.set_yscale('log')  # Log scale due to huge differences
        
        # Add value labels
        for bar, size in zip(bars, memory_sizes):
            if size > 0:
                if size < 1000:
                    label = f'{size:.0f}GB'
                else:
                    label = f'{size/1024:.0f}TB\n(VIRTUAL)'
                ax4.text(bar.get_x() + bar.get_width()/2, bar.get_height() * 1.1,
                        label, ha='center', fontweight='bold')
    
    # 5. ArrayPool Efficiency Crisis
    ax5 = axes[1, 1]
    if vma_data['arraypool']:
        pool_data = vma_data['arraypool']
        
        # Stacked bar showing pooled vs new allocations
        pooled_pct = (pool_data['pooled'] / pool_data['rent']) * 100 if pool_data['rent'] > 0 else 0
        new_pct = (pool_data['new'] / pool_data['rent']) * 100 if pool_data['rent'] > 0 else 0
        
        ax5.bar(['ArrayPool Requests'], [pooled_pct], color='green', alpha=0.7, label='Pooled (Good)')
        ax5.bar(['ArrayPool Requests'], [new_pct], bottom=[pooled_pct], color='red', alpha=0.7, label='NEW (Creates VMAs)')
        
        ax5.set_ylabel('Percentage of Requests')
        ax5.set_title(f'ArrayPool Efficiency Crisis\n{new_pct:.1f}% are NEW allocations!', 
                      fontweight='bold', color='red')
        ax5.legend()
        
        # Add text annotations
        if pooled_pct > 5:
            ax5.text(0, pooled_pct/2, f'{pooled_pct:.1f}%\nPooled', ha='center', va='center', 
                     fontweight='bold', color='white')
        if new_pct > 5:
            ax5.text(0, pooled_pct + new_pct/2, f'{new_pct:.1f}%\nNEW\n(VMA creators!)', 
                     ha='center', va='center', fontweight='bold', color='white')
    
    # 6. Crisis Summary
    ax6 = axes[1, 2]
    ax6.axis('off')
    
    # Calculate time to crash (rough estimate)
    growth_rate = vma_data['total_vmas'] / (7 * 60) if vma_data['total_vmas'] > 0 else 0  # VMAs per minute
    remaining_vmas = vma_data['vma_limit'] - vma_data['total_vmas']
    minutes_to_crash = remaining_vmas / growth_rate if growth_rate > 0 else float('inf')
    
    outstanding = vma_data['arraypool'].get('outstanding', 0)
    new_allocs = vma_data['arraypool'].get('new', 0)
    virtual_tb = vma_data['memory'].get('arraypool_virtual_tb', 0)
    
    crisis_text = f"""
🚨 CRISIS SUMMARY 🚨

Current VMAs: {vma_data['total_vmas']:,}
Limit: {vma_data['vma_limit']:,}
Usage: {vma_data['percent_used']:.1f}%

⏰ Est. Time to Crash:
{minutes_to_crash:.0f} minutes

🔥 Root Causes:
• {new_allocs:,} NEW ArrayPool buffers
• {outstanding:,} outstanding buffers
• Each creates a VMA
• {virtual_tb:.0f}TB VIRTUAL memory allocated
• Only ~{vma_data['memory'].get('gc_committed_gb', 0):.0f}GB actually committed

💡 The {virtual_tb:.0f}TB is VIRTUAL:
• ArrayPool reserves address space
• Only small portion is physical RAM
• But each buffer = 1 VMA
• {outstanding:,} outstanding buffers
• = {outstanding:,} VMAs approaching limit!

💡 IMMEDIATE FIXES:
• Reduce ConcurrentServiceRequests
• Reduce MaxInMemoryParts  
• Increase buffer sizes
• Force GC more frequently

⚠️ STATUS: CRITICAL
System will crash soon!
    """
    
    ax6.text(0.05, 0.95, crisis_text, transform=ax6.transAxes, fontsize=10,
             verticalalignment='top', fontfamily='monospace',
             bbox=dict(boxstyle='round', facecolor='red', alpha=0.2))
    
    plt.tight_layout()
    plt.savefig('vma_crisis_analysis.png', dpi=300, bbox_inches='tight')
    print("\n🚨 CRITICAL VMA CRISIS ANALYSIS saved to: vma_crisis_analysis.png")
    plt.show()

def main():
    parser = argparse.ArgumentParser(description='Analyze VMA exhaustion from log file')
    parser.add_argument('logfile', help='Path to log file')
    
    args = parser.parse_args()
    
    print(f"Parsing VMA data from: {args.logfile}")
    vma_data = parse_vma_data_from_log(args.logfile)
    
    print(f"Found {vma_data['total_vmas']:,} VMAs ({vma_data['percent_used']:.1f}% of limit)")
    print(f"Outstanding ArrayPool buffers: {vma_data['arraypool'].get('outstanding', 0):,}")
    
    create_vma_crisis_visualization(vma_data)

if __name__ == '__main__':
    main()
