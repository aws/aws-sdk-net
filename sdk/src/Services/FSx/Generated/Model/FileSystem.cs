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

namespace Amazon.FSx.Model
{
    /// <summary>
    /// A description of a specific Amazon FSx file system.
    /// </summary>
    public partial class FileSystem
    {
        private List<AdministrativeAction> _administrativeActions = new List<AdministrativeAction>();
        private DateTime? _creationTime;
        private string _dnsName;
        private FileSystemFailureDetails _failureDetails;
        private string _fileSystemId;
        private FileSystemType _fileSystemType;
        private string _kmsKeyId;
        private FileSystemLifecycle _lifecycle;
        private LustreFileSystemConfiguration _lustreConfiguration;
        private List<string> _networkInterfaceIds = new List<string>();
        private string _ownerId;
        private string _resourceARN;
        private int? _storageCapacity;
        private StorageType _storageType;
        private List<string> _subnetIds = new List<string>();
        private List<Tag> _tags = new List<Tag>();
        private string _vpcId;
        private WindowsFileSystemConfiguration _windowsConfiguration;

        /// <summary>
        /// Gets and sets the property AdministrativeActions. 
        /// <para>
        /// A list of administrative actions for the file system that are in process or waiting
        /// to be processed. Administrative actions describe changes to the Windows file system
        /// that you have initiated using the <code>UpdateFileSystem</code> action. 
        /// </para>
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
            return this._administrativeActions != null && this._administrativeActions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time that the file system was created, in seconds (since 1970-01-01T00:00:00Z),
        /// also known as Unix time.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
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
        /// The DNS name for the file system.
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
        /// The type of Amazon FSx file system, either <code>LUSTRE</code> or <code>WINDOWS</code>.
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
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ID of the AWS Key Management Service (AWS KMS) key used to encrypt the file system's
        /// data for Amazon FSx for Windows File Server file systems and persistent Amazon FSx
        /// for Lustre file systems at rest. In either case, if not specified, the Amazon FSx
        /// managed key is used. The scratch Amazon FSx for Lustre file systems are always encrypted
        /// at rest using Amazon FSx managed keys. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_Encrypt.html">Encrypt</a>
        /// in the <i>AWS Key Management Service API Reference</i>.
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
        /// The lifecycle status of the file system, following are the possible values and what
        /// they mean:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>AVAILABLE</code> - The file system is in a healthy state, and is reachable
        /// and available for use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CREATING</code> - Amazon FSx is creating the new file system.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DELETING</code> - Amazon FSx is deleting an existing file system.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FAILED</code> - An existing file system has experienced an unrecoverable failure.
        /// When creating a new file system, Amazon FSx was unable to create the file system.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MISCONFIGURED</code> indicates that the file system is in a failed but recoverable
        /// state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UPDATING</code> indicates that the file system is undergoing a customer initiated
        /// update.
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
        /// The IDs of the elastic network interface from which a specific file system is accessible.
        /// The elastic network interface is automatically created in the same VPC that the Amazon
        /// FSx file system was created in. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-eni.html">Elastic
        /// Network Interfaces</a> in the <i>Amazon EC2 User Guide.</i> 
        /// </para>
        ///  
        /// <para>
        /// For an Amazon FSx for Windows File Server file system, you can have one network interface
        /// ID. For an Amazon FSx for Lustre file system, you can have more than one.
        /// </para>
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
            return this._networkInterfaceIds != null && this._networkInterfaceIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The AWS account that created the file system. If the file system was created by an
        /// AWS Identity and Access Management (IAM) user, the AWS account to which the IAM user
        /// belongs is the owner.
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
        /// The Amazon Resource Name (ARN) for the file system resource.
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
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int StorageCapacity
        {
            get { return this._storageCapacity.GetValueOrDefault(); }
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
        /// The storage type of the file system. Valid values are <code>SSD</code> and <code>HDD</code>.
        /// If set to <code>SSD</code>, the file system uses solid state drive storage. If set
        /// to <code>HDD</code>, the file system uses hard disk drive storage. 
        /// </para>
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
        /// Specifies the IDs of the subnets that the file system is accessible from. For Windows
        /// <code>MULTI_AZ_1</code> file system deployment type, there are two subnet IDs, one
        /// for the preferred file server and one for the standby file server. The preferred file
        /// server subnet identified in the <code>PreferredSubnetID</code> property. All other
        /// file systems have only one subnet ID.
        /// </para>
        ///  
        /// <para>
        /// For Lustre file systems, and Single-AZ Windows file systems, this is the ID of the
        /// subnet that contains the endpoint for the file system. For <code>MULTI_AZ_1</code>
        /// Windows file systems, the endpoint for the file system is available in the <code>PreferredSubnetID</code>.
        /// </para>
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
            return this._subnetIds != null && this._subnetIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to associate with the file system. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tagging
        /// Your Amazon EC2 Resources</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
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
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the primary VPC for the file system.
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
        /// The configuration for this Microsoft Windows file system.
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