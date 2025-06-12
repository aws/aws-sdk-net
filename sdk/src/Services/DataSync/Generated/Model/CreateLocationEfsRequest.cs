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
    /// Container for the parameters to the CreateLocationEfs operation.
    /// Creates a transfer <i>location</i> for an Amazon EFS file system. DataSync can use
    /// this location as a source or destination for transferring data.
    /// 
    ///  
    /// <para>
    /// Before you begin, make sure that you understand how DataSync <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-efs-location.html#create-efs-location-access">accesses
    /// Amazon EFS file systems</a>.
    /// </para>
    /// </summary>
    public partial class CreateLocationEfsRequest : AmazonDataSyncRequest
    {
        private string _accessPointArn;
        private Ec2Config _ec2Config;
        private string _efsFilesystemArn;
        private string _fileSystemAccessRoleArn;
        private EfsInTransitEncryption _inTransitEncryption;
        private string _subdirectory;
        private List<TagListEntry> _tags = AWSConfigs.InitializeCollections ? new List<TagListEntry>() : null;

        /// <summary>
        /// Gets and sets the property AccessPointArn. 
        /// <para>
        /// Specifies the Amazon Resource Name (ARN) of the access point that DataSync uses to
        /// mount your Amazon EFS file system.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-efs-location.html#create-efs-location-iam">Accessing
        /// restricted file systems</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
        public string AccessPointArn
        {
            get { return this._accessPointArn; }
            set { this._accessPointArn = value; }
        }

        // Check to see if AccessPointArn property is set
        internal bool IsSetAccessPointArn()
        {
            return this._accessPointArn != null;
        }

        /// <summary>
        /// Gets and sets the property Ec2Config. 
        /// <para>
        /// Specifies the subnet and security groups DataSync uses to connect to one of your Amazon
        /// EFS file system's <a href="https://docs.aws.amazon.com/efs/latest/ug/accessing-fs.html">mount
        /// targets</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Ec2Config Ec2Config
        {
            get { return this._ec2Config; }
            set { this._ec2Config = value; }
        }

        // Check to see if Ec2Config property is set
        internal bool IsSetEc2Config()
        {
            return this._ec2Config != null;
        }

        /// <summary>
        /// Gets and sets the property EfsFilesystemArn. 
        /// <para>
        /// Specifies the ARN for your Amazon EFS file system.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=128)]
        public string EfsFilesystemArn
        {
            get { return this._efsFilesystemArn; }
            set { this._efsFilesystemArn = value; }
        }

        // Check to see if EfsFilesystemArn property is set
        internal bool IsSetEfsFilesystemArn()
        {
            return this._efsFilesystemArn != null;
        }

        /// <summary>
        /// Gets and sets the property FileSystemAccessRoleArn. 
        /// <para>
        /// Specifies an Identity and Access Management (IAM) role that allows DataSync to access
        /// your Amazon EFS file system.
        /// </para>
        ///  
        /// <para>
        /// For information on creating this role, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-efs-location.html#create-efs-location-iam-role">Creating
        /// a DataSync IAM role for file system access</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string FileSystemAccessRoleArn
        {
            get { return this._fileSystemAccessRoleArn; }
            set { this._fileSystemAccessRoleArn = value; }
        }

        // Check to see if FileSystemAccessRoleArn property is set
        internal bool IsSetFileSystemAccessRoleArn()
        {
            return this._fileSystemAccessRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property InTransitEncryption. 
        /// <para>
        /// Specifies whether you want DataSync to use Transport Layer Security (TLS) 1.2 encryption
        /// when it transfers data to or from your Amazon EFS file system.
        /// </para>
        ///  
        /// <para>
        /// If you specify an access point using <c>AccessPointArn</c> or an IAM role using <c>FileSystemAccessRoleArn</c>,
        /// you must set this parameter to <c>TLS1_2</c>.
        /// </para>
        /// </summary>
        public EfsInTransitEncryption InTransitEncryption
        {
            get { return this._inTransitEncryption; }
            set { this._inTransitEncryption = value; }
        }

        // Check to see if InTransitEncryption property is set
        internal bool IsSetInTransitEncryption()
        {
            return this._inTransitEncryption != null;
        }

        /// <summary>
        /// Gets and sets the property Subdirectory. 
        /// <para>
        /// Specifies a mount path for your Amazon EFS file system. This is where DataSync reads
        /// or writes data on your file system (depending on if this is a source or destination
        /// location).
        /// </para>
        ///  
        /// <para>
        /// By default, DataSync uses the root directory (or <a href="https://docs.aws.amazon.com/efs/latest/ug/efs-access-points.html">access
        /// point</a> if you provide one by using <c>AccessPointArn</c>). You can also include
        /// subdirectories using forward slashes (for example, <c>/path/to/folder</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Max=4096)]
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
        /// Specifies the key-value pair that represents a tag that you want to add to the resource.
        /// The value can be an empty string. This value helps you manage, filter, and search
        /// for your resources. We recommend that you create a name tag for your location.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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