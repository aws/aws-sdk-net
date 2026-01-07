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
    # Skip cases with 512MB parts as they show anomalous behavior
    if r['PartSize'] >= 512 * 1024 * 1024:
        continue
    
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

print("\n" + "="*80)
print("Analysis complete!")
print("="*80)
