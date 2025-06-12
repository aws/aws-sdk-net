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
    /// Container for the parameters to the UpdateLocationAzureBlob operation.
    /// Modifies the following configurations of the Microsoft Azure Blob Storage transfer
    /// location that you're using with DataSync.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/creating-azure-blob-location.html">Configuring
    /// DataSync transfers with Azure Blob Storage</a>.
    /// </para>
    /// </summary>
    public partial class UpdateLocationAzureBlobRequest : AmazonDataSyncRequest
    {
        private AzureAccessTier _accessTier;
        private List<string> _agentArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private AzureBlobAuthenticationType _authenticationType;
        private AzureBlobType _blobType;
        private CmkSecretConfig _cmkSecretConfig;
        private CustomSecretConfig _customSecretConfig;
        private string _locationArn;
        private AzureBlobSasConfiguration _sasConfiguration;
        private string _subdirectory;

        /// <summary>
        /// Gets and sets the property AccessTier. 
        /// <para>
        /// Specifies the access tier that you want your objects or files transferred into. This
        /// only applies when using the location as a transfer destination. For more information,
        /// see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/creating-azure-blob-location.html#azure-blob-access-tiers">Access
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
        /// (Optional) Specifies the Amazon Resource Name (ARN) of the DataSync agent that can
        /// connect with your Azure Blob Storage container. If you are setting up an agentless
        /// cross-cloud transfer, you do not need to specify a value for this parameter.
        /// </para>
        ///  
        /// <para>
        /// You can specify more than one agent. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/multiple-agents.html">Using
        /// multiple agents for your transfer</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// You cannot add or remove agents from a storage location after you initially create
        /// it.
        /// </para>
        ///  </note>
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
        /// Specifies the authentication method DataSync uses to access your Azure Blob Storage.
        /// DataSync can access blob storage using a shared access signature (SAS).
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
        /// Specifies the type of blob that you want your objects or files to be when transferring
        /// them into Azure Blob Storage. Currently, DataSync only supports moving data into Azure
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
        /// Specifies configuration information for a DataSync-managed secret, such as an authentication
        /// token or set of credentials that DataSync uses to access a specific transfer location,
        /// and a customer-managed KMS key.
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
        /// Gets and sets the property CustomSecretConfig. 
        /// <para>
        /// Specifies configuration information for a customer-managed secret, such as an authentication
        /// token or set of credentials that DataSync uses to access a specific transfer location,
        /// and a customer-managed KMS key.
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
        /// Specifies the ARN of the Azure Blob Storage transfer location that you're updating.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=128)]
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
        /// Gets and sets the property SasConfiguration. 
        /// <para>
        /// Specifies the SAS configuration that allows DataSync to access your Azure Blob Storage.
        /// </para>
        /// </summary>
        public AzureBlobSasConfiguration SasConfiguration
        {
            get { return this._sasConfiguration; }
            set { this._sasConfiguration = value; }
        }

        // Check to see if SasConfiguration property is set
        internal bool IsSetSasConfiguration()
        {
            return this._sasConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Subdirectory. 
        /// <para>
        /// Specifies path segments if you want to limit your transfer to a virtual directory
        /// in your container (for example, <c>/my/images</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string Subdirectory
        {
            get { return this._subdirectory; }
            set { this._subdirectory = value; }
        }

        // Check to see if Subdirectory property is set
        internal bool IsSetSubdirectory()
        {
            return this._subdirectory != null;
        }

    }
}