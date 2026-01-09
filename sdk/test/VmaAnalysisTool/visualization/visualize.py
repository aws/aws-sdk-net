#!/usr/bin/env python3
"""
VMA Analysis Visualization Tool

Main entry point for analyzing and visualizing VMA test results.

Usage:
    python visualize.py <csv_file> [options]
    
Examples:
    python visualize.py vma-results.csv
    python visualize.py vma-results.csv --output-dir plots --all
    python visualize.py vma-results.csv --summary --recommendations
    python visualize.py vma-results.csv --plot heatmap --show
"""

import argparse
import sys
from pathlib import Path

# Add parent directory to path for standalone execution
if __name__ == "__main__":
    sys.path.insert(0, str(Path(__file__).parent.parent))

from visualization.vma_data import load_csv, prepare_data, print_summary, get_summary
from visualization.vma_plots import (
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
from visualization.vma_analysis import (
    print_recommendations,
    find_optimal_chunk_sizes,
    generate_chunk_size_table,
    export_analysis,
)


def parse_args():
    """Parse command line arguments."""
    parser = argparse.ArgumentParser(
        description='Analyze and visualize VMA test results from VmaAnalysisTool',
        formatter_class=argparse.RawDescriptionHelpFormatter,
        epilog="""
Examples:
  %(prog)s vma-results.csv                     # Summary and recommendations
  %(prog)s vma-results.csv --all               # Generate all plots
  %(prog)s vma-results.csv --plot heatmap      # Generate specific plot
  %(prog)s vma-results.csv --show              # Display plots interactively
  %(prog)s vma-results.csv --export analysis.csv  # Export analysis

Available plots:
  chunk-impact    Line plot of chunk size vs VMA count
  heatmap         Heatmap of part size × chunk size
  safety-margin   Bar chart of safety margins
  safety-dist     Pie/bar charts of safety status distribution
  memory-vma      Scatter plot of memory vs VMA count
  optimal         Minimum safe chunk sizes plot
        """
    )
    
    parser.add_argument('csv_file', help='Path to CSV file from VmaAnalysisTool')
    
    # Output options
    parser.add_argument('-o', '--output-dir', default='.',
                        help='Directory to save output files (default: current dir)')
    parser.add_argument('--prefix', default='',
                        help='Prefix for output filenames')
    
    # What to generate
    parser.add_argument('--all', action='store_true',
                        help='Generate all plots')
    parser.add_argument('--plot', choices=[
                        'chunk-impact', 'heatmap', 'safety-margin', 
                        'safety-dist', 'memory-vma', 'optimal'],
                        help='Generate a specific plot')
    parser.add_argument('--summary', action='store_true',
                        help='Print data summary')
    parser.add_argument('--recommendations', action='store_true',
                        help='Print chunk size recommendations')
    parser.add_argument('--export', metavar='FILE',
                        help='Export analysis to CSV file')
    parser.add_argument('--table', action='store_true',
                        help='Print chunk size recommendation table')
    
    # Display options
    parser.add_argument('--show', action='store_true',
                        help='Display plots interactively (requires display)')
    parser.add_argument('--no-save', action='store_true',
                        help='Do not save plots to files')
    
    # Filter options
    parser.add_argument('--part-size', type=float, metavar='MB',
                        help='Filter to specific part size (MB)')
    parser.add_argument('--chunk-size', type=float, metavar='KB',
                        help='Filter to specific chunk size (KB)')
    parser.add_argument('--safe-only', action='store_true',
                        help='Filter to only safe configurations')
    
    return parser.parse_args()


def main():
    """Main entry point."""
    args = parse_args()
    
    # Load data
    print("\n" + "=" * 60)
    print("VMA ANALYSIS VISUALIZATION TOOL")
    print("=" * 60 + "\n")
    
    df = load_csv(args.csv_file)
    if df is None:
        sys.exit(1)
    
    # Prepare data
    df = prepare_data(df)
    
    # Apply filters
    if args.part_size:
        if 'PartSizeMB' in df.columns:
            df = df[df['PartSizeMB'] == args.part_size]
            print(f"✓ Filtered to part size: {args.part_size} MB ({len(df)} rows)")
        else:
            print("⚠ Cannot filter by part size - column not found")
    
    if args.chunk_size:
        if 'ChunkSizeKB' in df.columns:
            df = df[df['ChunkSizeKB'] == args.chunk_size]
            print(f"✓ Filtered to chunk size: {args.chunk_size} KB ({len(df)} rows)")
        else:
            print("⚠ Cannot filter by chunk size - column not found")
    
    if args.safe_only:
        from visualization.vma_data import SAFE_THRESHOLD
        df = df[df['PeakVmaCount'] < SAFE_THRESHOLD]
        print(f"✓ Filtered to safe configs only ({len(df)} rows)")
    
    if len(df) == 0:
        print("✗ No data remaining after filters")
        sys.exit(1)
    
    # Default behavior: summary + recommendations if no specific action requested
    no_action = not any([args.all, args.plot, args.summary, 
                         args.recommendations, args.export, args.table])
    
    # Print summary
    if args.summary or no_action:
        print_summary(df)
    
    # Print recommendations
    if args.recommendations or no_action:
        print_recommendations(df)
    
    # Print chunk size table
    if args.table:
        print("\n" + "=" * 60)
        print("DYNAMIC CHUNK SIZE TABLE")
        print("=" * 60 + "\n")
        table = generate_chunk_size_table()
        print(table.to_string(index=False))
    
    # Export analysis
    if args.export:
        export_analysis(df, args.export)
    
    # Generate plots
    setup_style()
    output_dir = Path(args.output_dir)
    output_dir.mkdir(parents=True, exist_ok=True)
    prefix = args.prefix + "_" if args.prefix else ""
    
    save_path = None if args.no_save else lambda name: str(output_dir / f"{prefix}{name}")
    
    if args.all:
        create_all_plots(df, output_dir=str(output_dir), prefix=args.prefix, show=args.show)
    
    elif args.plot:
        plot_map = {
            'chunk-impact': ('chunk_size_impact.png', plot_chunk_size_impact),
            'heatmap': ('vma_heatmap.png', plot_heatmap),
            'safety-margin': ('safety_margin.png', plot_safety_margin),
            'safety-dist': ('safety_distribution.png', plot_safety_distribution),
            'memory-vma': ('memory_vs_vma.png', plot_memory_vs_vma),
            'optimal': ('optimal_chunk_sizes.png', plot_optimal_chunk_sizes),
        }
        
        filename, plot_fn = plot_map[args.plot]
        output_path = save_path(filename) if save_path else None
        plot_fn(df, output_path=output_path, show=args.show)
    
    print("\n✓ Done!\n")


if __name__ == '__main__':
    main()
