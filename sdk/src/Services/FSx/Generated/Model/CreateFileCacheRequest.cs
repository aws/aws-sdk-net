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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
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
namespace Amazon.FSx.Model
{
    /// <summary>
    /// Container for the parameters to the CreateFileCache operation.
    /// Creates a new Amazon File Cache resource.
    /// 
    ///  
    /// <para>
    /// You can use this operation with a client request token in the request that Amazon
    /// File Cache uses to ensure idempotent creation. If a cache with the specified client
    /// request token exists and the parameters match, <c>CreateFileCache</c> returns the
    /// description of the existing cache. If a cache with the specified client request token
    /// exists and the parameters don't match, this call returns <c>IncompatibleParameterError</c>.
    /// If a file cache with the specified client request token doesn't exist, <c>CreateFileCache</c>
    /// does the following: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Creates a new, empty Amazon File Cache resource with an assigned ID, and an initial
    /// lifecycle state of <c>CREATING</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Returns the description of the cache in JSON format.
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// The <c>CreateFileCache</c> call returns while the cache's lifecycle state is still
    /// <c>CREATING</c>. You can check the cache creation status by calling the <a href="https://docs.aws.amazon.com/fsx/latest/APIReference/API_DescribeFileCaches.html">DescribeFileCaches</a>
    /// operation, which returns the cache state along with other information.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateFileCacheRequest : AmazonFSxRequest
    {
        private string _clientRequestToken;
        private bool? _copyTagsToDataRepositoryAssociations;
        private List<FileCacheDataRepositoryAssociation> _dataRepositoryAssociations = AWSConfigs.InitializeCollections ? new List<FileCacheDataRepositoryAssociation>() : null;
        private FileCacheType _fileCacheType;
        private string _fileCacheTypeVersion;
        private string _kmsKeyId;
        private CreateFileCacheLustreConfiguration _lustreConfiguration;
        private List<string> _securityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _storageCapacity;
        private List<string> _subnetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// An idempotency token for resource creation, in a string of up to 63 ASCII characters.
        /// This token is automatically filled on your behalf when you use the Command Line Interface
        /// (CLI) or an Amazon Web Services SDK.
        /// </para>
        ///  
        /// <para>
        /// By using the idempotent operation, you can retry a <c>CreateFileCache</c> operation
        /// without the risk of creating an extra cache. This approach can be useful when an initial
        /// call fails in a way that makes it unclear whether a cache was created. Examples are
        /// if a transport level timeout occurred, or your connection was reset. If you use the
        /// same client request token and the initial call created a cache, the client receives
        /// success as long as the parameters are the same.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property CopyTagsToDataRepositoryAssociations. 
        /// <para>
        /// A boolean flag indicating whether tags for the cache should be copied to data repository
        /// associations. This value defaults to false.
        /// </para>
        /// </summary>
        public bool? CopyTagsToDataRepositoryAssociations
        {
            get { return this._copyTagsToDataRepositoryAssociations; }
            set { this._copyTagsToDataRepositoryAssociations = value; }
        }

        // Check to see if CopyTagsToDataRepositoryAssociations property is set
        internal bool IsSetCopyTagsToDataRepositoryAssociations()
        {
            return this._copyTagsToDataRepositoryAssociations.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataRepositoryAssociations. 
        /// <para>
        /// A list of up to 8 configurations for data repository associations (DRAs) to be created
        /// during the cache creation. The DRAs link the cache to either an Amazon S3 data repository
        /// or a Network File System (NFS) data repository that supports the NFSv3 protocol.
        /// </para>
        ///  
        /// <para>
        /// The DRA configurations must meet the following requirements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// All configurations on the list must be of the same data repository type, either all
        /// S3 or all NFS. A cache can't link to different data repository types at the same time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An NFS DRA must link to an NFS file system that supports the NFSv3 protocol.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// DRA automatic import and automatic export is not supported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=8)]
        public List<FileCacheDataRepositoryAssociation> DataRepositoryAssociations
        {
            get { return this._dataRepositoryAssociations; }
            set { this._dataRepositoryAssociations = value; }
        }

        // Check to see if DataRepositoryAssociations property is set
        internal bool IsSetDataRepositoryAssociations()
        {
            return this._dataRepositoryAssociations != null && (this._dataRepositoryAssociations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FileCacheType. 
        /// <para>
        /// The type of cache that you're creating, which must be <c>LUSTRE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FileCacheType FileCacheType
        {
            get { return this._fileCacheType; }
            set { this._fileCacheType = value; }
        }

        // Check to see if FileCacheType property is set
        internal bool IsSetFileCacheType()
        {
            return this._fileCacheType != null;
        }

        /// <summary>
        /// Gets and sets the property FileCacheTypeVersion. 
        /// <para>
        /// Sets the Lustre version for the cache that you're creating, which must be <c>2.12</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public string FileCacheTypeVersion
        {
            get { return this._fileCacheTypeVersion; }
            set { this._fileCacheTypeVersion = value; }
        }

        // Check to see if FileCacheTypeVersion property is set
        internal bool IsSetFileCacheTypeVersion()
        {
            return this._fileCacheTypeVersion != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// Specifies the ID of the Key Management Service (KMS) key to use for encrypting data
        /// on an Amazon File Cache. If a <c>KmsKeyId</c> isn't specified, the Amazon FSx-managed
        /// KMS key for your account is used. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_Encrypt.html">Encrypt</a>
        /// in the <i>Key Management Service API Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property LustreConfiguration. 
        /// <para>
        /// The configuration for the Amazon File Cache resource being created.
        /// </para>
        /// </summary>
        public CreateFileCacheLustreConfiguration LustreConfiguration
        {
            get { return this._lustreConfiguration; }
            set { this._lustreConfiguration = value; }
        }

        // Check to see if LustreConfiguration property is set
        internal bool IsSetLustreConfiguration()
        {
            return this._lustreConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// A list of IDs specifying the security groups to apply to all network interfaces created
        /// for Amazon File Cache access. This list isn't returned in later requests to describe
        /// the cache.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=50)]
        public List<string> SecurityGroupIds
        {
            get { return this._securityGroupIds; }
            set { this._securityGroupIds = value; }
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this._securityGroupIds != null && (this._securityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StorageCapacity. 
        /// <para>
        /// The storage capacity of the cache in gibibytes (GiB). Valid values are 1200 GiB, 2400
        /// GiB, and increments of 2400 GiB.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2147483647)]
        public int? StorageCapacity
        {
            get { return this._storageCapacity; }
            set { this._storageCapacity = value; }
        }

        // Check to see if StorageCapacity property is set
        internal bool IsSetStorageCapacity()
        {
            return this._storageCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SubnetIds.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Max=50)]
        public List<string> SubnetIds
        {
            get { return this._subnetIds; }
            set { this._subnetIds = value; }
        }

        // Check to see if SubnetIds property is set
        internal bool IsSetSubnetIds()
        {
            return this._subnetIds != null && (this._subnetIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<Tag> Tags
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