#!/bin/bash

# Setup script for DocFX documentation generation with Material theme
# This script demonstrates how to use the new DocFX integration

# Default values
SDK_ASSEMBLIES_ROOT=""
OUTPUT_FOLDER="./docs-output"
PLATFORM="net472"
VERBOSE=false
CLEAN=false
TEST_MODE=false

# Parse command line arguments
while [[ $# -gt 0 ]]; do
    case $1 in
        --sdk-assemblies-root)
            SDK_ASSEMBLIES_ROOT="$2"
            shift 2
            ;;
        --output-folder)
            OUTPUT_FOLDER="$2"
            shift 2
            ;;
        --platform)
            PLATFORM="$2"
            shift 2
            ;;
        --verbose)
            VERBOSE=true
            shift
            ;;
        --clean)
            CLEAN=true
            shift
            ;;
        --test-mode)
            TEST_MODE=true
            shift
            ;;
        --help)
            echo "Usage: $0 [options]"
            echo "Options:"
            echo "  --sdk-assemblies-root PATH  Path to SDK assemblies"
            echo "  --output-folder PATH        Output folder for documentation"
            echo "  --platform PLATFORM        Platform to use (default: net472)"
            echo "  --verbose                   Enable verbose output"
            echo "  --clean                     Clean output folder before generation"
            echo "  --test-mode                 Run in test mode with limited services"
            echo "  --help                      Show this help message"
            exit 0
            ;;
        *)
            echo "Unknown option: $1"
            exit 1
            ;;
    esac
done

echo "Setting up DocFX documentation generation with Material theme..."

# Check if DocFX is installed
if command -v docfx &> /dev/null; then
    DOCFX_VERSION=$(docfx --version 2>/dev/null || echo "Unknown")
    echo "DocFX version: $DOCFX_VERSION"
else
    echo "DocFX not found. Installing DocFX..."
    dotnet tool install -g docfx
fi

# Check if Git is available (needed for Material theme setup)
if command -v git &> /dev/null; then
    GIT_VERSION=$(git --version)
    echo "Git version: $GIT_VERSION"
else
    echo "Warning: Git not found. Material theme setup may fail."
fi

# Build the documentation generator
echo "Building documentation generator..."
dotnet build AWSSDKDocGenerator.sln -c Release

if [ $? -ne 0 ]; then
    echo "Failed to build documentation generator"
    exit 1
fi

# Prepare command line arguments
ARGS=("-usedocfx")

if [ -n "$SDK_ASSEMBLIES_ROOT" ]; then
    ARGS+=("-sdkassembliesroot" "$SDK_ASSEMBLIES_ROOT")
fi

if [ -n "$OUTPUT_FOLDER" ]; then
    ARGS+=("-outputfolder" "$OUTPUT_FOLDER")
fi

if [ -n "$PLATFORM" ]; then
    ARGS+=("-platform" "$PLATFORM")
fi

if [ "$VERBOSE" = true ]; then
    ARGS+=("-verbose")
fi

if [ "$CLEAN" = true ]; then
    ARGS+=("-clean")
fi

if [ "$TEST_MODE" = true ]; then
    ARGS+=("-testmode")
fi

# Run the documentation generator with DocFX
echo "Running documentation generator with DocFX..."
echo "Command: SDKDocGenerator ${ARGS[*]}"

GENERATOR_PATH="SDKDocGenerator/bin/Release/SDKDocGenerator"
if [ -f "$GENERATOR_PATH" ]; then
    "$GENERATOR_PATH" "${ARGS[@]}"
else
    echo "Documentation generator not found at: $GENERATOR_PATH"
    echo "Please build the solution first."
    exit 1
fi

if [ $? -eq 0 ]; then
    echo "Documentation generation completed successfully!"
    if [ -n "$OUTPUT_FOLDER" ] && [ -d "$OUTPUT_FOLDER" ]; then
        echo "Documentation available at: $OUTPUT_FOLDER"
    fi
else
    echo "Documentation generation failed with exit code: $?"
fi
