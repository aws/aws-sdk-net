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
    /// <summary>
    /// A pipeline handler which provides hooks to run
    /// external code in the pre-invoke and post-invoke phases.
    /// </summary>
    public class CallbackHandler : GenericHandler
    {
        /// <summary>
        /// Action to execute on the pre invoke phase.
        /// </summary>
        public Action<IExecutionContext> OnPreInvoke { get; set; }

        /// <summary>
        /// Action to execute on the post invoke phase.
        /// </summary>
        public Action<IExecutionContext> OnPostInvoke { get; set; }

        /// <summary>
        /// Executes the OnPreInvoke action as part of pre-invoke.
        /// </summary>
        /// <param name="executionContext">The execution context, it contains the
        /// request and response context.</param>
        protected override void PreInvoke(IExecutionContext executionContext)
        {
            RaiseOnPreInvoke(executionContext);
        }

        /// <summary>
        /// Executes the OnPreInvoke action as part of post-invoke.
        /// </summary>
        /// <param name="executionContext">The execution context, it contains the
        /// request and response context.</param>
        protected override void PostInvoke(IExecutionContext executionContext)
        {
            RaiseOnPostInvoke(executionContext);
        }

        private void RaiseOnPreInvoke(IExecutionContext context)
        {
            if (this.OnPreInvoke != null)
                this.OnPreInvoke(context);
        }

        private void RaiseOnPostInvoke(IExecutionContext context)
        {
            if (this.OnPostInvoke != null)
                this.OnPostInvoke(context);
        }
    }
}
