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
 * Do not modify this file. This file is generated from the securityagent-2025-09-06.normal.json service model.
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
        private string _displayName;
        private string _installationId;
        private string _integrationId;
        private string _kmsKeyId;
        private Provider _provider;
        private ProviderType _providerType;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// Display name for the integration
        /// </para>
        /// </summary>
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property InstallationId. 
        /// <para>
        /// Installation identifier from the provider
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string InstallationId
        {
            get { return this._installationId; }
            set { this._installationId = value; }
        }

        // Check to see if InstallationId property is set
        internal bool IsSetInstallationId()
        {
            return this._installationId != null;
        }

        /// <summary>
        /// Gets and sets the property IntegrationId. 
        /// <para>
        /// Unique identifier of the integration
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IntegrationId
        {
            get { return this._integrationId; }
            set { this._integrationId = value; }
        }

        // Check to see if IntegrationId property is set
        internal bool IsSetIntegrationId()
        {
            return this._integrationId != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// KMS key ID for encrypting integration details
        /// </para>
        /// </summary>
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property Provider. 
        /// <para>
        /// Provider type
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Provider Provider
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
        /// Gets and sets the property ProviderType. 
        /// <para>
        /// Type of provider integration
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ProviderType ProviderType
        {
            get { return this._providerType; }
            set { this._providerType = value; }
        }

        // Check to see if ProviderType property is set
        internal bool IsSetProviderType()
        {
            return this._providerType != null;
        }

    }
}