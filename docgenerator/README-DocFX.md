# DocFX Integration for AWS SDK .NET Documentation

This document describes the new DocFX integration that provides a modern, beautiful documentation experience using the Material theme.

## Overview

The AWS SDK .NET documentation generator has been enhanced to support DocFX with a Material Design theme, providing:

- **Modern UI**: Beautiful, responsive design with Material Design principles
- **Enhanced Search**: Powerful search functionality across all documentation
- **Better Navigation**: Improved table of contents and cross-references
- **Mobile Friendly**: Optimized for mobile and tablet viewing
- **Fast Loading**: Optimized performance and caching

## Requirements

Before using the DocFX integration, ensure you have:

1. **.NET 8.0 SDK** or later
2. **DocFX** - Install using: `dotnet tool install -g docfx`
3. **Git** - Required for downloading the Material theme
4. **Built AWS SDK assemblies** - The SDK must be built and assemblies available

## Quick Start

### Using the Setup Scripts

The easiest way to get started is using the provided setup scripts:

#### Windows (PowerShell)
```powershell
.\setup-docfx.ps1 -SDKAssembliesRoot "C:\path\to\sdk\assemblies" -Verbose
```

#### Linux/macOS (Bash)
```bash
./setup-docfx.sh --sdk-assemblies-root "/path/to/sdk/assemblies" --verbose
```

### Manual Usage

You can also run the documentation generator directly:

```bash
# Build the generator first
dotnet build SDKDocGenerator.sln -c Release

# Run with DocFX
./SDKDocGenerator/bin/Release/net8.0/SDKDocGenerator -usedocfx -sdkassembliesroot "/path/to/assemblies" -verbose
```

## Command Line Options

The DocFX integration adds the following new option:

- `-usedocfx` or `-docfx`: Enable DocFX generation with Material theme

All existing options are supported:

- `-sdkassembliesroot`: Path to SDK assemblies directory
- `-outputfolder`: Output directory for generated documentation
- `-platform`: Target platform (default: net472)
- `-services`: Comma-separated list of services to include
- `-verbose`: Enable verbose output
- `-clean`: Clean output folder before generation
- `-testmode`: Generate limited documentation for testing

## Configuration

### DocFX Configuration File

The `docfx.json` file controls DocFX behavior:

```json
{
  "metadata": [
    {
      "src": [
        {
          "files": ["**/*.dll"],
          "exclude": ["**/AWSSDK.Extensions.*.dll"],
          "src": "../sdk/src/Core/bin/Release/net472"
        }
      ],
      "dest": "api"
    }
  ],
  "build": {
    "template": ["default", "modern", "templates/material"],
    "globalMetadata": {
      "_appTitle": "AWS SDK for .NET API Reference",
      "_enableSearch": true
    }
  }
}
```

### Material Theme Customization

The Material theme can be customized by editing files in `templates/material/`:

- `public/main.css`: Main stylesheet for theme customization
- `partials/`: Template partials for layout modifications
- `styles/`: Additional styling options

Example color customization:
```css
[data-bs-theme='light'] nav.navbar {
  background-color: var(--bs-primary-bg-subtle);
}
```

## Architecture

### DocFX Integration Components

1. **DocFxIntegration.cs**: Main integration class handling DocFX operations
2. **Updated SdkDocGenerator.cs**: Enhanced main generator with DocFX support
3. **Configuration Files**: DocFX configuration and theme setup
4. **Setup Scripts**: Automated setup and execution scripts

### Generation Process

When using DocFX mode (`-usedocfx`), the generator:

1. **Setup Phase**:
   - Downloads Material theme (if not present)
   - Updates DocFX configuration with current options
   
2. **Metadata Generation**:
   - Analyzes SDK assemblies using DocFX metadata generation
   - Creates YAML files with API documentation structure
   
3. **Build Phase**:
   - Builds documentation using DocFX with Material theme
   - Generates search index
   - Outputs final documentation site

### Legacy vs DocFX Mode

| Feature | Legacy Mode | DocFX Mode |
|---------|-------------|------------|
| Output Format | Custom HTML | Static site with modern UI |
| Theme | Custom CSS | Material Design |
| Search | Basic | Advanced with indexing |
| Mobile Support | Limited | Fully responsive |
| Performance | Slower | Optimized |
| Maintenance | Custom code | Standard DocFX |

## Troubleshooting

### Common Issues

1. **DocFX not found**:
   ```bash
   dotnet tool install -g docfx
   ```

2. **Git not available**:
   - Install Git to enable Material theme download
   - Or manually download theme from: https://github.com/ovasquez/docfx-material

3. **Assembly not found errors**:
   - Ensure SDK is built: `dotnet build` in SDK root
   - Verify assemblies path with `-sdkassembliesroot`

4. **Permission errors**:
   - Ensure output directory is writable
   - Run with appropriate permissions

### Debugging

Enable verbose output for detailed information:
```bash
./SDKDocGenerator -usedocfx -verbose -testmode
```

Check DocFX logs in the output directory for build-specific issues.

## Migration from Legacy Generator

To migrate from the legacy HTML generator:

1. **Install DocFX**: `dotnet tool install -g docfx`
2. **Add DocFX flag**: Include `-usedocfx` in your build commands
3. **Update scripts**: Modify existing build scripts to use new option
4. **Test output**: Verify documentation generates correctly
5. **Customize theme**: Adjust Material theme as needed

## Examples

### Basic Generation
```bash
# Generate docs for all services
./SDKDocGenerator -usedocfx -sdkassembliesroot "/path/to/assemblies"
```

### Test Mode
```bash
# Generate limited docs for testing
./SDKDocGenerator -usedocfx -testmode -verbose
```

### Specific Services
```bash
# Generate docs for specific services only
./SDKDocGenerator -usedocfx -services "S3,DynamoDBv2,EC2" -verbose
```

### Custom Output
```bash
# Generate to custom location
./SDKDocGenerator -usedocfx -outputfolder "/custom/output/path" -clean
```

## Contributing

When contributing to the DocFX integration:

1. **Test both modes**: Ensure legacy generator still works
2. **Update documentation**: Keep this README current
3. **Test themes**: Verify Material theme customizations
4. **Performance**: Monitor generation time and output size

## Support

For issues specific to:
- **DocFX**: See [DocFX documentation](https://dotnet.github.io/docfx/)
- **Material Theme**: See [DocFX Material repository](https://github.com/ovasquez/docfx-material)
- **AWS SDK**: Use standard AWS SDK support channels

