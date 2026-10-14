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

namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// The information for all SenderIds in an Amazon Web Services account.
    /// </summary>
    public partial class SenderIdInformation
    {
        /// <summary>
        /// Gets and sets the property DeletionProtectionEnabled. 
        /// <para>
        /// By default this is set to false. When set to true the sender ID can't be deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? DeletionProtectionEnabled { get; set; }

        /// <summary>
        /// Checks to see if the DeletionProtectionEnabled property is set.
        /// </summary>
        internal bool IsSetDeletionProtectionEnabled() => this.DeletionProtectionEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property IsoCountryCode. 
        /// <para>
        /// The two-character code, in ISO 3166-1 alpha-2 format, for the country or region. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 2)]
        public string IsoCountryCode { get; set; }

        /// <summary>
        /// Checks to see if the IsoCountryCode property is set.
        /// </summary>
        internal bool IsSetIsoCountryCode() => this.IsoCountryCode != null;

        /// <summary>
        /// Gets and sets the property MessageTypes. 
        /// <para>
        /// The type of message. Valid values are TRANSACTIONAL for messages that are critical
        /// or time-sensitive and PROMOTIONAL for messages that aren't critical or time-sensitive.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Max = 2)]
        public List<string> MessageTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the MessageTypes property is set.
        /// </summary>
        internal bool IsSetMessageTypes() => this.MessageTypes != null && (this.MessageTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MessagingLimits. 
        /// <para>
        /// The messaging limits that apply to the sender ID, including the per-capability send
        /// rates.
        /// </para>
        /// </summary>
        public MessagingLimits MessagingLimits { get; set; }

        /// <summary>
        /// Checks to see if the MessagingLimits property is set.
        /// </summary>
        internal bool IsSetMessagingLimits() => this.MessagingLimits != null;

        /// <summary>
        /// Gets and sets the property MonthlyLeasingPrice. 
        /// <para>
        /// The monthly leasing price, in US dollars.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string MonthlyLeasingPrice { get; set; }

        /// <summary>
        /// Checks to see if the MonthlyLeasingPrice property is set.
        /// </summary>
        internal bool IsSetMonthlyLeasingPrice() => this.MonthlyLeasingPrice != null;

        /// <summary>
        /// Gets and sets the property PricingTier. 
        /// <para>
        /// The pricing model.
        /// </para>
        /// </summary>
        public string PricingTier { get; set; }

        /// <summary>
        /// Checks to see if the PricingTier property is set.
        /// </summary>
        internal bool IsSetPricingTier() => this.PricingTier != null;

        /// <summary>
        /// Gets and sets the property Registered. 
        /// <para>
        /// True if the sender ID is registered.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Registered { get; set; }

        /// <summary>
        /// Checks to see if the Registered property is set.
        /// </summary>
        internal bool IsSetRegistered() => this.Registered.HasValue;

        /// <summary>
        /// Gets and sets the property RegistrationId. 
        /// <para>
        /// The unique identifier for the registration.
        /// </para>
        /// </summary>
        public string RegistrationId { get; set; }

        /// <summary>
        /// Checks to see if the RegistrationId property is set.
        /// </summary>
        internal bool IsSetRegistrationId() => this.RegistrationId != null;

        /// <summary>
        /// Gets and sets the property SenderId. 
        /// <para>
        /// The alphanumeric sender ID in a specific country that you'd like to describe.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 11)]
        public string SenderId { get; set; }

        /// <summary>
        /// Checks to see if the SenderId property is set.
        /// </summary>
        internal bool IsSetSenderId() => this.SenderId != null;

        /// <summary>
        /// Gets and sets the property SenderIdArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) associated with the SenderId.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SenderIdArn { get; set; }

        /// <summary>
        /// Checks to see if the SenderIdArn property is set.
        /// </summary>
        internal bool IsSetSenderIdArn() => this.SenderIdArn != null;
    }
}
