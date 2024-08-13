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
    /// The latest known metered size (in bytes) of data stored in the file system, in its
    /// <c>Value</c> field, and the time at which that size was determined in its <c>Timestamp</c>
    /// field. The value doesn't represent the size of a consistent snapshot of the file system,
    /// but it is eventually consistent when there are no writes to the file system. That
    /// is, the value represents the actual size only if the file system is not modified for
    /// a period longer than a couple of hours. Otherwise, the value is not necessarily the
    /// exact size the file system was at any instant in time.
    /// </summary>
    public partial class FileSystemSize
    {
        private DateTime? _timestamp;
        private long? _value;
        private long? _valueInArchive;
        private long? _valueInIA;
        private long? _valueInStandard;

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The time at which the size of data, returned in the <c>Value</c> field, was determined.
        /// The value is the integer number of seconds since 1970-01-01T00:00:00Z.
        /// </para>
        /// </summary>
        public DateTime? Timestamp
        {
            get { return this._timestamp; }
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
        /// The latest known metered size (in bytes) of data stored in the file system.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public long? Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ValueInArchive. 
        /// <para>
        /// The latest known metered size (in bytes) of data stored in the Archive storage class.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? ValueInArchive
        {
            get { return this._valueInArchive; }
            set { this._valueInArchive = value; }
        }

        // Check to see if ValueInArchive property is set
        internal bool IsSetValueInArchive()
        {
            return this._valueInArchive.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ValueInIA. 
        /// <para>
        /// The latest known metered size (in bytes) of data stored in the Infrequent Access storage
        /// class.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? ValueInIA
        {
            get { return this._valueInIA; }
            set { this._valueInIA = value; }
        }

        // Check to see if ValueInIA property is set
        internal bool IsSetValueInIA()
        {
            return this._valueInIA.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ValueInStandard. 
        /// <para>
        /// The latest known metered size (in bytes) of data stored in the Standard storage class.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? ValueInStandard
        {
            get { return this._valueInStandard; }
            set { this._valueInStandard = value; }
        }

        // Check to see if ValueInStandard property is set
        internal bool IsSetValueInStandard()
        {
            return this._valueInStandard.HasValue; 
        }

    }
}