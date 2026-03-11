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
 * Do not modify this file. This file is generated from the keyspaces-2022-02-10.normal.json service model.
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
namespace Amazon.Keyspaces.Model
{
    /// <summary>
    /// Specifies the warm throughput settings for a table. Pre-warming a table by specifying
    /// warm throughput pre-provisions read and write capacity units to help avoid capacity
    /// exceeded exceptions and reduce latency when your table starts receiving traffic.
    /// 
    ///  
    /// <para>
    /// For more information about pre-warming in Amazon Keyspaces, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/warm-throughput.html">Pre-warm
    /// a table in Amazon Keyspaces</a> in the <i>Amazon Keyspaces Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class WarmThroughputSpecification
    {
        private long? _readUnitsPerSecond;
        private long? _writeUnitsPerSecond;

        /// <summary>
        /// Gets and sets the property ReadUnitsPerSecond. 
        /// <para>
        /// The number of read capacity units per second to pre-warm the table for read capacity
        /// throughput. The minimum value is 1.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public long? ReadUnitsPerSecond
        {
            get { return this._readUnitsPerSecond; }
            set { this._readUnitsPerSecond = value; }
        }

        // Check to see if ReadUnitsPerSecond property is set
        internal bool IsSetReadUnitsPerSecond()
        {
            return this._readUnitsPerSecond.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WriteUnitsPerSecond. 
        /// <para>
        /// The number of write capacity units per second to pre-warm the table for write capacity
        /// throughput. The minimum value is 1.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public long? WriteUnitsPerSecond
        {
            get { return this._writeUnitsPerSecond; }
            set { this._writeUnitsPerSecond = value; }
        }

        // Check to see if WriteUnitsPerSecond property is set
        internal bool IsSetWriteUnitsPerSecond()
        {
            return this._writeUnitsPerSecond.HasValue; 
        }

    }
}