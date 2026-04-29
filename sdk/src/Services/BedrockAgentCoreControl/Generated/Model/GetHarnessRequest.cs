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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
    /// Container for the parameters to the GetHarness operation.
    /// Operation to get a single Harness.
    /// </summary>
    public partial class GetHarnessRequest : AmazonBedrockAgentCoreControlRequest
    {
        private string _harnessId;

        /// <summary>
        /// Gets and sets the property HarnessId. 
        /// <para>
        /// The ID of the harness to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string HarnessId
        {
            get { return this._harnessId; }
            set { this._harnessId = value; }
        }

        // Check to see if HarnessId property is set
        internal bool IsSetHarnessId()
        {
            return this._harnessId != null;
        }

    }
}