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
    /// Container for the parameters to the GetUsageTotals operation.
    /// Retrieves (queries) aggregated usage data for an account.
    /// </summary>
    public partial class GetUsageTotalsRequest : AmazonMacie2Request
    {
        private string _timeRange;

        /// <summary>
        /// Gets and sets the property TimeRange. 
        /// <para>
        /// The inclusive time period to retrieve the data for. Valid values are: MONTH_TO_DATE,
        /// for the current calendar month to date; and, PAST_30_DAYS, for the preceding 30 days.
        /// If you don't specify a value for this parameter, Amazon Macie provides aggregated
        /// usage data for the preceding 30 days.
        /// </para>
        /// </summary>
        public string TimeRange
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