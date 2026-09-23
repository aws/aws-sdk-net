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
 * Do not modify this file. This file is generated from the billing-2023-09-07.normal.json service model.
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
namespace Amazon.Billing.Model
{
    /// <summary>
    /// Container for the parameters to the ListBillingViewSegments operation.
    /// Lists the segments of a billing view over a given time period. Each segment identifies
    /// the billing domain (<c>PRO_FORMA</c> or <c>BILLABLE</c>) and the account relationships
    /// that apply during its time range.
    /// 
    ///  
    /// <para>
    /// If you don't provide an <c>arn</c>, the response includes segments for the caller's
    /// <c>PRIMARY</c> billing view.
    /// </para>
    ///  
    /// <para>
    /// If a mid-period change occurs, the response includes multiple segments, each with
    /// its own time range. The response omits hidden segments, so the segments it returns
    /// might not cover the entire requested time period.
    /// </para>
    /// </summary>
    public partial class ListBillingViewSegmentsRequest : AmazonBillingRequest
    {
        private string _arn;
        private int? _maxResults;
        private string _nextToken;
        private BillingViewSegmentTimeRange _timeRange;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) that uniquely identifies the billing view to query.
        /// If you don't provide an ARN, the caller's <c>PRIMARY</c> billing view is used. The
        /// ARN must reference a primary billing view. Custom billing views aren't supported.
        /// 
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  The number of entries a paginated response contains. Valid values range from 1 to
        /// 100. The default is 100. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  The pagination token that is used on subsequent calls to list billing view segments.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4095)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property TimeRange. 
        /// <para>
        ///  The billing period to query. If you don't provide a time range, the current billing
        /// period, which is the calendar month in UTC, is used. 
        /// </para>
        /// </summary>
        public BillingViewSegmentTimeRange TimeRange
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