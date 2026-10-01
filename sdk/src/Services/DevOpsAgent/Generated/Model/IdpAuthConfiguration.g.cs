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
    /// Configuration for external Identity Provider OIDC authentication flow for the Operator
    /// App.
    /// </summary>
    public partial class IdpAuthConfiguration
    {
        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The OIDC client ID for the IdP application
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ClientId { get; set; }

        /// <summary>
        /// Checks to see if the ClientId property is set.
        /// </summary>
        internal bool IsSetClientId() => this.ClientId != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the Operator App IdP auth flow was enabled.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property IssuerUrl. 
        /// <para>
        /// The OIDC issuer URL of the external Identity Provider
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
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
        [AWSProperty(Required = true)]
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
        [AWSProperty(Required = true)]
        public string Provider { get; set; }

        /// <summary>
        /// Checks to see if the Provider property is set.
        /// </summary>
        internal bool IsSetProvider() => this.Provider != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the Operator App IdP auth flow was updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
