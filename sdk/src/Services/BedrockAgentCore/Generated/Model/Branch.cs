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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// Contains information about a branch in an AgentCore Memory resource. Branches allow
    /// for organizing events into different conversation threads or paths.
    /// </summary>
    public partial class Branch
    {
        private string _name;
        private string _rootEventId;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the branch.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RootEventId. 
        /// <para>
        /// The identifier of the root event for this branch.
        /// </para>
        /// </summary>
        public string RootEventId
        {
            get { return this._rootEventId; }
            set { this._rootEventId = value; }
        }

        // Check to see if RootEventId property is set
        internal bool IsSetRootEventId()
        {
            return this._rootEventId != null;
        }

    }
}