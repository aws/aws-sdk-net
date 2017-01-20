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
    /// Container for the parameters to the DescribeTags operation.
    /// Returns the tags associated with a file system. The order of tags returned in the
    /// response of one <code>DescribeTags</code> call and the order of tags returned across
    /// the responses of a multi-call iteration (when using pagination) is unspecified. 
    /// 
    ///  
    /// <para>
    ///  This operation requires permissions for the <code>elasticfilesystem:DescribeTags</code>
    /// action. 
    /// </para>
    /// </summary>
    public partial class DescribeTagsRequest : AmazonElasticFileSystemRequest
    {
        private string _fileSystemId;
        private string _marker;
        private int? _maxItems;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DescribeTagsRequest() { }

        /// <summary>
        /// Instantiates DescribeTagsRequest with the parameterized properties
        /// </summary>
        /// <param name="fileSystemId">ID of the file system whose tag set you want to retrieve.</param>
        public DescribeTagsRequest(string fileSystemId)
        {
            _fileSystemId = fileSystemId;
        }

        /// <summary>
        /// Gets and sets the property FileSystemId. 
        /// <para>
        /// ID of the file system whose tag set you want to retrieve.
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
        /// Gets and sets the property Marker. 
        /// <para>
        /// (Optional) Opaque pagination token returned from a previous <code>DescribeTags</code>
        /// operation (String). If present, it specifies to continue the list from where the previous
        /// call left off.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// (Optional) Maximum number of file system tags to return in the response. It must be
        /// an integer with a value greater than zero.
        /// </para>
        /// </summary>
        public int MaxItems
        {
            get { return this._maxItems.GetValueOrDefault(); }
            set { this._maxItems = value; }
        }

        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this._maxItems.HasValue; 
        }

    }
}