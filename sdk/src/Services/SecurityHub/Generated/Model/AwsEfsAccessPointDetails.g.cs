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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides information about an Amazon EFS access point.
    /// </summary>
    public partial class AwsEfsAccessPointDetails
    {
        /// <summary>
        /// Gets and sets the property AccessPointId. 
        /// <para>
        /// The ID of the Amazon EFS access point. 
        /// </para>
        /// </summary>
        public string AccessPointId { get; set; }

        /// <summary>
        /// Checks to see if the AccessPointId property is set.
        /// </summary>
        internal bool IsSetAccessPointId() => this.AccessPointId != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon EFS access point. 
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The opaque string specified in the request to ensure idempotent creation. 
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property FileSystemId. 
        /// <para>
        /// The ID of the Amazon EFS file system that the access point applies to. 
        /// </para>
        /// </summary>
        public string FileSystemId { get; set; }

        /// <summary>
        /// Checks to see if the FileSystemId property is set.
        /// </summary>
        internal bool IsSetFileSystemId() => this.FileSystemId != null;

        /// <summary>
        /// Gets and sets the property PosixUser. 
        /// <para>
        /// The full POSIX identity, including the user ID, group ID, and secondary group IDs
        /// on the access point, that is used for all file operations by NFS clients using the
        /// access point. 
        /// </para>
        /// </summary>
        public AwsEfsAccessPointPosixUserDetails PosixUser { get; set; }

        /// <summary>
        /// Checks to see if the PosixUser property is set.
        /// </summary>
        internal bool IsSetPosixUser() => this.PosixUser != null;

        /// <summary>
        /// Gets and sets the property RootDirectory. 
        /// <para>
        /// The directory on the Amazon EFS file system that the access point exposes as the root
        /// directory to NFS clients using the access point. 
        /// </para>
        /// </summary>
        public AwsEfsAccessPointRootDirectoryDetails RootDirectory { get; set; }

        /// <summary>
        /// Checks to see if the RootDirectory property is set.
        /// </summary>
        internal bool IsSetRootDirectory() => this.RootDirectory != null;
    }
}
