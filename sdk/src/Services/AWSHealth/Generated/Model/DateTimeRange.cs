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
 * Do not modify this file. This file is generated from the health-2016-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AWSHealth.Model
{
    /// <summary>
    /// A range of dates and times that is used by the <a>EventFilter</a> and <a>EntityFilter</a>
    /// objects. If <code>from</code> is set and <code>to</code> is set: match items where
    /// the timestamp (<code>startTime</code>, <code>endTime</code>, or <code>lastUpdatedTime</code>)
    /// is between <code>from</code> and <code>to</code> inclusive. If <code>from</code> is
    /// set and <code>to</code> is not set: match items where the timestamp value is equal
    /// to or after <code>from</code>. If <code>from</code> is not set and <code>to</code>
    /// is set: match items where the timestamp value is equal to or before <code>to</code>.
    /// </summary>
    public partial class DateTimeRange
    {
        private DateTime? _from;
        private DateTime? _to;

        /// <summary>
        /// Gets and sets the property From. 
        /// <para>
        /// The starting date and time of a time range.
        /// </para>
        /// </summary>
        public DateTime From
        {
            get { return this._from.GetValueOrDefault(); }
            set { this._from = value; }
        }

        // Check to see if From property is set
        internal bool IsSetFrom()
        {
            return this._from.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property To. 
        /// <para>
        /// The ending date and time of a time range.
        /// </para>
        /// </summary>
        public DateTime To
        {
            get { return this._to.GetValueOrDefault(); }
            set { this._to = value; }
        }

        // Check to see if To property is set
        internal bool IsSetTo()
        {
            return this._to.HasValue; 
        }

    }
}