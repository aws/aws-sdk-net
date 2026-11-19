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
    /// Container for the parameters to the GetUsageLinesEstimatedCost operation. Retrieves
    /// the estimated cost of a list of usage lines. Each usage line identifies a billing
    /// line by its service code, usage type, and operation, and includes the usage amount
    /// to price. The estimate is based on Amazon Web Services pricing data and the rate type
    /// you choose. It doesn't include taxes, and your actual charges depend on your usage.
    /// <para> The response includes the estimated cost of each usage line that was priced.
    /// It also includes each usage line that couldn't be priced, and the reason it couldn't
    /// be priced. </para>
    /// </summary>
    public partial class GetUsageLinesEstimatedCostRequest : AmazonBCMPricingCalculatorRequest
    {
        /// <summary>
        /// Gets and sets the property RateType. 
        /// <para>
        ///  The type of pricing rates to use to estimate the cost of the usage lines. You can
        /// only use a rate type that your Pricing Calculator rate preferences allow. If you use
        /// billing transfer as a bill source account, you can only use BEFORE_DISCOUNTS 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RateType RateType { get; set; }

        /// <summary>
        /// Checks to see if the RateType property is set.
        /// </summary>
        internal bool IsSetRateType() => this.RateType != null;

        /// <summary>
        /// Gets and sets the property Usage. 
        /// <para>
        ///  The usage lines that you want to estimate. You can include up to 500 usage lines
        /// in a request. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 500)]
        public List<GetUsageLinesEstimatedCostInput> Usage { get; set; } = AWSConfigs.InitializeCollections ? new List<GetUsageLinesEstimatedCostInput>() : null;

        /// <summary>
        /// Checks to see if the Usage property is set.
        /// </summary>
        internal bool IsSetUsage() => this.Usage != null && (this.Usage.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
