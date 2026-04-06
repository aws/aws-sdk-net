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
 * Do not modify this file. This file is generated from the devops-agent-2026-01-01.normal.json service model.
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
    /// Container for the parameters to the EnableOperatorApp operation.
    /// Enable the Operator App to access the given AgentSpace
    /// </summary>
    public partial class EnableOperatorAppRequest : AmazonDevOpsAgentRequest
    {
        private string _agentSpaceId;
        private AuthFlow _authFlow;
        private string _idcInstanceArn;
        private string _idpClientId;
        private string _idpClientSecret;
        private string _issuerUrl;
        private string _operatorAppRoleArn;
        private string _provider;

        /// <summary>
        /// Gets and sets the property AgentSpaceId. 
        /// <para>
        /// The unique identifier of the AgentSpace
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AgentSpaceId
        {
            get { return this._agentSpaceId; }
            set { this._agentSpaceId = value; }
        }

        // Check to see if AgentSpaceId property is set
        internal bool IsSetAgentSpaceId()
        {
            return this._agentSpaceId != null;
        }

        /// <summary>
        /// Gets and sets the property AuthFlow. 
        /// <para>
        /// The authentication flow configured for the operator App. e.g. iam or idc
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AuthFlow AuthFlow
        {
            get { return this._authFlow; }
            set { this._authFlow = value; }
        }

        // Check to see if AuthFlow property is set
        internal bool IsSetAuthFlow()
        {
            return this._authFlow != null;
        }

        /// <summary>
        /// Gets and sets the property IdcInstanceArn. 
        /// <para>
        /// The IdC instance Arn used to create an IdC auth application
        /// </para>
        /// </summary>
        public string IdcInstanceArn
        {
            get { return this._idcInstanceArn; }
            set { this._idcInstanceArn = value; }
        }

        // Check to see if IdcInstanceArn property is set
        internal bool IsSetIdcInstanceArn()
        {
            return this._idcInstanceArn != null;
        }

        /// <summary>
        /// Gets and sets the property IdpClientId. 
        /// <para>
        /// The OIDC client ID for the IdP application
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string IdpClientId
        {
            get { return this._idpClientId; }
            set { this._idpClientId = value; }
        }

        // Check to see if IdpClientId property is set
        internal bool IsSetIdpClientId()
        {
            return this._idpClientId != null;
        }

        /// <summary>
        /// Gets and sets the property IdpClientSecret. 
        /// <para>
        /// The OIDC client secret for the IdP application
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1024)]
        public string IdpClientSecret
        {
            get { return this._idpClientSecret; }
            set { this._idpClientSecret = value; }
        }

        // Check to see if IdpClientSecret property is set
        internal bool IsSetIdpClientSecret()
        {
            return this._idpClientSecret != null;
        }

        /// <summary>
        /// Gets and sets the property IssuerUrl. 
        /// <para>
        /// The OIDC issuer URL of the external Identity Provider
        /// </para>
        /// </summary>
        public string IssuerUrl
        {
            get { return this._issuerUrl; }
            set { this._issuerUrl = value; }
        }

        // Check to see if IssuerUrl property is set
        internal bool IsSetIssuerUrl()
        {
            return this._issuerUrl != null;
        }

        /// <summary>
        /// Gets and sets the property OperatorAppRoleArn. 
        /// <para>
        /// The IAM role end users assume to access AIDevOps APIs
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string OperatorAppRoleArn
        {
            get { return this._operatorAppRoleArn; }
            set { this._operatorAppRoleArn = value; }
        }

        // Check to see if OperatorAppRoleArn property is set
        internal bool IsSetOperatorAppRoleArn()
        {
            return this._operatorAppRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Provider. 
        /// <para>
        /// The Identity Provider name (e.g., Entra, Okta, Google)
        /// </para>
        /// </summary>
        public string Provider
        {
            get { return this._provider; }
            set { this._provider = value; }
        }

        // Check to see if Provider property is set
        internal bool IsSetProvider()
        {
            return this._provider != null;
        }

    }
}