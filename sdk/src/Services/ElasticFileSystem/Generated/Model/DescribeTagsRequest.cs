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
 * Do not modify this file. This file is generated from the elasticfilesystem-2015-02-01.normal.json service model.
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
    /// Container for the parameters to the DescribeTags operation.
    /// <note> 
    /// <para>
    /// DEPRECATED - The <c>DescribeTags</c> action is deprecated and not maintained. To view
    /// tags associated with EFS resources, use the <c>ListTagsForResource</c> API action.
    /// </para>
    ///  </note> 
    /// <para>
    /// Returns the tags associated with a file system. The order of tags returned in the
    /// response of one <c>DescribeTags</c> call and the order of tags returned across the
    /// responses of a multiple-call iteration (when using pagination) is unspecified. 
    /// </para>
    ///  
    /// <para>
    ///  This operation requires permissions for the <c>elasticfilesystem:DescribeTags</c>
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
        /// <param name="fileSystemId">The ID of the file system whose tag set you want to retrieve.</param>
        public DescribeTagsRequest(string fileSystemId)
        {
            _fileSystemId = fileSystemId;
        }

        /// <summary>
        /// Gets and sets the property FileSystemId. 
        /// <para>
        /// The ID of the file system whose tag set you want to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=128)]
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
        /// (Optional) An opaque pagination token returned from a previous <c>DescribeTags</c>
        /// operation (String). If present, it specifies to continue the list from where the previous
        /// call left off.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// (Optional) The maximum number of file system tags to return in the response. Currently,
        /// this number is automatically set to 100, and other values are ignored. The response
        /// is paginated at 100 per page if you have more than 100 tags.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? MaxItems
        {
            get { return this._maxItems; }
            set { this._maxItems = value; }
        }

        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this._maxItems.HasValue; 
        }

    }
}