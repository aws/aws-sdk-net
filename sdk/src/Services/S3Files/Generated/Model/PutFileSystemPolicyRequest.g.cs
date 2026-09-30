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

namespace Amazon.S3Files.Model
{
    /// <summary>
    /// Container for the parameters to the PutFileSystemPolicy operation. Creates or replaces
    /// the IAM resource policy for an S3 File System to control access permissions.
    /// </summary>
    public partial class PutFileSystemPolicyRequest : AmazonS3FilesRequest
    {
        /// <summary>
        /// Gets and sets the property FileSystemId. 
        /// <para>
        /// The ID or Amazon Resource Name (ARN) of the S3 File System to apply the resource policy
        /// to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 128)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// Checks to see if the FileSystemId property is set.
        /// </summary>
        internal bool IsSetFileSystemId() => this.FileSystemId != null;

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// The JSON-formatted resource policy to apply to the file system. The policy defines
        /// the permissions for accessing the file system. The policy must be a valid JSON document
        /// that follows IAM policy syntax.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Policy { get; set; }

        /// <summary>
        /// Checks to see if the Policy property is set.
        /// </summary>
        internal bool IsSetPolicy() => this.Policy != null;
    }
}
