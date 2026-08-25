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
 * Do not modify this file. This file is generated from the devops-agent-2026-01-01.normal.json service model.
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
namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Tool-invocation pattern primitive used to express both an agent-requested approval
    /// and a finalized approval. The primitive is uniform across AWS and third-party tools:
    /// a tool identifier plus a map of argument pins that narrow which invocations the pattern
    /// matches.
    /// </summary>
    public partial class ApprovalPattern
    {
        private Dictionary<string, string> _argumentPins = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _tool;

        /// <summary>
        /// Gets and sets the property ArgumentPins. 
        /// <para>
        /// Argument constraints that narrow which tool invocations the pattern matches. For AWS
        /// tools, the map must include `operation` (the IAM action, e.g. `ec2:AuthorizeSecurityGroupIngress`)
        /// and `resource_arn` (the resource ARN or ARN glob); additional narrowing arguments
        /// go in further pin keys. The same `{tool, argumentPins}` shape is used uniformly for
        /// AWS and third-party tools, with tool-specific keys for third-party tools. Requests
        /// whose argument pins are collectively too large are rejected with a ValidationException.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=20)]
        public Dictionary<string, string> ArgumentPins
        {
            get { return this._argumentPins; }
            set { this._argumentPins = value; }
        }

        // Check to see if ArgumentPins property is set
        internal bool IsSetArgumentPins()
        {
            return this._argumentPins != null && (this._argumentPins.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tool. 
        /// <para>
        /// Identifier of the tool the pattern applies to (e.g. `use_aws` for AWS actions, or
        /// a third-party tool name).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string Tool
        {
            get { return this._tool; }
            set { this._tool = value; }
        }

        // Check to see if Tool property is set
        internal bool IsSetTool()
        {
            return this._tool != null;
        }

    }
}