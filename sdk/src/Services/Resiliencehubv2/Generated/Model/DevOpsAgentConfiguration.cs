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
 * Do not modify this file. This file is generated from the resiliencehubv2-2026-02-17.normal.json service model.
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
namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// The AWS DevOps Agent (DevOps Agent) integration configuration that you supply when
    /// creating or updating a service. Connecting a service to a DevOps Agent Agent Space
    /// lets DevOps Agent investigate the service's resilience test runs and attach its analysis
    /// to the results. Include this block with an Agent Space Amazon Resource Name (ARN)
    /// to connect or reconnect the service to an Agent Space. Include it without an Agent
    /// Space ARN to disconnect the service. Omit it to leave the existing linkage unchanged.
    /// </summary>
    public partial class DevOpsAgentConfiguration
    {
        private string _agentSpaceArn;

        /// <summary>
        /// Gets and sets the property AgentSpaceArn. 
        /// <para>
        /// The ARN of the DevOps Agent Agent Space to link to this service.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string AgentSpaceArn
        {
            get { return this._agentSpaceArn; }
            set { this._agentSpaceArn = value; }
        }

        // Check to see if AgentSpaceArn property is set
        internal bool IsSetAgentSpaceArn()
        {
            return this._agentSpaceArn != null;
        }

    }
}