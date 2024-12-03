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
    /// DescribeLocationEfsResponse
    /// </summary>
    public partial class DescribeLocationEfsResponse : AmazonWebServiceResponse
    {
        private string _accessPointArn;
        private DateTime? _creationTime;
        private Ec2Config _ec2Config;
        private string _fileSystemAccessRoleArn;
        private EfsInTransitEncryption _inTransitEncryption;
        private string _locationArn;
        private string _locationUri;

        /// <summary>
        /// Gets and sets the property AccessPointArn. 
        /// <para>
        /// The ARN of the access point that DataSync uses to access the Amazon EFS file system.
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
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time that the location was created.
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
        /// Gets and sets the property Ec2Config.
        /// </summary>
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
        /// Gets and sets the property FileSystemAccessRoleArn. 
        /// <para>
        /// The Identity and Access Management (IAM) role that allows DataSync to access your
        /// Amazon EFS file system.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-efs-location.html#create-efs-location-iam-role">Creating
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
        /// Indicates whether DataSync uses Transport Layer Security (TLS) encryption when transferring
        /// data to or from the Amazon EFS file system.
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
        /// The ARN of the Amazon EFS file system location.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
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
        /// Gets and sets the property LocationUri. 
        /// <para>
        /// The URL of the Amazon EFS file system location.
        /// </para>
        /// </summary>
        [AWSProperty(Max=4360)]
        public string LocationUri
        {
            get { return this._locationUri; }
            set { this._locationUri = value; }
        }

        // Check to see if LocationUri property is set
        internal bool IsSetLocationUri()
        {
            return this._locationUri != null;
        }

    }
}