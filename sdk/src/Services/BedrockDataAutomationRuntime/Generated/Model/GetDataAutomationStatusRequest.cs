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
 * Do not modify this file. This file is generated from the bedrock-data-automation-runtime-2024-06-13.normal.json service model.
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
namespace Amazon.BedrockDataAutomationRuntime.Model
{
    /// <summary>
    /// Container for the parameters to the GetDataAutomationStatus operation.
    /// API used to get data automation status.
    /// </summary>
    public partial class GetDataAutomationStatusRequest : AmazonBedrockDataAutomationRuntimeRequest
    {
        private string _invocationArn;

        /// <summary>
        /// Gets and sets the property InvocationArn. 
        /// <para>
        /// Invocation arn.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string InvocationArn
        {
            get { return this._invocationArn; }
            set { this._invocationArn = value; }
        }

        // Check to see if InvocationArn property is set
        internal bool IsSetInvocationArn()
        {
            return this._invocationArn != null;
        }

    }
}