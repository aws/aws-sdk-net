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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Authentication method for calling a Gateway.
    /// </summary>
    public partial class HarnessGatewayOutboundAuth
    {
        private Unit _awsIam;
        private Unit _none;
        private OAuthCredentialProvider _oauth;

        /// <summary>
        /// Gets and sets the property AwsIam. 
        /// <para>
        /// SigV4-sign requests using the agent's execution role.
        /// </para>
        /// </summary>
        public Unit AwsIam
        {
            get { return this._awsIam; }
            set { this._awsIam = value; }
        }

        // Check to see if AwsIam property is set
        internal bool IsSetAwsIam()
        {
            return this._awsIam != null;
        }

        /// <summary>
        /// Gets and sets the property None. 
        /// <para>
        /// No authentication.
        /// </para>
        /// </summary>
        public Unit None
        {
            get { return this._none; }
            set { this._none = value; }
        }

        // Check to see if None property is set
        internal bool IsSetNone()
        {
            return this._none != null;
        }

        /// <summary>
        /// Gets and sets the property Oauth.
        /// </summary>
        public OAuthCredentialProvider Oauth
        {
            get { return this._oauth; }
            set { this._oauth = value; }
        }

        // Check to see if Oauth property is set
        internal bool IsSetOauth()
        {
            return this._oauth != null;
        }

    }
}