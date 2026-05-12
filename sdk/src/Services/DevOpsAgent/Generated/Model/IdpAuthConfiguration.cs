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
    /// Configuration for external Identity Provider OIDC authentication flow for the Operator
    /// App.
    /// </summary>
    public partial class IdpAuthConfiguration
    {
        private string _clientId;
        private DateTime? _createdAt;
        private string _issuerUrl;
        private string _operatorAppRoleArn;
        private string _provider;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The OIDC client ID for the IdP application
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClientId
        {
            get { return this._clientId; }
            set { this._clientId = value; }
        }

        // Check to see if ClientId property is set
        internal bool IsSetClientId()
        {
            return this._clientId != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the Operator App IdP auth flow was enabled.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IssuerUrl. 
        /// <para>
        /// The OIDC issuer URL of the external Identity Provider
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        [AWSProperty(Required=true)]
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
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the Operator App IdP auth flow was updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}