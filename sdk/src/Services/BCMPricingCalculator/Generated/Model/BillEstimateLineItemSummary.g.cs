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
    /// Provides a summary of a line item in a bill estimate.
    /// </summary>
    public partial class BillEstimateLineItemSummary
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        ///  The availability zone associated with this line item, if applicable. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 32)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property EstimatedCost. 
        /// <para>
        ///  The estimated cost for this line item. 
        /// </para>
        /// </summary>
        public CostAmount EstimatedCost { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedCost property is set.
        /// </summary>
        internal bool IsSetEstimatedCost() => this.EstimatedCost != null;

        /// <summary>
        /// Gets and sets the property EstimatedUsageQuantity. 
        /// <para>
        ///  The estimated usage quantity for this line item. 
        /// </para>
        /// </summary>
        public UsageQuantityResult EstimatedUsageQuantity { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedUsageQuantity property is set.
        /// </summary>
        internal bool IsSetEstimatedUsageQuantity() => this.EstimatedUsageQuantity != null;

        /// <summary>
        /// Gets and sets the property HistoricalCost. 
        /// <para>
        ///  The historical cost for this line item. 
        /// </para>
        /// </summary>
        public CostAmount HistoricalCost { get; set; }

        /// <summary>
        /// Checks to see if the HistoricalCost property is set.
        /// </summary>
        internal bool IsSetHistoricalCost() => this.HistoricalCost != null;

        /// <summary>
        /// Gets and sets the property HistoricalUsageQuantity. 
        /// <para>
        ///  The historical usage quantity for this line item. 
        /// </para>
        /// </summary>
        public UsageQuantityResult HistoricalUsageQuantity { get; set; }

        /// <summary>
        /// Checks to see if the HistoricalUsageQuantity property is set.
        /// </summary>
        internal bool IsSetHistoricalUsageQuantity() => this.HistoricalUsageQuantity != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  The unique identifier of this line item. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LineItemId. 
        /// <para>
        ///  The line item identifier from the original bill. 
        /// </para>
        /// </summary>
        public string LineItemId { get; set; }

        /// <summary>
        /// Checks to see if the LineItemId property is set.
        /// </summary>
        internal bool IsSetLineItemId() => this.LineItemId != null;

        /// <summary>
        /// Gets and sets the property LineItemType. 
        /// <para>
        ///  The type of this line item (e.g., Usage, Tax, Credit). 
        /// </para>
        /// </summary>
        public string LineItemType { get; set; }

        /// <summary>
        /// Checks to see if the LineItemType property is set.
        /// </summary>
        internal bool IsSetLineItemType() => this.LineItemType != null;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        ///  The location associated with this line item. 
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
        ///  The specific operation associated with this line item. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 32)]
        public string Operation { get; set; }

        /// <summary>
        /// Checks to see if the Operation property is set.
        /// </summary>
        internal bool IsSetOperation() => this.Operation != null;

        /// <summary>
        /// Gets and sets the property PayerAccountId. 
        /// <para>
        ///  The Amazon Web Services account ID of the payer for this line item. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string PayerAccountId { get; set; }

        /// <summary>
        /// Checks to see if the PayerAccountId property is set.
        /// </summary>
        internal bool IsSetPayerAccountId() => this.PayerAccountId != null;

        /// <summary>
        /// Gets and sets the property SavingsPlanArns. 
        /// <para>
        ///  The Amazon Resource Names (ARNs) of any Savings Plans applied to this line item.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SavingsPlanArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SavingsPlanArns property is set.
        /// </summary>
        internal bool IsSetSavingsPlanArns() => this.SavingsPlanArns != null && (this.SavingsPlanArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ServiceCode. 
        /// <para>
        ///  The Amazon Web Services service code associated with this line item. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 32)]
        public string ServiceCode { get; set; }

        /// <summary>
        /// Checks to see if the ServiceCode property is set.
        /// </summary>
        internal bool IsSetServiceCode() => this.ServiceCode != null;

        /// <summary>
        /// Gets and sets the property UsageAccountId. 
        /// <para>
        ///  The Amazon Web Services account ID associated with the usage for this line item.
        /// 
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
        ///  The type of usage for this line item. 
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
