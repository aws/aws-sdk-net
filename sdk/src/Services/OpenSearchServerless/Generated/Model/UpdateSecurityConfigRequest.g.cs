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

namespace Amazon.OpenSearchServerless.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSecurityConfig operation. Updates a security
    /// configuration for OpenSearch Serverless. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-saml.html">SAML
    /// authentication for Amazon OpenSearch Serverless</a>.
    /// </summary>
    public partial class UpdateSecurityConfigRequest : AmazonOpenSearchServerlessRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier to ensure idempotency of the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property ConfigVersion. 
        /// <para>
        /// The version of the security configuration to be updated. You can find the most recent
        /// version of a security configuration using the <c>GetSecurityPolicy</c> command.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 36)]
        public string ConfigVersion { get; set; }

        /// <summary>
        /// Checks to see if the ConfigVersion property is set.
        /// </summary>
        internal bool IsSetConfigVersion() => this.ConfigVersion != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the security configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property IamFederationOptions. 
        /// <para>
        /// Describes IAM federation options in the form of a key-value map for updating an existing
        /// security configuration. Use this field to modify IAM federation settings for the security
        /// configuration.
        /// </para>
        /// </summary>
        public IamFederationConfigOptions IamFederationOptions { get; set; }

        /// <summary>
        /// Checks to see if the IamFederationOptions property is set.
        /// </summary>
        internal bool IsSetIamFederationOptions() => this.IamFederationOptions != null;

        /// <summary>
        /// Gets and sets the property IamIdentityCenterOptionsUpdates. 
        /// <para>
        /// Describes IAM Identity Center options in the form of a key-value map.
        /// </para>
        /// </summary>
        public UpdateIamIdentityCenterConfigOptions IamIdentityCenterOptionsUpdates { get; set; }

        /// <summary>
        /// Checks to see if the IamIdentityCenterOptionsUpdates property is set.
        /// </summary>
        internal bool IsSetIamIdentityCenterOptionsUpdates() => this.IamIdentityCenterOptionsUpdates != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The security configuration identifier. For SAML the ID will be <c>saml/&lt;accountId&gt;/&lt;idpProviderName&gt;</c>.
        /// For example, <c>saml/123456789123/OKTADev</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property SamlOptions. 
        /// <para>
        /// SAML options in in the form of a key-value map.
        /// </para>
        /// </summary>
        public SamlConfigOptions SamlOptions { get; set; }

        /// <summary>
        /// Checks to see if the SamlOptions property is set.
        /// </summary>
        internal bool IsSetSamlOptions() => this.SamlOptions != null;
    }
}
