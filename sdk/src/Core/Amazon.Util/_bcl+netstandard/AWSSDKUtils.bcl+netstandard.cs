/*******************************************************************************
 *  Copyright 2008-2019 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 */

using System.Diagnostics;
#if AWS_ASYNC_API
using System.Threading.Tasks;
#endif
using Amazon.Runtime.Internal.Util;
using System.Diagnostics.CodeAnalysis;
using System.Threading;

namespace Amazon.Util
{
    public static partial class AWSSDKUtils
    {
        #region Public Methods and Properties
        /// <summary>
        /// Runs a process with the below input parameters.
        /// </summary>
        /// <param name="processStartInfo"></param>
        /// <returns></returns>
        [SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands")]
        public static ProcessExecutionResult RunProcess(ProcessStartInfo processStartInfo)
        {
            using (var process = new Process
            {
                StartInfo = processStartInfo
            })
            {
                var logger = Logger.GetLogger(typeof(AWSSDKUtils));
                logger.InfoFormat("Starting a process with the following ProcessInfo: UseShellExecute - {0} RedirectStandardError - {1}, RedirectStandardOutput - {2}, CreateNoWindow - {3}",  
                    processStartInfo.UseShellExecute, processStartInfo.RedirectStandardError, processStartInfo.RedirectStandardOutput, processStartInfo.CreateNoWindow);
                process.Start();
                logger.InfoFormat("Process started");
                string standardOutput = null;
                var thread = new Thread(() => standardOutput = process.StandardOutput.ReadToEnd());
                thread.Start();
                var standardError = process.StandardError.ReadToEnd();
                thread.Join();
                process.WaitForExit();                

                return new ProcessExecutionResult
                {
                    ExitCode = process.ExitCode,
                    StandardError = standardError,
                    StandardOutput = standardOutput
                };                
            }
        }
#if AWS_ASYNC_API
        [SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands")]
        public static async Task<ProcessExecutionResult> RunProcessAsync(ProcessStartInfo processStartInfo)
        {
            var logger = Logger.GetLogger(typeof(AWSSDKUtils));
            using (var process = new Process
            {
                StartInfo = processStartInfo,
                EnableRaisingEvents = true
            })
            {
                var tcs = new TaskCompletionSource<object>();
                process.Exited += (s, ea) => tcs.SetResult(null);
                logger.InfoFormat("Starting a process with the following ProcessInfo: UseShellExecute - {0} RedirectStandardError - {1}, RedirectStandardOutput - {2}, CreateNoWindow - {3}",  
                    processStartInfo.UseShellExecute, processStartInfo.RedirectStandardError, processStartInfo.RedirectStandardOutput, processStartInfo.CreateNoWindow);                
                process.Start();
                logger.InfoFormat("Process started");

                var standardErrorTask = process.StandardError.ReadToEndAsync();
                var standardOutputTask = process.StandardOutput.ReadToEndAsync();

                await Task.WhenAll(tcs.Task, standardErrorTask, standardOutputTask);

                return new ProcessExecutionResult
                {
                    ExitCode = process.ExitCode,
                    StandardError = standardErrorTask.Result,
                    StandardOutput = standardOutputTask.Result
                };
            }

        }
#endif
        #endregion
    }
}
