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
    /// This is the response object from the GetWorkloadEstimate operation.
    /// </summary>
    public partial class GetWorkloadEstimateResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CostCurrency. 
        /// <para>
        ///  The currency of the estimated cost. 
        /// </para>
        /// </summary>
        public CurrencyCode CostCurrency { get; set; }

        /// <summary>
        /// Checks to see if the CostCurrency property is set.
        /// </summary>
        internal bool IsSetCostCurrency() => this.CostCurrency != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        ///  The timestamp when the workload estimate was created. 
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ExpiresAt. 
        /// <para>
        ///  The timestamp when the workload estimate will expire. 
        /// </para>
        /// </summary>
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Checks to see if the ExpiresAt property is set.
        /// </summary>
        internal bool IsSetExpiresAt() => this.ExpiresAt.HasValue;

        /// <summary>
        /// Gets and sets the property FailureMessage. 
        /// <para>
        ///  An error message if the workload estimate retrieval failed. 
        /// </para>
        /// </summary>
        public string FailureMessage { get; set; }

        /// <summary>
        /// Checks to see if the FailureMessage property is set.
        /// </summary>
        internal bool IsSetFailureMessage() => this.FailureMessage != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  The unique identifier of the retrieved workload estimate. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the retrieved workload estimate. 
        /// </para>
        /// </summary>
        [AWSProperty(Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RateTimestamp. 
        /// <para>
        ///  The timestamp of the pricing rates used for the estimate. 
        /// </para>
        /// </summary>
        public DateTime? RateTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the RateTimestamp property is set.
        /// </summary>
        internal bool IsSetRateTimestamp() => this.RateTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property RateType. 
        /// <para>
        ///  The type of pricing rates used for the estimate. 
        /// </para>
        /// </summary>
        public WorkloadEstimateRateType RateType { get; set; }

        /// <summary>
        /// Checks to see if the RateType property is set.
        /// </summary>
        internal bool IsSetRateType() => this.RateType != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The current status of the workload estimate. 
        /// </para>
        /// </summary>
        public WorkloadEstimateStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TotalCost. 
        /// <para>
        ///  The total estimated cost for the workload. 
        /// </para>
        /// </summary>
        public double? TotalCost { get; set; }

        /// <summary>
        /// Checks to see if the TotalCost property is set.
        /// </summary>
        internal bool IsSetTotalCost() => this.TotalCost.HasValue;
    }
}
