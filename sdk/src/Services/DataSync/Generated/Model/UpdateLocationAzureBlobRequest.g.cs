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
    /// Container for the parameters to the UpdateLocationAzureBlob operation. Modifies the
    /// following configurations of the Microsoft Azure Blob Storage transfer location that
    /// you're using with DataSync. <para> For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/creating-azure-blob-location.html">Configuring
    /// DataSync transfers with Azure Blob Storage</a>. </para>
    /// </summary>
    public partial class UpdateLocationAzureBlobRequest : AmazonDataSyncRequest
    {
        /// <summary>
        /// Gets and sets the property AccessTier. 
        /// <para>
        /// Specifies the access tier that you want your objects or files transferred into. This
        /// only applies when using the location as a transfer destination. For more information,
        /// see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/creating-azure-blob-location.html#azure-blob-access-tiers">Access
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
        /// Specifies the authentication method DataSync uses to access your Azure Blob Storage.
        /// DataSync can access blob storage using a shared access signature (SAS).
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
        /// Specifies the type of blob that you want your objects or files to be when transferring
        /// them into Azure Blob Storage. Currently, DataSync only supports moving data into Azure
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
        /// Specifies configuration information for a DataSync-managed secret, such as an authentication
        /// token or set of credentials that DataSync uses to access a specific transfer location,
        /// and a customer-managed KMS key.
        /// </para>
        /// </summary>
        public CmkSecretConfig CmkSecretConfig { get; set; }

        /// <summary>
        /// Checks to see if the CmkSecretConfig property is set.
        /// </summary>
        internal bool IsSetCmkSecretConfig() => this.CmkSecretConfig != null;

        /// <summary>
        /// Gets and sets the property CustomSecretConfig. 
        /// <para>
        /// Specifies configuration information for a customer-managed secret, such as an authentication
        /// token or set of credentials that DataSync uses to access a specific transfer location,
        /// and a customer-managed Identity and Access Management (IAM) role that provides access
        /// to the secret.
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
        /// Specifies the ARN of the Azure Blob Storage transfer location that you're updating.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 128)]
        public string LocationArn { get; set; }

        /// <summary>
        /// Checks to see if the LocationArn property is set.
        /// </summary>
        internal bool IsSetLocationArn() => this.LocationArn != null;

        /// <summary>
        /// Gets and sets the property SasConfiguration. 
        /// <para>
        /// Specifies the SAS configuration that allows DataSync to access your Azure Blob Storage.
        /// </para>
        /// </summary>
        public AzureBlobSasConfiguration SasConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SasConfiguration property is set.
        /// </summary>
        internal bool IsSetSasConfiguration() => this.SasConfiguration != null;

        /// <summary>
        /// Gets and sets the property Subdirectory. 
        /// <para>
        /// Specifies path segments if you want to limit your transfer to a virtual directory
        /// in your container (for example, <c>/my/images</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Subdirectory { get; set; }

        /// <summary>
        /// Checks to see if the Subdirectory property is set.
        /// </summary>
        internal bool IsSetSubdirectory() => this.Subdirectory != null;
    }
}
