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
    /// Container for the parameters to the PutKey operation.
    /// Creates a new key value pair or replaces the value of an existing key.
    /// </summary>
    public partial class PutKeyRequest : AmazonCloudFrontKeyValueStoreRequest
    {
        private string _ifMatch;
        private string _key;
        private string _kvsARN;
        private string _value;

        /// <summary>
        /// Gets and sets the property IfMatch. 
        /// <para>
        /// The current version (ETag) of the Key Value Store that you are putting keys into,
        /// which you can get using DescribeKeyValueStore.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IfMatch
        {
            get { return this._ifMatch; }
            set { this._ifMatch = value; }
        }

        // Check to see if IfMatch property is set
        internal bool IsSetIfMatch()
        {
            return this._ifMatch != null;
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The key to put.
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
        /// Gets and sets the property Value. 
        /// <para>
        /// The value to put.
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