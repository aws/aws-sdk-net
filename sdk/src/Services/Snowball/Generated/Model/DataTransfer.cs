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
 * Do not modify this file. This file is generated from the snowball-2016-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Snowball.Model
{
    /// <summary>
    /// Defines the real-time status of a Snowball's data transfer while the appliance is
    /// at AWS. Note that this data is only available while a job has a <code>JobState</code>
    /// value of <code>InProgress</code>, for both import and export jobs.
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
        /// The number of bytes transferred between a Snowball and Amazon S3.
        /// </para>
        /// </summary>
        public long BytesTransferred
        {
            get { return this._bytesTransferred.GetValueOrDefault(); }
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
        /// The number of objects transferred between a Snowball and Amazon S3.
        /// </para>
        /// </summary>
        public long ObjectsTransferred
        {
            get { return this._objectsTransferred.GetValueOrDefault(); }
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
        /// The total bytes of data for a transfer between a Snowball and Amazon S3. This value
        /// is set to 0 (zero) until all the keys that will be transferred have been listed.
        /// </para>
        /// </summary>
        public long TotalBytes
        {
            get { return this._totalBytes.GetValueOrDefault(); }
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
        /// The total number of objects for a transfer between a Snowball and Amazon S3. This
        /// value is set to 0 (zero) until all the keys that will be transferred have been listed.
        /// </para>
        /// </summary>
        public long TotalObjects
        {
            get { return this._totalObjects.GetValueOrDefault(); }
            set { this._totalObjects = value; }
        }

        // Check to see if TotalObjects property is set
        internal bool IsSetTotalObjects()
        {
            return this._totalObjects.HasValue; 
        }

    }
}