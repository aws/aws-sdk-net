"""
VMA Analysis Visualization Package

A modular Python package for analyzing and visualizing VMA (Virtual Memory Area) 
test results from the VmaAnalysisTool.

Modules:
    vma_data: Data loading and preparation functions
    vma_plots: Visualization and plotting functions  
    vma_analysis: Analysis and recommendation functions

Usage:
    from visualization import load_csv, prepare_data, create_all_plots
    
    df = load_csv('vma-results.csv')
    df = prepare_data(df)
    create_all_plots(df, output_dir='plots')
"""

from .vma_data import (
    load_csv,
    prepare_data,
    get_summary,
    print_summary,
    filter_safe,
    filter_by_part_size,
    filter_by_chunk_size,
    load_multiple_csvs,
    SAFE_THRESHOLD,
    ABORT_THRESHOLD,
    LINUX_LIMIT,
)

from .vma_plots import (
    setup_style,
    plot_chunk_size_impact,
    plot_heatmap,
    plot_safety_margin,
    plot_safety_distribution,
    plot_memory_vs_vma,
    plot_optimal_chunk_sizes,
    plot_memory_validation,
    plot_memory_by_config,
    create_all_plots,
)

from .vma_analysis import (
    find_optimal_chunk_sizes,
    derive_chunk_size_formula,
    calculate_chunk_size,
    generate_chunk_size_table,
    validate_formula,
    print_recommendations,
    export_analysis,
)

__version__ = '1.0.0'
__all__ = [
    # Data functions
    'load_csv',
    'prepare_data', 
    'get_summary',
    'print_summary',
    'filter_safe',
    'filter_by_part_size',
    'filter_by_chunk_size',
    'load_multiple_csvs',
    # Constants
    'SAFE_THRESHOLD',
    'ABORT_THRESHOLD', 
    'LINUX_LIMIT',
    # Plot functions
    'setup_style',
    'plot_chunk_size_impact',
    'plot_heatmap',
    'plot_safety_margin',
    'plot_safety_distribution',
    'plot_memory_vs_vma',
    'plot_optimal_chunk_sizes',
    'create_all_plots',
    # Analysis functions
    'find_optimal_chunk_sizes',
    'derive_chunk_size_formula',
    'calculate_chunk_size',
    'generate_chunk_size_table',
    'validate_formula',
    'print_recommendations',
    'export_analysis',
]
