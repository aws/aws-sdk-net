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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
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
namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies criteria for including or excluding endpoints from a segment based on how
    /// recently an endpoint was active.
    /// </summary>
    public partial class RecencyDimension
    {
        private Duration _duration;
        private RecencyType _recencyType;

        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        /// The duration to use when determining whether an endpoint is active or inactive.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Duration Duration
        {
            get { return this._duration; }
            set { this._duration = value; }
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this._duration != null;
        }

        /// <summary>
        /// Gets and sets the property RecencyType. 
        /// <para>
        /// The type of recency dimension to use for the segment. Valid values are: ACTIVE, endpoints
        /// that were active within the specified duration are included in the segment; and, INACTIVE,
        /// endpoints that weren't active within the specified duration are included in the segment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RecencyType RecencyType
        {
            get { return this._recencyType; }
            set { this._recencyType = value; }
        }

        // Check to see if RecencyType property is set
        internal bool IsSetRecencyType()
        {
            return this._recencyType != null;
        }

    }
}