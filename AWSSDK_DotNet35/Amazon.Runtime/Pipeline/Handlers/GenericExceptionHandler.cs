/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using System;

namespace Amazon.Runtime.Internal
{
    public abstract class GenericExceptionHandler : PipelineHandler
    {
        public override void InvokeSync(IExecutionContext executionContext)
        {
            try
            {
                base.InvokeSync(executionContext);
            }
            catch(Exception exception)
            {
                HandleException(executionContext, exception);
                throw;
            }
        }

#if BCL45 || WIN_RT || WINDOWS_PHONE 
        public override async System.Threading.Tasks.Task<T> InvokeAsync<T>(IExecutionContext executionContext)
        {
            try
            {
                return await base.InvokeAsync<T>(executionContext).ConfigureAwait(false);
            }
            catch(Exception exception)
            {
                HandleException(executionContext, exception);
                throw;
            }
        }
#elif BCL && !BCL45
        protected override void InvokeAsyncCallback(IAsyncExecutionContext executionContext)
        {
            var exception = executionContext.ResponseContext.AsyncResult.Exception;
            if (executionContext.ResponseContext.AsyncResult.Exception != null)
            {
                HandleException(ExecutionContext.CreateFromAsyncContext(executionContext), exception);
            }
            // Call outer handler
            base.InvokeAsyncCallback(executionContext);
        }
#endif

        protected virtual void HandleException(IExecutionContext executionContext, Exception exception) { }
    }
}
