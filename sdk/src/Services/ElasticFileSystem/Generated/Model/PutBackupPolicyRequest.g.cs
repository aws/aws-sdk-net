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

namespace Amazon.ElasticFileSystem.Model
{
    /// <summary>
    /// Container for the parameters to the PutBackupPolicy operation. Updates the file system's
    /// backup policy. Use this action to start or stop automatic backups of the file system.
    /// </summary>
    public partial class PutBackupPolicyRequest : AmazonElasticFileSystemRequest
    {
        /// <summary>
        /// Gets and sets the property BackupPolicy. 
        /// <para>
        /// The backup policy included in the <c>PutBackupPolicy</c> request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public BackupPolicy BackupPolicy { get; set; }

        /// <summary>
        /// Checks to see if the BackupPolicy property is set.
        /// </summary>
        internal bool IsSetBackupPolicy() => this.BackupPolicy != null;

        /// <summary>
        /// Gets and sets the property FileSystemId. 
        /// <para>
        /// Specifies which EFS file system to update the backup policy for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 128)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// Checks to see if the FileSystemId property is set.
        /// </summary>
        internal bool IsSetFileSystemId() => this.FileSystemId != null;
    }
}
