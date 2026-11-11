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

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Describes Network File System (NFS) file share default values. Files and folders stored
    /// as Amazon S3 objects in S3 buckets don't, by default, have Unix file permissions assigned
    /// to them. Upon discovery in an S3 bucket by Storage Gateway, the S3 objects that represent
    /// files and folders are assigned these default Unix permissions. This operation is only
    /// supported for S3 File Gateways.
    /// </summary>
    public partial class NFSFileShareDefaults
    {
        /// <summary>
        /// Gets and sets the property DirectoryMode. 
        /// <para>
        /// The Unix directory mode in the form "nnnn". For example, <c>0666</c> represents the
        /// default access mode for all directories inside the file share. The default value is
        /// <c>0777</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4)]
        public string DirectoryMode { get; set; }

        /// <summary>
        /// Checks to see if the DirectoryMode property is set.
        /// </summary>
        internal bool IsSetDirectoryMode() => this.DirectoryMode != null;

        /// <summary>
        /// Gets and sets the property FileMode. 
        /// <para>
        /// The Unix file mode in the form "nnnn". For example, <c>0666</c> represents the default
        /// file mode inside the file share. The default value is <c>0666</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4)]
        public string FileMode { get; set; }

        /// <summary>
        /// Checks to see if the FileMode property is set.
        /// </summary>
        internal bool IsSetFileMode() => this.FileMode != null;

        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// The default group ID for the file share (unless the files have another group ID specified).
        /// The default value is <c>nfsnobody</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4294967294)]
        public long? GroupId { get; set; }

        /// <summary>
        /// Checks to see if the GroupId property is set.
        /// </summary>
        internal bool IsSetGroupId() => this.GroupId.HasValue;

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The default owner ID for files in the file share (unless the files have another owner
        /// ID specified). The default value is <c>nfsnobody</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4294967294)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId.HasValue;
    }
}
