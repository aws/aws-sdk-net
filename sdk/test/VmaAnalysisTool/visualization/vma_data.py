"""
VMA Data Loading and Preparation Module

This module handles loading CSV data from VmaAnalysisTool and preparing it for visualization.
"""

import pandas as pd
import numpy as np
from pathlib import Path
from typing import Optional, List, Dict, Any


# Constants
SAFE_THRESHOLD = 50000
ABORT_THRESHOLD = 60000
LINUX_LIMIT = 65536


def load_csv(filepath: str) -> Optional[pd.DataFrame]:
    """
    Load VMA analysis results from a CSV file.
    
    Args:
        filepath: Path to the CSV file
        
    Returns:
        DataFrame with the loaded data, or None if file not found
    """
    try:
        df = pd.read_csv(filepath)
        print(f"✓ Loaded {len(df)} results from {filepath}")
        print(f"  Columns: {list(df.columns)}")
        return df
    except FileNotFoundError:
        print(f"✗ File not found: {filepath}")
        print("\nRun VmaAnalysisTool first:")
        print("  dotnet run -- chunk-sweep --isolated --export-csv vma-results.csv")
        return None
    except Exception as e:
        print(f"✗ Error loading file: {e}")
        return None


def prepare_data(df: pd.DataFrame) -> pd.DataFrame:
    """
    Prepare and enrich the data with derived columns.
    
    Args:
        df: Raw DataFrame from CSV
        
    Returns:
        DataFrame with additional computed columns
    """
    df = df.copy()
    
    # Convert bytes to readable units
    if 'PartSizeBytes' in df.columns:
        df['PartSizeMB'] = df['PartSizeBytes'] / (1024 * 1024)
        df['PartSizeGB'] = df['PartSizeBytes'] / (1024 ** 3)
    
    if 'ChunkSizeBytes' in df.columns:
        df['ChunkSizeKB'] = df['ChunkSizeBytes'] / 1024
        df['ChunkSizeMB'] = df['ChunkSizeBytes'] / (1024 * 1024)
    
    # Calculate chunks per part
    if 'ChunksPerPart' not in df.columns:
        if 'PartSizeBytes' in df.columns and 'ChunkSizeBytes' in df.columns:
            df['ChunksPerPart'] = np.ceil(df['PartSizeBytes'] / df['ChunkSizeBytes']).astype(int)
    
    # Calculate estimated memory (if not present from CSV)
    if 'ExpectedMemoryBytes' not in df.columns:
        if 'MaxInMemoryParts' in df.columns and 'PartSizeBytes' in df.columns:
            df['ExpectedMemoryBytes'] = df['MaxInMemoryParts'] * df['PartSizeBytes']
    
    # Convert memory columns to GB for easier visualization
    memory_byte_cols = ['ExpectedMemoryBytes', 'BaselineWorkingSetBytes', 'PeakWorkingSetBytes', 
                        'WorkingSetDeltaBytes', 'PeakPrivateMemoryBytes', 'PeakGcMemoryBytes']
    for col in memory_byte_cols:
        if col in df.columns:
            gb_col = col.replace('Bytes', 'GB')
            df[gb_col] = df[col] / (1024 ** 3)
    
    # Legacy column name support
    if 'EstimatedMemoryGB' not in df.columns and 'ExpectedMemoryGB' in df.columns:
        df['EstimatedMemoryGB'] = df['ExpectedMemoryGB']
    elif 'EstimatedMemoryGB' not in df.columns:
        if 'MaxInMemoryParts' in df.columns and 'PartSizeBytes' in df.columns:
            df['EstimatedMemoryGB'] = (df['MaxInMemoryParts'] * df['PartSizeBytes']) / (1024 ** 3)
    
    # Calculate memory efficiency ratio if not present
    if 'MemoryEfficiencyRatio' not in df.columns:
        if 'WorkingSetDeltaBytes' in df.columns and 'ExpectedMemoryBytes' in df.columns:
            df['MemoryEfficiencyRatio'] = df['WorkingSetDeltaBytes'] / df['ExpectedMemoryBytes']
    
    # Safety calculations
    df['SafetyMargin'] = SAFE_THRESHOLD - df['PeakVmaCount']
    df['SafetyMarginPercent'] = (df['SafetyMargin'] / SAFE_THRESHOLD) * 100
    
    # Safety status categorization
    df['SafetyStatus'] = pd.cut(
        df['PeakVmaCount'],
        bins=[0, SAFE_THRESHOLD * 0.8, SAFE_THRESHOLD, ABORT_THRESHOLD, LINUX_LIMIT, float('inf')],
        labels=['Safe', 'Warning', 'Unsafe', 'Critical', 'Exceeded']
    )
    
    print(f"✓ Data prepared with {len(df.columns)} columns")
    return df


def get_summary(df: pd.DataFrame) -> Dict[str, Any]:
    """
    Generate summary statistics for the data.
    
    Args:
        df: Prepared DataFrame
        
    Returns:
        Dictionary with summary statistics
    """
    return {
        'total_tests': len(df),
        'safe_count': len(df[df['PeakVmaCount'] < SAFE_THRESHOLD]),
        'warning_count': len(df[(df['PeakVmaCount'] >= SAFE_THRESHOLD) & (df['PeakVmaCount'] < ABORT_THRESHOLD)]),
        'aborted_count': len(df[df['PeakVmaCount'] >= ABORT_THRESHOLD]),
        'vma_min': df['PeakVmaCount'].min(),
        'vma_max': df['PeakVmaCount'].max(),
        'vma_mean': df['PeakVmaCount'].mean(),
        'chunk_sizes': sorted(df['ChunkSizeKB'].unique()) if 'ChunkSizeKB' in df.columns else [],
        'part_sizes': sorted(df['PartSizeMB'].unique()) if 'PartSizeMB' in df.columns else [],
    }


def print_summary(df: pd.DataFrame) -> None:
    """Print a formatted summary of the data."""
    summary = get_summary(df)
    
    print("\n" + "=" * 50)
    print("VMA ANALYSIS SUMMARY")
    print("=" * 50)
    print(f"\nTotal tests: {summary['total_tests']}")
    print(f"  ✓ Safe (< 50K):      {summary['safe_count']}")
    print(f"  ⚠ Warning (50-60K):  {summary['warning_count']}")
    print(f"  ✗ Aborted (≥ 60K):   {summary['aborted_count']}")
    print(f"\nVMA Count Range: {summary['vma_min']:,.0f} - {summary['vma_max']:,.0f}")
    print(f"VMA Count Mean:  {summary['vma_mean']:,.0f}")
    
    if summary['chunk_sizes']:
        print(f"\nChunk Sizes (KB): {summary['chunk_sizes']}")
    if summary['part_sizes']:
        print(f"Part Sizes (MB): {summary['part_sizes']}")


def filter_safe(df: pd.DataFrame) -> pd.DataFrame:
    """Return only tests that stayed below the safe threshold."""
    return df[df['PeakVmaCount'] < SAFE_THRESHOLD].copy()


def filter_by_part_size(df: pd.DataFrame, part_size_mb: float) -> pd.DataFrame:
    """Return only tests for a specific part size."""
    if 'PartSizeMB' not in df.columns:
        return df
    return df[df['PartSizeMB'] == part_size_mb].copy()


def filter_by_chunk_size(df: pd.DataFrame, chunk_size_kb: float) -> pd.DataFrame:
    """Return only tests for a specific chunk size."""
    if 'ChunkSizeKB' not in df.columns:
        return df
    return df[df['ChunkSizeKB'] == chunk_size_kb].copy()


def load_multiple_csvs(filepaths: List[str], labels: Optional[List[str]] = None) -> pd.DataFrame:
    """
    Load and combine multiple CSV files.
    
    Args:
        filepaths: List of CSV file paths
        labels: Optional labels for each file (used in 'Source' column)
        
    Returns:
        Combined DataFrame with 'Source' column
    """
    dfs = []
    labels = labels or [Path(f).stem for f in filepaths]
    
    for filepath, label in zip(filepaths, labels):
        df = load_csv(filepath)
        if df is not None:
            df['Source'] = label
            dfs.append(df)
    
    if not dfs:
        return None
    
    combined = pd.concat(dfs, ignore_index=True)
    print(f"\n✓ Combined {len(dfs)} files with {len(combined)} total rows")
    return combined
