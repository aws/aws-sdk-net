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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// The latency peaks for an on-premises storage system resource. Each data point represents
    /// the 95th percentile peak value during a 1-hour interval.
    /// </summary>
    public partial class Latency
    {
        private double? _other;
        private double? _read;
        private double? _write;

        /// <summary>
        /// Gets and sets the property Other. 
        /// <para>
        /// Peak latency for operations unrelated to read and write operations.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public double Other
        {
            get { return this._other.GetValueOrDefault(); }
            set { this._other = value; }
        }

        // Check to see if Other property is set
        internal bool IsSetOther()
        {
            return this._other.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Read. 
        /// <para>
        /// Peak latency for read operations.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public double Read
        {
            get { return this._read.GetValueOrDefault(); }
            set { this._read = value; }
        }

        // Check to see if Read property is set
        internal bool IsSetRead()
        {
            return this._read.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Write. 
        /// <para>
        /// Peak latency for write operations.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public double Write
        {
            get { return this._write.GetValueOrDefault(); }
            set { this._write = value; }
        }

        // Check to see if Write property is set
        internal bool IsSetWrite()
        {
            return this._write.HasValue; 
        }

    }
}