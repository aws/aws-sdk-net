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
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.Runtime.Internal
{
    /// <summary>
    /// This handler provides an OnError action that can be used as hook for
    /// external code to handle exceptions in the runtime pipeline.
    /// </summary>
    public class ErrorCallbackHandler : GenericExceptionHandler
    {
        /// <summary>
        /// Action to execute if an exception occurs during the 
        /// execution of any underlying handlers.
        /// </summary>
        public Action<IExecutionContext,Exception> OnError { get; set; }

        /// <summary>
        /// Executes the OnError action if an exception occurs during the 
        /// execution of any underlying handlers.
        /// </summary>
        /// <param name="executionContext"></param>
        /// <param name="exception"></param>
        protected override void HandleException(IExecutionContext executionContext, Exception exception)
        {
            OnError(executionContext, exception);
        }
    }
}
