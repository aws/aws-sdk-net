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
    /// This is the response object from the GetUsageLinesEstimatedCost operation.
    /// </summary>
    public partial class GetUsageLinesEstimatedCostResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Currency. 
        /// <para>
        ///  The currency of the costs in the response. 
        /// </para>
        /// </summary>
        public CurrencyCode Currency { get; set; }

        /// <summary>
        /// Checks to see if the Currency property is set.
        /// </summary>
        internal bool IsSetCurrency() => this.Currency != null;

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        ///  The usage lines that couldn't be priced, and the reason that each one couldn't be
        /// priced. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<GetUsageLinesEstimatedCostError> Errors { get; set; } = AWSConfigs.InitializeCollections ? new List<GetUsageLinesEstimatedCostError>() : null;

        /// <summary>
        /// Checks to see if the Errors property is set.
        /// </summary>
        internal bool IsSetErrors() => this.Errors != null && (this.Errors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LineItems. 
        /// <para>
        ///  The estimated cost of each usage line that was priced. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<GetUsageLinesEstimatedCostLineItem> LineItems { get; set; } = AWSConfigs.InitializeCollections ? new List<GetUsageLinesEstimatedCostLineItem>() : null;

        /// <summary>
        /// Checks to see if the LineItems property is set.
        /// </summary>
        internal bool IsSetLineItems() => this.LineItems != null && (this.LineItems.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RateType. 
        /// <para>
        ///  The type of pricing rates used to estimate the cost of the usage lines. 
        /// </para>
        /// </summary>
        public RateType RateType { get; set; }

        /// <summary>
        /// Checks to see if the RateType property is set.
        /// </summary>
        internal bool IsSetRateType() => this.RateType != null;

        /// <summary>
        /// Gets and sets the property TotalCost. 
        /// <para>
        ///  The sum of the estimated costs of all usage lines that were priced. Usage lines returned
        /// in <c>errors</c> aren't included. 
        /// </para>
        /// </summary>
        public double? TotalCost { get; set; }

        /// <summary>
        /// Checks to see if the TotalCost property is set.
        /// </summary>
        internal bool IsSetTotalCost() => this.TotalCost.HasValue;
    }
}
