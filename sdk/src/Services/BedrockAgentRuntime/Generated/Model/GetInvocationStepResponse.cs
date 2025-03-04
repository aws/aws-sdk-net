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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
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
namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// This is the response object from the GetInvocationStep operation.
    /// </summary>
    public partial class GetInvocationStepResponse : AmazonWebServiceResponse
    {
        private InvocationStep _invocationStep;

        /// <summary>
        /// Gets and sets the property InvocationStep. 
        /// <para>
        /// The complete details of the requested invocation step.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InvocationStep InvocationStep
        {
            get { return this._invocationStep; }
            set { this._invocationStep = value; }
        }

        // Check to see if InvocationStep property is set
        internal bool IsSetInvocationStep()
        {
            return this._invocationStep != null;
        }

    }
}