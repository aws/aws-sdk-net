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

namespace Amazon.AgentRegistryControl.Model
{
    /// <summary>
    /// The source details for a registry record that was auto-detected from an Amazon Bedrock
    /// AgentCore Runtime resource.
    /// </summary>
    public partial class AgentCoreRuntimeSourceDetails
    {
        /// <summary>
        /// Gets and sets the property AuthorizerConfiguration.
        /// </summary>
        public AuthorizerConfiguration AuthorizerConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizerConfiguration property is set.
        /// </summary>
        internal bool IsSetAuthorizerConfiguration() => this.AuthorizerConfiguration != null;

        /// <summary>
        /// Gets and sets the property ProtocolConfiguration. 
        /// <para>
        /// The protocol configuration of the AgentCore Runtime resource that the registry record
        /// was detected from.
        /// </para>
        /// </summary>
        public AgentCoreRuntimeProtocolConfiguration ProtocolConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ProtocolConfiguration property is set.
        /// </summary>
        internal bool IsSetProtocolConfiguration() => this.ProtocolConfiguration != null;

        /// <summary>
        /// Gets and sets the property WorkloadIdentityDetails. 
        /// <para>
        /// The workload identity details for the AgentCore Runtime resource. Present when the
        /// runtime has a workload identity configured.
        /// </para>
        /// </summary>
        public WorkloadIdentityDetails WorkloadIdentityDetails { get; set; }

        /// <summary>
        /// Checks to see if the WorkloadIdentityDetails property is set.
        /// </summary>
        internal bool IsSetWorkloadIdentityDetails() => this.WorkloadIdentityDetails != null;
    }
}
