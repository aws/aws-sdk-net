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
    /// Container for the parameters to the UpdateLocationEfs operation.
    /// Modifies the following configuration parameters of the Amazon EFS transfer location
    /// that you're using with DataSync.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-efs-location.html">Configuring
    /// DataSync transfers with Amazon EFS</a>.
    /// </para>
    /// </summary>
    public partial class UpdateLocationEfsRequest : AmazonDataSyncRequest
    {
        private string _accessPointArn;
        private string _fileSystemAccessRoleArn;
        private EfsInTransitEncryption _inTransitEncryption;
        private string _locationArn;
        private string _subdirectory;

        /// <summary>
        /// Gets and sets the property AccessPointArn. 
        /// <para>
        /// Specifies the Amazon Resource Name (ARN) of the access point that DataSync uses to
        /// mount your Amazon EFS file system.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-efs-location.html#create-efs-location-iam">Accessing
        /// restricted Amazon EFS file systems</a>.
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
        /// Gets and sets the property FileSystemAccessRoleArn. 
        /// <para>
        /// Specifies an Identity and Access Management (IAM) role that allows DataSync to access
        /// your Amazon EFS file system.
        /// </para>
        ///  
        /// <para>
        /// For information on creating this role, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-efs-location.html#create-efs-location-iam-role">Creating
        /// a DataSync IAM role for Amazon EFS file system access</a>.
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
        /// Gets and sets the property LocationArn. 
        /// <para>
        /// Specifies the Amazon Resource Name (ARN) of the Amazon EFS transfer location that
        /// you're updating.
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

    }
}