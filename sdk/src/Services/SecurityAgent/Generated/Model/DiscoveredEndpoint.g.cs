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

namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// Represents an endpoint discovered during a pentest job.
    /// </summary>
    public partial class DiscoveredEndpoint
    {
        /// <summary>
        /// Gets and sets the property AgentSpaceId. 
        /// <para>
        /// The unique identifier of the agent space associated with the discovered endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AgentSpaceId { get; set; }

        /// <summary>
        /// Checks to see if the AgentSpaceId property is set.
        /// </summary>
        internal bool IsSetAgentSpaceId() => this.AgentSpaceId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the discovered endpoint.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Evidence. 
        /// <para>
        /// The evidence that led to the discovery of the endpoint.
        /// </para>
        /// </summary>
        public string Evidence { get; set; }

        /// <summary>
        /// Checks to see if the Evidence property is set.
        /// </summary>
        internal bool IsSetEvidence() => this.Evidence != null;

        /// <summary>
        /// Gets and sets the property Operation. 
        /// <para>
        /// The HTTP operation associated with the discovered endpoint.
        /// </para>
        /// </summary>
        public string Operation { get; set; }

        /// <summary>
        /// Checks to see if the Operation property is set.
        /// </summary>
        internal bool IsSetOperation() => this.Operation != null;

        /// <summary>
        /// Gets and sets the property PentestJobId. 
        /// <para>
        /// The unique identifier of the pentest job that discovered the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PentestJobId { get; set; }

        /// <summary>
        /// Checks to see if the PentestJobId property is set.
        /// </summary>
        internal bool IsSetPentestJobId() => this.PentestJobId != null;

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        /// The unique identifier of the task that discovered the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TaskId { get; set; }

        /// <summary>
        /// Checks to see if the TaskId property is set.
        /// </summary>
        internal bool IsSetTaskId() => this.TaskId != null;

        /// <summary>
        /// Gets and sets the property Uri. 
        /// <para>
        /// The URI of the discovered endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Uri { get; set; }

        /// <summary>
        /// Checks to see if the Uri property is set.
        /// </summary>
        internal bool IsSetUri() => this.Uri != null;
    }
}
