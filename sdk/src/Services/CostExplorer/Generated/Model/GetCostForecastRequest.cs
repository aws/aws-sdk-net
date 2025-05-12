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
    /// Container for the parameters to the GetCostForecast operation.
    /// Retrieves a forecast for how much Amazon Web Services predicts that you will spend
    /// over the forecast time period that you select, based on your past costs.
    /// </summary>
    public partial class GetCostForecastRequest : AmazonCostExplorerRequest
    {
        private string _billingViewArn;
        private Expression _filter;
        private Granularity _granularity;
        private Metric _metric;
        private int? _predictionIntervalLevel;
        private DateInterval _timePeriod;

        /// <summary>
        /// Gets and sets the property BillingViewArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies a specific billing view. The
        /// ARN is used to specify which particular billing view you want to interact with or
        /// retrieve information from when making API calls related to Amazon Web Services Billing
        /// and Cost Management features. The BillingViewArn can be retrieved by calling the ListBillingViews
        /// API.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string BillingViewArn
        {
            get { return this._billingViewArn; }
            set { this._billingViewArn = value; }
        }

        // Check to see if BillingViewArn property is set
        internal bool IsSetBillingViewArn()
        {
            return this._billingViewArn != null;
        }

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// The filters that you want to use to filter your forecast. The <c>GetCostForecast</c>
        /// API supports filtering by the following dimensions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AZ</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INSTANCE_TYPE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LINKED_ACCOUNT</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OPERATION</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PURCHASE_TYPE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REGION</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SERVICE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>USAGE_TYPE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>USAGE_TYPE_GROUP</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RECORD_TYPE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OPERATING_SYSTEM</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TENANCY</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SCOPE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PLATFORM</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SUBSCRIPTION_ID</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LEGAL_ENTITY_NAME</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DEPLOYMENT_OPTION</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DATABASE_ENGINE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INSTANCE_TYPE_FAMILY</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BILLING_ENTITY</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RESERVATION_ID</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SAVINGS_PLAN_ARN</c> 
        /// </para>
        ///  </li> </ul>
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
        /// How granular you want the forecast to be. You can get 3 months of <c>DAILY</c> forecasts
        /// or 12 months of <c>MONTHLY</c> forecasts.
        /// </para>
        ///  
        /// <para>
        /// The <c>GetCostForecast</c> operation supports only <c>DAILY</c> and <c>MONTHLY</c>
        /// granularities.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Metric. 
        /// <para>
        /// Which metric Cost Explorer uses to create your forecast. For more information about
        /// blended and unblended rates, see <a href="http://aws.amazon.com/premiumsupport/knowledge-center/blended-rates-intro/">Why
        /// does the "blended" annotation appear on some line items in my bill?</a>. 
        /// </para>
        ///  
        /// <para>
        /// Valid values for a <c>GetCostForecast</c> call are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// AMORTIZED_COST
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// BLENDED_COST
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// NET_AMORTIZED_COST
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// NET_UNBLENDED_COST
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNBLENDED_COST
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public Metric Metric
        {
            get { return this._metric; }
            set { this._metric = value; }
        }

        // Check to see if Metric property is set
        internal bool IsSetMetric()
        {
            return this._metric != null;
        }

        /// <summary>
        /// Gets and sets the property PredictionIntervalLevel. 
        /// <para>
        /// Cost Explorer always returns the mean forecast as a single point. You can request
        /// a prediction interval around the mean by specifying a confidence level. The higher
        /// the confidence level, the more confident Cost Explorer is about the actual value falling
        /// in the prediction interval. Higher confidence levels result in wider prediction intervals.
        /// </para>
        /// </summary>
        [AWSProperty(Min=51, Max=99)]
        public int? PredictionIntervalLevel
        {
            get { return this._predictionIntervalLevel; }
            set { this._predictionIntervalLevel = value; }
        }

        // Check to see if PredictionIntervalLevel property is set
        internal bool IsSetPredictionIntervalLevel()
        {
            return this._predictionIntervalLevel.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimePeriod. 
        /// <para>
        /// The period of time that you want the forecast to cover. The start date must be equal
        /// to or no later than the current date to avoid a validation error.
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