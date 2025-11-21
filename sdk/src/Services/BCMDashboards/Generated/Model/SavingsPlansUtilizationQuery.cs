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
 * Do not modify this file. This file is generated from the bcm-dashboards-2025-08-18.normal.json service model.
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
namespace Amazon.BCMDashboards.Model
{
    /// <summary>
    /// Defines the parameters for querying Savings Plans utilization data, including time
    /// granularity and sorting preferences.
    /// </summary>
    public partial class SavingsPlansUtilizationQuery
    {
        private Expression _filter;
        private Granularity _granularity;
        private DateTimeRange _timeRange;

        /// <summary>
        /// Gets and sets the property Filter.
        /// </summary>
        public Expression Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null;
        }

        /// <summary>
        /// Gets and sets the property Granularity. 
        /// <para>
        /// The time granularity of the retrieved data: HOURLY, DAILY, or MONTHLY.
        /// </para>
        /// </summary>
        public Granularity Granularity
        {
            get { return this._granularity; }
            set { this._granularity = value; }
        }

        // Check to see if Granularity property is set
        internal bool IsSetGranularity()
        {
            return this._granularity != null;
        }

        /// <summary>
        /// Gets and sets the property TimeRange.
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTimeRange TimeRange
        {
            get { return this._timeRange; }
            set { this._timeRange = value; }
        }

        // Check to see if TimeRange property is set
        internal bool IsSetTimeRange()
        {
            return this._timeRange != null;
        }

    }
}