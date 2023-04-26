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

namespace Amazon.Keyspaces.Model
{
    /// <summary>
    /// Amazon Keyspaces has two read/write capacity modes for processing reads and writes
    /// on your tables: 
    /// 
    ///  <ul> <li> 
    /// <para>
    /// On-demand (default)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Provisioned
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// The read/write capacity mode that you choose controls how you are charged for read
    /// and write throughput and how table throughput capacity is managed.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/ReadWriteCapacityMode.html">Read/write
    /// capacity modes</a> in the <i>Amazon Keyspaces Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class CapacitySpecification
    {
        private long? _readCapacityUnits;
        private ThroughputMode _throughputMode;
        private long? _writeCapacityUnits;

        /// <summary>
        /// Gets and sets the property ReadCapacityUnits. 
        /// <para>
        /// The throughput capacity specified for <code>read</code> operations defined in <code>read
        /// capacity units</code> <code>(RCUs)</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public long ReadCapacityUnits
        {
            get { return this._readCapacityUnits.GetValueOrDefault(); }
            set { this._readCapacityUnits = value; }
        }

        // Check to see if ReadCapacityUnits property is set
        internal bool IsSetReadCapacityUnits()
        {
            return this._readCapacityUnits.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ThroughputMode. 
        /// <para>
        /// The read/write throughput capacity mode for a table. The options are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>throughputMode:PAY_PER_REQUEST</code> and 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>throughputMode:PROVISIONED</code> - Provisioned capacity mode requires <code>readCapacityUnits</code>
        /// and <code>writeCapacityUnits</code> as input.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The default is <code>throughput_mode:PAY_PER_REQUEST</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/ReadWriteCapacityMode.html">Read/write
        /// capacity modes</a> in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ThroughputMode ThroughputMode
        {
            get { return this._throughputMode; }
            set { this._throughputMode = value; }
        }

        // Check to see if ThroughputMode property is set
        internal bool IsSetThroughputMode()
        {
            return this._throughputMode != null;
        }

        /// <summary>
        /// Gets and sets the property WriteCapacityUnits. 
        /// <para>
        /// The throughput capacity specified for <code>write</code> operations defined in <code>write
        /// capacity units</code> <code>(WCUs)</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public long WriteCapacityUnits
        {
            get { return this._writeCapacityUnits.GetValueOrDefault(); }
            set { this._writeCapacityUnits = value; }
        }

        // Check to see if WriteCapacityUnits property is set
        internal bool IsSetWriteCapacityUnits()
        {
            return this._writeCapacityUnits.HasValue; 
        }

    }
}