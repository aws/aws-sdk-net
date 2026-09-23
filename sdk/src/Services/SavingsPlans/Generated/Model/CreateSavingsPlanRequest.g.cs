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

namespace Amazon.SavingsPlans.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSavingsPlan operation. Creates a Savings
    /// Plan.
    /// </summary>
    public partial class CreateSavingsPlanRequest : AmazonSavingsPlansRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Commitment. 
        /// <para>
        /// The hourly commitment, in the same currency of the <c>savingsPlanOfferingId</c>. This
        /// is a value between 0.001 and 1 million. You cannot specify more than five digits after
        /// the decimal point.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Commitment { get; set; }

        /// <summary>
        /// Checks to see if the Commitment property is set.
        /// </summary>
        internal bool IsSetCommitment() => this.Commitment != null;

        /// <summary>
        /// Gets and sets the property PurchaseTime. 
        /// <para>
        /// The purchase time of the Savings Plan in UTC format (YYYY-MM-DDTHH:MM:SSZ).
        /// </para>
        /// </summary>
        public DateTime? PurchaseTime { get; set; }

        /// <summary>
        /// Checks to see if the PurchaseTime property is set.
        /// </summary>
        internal bool IsSetPurchaseTime() => this.PurchaseTime.HasValue;

        /// <summary>
        /// Gets and sets the property SavingsPlanOfferingId. 
        /// <para>
        /// The ID of the offering.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SavingsPlanOfferingId { get; set; }

        /// <summary>
        /// Checks to see if the SavingsPlanOfferingId property is set.
        /// </summary>
        internal bool IsSetSavingsPlanOfferingId() => this.SavingsPlanOfferingId != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// One or more tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UpfrontPaymentAmount. 
        /// <para>
        /// The up-front payment amount. This is a whole number between 50 and 99 percent of the
        /// total value of the Savings Plan. This parameter is only supported if the payment option
        /// is <c>Partial Upfront</c>.
        /// </para>
        /// </summary>
        public string UpfrontPaymentAmount { get; set; }

        /// <summary>
        /// Checks to see if the UpfrontPaymentAmount property is set.
        /// </summary>
        internal bool IsSetUpfrontPaymentAmount() => this.UpfrontPaymentAmount != null;
    }
}
