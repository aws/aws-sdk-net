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
 * Do not modify this file. This file is generated from the bcm-pricing-calculator-2024-06-19.normal.json service model.
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
        private string _availabilityZone;
        private CostAmount _estimatedCost;
        private UsageQuantityResult _estimatedUsageQuantity;
        private CostAmount _historicalCost;
        private UsageQuantityResult _historicalUsageQuantity;
        private string _id;
        private string _lineItemId;
        private string _lineItemType;
        private string _location;
        private string _operation;
        private string _payerAccountId;
        private List<string> _savingsPlanArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _serviceCode;
        private string _usageAccountId;
        private string _usageType;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        ///  The availability zone associated with this line item, if applicable. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=32)]
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property EstimatedCost. 
        /// <para>
        ///  The estimated cost for this line item. 
        /// </para>
        /// </summary>
        public CostAmount EstimatedCost
        {
            get { return this._estimatedCost; }
            set { this._estimatedCost = value; }
        }

        // Check to see if EstimatedCost property is set
        internal bool IsSetEstimatedCost()
        {
            return this._estimatedCost != null;
        }

        /// <summary>
        /// Gets and sets the property EstimatedUsageQuantity. 
        /// <para>
        ///  The estimated usage quantity for this line item. 
        /// </para>
        /// </summary>
        public UsageQuantityResult EstimatedUsageQuantity
        {
            get { return this._estimatedUsageQuantity; }
            set { this._estimatedUsageQuantity = value; }
        }

        // Check to see if EstimatedUsageQuantity property is set
        internal bool IsSetEstimatedUsageQuantity()
        {
            return this._estimatedUsageQuantity != null;
        }

        /// <summary>
        /// Gets and sets the property HistoricalCost. 
        /// <para>
        ///  The historical cost for this line item. 
        /// </para>
        /// </summary>
        public CostAmount HistoricalCost
        {
            get { return this._historicalCost; }
            set { this._historicalCost = value; }
        }

        // Check to see if HistoricalCost property is set
        internal bool IsSetHistoricalCost()
        {
            return this._historicalCost != null;
        }

        /// <summary>
        /// Gets and sets the property HistoricalUsageQuantity. 
        /// <para>
        ///  The historical usage quantity for this line item. 
        /// </para>
        /// </summary>
        public UsageQuantityResult HistoricalUsageQuantity
        {
            get { return this._historicalUsageQuantity; }
            set { this._historicalUsageQuantity = value; }
        }

        // Check to see if HistoricalUsageQuantity property is set
        internal bool IsSetHistoricalUsageQuantity()
        {
            return this._historicalUsageQuantity != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  The unique identifier of this line item. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LineItemId. 
        /// <para>
        ///  The line item identifier from the original bill. 
        /// </para>
        /// </summary>
        public string LineItemId
        {
            get { return this._lineItemId; }
            set { this._lineItemId = value; }
        }

        // Check to see if LineItemId property is set
        internal bool IsSetLineItemId()
        {
            return this._lineItemId != null;
        }

        /// <summary>
        /// Gets and sets the property LineItemType. 
        /// <para>
        ///  The type of this line item (e.g., Usage, Tax, Credit). 
        /// </para>
        /// </summary>
        public string LineItemType
        {
            get { return this._lineItemType; }
            set { this._lineItemType = value; }
        }

        // Check to see if LineItemType property is set
        internal bool IsSetLineItemType()
        {
            return this._lineItemType != null;
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        ///  The location associated with this line item. 
        /// </para>
        /// </summary>
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property Operation. 
        /// <para>
        ///  The specific operation associated with this line item. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=32)]
        public string Operation
        {
            get { return this._operation; }
            set { this._operation = value; }
        }

        // Check to see if Operation property is set
        internal bool IsSetOperation()
        {
            return this._operation != null;
        }

        /// <summary>
        /// Gets and sets the property PayerAccountId. 
        /// <para>
        ///  The Amazon Web Services account ID of the payer for this line item. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string PayerAccountId
        {
            get { return this._payerAccountId; }
            set { this._payerAccountId = value; }
        }

        // Check to see if PayerAccountId property is set
        internal bool IsSetPayerAccountId()
        {
            return this._payerAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property SavingsPlanArns. 
        /// <para>
        ///  The Amazon Resource Names (ARNs) of any Savings Plans applied to this line item.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SavingsPlanArns
        {
            get { return this._savingsPlanArns; }
            set { this._savingsPlanArns = value; }
        }

        // Check to see if SavingsPlanArns property is set
        internal bool IsSetSavingsPlanArns()
        {
            return this._savingsPlanArns != null && (this._savingsPlanArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ServiceCode. 
        /// <para>
        ///  The Amazon Web Services service code associated with this line item. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=32)]
        public string ServiceCode
        {
            get { return this._serviceCode; }
            set { this._serviceCode = value; }
        }

        // Check to see if ServiceCode property is set
        internal bool IsSetServiceCode()
        {
            return this._serviceCode != null;
        }

        /// <summary>
        /// Gets and sets the property UsageAccountId. 
        /// <para>
        ///  The Amazon Web Services account ID associated with the usage for this line item.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string UsageAccountId
        {
            get { return this._usageAccountId; }
            set { this._usageAccountId = value; }
        }

        // Check to see if UsageAccountId property is set
        internal bool IsSetUsageAccountId()
        {
            return this._usageAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property UsageType. 
        /// <para>
        ///  The type of usage for this line item. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=128)]
        public string UsageType
        {
            get { return this._usageType; }
            set { this._usageType = value; }
        }

        // Check to see if UsageType property is set
        internal bool IsSetUsageType()
        {
            return this._usageType != null;
        }

    }
}