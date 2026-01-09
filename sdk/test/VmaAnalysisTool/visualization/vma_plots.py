"""
VMA Plotting Functions Module

This module provides visualization functions for VMA analysis data.
"""

import matplotlib.pyplot as plt
import seaborn as sns
import pandas as pd
import numpy as np
from pathlib import Path
from typing import Optional, List, Tuple

from .vma_data import SAFE_THRESHOLD, ABORT_THRESHOLD, LINUX_LIMIT


def setup_style():
    """Configure matplotlib and seaborn styles."""
    sns.set_theme(style="whitegrid")
    plt.rcParams['figure.figsize'] = [12, 6]
    plt.rcParams['font.size'] = 11
    plt.rcParams['axes.titlesize'] = 14
    plt.rcParams['axes.labelsize'] = 12


def plot_chunk_size_impact(df: pd.DataFrame, output_path: Optional[str] = None, show: bool = True) -> plt.Figure:
    """
    Create a line plot showing how chunk size affects VMA count.
    
    Args:
        df: Prepared DataFrame
        output_path: Optional path to save the figure
        show: Whether to display the plot
        
    Returns:
        matplotlib Figure object
    """
    if 'ChunkSizeKB' not in df.columns:
        print("✗ ChunkSizeKB column not found")
        return None
    
    fig, ax = plt.subplots(figsize=(14, 7))
    
    # Plot lines for each part size
    if 'PartSizeMB' in df.columns:
        for part_size in sorted(df['PartSizeMB'].unique()):
            subset = df[df['PartSizeMB'] == part_size].sort_values('ChunkSizeKB')
            ax.plot(subset['ChunkSizeKB'], subset['PeakVmaCount'], 
                   marker='o', label=f'{part_size:.0f}MB parts', linewidth=2, markersize=6)
    else:
        subset = df.sort_values('ChunkSizeKB')
        ax.plot(subset['ChunkSizeKB'], subset['PeakVmaCount'], marker='o', linewidth=2)
    
    # Add threshold lines
    ax.axhline(y=SAFE_THRESHOLD, color='orange', linestyle='--', linewidth=2, 
               label=f'Safe Threshold ({SAFE_THRESHOLD:,})')
    ax.axhline(y=ABORT_THRESHOLD, color='red', linestyle='--', linewidth=2, 
               label=f'Abort Threshold ({ABORT_THRESHOLD:,})')
    ax.axhline(y=LINUX_LIMIT, color='darkred', linestyle='-', linewidth=1.5, 
               label=f'Linux Limit ({LINUX_LIMIT:,})')
    
    # Fill safe zone
    xlim = ax.get_xlim()
    ax.fill_between([xlim[0], xlim[1]], 0, SAFE_THRESHOLD, alpha=0.1, color='green')
    ax.set_xlim(xlim)
    
    ax.set_xlabel('Chunk Size (KB)')
    ax.set_ylabel('Peak VMA Count')
    ax.set_title('Impact of Chunk Size on VMA Count')
    ax.legend(loc='upper right', fontsize=10)
    ax.set_xscale('log', base=2)
    ax.grid(True, alpha=0.3)
    ax.yaxis.set_major_formatter(plt.FuncFormatter(lambda x, p: f'{x:,.0f}'))
    
    plt.tight_layout()
    
    if output_path:
        fig.savefig(output_path, dpi=150, bbox_inches='tight')
        print(f"✓ Saved: {output_path}")
    
    if show:
        plt.show()
    
    return fig


def plot_heatmap(df: pd.DataFrame, output_path: Optional[str] = None, show: bool = True) -> plt.Figure:
    """
    Create a heatmap of VMA count by part size and chunk size.
    
    Args:
        df: Prepared DataFrame
        output_path: Optional path to save the figure
        show: Whether to display the plot
        
    Returns:
        matplotlib Figure object
    """
    if 'PartSizeMB' not in df.columns or 'ChunkSizeKB' not in df.columns:
        print("✗ Required columns not found for heatmap")
        return None
    
    # Create pivot table
    pivot = df.pivot_table(
        values='PeakVmaCount',
        index='PartSizeMB',
        columns='ChunkSizeKB',
        aggfunc='mean'
    )
    
    fig, ax = plt.subplots(figsize=(14, 10))
    
    sns.heatmap(pivot,
                annot=True,
                fmt='.0f',
                cmap='RdYlGn_r',
                center=SAFE_THRESHOLD,
                vmin=0,
                vmax=ABORT_THRESHOLD,
                linewidths=0.5,
                ax=ax,
                cbar_kws={'label': 'Peak VMA Count'})
    
    ax.set_title('VMA Count: Part Size × Chunk Size\n(Green = Safe, Red = Danger)')
    ax.set_xlabel('Chunk Size (KB)')
    ax.set_ylabel('Part Size (MB)')
    
    plt.tight_layout()
    
    if output_path:
        fig.savefig(output_path, dpi=150, bbox_inches='tight')
        print(f"✓ Saved: {output_path}")
    
    if show:
        plt.show()
    
    return fig


def plot_safety_margin(df: pd.DataFrame, top_n: int = 30, output_path: Optional[str] = None, 
                       show: bool = True) -> plt.Figure:
    """
    Create a horizontal bar chart showing safety margins.
    
    Args:
        df: Prepared DataFrame
        top_n: Number of configurations to show
        output_path: Optional path to save the figure
        show: Whether to display the plot
        
    Returns:
        matplotlib Figure object
    """
    if 'SafetyMargin' not in df.columns:
        print("✗ SafetyMargin column not found")
        return None
    
    fig, ax = plt.subplots(figsize=(14, max(8, top_n * 0.3)))
    
    df_sorted = df.sort_values('SafetyMargin', ascending=False).head(top_n)
    colors = ['green' if x > 0 else 'red' for x in df_sorted['SafetyMargin']]
    
    y_pos = range(len(df_sorted))
    ax.barh(y_pos, df_sorted['SafetyMargin'], color=colors)
    ax.set_yticks(y_pos)
    ax.set_yticklabels(df_sorted['Name'].str[:45])
    ax.axvline(x=0, color='black', linewidth=2)
    
    ax.set_xlabel('Safety Margin (VMAs from 50K threshold)')
    ax.set_title('Safety Margin by Configuration\n(Positive = Safe, Negative = Over Threshold)')
    ax.xaxis.set_major_formatter(plt.FuncFormatter(lambda x, p: f'{x:,.0f}'))
    
    plt.tight_layout()
    
    if output_path:
        fig.savefig(output_path, dpi=150, bbox_inches='tight')
        print(f"✓ Saved: {output_path}")
    
    if show:
        plt.show()
    
    return fig


def plot_safety_distribution(df: pd.DataFrame, output_path: Optional[str] = None, 
                            show: bool = True) -> plt.Figure:
    """
    Create pie and bar charts showing safety status distribution.
    
    Args:
        df: Prepared DataFrame
        output_path: Optional path to save the figure
        show: Whether to display the plot
        
    Returns:
        matplotlib Figure object
    """
    if 'SafetyStatus' not in df.columns:
        print("✗ SafetyStatus column not found")
        return None
    
    fig, axes = plt.subplots(1, 2, figsize=(14, 5))
    
    status_counts = df['SafetyStatus'].value_counts()
    colors_map = {
        'Safe': 'green', 
        'Warning': 'gold', 
        'Unsafe': 'orange', 
        'Critical': 'red', 
        'Exceeded': 'darkred'
    }
    pie_colors = [colors_map.get(s, 'gray') for s in status_counts.index]
    
    # Pie chart
    axes[0].pie(status_counts.values, labels=status_counts.index, colors=pie_colors,
                autopct='%1.1f%%', startangle=90)
    axes[0].set_title('Test Results by Safety Status')
    
    # Bar chart
    axes[1].bar(status_counts.index, status_counts.values, color=pie_colors)
    axes[1].set_xlabel('Safety Status')
    axes[1].set_ylabel('Number of Tests')
    axes[1].set_title('Test Count by Safety Status')
    
    plt.tight_layout()
    
    if output_path:
        fig.savefig(output_path, dpi=150, bbox_inches='tight')
        print(f"✓ Saved: {output_path}")
    
    if show:
        plt.show()
    
    return fig


def plot_memory_vs_vma(df: pd.DataFrame, output_path: Optional[str] = None, 
                       show: bool = True) -> plt.Figure:
    """
    Create a scatter plot of memory usage vs VMA count.
    
    Args:
        df: Prepared DataFrame
        output_path: Optional path to save the figure
        show: Whether to display the plot
        
    Returns:
        matplotlib Figure object
    """
    if 'EstimatedMemoryGB' not in df.columns:
        print("✗ EstimatedMemoryGB column not found")
        return None
    
    fig, ax = plt.subplots(figsize=(12, 8))
    
    # Color by chunk size if available
    if 'ChunkSizeKB' in df.columns:
        scatter = ax.scatter(df['EstimatedMemoryGB'], df['PeakVmaCount'],
                            c=df['ChunkSizeKB'], cmap='viridis', alpha=0.7, s=50)
        cbar = plt.colorbar(scatter, ax=ax)
        cbar.set_label('Chunk Size (KB)')
    else:
        ax.scatter(df['EstimatedMemoryGB'], df['PeakVmaCount'], alpha=0.7, s=50)
    
    # Add threshold lines
    ax.axhline(y=SAFE_THRESHOLD, color='orange', linestyle='--', linewidth=2, label='Safe Threshold')
    ax.axhline(y=ABORT_THRESHOLD, color='red', linestyle='--', linewidth=2, label='Abort Threshold')
    
    ax.set_xlabel('Estimated Memory (GB)')
    ax.set_ylabel('Peak VMA Count')
    ax.set_title('Memory Usage vs VMA Count\n(Same memory can have different VMA counts depending on chunk size)')
    ax.legend()
    ax.yaxis.set_major_formatter(plt.FuncFormatter(lambda x, p: f'{x:,.0f}'))
    ax.grid(True, alpha=0.3)
    
    plt.tight_layout()
    
    if output_path:
        fig.savefig(output_path, dpi=150, bbox_inches='tight')
        print(f"✓ Saved: {output_path}")
    
    if show:
        plt.show()
    
    return fig


def plot_optimal_chunk_sizes(df: pd.DataFrame, output_path: Optional[str] = None, 
                             show: bool = True) -> plt.Figure:
    """
    Plot the minimum safe chunk size for each part size.
    
    Args:
        df: Prepared DataFrame
        output_path: Optional path to save the figure
        show: Whether to display the plot
        
    Returns:
        matplotlib Figure object
    """
    if 'PartSizeMB' not in df.columns or 'ChunkSizeKB' not in df.columns:
        print("✗ Required columns not found")
        return None
    
    # Filter to safe configurations
    safe_df = df[df['PeakVmaCount'] < SAFE_THRESHOLD].copy()
    
    if len(safe_df) == 0:
        print("✗ No safe configurations found")
        return None
    
    # Find minimum safe chunk size for each part size
    min_safe = safe_df.loc[safe_df.groupby('PartSizeMB')['ChunkSizeKB'].idxmin()]
    
    fig, ax = plt.subplots(figsize=(12, 6))
    
    ax.scatter(min_safe['PartSizeMB'], min_safe['ChunkSizeKB'], 
               s=100, c='green', marker='o', label='Minimum Safe Chunk Size', zorder=5)
    ax.plot(min_safe['PartSizeMB'], min_safe['ChunkSizeKB'], 
            linestyle='--', alpha=0.5, color='green')
    
    ax.set_xlabel('Part Size (MB)')
    ax.set_ylabel('Minimum Chunk Size (KB)')
    ax.set_title('Minimum Chunk Size Required for Safety\n(Below 50,000 VMAs)')
    ax.legend()
    ax.grid(True, alpha=0.3)
    
    plt.tight_layout()
    
    if output_path:
        fig.savefig(output_path, dpi=150, bbox_inches='tight')
        print(f"✓ Saved: {output_path}")
    
    if show:
        plt.show()
    
    return fig


def plot_memory_validation(df: pd.DataFrame, output_path: Optional[str] = None, 
                           show: bool = True) -> plt.Figure:
    """
    Plot actual vs expected memory usage to validate the formula.
    
    Args:
        df: Prepared DataFrame
        output_path: Optional path to save the figure
        show: Whether to display the plot
        
    Returns:
        matplotlib Figure object
    """
    # Check for required columns
    expected_col = 'ExpectedMemoryGB' if 'ExpectedMemoryGB' in df.columns else 'EstimatedMemoryGB'
    actual_col = 'WorkingSetDeltaGB' if 'WorkingSetDeltaGB' in df.columns else None
    
    if expected_col not in df.columns:
        print("✗ Expected memory column not found")
        return None
    
    if actual_col is None or actual_col not in df.columns:
        print("✗ Actual memory column (WorkingSetDeltaGB) not found")
        print("  Note: Memory tracking requires running tests with latest VmaAnalysisTool")
        return None
    
    # Filter out invalid data
    valid_df = df[(df[expected_col] > 0) & (df[actual_col] > 0)].copy()
    
    if len(valid_df) == 0:
        print("✗ No valid memory data found")
        return None
    
    fig, axes = plt.subplots(1, 2, figsize=(14, 6))
    
    # Plot 1: Scatter plot of expected vs actual
    ax1 = axes[0]
    max_val = max(valid_df[expected_col].max(), valid_df[actual_col].max()) * 1.1
    
    ax1.scatter(valid_df[expected_col], valid_df[actual_col], alpha=0.6, s=50)
    ax1.plot([0, max_val], [0, max_val], 'r--', linewidth=2, label='Perfect Match (1:1)')
    ax1.plot([0, max_val], [0, max_val * 0.5], 'g--', linewidth=1, alpha=0.5, label='0.5x')
    ax1.plot([0, max_val], [0, max_val * 2], 'g--', linewidth=1, alpha=0.5, label='2.0x')
    
    ax1.set_xlabel('Expected Memory (GB)\n(MaxInMemoryParts × PartSize)')
    ax1.set_ylabel('Actual Memory Delta (GB)')
    ax1.set_title('Memory Formula Validation\nExpected vs Actual Usage')
    ax1.legend()
    ax1.grid(True, alpha=0.3)
    ax1.set_xlim(0, max_val)
    ax1.set_ylim(0, max_val)
    
    # Plot 2: Efficiency ratio histogram
    ax2 = axes[1]
    if 'MemoryEfficiencyRatio' in valid_df.columns:
        ratios = valid_df['MemoryEfficiencyRatio'].dropna()
        ratios = ratios[(ratios > 0) & (ratios < 5)]  # Filter outliers
        
        if len(ratios) > 0:
            ax2.hist(ratios, bins=30, edgecolor='black', alpha=0.7)
            ax2.axvline(x=1.0, color='red', linestyle='--', linewidth=2, label='Expected (1.0)')
            ax2.axvline(x=ratios.mean(), color='green', linestyle='-', linewidth=2, 
                       label=f'Mean ({ratios.mean():.2f})')
            
            ax2.set_xlabel('Memory Efficiency Ratio (Actual/Expected)')
            ax2.set_ylabel('Number of Tests')
            ax2.set_title('Distribution of Memory Efficiency Ratio\n(1.0 = Perfect Match)')
            ax2.legend()
            ax2.grid(True, alpha=0.3)
    
    plt.tight_layout()
    
    if output_path:
        fig.savefig(output_path, dpi=150, bbox_inches='tight')
        print(f"✓ Saved: {output_path}")
    
    if show:
        plt.show()
    
    return fig


def plot_memory_by_config(df: pd.DataFrame, output_path: Optional[str] = None, 
                          show: bool = True) -> plt.Figure:
    """
    Plot memory usage grouped by configuration parameters.
    
    Args:
        df: Prepared DataFrame
        output_path: Optional path to save the figure
        show: Whether to display the plot
        
    Returns:
        matplotlib Figure object
    """
    expected_col = 'ExpectedMemoryGB' if 'ExpectedMemoryGB' in df.columns else 'EstimatedMemoryGB'
    actual_col = 'WorkingSetDeltaGB' if 'WorkingSetDeltaGB' in df.columns else None
    
    if expected_col not in df.columns or 'PartSizeMB' not in df.columns:
        print("✗ Required columns not found")
        return None
    
    fig, ax = plt.subplots(figsize=(14, 8))
    
    # Group by part size and max in memory parts
    if 'MaxInMemoryParts' in df.columns:
        grouped = df.groupby(['PartSizeMB', 'MaxInMemoryParts']).agg({
            expected_col: 'first',
            actual_col: 'mean' if actual_col else 'first',
            'PeakVmaCount': 'mean'
        }).reset_index()
        
        grouped['Label'] = grouped.apply(
            lambda x: f"{x['PartSizeMB']:.0f}MB × {x['MaxInMemoryParts']:.0f}", axis=1)
        
        x = range(len(grouped))
        width = 0.35
        
        bars1 = ax.bar([i - width/2 for i in x], grouped[expected_col], width, 
                       label='Expected (MaxInMemoryParts × PartSize)', color='steelblue', alpha=0.8)
        
        if actual_col and actual_col in grouped.columns:
            bars2 = ax.bar([i + width/2 for i in x], grouped[actual_col], width, 
                          label='Actual (Working Set Delta)', color='coral', alpha=0.8)
        
        ax.set_xticks(x)
        ax.set_xticklabels(grouped['Label'], rotation=45, ha='right')
        ax.set_xlabel('Configuration (PartSize × MaxInMemoryParts)')
        ax.set_ylabel('Memory (GB)')
        ax.set_title('Memory Usage by Configuration\nExpected vs Actual')
        ax.legend()
        ax.grid(True, alpha=0.3, axis='y')
    
    plt.tight_layout()
    
    if output_path:
        fig.savefig(output_path, dpi=150, bbox_inches='tight')
        print(f"✓ Saved: {output_path}")
    
    if show:
        plt.show()
    
    return fig


def create_all_plots(df: pd.DataFrame, output_dir: str = ".", prefix: str = "", show: bool = False):
    """
    Generate all standard visualizations and save them.
    
    Args:
        df: Prepared DataFrame
        output_dir: Directory to save plots
        prefix: Optional prefix for output filenames
        show: Whether to display plots
    """
    setup_style()
    output_dir = Path(output_dir)
    output_dir.mkdir(parents=True, exist_ok=True)
    
    p = prefix + "_" if prefix else ""
    
    print("\n" + "=" * 50)
    print("GENERATING VISUALIZATIONS")
    print("=" * 50 + "\n")
    
    plot_chunk_size_impact(df, output_dir / f"{p}chunk_size_impact.png", show=show)
    plot_heatmap(df, output_dir / f"{p}vma_heatmap.png", show=show)
    plot_safety_margin(df, output_path=output_dir / f"{p}safety_margin.png", show=show)
    plot_safety_distribution(df, output_dir / f"{p}safety_distribution.png", show=show)
    plot_memory_vs_vma(df, output_dir / f"{p}memory_vs_vma.png", show=show)
    plot_optimal_chunk_sizes(df, output_dir / f"{p}optimal_chunk_sizes.png", show=show)
    
    # Memory-specific plots (only if data is available)
    if 'WorkingSetDeltaGB' in df.columns or 'WorkingSetDeltaBytes' in df.columns:
        print("\n--- Memory Analysis Plots ---\n")
        plot_memory_validation(df, output_dir / f"{p}memory_validation.png", show=show)
        plot_memory_by_config(df, output_dir / f"{p}memory_by_config.png", show=show)
    
    print(f"\n✓ All plots saved to: {output_dir}")
