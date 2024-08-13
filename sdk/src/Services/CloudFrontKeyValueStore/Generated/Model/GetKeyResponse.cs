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
    /// A key value pair.
    /// </summary>
    public partial class GetKeyResponse : AmazonWebServiceResponse
    {
        private int? _itemCount;
        private string _key;
        private long? _totalSizeInBytes;
        private string _value;

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
        /// Gets and sets the property Key. 
        /// <para>
        /// The key of the key value pair.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
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

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of the key value pair.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}