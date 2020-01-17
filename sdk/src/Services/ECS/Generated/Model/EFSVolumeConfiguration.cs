/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECS.Model
{
    /// <summary>
    /// This parameter is specified when you are using an Amazon Elastic File System (Amazon
    /// EFS) file storage. Amazon EFS file systems are only supported when you are using the
    /// EC2 launch type.
    /// 
    ///  <important> 
    /// <para>
    ///  <code>EFSVolumeConfiguration</code> remains in preview and is a Beta Service as defined
    /// by and subject to the Beta Service Participation Service Terms located at <a href="https://aws.amazon.com/service-terms">https://aws.amazon.com/service-terms</a>
    /// ("Beta Terms"). These Beta Terms apply to your participation in this preview of <code>EFSVolumeConfiguration</code>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class EFSVolumeConfiguration
    {
        private string _fileSystemId;
        private string _rootDirectory;

        /// <summary>
        /// Gets and sets the property FileSystemId. 
        /// <para>
        /// The Amazon EFS file system ID to use.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FileSystemId
        {
            get { return this._fileSystemId; }
            set { this._fileSystemId = value; }
        }

        // Check to see if FileSystemId property is set
        internal bool IsSetFileSystemId()
        {
            return this._fileSystemId != null;
        }

        /// <summary>
        /// Gets and sets the property RootDirectory. 
        /// <para>
        /// The directory within the Amazon EFS file system to mount as the root directory inside
        /// the host.
        /// </para>
        /// </summary>
        public string RootDirectory
        {
            get { return this._rootDirectory; }
            set { this._rootDirectory = value; }
        }

        // Check to see if RootDirectory property is set
        internal bool IsSetRootDirectory()
        {
            return this._rootDirectory != null;
        }

    }
}