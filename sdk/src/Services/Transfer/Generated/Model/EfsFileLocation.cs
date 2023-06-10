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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Specifies the details for the file location for the file that's being used in the
    /// workflow. Only applicable if you are using Amazon Elastic File Systems (Amazon EFS)
    /// for storage.
    /// 
    ///  
    /// <para>
    ///  
    /// </para>
    /// </summary>
    public partial class EfsFileLocation
    {
        private string _fileSystemId;
        private string _path;

        /// <summary>
        /// Gets and sets the property FileSystemId. 
        /// <para>
        /// The identifier of the file system, assigned by Amazon EFS.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
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
        /// Gets and sets the property Path. 
        /// <para>
        /// The pathname for the folder being used by a workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=65536)]
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }

    }
}