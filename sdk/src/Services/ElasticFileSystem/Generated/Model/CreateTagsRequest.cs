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
 * Do not modify this file. This file is generated from the elasticfilesystem-2015-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticFileSystem.Model
{
    /// <summary>
    /// Container for the parameters to the CreateTags operation.
    /// Creates or overwrites tags associated with a file system. Each tag is a key-value
    /// pair. If a tag key specified in the request already exists on the file system, this
    /// operation overwrites its value with the value provided in the request. If you add
    /// the <code>Name</code> tag to your file system, Amazon EFS returns it in the response
    /// to the <a>DescribeFileSystems</a> operation. 
    /// 
    ///  
    /// <para>
    /// This operation requires permission for the <code>elasticfilesystem:CreateTags</code>
    /// action.
    /// </para>
    /// </summary>
    public partial class CreateTagsRequest : AmazonElasticFileSystemRequest
    {
        private string _fileSystemId;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property FileSystemId. 
        /// <para>
        /// ID of the file system whose tags you want to modify (String). This operation modifies
        /// the tags only, not the file system.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Array of <code>Tag</code> objects to add. Each <code>Tag</code> object is a key-value
        /// pair. 
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}