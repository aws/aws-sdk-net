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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the GetUsageForecast operation. Retrieves a forecast
    /// for how much Amazon Web Services predicts that you will use over the forecast time
    /// period that you select, based on your past usage.
    /// </summary>
    public partial class GetUsageForecastRequest : AmazonCostExplorerRequest
    {
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
        [AWSProperty(Min = 20, Max = 2048)]
        public string BillingViewArn { get; set; }

        /// <summary>
        /// Checks to see if the BillingViewArn property is set.
        /// </summary>
        internal bool IsSetBillingViewArn() => this.BillingViewArn != null;

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// The filters that you want to use to filter your forecast. The <c>GetUsageForecast</c>
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
        ///  <c>LINKED_ACCOUNT_NAME</c> 
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
        public Expression Filter { get; set; }

        /// <summary>
        /// Checks to see if the Filter property is set.
        /// </summary>
        internal bool IsSetFilter() => this.Filter != null;

        /// <summary>
        /// Gets and sets the property Granularity. 
        /// <para>
        /// How granular you want the forecast to be. You can get 3 months of <c>DAILY</c> forecasts
        /// or 18 months of <c>MONTHLY</c> forecasts.
        /// </para>
        ///  
        /// <para>
        /// The <c>GetUsageForecast</c> operation supports only <c>DAILY</c> and <c>MONTHLY</c>
        /// granularities.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Granularity Granularity { get; set; }

        /// <summary>
        /// Checks to see if the Granularity property is set.
        /// </summary>
        internal bool IsSetGranularity() => this.Granularity != null;

        /// <summary>
        /// Gets and sets the property Metric. 
        /// <para>
        /// Which metric Cost Explorer uses to create your forecast.
        /// </para>
        ///  
        /// <para>
        /// Valid values for a <c>GetUsageForecast</c> call are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// USAGE_QUANTITY
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// NORMALIZED_USAGE_AMOUNT
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public Metric Metric { get; set; }

        /// <summary>
        /// Checks to see if the Metric property is set.
        /// </summary>
        internal bool IsSetMetric() => this.Metric != null;

        /// <summary>
        /// Gets and sets the property PredictionIntervalLevel. 
        /// <para>
        /// Amazon Web Services Cost Explorer always returns the mean forecast as a single point.
        /// You can request a prediction interval around the mean by specifying a confidence level.
        /// The higher the confidence level, the more confident Cost Explorer is about the actual
        /// value falling in the prediction interval. Higher confidence levels result in wider
        /// prediction intervals.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 51, Max = 99)]
        public int? PredictionIntervalLevel { get; set; }

        /// <summary>
        /// Checks to see if the PredictionIntervalLevel property is set.
        /// </summary>
        internal bool IsSetPredictionIntervalLevel() => this.PredictionIntervalLevel.HasValue;

        /// <summary>
        /// Gets and sets the property TimePeriod. 
        /// <para>
        /// The start and end dates of the period that you want to retrieve usage forecast for.
        /// The start date is included in the period, but the end date isn't included in the period.
        /// For example, if <c>start</c> is <c>2017-01-01</c> and <c>end</c> is <c>2017-05-01</c>,
        /// then the cost and usage data is retrieved from <c>2017-01-01</c> up to and including
        /// <c>2017-04-30</c> but not including <c>2017-05-01</c>. The start date must be equal
        /// to or later than the current date to avoid a validation error.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateInterval TimePeriod { get; set; }

        /// <summary>
        /// Checks to see if the TimePeriod property is set.
        /// </summary>
        internal bool IsSetTimePeriod() => this.TimePeriod != null;
    }
}
