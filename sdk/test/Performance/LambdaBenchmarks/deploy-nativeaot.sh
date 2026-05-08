#!/bin/bash
# Deploy NativeAOT Lambda cold start benchmark functions
# Usage: ./deploy-nativeaot.sh [region] [arch-suffix]
# Example (x64 instance):  ./deploy-nativeaot.sh us-east-1 x64
# Example (arm64 instance): ./deploy-nativeaot.sh us-east-1 arm64

set -e

REGION="${1:-us-east-1}"
ARCH_SUFFIX="${2:-x64}"
PREFIX="dotnet-perf"
ROLE_ARN=$(aws iam get-role --role-name dotnet-perf-lambda-coldstart-role --query 'Role.Arn' --output text 2>/dev/null)

if [ "$ARCH_SUFFIX" = "x64" ]; then
    RUNTIME_ID="linux-x64"
    LAMBDA_ARCH="x86_64"
elif [ "$ARCH_SUFFIX" = "arm64" ]; then
    RUNTIME_ID="linux-arm64"
    LAMBDA_ARCH="arm64"
else
    echo "ERROR: arch-suffix must be 'x64' or 'arm64'"
    exit 1
fi

echo "========================================"
echo "Deploying NativeAOT Lambda Cold Start Functions"
echo "========================================"
echo "  Region:    $REGION"
echo "  Arch:      $LAMBDA_ARCH ($ARCH_SUFFIX)"
echo "  Runtime:   provided.al2023"
echo "  Role:      $ROLE_ARN"
echo ""

TMPDIR=$(mktemp -d)
echo "Build directory: $TMPDIR"

# Function to build, package, and deploy a NativeAOT Lambda
deploy_service() {
    local SVC_NAME=$1
    local PROJECT_NAME=$2
    local SERVICE_PACKAGE=$3
    local FUNCTION_CS=$4
    local FUNC_NAME="${PREFIX}-${SVC_NAME}-coldstart-aot-${ARCH_SUFFIX}"

    echo "--- Building $SVC_NAME ($FUNC_NAME) ---"

    local SVC_DIR="$TMPDIR/$SVC_NAME"
    mkdir -p "$SVC_DIR"

    # Write csproj
    cat > "$SVC_DIR/${PROJECT_NAME}.csproj" << 'CSPROJ_EOF'
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <TargetFramework>net8.0</TargetFramework>
    <GenerateRuntimeConfigurationFiles>true</GenerateRuntimeConfigurationFiles>
    <AWSProjectType>Lambda</AWSProjectType>
    <OutputType>Exe</OutputType>
    <PublishAot>true</PublishAot>
    <StripSymbols>true</StripSymbols>
  </PropertyGroup>
  <ItemGroup>
    <PackageReference Include="Amazon.Lambda.Core" Version="2.*" />
    <PackageReference Include="Amazon.Lambda.Serialization.SystemTextJson" Version="2.*" />
    <PackageReference Include="Amazon.Lambda.RuntimeSupport" Version="1.*" />
CSPROJ_EOF
    echo "    <PackageReference Include=\"$SERVICE_PACKAGE\" Version=\"4.*\" />" >> "$SVC_DIR/${PROJECT_NAME}.csproj"
    cat >> "$SVC_DIR/${PROJECT_NAME}.csproj" << 'CSPROJ_EOF2'
  </ItemGroup>
</Project>
CSPROJ_EOF2

    # Write Function.cs
    echo "$FUNCTION_CS" > "$SVC_DIR/Function.cs"

    # Build
    echo "  Building for $LAMBDA_ARCH (NativeAOT)..."
    dotnet publish "$SVC_DIR" -c Release -r "$RUNTIME_ID" --self-contained true -o "$SVC_DIR/publish" 2>&1 | tail -5

    # Rename output to bootstrap
    local BOOTSTRAP="$SVC_DIR/publish/bootstrap"
    if [ ! -f "$BOOTSTRAP" ]; then
        # Find the executable (it won't have .dll extension for NativeAOT)
        local EXE=$(find "$SVC_DIR/publish" -maxdepth 1 -name "$PROJECT_NAME" -type f | head -1)
        if [ -n "$EXE" ]; then
            cp "$EXE" "$BOOTSTRAP"
            chmod +x "$BOOTSTRAP"
        else
            echo "  ERROR: Could not find bootstrap binary"
            return 1
        fi
    fi
    chmod +x "$BOOTSTRAP"

    # Package
    echo "  Packaging $FUNC_NAME..."
    local ZIP_PATH="$TMPDIR/${FUNC_NAME}.zip"
    (cd "$SVC_DIR/publish" && zip -q -r "$ZIP_PATH" .)

    # Deploy
    echo "  Deploying $FUNC_NAME..."
    if aws lambda get-function --function-name "$FUNC_NAME" --region "$REGION" > /dev/null 2>&1; then
        aws lambda update-function-code --function-name "$FUNC_NAME" --zip-file "fileb://$ZIP_PATH" --region "$REGION" --no-cli-pager > /dev/null
        aws lambda wait function-updated --function-name "$FUNC_NAME" --region "$REGION"
        aws lambda update-function-configuration --function-name "$FUNC_NAME" --handler bootstrap --runtime provided.al2023 --memory-size 512 --timeout 30 --architectures "$LAMBDA_ARCH" --region "$REGION" --no-cli-pager > /dev/null
    else
        aws lambda create-function --function-name "$FUNC_NAME" --runtime provided.al2023 --handler bootstrap --role "$ROLE_ARN" --zip-file "fileb://$ZIP_PATH" --memory-size 512 --timeout 30 --architectures "$LAMBDA_ARCH" --region "$REGION" --no-cli-pager > /dev/null
    fi
    aws lambda wait function-active-v2 --function-name "$FUNC_NAME" --region "$REGION"
    echo "  ✓ $FUNC_NAME deployed"

    # Show package size
    local SIZE=$(stat -c%s "$ZIP_PATH" 2>/dev/null || stat -f%z "$ZIP_PATH" 2>/dev/null)
    echo "  Package size: $((SIZE / 1024)) KB"
}

# --- STS ---
STS_CS='using System.Threading.Tasks;
using Amazon.Lambda.Core;
using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace ColdStartBenchmark;

public class Function
{
    public async Task<string> FunctionHandler(object input, ILambdaContext context)
    {
        var client = new AmazonSecurityTokenServiceClient();
        var response = await client.GetCallerIdentityAsync(new GetCallerIdentityRequest());
        return response.Arn;
    }
}

public class Program
{
    public static async Task Main(string[] args)
    {
        var handler = new ColdStartBenchmark.Function();
        await Amazon.Lambda.RuntimeSupport.LambdaBootstrapBuilder
            .Create<object, string>(handler.FunctionHandler, new Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer())
            .Build()
            .RunAsync();
    }
}'
deploy_service "sts" "StsColdStart" "AWSSDK.SecurityToken" "$STS_CS"

# --- S3 ---
S3_CS='using System.Threading.Tasks;
using Amazon.Lambda.Core;
using Amazon.S3;
using Amazon.S3.Model;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace ColdStartBenchmark;

public class Function
{
    public async Task<string> FunctionHandler(object input, ILambdaContext context)
    {
        var client = new AmazonS3Client();
        var response = await client.ListBucketsAsync(new ListBucketsRequest());
        return $"Found {response.Buckets.Count} buckets";
    }
}

public class Program
{
    public static async Task Main(string[] args)
    {
        var handler = new ColdStartBenchmark.Function();
        await Amazon.Lambda.RuntimeSupport.LambdaBootstrapBuilder
            .Create<object, string>(handler.FunctionHandler, new Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer())
            .Build()
            .RunAsync();
    }
}'
deploy_service "s3" "S3ColdStart" "AWSSDK.S3" "$S3_CS"

# --- EC2 ---
EC2_CS='using System.Threading.Tasks;
using Amazon.Lambda.Core;
using Amazon.EC2;
using Amazon.EC2.Model;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace ColdStartBenchmark;

public class Function
{
    public async Task<string> FunctionHandler(object input, ILambdaContext context)
    {
        var client = new AmazonEC2Client();
        var response = await client.DescribeRegionsAsync(new DescribeRegionsRequest());
        return $"Found {response.Regions.Count} regions";
    }
}

public class Program
{
    public static async Task Main(string[] args)
    {
        var handler = new ColdStartBenchmark.Function();
        await Amazon.Lambda.RuntimeSupport.LambdaBootstrapBuilder
            .Create<object, string>(handler.FunctionHandler, new Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer())
            .Build()
            .RunAsync();
    }
}'
deploy_service "ec2" "Ec2ColdStart" "AWSSDK.EC2" "$EC2_CS"

# Cleanup
echo ""
echo "Cleaning up build directory..."
rm -rf "$TMPDIR"

echo ""
echo "========================================"
echo "All 3 NativeAOT functions ($ARCH_SUFFIX) deployed!"
echo "========================================"
echo ""
echo "Next: Run benchmarks from any machine with AWS creds:"
echo "  dotnet run -c Release --project sdk/test/Performance/LambdaBenchmarks/LambdaBenchmarksRunner/LambdaBenchmarksRunner.csproj -- coldstart-initduration --iterations 100 --region $REGION --mode-suffix -aot"
