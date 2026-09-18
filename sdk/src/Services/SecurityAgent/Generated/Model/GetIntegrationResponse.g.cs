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

namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// This is the response object from the GetIntegration operation.
    /// </summary>
    public partial class GetIntegrationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name of the integration.
        /// </para>
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property InstallationId. 
        /// <para>
        /// The installation identifier from the integration provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string InstallationId { get; set; }

        /// <summary>
        /// Checks to see if the InstallationId property is set.
        /// </summary>
        internal bool IsSetInstallationId() => this.InstallationId != null;

        /// <summary>
        /// Gets and sets the property IntegrationId. 
        /// <para>
        /// The unique identifier of the integration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string IntegrationId { get; set; }

        /// <summary>
        /// Checks to see if the IntegrationId property is set.
        /// </summary>
        internal bool IsSetIntegrationId() => this.IntegrationId != null;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The identifier of the AWS KMS key used to encrypt data associated with the integration.
        /// </para>
        /// </summary>
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property PrivateConnectionName. 
        /// <para>
        /// The name of the private connection used to reach the integration's self-hosted instance
        /// over private networking, if one is configured.
        /// </para>
        /// </summary>
        public string PrivateConnectionName { get; set; }

        /// <summary>
        /// Checks to see if the PrivateConnectionName property is set.
        /// </summary>
        internal bool IsSetPrivateConnectionName() => this.PrivateConnectionName != null;

        /// <summary>
        /// Gets and sets the property Provider. 
        /// <para>
        /// The integration provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Provider Provider { get; set; }

        /// <summary>
        /// Checks to see if the Provider property is set.
        /// </summary>
        internal bool IsSetProvider() => this.Provider != null;

        /// <summary>
        /// Gets and sets the property ProviderType. 
        /// <para>
        /// The type of the integration provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ProviderType ProviderType { get; set; }

        /// <summary>
        /// Checks to see if the ProviderType property is set.
        /// </summary>
        internal bool IsSetProviderType() => this.ProviderType != null;

        /// <summary>
        /// Gets and sets the property TargetUrl. 
        /// <para>
        /// The HTTPS URL of the customer self-hosted instance, such as a GitHub Enterprise Server
        /// or self-managed GitLab instance. This value is absent for SaaS integrations.
        /// </para>
        /// </summary>
        public string TargetUrl { get; set; }

        /// <summary>
        /// Checks to see if the TargetUrl property is set.
        /// </summary>
        internal bool IsSetTargetUrl() => this.TargetUrl != null;
    }
}
