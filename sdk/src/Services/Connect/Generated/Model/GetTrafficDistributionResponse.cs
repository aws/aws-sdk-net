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
    /// This is the response object from the GetTrafficDistribution operation.
    /// </summary>
    public partial class GetTrafficDistributionResponse : AmazonWebServiceResponse
    {
        private AgentConfig _agentConfig;
        private string _arn;
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
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the traffic distribution group.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the traffic distribution group. This can be the ID or the ARN if
        /// the API is being called in the Region where the traffic distribution group was created.
        /// The ARN must be provided if the call is from the replicated Region.
        /// </para>
        /// </summary>
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
        /// The distribution of traffic between the instance and its replicas.
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