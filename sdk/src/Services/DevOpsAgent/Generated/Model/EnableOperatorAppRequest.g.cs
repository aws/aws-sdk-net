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
    /// Container for the parameters to the EnableOperatorApp operation. Enable the Operator
    /// App to access the given AgentSpace
    /// </summary>
    public partial class EnableOperatorAppRequest : AmazonDevOpsAgentRequest
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
        /// Gets and sets the property AuthFlow. 
        /// <para>
        /// The authentication flow configured for the operator App. e.g. iam or idc
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AuthFlow AuthFlow { get; set; }

        /// <summary>
        /// Checks to see if the AuthFlow property is set.
        /// </summary>
        internal bool IsSetAuthFlow() => this.AuthFlow != null;

        /// <summary>
        /// Gets and sets the property IdcInstanceArn. 
        /// <para>
        /// The IdC instance Arn used to create an IdC auth application
        /// </para>
        /// </summary>
        public string IdcInstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the IdcInstanceArn property is set.
        /// </summary>
        internal bool IsSetIdcInstanceArn() => this.IdcInstanceArn != null;

        /// <summary>
        /// Gets and sets the property IdpClientId. 
        /// <para>
        /// The OIDC client ID for the IdP application
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string IdpClientId { get; set; }

        /// <summary>
        /// Checks to see if the IdpClientId property is set.
        /// </summary>
        internal bool IsSetIdpClientId() => this.IdpClientId != null;

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

        /// <summary>
        /// Gets and sets the property IssuerUrl. 
        /// <para>
        /// The OIDC issuer URL of the external Identity Provider
        /// </para>
        /// </summary>
        public string IssuerUrl { get; set; }

        /// <summary>
        /// Checks to see if the IssuerUrl property is set.
        /// </summary>
        internal bool IsSetIssuerUrl() => this.IssuerUrl != null;

        /// <summary>
        /// Gets and sets the property OperatorAppRoleArn. 
        /// <para>
        /// The IAM role end users assume to access AIDevOps APIs
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string OperatorAppRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the OperatorAppRoleArn property is set.
        /// </summary>
        internal bool IsSetOperatorAppRoleArn() => this.OperatorAppRoleArn != null;

        /// <summary>
        /// Gets and sets the property Provider. 
        /// <para>
        /// The Identity Provider name (e.g., Entra, Okta, Google)
        /// </para>
        /// </summary>
        public string Provider { get; set; }

        /// <summary>
        /// Checks to see if the Provider property is set.
        /// </summary>
        internal bool IsSetProvider() => this.Provider != null;
    }
}
