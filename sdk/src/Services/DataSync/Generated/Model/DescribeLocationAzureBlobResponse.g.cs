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

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// This is the response object from the DescribeLocationAzureBlob operation.
    /// </summary>
    public partial class DescribeLocationAzureBlobResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AccessTier. 
        /// <para>
        /// The access tier that you want your objects or files transferred into. This only applies
        /// when using the location as a transfer destination. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/creating-azure-blob-location.html#azure-blob-access-tiers">Access
        /// tiers</a>.
        /// </para>
        /// </summary>
        public AzureAccessTier AccessTier { get; set; }

        /// <summary>
        /// Checks to see if the AccessTier property is set.
        /// </summary>
        internal bool IsSetAccessTier() => this.AccessTier != null;

        /// <summary>
        /// Gets and sets the property AgentArns. 
        /// <para>
        /// The ARNs of the DataSync agents that can connect with your Azure Blob Storage container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 8)]
        public List<string> AgentArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AgentArns property is set.
        /// </summary>
        internal bool IsSetAgentArns() => this.AgentArns != null && (this.AgentArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AuthenticationType. 
        /// <para>
        /// The authentication method DataSync uses to access your Azure Blob Storage. DataSync
        /// can access blob storage using a shared access signature (SAS).
        /// </para>
        /// </summary>
        public AzureBlobAuthenticationType AuthenticationType { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationType property is set.
        /// </summary>
        internal bool IsSetAuthenticationType() => this.AuthenticationType != null;

        /// <summary>
        /// Gets and sets the property BlobType. 
        /// <para>
        /// The type of blob that you want your objects or files to be when transferring them
        /// into Azure Blob Storage. Currently, DataSync only supports moving data into Azure
        /// Blob Storage as block blobs. For more information on blob types, see the <a href="https://learn.microsoft.com/en-us/rest/api/storageservices/understanding-block-blobs--append-blobs--and-page-blobs">Azure
        /// Blob Storage documentation</a>.
        /// </para>
        /// </summary>
        public AzureBlobType BlobType { get; set; }

        /// <summary>
        /// Checks to see if the BlobType property is set.
        /// </summary>
        internal bool IsSetBlobType() => this.BlobType != null;

        /// <summary>
        /// Gets and sets the property CmkSecretConfig. 
        /// <para>
        /// Describes configuration information for a DataSync-managed secret, such as an authentication
        /// token that DataSync uses to access a specific storage location, with a customer-managed
        /// KMS key.
        /// </para>
        /// </summary>
        public CmkSecretConfig CmkSecretConfig { get; set; }

        /// <summary>
        /// Checks to see if the CmkSecretConfig property is set.
        /// </summary>
        internal bool IsSetCmkSecretConfig() => this.CmkSecretConfig != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time that your Azure Blob Storage transfer location was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property CustomSecretConfig. 
        /// <para>
        /// Describes configuration information for a customer-managed secret, such as an authentication
        /// token that DataSync uses to access a specific storage location, with a customer-managed
        /// Identity and Access Management (IAM) role that provides access to the secret.
        /// </para>
        /// </summary>
        public CustomSecretConfig CustomSecretConfig { get; set; }

        /// <summary>
        /// Checks to see if the CustomSecretConfig property is set.
        /// </summary>
        internal bool IsSetCustomSecretConfig() => this.CustomSecretConfig != null;

        /// <summary>
        /// Gets and sets the property LocationArn. 
        /// <para>
        /// The ARN of your Azure Blob Storage transfer location.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string LocationArn { get; set; }

        /// <summary>
        /// Checks to see if the LocationArn property is set.
        /// </summary>
        internal bool IsSetLocationArn() => this.LocationArn != null;

        /// <summary>
        /// Gets and sets the property LocationUri. 
        /// <para>
        /// The URL of the Azure Blob Storage container involved in your transfer.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4360)]
        public string LocationUri { get; set; }

        /// <summary>
        /// Checks to see if the LocationUri property is set.
        /// </summary>
        internal bool IsSetLocationUri() => this.LocationUri != null;

        /// <summary>
        /// Gets and sets the property ManagedSecretConfig. 
        /// <para>
        /// Describes configuration information for a DataSync-managed secret, such as an authentication
        /// token that DataSync uses to access a specific storage location. DataSync uses the
        /// default Amazon Web Services-managed KMS key to encrypt this secret in Secrets Manager.
        /// </para>
        /// </summary>
        public ManagedSecretConfig ManagedSecretConfig { get; set; }

        /// <summary>
        /// Checks to see if the ManagedSecretConfig property is set.
        /// </summary>
        internal bool IsSetManagedSecretConfig() => this.ManagedSecretConfig != null;
    }
}
