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

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// The action that a lifecycle hook runs. Specify exactly one member. Currently, <c>httpPost</c>
    /// is the only supported action.
    /// </summary>
    public partial class LifecycleHookAction
    {
        /// <summary>
        /// Gets and sets the property HttpPost. 
        /// <para>
        /// Sends an HTTP <c>POST</c> request to your agent's container on the specified port
        /// and path to run the hook. The hook succeeds if your container returns a <c>2xx</c>
        /// response. The hook fails if your container returns any other response or doesn't respond
        /// before the hook times out.
        /// </para>
        /// </summary>
        public HttpPostLifecycleHookAction HttpPost { get; set; }

        /// <summary>
        /// Checks to see if the HttpPost property is set.
        /// </summary>
        internal bool IsSetHttpPost() => this.HttpPost != null;
    }
}
