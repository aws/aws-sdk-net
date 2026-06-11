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
 * Do not modify this file. This file is generated from the resiliencehubv2-2026-02-17.normal.json service model.
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
namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// A data point in a dependency query range.
    /// </summary>
    public partial class QueryDataPoint
    {
        private long? _queryCount;
        private DateTime? _timestamp;

        /// <summary>
        /// Gets and sets the property QueryCount. 
        /// <para>
        /// The number of queries at this data point.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? QueryCount
        {
            get { return this._queryCount; }
            set { this._queryCount = value; }
        }

        // Check to see if QueryCount property is set
        internal bool IsSetQueryCount()
        {
            return this._queryCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The timestamp of the data point.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}