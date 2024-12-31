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
    /// Mixin for common fields returned by CRUD APIs
    /// </summary>
    public partial class CreateWorkloadEstimateResponse : AmazonWebServiceResponse
    {
        private CurrencyCode _costCurrency;
        private DateTime? _createdAt;
        private DateTime? _expiresAt;
        private string _failureMessage;
        private string _id;
        private string _name;
        private DateTime? _rateTimestamp;
        private WorkloadEstimateRateType _rateType;
        private WorkloadEstimateStatus _status;
        private double? _totalCost;

        /// <summary>
        /// Gets and sets the property CostCurrency. 
        /// <para>
        ///  The currency of the estimated cost. 
        /// </para>
        /// </summary>
        public CurrencyCode CostCurrency
        {
            get { return this._costCurrency; }
            set { this._costCurrency = value; }
        }

        // Check to see if CostCurrency property is set
        internal bool IsSetCostCurrency()
        {
            return this._costCurrency != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        ///  The timestamp when the workload estimate was created. 
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExpiresAt. 
        /// <para>
        ///  The timestamp when the workload estimate will expire. 
        /// </para>
        /// </summary>
        public DateTime? ExpiresAt
        {
            get { return this._expiresAt; }
            set { this._expiresAt = value; }
        }

        // Check to see if ExpiresAt property is set
        internal bool IsSetExpiresAt()
        {
            return this._expiresAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailureMessage. 
        /// <para>
        ///  An error message if the workload estimate creation failed. 
        /// </para>
        /// </summary>
        public string FailureMessage
        {
            get { return this._failureMessage; }
            set { this._failureMessage = value; }
        }

        // Check to see if FailureMessage property is set
        internal bool IsSetFailureMessage()
        {
            return this._failureMessage != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  The unique identifier for the created workload estimate. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
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
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the created workload estimate. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=64)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RateTimestamp. 
        /// <para>
        ///  The timestamp of the pricing rates used for the estimate. 
        /// </para>
        /// </summary>
        public DateTime? RateTimestamp
        {
            get { return this._rateTimestamp; }
            set { this._rateTimestamp = value; }
        }

        // Check to see if RateTimestamp property is set
        internal bool IsSetRateTimestamp()
        {
            return this._rateTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RateType. 
        /// <para>
        ///  The type of pricing rates used for the estimate. 
        /// </para>
        /// </summary>
        public WorkloadEstimateRateType RateType
        {
            get { return this._rateType; }
            set { this._rateType = value; }
        }

        // Check to see if RateType property is set
        internal bool IsSetRateType()
        {
            return this._rateType != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The current status of the workload estimate. 
        /// </para>
        /// </summary>
        public WorkloadEstimateStatus Status
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
        /// Gets and sets the property TotalCost. 
        /// <para>
        ///  The total estimated cost for the workload. 
        /// </para>
        /// </summary>
        public double? TotalCost
        {
            get { return this._totalCost; }
            set { this._totalCost = value; }
        }

        // Check to see if TotalCost property is set
        internal bool IsSetTotalCost()
        {
            return this._totalCost.HasValue; 
        }

    }
}