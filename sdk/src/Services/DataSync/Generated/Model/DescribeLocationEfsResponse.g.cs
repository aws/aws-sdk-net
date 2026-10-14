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
    /// This is the response object from the DescribeLocationEfs operation.
    /// </summary>
    public partial class DescribeLocationEfsResponse : AmazonWebServiceResponse
    {
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
        [AWSProperty(Min = 0, Max = 128)]
        public string AccessPointArn { get; set; }

        /// <summary>
        /// Checks to see if the AccessPointArn property is set.
        /// </summary>
        internal bool IsSetAccessPointArn() => this.AccessPointArn != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time that the location was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Ec2Config.
        /// </summary>
        public Ec2Config Ec2Config { get; set; }

        /// <summary>
        /// Checks to see if the Ec2Config property is set.
        /// </summary>
        internal bool IsSetEc2Config() => this.Ec2Config != null;

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
        [AWSProperty(Min = 0, Max = 2048)]
        public string FileSystemAccessRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the FileSystemAccessRoleArn property is set.
        /// </summary>
        internal bool IsSetFileSystemAccessRoleArn() => this.FileSystemAccessRoleArn != null;

        /// <summary>
        /// Gets and sets the property InTransitEncryption. 
        /// <para>
        /// Indicates whether DataSync uses Transport Layer Security (TLS) encryption when transferring
        /// data to or from the Amazon EFS file system.
        /// </para>
        /// </summary>
        public EfsInTransitEncryption InTransitEncryption { get; set; }

        /// <summary>
        /// Checks to see if the InTransitEncryption property is set.
        /// </summary>
        internal bool IsSetInTransitEncryption() => this.InTransitEncryption != null;

        /// <summary>
        /// Gets and sets the property LocationArn. 
        /// <para>
        /// The ARN of the Amazon EFS file system location.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string LocationArn { get; set; }

        /// <summary>
        /// Checks to see if the LocationArn property is set.
        /// </summary>
        internal bool IsSetLocationArn() => this.LocationArn != null;

        /// <summary>
        /// Gets and sets the property LocationUri. 
        /// <para>
        /// The URL of the Amazon EFS file system location.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4360)]
        public string LocationUri { get; set; }

        /// <summary>
        /// Checks to see if the LocationUri property is set.
        /// </summary>
        internal bool IsSetLocationUri() => this.LocationUri != null;
    }
}
