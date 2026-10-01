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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// Specifies a file system to mount into the session by providing exactly one of the
    /// following:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <c>s3FilesConfiguration</c> - Mounts an Amazon Simple Storage Service (Amazon S3)
    /// Files access point.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>efsConfiguration</c> - Mounts an Amazon Elastic File System (Amazon EFS) access
    /// point.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ToolsFileSystemConfiguration
    {
        /// <summary>
        /// Gets and sets the property EfsConfiguration. 
        /// <para>
        /// The configuration for mounting your own Amazon Elastic File System (Amazon EFS) access
        /// point into the session.
        /// </para>
        /// </summary>
        public EfsConfiguration EfsConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EfsConfiguration property is set.
        /// </summary>
        internal bool IsSetEfsConfiguration() => this.EfsConfiguration != null;

        /// <summary>
        /// Gets and sets the property S3FilesConfiguration. 
        /// <para>
        /// The configuration for mounting your own Amazon Simple Storage Service (Amazon S3)
        /// Files access point into the session.
        /// </para>
        /// </summary>
        public S3FilesConfiguration S3FilesConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the S3FilesConfiguration property is set.
        /// </summary>
        internal bool IsSetS3FilesConfiguration() => this.S3FilesConfiguration != null;
    }
}
