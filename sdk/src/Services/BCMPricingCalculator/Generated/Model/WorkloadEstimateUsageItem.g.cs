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

namespace Amazon.BCMPricingCalculator.Model
{
    /// <summary>
    /// Represents a usage item in a workload estimate.
    /// </summary>
    public partial class WorkloadEstimateUsageItem
    {
        /// <summary>
        /// Gets and sets the property Cost. 
        /// <para>
        ///  The estimated cost for this usage item. 
        /// </para>
        /// </summary>
        public double? Cost { get; set; }

        /// <summary>
        /// Checks to see if the Cost property is set.
        /// </summary>
        internal bool IsSetCost() => this.Cost.HasValue;

        /// <summary>
        /// Gets and sets the property Currency. 
        /// <para>
        ///  The currency of the estimated cost. 
        /// </para>
        /// </summary>
        public CurrencyCode Currency { get; set; }

        /// <summary>
        /// Checks to see if the Currency property is set.
        /// </summary>
        internal bool IsSetCurrency() => this.Currency != null;

        /// <summary>
        /// Gets and sets the property Group. 
        /// <para>
        ///  The group identifier for this usage item. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 30)]
        public string Group { get; set; }

        /// <summary>
        /// Checks to see if the Group property is set.
        /// </summary>
        internal bool IsSetGroup() => this.Group != null;

        /// <summary>
        /// Gets and sets the property HistoricalUsage. 
        /// <para>
        ///  Historical usage data associated with this item, if available. 
        /// </para>
        /// </summary>
        public HistoricalUsageEntity HistoricalUsage { get; set; }

        /// <summary>
        /// Checks to see if the HistoricalUsage property is set.
        /// </summary>
        internal bool IsSetHistoricalUsage() => this.HistoricalUsage != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  The unique identifier of this usage item. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        ///  The location associated with this usage item. 
        /// </para>
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Checks to see if the Location property is set.
        /// </summary>
        internal bool IsSetLocation() => this.Location != null;

        /// <summary>
        /// Gets and sets the property Operation. 
        /// <para>
        ///  The specific operation associated with this usage item. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 32)]
        public string Operation { get; set; }

        /// <summary>
        /// Checks to see if the Operation property is set.
        /// </summary>
        internal bool IsSetOperation() => this.Operation != null;

        /// <summary>
        /// Gets and sets the property Quantity. 
        /// <para>
        ///  The estimated usage quantity for this item. 
        /// </para>
        /// </summary>
        public WorkloadEstimateUsageQuantity Quantity { get; set; }

        /// <summary>
        /// Checks to see if the Quantity property is set.
        /// </summary>
        internal bool IsSetQuantity() => this.Quantity != null;

        /// <summary>
        /// Gets and sets the property ServiceCode. 
        /// <para>
        ///  The Amazon Web Services service code associated with this usage item. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 32)]
        public string ServiceCode { get; set; }

        /// <summary>
        /// Checks to see if the ServiceCode property is set.
        /// </summary>
        internal bool IsSetServiceCode() => this.ServiceCode != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The current status of this usage item. 
        /// </para>
        /// </summary>
        public WorkloadEstimateCostStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UsageAccountId. 
        /// <para>
        ///  The Amazon Web Services account ID associated with this usage item. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string UsageAccountId { get; set; }

        /// <summary>
        /// Checks to see if the UsageAccountId property is set.
        /// </summary>
        internal bool IsSetUsageAccountId() => this.UsageAccountId != null;

        /// <summary>
        /// Gets and sets the property UsageType. 
        /// <para>
        ///  The type of usage for this item. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 128)]
        public string UsageType { get; set; }

        /// <summary>
        /// Checks to see if the UsageType property is set.
        /// </summary>
        internal bool IsSetUsageType() => this.UsageType != null;
    }
}
