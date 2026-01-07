#!/usr/bin/env python3
"""
Analyze ArrayPool simulation results to derive a formula for Real OS VMAs Created
"""

import json
import numpy as np
from scipy.optimize import curve_fit
import matplotlib.pyplot as plt

# Load the simulation results
with open('arraypool_simulation_results.json', 'r') as f:
    results = json.load(f)

# Extract data
data = []
for r in results:
    data.append({
        'part_size_mb': r['PartSize'] / (1024 * 1024),
        'chunk_size_kb': r['ChunkSize'] / 1024,
        'c': r['ConcurrentRequests'],
        'm': r['MaxInMemoryParts'],
        'chunks_per_part': r['ChunksPerPart'],
        'peak_buffered': r['PeakBufferedParts'],
        'unique_arrays': r['UniqueArrays'],
        'pool_miss_rate': r['PoolMissRate'],
        'real_vmas': r['RealOSVMAsCreated'],
        'scenario': r['ScenarioName']
    })

print("="*80)
print("VMA Formula Analysis")
print("="*80)
print()

# Test different formula hypotheses
print("Testing Formula Hypotheses:")
print("-" * 80)

# Extract variables
chunks_per_part = np.array([d['chunks_per_part'] for d in data])
peak_buffered = np.array([d['peak_buffered'] for d in data])
pool_miss_rate = np.array([d['pool_miss_rate'] for d in data])
unique_arrays = np.array([d['unique_arrays'] for d in data])
real_vmas = np.array([d['real_vmas'] for d in data])
m_values = np.array([d['m'] for d in data])

# Hypothesis 1: Real VMAs ≈ Peak * sqrt(Chunks/Part) * k
print("\n1. Formula: Real_VMAs = k * Peak * sqrt(Chunks/Part)")
sqrt_chunks = np.sqrt(chunks_per_part)
X1 = peak_buffered * sqrt_chunks
k1, _ = np.polyfit(X1, real_vmas, 1)
predicted1 = k1 * X1
r2_1 = 1 - (np.sum((real_vmas - predicted1)**2) / np.sum((real_vmas - np.mean(real_vmas))**2))
print(f"   k = {k1:.4f}")
print(f"   R² = {r2_1:.4f}")
print(f"   RMSE = {np.sqrt(np.mean((real_vmas - predicted1)**2)):.2f}")

# Hypothesis 2: Real VMAs ≈ Peak * Chunks/Part * k
print("\n2. Formula: Real_VMAs = k * Peak * Chunks/Part")
X2 = peak_buffered * chunks_per_part
k2, _ = np.polyfit(X2, real_vmas, 1)
predicted2 = k2 * X2
r2_2 = 1 - (np.sum((real_vmas - predicted2)**2) / np.sum((real_vmas - np.mean(real_vmas))**2))
print(f"   k = {k2:.6f}")
print(f"   R² = {r2_2:.4f}")
print(f"   RMSE = {np.sqrt(np.mean((real_vmas - predicted2)**2)):.2f}")

# Hypothesis 3: Real VMAs ≈ Unique_Arrays * k
print("\n3. Formula: Real_VMAs = k * Unique_Arrays")
k3, _ = np.polyfit(unique_arrays, real_vmas, 1)
predicted3 = k3 * unique_arrays
r2_3 = 1 - (np.sum((real_vmas - predicted3)**2) / np.sum((real_vmas - np.mean(real_vmas))**2))
print(f"   k = {k3:.6f}")
print(f"   R² = {r2_3:.4f}")
print(f"   RMSE = {np.sqrt(np.mean((real_vmas - predicted3)**2)):.2f}")

# Hypothesis 4: Real VMAs ≈ Peak * Chunks/Part^a * k (power law)
print("\n4. Formula: Real_VMAs = k * Peak * Chunks/Part^a")
def power_law(X, k, a):
    peak, chunks = X
    return k * peak * (chunks ** a)

try:
    popt, _ = curve_fit(power_law, (peak_buffered, chunks_per_part), real_vmas, p0=[1, 0.5])
    k4, a4 = popt
    predicted4 = power_law((peak_buffered, chunks_per_part), k4, a4)
    r2_4 = 1 - (np.sum((real_vmas - predicted4)**2) / np.sum((real_vmas - np.mean(real_vmas))**2))
    print(f"   k = {k4:.4f}, a = {a4:.4f}")
    print(f"   R² = {r2_4:.4f}")
    print(f"   RMSE = {np.sqrt(np.mean((real_vmas - predicted4)**2)):.2f}")
except:
    print("   Could not fit power law")
    r2_4 = -1

# Hypothesis 5: Real VMAs ≈ M * Chunks/Part * k
print("\n5. Formula: Real_VMAs = k * M * Chunks/Part")
X5 = m_values * chunks_per_part
k5, _ = np.polyfit(X5, real_vmas, 1)
predicted5 = k5 * X5
r2_5 = 1 - (np.sum((real_vmas - predicted5)**2) / np.sum((real_vmas - np.mean(real_vmas))**2))
print(f"   k = {k5:.6f}")
print(f"   R² = {r2_5:.4f}")
print(f"   RMSE = {np.sqrt(np.mean((real_vmas - predicted5)**2)):.2f}")

# Find best formula
best_r2 = max(r2_1, r2_2, r2_3, r2_4, r2_5)
print("\n" + "="*80)
print("BEST FORMULA:")
print("="*80)

if best_r2 == r2_1:
    print(f"\n✓ Real_VMAs = {k1:.4f} × Peak × sqrt(Chunks/Part)")
    print(f"  R² = {r2_1:.4f}")
    best_predicted = predicted1
    best_name = "Peak × sqrt(Chunks/Part)"
elif best_r2 == r2_2:
    print(f"\n✓ Real_VMAs = {k2:.6f} × Peak × Chunks/Part")
    print(f"  R² = {r2_2:.4f}")
    best_predicted = predicted2
    best_name = "Peak × Chunks/Part"
elif best_r2 == r2_3:
    print(f"\n✓ Real_VMAs = {k3:.6f} × Unique_Arrays")
    print(f"  R² = {r2_3:.4f}")
    best_predicted = predicted3
    best_name = "Unique_Arrays"
elif best_r2 == r2_4:
    print(f"\n✓ Real_VMAs = {k4:.4f} × Peak × Chunks/Part^{a4:.4f}")
    print(f"  R² = {r2_4:.4f}")
    best_predicted = predicted4
    best_name = f"Peak × Chunks/Part^{a4:.2f}"
else:
    print(f"\n✓ Real_VMAs = {k5:.6f} × M × Chunks/Part")
    print(f"  R² = {r2_5:.4f}")
    best_predicted = predicted5
    best_name = "M × Chunks/Part"

# Print practical formula
print("\n" + "="*80)
print("PRACTICAL FORMULA:")
print("="*80)
print("\nGiven:")
print("  - PartSize (bytes)")
print("  - ChunkSize (bytes)")
print("  - MaxInMemoryParts (M)")
print("  - ConcurrentRequests (C)")
print("\nCalculate:")
print("  1. Chunks/Part = ceil(PartSize / ChunkSize)")
print("  2. Peak ≈ min(M-1, M)  // Usually M-1 due to streaming")

if best_r2 == r2_1:
    print(f"  3. Real_VMAs ≈ {k1:.2f} × Peak × sqrt(Chunks/Part)")
elif best_r2 == r2_2:
    print(f"  3. Real_VMAs ≈ {k2:.4f} × Peak × Chunks/Part")
elif best_r2 == r2_3:
    print(f"  3. Unique_Arrays = Peak × Chunks/Part × (0.16 for M=16, 0.32 for M=32, etc.)")
    print(f"     Real_VMAs ≈ {k3:.4f} × Unique_Arrays")
elif best_r2 == r2_4:
    print(f"  3. Real_VMAs ≈ {k4:.2f} × Peak × (Chunks/Part)^{a4:.2f}")
else:
    print(f"  3. Real_VMAs ≈ {k5:.4f} × M × Chunks/Part")

# Show examples
print("\n" + "="*80)
print("FORMULA VALIDATION - Sample Cases:")
print("="*80)
print(f"\n{'Scenario':<50} {'Actual':<10} {'Predicted':<10} {'Error':<10}")
print("-" * 80)

for i, d in enumerate(data[:15]):  # Show first 15 cases
    actual = real_vmas[i]
    predicted = best_predicted[i]
    error = abs(actual - predicted) / actual * 100
    print(f"{d['scenario']:<50} {actual:<10.0f} {predicted:<10.0f} {error:<9.1f}%")

# Create visualization
fig, (ax1, ax2) = plt.subplots(1, 2, figsize=(15, 6))

# Plot 1: Predicted vs Actual
ax1.scatter(real_vmas, best_predicted, alpha=0.6)
ax1.plot([real_vmas.min(), real_vmas.max()], [real_vmas.min(), real_vmas.max()], 'r--', lw=2)
ax1.set_xlabel('Actual Real OS VMAs', fontsize=12)
ax1.set_ylabel('Predicted Real OS VMAs', fontsize=12)
ax1.set_title(f'Predicted vs Actual (R² = {best_r2:.4f})\nFormula: {best_name}', fontsize=14)
ax1.grid(True, alpha=0.3)

# Plot 2: Residuals
residuals = real_vmas - best_predicted
ax2.scatter(best_predicted, residuals, alpha=0.6)
ax2.axhline(y=0, color='r', linestyle='--', lw=2)
ax2.set_xlabel('Predicted Real OS VMAs', fontsize=12)
ax2.set_ylabel('Residuals (Actual - Predicted)', fontsize=12)
ax2.set_title('Residual Plot', fontsize=14)
ax2.grid(True, alpha=0.3)

plt.tight_layout()
plt.savefig('vma_formula_analysis.png', dpi=150, bbox_inches='tight')
print(f"\n✓ Visualization saved to: vma_formula_analysis.png")

# Summary statistics by M value
print("\n" + "="*80)
print("PATTERN BY MaxInMemoryParts (M):")
print("="*80)

for m_val in sorted(set(m_values)):
    mask = m_values == m_val
    avg_ratio = np.mean(real_vmas[mask] / unique_arrays[mask])
    print(f"\nM = {m_val}:")
    print(f"  Average Real_VMAs / Unique_Arrays = {avg_ratio:.4f}")
    print(f"  Suggests: Real_VMAs ≈ Unique_Arrays × {avg_ratio:.4f}")

# Chunk size analysis
print("\n" + "="*80)
print("CHUNK SIZE IMPACT ANALYSIS:")
print("="*80)

chunk_sizes_kb = np.array([d['chunk_size_kb'] for d in data])
part_sizes_mb = np.array([d['part_size_mb'] for d in data])

unique_chunk_sizes = sorted(set(chunk_sizes_kb))
unique_part_sizes = sorted(set(part_sizes_mb))

if len(unique_chunk_sizes) > 1 and len(unique_part_sizes) > 1:
    print(f"\nPart sizes tested: {unique_part_sizes}")
    print(f"Chunk sizes tested: {unique_chunk_sizes}")
    
    # Create chunk size visualization
    fig, axes = plt.subplots(2, 2, figsize=(16, 12))
    
    # Plot 1: Heatmap of VMAs by Part Size and Chunk Size
    ax1 = axes[0, 0]
    
    # Build heatmap data
    from collections import defaultdict
    vma_matrix = defaultdict(lambda: defaultdict(list))
    for d in data:
        vma_matrix[d['part_size_mb']][d['chunk_size_kb']].append(d['real_vmas'])
    
    heatmap_data = []
    for ps in unique_part_sizes:
        row = []
        for cs in unique_chunk_sizes:
            if vma_matrix[ps][cs]:
                row.append(np.mean(vma_matrix[ps][cs]))
            else:
                row.append(0)
        heatmap_data.append(row)
    
    heatmap_data = np.array(heatmap_data)
    
    im = ax1.imshow(heatmap_data, cmap='RdYlGn_r', aspect='auto')
    ax1.set_xticks(range(len(unique_chunk_sizes)))
    ax1.set_yticks(range(len(unique_part_sizes)))
    ax1.set_xticklabels([f'{int(cs)}KB' if cs < 1024 else f'{int(cs/1024)}MB' 
                         for cs in unique_chunk_sizes], rotation=45)
    ax1.set_yticklabels([f'{int(ps)}MB' for ps in unique_part_sizes])
    ax1.set_xlabel('Chunk Size', fontsize=12, fontweight='bold')
    ax1.set_ylabel('Part Size', fontsize=12, fontweight='bold')
    ax1.set_title('Real OS VMAs: Part Size × Chunk Size', fontsize=14, fontweight='bold')
    plt.colorbar(im, ax=ax1, label='Real OS VMAs')
    
    # Add text annotations
    for i in range(len(unique_part_sizes)):
        for j in range(len(unique_chunk_sizes)):
            if heatmap_data[i, j] > 0:
                ax1.text(j, i, f'{int(heatmap_data[i, j])}',
                        ha="center", va="center", color="white" if heatmap_data[i, j] > heatmap_data.max()/2 else "black",
                        fontsize=8, fontweight='bold')
    
    # Plot 2: VMAs vs Chunk Size for each Part Size
    ax2 = axes[0, 1]
    colors = plt.cm.tab10(np.linspace(0, 1, len(unique_part_sizes)))
    
    for idx, ps in enumerate(unique_part_sizes):
        chunk_vma_pairs = []
        for cs in unique_chunk_sizes:
            if vma_matrix[ps][cs]:
                chunk_vma_pairs.append((cs, np.mean(vma_matrix[ps][cs])))
        
        if chunk_vma_pairs:
            chunks, vmas = zip(*chunk_vma_pairs)
            ax2.plot(chunks, vmas, 'o-', color=colors[idx], linewidth=2,
                    markersize=8, label=f'{int(ps)}MB parts')
    
    ax2.set_xlabel('Chunk Size (KB)', fontsize=12, fontweight='bold')
    ax2.set_ylabel('Real OS VMAs', fontsize=12, fontweight='bold')
    ax2.set_title('VMAs vs Chunk Size by Part Size', fontsize=14, fontweight='bold')
    ax2.set_xscale('log', base=2)
    ax2.set_yscale('log')
    ax2.grid(True, alpha=0.3, which='both')
    ax2.legend(fontsize=9)
    ax2.axhline(y=65536, color='red', linestyle='--', linewidth=2, alpha=0.5)
    
    # Plot 3: Chunks per Part impact
    ax3 = axes[1, 0]
    
    # Group by similar chunks/part ratios
    chunks_bins = [0, 128, 512, 2048, 8192, 100000]
    bin_labels = ['0-128', '128-512', '512-2K', '2K-8K', '8K+']
    
    for label, (low, high) in zip(bin_labels, zip(chunks_bins[:-1], chunks_bins[1:])):
        mask = (chunks_per_part >= low) & (chunks_per_part < high)
        if np.any(mask):
            ax3.scatter(chunks_per_part[mask], real_vmas[mask], 
                       alpha=0.6, s=100, label=f'{label} chunks/part')
    
    ax3.set_xlabel('Chunks Per Part', fontsize=12, fontweight='bold')
    ax3.set_ylabel('Real OS VMAs', fontsize=12, fontweight='bold')
    ax3.set_title('VMAs vs Chunks Per Part', fontsize=14, fontweight='bold')
    ax3.set_xscale('log')
    ax3.set_yscale('log')
    ax3.grid(True, alpha=0.3, which='both')
    ax3.legend(fontsize=9)
    ax3.axhline(y=65536, color='red', linestyle='--', linewidth=2, alpha=0.5, label='VMA Limit')
    
    # Plot 4: Pool efficiency by chunk size
    ax4 = axes[1, 1]
    
    for idx, ps in enumerate(unique_part_sizes):
        chunk_eff_pairs = []
        for cs in unique_chunk_sizes:
            mask = (part_sizes_mb == ps) & (chunk_sizes_kb == cs)
            if np.any(mask):
                avg_miss_rate = np.mean(pool_miss_rate[mask])
                chunk_eff_pairs.append((cs, avg_miss_rate))
        
        if chunk_eff_pairs:
            chunks, miss_rates = zip(*chunk_eff_pairs)
            ax4.scatter(chunks, miss_rates, color=colors[idx], s=100, 
                       alpha=0.6, label=f'{int(ps)}MB parts')
    
    ax4.set_xlabel('Chunk Size (KB)', fontsize=12, fontweight='bold')
    ax4.set_ylabel('Pool Miss Rate', fontsize=12, fontweight='bold')
    ax4.set_title('Pool Miss Rate vs Chunk Size', fontsize=14, fontweight='bold')
    ax4.set_xscale('log', base=2)
    ax4.grid(True, alpha=0.3, which='both')
    ax4.legend(fontsize=9)
    
    plt.tight_layout()
    plt.savefig('vma_chunk_size_analysis.png', dpi=150, bbox_inches='tight')
    print(f"\n✓ Chunk size analysis saved to: vma_chunk_size_analysis.png")
    
    # Print findings
    print(f"\nKey findings:")
    max_vma_idx = np.argmax(real_vmas)
    min_vma_idx = np.argmin(real_vmas)
    vma_ratio = real_vmas.max() / real_vmas.min() if real_vmas.min() > 0 else 0
    print(f"  • Highest VMAs: {real_vmas[max_vma_idx]:.0f} - {data[max_vma_idx]['scenario']}")
    print(f"  • Lowest VMAs: {real_vmas[min_vma_idx]:.0f} - {data[min_vma_idx]['scenario']}")
    print(f"  • VMA range: {real_vmas.min():.0f} to {real_vmas.max():.0f} ({vma_ratio:.1f}× difference)")
    
    # Analyze chunk size effect
    print(f"\n  Chunk size effect on VMAs (holding part size constant):")
    for ps in unique_part_sizes[:3]:  # Show first 3 part sizes
        mask = part_sizes_mb == ps
        if np.any(mask):
            vmas_for_ps = real_vmas[mask]
            if len(vmas_for_ps) > 1:
                vma_range = vmas_for_ps.max() - vmas_for_ps.min()
                vma_pct = (vma_range / vmas_for_ps.mean()) * 100
                print(f"    {int(ps)}MB parts: VMAs vary by {vma_range:.0f} ({vma_pct:.1f}% of mean)")
    
    # Analyze M and C effect
    print(f"\n  MaxInMemoryParts (M) and ConcurrentRequests (C) effect:")
    for m_val in sorted(set(m_values))[:3]:  # Show first 3 M values
        mask = m_values == m_val
        if np.any(mask):
            vmas_for_m = real_vmas[mask]
            if len(vmas_for_m) > 1:
                print(f"    M={int(m_val)}: VMAs range from {vmas_for_m.min():.0f} to {vmas_for_m.max():.0f}")

else:
    print("\nInsufficient chunk size variations for detailed analysis")

print("\n" + "="*80)
print("Analysis complete!")
print("="*80)
