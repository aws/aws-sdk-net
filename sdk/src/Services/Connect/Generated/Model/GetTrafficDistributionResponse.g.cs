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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// This is the response object from the GetTrafficDistribution operation.
    /// </summary>
    public partial class GetTrafficDistributionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AgentConfig. 
        /// <para>
        /// The distribution of agents between the instance and its replica(s).
        /// </para>
        /// </summary>
        public AgentConfig AgentConfig { get; set; }

        /// <summary>
        /// Checks to see if the AgentConfig property is set.
        /// </summary>
        internal bool IsSetAgentConfig() => this.AgentConfig != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the traffic distribution group.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the traffic distribution group. This can be the ID or the ARN if
        /// the API is being called in the Region where the traffic distribution group was created.
        /// The ARN must be provided if the call is from the replicated Region.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LastFailoverTime. 
        /// <para>
        /// The timestamp of the most recent failover for the traffic distribution group. This
        /// value is updated each time <c>UpdateTrafficDistribution</c> is called to change the
        /// traffic distribution.
        /// </para>
        /// </summary>
        public DateTime? LastFailoverTime { get; set; }

        /// <summary>
        /// Checks to see if the LastFailoverTime property is set.
        /// </summary>
        internal bool IsSetLastFailoverTime() => this.LastFailoverTime.HasValue;

        /// <summary>
        /// Gets and sets the property SignInConfig. 
        /// <para>
        /// The distribution that determines which Amazon Web Services Regions should be used
        /// to sign in agents in to both the instance and its replica(s).
        /// </para>
        /// </summary>
        public SignInConfig SignInConfig { get; set; }

        /// <summary>
        /// Checks to see if the SignInConfig property is set.
        /// </summary>
        internal bool IsSetSignInConfig() => this.SignInConfig != null;

        /// <summary>
        /// Gets and sets the property TelephonyConfig. 
        /// <para>
        /// The distribution of traffic between the instance and its replicas.
        /// </para>
        /// </summary>
        public TelephonyConfig TelephonyConfig { get; set; }

        /// <summary>
        /// Checks to see if the TelephonyConfig property is set.
        /// </summary>
        internal bool IsSetTelephonyConfig() => this.TelephonyConfig != null;
    }
}
