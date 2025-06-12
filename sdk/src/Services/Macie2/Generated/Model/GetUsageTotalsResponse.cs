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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
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
namespace Amazon.Macie2.Model
{
    /// <summary>
    /// This is the response object from the GetUsageTotals operation.
    /// </summary>
    public partial class GetUsageTotalsResponse : AmazonWebServiceResponse
    {
        private TimeRange _timeRange;
        private List<UsageTotal> _usageTotals = AWSConfigs.InitializeCollections ? new List<UsageTotal>() : null;

        /// <summary>
        /// Gets and sets the property TimeRange. 
        /// <para>
        /// The inclusive time period that the usage data applies to. Possible values are: MONTH_TO_DATE,
        /// for the current calendar month to date; and, PAST_30_DAYS, for the preceding 30 days.
        /// </para>
        /// </summary>
        public TimeRange TimeRange
        {
            get { return this._timeRange; }
            set { this._timeRange = value; }
        }

        // Check to see if TimeRange property is set
        internal bool IsSetTimeRange()
        {
            return this._timeRange != null;
        }

        /// <summary>
        /// Gets and sets the property UsageTotals. 
        /// <para>
        /// An array of objects that contains the results of the query. Each object contains the
        /// data for a specific usage metric.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UsageTotal> UsageTotals
        {
            get { return this._usageTotals; }
            set { this._usageTotals = value; }
        }

        // Check to see if UsageTotals property is set
        internal bool IsSetUsageTotals()
        {
            return this._usageTotals != null && (this._usageTotals.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}