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
    /// Specifies the settings that the gateway uses to send a streamed target response to
    /// the interceptor in batches.
    /// </summary>
    public partial class ResponseStreamingConfiguration
    {
        /// <summary>
        /// Gets and sets the property MaxEventsPerInvocation. 
        /// <para>
        /// Specifies the maximum number of response events that the gateway sends to the interceptor
        /// in one invocation. The interceptor's output for the first batch determines the status
        /// code and headers of the response. The gateway ignores the status code and headers
        /// that the interceptor returns for later batches.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 8192)]
        public int? MaxEventsPerInvocation { get; set; }

        /// <summary>
        /// Checks to see if the MaxEventsPerInvocation property is set.
        /// </summary>
        internal bool IsSetMaxEventsPerInvocation() => this.MaxEventsPerInvocation.HasValue;
    }
}
