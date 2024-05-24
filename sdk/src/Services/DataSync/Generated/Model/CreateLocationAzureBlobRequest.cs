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
    /// Container for the parameters to the CreateLocationAzureBlob operation.
    /// Creates a transfer <i>location</i> for a Microsoft Azure Blob Storage container. DataSync
    /// can use this location as a transfer source or destination.
    /// 
    ///  
    /// <para>
    /// Before you begin, make sure you know <a href="https://docs.aws.amazon.com/datasync/latest/userguide/creating-azure-blob-location.html#azure-blob-access">how
    /// DataSync accesses Azure Blob Storage</a> and works with <a href="https://docs.aws.amazon.com/datasync/latest/userguide/creating-azure-blob-location.html#azure-blob-access-tiers">access
    /// tiers</a> and <a href="https://docs.aws.amazon.com/datasync/latest/userguide/creating-azure-blob-location.html#blob-types">blob
    /// types</a>. You also need a <a href="https://docs.aws.amazon.com/datasync/latest/userguide/creating-azure-blob-location.html#azure-blob-creating-agent">DataSync
    /// agent</a> that can connect to your container.
    /// </para>
    /// </summary>
    public partial class CreateLocationAzureBlobRequest : AmazonDataSyncRequest
    {
        private AzureAccessTier _accessTier;
        private List<string> _agentArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private AzureBlobAuthenticationType _authenticationType;
        private AzureBlobType _blobType;
        private string _containerUrl;
        private AzureBlobSasConfiguration _sasConfiguration;
        private string _subdirectory;
        private List<TagListEntry> _tags = AWSConfigs.InitializeCollections ? new List<TagListEntry>() : null;

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
        /// Specifies the Amazon Resource Name (ARN) of the DataSync agent that can connect with
        /// your Azure Blob Storage container.
        /// </para>
        ///  
        /// <para>
        /// You can specify more than one agent. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/multiple-agents.html">Using
        /// multiple agents for your transfer</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4)]
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
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ContainerUrl. 
        /// <para>
        /// Specifies the URL of the Azure Blob Storage container involved in your transfer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=325)]
        public string ContainerUrl
        {
            get { return this._containerUrl; }
            set { this._containerUrl = value; }
        }

        // Check to see if ContainerUrl property is set
        internal bool IsSetContainerUrl()
        {
            return this._containerUrl != null;
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Specifies labels that help you categorize, filter, and search for your Amazon Web
        /// Services resources. We recommend creating at least a name tag for your transfer location.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<TagListEntry> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}