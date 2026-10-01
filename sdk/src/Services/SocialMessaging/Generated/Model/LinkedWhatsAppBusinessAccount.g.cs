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

namespace Amazon.SocialMessaging.Model
{
    /// <summary>
    /// The details of your linked WhatsApp Business Account.
    /// </summary>
    public partial class LinkedWhatsAppBusinessAccount
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the linked WhatsApp Business Account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 2048)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property DatasetId. 
        /// <para>
        /// The Meta Conversions API dataset ID associated with this WhatsApp Business Account.
        /// This value is a numeric string of 10 to 20 digits. This field is not present when
        /// no dataset has been created for this account.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 20)]
        public string DatasetId { get; set; }

        /// <summary>
        /// Checks to see if the DatasetId property is set.
        /// </summary>
        internal bool IsSetDatasetId() => this.DatasetId != null;

        /// <summary>
        /// Gets and sets the property EventDestinations. 
        /// <para>
        /// The event destinations for the linked WhatsApp Business Account.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Max = 1)]
        public List<WhatsAppBusinessAccountEventDestination> EventDestinations { get; set; } = AWSConfigs.InitializeCollections ? new List<WhatsAppBusinessAccountEventDestination>() : null;

        /// <summary>
        /// Checks to see if the EventDestinations property is set.
        /// </summary>
        internal bool IsSetEventDestinations() => this.EventDestinations != null && (this.EventDestinations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the linked WhatsApp Business Account, formatted as <c>waba-01234567890123456789012345678901</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 115)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LinkDate. 
        /// <para>
        /// The date the WhatsApp Business Account was linked.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LinkDate { get; set; }

        /// <summary>
        /// Checks to see if the LinkDate property is set.
        /// </summary>
        internal bool IsSetLinkDate() => this.LinkDate.HasValue;

        /// <summary>
        /// Gets and sets the property MarketingMessagesOnboardingStatus. 
        /// <para>
        /// The onboarding status for the Marketing Messages API. This value is fetched from Meta
        /// and indicates whether the WhatsApp Business Account is onboarded for Meta's Marketing
        /// Messages API.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 100)]
        public string MarketingMessagesOnboardingStatus { get; set; }

        /// <summary>
        /// Checks to see if the MarketingMessagesOnboardingStatus property is set.
        /// </summary>
        internal bool IsSetMarketingMessagesOnboardingStatus() => this.MarketingMessagesOnboardingStatus != null;

        /// <summary>
        /// Gets and sets the property PhoneNumbers. 
        /// <para>
        /// The phone numbers associated with the Linked WhatsApp Business Account.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<WhatsAppPhoneNumberSummary> PhoneNumbers { get; set; } = AWSConfigs.InitializeCollections ? new List<WhatsAppPhoneNumberSummary>() : null;

        /// <summary>
        /// Checks to see if the PhoneNumbers property is set.
        /// </summary>
        internal bool IsSetPhoneNumbers() => this.PhoneNumbers != null && (this.PhoneNumbers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RegistrationStatus. 
        /// <para>
        /// The registration status of the linked WhatsApp Business Account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RegistrationStatus RegistrationStatus { get; set; }

        /// <summary>
        /// Checks to see if the RegistrationStatus property is set.
        /// </summary>
        internal bool IsSetRegistrationStatus() => this.RegistrationStatus != null;

        /// <summary>
        /// Gets and sets the property WabaId. 
        /// <para>
        /// The WhatsApp Business Account ID from meta.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string WabaId { get; set; }

        /// <summary>
        /// Checks to see if the WabaId property is set.
        /// </summary>
        internal bool IsSetWabaId() => this.WabaId != null;

        /// <summary>
        /// Gets and sets the property WabaName. 
        /// <para>
        /// The name of the linked WhatsApp Business Account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 200)]
        public string WabaName { get; set; }

        /// <summary>
        /// Checks to see if the WabaName property is set.
        /// </summary>
        internal bool IsSetWabaName() => this.WabaName != null;
    }
}
