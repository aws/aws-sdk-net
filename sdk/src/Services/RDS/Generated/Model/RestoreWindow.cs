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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Earliest and latest time an instance can be restored to:
    /// </summary>
    public partial class RestoreWindow
    {
        private DateTime? _earliestTime;
        private DateTime? _latestTime;

        /// <summary>
        /// Gets and sets the property EarliestTime. 
        /// <para>
        /// The earliest time you can restore an instance to.
        /// </para>
        /// </summary>
        public DateTime EarliestTime
        {
            get { return this._earliestTime.GetValueOrDefault(); }
            set { this._earliestTime = value; }
        }

        // Check to see if EarliestTime property is set
        internal bool IsSetEarliestTime()
        {
            return this._earliestTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LatestTime. 
        /// <para>
        /// The latest time you can restore an instance to.
        /// </para>
        /// </summary>
        public DateTime LatestTime
        {
            get { return this._latestTime.GetValueOrDefault(); }
            set { this._latestTime = value; }
        }

        // Check to see if LatestTime property is set
        internal bool IsSetLatestTime()
        {
            return this._latestTime.HasValue; 
        }

    }
}