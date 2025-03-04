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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
    /// Container for the parameters to the UpdateTrafficDistribution operation.
    /// Updates the traffic distribution for a given traffic distribution group. 
    /// 
    ///  <important> 
    /// <para>
    /// When you shift telephony traffic, also shift agents and/or agent sign-ins to ensure
    /// they can handle the calls in the other Region. If you don't shift the agents, voice
    /// calls will go to the shifted Region but there won't be any agents available to receive
    /// the calls.
    /// </para>
    ///  </important> <note> 
    /// <para>
    /// The <c>SignInConfig</c> distribution is available only on a default <c>TrafficDistributionGroup</c>
    /// (see the <c>IsDefault</c> parameter in the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_TrafficDistributionGroup.html">TrafficDistributionGroup</a>
    /// data type). If you call <c>UpdateTrafficDistribution</c> with a modified <c>SignInConfig</c>
    /// and a non-default <c>TrafficDistributionGroup</c>, an <c>InvalidRequestException</c>
    /// is returned.
    /// </para>
    ///  </note> 
    /// <para>
    /// For more information about updating a traffic distribution group, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/update-telephony-traffic-distribution.html">Update
    /// telephony traffic distribution across Amazon Web Services Regions </a> in the <i>Amazon
    /// Connect Administrator Guide</i>. 
    /// </para>
    /// </summary>
    public partial class UpdateTrafficDistributionRequest : AmazonConnectRequest
    {
        private AgentConfig _agentConfig;
        private string _id;
        private SignInConfig _signInConfig;
        private TelephonyConfig _telephonyConfig;

        /// <summary>
        /// Gets and sets the property AgentConfig. 
        /// <para>
        /// The distribution of agents between the instance and its replica(s).
        /// </para>
        /// </summary>
        public AgentConfig AgentConfig
        {
            get { return this._agentConfig; }
            set { this._agentConfig = value; }
        }

        // Check to see if AgentConfig property is set
        internal bool IsSetAgentConfig()
        {
            return this._agentConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the traffic distribution group. This can be the ID or the ARN if
        /// the API is being called in the Region where the traffic distribution group was created.
        /// The ARN must be provided if the call is from the replicated Region. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property SignInConfig. 
        /// <para>
        /// The distribution that determines which Amazon Web Services Regions should be used
        /// to sign in agents in to both the instance and its replica(s).
        /// </para>
        /// </summary>
        public SignInConfig SignInConfig
        {
            get { return this._signInConfig; }
            set { this._signInConfig = value; }
        }

        // Check to see if SignInConfig property is set
        internal bool IsSetSignInConfig()
        {
            return this._signInConfig != null;
        }

        /// <summary>
        /// Gets and sets the property TelephonyConfig. 
        /// <para>
        /// The distribution of traffic between the instance and its replica(s).
        /// </para>
        /// </summary>
        public TelephonyConfig TelephonyConfig
        {
            get { return this._telephonyConfig; }
            set { this._telephonyConfig = value; }
        }

        // Check to see if TelephonyConfig property is set
        internal bool IsSetTelephonyConfig()
        {
            return this._telephonyConfig != null;
        }

    }
}