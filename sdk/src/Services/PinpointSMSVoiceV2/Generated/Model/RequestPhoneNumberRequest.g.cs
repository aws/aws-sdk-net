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
    /// Container for the parameters to the RequestPhoneNumber operation. Request an origination
    /// phone number for use in your account. For more information on phone number request
    /// see <a href="https://docs.aws.amazon.com/sms-voice/latest/userguide/phone-numbers-request.html">Request
    /// a phone number</a> in the <i>End User Messaging SMS User Guide</i>.
    /// </summary>
    public partial class RequestPhoneNumberRequest : AmazonPinpointSMSVoiceV2Request
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. If you don't specify a client token, a randomly generated token is used for
        /// the request to ensure idempotency.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DeletionProtectionEnabled. 
        /// <para>
        /// By default this is set to false. When set to true the phone number can't be deleted.
        /// </para>
        /// </summary>
        public bool? DeletionProtectionEnabled { get; set; }

        /// <summary>
        /// Checks to see if the DeletionProtectionEnabled property is set.
        /// </summary>
        internal bool IsSetDeletionProtectionEnabled() => this.DeletionProtectionEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property InternationalSendingEnabled. 
        /// <para>
        /// By default this is set to false. When set to true the international sending of phone
        /// number is Enabled. 
        /// </para>
        /// </summary>
        public bool? InternationalSendingEnabled { get; set; }

        /// <summary>
        /// Checks to see if the InternationalSendingEnabled property is set.
        /// </summary>
        internal bool IsSetInternationalSendingEnabled() => this.InternationalSendingEnabled.HasValue;

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
        /// Gets and sets the property MessageType. 
        /// <para>
        /// The type of message. Valid values are <c>TRANSACTIONAL</c> for messages that are critical
        /// or time-sensitive and <c>PROMOTIONAL</c> for messages that aren't critical or time-sensitive.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MessageType MessageType { get; set; }

        /// <summary>
        /// Checks to see if the MessageType property is set.
        /// </summary>
        internal bool IsSetMessageType() => this.MessageType != null;

        /// <summary>
        /// Gets and sets the property NumberCapabilities. 
        /// <para>
        /// Indicates if the phone number will be used for text messages, voice messages, or both.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 4)]
        public List<string> NumberCapabilities { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the NumberCapabilities property is set.
        /// </summary>
        internal bool IsSetNumberCapabilities() => this.NumberCapabilities != null && (this.NumberCapabilities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NumberPreference. 
        /// <para>
        /// An optional selection preference used to request a specific phone number, such as
        /// a number that starts with, ends with, or contains a particular digit pattern. You
        /// can specify at most one preference. Number preferences apply only to <c>TEN_DLC</c>
        /// requests in the <c>US</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<NumberPreferenceItem> NumberPreference { get; set; } = AWSConfigs.InitializeCollections ? new List<NumberPreferenceItem>() : null;

        /// <summary>
        /// Checks to see if the NumberPreference property is set.
        /// </summary>
        internal bool IsSetNumberPreference() => this.NumberPreference != null && (this.NumberPreference.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NumberType. 
        /// <para>
        /// The type of phone number to request.
        /// </para>
        ///  
        /// <para>
        /// When you request a <c>SIMULATOR</c> phone number, you must set <b>MessageType</b>
        /// as <c>TRANSACTIONAL</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RequestableNumberType NumberType { get; set; }

        /// <summary>
        /// Checks to see if the NumberType property is set.
        /// </summary>
        internal bool IsSetNumberType() => this.NumberType != null;

        /// <summary>
        /// Gets and sets the property OptOutListName. 
        /// <para>
        /// The name of the OptOutList to associate with the phone number. You can use the OptOutListName
        /// or OptOutListArn.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you are using a shared End User Messaging SMS resource then you must use the full
        /// Amazon Resource Name(ARN).
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string OptOutListName { get; set; }

        /// <summary>
        /// Checks to see if the OptOutListName property is set.
        /// </summary>
        internal bool IsSetOptOutListName() => this.OptOutListName != null;

        /// <summary>
        /// Gets and sets the property PoolId. 
        /// <para>
        /// The pool to associated with the phone number. You can use the PoolId or PoolArn. 
        /// </para>
        ///  <important> 
        /// <para>
        /// If you are using a shared End User Messaging SMS resource then you must use the full
        /// Amazon Resource Name(ARN).
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string PoolId { get; set; }

        /// <summary>
        /// Checks to see if the PoolId property is set.
        /// </summary>
        internal bool IsSetPoolId() => this.PoolId != null;

        /// <summary>
        /// Gets and sets the property RegistrationId. 
        /// <para>
        /// Use this field to attach your phone number for an external registration process.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string RegistrationId { get; set; }

        /// <summary>
        /// Checks to see if the RegistrationId property is set.
        /// </summary>
        internal bool IsSetRegistrationId() => this.RegistrationId != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of tags (key and value pairs) to associate with the requested phone number.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
