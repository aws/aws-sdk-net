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
    /// Container for the parameters to the CreateFileSystemFromBackup operation.
    /// Creates a new Amazon FSx file system from an existing Amazon FSx backup.
    /// 
    ///  
    /// <para>
    /// If a file system with the specified client request token exists and the parameters
    /// match, this operation returns the description of the file system. If a client request
    /// token specified by the file system exists and the parameters don't match, this call
    /// returns <code>IncompatibleParameterError</code>. If a file system with the specified
    /// client request token doesn't exist, this operation does the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Creates a new Amazon FSx file system from backup with an assigned ID, and an initial
    /// lifecycle state of <code>CREATING</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Returns the description of the file system.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Parameters like Active Directory, default share name, automatic backup, and backup
    /// settings default to the parameters of the file system that was backed up, unless overridden.
    /// You can explicitly supply other settings.
    /// </para>
    ///  
    /// <para>
    /// By using the idempotent operation, you can retry a <code>CreateFileSystemFromBackup</code>
    /// call without the risk of creating an extra file system. This approach can be useful
    /// when an initial call fails in a way that makes it unclear whether a file system was
    /// created. Examples are if a transport level timeout occurred, or your connection was
    /// reset. If you use the same client request token and the initial call created a file
    /// system, the client receives success as long as the parameters are the same.
    /// </para>
    ///  <note> 
    /// <para>
    /// The <code>CreateFileSystemFromBackup</code> call returns while the file system's lifecycle
    /// state is still <code>CREATING</code>. You can check the file-system creation status
    /// by calling the <a>DescribeFileSystems</a> operation, which returns the file system
    /// state along with other information.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateFileSystemFromBackupRequest : AmazonFSxRequest
    {
        private string _backupId;
        private string _clientRequestToken;
        private CreateFileSystemLustreConfiguration _lustreConfiguration;
        private List<string> _securityGroupIds = new List<string>();
        private StorageType _storageType;
        private List<string> _subnetIds = new List<string>();
        private List<Tag> _tags = new List<Tag>();
        private CreateFileSystemWindowsConfiguration _windowsConfiguration;

        /// <summary>
        /// Gets and sets the property BackupId.
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=128)]
        public string BackupId
        {
            get { return this._backupId; }
            set { this._backupId = value; }
        }

        // Check to see if BackupId property is set
        internal bool IsSetBackupId()
        {
            return this._backupId != null;
        }

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A string of up to 64 ASCII characters that Amazon FSx uses to ensure idempotent creation.
        /// This string is automatically filled on your behalf when you use the AWS Command Line
        /// Interface (AWS CLI) or an AWS SDK.
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
        /// Gets and sets the property LustreConfiguration.
        /// </summary>
        public CreateFileSystemLustreConfiguration LustreConfiguration
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
        /// A list of IDs for the security groups that apply to the specified network interfaces
        /// created for file system access. These security groups apply to all network interfaces.
        /// This value isn't returned in later DescribeFileSystem requests.
        /// </para>
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
            return this._securityGroupIds != null && this._securityGroupIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        /// Sets the storage type for the Windows file system you're creating from a backup. Valid
        /// values are <code>SSD</code> and <code>HDD</code>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Set to <code>SSD</code> to use solid state drive storage. Supported on all Windows
        /// deployment types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Set to <code>HDD</code> to use hard disk drive storage. Supported on <code>SINGLE_AZ_2</code>
        /// and <code>MULTI_AZ_1</code> Windows file system deployment types. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  Default value is <code>SSD</code>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// HDD and SSD storage types have different minimum storage capacity requirements. A
        /// restored file system's storage capacity is tied to the file system that was backed
        /// up. You can create a file system that uses HDD storage from a backup of a file system
        /// that used SSD storage only if the original SSD file system had a storage capacity
        /// of at least 2000 GiB. 
        /// </para>
        ///  </note>
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
        /// Specifies the IDs of the subnets that the file system will be accessible from. For
        /// Windows <code>MULTI_AZ_1</code> file system deployment types, provide exactly two
        /// subnet IDs, one for the preferred file server and one for the standby file server.
        /// You specify one of these subnets as the preferred subnet using the <code>WindowsConfiguration
        /// &gt; PreferredSubnetID</code> property.
        /// </para>
        ///  
        /// <para>
        /// For Windows <code>SINGLE_AZ_1</code> and <code>SINGLE_AZ_2</code> deployment types
        /// and Lustre file systems, provide exactly one subnet ID. The file server is launched
        /// in that subnet's Availability Zone.
        /// </para>
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
            return this._subnetIds != null && this._subnetIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to be applied to the file system at file system creation. The key value of
        /// the <code>Name</code> tag appears in the console as the file system name.
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
        /// Gets and sets the property WindowsConfiguration. 
        /// <para>
        /// The configuration for this Microsoft Windows file system.
        /// </para>
        /// </summary>
        public CreateFileSystemWindowsConfiguration WindowsConfiguration
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