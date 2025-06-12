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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
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
        private AzureAccessTier _accessTier;
        private List<string> _agentArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private AzureBlobAuthenticationType _authenticationType;
        private AzureBlobType _blobType;
        private CmkSecretConfig _cmkSecretConfig;
        private DateTime? _creationTime;
        private CustomSecretConfig _customSecretConfig;
        private string _locationArn;
        private string _locationUri;
        private ManagedSecretConfig _managedSecretConfig;

        /// <summary>
        /// Gets and sets the property AccessTier. 
        /// <para>
        /// The access tier that you want your objects or files transferred into. This only applies
        /// when using the location as a transfer destination. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/creating-azure-blob-location.html#azure-blob-access-tiers">Access
        /// tiers</a>.
        /// </para>
        /// </summary>
        public AzureAccessTier AccessTier
        {
            get { return this._accessTier; }
            set { this._accessTier = value; }
        }

        // Check to see if AccessTier property is set
        internal bool IsSetAccessTier()
        {
            return this._accessTier != null;
        }

        /// <summary>
        /// Gets and sets the property AgentArns. 
        /// <para>
        /// The ARNs of the DataSync agents that can connect with your Azure Blob Storage container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=4)]
        public List<string> AgentArns
        {
            get { return this._agentArns; }
            set { this._agentArns = value; }
        }

        // Check to see if AgentArns property is set
        internal bool IsSetAgentArns()
        {
            return this._agentArns != null && (this._agentArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AuthenticationType. 
        /// <para>
        /// The authentication method DataSync uses to access your Azure Blob Storage. DataSync
        /// can access blob storage using a shared access signature (SAS).
        /// </para>
        /// </summary>
        public AzureBlobAuthenticationType AuthenticationType
        {
            get { return this._authenticationType; }
            set { this._authenticationType = value; }
        }

        // Check to see if AuthenticationType property is set
        internal bool IsSetAuthenticationType()
        {
            return this._authenticationType != null;
        }

        /// <summary>
        /// Gets and sets the property BlobType. 
        /// <para>
        /// The type of blob that you want your objects or files to be when transferring them
        /// into Azure Blob Storage. Currently, DataSync only supports moving data into Azure
        /// Blob Storage as block blobs. For more information on blob types, see the <a href="https://learn.microsoft.com/en-us/rest/api/storageservices/understanding-block-blobs--append-blobs--and-page-blobs">Azure
        /// Blob Storage documentation</a>.
        /// </para>
        /// </summary>
        public AzureBlobType BlobType
        {
            get { return this._blobType; }
            set { this._blobType = value; }
        }

        // Check to see if BlobType property is set
        internal bool IsSetBlobType()
        {
            return this._blobType != null;
        }

        /// <summary>
        /// Gets and sets the property CmkSecretConfig. 
        /// <para>
        /// Describes configuration information for a DataSync-managed secret, such as an authentication
        /// token that DataSync uses to access a specific storage location, with a customer-managed
        /// KMS key.
        /// </para>
        /// </summary>
        public CmkSecretConfig CmkSecretConfig
        {
            get { return this._cmkSecretConfig; }
            set { this._cmkSecretConfig = value; }
        }

        // Check to see if CmkSecretConfig property is set
        internal bool IsSetCmkSecretConfig()
        {
            return this._cmkSecretConfig != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time that your Azure Blob Storage transfer location was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CustomSecretConfig. 
        /// <para>
        /// Describes configuration information for a customer-managed secret, such as an authentication
        /// token that DataSync uses to access a specific storage location, with a customer-managed
        /// KMS key.
        /// </para>
        /// </summary>
        public CustomSecretConfig CustomSecretConfig
        {
            get { return this._customSecretConfig; }
            set { this._customSecretConfig = value; }
        }

        // Check to see if CustomSecretConfig property is set
        internal bool IsSetCustomSecretConfig()
        {
            return this._customSecretConfig != null;
        }

        /// <summary>
        /// Gets and sets the property LocationArn. 
        /// <para>
        /// The ARN of your Azure Blob Storage transfer location.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
        public string LocationArn
        {
            get { return this._locationArn; }
            set { this._locationArn = value; }
        }

        // Check to see if LocationArn property is set
        internal bool IsSetLocationArn()
        {
            return this._locationArn != null;
        }

        /// <summary>
        /// Gets and sets the property LocationUri. 
        /// <para>
        /// The URL of the Azure Blob Storage container involved in your transfer.
        /// </para>
        /// </summary>
        [AWSProperty(Max=4360)]
        public string LocationUri
        {
            get { return this._locationUri; }
            set { this._locationUri = value; }
        }

        // Check to see if LocationUri property is set
        internal bool IsSetLocationUri()
        {
            return this._locationUri != null;
        }

        /// <summary>
        /// Gets and sets the property ManagedSecretConfig. 
        /// <para>
        /// Describes configuration information for a DataSync-managed secret, such as an authentication
        /// token that DataSync uses to access a specific storage location. DataSync uses the
        /// default Amazon Web Services-managed KMS key to encrypt this secret in Secrets Manager.
        /// </para>
        /// </summary>
        public ManagedSecretConfig ManagedSecretConfig
        {
            get { return this._managedSecretConfig; }
            set { this._managedSecretConfig = value; }
        }

        // Check to see if ManagedSecretConfig property is set
        internal bool IsSetManagedSecretConfig()
        {
            return this._managedSecretConfig != null;
        }

    }
}