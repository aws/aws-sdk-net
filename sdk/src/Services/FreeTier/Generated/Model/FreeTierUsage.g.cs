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

namespace Amazon.FreeTier.Model
{
    /// <summary>
    /// Consists of a Amazon Web Services Free Tier offer’s metadata and your data usage for
    /// the offer.
    /// </summary>
    public partial class FreeTierUsage
    {
        /// <summary>
        /// Gets and sets the property ActualUsageAmount. 
        /// <para>
        /// Describes the actual usage accrued month-to-day (MTD) that you've used so far.
        /// </para>
        /// </summary>
        public double? ActualUsageAmount { get; set; }

        /// <summary>
        /// Checks to see if the ActualUsageAmount property is set.
        /// </summary>
        internal bool IsSetActualUsageAmount() => this.ActualUsageAmount.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the Free Tier offer.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ForecastedUsageAmount. 
        /// <para>
        /// Describes the forecasted usage by the month that you're expected to use.
        /// </para>
        /// </summary>
        public double? ForecastedUsageAmount { get; set; }

        /// <summary>
        /// Checks to see if the ForecastedUsageAmount property is set.
        /// </summary>
        internal bool IsSetForecastedUsageAmount() => this.ForecastedUsageAmount.HasValue;

        /// <summary>
        /// Gets and sets the property FreeTierType. 
        /// <para>
        /// Describes the type of the Free Tier offer. For example, the offer can be <c>"12 Months
        /// Free"</c>, <c>"Always Free"</c>, and <c>"Free Trial"</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string FreeTierType { get; set; }

        /// <summary>
        /// Checks to see if the FreeTierType property is set.
        /// </summary>
        internal bool IsSetFreeTierType() => this.FreeTierType != null;

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// Describes the maximum usage allowed in Free Tier.
        /// </para>
        /// </summary>
        public double? Limit { get; set; }

        /// <summary>
        /// Checks to see if the Limit property is set.
        /// </summary>
        internal bool IsSetLimit() => this.Limit.HasValue;

        /// <summary>
        /// Gets and sets the property Operation. 
        /// <para>
        /// Describes <c>usageType</c> more granularly with the specific Amazon Web Services service
        /// API operation. For example, this can be the <c>RunInstances</c> API operation for
        /// Amazon Elastic Compute Cloud.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Operation { get; set; }

        /// <summary>
        /// Checks to see if the Operation property is set.
        /// </summary>
        internal bool IsSetOperation() => this.Operation != null;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// Describes the Amazon Web Services Region for which this offer is applicable
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property Service. 
        /// <para>
        /// The name of the Amazon Web Services service providing the Free Tier offer. For example,
        /// this can be Amazon Elastic Compute Cloud.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Service { get; set; }

        /// <summary>
        /// Checks to see if the Service property is set.
        /// </summary>
        internal bool IsSetService() => this.Service != null;

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// Describes the unit of the <c>usageType</c>, such as <c>Hrs</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Unit { get; set; }

        /// <summary>
        /// Checks to see if the Unit property is set.
        /// </summary>
        internal bool IsSetUnit() => this.Unit != null;

        /// <summary>
        /// Gets and sets the property UsageType. 
        /// <para>
        /// Describes the usage details of the offer. For example, this might be <c>Global-BoxUsage:freetrial</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string UsageType { get; set; }

        /// <summary>
        /// Checks to see if the UsageType property is set.
        /// </summary>
        internal bool IsSetUsageType() => this.UsageType != null;
    }
}
