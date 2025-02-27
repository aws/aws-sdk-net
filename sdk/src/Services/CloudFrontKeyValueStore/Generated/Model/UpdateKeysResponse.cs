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
 * Do not modify this file. This file is generated from the cloudfront-keyvaluestore-2022-07-26.normal.json service model.
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
namespace Amazon.CloudFrontKeyValueStore.Model
{
    /// <summary>
    /// Metadata information about a Key Value Store.
    /// </summary>
    public partial class UpdateKeysResponse : AmazonWebServiceResponse
    {
        private string _eTag;
        private int? _itemCount;
        private long? _totalSizeInBytes;

        /// <summary>
        /// Gets and sets the property ETag. 
        /// <para>
        /// The current version identifier of the Key Value Store after the successful update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ETag
        {
            get { return this._eTag; }
            set { this._eTag = value; }
        }

        // Check to see if ETag property is set
        internal bool IsSetETag()
        {
            return this._eTag != null;
        }

        /// <summary>
        /// Gets and sets the property ItemCount. 
        /// <para>
        /// Number of key value pairs in the Key Value Store after the successful update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? ItemCount
        {
            get { return this._itemCount; }
            set { this._itemCount = value; }
        }

        // Check to see if ItemCount property is set
        internal bool IsSetItemCount()
        {
            return this._itemCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalSizeInBytes. 
        /// <para>
        /// Total size of the Key Value Store after the successful update, in bytes.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? TotalSizeInBytes
        {
            get { return this._totalSizeInBytes; }
            set { this._totalSizeInBytes = value; }
        }

        // Check to see if TotalSizeInBytes property is set
        internal bool IsSetTotalSizeInBytes()
        {
            return this._totalSizeInBytes.HasValue; 
        }

    }
}