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
    /// Information about a Savings Plan.
    /// </summary>
    public partial class SavingsPlan
    {
        /// <summary>
        /// Gets and sets the property Commitment. 
        /// <para>
        /// The hourly commitment amount in the specified currency.
        /// </para>
        /// </summary>
        public string Commitment { get; set; }

        /// <summary>
        /// Checks to see if the Commitment property is set.
        /// </summary>
        internal bool IsSetCommitment() => this.Commitment != null;

        /// <summary>
        /// Gets and sets the property Currency. 
        /// <para>
        /// The currency.
        /// </para>
        /// </summary>
        public CurrencyCode Currency { get; set; }

        /// <summary>
        /// Checks to see if the Currency property is set.
        /// </summary>
        internal bool IsSetCurrency() => this.Currency != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Ec2InstanceFamily. 
        /// <para>
        /// The EC2 instance family.
        /// </para>
        /// </summary>
        public string Ec2InstanceFamily { get; set; }

        /// <summary>
        /// Checks to see if the Ec2InstanceFamily property is set.
        /// </summary>
        internal bool IsSetEc2InstanceFamily() => this.Ec2InstanceFamily != null;

        /// <summary>
        /// Gets and sets the property End. 
        /// <para>
        /// The end time.
        /// </para>
        /// </summary>
        public string End { get; set; }

        /// <summary>
        /// Checks to see if the End property is set.
        /// </summary>
        internal bool IsSetEnd() => this.End != null;

        /// <summary>
        /// Gets and sets the property OfferingId. 
        /// <para>
        /// The ID of the offering.
        /// </para>
        /// </summary>
        public string OfferingId { get; set; }

        /// <summary>
        /// Checks to see if the OfferingId property is set.
        /// </summary>
        internal bool IsSetOfferingId() => this.OfferingId != null;

        /// <summary>
        /// Gets and sets the property PaymentOption. 
        /// <para>
        /// The payment option.
        /// </para>
        /// </summary>
        public SavingsPlanPaymentOption PaymentOption { get; set; }

        /// <summary>
        /// Checks to see if the PaymentOption property is set.
        /// </summary>
        internal bool IsSetPaymentOption() => this.PaymentOption != null;

        /// <summary>
        /// Gets and sets the property ProductTypes. 
        /// <para>
        /// The product types.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ProductTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ProductTypes property is set.
        /// </summary>
        internal bool IsSetProductTypes() => this.ProductTypes != null && (this.ProductTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RecurringPaymentAmount. 
        /// <para>
        /// The recurring payment amount.
        /// </para>
        /// </summary>
        public string RecurringPaymentAmount { get; set; }

        /// <summary>
        /// Checks to see if the RecurringPaymentAmount property is set.
        /// </summary>
        internal bool IsSetRecurringPaymentAmount() => this.RecurringPaymentAmount != null;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region.
        /// </para>
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property ReturnableUntil. 
        /// <para>
        /// The time until when a return for the Savings Plan can be requested. If the Savings
        /// Plan is not returnable, the field reflects the Savings Plans start time.
        /// </para>
        /// </summary>
        public string ReturnableUntil { get; set; }

        /// <summary>
        /// Checks to see if the ReturnableUntil property is set.
        /// </summary>
        internal bool IsSetReturnableUntil() => this.ReturnableUntil != null;

        /// <summary>
        /// Gets and sets the property SavingsPlanArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Savings Plan.
        /// </para>
        /// </summary>
        public string SavingsPlanArn { get; set; }

        /// <summary>
        /// Checks to see if the SavingsPlanArn property is set.
        /// </summary>
        internal bool IsSetSavingsPlanArn() => this.SavingsPlanArn != null;

        /// <summary>
        /// Gets and sets the property SavingsPlanId. 
        /// <para>
        /// The ID of the Savings Plan.
        /// </para>
        /// </summary>
        public string SavingsPlanId { get; set; }

        /// <summary>
        /// Checks to see if the SavingsPlanId property is set.
        /// </summary>
        internal bool IsSetSavingsPlanId() => this.SavingsPlanId != null;

        /// <summary>
        /// Gets and sets the property SavingsPlanType. 
        /// <para>
        /// The plan type.
        /// </para>
        /// </summary>
        public SavingsPlanType SavingsPlanType { get; set; }

        /// <summary>
        /// Checks to see if the SavingsPlanType property is set.
        /// </summary>
        internal bool IsSetSavingsPlanType() => this.SavingsPlanType != null;

        /// <summary>
        /// Gets and sets the property Start. 
        /// <para>
        /// The start time.
        /// </para>
        /// </summary>
        public string Start { get; set; }

        /// <summary>
        /// Checks to see if the Start property is set.
        /// </summary>
        internal bool IsSetStart() => this.Start != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state.
        /// </para>
        /// </summary>
        public SavingsPlanState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

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
        /// Gets and sets the property TermDurationInSeconds. 
        /// <para>
        /// The duration of the term, in seconds.
        /// </para>
        /// </summary>
        public long? TermDurationInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the TermDurationInSeconds property is set.
        /// </summary>
        internal bool IsSetTermDurationInSeconds() => this.TermDurationInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property UpfrontPaymentAmount. 
        /// <para>
        /// The up-front payment amount.
        /// </para>
        /// </summary>
        public string UpfrontPaymentAmount { get; set; }

        /// <summary>
        /// Checks to see if the UpfrontPaymentAmount property is set.
        /// </summary>
        internal bool IsSetUpfrontPaymentAmount() => this.UpfrontPaymentAmount != null;
    }
}
