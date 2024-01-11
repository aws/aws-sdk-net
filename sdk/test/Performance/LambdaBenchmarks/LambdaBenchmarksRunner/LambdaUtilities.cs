/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using System.Text;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Amazon.Lambda;
using Amazon.Lambda.Model;

namespace LambdaBenchmarksRunner
{
    public class LambdaUtilities
    {
        public static async Task DeployFunction(IAmazonLambda lambdaClient, string functionName, string functionHandler, int memory, string architecture, string runtime, int timeOut = 30)
        {
            var dotnetCLI = FindExecutableInPath("dotnet.exe");
            var arguments = $"lambda deploy-function --configuration Release --function-name {functionName}  --function-handler {functionHandler} " +
                $"--function-memory-size {memory} --function-architecture {architecture} --function-runtime {runtime} " +
                $"--function-timeout {timeOut} --function-role LambdaBenchmarksTestRole";

            var psi = new ProcessStartInfo
            {
                FileName = dotnetCLI,
                Arguments = arguments,
                WorkingDirectory = FindLambdaBenchmarksDirectory()
            };

            using var proc = new Process();
            proc.StartInfo = psi;
            proc.Start();

            proc.WaitForExit();

            await WaitTillFunctionAvailableAsync(lambdaClient, functionName);
            if (proc.ExitCode != 0)
            {
                throw new Exception($"Fail to deploy Lambda function {functionName}");
            }
        }

        public static async Task<InvokeResponse> ExecuteFunction(IAmazonLambda lambdaClient, string functionName, string payload = null)
        {
            var invokeRequest = new InvokeRequest
            {
                FunctionName = functionName,
            };

            if(!string.IsNullOrEmpty(payload)) 
                invokeRequest.Payload = payload;

            var response = await lambdaClient.InvokeAsync(invokeRequest);
            if(response.FunctionError != null)
            {
                var functionErrorResponse = Encoding.ASCII.GetString(response.Payload.ToArray());
                functionErrorResponse = $"Executing: {functionName} with payload :{payload} throw exception: \n{functionErrorResponse}";

                throw new AmazonLambdaException(functionErrorResponse);
            }

            return response;
        }


        public static async Task<UpdateFunctionConfigurationResponse> UpdateFunctionTimeout(IAmazonLambda lambdaClient, string functionName, int timeout)
        {
            var response = await lambdaClient.UpdateFunctionConfigurationAsync(new UpdateFunctionConfigurationRequest
            {
                FunctionName = functionName,
                Timeout = timeout,

            });
            await WaitTillFunctionAvailableAsync(lambdaClient, functionName);

            return response;
        }

        private static async Task WaitTillFunctionAvailableAsync(IAmazonLambda lambdaClient, string functionName)
        {
            const int POLL_INTERVAL = 3000;
            const int MAX_TIMEOUT_MINUTES = 20;
            var request = new GetFunctionConfigurationRequest
            {
                FunctionName = functionName
            };

            var timeout = DateTime.UtcNow.AddMinutes(MAX_TIMEOUT_MINUTES);
            do
            {
                var response = await lambdaClient.GetFunctionConfigurationAsync(request);
                if (response.LastUpdateStatus != LastUpdateStatus.InProgress && response.State != State.Pending)
                {
                    return;
                }
                await Task.Delay(POLL_INTERVAL);

            } while (DateTime.UtcNow < timeout);

            throw new Exception($"Timeout waiting for function {functionName} to become available");
        }

        private static string FindLambdaBenchmarksDirectory()
        {
            const string LAMBDA_BENCHMARKS_DIRECTORY = "LambdaBenchmarks";

            var directory = Directory.GetParent(Assembly.GetExecutingAssembly().Location);

            do
            {
                if (directory.GetDirectories().Any(x => x.Name == LAMBDA_BENCHMARKS_DIRECTORY))
                {
                    return Path.Join(directory.FullName, LAMBDA_BENCHMARKS_DIRECTORY);
                }

                directory = directory.Parent;

            } while (directory != null);

            throw new Exception("Failed to find LambdaBenchmarks directory");
        }

        private static string FindExecutableInPath(string command)
        {
            if (File.Exists(command))
                return Path.GetFullPath(command);

            if (string.Equals(command, "dotnet.exe"))
            {
                if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    command = "dotnet";
                }

                var mainModule = Process.GetCurrentProcess().MainModule;
                if (!string.IsNullOrEmpty(mainModule?.FileName)
                    && Path.GetFileName(mainModule.FileName).Equals(command, StringComparison.OrdinalIgnoreCase))
                {
                    return mainModule.FileName;
                }
            }

            Func<string, string> quoteRemover = x =>
            {
                if (x.StartsWith("\""))
                    x = x.Substring(1);
                if (x.EndsWith("\""))
                    x = x.Substring(0, x.Length - 1);
                return x;
            };

            var envPath = System.Environment.GetEnvironmentVariable("PATH");
            if (envPath != null)
            {
                foreach (var path in envPath.Split(Path.PathSeparator))
                {
                    try
                    {
                        var fullPath = Path.Combine(quoteRemover(path), command);
                        if (File.Exists(fullPath))
                            return fullPath;
                    }
                    catch (Exception)
                    {
                        // Catch exceptions and continue if there are invalid characters in the user's path.
                    }
                }
            }

            return null;
        }
    }
}
