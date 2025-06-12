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
    /// A description of a specific Amazon File Cache resource, which is a response object
    /// from the <c>DescribeFileCaches</c> operation.
    /// </summary>
    public partial class FileCache
    {
        private DateTime? _creationTime;
        private List<string> _dataRepositoryAssociationIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _dnsName;
        private FileCacheFailureDetails _failureDetails;
        private string _fileCacheId;
        private FileCacheType _fileCacheType;
        private string _fileCacheTypeVersion;
        private string _kmsKeyId;
        private FileCacheLifecycle _lifecycle;
        private FileCacheLustreConfiguration _lustreConfiguration;
        private List<string> _networkInterfaceIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _ownerId;
        private string _resourceARN;
        private int? _storageCapacity;
        private List<string> _subnetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property CreationTime.
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
        /// Gets and sets the property DataRepositoryAssociationIds. 
        /// <para>
        /// A list of IDs of data repository associations that are associated with this cache.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=50)]
        public List<string> DataRepositoryAssociationIds
        {
            get { return this._dataRepositoryAssociationIds; }
            set { this._dataRepositoryAssociationIds = value; }
        }

        // Check to see if DataRepositoryAssociationIds property is set
        internal bool IsSetDataRepositoryAssociationIds()
        {
            return this._dataRepositoryAssociationIds != null && (this._dataRepositoryAssociationIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DNSName. 
        /// <para>
        /// The Domain Name System (DNS) name for the cache.
        /// </para>
        /// </summary>
        [AWSProperty(Min=16, Max=275)]
        public string DNSName
        {
            get { return this._dnsName; }
            set { this._dnsName = value; }
        }

        // Check to see if DNSName property is set
        internal bool IsSetDNSName()
        {
            return this._dnsName != null;
        }

        /// <summary>
        /// Gets and sets the property FailureDetails. 
        /// <para>
        /// A structure providing details of any failures that occurred.
        /// </para>
        /// </summary>
        public FileCacheFailureDetails FailureDetails
        {
            get { return this._failureDetails; }
            set { this._failureDetails = value; }
        }

        // Check to see if FailureDetails property is set
        internal bool IsSetFailureDetails()
        {
            return this._failureDetails != null;
        }

        /// <summary>
        /// Gets and sets the property FileCacheId. 
        /// <para>
        /// The system-generated, unique ID of the cache.
        /// </para>
        /// </summary>
        [AWSProperty(Min=11, Max=21)]
        public string FileCacheId
        {
            get { return this._fileCacheId; }
            set { this._fileCacheId = value; }
        }

        // Check to see if FileCacheId property is set
        internal bool IsSetFileCacheId()
        {
            return this._fileCacheId != null;
        }

        /// <summary>
        /// Gets and sets the property FileCacheType. 
        /// <para>
        /// The type of cache, which must be <c>LUSTRE</c>.
        /// </para>
        /// </summary>
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
        /// The Lustre version of the cache, which must be <c>2.12</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
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
        /// Gets and sets the property Lifecycle. 
        /// <para>
        /// The lifecycle status of the cache. The following are the possible values and what
        /// they mean:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AVAILABLE</c> - The cache is in a healthy state, and is reachable and available
        /// for use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATING</c> - The new cache is being created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c> - An existing cache is being deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATING</c> - The cache is undergoing a customer-initiated update.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> - An existing cache has experienced an unrecoverable failure. When
        /// creating a new cache, the cache was unable to be created.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public FileCacheLifecycle Lifecycle
        {
            get { return this._lifecycle; }
            set { this._lifecycle = value; }
        }

        // Check to see if Lifecycle property is set
        internal bool IsSetLifecycle()
        {
            return this._lifecycle != null;
        }

        /// <summary>
        /// Gets and sets the property LustreConfiguration. 
        /// <para>
        /// The configuration for the Amazon File Cache resource.
        /// </para>
        /// </summary>
        public FileCacheLustreConfiguration LustreConfiguration
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
        /// Gets and sets the property NetworkInterfaceIds.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=50)]
        public List<string> NetworkInterfaceIds
        {
            get { return this._networkInterfaceIds; }
            set { this._networkInterfaceIds = value; }
        }

        // Check to see if NetworkInterfaceIds property is set
        internal bool IsSetNetworkInterfaceIds()
        {
            return this._networkInterfaceIds != null && (this._networkInterfaceIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OwnerId.
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string OwnerId
        {
            get { return this._ownerId; }
            set { this._ownerId = value; }
        }

        // Check to see if OwnerId property is set
        internal bool IsSetOwnerId()
        {
            return this._ownerId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceARN.
        /// </summary>
        [AWSProperty(Min=8, Max=512)]
        public string ResourceARN
        {
            get { return this._resourceARN; }
            set { this._resourceARN = value; }
        }

        // Check to see if ResourceARN property is set
        internal bool IsSetResourceARN()
        {
            return this._resourceARN != null;
        }

        /// <summary>
        /// Gets and sets the property StorageCapacity. 
        /// <para>
        /// The storage capacity of the cache in gibibytes (GiB).
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
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
        [AWSProperty(Max=50)]
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
        /// Gets and sets the property VpcId.
        /// </summary>
        [AWSProperty(Min=12, Max=21)]
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

    }
}