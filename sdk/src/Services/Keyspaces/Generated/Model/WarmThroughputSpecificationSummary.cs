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
    /// Contains the current warm throughput settings for a table, including the configured
    /// capacity units and the current status of the warm throughput configuration.
    /// </summary>
    public partial class WarmThroughputSpecificationSummary
    {
        private long? _readUnitsPerSecond;
        private WarmThroughputStatus _status;
        private long? _writeUnitsPerSecond;

        /// <summary>
        /// Gets and sets the property ReadUnitsPerSecond. 
        /// <para>
        /// The number of read capacity units per second currently configured for warm throughput.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long ReadUnitsPerSecond
        {
            get { return this._readUnitsPerSecond.GetValueOrDefault(); }
            set { this._readUnitsPerSecond = value; }
        }

        // Check to see if ReadUnitsPerSecond property is set
        internal bool IsSetReadUnitsPerSecond()
        {
            return this._readUnitsPerSecond.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the warm throughput configuration. Valid values are <c>AVAILABLE</c>
        /// when the configuration is active, and <c>UPDATING</c> when changes are being applied.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public WarmThroughputStatus Status
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
        /// Gets and sets the property WriteUnitsPerSecond. 
        /// <para>
        /// The number of write capacity units per second currently configured for warm throughput.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long WriteUnitsPerSecond
        {
            get { return this._writeUnitsPerSecond.GetValueOrDefault(); }
            set { this._writeUnitsPerSecond = value; }
        }

        // Check to see if WriteUnitsPerSecond property is set
        internal bool IsSetWriteUnitsPerSecond()
        {
            return this._writeUnitsPerSecond.HasValue; 
        }

    }
}