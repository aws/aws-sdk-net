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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Contains the resource trend metrics data for a specific time point in the requested
    /// time period.
    /// </summary>
    public partial class ResourcesTrendsMetricsResult
    {
        private DateTime? _timestamp;
        private ResourcesTrendsValues _trendsValues;

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The timestamp for this data point in the resources trend metrics.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property TrendsValues. 
        /// <para>
        /// The resource trend metric values associated with this timestamp, including resource
        /// counts.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResourcesTrendsValues TrendsValues
        {
            get { return this._trendsValues; }
            set { this._trendsValues = value; }
        }

        // Check to see if TrendsValues property is set
        internal bool IsSetTrendsValues()
        {
            return this._trendsValues != null;
        }

    }
}