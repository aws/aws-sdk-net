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
    public partial class DescribeKeyValueStoreResponse : AmazonWebServiceResponse
    {
        private DateTime? _created;
        private string _eTag;
        private string _failureReason;
        private int? _itemCount;
        private string _kvsARN;
        private DateTime? _lastModified;
        private string _status;
        private long? _totalSizeInBytes;

        /// <summary>
        /// Gets and sets the property Created. 
        /// <para>
        /// Date and time when the Key Value Store was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? Created
        {
            get { return this._created; }
            set { this._created = value; }
        }

        // Check to see if Created property is set
        internal bool IsSetCreated()
        {
            return this._created.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ETag. 
        /// <para>
        /// The version identifier for the current version of the Key Value Store.
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
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason for Key Value Store creation failure.
        /// </para>
        /// </summary>
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property ItemCount. 
        /// <para>
        /// Number of key value pairs in the Key Value Store.
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
        /// Gets and sets the property KvsARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Key Value Store.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string KvsARN
        {
            get { return this._kvsARN; }
            set { this._kvsARN = value; }
        }

        // Check to see if KvsARN property is set
        internal bool IsSetKvsARN()
        {
            return this._kvsARN != null;
        }

        /// <summary>
        /// Gets and sets the property LastModified. 
        /// <para>
        /// Date and time when the key value pairs in the Key Value Store was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModified
        {
            get { return this._lastModified; }
            set { this._lastModified = value; }
        }

        // Check to see if LastModified property is set
        internal bool IsSetLastModified()
        {
            return this._lastModified.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the Key Value Store.
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TotalSizeInBytes. 
        /// <para>
        /// Total size of the Key Value Store in bytes.
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