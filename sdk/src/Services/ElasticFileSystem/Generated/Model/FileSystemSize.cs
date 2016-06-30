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
    /// Latest known metered size (in bytes) of data stored in the file system, in its <code>Value</code>
    /// field, and the time at which that size was determined in its <code>Timestamp</code>
    /// field. Note that the value does not represent the size of a consistent snapshot of
    /// the file system, but it is eventually consistent when there are no writes to the file
    /// system. That is, the value will represent the actual size only if the file system
    /// is not modified for a period longer than a couple of hours. Otherwise, the value is
    /// not necessarily the exact size the file system was at any instant in time.
    /// </summary>
    public partial class FileSystemSize
    {
        private DateTime? _timestamp;
        private long? _value;

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// Time at which the size of data, returned in the <code>Value</code> field, was determined.
        /// The value is the integer number of seconds since 1970-01-01T00:00:00Z.
        /// </para>
        /// </summary>
        public DateTime Timestamp
        {
            get { return this._timestamp.GetValueOrDefault(); }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// Latest known metered size (in bytes) of data stored in the file system.
        /// </para>
        /// </summary>
        public long Value
        {
            get { return this._value.GetValueOrDefault(); }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value.HasValue; 
        }

    }
}