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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
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
namespace Amazon.S3.Model
{
    /// <summary>
    /// This data type contains information about progress of an operation.
    /// </summary>
    public partial class Progress
    {
        private long? _bytesProcessed;
        private long? _bytesReturned;
        private long? _bytesScanned;

        /// <summary>
        /// Gets and sets the property BytesProcessed. 
        /// <para>
        /// The current number of uncompressed object bytes processed.
        /// </para>
        /// </summary>
        public long? BytesProcessed
        {
            get { return this._bytesProcessed; }
            set { this._bytesProcessed = value; }
        }

        // Check to see if BytesProcessed property is set
        internal bool IsSetBytesProcessed()
        {
            return this._bytesProcessed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BytesReturned. 
        /// <para>
        /// The current number of bytes of records payload data returned.
        /// </para>
        /// </summary>
        public long? BytesReturned
        {
            get { return this._bytesReturned; }
            set { this._bytesReturned = value; }
        }

        // Check to see if BytesReturned property is set
        internal bool IsSetBytesReturned()
        {
            return this._bytesReturned.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BytesScanned. 
        /// <para>
        /// The current number of object bytes scanned.
        /// </para>
        /// </summary>
        public long? BytesScanned
        {
            get { return this._bytesScanned; }
            set { this._bytesScanned = value; }
        }

        // Check to see if BytesScanned property is set
        internal bool IsSetBytesScanned()
        {
            return this._bytesScanned.HasValue; 
        }

    }
}