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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Container for the parameters to the GetSavingsPlansUtilization operation.
    /// Retrieves the Savings Plans utilization for your account across date ranges with daily
    /// or monthly granularity. Management account in an organization have access to member
    /// accounts. You can use <c>GetDimensionValues</c> in <c>SAVINGS_PLANS</c> to determine
    /// the possible dimension values.
    /// 
    ///  <note> 
    /// <para>
    /// You can't group by any dimension values for <c>GetSavingsPlansUtilization</c>.
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
        ///  <c>LINKED_ACCOUNT</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SAVINGS_PLAN_ARN</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SAVINGS_PLANS_TYPE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REGION</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PAYMENT_OPTION</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INSTANCE_TYPE_FAMILY</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <c>GetSavingsPlansUtilization</c> uses the same <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_Expression.html">Expression</a>
        /// object as the other operations, but only <c>AND</c> is supported among each dimension.
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
        /// The <c>GetSavingsPlansUtilization</c> operation supports only <c>DAILY</c> and <c>MONTHLY</c>
        /// granularities.
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
        /// The value that you want to sort the data by.
        /// </para>
        ///  
        /// <para>
        /// The following values are supported for <c>Key</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>UtilizationPercentage</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TotalCommitment</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UsedCommitment</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UnusedCommitment</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NetSavings</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The supported values for <c>SortOrder</c> are <c>ASCENDING</c> and <c>DESCENDING</c>.
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
        /// The time period that you want the usage and costs for. The <c>Start</c> date must
        /// be within 13 months. The <c>End</c> date must be after the <c>Start</c> date, and
        /// before the current date. Future dates can't be used as an <c>End</c> date.
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