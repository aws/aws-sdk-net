"""
VMA Analysis Functions Module

This module provides analysis functions to find optimal configurations and derive formulas.
"""

import pandas as pd
import numpy as np
from typing import Dict, List, Any, Optional, Tuple

from .vma_data import SAFE_THRESHOLD, ABORT_THRESHOLD, LINUX_LIMIT


def find_optimal_chunk_sizes(df: pd.DataFrame) -> pd.DataFrame:
    """
    Find the minimum chunk size that keeps VMAs below the safe threshold for each part size.
    
    Args:
        df: Prepared DataFrame
        
    Returns:
        DataFrame with optimal configurations
    """
    if 'PartSizeMB' not in df.columns or 'ChunkSizeKB' not in df.columns:
        print("✗ Required columns not found")
        return pd.DataFrame()
    
    results = []
    
    for part_size in sorted(df['PartSizeMB'].unique()):
        subset = df[df['PartSizeMB'] == part_size].sort_values('ChunkSizeKB')
        safe_configs = subset[subset['PeakVmaCount'] < SAFE_THRESHOLD]
        
        if len(safe_configs) > 0:
            min_safe = safe_configs.iloc[0]
            results.append({
                'PartSizeMB': part_size,
                'MinSafeChunkSizeKB': min_safe['ChunkSizeKB'],
                'VmaCount': min_safe['PeakVmaCount'],
                'SafetyMargin': SAFE_THRESHOLD - min_safe['PeakVmaCount'],
                'ChunksPerPart': min_safe.get('ChunksPerPart', np.nan),
                'Status': 'Safe'
            })
        else:
            # No safe configuration found
            best = subset.loc[subset['PeakVmaCount'].idxmin()] if len(subset) > 0 else None
            results.append({
                'PartSizeMB': part_size,
                'MinSafeChunkSizeKB': None,
                'VmaCount': best['PeakVmaCount'] if best is not None else np.nan,
                'SafetyMargin': np.nan,
                'ChunksPerPart': np.nan,
                'Status': 'No Safe Config'
            })
    
    return pd.DataFrame(results)


def derive_chunk_size_formula(df: pd.DataFrame) -> Dict[str, Any]:
    """
    Attempt to derive a formula for optimal chunk size based on test data.
    
    Args:
        df: Prepared DataFrame with PartSizeMB, ChunkSizeKB, and PeakVmaCount
        
    Returns:
        Dictionary with formula parameters and analysis
    """
    optimal = find_optimal_chunk_sizes(df)
    safe_optimal = optimal[optimal['Status'] == 'Safe'].copy()
    
    if len(safe_optimal) < 2:
        return {
            'formula': None,
            'reason': 'Not enough safe configurations to derive formula',
            'data_points': len(safe_optimal)
        }
    
    # Calculate ratio: ChunkSize / PartSize for each safe config
    safe_optimal['Ratio'] = safe_optimal['MinSafeChunkSizeKB'] * 1024 / (safe_optimal['PartSizeMB'] * 1024 * 1024)
    
    # Simple linear relationship: ChunkSize = k * PartSize
    # Find k that works for all cases
    ratios = safe_optimal['Ratio'].values
    
    # Calculate chunks per part for each configuration
    safe_optimal['ActualChunksPerPart'] = (safe_optimal['PartSizeMB'] * 1024) / safe_optimal['MinSafeChunkSizeKB']
    
    return {
        'formula_type': 'linear_ratio',
        'mean_ratio': ratios.mean(),
        'min_ratio': ratios.min(),
        'max_ratio': ratios.max(),
        'suggested_ratio': ratios.max() * 1.2,  # 20% safety margin
        'data_points': len(safe_optimal),
        'optimal_data': safe_optimal,
        'recommendation': f"ChunkSize = PartSize × {ratios.max() * 1.2:.6f} (with 20% safety margin)"
    }


def calculate_chunk_size(
    part_size_bytes: int,
    max_in_memory_parts: int = 100,
    concurrent_requests: int = 10,
    target_max_vmas: int = SAFE_THRESHOLD,
    safety_factor: float = 2.5,
    min_chunk_size: int = 64 * 1024,
    max_chunk_size: int = 16 * 1024 * 1024
) -> Dict[str, Any]:
    """
    Calculate recommended chunk size using the dynamic formula.
    
    Formula:
    TargetChunksPerPart = TargetMaxVMAs / (MaxInMemoryParts × SafetyFactor)
    ChunkSize = PartSize / TargetChunksPerPart
    
    Args:
        part_size_bytes: Size of each part in bytes
        max_in_memory_parts: Maximum parts to buffer in memory
        concurrent_requests: Number of concurrent HTTP requests
        target_max_vmas: Target maximum VMA count
        safety_factor: Safety multiplier
        min_chunk_size: Minimum chunk size in bytes
        max_chunk_size: Maximum chunk size in bytes
        
    Returns:
        Dictionary with calculation results
    """
    # Calculate target chunks per part
    target_chunks_per_part = target_max_vmas / (max_in_memory_parts * safety_factor)
    
    # Calculate raw chunk size
    raw_chunk_size = part_size_bytes / target_chunks_per_part
    
    # Clamp to min/max bounds
    chunk_size = max(min_chunk_size, min(max_chunk_size, raw_chunk_size))
    
    # Round to nearest power of 2 for memory alignment
    power = np.ceil(np.log2(chunk_size))
    chunk_size_aligned = int(2 ** power)
    
    # Calculate resulting metrics
    chunks_per_part = int(np.ceil(part_size_bytes / chunk_size_aligned))
    max_concurrent_chunks = chunks_per_part * max_in_memory_parts
    
    return {
        'part_size_bytes': part_size_bytes,
        'part_size_mb': part_size_bytes / (1024 * 1024),
        'recommended_chunk_size': chunk_size_aligned,
        'recommended_chunk_size_kb': chunk_size_aligned / 1024,
        'raw_chunk_size': raw_chunk_size,
        'chunks_per_part': chunks_per_part,
        'max_concurrent_chunks': max_concurrent_chunks,
        'estimated_peak_vmas': max_concurrent_chunks,
        'safety_margin': target_max_vmas - max_concurrent_chunks,
        'safety_margin_percent': ((target_max_vmas - max_concurrent_chunks) / target_max_vmas) * 100,
        'formula_params': {
            'max_in_memory_parts': max_in_memory_parts,
            'concurrent_requests': concurrent_requests,
            'target_max_vmas': target_max_vmas,
            'safety_factor': safety_factor
        }
    }


def generate_chunk_size_table(
    part_sizes_mb: List[int] = [5, 10, 50, 100, 500, 1024, 5120],
    **kwargs
) -> pd.DataFrame:
    """
    Generate a table of recommended chunk sizes for various part sizes.
    
    Args:
        part_sizes_mb: List of part sizes to calculate for
        **kwargs: Additional arguments passed to calculate_chunk_size
        
    Returns:
        DataFrame with recommendations
    """
    results = []
    
    for part_mb in part_sizes_mb:
        calc = calculate_chunk_size(part_mb * 1024 * 1024, **kwargs)
        results.append({
            'PartSizeMB': part_mb,
            'RecommendedChunkKB': calc['recommended_chunk_size_kb'],
            'ChunksPerPart': calc['chunks_per_part'],
            'EstimatedPeakVMAs': calc['estimated_peak_vmas'],
            'SafetyMarginPercent': calc['safety_margin_percent']
        })
    
    return pd.DataFrame(results)


def validate_formula(df: pd.DataFrame, formula_fn=None) -> pd.DataFrame:
    """
    Validate a chunk size formula against test data.
    
    Args:
        df: Test data DataFrame
        formula_fn: Function that takes part_size_bytes and returns recommended chunk size
                   If None, uses the default calculate_chunk_size formula
        
    Returns:
        DataFrame comparing predicted vs actual results
    """
    if formula_fn is None:
        formula_fn = lambda ps: calculate_chunk_size(ps)['recommended_chunk_size']
    
    results = []
    
    for _, row in df.iterrows():
        if 'PartSizeBytes' not in row or pd.isna(row['PartSizeBytes']):
            continue
            
        predicted_chunk = formula_fn(int(row['PartSizeBytes']))
        actual_chunk = row.get('ChunkSizeBytes', np.nan)
        actual_vma = row.get('PeakVmaCount', np.nan)
        
        results.append({
            'PartSizeMB': row.get('PartSizeMB', np.nan),
            'ActualChunkKB': actual_chunk / 1024 if not pd.isna(actual_chunk) else np.nan,
            'PredictedChunkKB': predicted_chunk / 1024,
            'ActualVMA': actual_vma,
            'ActualSafe': actual_vma < SAFE_THRESHOLD if not pd.isna(actual_vma) else np.nan,
            'WouldBeSafe': 'Yes' if predicted_chunk >= actual_chunk else 'Maybe'
        })
    
    return pd.DataFrame(results)


def print_recommendations(df: pd.DataFrame) -> None:
    """Print analysis recommendations based on test data."""
    optimal = find_optimal_chunk_sizes(df)
    
    print("\n" + "=" * 60)
    print("CHUNK SIZE RECOMMENDATIONS")
    print("=" * 60)
    
    print("\n📊 Optimal Chunk Sizes (minimum to stay safe):")
    print("-" * 50)
    
    for _, row in optimal.iterrows():
        if row['Status'] == 'Safe':
            print(f"  Part Size: {row['PartSizeMB']:>6.0f} MB → Chunk: {row['MinSafeChunkSizeKB']:>6.0f} KB " +
                  f"(VMA: {row['VmaCount']:>6,.0f}, Margin: {row['SafetyMargin']:>+6,.0f})")
        else:
            print(f"  Part Size: {row['PartSizeMB']:>6.0f} MB → ✗ No safe configuration found")
    
    # Formula derivation
    formula = derive_chunk_size_formula(df)
    
    print("\n📐 Formula Analysis:")
    print("-" * 50)
    if formula['formula_type']:
        print(f"  ChunkSize/PartSize ratio range: {formula['min_ratio']:.6f} - {formula['max_ratio']:.6f}")
        print(f"  Suggested formula: {formula['recommendation']}")
    else:
        print(f"  {formula['reason']}")
    
    # Dynamic formula test
    print("\n🔧 Dynamic Formula Recommendations:")
    print("-" * 50)
    table = generate_chunk_size_table()
    print(table.to_string(index=False))
    
    print("\n💡 Key Insights:")
    print("-" * 50)
    print("  • Larger chunk sizes = fewer VMAs (same memory usage)")
    print("  • VMA count ≈ MaxInMemoryParts × ChunksPerPart")
    print("  • Memory usage = MaxInMemoryParts × PartSize (independent of chunk size)")
    print("  • Target: Keep VMA count below 50,000 for safety")


def export_analysis(df: pd.DataFrame, output_path: str) -> None:
    """
    Export detailed analysis to a CSV file.
    
    Args:
        df: Prepared DataFrame
        output_path: Path to save the analysis
    """
    optimal = find_optimal_chunk_sizes(df)
    optimal.to_csv(output_path, index=False)
    print(f"✓ Analysis exported to: {output_path}")
