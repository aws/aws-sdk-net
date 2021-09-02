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
    /// Specifies the details for the file location for the file being used in the workflow.
    /// Only applicable if you are using Amazon EFS for storage.
    /// 
    ///  
    /// <para>
    ///  You need to provide the file system ID and the pathname. The pathname can represent
    /// either a path or a file. This is determined by whether or not you end the path value
    /// with the forward slash (/) character. If the final character is "/", then your file
    /// is copied to the folder, and its name does not change. If, rather, the final character
    /// is alphanumeric, your uploaded file is renamed to the path value. In this case, if
    /// a file with that name already exists, it is overwritten. 
    /// </para>
    ///  
    /// <para>
    /// For example, if your path is <code>shared-files/bob/</code>, your uploaded files are
    /// copied to the <code>shared-files/bob/</code>, folder. If your path is <code>shared-files/today</code>,
    /// each uploaded file is copied to the <code>shared-files</code> folder and named <code>today</code>:
    /// each upload overwrites the previous version of the <code>bob</code> file.
    /// </para>
    /// </summary>
    public partial class EfsFileLocation
    {
        private string _fileSystemId;
        private string _path;

        /// <summary>
        /// Gets and sets the property FileSystemId. 
        /// <para>
        /// The ID of the file system, assigned by Amazon EFS.
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
        [AWSProperty(Min=1, Max=100)]
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