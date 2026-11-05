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

namespace Amazon.ApplicationDiscoveryService.Model
{
    /// <summary>
    /// An object representing the agent or data collector to be deleted along with the optional
    /// configurations for error handling.
    /// </summary>
    public partial class DeleteAgent
    {
        /// <summary>
        /// Gets and sets the property AgentId. 
        /// <para>
        ///  The ID of the agent or data collector to delete. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 20)]
        public string AgentId { get; set; }

        /// <summary>
        /// Checks to see if the AgentId property is set.
        /// </summary>
        internal bool IsSetAgentId() => this.AgentId != null;

        /// <summary>
        /// Gets and sets the property Force. 
        /// <para>
        ///  Optional flag used to force delete an agent or data collector. It is needed to delete
        /// any agent in HEALTHY/UNHEALTHY/RUNNING status. Note that deleting an agent that is
        /// actively reporting health causes it to be re-registered with a different agent ID
        /// after data collector re-connects with Amazon Web Services. 
        /// </para>
        /// </summary>
        public bool? Force { get; set; }

        /// <summary>
        /// Checks to see if the Force property is set.
        /// </summary>
        internal bool IsSetForce() => this.Force.HasValue;
    }
}
