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

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Container for the parameters required to enable Cognito authentication for an OpenSearch
    /// Service domain. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/cognito-auth.html">Configuring
    /// Amazon Cognito authentication for OpenSearch Dashboards</a>.
    /// </summary>
    public partial class CognitoOptions
    {
        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Whether to enable or disable Amazon Cognito authentication for OpenSearch Dashboards.
        /// </para>
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property IdentityPoolId. 
        /// <para>
        /// The Amazon Cognito identity pool ID that you want OpenSearch Service to use for OpenSearch
        /// Dashboards authentication.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 55)]
        public string IdentityPoolId { get; set; }

        /// <summary>
        /// Checks to see if the IdentityPoolId property is set.
        /// </summary>
        internal bool IsSetIdentityPoolId() => this.IdentityPoolId != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The <c>AmazonOpenSearchServiceCognitoAccess</c> role that allows OpenSearch Service
        /// to configure your user pool and identity pool.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property UserPoolId. 
        /// <para>
        /// The Amazon Cognito user pool ID that you want OpenSearch Service to use for OpenSearch
        /// Dashboards authentication.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 55)]
        public string UserPoolId { get; set; }

        /// <summary>
        /// Checks to see if the UserPoolId property is set.
        /// </summary>
        internal bool IsSetUserPoolId() => this.UserPoolId != null;
    }
}
