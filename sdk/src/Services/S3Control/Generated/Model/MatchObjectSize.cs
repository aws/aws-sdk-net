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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
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
namespace Amazon.S3Control.Model
{
    /// <summary>
    /// A filter condition that specifies the object size range of included objects in bytes.
    /// Only integers are supported.
    /// </summary>
    public partial class MatchObjectSize
    {
        private long? _bytesGreaterThan;
        private long? _bytesLessThan;

        /// <summary>
        /// Gets and sets the property BytesGreaterThan. 
        /// <para>
        ///  Specifies the minimum object size in Bytes. The value must be a positive number,
        /// greater than 0 and less than 5 TB. 
        /// </para>
        /// </summary>
        public long? BytesGreaterThan
        {
            get { return this._bytesGreaterThan; }
            set { this._bytesGreaterThan = value; }
        }

        // Check to see if BytesGreaterThan property is set
        internal bool IsSetBytesGreaterThan()
        {
            return this._bytesGreaterThan.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BytesLessThan. 
        /// <para>
        ///  Specifies the maximum object size in Bytes. The value must be a positive number,
        /// greater than the minimum object size and less than 5 TB. 
        /// </para>
        /// </summary>
        public long? BytesLessThan
        {
            get { return this._bytesLessThan; }
            set { this._bytesLessThan = value; }
        }

        // Check to see if BytesLessThan property is set
        internal bool IsSetBytesLessThan()
        {
            return this._bytesLessThan.HasValue; 
        }

    }
}