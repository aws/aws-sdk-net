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
    /// Represents a successfully created item in a batch operation for workload estimate
    /// usage.
    /// </summary>
    public partial class BatchCreateWorkloadEstimateUsageItem
    {
        private double? _cost;
        private CurrencyCode _currency;
        private string _group;
        private HistoricalUsageEntity _historicalUsage;
        private string _id;
        private string _key;
        private string _location;
        private string _operation;
        private WorkloadEstimateUsageQuantity _quantity;
        private string _serviceCode;
        private WorkloadEstimateCostStatus _status;
        private string _usageAccountId;
        private string _usageType;

        /// <summary>
        /// Gets and sets the property Cost. 
        /// <para>
        ///  The estimated cost associated with this usage. 
        /// </para>
        /// </summary>
        public double? Cost
        {
            get { return this._cost; }
            set { this._cost = value; }
        }

        // Check to see if Cost property is set
        internal bool IsSetCost()
        {
            return this._cost.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Currency. 
        /// <para>
        ///  The currency of the estimated cost. 
        /// </para>
        /// </summary>
        public CurrencyCode Currency
        {
            get { return this._currency; }
            set { this._currency = value; }
        }

        // Check to see if Currency property is set
        internal bool IsSetCurrency()
        {
            return this._currency != null;
        }

        /// <summary>
        /// Gets and sets the property Group. 
        /// <para>
        ///  The group identifier for the created usage estimate. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=30)]
        public string Group
        {
            get { return this._group; }
            set { this._group = value; }
        }

        // Check to see if Group property is set
        internal bool IsSetGroup()
        {
            return this._group != null;
        }

        /// <summary>
        /// Gets and sets the property HistoricalUsage. 
        /// <para>
        ///  Historical usage data associated with this estimate, if available. 
        /// </para>
        /// </summary>
        public HistoricalUsageEntity HistoricalUsage
        {
            get { return this._historicalUsage; }
            set { this._historicalUsage = value; }
        }

        // Check to see if HistoricalUsage property is set
        internal bool IsSetHistoricalUsage()
        {
            return this._historicalUsage != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  The unique identifier assigned to the created usage estimate. 
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
        /// Gets and sets the property Key. 
        /// <para>
        ///  The key of the successfully created entry. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        ///  The location associated with this usage estimate. 
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
        ///  The specific operation associated with this usage estimate. 
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
        /// Gets and sets the property Quantity. 
        /// <para>
        ///  The estimated usage quantity. 
        /// </para>
        /// </summary>
        public WorkloadEstimateUsageQuantity Quantity
        {
            get { return this._quantity; }
            set { this._quantity = value; }
        }

        // Check to see if Quantity property is set
        internal bool IsSetQuantity()
        {
            return this._quantity != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceCode. 
        /// <para>
        ///  The Amazon Web Services service code for this usage estimate. 
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
        /// Gets and sets the property Status. 
        /// <para>
        ///  The current status of the created usage estimate. 
        /// </para>
        /// </summary>
        public WorkloadEstimateCostStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property UsageAccountId. 
        /// <para>
        ///  The Amazon Web Services account ID associated with the created usage estimate. 
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
        ///  The type of usage that was estimated. 
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