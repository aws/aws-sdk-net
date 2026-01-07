#!/usr/bin/env python3
"""
Analyze ArrayPool simulation results to derive VMA calculation formulas.
This script processes the simulation results and determines how to calculate
VMAs based on configuration parameters.
"""

import json
import numpy as np
import matplotlib.pyplot as plt
from pathlib import Path

def load_simulation_results(json_file):
    """Load simulation results from JSON file."""
    with open(json_file, 'r') as f:
        return json.load(f)

def calculate_chunks_per_part(part_size, chunk_size):
    """Calculate chunks per part."""
    return part_size / chunk_size

def analyze_non_saturated_scenarios(data):
    """
    Analyze scenarios where buffer was NOT saturated (peak buffered << MaxInMemoryParts).
    Derive the efficiency factor for VMA calculation.
    """
    print("\n" + "="*80)
    print("NON-SATURATED BUFFER ANALYSIS")
    print("="*80)
    
    non_saturated = []
    
    for scenario in data:
        part_size = scenario['PartSize']
        chunk_size = scenario['ChunkSize']
        max_in_memory = scenario['MaxInMemoryParts']
        peak_buffered = scenario['PeakBufferedParts']
        unique_arrays = scenario['UniqueArrays']
        chunks_per_part = calculate_chunks_per_part(part_size, chunk_size)
        
        # Consider non-saturated if peak buffered is significantly less than max
        saturation_ratio = peak_buffered / max_in_memory
        
        if saturation_ratio < 0.5:  # Less than 50% of buffer capacity used
            efficiency = unique_arrays / chunks_per_part
            non_saturated.append({
                'PartSize_MB': part_size / (1024**2),
                'ChunkSize_KB': chunk_size / 1024,
                'ChunksPerPart': chunks_per_part,
                'MaxInMemoryParts': max_in_memory,
                'PeakBufferedParts': peak_buffered,
                'SaturationRatio': saturation_ratio,
                'UniqueArrays': unique_arrays,
                'Efficiency': efficiency,
                'BufferFullEvents': scenario['BufferFullCount']
            })
    
    if not non_saturated:
        print("No non-saturated scenarios found!")
        return None
    
    print(f"\nFound {len(non_saturated)} non-saturated scenarios:")
    print(f"{'Part Size':<12} {'Chunks':<10} {'Peak Buf':<10} {'Sat %':<10} {'VMAs':<12} {'Efficiency':<12}")
    print("-" * 80)
    
    efficiencies = []
    for s in non_saturated:
        print(f"{s['PartSize_MB']:<12.0f} {s['ChunksPerPart']:<10.0f} {s['PeakBufferedParts']:<10.0f} "
              f"{s['SaturationRatio']*100:<10.1f} {s['UniqueArrays']:<12.0f} {s['Efficiency']:<12.4f}")
        efficiencies.append(s['Efficiency'])
    
    avg_efficiency = np.mean(efficiencies)
    std_efficiency = np.std(efficiencies)
    
    print(f"\n{'='*80}")
    print(f"NON-SATURATED FORMULA:")
    print(f"  VMAs = {avg_efficiency:.4f} × ChunksPerPart")
    print(f"  VMAs = {avg_efficiency:.4f} × (PartSize / ChunkSize)")
    print(f"\n  Average Efficiency Factor: {avg_efficiency:.4f} ± {std_efficiency:.4f}")
    print(f"  This represents {(1-avg_efficiency)*100:.2f}% buffer reuse rate")
    print(f"{'='*80}")
    
    return avg_efficiency, non_saturated

def analyze_saturated_scenarios(data):
    """
    Analyze scenarios where buffer WAS saturated (peak buffered ≈ MaxInMemoryParts).
    Derive the multiplier for VMA calculation under saturation.
    """
    print("\n" + "="*80)
    print("SATURATED BUFFER ANALYSIS")
    print("="*80)
    
    saturated = []
    
    for scenario in data:
        part_size = scenario['PartSize']
        chunk_size = scenario['ChunkSize']
        max_in_memory = scenario['MaxInMemoryParts']
        peak_buffered = scenario['PeakBufferedParts']
        unique_arrays = scenario['UniqueArrays']
        chunks_per_part = calculate_chunks_per_part(part_size, chunk_size)
        
        # Consider saturated if peak buffered is close to max
        saturation_ratio = peak_buffered / max_in_memory
        
        if saturation_ratio >= 0.8:  # 80% or more of buffer capacity used
            expected_vmas_saturated = max_in_memory * chunks_per_part
            multiplier = unique_arrays / expected_vmas_saturated
            
            saturated.append({
                'PartSize_MB': part_size / (1024**2),
                'ChunkSize_KB': chunk_size / 1024,
                'ChunksPerPart': chunks_per_part,
                'MaxInMemoryParts': max_in_memory,
                'PeakBufferedParts': peak_buffered,
                'SaturationRatio': saturation_ratio,
                'UniqueArrays': unique_arrays,
                'ExpectedVMAs': expected_vmas_saturated,
                'Multiplier': multiplier,
                'BufferFullEvents': scenario['BufferFullCount'],
                'PoolEfficiency': scenario.get('PoolEfficiency', 0.0)
            })
    
    if not saturated:
        print("No saturated scenarios found!")
        return None
    
    print(f"\nFound {len(saturated)} saturated scenarios:")
    print(f"{'Part Size':<12} {'MaxMem':<10} {'Peak Buf':<10} {'Sat %':<10} {'VMAs':<12} {'Expected':<12} {'Mult':<10}")
    print("-" * 100)
    
    multipliers = []
    for s in saturated:
        print(f"{s['PartSize_MB']:<12.0f} {s['MaxInMemoryParts']:<10.0f} {s['PeakBufferedParts']:<10.0f} "
              f"{s['SaturationRatio']*100:<10.1f} {s['UniqueArrays']:<12.0f} {s['ExpectedVMAs']:<12.0f} {s['Multiplier']:<10.4f}")
        multipliers.append(s['Multiplier'])
    
    avg_multiplier = np.mean(multipliers)
    std_multiplier = np.std(multipliers)
    
    print(f"\n{'='*80}")
    print(f"SATURATED FORMULA:")
    print(f"  VMAs = {avg_multiplier:.4f} × MaxInMemoryParts × ChunksPerPart")
    print(f"  VMAs = {avg_multiplier:.4f} × MaxInMemoryParts × (PartSize / ChunkSize)")
    print(f"\n  Average Multiplier: {avg_multiplier:.4f} ± {std_multiplier:.4f}")
    if saturated[0]['PoolEfficiency'] > 0:
        print(f"  Pool Efficiency drops to ~{saturated[0]['PoolEfficiency']:.1f}% when saturated")
    print(f"  Buffer full events: {saturated[0]['BufferFullEvents']}")
    print(f"{'='*80}")
    
    return avg_multiplier, saturated

def identify_saturation_threshold(data):
    """Identify the threshold where buffer saturation occurs."""
    print("\n" + "="*80)
    print("SATURATION THRESHOLD ANALYSIS")
    print("="*80)
    
    scenarios = []
    for scenario in data:
        part_size = scenario['PartSize']
        chunk_size = scenario['ChunkSize']
        max_in_memory = scenario['MaxInMemoryParts']
        peak_buffered = scenario['PeakBufferedParts']
        saturation_ratio = peak_buffered / max_in_memory
        chunks_per_part = calculate_chunks_per_part(part_size, chunk_size)
        
        scenarios.append({
            'PartSize_MB': part_size / (1024**2),
            'MaxInMemoryParts': max_in_memory,
            'PeakBufferedParts': peak_buffered,
            'SaturationRatio': saturation_ratio,
            'BufferFullEvents': scenario['BufferFullCount'],
            'ChunksPerPart': chunks_per_part,
            'UniqueArrays': scenario['UniqueArrays']
        })
    
    # Sort by saturation ratio
    scenarios.sort(key=lambda x: x['SaturationRatio'])
    
    print(f"\nSaturation progression by scenario:")
    print(f"{'Part Size':<12} {'MaxMem':<10} {'Peak Buf':<10} {'Sat %':<10} {'Buffer Full':<15} {'Status':<15}")
    print("-" * 80)
    
    for s in scenarios:
        status = "NON-SATURATED" if s['SaturationRatio'] < 0.5 else "SATURATED"
        print(f"{s['PartSize_MB']:<12.0f} {s['MaxInMemoryParts']:<10.0f} {s['PeakBufferedParts']:<10.0f} "
              f"{s['SaturationRatio']*100:<10.1f} {s['BufferFullEvents']:<15} {status:<15}")
    
    # Find threshold
    threshold = None
    for s in scenarios:
        if s['SaturationRatio'] >= 0.8:
            threshold = s
            break
    
    if threshold:
        print(f"\n{'='*80}")
        print(f"SATURATION THRESHOLD:")
        print(f"  Occurs at: {threshold['PartSize_MB']:.0f}MB parts with MaxInMemoryParts={threshold['MaxInMemoryParts']}")
        print(f"  Peak buffered: {threshold['PeakBufferedParts']} ({threshold['SaturationRatio']*100:.1f}% of capacity)")
        print(f"  Buffer full events: {threshold['BufferFullEvents']}")
        print(f"  This causes VMA explosion: {threshold['UniqueArrays']:,} unique arrays")
        print(f"{'='*80}")

def calculate_safe_configurations(non_saturated_efficiency):
    """Calculate safe configurations to stay under VMA limit."""
    print("\n" + "="*80)
    print("SAFE CONFIGURATION CALCULATOR")
    print("="*80)
    
    VMA_LIMIT = 65536
    CHUNK_SIZE = 64 * 1024  # 64KB
    
    print(f"\nVMA Limit: {VMA_LIMIT:,}")
    print(f"Chunk Size: {CHUNK_SIZE/1024:.0f}KB")
    print(f"Efficiency Factor: {non_saturated_efficiency:.4f}")
    
    print(f"\n{'Part Size':<15} {'Max Chunks':<15} {'Safe MaxMem':<15} {'Notes':<30}")
    print("-" * 80)
    
    part_sizes = [32, 64, 128, 256, 512, 1024, 2048, 5120]  # MB
    
    for part_size_mb in part_sizes:
        part_size = part_size_mb * 1024 * 1024
        chunks_per_part = part_size / CHUNK_SIZE
        
        # For non-saturated: VMAs = efficiency × chunks
        max_chunks = VMA_LIMIT / non_saturated_efficiency
        
        # For saturated: VMAs = MaxInMemoryParts × chunks
        # So: MaxInMemoryParts = VMA_LIMIT / chunks_per_part
        safe_max_in_memory = int(VMA_LIMIT / chunks_per_part)
        
        if chunks_per_part < max_chunks:
            status = "✓ SAFE"
        elif safe_max_in_memory >= 10:
            status = f"OK with MaxMem≤{safe_max_in_memory}"
        else:
            status = "⚠ HIGH RISK"
        
        print(f"{part_size_mb:<15} {chunks_per_part:<15.0f} {safe_max_in_memory:<15} {status:<30}")
    
    print(f"\n{'='*80}")
    print(f"RECOMMENDATIONS:")
    print(f"  1. Keep PartSize × MaxInMemoryParts / ChunkSize < {VMA_LIMIT:,}")
    print(f"  2. Monitor buffer saturation (peak buffered vs MaxInMemoryParts)")
    print(f"  3. If saturation occurs, reduce MaxInMemoryParts or PartSize")
    print(f"  4. Non-saturated buffer: VMAs ≈ {non_saturated_efficiency:.4f} × (PartSize/ChunkSize)")
    print(f"  5. Saturated buffer: VMAs ≈ MaxInMemoryParts × (PartSize/ChunkSize)")
    print(f"{'='*80}")

def create_visualization(data, non_saturated_data, saturated_data):
    """Create visualizations of VMA formulas."""
    print("\n" + "="*80)
    print("CREATING VISUALIZATIONS")
    print("="*80)
    
    fig, axes = plt.subplots(2, 2, figsize=(16, 12))
    
    # Plot 1: VMAs vs ChunksPerPart (colored by saturation)
    ax1 = axes[0, 0]
    
    for scenario in data:
        part_size = scenario['PartSize'] / (1024**2)
        chunk_size = scenario['ChunkSize']
        chunks_per_part = scenario['PartSize'] / chunk_size
        unique_arrays = scenario['UniqueArrays']
        peak_buffered = scenario['PeakBufferedParts']
        max_in_memory = scenario['MaxInMemoryParts']
        saturation = peak_buffered / max_in_memory
        
        color = 'green' if saturation < 0.5 else 'red'
        marker = 'o' if saturation < 0.5 else '^'
        
        ax1.scatter(chunks_per_part, unique_arrays, c=color, marker=marker, s=100, alpha=0.7,
                   label=f"{part_size:.0f}MB ({saturation*100:.0f}% sat)" if scenario == data[0] or scenario == data[-1] else "")
    
    ax1.set_xlabel('Chunks Per Part', fontsize=12, fontweight='bold')
    ax1.set_ylabel('Unique Arrays (VMAs)', fontsize=12, fontweight='bold')
    ax1.set_title('VMA Relationship: Non-Saturated vs Saturated', fontsize=14, fontweight='bold')
    ax1.axhline(y=65536, color='black', linestyle='--', linewidth=2, label='VMA Limit (65,536)')
    ax1.grid(True, alpha=0.3)
    ax1.legend()
    
    # Plot 2: Efficiency Factor Analysis
    ax2 = axes[0, 1]
    
    if non_saturated_data:
        chunks = [s['ChunksPerPart'] for s in non_saturated_data]
        efficiencies = [s['Efficiency'] for s in non_saturated_data]
        ax2.scatter(chunks, efficiencies, c='green', marker='o', s=100, alpha=0.7)
        avg_eff = np.mean(efficiencies)
        ax2.axhline(y=avg_eff, color='blue', linestyle='--', linewidth=2, 
                   label=f'Average: {avg_eff:.4f}')
    
    ax2.set_xlabel('Chunks Per Part', fontsize=12, fontweight='bold')
    ax2.set_ylabel('Efficiency Factor', fontsize=12, fontweight='bold')
    ax2.set_title('Non-Saturated Efficiency Factor', fontsize=14, fontweight='bold')
    ax2.grid(True, alpha=0.3)
    ax2.legend()
    
    # Plot 3: Saturation Impact
    ax3 = axes[1, 0]
    
    part_sizes = []
    saturation_ratios = []
    vma_counts = []
    
    for scenario in data:
        part_sizes.append(scenario['PartSize'] / (1024**2))
        saturation_ratios.append(scenario['PeakBufferedParts'] / scenario['MaxInMemoryParts'])
        vma_counts.append(scenario['UniqueArrays'])
    
    scatter = ax3.scatter(part_sizes, saturation_ratios, c=vma_counts, cmap='RdYlGn_r', 
                         s=200, alpha=0.8, edgecolors='black', linewidth=1)
    
    ax3.axhline(y=0.5, color='orange', linestyle='--', linewidth=2, label='Saturation Threshold')
    ax3.set_xlabel('Part Size (MB)', fontsize=12, fontweight='bold')
    ax3.set_ylabel('Buffer Saturation Ratio', fontsize=12, fontweight='bold')
    ax3.set_title('Saturation vs Part Size (colored by VMAs)', fontsize=14, fontweight='bold')
    ax3.grid(True, alpha=0.3)
    ax3.legend()
    
    cbar = plt.colorbar(scatter, ax=ax3)
    cbar.set_label('Unique Arrays (VMAs)', fontsize=10, fontweight='bold')
    
    # Plot 4: Formula Comparison
    ax4 = axes[1, 1]
    
    part_sizes_range = np.linspace(32, 256, 100)
    chunk_size = 64 * 1024
    max_in_memory = 50
    
    if non_saturated_data and saturated_data:
        non_sat_eff = np.mean([s['Efficiency'] for s in non_saturated_data])
        sat_mult = np.mean([s['Multiplier'] for s in saturated_data])
        
        vmas_non_saturated = [(ps * 1024 * 1024 / chunk_size) * non_sat_eff for ps in part_sizes_range]
        vmas_saturated = [(ps * 1024 * 1024 / chunk_size) * max_in_memory * sat_mult for ps in part_sizes_range]
        
        ax4.plot(part_sizes_range, vmas_non_saturated, 'g-', linewidth=3, 
                label=f'Non-Saturated: {non_sat_eff:.4f} × Chunks')
        ax4.plot(part_sizes_range, vmas_saturated, 'r-', linewidth=3,
                label=f'Saturated: {sat_mult:.4f} × MaxMem × Chunks')
        ax4.axhline(y=65536, color='black', linestyle='--', linewidth=2, label='VMA Limit')
        
        ax4.set_xlabel('Part Size (MB)', fontsize=12, fontweight='bold')
        ax4.set_ylabel('Predicted VMAs', fontsize=12, fontweight='bold')
        ax4.set_title(f'Formula Comparison (MaxInMemoryParts={max_in_memory})', fontsize=14, fontweight='bold')
        ax4.grid(True, alpha=0.3)
        ax4.legend()
        ax4.set_yscale('log')
    
    plt.tight_layout()
    plt.savefig('ArrayPoolSimulator/vma_formula_analysis.png', dpi=300, bbox_inches='tight')
    print("✓ Saved: ArrayPoolSimulator/vma_formula_analysis.png")
    
    plt.close()

def main():
    """Main analysis function."""
    print("="*80)
    print("VMA FORMULA DERIVATION FROM ARRAYPOOL SIMULATION")
    print("="*80)
    
    # Load simulation results
    json_file = Path("ArrayPoolSimulator/arraypool_simulation_results.json")
    
    if not json_file.exists():
        print(f"\nERROR: {json_file} not found!")
        print("Please ensure the simulation has been run and results file exists.")
        return
    
    print(f"\nLoading results from: {json_file}")
    data = load_simulation_results(json_file)
    print(f"✓ Loaded {len(data)} scenarios")
    
    # Analyze non-saturated scenarios
    result = analyze_non_saturated_scenarios(data)
    if result:
        non_saturated_efficiency, non_saturated_data = result
    else:
        non_saturated_efficiency, non_saturated_data = None, None
    
    # Analyze saturated scenarios
    result = analyze_saturated_scenarios(data)
    if result:
        saturated_multiplier, saturated_data = result
    else:
        saturated_multiplier, saturated_data = None, None
    
    # Identify saturation threshold
    identify_saturation_threshold(data)
    
    # Calculate safe configurations
    if non_saturated_efficiency:
        calculate_safe_configurations(non_saturated_efficiency)
    
    # Create visualizations
    create_visualization(data, non_saturated_data, saturated_data)
    
    print("\n" + "="*80)
    print("ANALYSIS COMPLETE")
    print("="*80)
    print("\nSUMMARY:")
    print(f"  • Non-saturated efficiency factor: {non_saturated_efficiency:.4f}" if non_saturated_efficiency else "  • No non-saturated data")
    print(f"  • Saturated multiplier: {saturated_multiplier:.4f}" if saturated_multiplier else "  • No saturated data")
    print(f"  • Visualization saved to: ArrayPoolSimulator/vma_formula_analysis.png")
    print("\nFORMULAS DERIVED:")
    if non_saturated_efficiency:
        print(f"  VMAs (non-saturated) = {non_saturated_efficiency:.4f} × (PartSize / ChunkSize)")
    if saturated_multiplier:
        print(f"  VMAs (saturated) = {saturated_multiplier:.4f} × MaxInMemoryParts × (PartSize / ChunkSize)")
    print("="*80)

if __name__ == "__main__":
    main()
