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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Container for the parameters to the GetSavingsPlansUtilization operation.
    /// Retrieves the Savings Plans utilization for your account across date ranges with daily
    /// or monthly granularity. Management account in an organization have access to member
    /// accounts. You can use <code>GetDimensionValues</code> in <code>SAVINGS_PLANS</code>
    /// to determine the possible dimension values.
    /// 
    ///  <note> 
    /// <para>
    /// You cannot group by any dimension values for <code>GetSavingsPlansUtilization</code>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GetSavingsPlansUtilizationRequest : AmazonCostExplorerRequest
    {
        private Expression _filter;
        private Granularity _granularity;
        private SortDefinition _sortBy;
        private DateInterval _timePeriod;

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// Filters Savings Plans utilization coverage data for active Savings Plans dimensions.
        /// You can filter data with the following dimensions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>LINKED_ACCOUNT</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SAVINGS_PLAN_ARN</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SAVINGS_PLANS_TYPE</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>REGION</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PAYMENT_OPTION</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>INSTANCE_TYPE_FAMILY</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <code>GetSavingsPlansUtilization</code> uses the same <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_Expression.html">Expression</a>
        /// object as the other operations, but only <code>AND</code> is supported among each
        /// dimension.
        /// </para>
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
        /// The granularity of the Amazon Web Services utillization data for your Savings Plans.
        /// </para>
        ///  
        /// <para>
        /// The <code>GetSavingsPlansUtilization</code> operation supports only <code>DAILY</code>
        /// and <code>MONTHLY</code> granularities.
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
        /// Gets and sets the property SortBy. 
        /// <para>
        /// The value by which you want to sort the data.
        /// </para>
        ///  
        /// <para>
        /// The following values are supported for <code>Key</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>UtilizationPercentage</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TotalCommitment</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UsedCommitment</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UnusedCommitment</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NetSavings</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Supported values for <code>SortOrder</code> are <code>ASCENDING</code> or <code>DESCENDING</code>.
        /// </para>
        /// </summary>
        public SortDefinition SortBy
        {
            get { return this._sortBy; }
            set { this._sortBy = value; }
        }

        // Check to see if SortBy property is set
        internal bool IsSetSortBy()
        {
            return this._sortBy != null;
        }

        /// <summary>
        /// Gets and sets the property TimePeriod. 
        /// <para>
        /// The time period that you want the usage and costs for. The <code>Start</code> date
        /// must be within 13 months. The <code>End</code> date must be after the <code>Start</code>
        /// date, and before the current date. Future dates can't be used as an <code>End</code>
        /// date.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateInterval TimePeriod
        {
            get { return this._timePeriod; }
            set { this._timePeriod = value; }
        }

        // Check to see if TimePeriod property is set
        internal bool IsSetTimePeriod()
        {
            return this._timePeriod != null;
        }

    }
}