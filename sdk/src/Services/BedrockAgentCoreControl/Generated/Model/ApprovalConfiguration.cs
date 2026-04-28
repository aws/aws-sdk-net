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
    /// Configuration for the registry record approval workflow. Controls whether records
    /// added to the registry require explicit approval before becoming active.
    /// </summary>
    public partial class ApprovalConfiguration
    {
        private bool? _autoApproval;

        /// <summary>
        /// Gets and sets the property AutoApproval. 
        /// <para>
        /// Whether registry records are auto-approved. When set to <c>true</c>, records are automatically
        /// approved upon creation. When set to <c>false</c> (the default), records require explicit
        /// approval for security purposes.
        /// </para>
        /// </summary>
        public bool? AutoApproval
        {
            get { return this._autoApproval; }
            set { this._autoApproval = value; }
        }

        // Check to see if AutoApproval property is set
        internal bool IsSetAutoApproval()
        {
            return this._autoApproval.HasValue; 
        }

    }
}