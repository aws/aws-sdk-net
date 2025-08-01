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
using System.IO;

namespace Amazon.Runtime.Internal
{
    /// <summary>
    /// .NET Framework uses .NET Standard 2.0 packages like System.Text.Json and System.Memory.
    /// These dependencies can issues loading assemblies like System.Runtime.CompilerServices.Unsafe
    /// do to how .NET Framework binds assemblies. The default exception is an unhelpful System.IO.FileNotFoundException.
    /// This handler checks for that exception in the request pipeline and gives an error message
    /// with details about the binding issues.
    /// </summary>
    public class BindingRedirectCheckHandler : PipelineHandler
    {
        private const string ERROR_MSG = 
            "The AWS SDK for .NET uses .NET Standard 2.0 packages like System.Text.Json and " +
            "System.Memory. These packages force newer versions of other system runtime assemblies like " +
            "System.Runtime.CompilerServices.Unsafe to be loaded. Depending on applications other dependencies this " + 
            "can cause assembly binding issues. To mitigated the issue enable assembly redirects. " +
            "https://learn.microsoft.com/en-us/dotnet/framework/configure-apps/how-to-enable-and-disable-automatic-binding-redirection";

        /// <summary>
        /// Check FileNotFoundException for binding errors.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        public override void InvokeSync(IExecutionContext executionContext)
        {
            try
            {
                base.InvokeSync(executionContext);
            }
            catch(FileNotFoundException e)
            {
                if (IsBindingException(e))
                {
                    throw new AmazonClientException(ERROR_MSG, e);
                }

                throw;
            }
        }

        /// <summary>
        /// Check FileNotFoundException for binding errors.
        /// </summary>
        /// <typeparam name="T">The response type for the current request.</typeparam>
        /// <param name="executionContext">The execution context, it contains the
        /// request and response context.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        public override async System.Threading.Tasks.Task<T> InvokeAsync<T>(IExecutionContext executionContext)
        {
            try
            {
                return await base.InvokeAsync<T>(executionContext).ConfigureAwait(false);
            }
            catch (FileNotFoundException e)
            {
                if (IsBindingException(e))
                {
                    throw new AmazonClientException(ERROR_MSG, e);
                }

                throw;
            }
        }

        public static bool IsBindingException(FileNotFoundException e)
        {
            if (e.Message.Contains("Could not load file or assembly") && 
                e.Message.Contains("System.Runtime."))
            {
                return true;
            }

            return false;
        }
    }
}
