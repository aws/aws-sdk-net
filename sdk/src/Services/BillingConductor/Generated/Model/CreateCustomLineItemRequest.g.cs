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

namespace Amazon.BillingConductor.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCustomLineItem operation. Creates a custom
    /// line item that can be used to create a one-time fixed charge that can be applied to
    /// a single billing group for the current or previous billing period. The one-time fixed
    /// charge is either a fee or discount.
    /// </summary>
    public partial class CreateCustomLineItemRequest : AmazonBillingConductorRequest
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account in which this custom line item will be applied to.
        /// </para>
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property BillingGroupArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) that references the billing group where the custom
        /// line item applies to. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BillingGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the BillingGroupArn property is set.
        /// </summary>
        internal bool IsSetBillingGroupArn() => this.BillingGroupArn != null;

        /// <summary>
        /// Gets and sets the property BillingPeriodRange. 
        /// <para>
        ///  A time range for which the custom line item is effective. 
        /// </para>
        /// </summary>
        public CustomLineItemBillingPeriodRange BillingPeriodRange { get; set; }

        /// <summary>
        /// Checks to see if the BillingPeriodRange property is set.
        /// </summary>
        internal bool IsSetBillingPeriodRange() => this.BillingPeriodRange != null;

        /// <summary>
        /// Gets and sets the property ChargeDetails. 
        /// <para>
        ///  A <c>CustomLineItemChargeDetails</c> that describes the charge details for a custom
        /// line item. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CustomLineItemChargeDetails ChargeDetails { get; set; }

        /// <summary>
        /// Checks to see if the ChargeDetails property is set.
        /// </summary>
        internal bool IsSetChargeDetails() => this.ChargeDetails != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you specify to ensure idempotency of the
        /// request. Idempotency ensures that an API request completes no more than one time.
        /// With an idempotent request, if the original request completes successfully, any subsequent
        /// retries complete successfully without performing any further actions.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property ComputationRule. 
        /// <para>
        ///  Specifies how the custom line item charges are computed. 
        /// </para>
        /// </summary>
        public ComputationRuleEnum ComputationRule { get; set; }

        /// <summary>
        /// Checks to see if the ComputationRule property is set.
        /// </summary>
        internal bool IsSetComputationRule() => this.ComputationRule != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  The description of the custom line item. This is shown on the Bills page in association
        /// with the charge value. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 255)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the custom line item. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PresentationDetails. 
        /// <para>
        ///  Details controlling how the custom line item charges are presented in the bill. Contains
        /// specifications for which service the charges will be shown under. 
        /// </para>
        /// </summary>
        public PresentationObject PresentationDetails { get; set; }

        /// <summary>
        /// Checks to see if the PresentationDetails property is set.
        /// </summary>
        internal bool IsSetPresentationDetails() => this.PresentationDetails != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  A map that contains tag keys and tag values that are attached to a custom line item.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
