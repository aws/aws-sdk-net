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
 * Do not modify this file. This file is generated from the savingsplans-2019-06-28.normal.json service model.
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
        private string _commitment;
        private CurrencyCode _currency;
        private string _description;
        private string _ec2InstanceFamily;
        private string _end;
        private string _offeringId;
        private SavingsPlanPaymentOption _paymentOption;
        private List<string> _productTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _recurringPaymentAmount;
        private string _region;
        private string _returnableUntil;
        private string _savingsPlanArn;
        private string _savingsPlanId;
        private SavingsPlanType _savingsPlanType;
        private string _start;
        private SavingsPlanState _state;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private long? _termDurationInSeconds;
        private string _upfrontPaymentAmount;

        /// <summary>
        /// Gets and sets the property Commitment. 
        /// <para>
        /// The hourly commitment amount in the specified currency.
        /// </para>
        /// </summary>
        public string Commitment
        {
            get { return this._commitment; }
            set { this._commitment = value; }
        }

        // Check to see if Commitment property is set
        internal bool IsSetCommitment()
        {
            return this._commitment != null;
        }

        /// <summary>
        /// Gets and sets the property Currency. 
        /// <para>
        /// The currency.
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Ec2InstanceFamily. 
        /// <para>
        /// The EC2 instance family.
        /// </para>
        /// </summary>
        public string Ec2InstanceFamily
        {
            get { return this._ec2InstanceFamily; }
            set { this._ec2InstanceFamily = value; }
        }

        // Check to see if Ec2InstanceFamily property is set
        internal bool IsSetEc2InstanceFamily()
        {
            return this._ec2InstanceFamily != null;
        }

        /// <summary>
        /// Gets and sets the property End. 
        /// <para>
        /// The end time.
        /// </para>
        /// </summary>
        public string End
        {
            get { return this._end; }
            set { this._end = value; }
        }

        // Check to see if End property is set
        internal bool IsSetEnd()
        {
            return this._end != null;
        }

        /// <summary>
        /// Gets and sets the property OfferingId. 
        /// <para>
        /// The ID of the offering.
        /// </para>
        /// </summary>
        public string OfferingId
        {
            get { return this._offeringId; }
            set { this._offeringId = value; }
        }

        // Check to see if OfferingId property is set
        internal bool IsSetOfferingId()
        {
            return this._offeringId != null;
        }

        /// <summary>
        /// Gets and sets the property PaymentOption. 
        /// <para>
        /// The payment option.
        /// </para>
        /// </summary>
        public SavingsPlanPaymentOption PaymentOption
        {
            get { return this._paymentOption; }
            set { this._paymentOption = value; }
        }

        // Check to see if PaymentOption property is set
        internal bool IsSetPaymentOption()
        {
            return this._paymentOption != null;
        }

        /// <summary>
        /// Gets and sets the property ProductTypes. 
        /// <para>
        /// The product types.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ProductTypes
        {
            get { return this._productTypes; }
            set { this._productTypes = value; }
        }

        // Check to see if ProductTypes property is set
        internal bool IsSetProductTypes()
        {
            return this._productTypes != null && (this._productTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RecurringPaymentAmount. 
        /// <para>
        /// The recurring payment amount.
        /// </para>
        /// </summary>
        public string RecurringPaymentAmount
        {
            get { return this._recurringPaymentAmount; }
            set { this._recurringPaymentAmount = value; }
        }

        // Check to see if RecurringPaymentAmount property is set
        internal bool IsSetRecurringPaymentAmount()
        {
            return this._recurringPaymentAmount != null;
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region.
        /// </para>
        /// </summary>
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property ReturnableUntil. 
        /// <para>
        /// The time until when a return for the Savings Plan can be requested. If the Savings
        /// Plan is not returnable, the field reflects the Savings Plan start time.
        /// </para>
        /// </summary>
        public string ReturnableUntil
        {
            get { return this._returnableUntil; }
            set { this._returnableUntil = value; }
        }

        // Check to see if ReturnableUntil property is set
        internal bool IsSetReturnableUntil()
        {
            return this._returnableUntil != null;
        }

        /// <summary>
        /// Gets and sets the property SavingsPlanArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Savings Plan.
        /// </para>
        /// </summary>
        public string SavingsPlanArn
        {
            get { return this._savingsPlanArn; }
            set { this._savingsPlanArn = value; }
        }

        // Check to see if SavingsPlanArn property is set
        internal bool IsSetSavingsPlanArn()
        {
            return this._savingsPlanArn != null;
        }

        /// <summary>
        /// Gets and sets the property SavingsPlanId. 
        /// <para>
        /// The ID of the Savings Plan.
        /// </para>
        /// </summary>
        public string SavingsPlanId
        {
            get { return this._savingsPlanId; }
            set { this._savingsPlanId = value; }
        }

        // Check to see if SavingsPlanId property is set
        internal bool IsSetSavingsPlanId()
        {
            return this._savingsPlanId != null;
        }

        /// <summary>
        /// Gets and sets the property SavingsPlanType. 
        /// <para>
        /// The plan type.
        /// </para>
        /// </summary>
        public SavingsPlanType SavingsPlanType
        {
            get { return this._savingsPlanType; }
            set { this._savingsPlanType = value; }
        }

        // Check to see if SavingsPlanType property is set
        internal bool IsSetSavingsPlanType()
        {
            return this._savingsPlanType != null;
        }

        /// <summary>
        /// Gets and sets the property Start. 
        /// <para>
        /// The start time.
        /// </para>
        /// </summary>
        public string Start
        {
            get { return this._start; }
            set { this._start = value; }
        }

        // Check to see if Start property is set
        internal bool IsSetStart()
        {
            return this._start != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state.
        /// </para>
        /// </summary>
        public SavingsPlanState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// One or more tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TermDurationInSeconds. 
        /// <para>
        /// The duration of the term, in seconds.
        /// </para>
        /// </summary>
        public long? TermDurationInSeconds
        {
            get { return this._termDurationInSeconds; }
            set { this._termDurationInSeconds = value; }
        }

        // Check to see if TermDurationInSeconds property is set
        internal bool IsSetTermDurationInSeconds()
        {
            return this._termDurationInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpfrontPaymentAmount. 
        /// <para>
        /// The up-front payment amount.
        /// </para>
        /// </summary>
        public string UpfrontPaymentAmount
        {
            get { return this._upfrontPaymentAmount; }
            set { this._upfrontPaymentAmount = value; }
        }

        // Check to see if UpfrontPaymentAmount property is set
        internal bool IsSetUpfrontPaymentAmount()
        {
            return this._upfrontPaymentAmount != null;
        }

    }
}