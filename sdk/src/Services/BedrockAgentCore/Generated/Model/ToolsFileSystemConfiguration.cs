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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
        private EfsConfiguration _efsConfiguration;
        private S3FilesConfiguration _s3FilesConfiguration;

        /// <summary>
        /// Gets and sets the property EfsConfiguration. 
        /// <para>
        /// The configuration for mounting your own Amazon Elastic File System (Amazon EFS) access
        /// point into the session.
        /// </para>
        /// </summary>
        public EfsConfiguration EfsConfiguration
        {
            get { return this._efsConfiguration; }
            set { this._efsConfiguration = value; }
        }

        // Check to see if EfsConfiguration property is set
        internal bool IsSetEfsConfiguration()
        {
            return this._efsConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property S3FilesConfiguration. 
        /// <para>
        /// The configuration for mounting your own Amazon Simple Storage Service (Amazon S3)
        /// Files access point into the session.
        /// </para>
        /// </summary>
        public S3FilesConfiguration S3FilesConfiguration
        {
            get { return this._s3FilesConfiguration; }
            set { this._s3FilesConfiguration = value; }
        }

        // Check to see if S3FilesConfiguration property is set
        internal bool IsSetS3FilesConfiguration()
        {
            return this._s3FilesConfiguration != null;
        }

    }
}