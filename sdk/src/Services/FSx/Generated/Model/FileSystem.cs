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
    /// A description of a specific Amazon FSx file system.
    /// </summary>
    public partial class FileSystem
    {
        private List<AdministrativeAction> _administrativeActions = AWSConfigs.InitializeCollections ? new List<AdministrativeAction>() : null;
        private DateTime? _creationTime;
        private string _dnsName;
        private FileSystemFailureDetails _failureDetails;
        private string _fileSystemId;
        private FileSystemType _fileSystemType;
        private string _fileSystemTypeVersion;
        private string _kmsKeyId;
        private FileSystemLifecycle _lifecycle;
        private LustreFileSystemConfiguration _lustreConfiguration;
        private List<string> _networkInterfaceIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private NetworkType _networkType;
        private OntapFileSystemConfiguration _ontapConfiguration;
        private OpenZFSFileSystemConfiguration _openZFSConfiguration;
        private string _ownerId;
        private string _resourceARN;
        private int? _storageCapacity;
        private StorageType _storageType;
        private List<string> _subnetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _vpcId;
        private WindowsFileSystemConfiguration _windowsConfiguration;

        /// <summary>
        /// Gets and sets the property AdministrativeActions. 
        /// <para>
        /// A list of administrative actions for the file system that are in process or waiting
        /// to be processed. Administrative actions describe changes to the Amazon FSx system
        /// that you have initiated using the <c>UpdateFileSystem</c> operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=50)]
        public List<AdministrativeAction> AdministrativeActions
        {
            get { return this._administrativeActions; }
            set { this._administrativeActions = value; }
        }

        // Check to see if AdministrativeActions property is set
        internal bool IsSetAdministrativeActions()
        {
            return this._administrativeActions != null && (this._administrativeActions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time that the file system was created, in seconds (since 1970-01-01T00:00:00Z),
        /// also known as Unix time.
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
        /// Gets and sets the property DNSName. 
        /// <para>
        /// The Domain Name System (DNS) name for the file system.
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
        /// </summary>
        public FileSystemFailureDetails FailureDetails
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
        /// Gets and sets the property FileSystemId. 
        /// <para>
        /// The system-generated, unique 17-digit ID of the file system.
        /// </para>
        /// </summary>
        [AWSProperty(Min=11, Max=21)]
        public string FileSystemId
        {
            get { return this._fileSystemId; }
            set { this._fileSystemId = value; }
        }

        // Check to see if FileSystemId property is set
        internal bool IsSetFileSystemId()
        {
            return this._fileSystemId != null;
        }

        /// <summary>
        /// Gets and sets the property FileSystemType. 
        /// <para>
        /// The type of Amazon FSx file system, which can be <c>LUSTRE</c>, <c>WINDOWS</c>, <c>ONTAP</c>,
        /// or <c>OPENZFS</c>.
        /// </para>
        /// </summary>
        public FileSystemType FileSystemType
        {
            get { return this._fileSystemType; }
            set { this._fileSystemType = value; }
        }

        // Check to see if FileSystemType property is set
        internal bool IsSetFileSystemType()
        {
            return this._fileSystemType != null;
        }

        /// <summary>
        /// Gets and sets the property FileSystemTypeVersion. 
        /// <para>
        /// The Lustre version of the Amazon FSx for Lustre file system, which can be <c>2.10</c>,
        /// <c>2.12</c>, or <c>2.15</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public string FileSystemTypeVersion
        {
            get { return this._fileSystemTypeVersion; }
            set { this._fileSystemTypeVersion = value; }
        }

        // Check to see if FileSystemTypeVersion property is set
        internal bool IsSetFileSystemTypeVersion()
        {
            return this._fileSystemTypeVersion != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ID of the Key Management Service (KMS) key used to encrypt Amazon FSx file system
        /// data. Used as follows with Amazon FSx file system types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Amazon FSx for Lustre <c>PERSISTENT_1</c> and <c>PERSISTENT_2</c> deployment types
        /// only.
        /// </para>
        ///  
        /// <para>
        ///  <c>SCRATCH_1</c> and <c>SCRATCH_2</c> types are encrypted using the Amazon FSx service
        /// KMS key for your account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon FSx for NetApp ONTAP
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon FSx for OpenZFS
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon FSx for Windows File Server
        /// </para>
        ///  </li> </ul>
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
        /// The lifecycle status of the file system. The following are the possible values and
        /// what they mean:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AVAILABLE</c> - The file system is in a healthy state, and is reachable and available
        /// for use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATING</c> - Amazon FSx is creating the new file system.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c> - Amazon FSx is deleting an existing file system.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> - An existing file system has experienced an unrecoverable failure.
        /// When creating a new file system, Amazon FSx was unable to create the file system.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MISCONFIGURED</c> - The file system is in a failed but recoverable state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MISCONFIGURED_UNAVAILABLE</c> - (Amazon FSx for Windows File Server only) The
        /// file system is currently unavailable due to a change in your Active Directory configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATING</c> - The file system is undergoing a customer-initiated update.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public FileSystemLifecycle Lifecycle
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
        /// </summary>
        public LustreFileSystemConfiguration LustreConfiguration
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
        /// <para>
        /// The IDs of the elastic network interfaces from which a specific file system is accessible.
        /// The elastic network interface is automatically created in the same virtual private
        /// cloud (VPC) that the Amazon FSx file system was created in. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-eni.html">Elastic
        /// Network Interfaces</a> in the <i>Amazon EC2 User Guide.</i> 
        /// </para>
        ///  
        /// <para>
        /// For an Amazon FSx for Windows File Server file system, you can have one network interface
        /// ID. For an Amazon FSx for Lustre file system, you can have more than one.
        /// </para>
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
        /// Gets and sets the property NetworkType. 
        /// <para>
        /// The network type of the file system.
        /// </para>
        /// </summary>
        public NetworkType NetworkType
        {
            get { return this._networkType; }
            set { this._networkType = value; }
        }

        // Check to see if NetworkType property is set
        internal bool IsSetNetworkType()
        {
            return this._networkType != null;
        }

        /// <summary>
        /// Gets and sets the property OntapConfiguration. 
        /// <para>
        /// The configuration for this Amazon FSx for NetApp ONTAP file system.
        /// </para>
        /// </summary>
        public OntapFileSystemConfiguration OntapConfiguration
        {
            get { return this._ontapConfiguration; }
            set { this._ontapConfiguration = value; }
        }

        // Check to see if OntapConfiguration property is set
        internal bool IsSetOntapConfiguration()
        {
            return this._ontapConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property OpenZFSConfiguration. 
        /// <para>
        /// The configuration for this Amazon FSx for OpenZFS file system.
        /// </para>
        /// </summary>
        public OpenZFSFileSystemConfiguration OpenZFSConfiguration
        {
            get { return this._openZFSConfiguration; }
            set { this._openZFSConfiguration = value; }
        }

        // Check to see if OpenZFSConfiguration property is set
        internal bool IsSetOpenZFSConfiguration()
        {
            return this._openZFSConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The Amazon Web Services account that created the file system. If the file system was
        /// created by a user in IAM Identity Center, the Amazon Web Services account to which
        /// the IAM user belongs is the owner.
        /// </para>
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
        /// <para>
        /// The Amazon Resource Name (ARN) of the file system resource.
        /// </para>
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
        /// The storage capacity of the file system in gibibytes (GiB).
        /// </para>
        ///  
        /// <para>
        /// Amazon FSx responds with an HTTP status code 400 (Bad Request) if the value of <c>StorageCapacity</c>
        /// is outside of the minimum or maximum values.
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
        /// Gets and sets the property StorageType. 
        /// <para>
        /// The type of storage the file system is using.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If set to <c>SSD</c>, the file system uses solid state drive storage.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If set to <c>HDD</c>, the file system uses hard disk drive storage.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If set to <c>INTELLIGENT_TIERING</c>, the file system uses fully elastic, intelligently-tiered
        /// storage.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public StorageType StorageType
        {
            get { return this._storageType; }
            set { this._storageType = value; }
        }

        // Check to see if StorageType property is set
        internal bool IsSetStorageType()
        {
            return this._storageType != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// Specifies the IDs of the subnets that the file system is accessible from. For the
        /// Amazon FSx Windows and ONTAP <c>MULTI_AZ_1</c> file system deployment type, there
        /// are two subnet IDs, one for the preferred file server and one for the standby file
        /// server. The preferred file server subnet identified in the <c>PreferredSubnetID</c>
        /// property. All other file systems have only one subnet ID.
        /// </para>
        ///  
        /// <para>
        /// For FSx for Lustre file systems, and Single-AZ Windows file systems, this is the ID
        /// of the subnet that contains the file system's endpoint. For <c>MULTI_AZ_1</c> Windows
        /// and ONTAP file systems, the file system endpoint is available in the <c>PreferredSubnetID</c>.
        /// </para>
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to associate with the file system. For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/LustreGuide/tag-resources.html">Tagging
        /// your Amazon FSx resources</a> in the <i>Amazon FSx for Lustre User Guide</i>.
        /// </para>
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

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the primary virtual private cloud (VPC) for the file system.
        /// </para>
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

        /// <summary>
        /// Gets and sets the property WindowsConfiguration. 
        /// <para>
        /// The configuration for this Amazon FSx for Windows File Server file system.
        /// </para>
        /// </summary>
        public WindowsFileSystemConfiguration WindowsConfiguration
        {
            get { return this._windowsConfiguration; }
            set { this._windowsConfiguration = value; }
        }

        // Check to see if WindowsConfiguration property is set
        internal bool IsSetWindowsConfiguration()
        {
            return this._windowsConfiguration != null;
        }

    }
}