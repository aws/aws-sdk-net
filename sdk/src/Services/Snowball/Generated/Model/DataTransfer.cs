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
 * Do not modify this file. This file is generated from the snowball-2016-06-30.normal.json service model.
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
namespace Amazon.Snowball.Model
{
    /// <summary>
    /// Defines the real-time status of a Snow device's data transfer while the device is
    /// at Amazon Web Services. This data is only available while a job has a <c>JobState</c>
    /// value of <c>InProgress</c>, for both import and export jobs.
    /// </summary>
    public partial class DataTransfer
    {
        private long? _bytesTransferred;
        private long? _objectsTransferred;
        private long? _totalBytes;
        private long? _totalObjects;

        /// <summary>
        /// Gets and sets the property BytesTransferred. 
        /// <para>
        /// The number of bytes transferred between a Snow device and Amazon S3.
        /// </para>
        /// </summary>
        public long? BytesTransferred
        {
            get { return this._bytesTransferred; }
            set { this._bytesTransferred = value; }
        }

        // Check to see if BytesTransferred property is set
        internal bool IsSetBytesTransferred()
        {
            return this._bytesTransferred.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ObjectsTransferred. 
        /// <para>
        /// The number of objects transferred between a Snow device and Amazon S3.
        /// </para>
        /// </summary>
        public long? ObjectsTransferred
        {
            get { return this._objectsTransferred; }
            set { this._objectsTransferred = value; }
        }

        // Check to see if ObjectsTransferred property is set
        internal bool IsSetObjectsTransferred()
        {
            return this._objectsTransferred.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalBytes. 
        /// <para>
        /// The total bytes of data for a transfer between a Snow device and Amazon S3. This value
        /// is set to 0 (zero) until all the keys that will be transferred have been listed.
        /// </para>
        /// </summary>
        public long? TotalBytes
        {
            get { return this._totalBytes; }
            set { this._totalBytes = value; }
        }

        // Check to see if TotalBytes property is set
        internal bool IsSetTotalBytes()
        {
            return this._totalBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalObjects. 
        /// <para>
        /// The total number of objects for a transfer between a Snow device and Amazon S3. This
        /// value is set to 0 (zero) until all the keys that will be transferred have been listed.
        /// </para>
        /// </summary>
        public long? TotalObjects
        {
            get { return this._totalObjects; }
            set { this._totalObjects = value; }
        }

        // Check to see if TotalObjects property is set
        internal bool IsSetTotalObjects()
        {
            return this._totalObjects.HasValue; 
        }

    }
}