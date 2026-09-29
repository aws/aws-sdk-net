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

namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateOperatorAppIdpConfig operation. Update the
    /// external Identity Provider configuration for the Operator App
    /// </summary>
    public partial class UpdateOperatorAppIdpConfigRequest : AmazonDevOpsAgentRequest
    {
        /// <summary>
        /// Gets and sets the property AgentSpaceId. 
        /// <para>
        /// The unique identifier of the AgentSpace
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AgentSpaceId { get; set; }

        /// <summary>
        /// Checks to see if the AgentSpaceId property is set.
        /// </summary>
        internal bool IsSetAgentSpaceId() => this.AgentSpaceId != null;

        /// <summary>
        /// Gets and sets the property IdpClientSecret. 
        /// <para>
        /// The OIDC client secret for the IdP application
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1024)]
        public string IdpClientSecret { get; set; }

        /// <summary>
        /// Checks to see if the IdpClientSecret property is set.
        /// </summary>
        internal bool IsSetIdpClientSecret() => this.IdpClientSecret != null;
    }
}
