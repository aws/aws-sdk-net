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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Authentication method for calling a Gateway.
    /// </summary>
    public partial class HarnessGatewayOutboundAuth
    {
        /// <summary>
        /// Gets and sets the property AwsIam. 
        /// <para>
        /// SigV4-sign requests using the agent's execution role.
        /// </para>
        /// </summary>
        public Unit AwsIam { get; set; }

        /// <summary>
        /// Checks to see if the AwsIam property is set.
        /// </summary>
        internal bool IsSetAwsIam() => this.AwsIam != null;

        /// <summary>
        /// Gets and sets the property None. 
        /// <para>
        /// No authentication.
        /// </para>
        /// </summary>
        public Unit None { get; set; }

        /// <summary>
        /// Checks to see if the None property is set.
        /// </summary>
        internal bool IsSetNone() => this.None != null;

        /// <summary>
        /// Gets and sets the property Oauth. 
        /// <para>
        /// Use OAuth credentials for outbound authentication to the gateway.
        /// </para>
        ///  
        /// <para>
        /// The <c>AUTHORIZATION_CODE</c> grant type is not supported for outbound authentication
        /// from a harness to an AgentCore Gateway, even when <c>defaultReturnUrl</c> is specified.
        /// </para>
        /// </summary>
        public OAuthCredentialProvider Oauth { get; set; }

        /// <summary>
        /// Checks to see if the Oauth property is set.
        /// </summary>
        internal bool IsSetOauth() => this.Oauth != null;
    }
}
