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
    /// Container for the parameters to the CreatePool operation. Creates a new pool and associates
    /// the specified origination identity to the pool. A pool can include one or more phone
    /// numbers and SenderIds that are associated with your Amazon Web Services account. <para>
    /// The new pool inherits its configuration from the specified origination identity. This
    /// includes keywords, message type, opt-out list, two-way configuration, and self-managed
    /// opt-out configuration. Deletion protection isn't inherited from the origination identity
    /// and defaults to false. </para> <para> If the origination identity is a phone number
    /// and is already associated with another pool, an error is returned. A sender ID can
    /// be associated with multiple pools. </para>
    /// </summary>
    public partial class CreatePoolRequest : AmazonPinpointSMSVoiceV2Request
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
        /// By default this is set to false. When set to true the pool can't be deleted. You can
        /// change this value using the <a href="https://docs.aws.amazon.com/pinpoint/latest/apireference_smsvoicev2/API_UpdatePool.html">UpdatePool</a>
        /// action.
        /// </para>
        /// </summary>
        public bool? DeletionProtectionEnabled { get; set; }

        /// <summary>
        /// Checks to see if the DeletionProtectionEnabled property is set.
        /// </summary>
        internal bool IsSetDeletionProtectionEnabled() => this.DeletionProtectionEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property IsoCountryCode. 
        /// <para>
        /// The new two-character code, in ISO 3166-1 alpha-2 format, for the country or region
        /// of the new pool. This field is optional and is not required for origination identity
        /// types that are not country-specific, such as RCS agents.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 2)]
        public string IsoCountryCode { get; set; }

        /// <summary>
        /// Checks to see if the IsoCountryCode property is set.
        /// </summary>
        internal bool IsSetIsoCountryCode() => this.IsoCountryCode != null;

        /// <summary>
        /// Gets and sets the property MessageType. 
        /// <para>
        /// The type of message. Valid values are TRANSACTIONAL for messages that are critical
        /// or time-sensitive and PROMOTIONAL for messages that aren't critical or time-sensitive.
        /// After the pool is created the MessageType can't be changed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MessageType MessageType { get; set; }

        /// <summary>
        /// Checks to see if the MessageType property is set.
        /// </summary>
        internal bool IsSetMessageType() => this.MessageType != null;

        /// <summary>
        /// Gets and sets the property OriginationIdentity. 
        /// <para>
        /// The origination identity to use such as a PhoneNumberId, PhoneNumberArn, SenderId
        /// or SenderIdArn. You can use <a href="https://docs.aws.amazon.com/pinpoint/latest/apireference_smsvoicev2/API_DescribePhoneNumbers.html">DescribePhoneNumbers</a>
        /// to find the values for PhoneNumberId and PhoneNumberArn, and use <a href="https://docs.aws.amazon.com/pinpoint/latest/apireference_smsvoicev2/API_DescribeSenderIds.html">DescribeSenderIds</a>
        /// can be used to get the values for SenderId and SenderIdArn.
        /// </para>
        ///  
        /// <para>
        /// After the pool is created you can add more origination identities to the pool by using
        /// <a href="https://docs.aws.amazon.com/pinpoint/latest/apireference_smsvoicev2/API_AssociateOriginationIdentity.html">AssociateOriginationIdentity</a>.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you are using a shared End User Messaging SMS resource then you must use the full
        /// Amazon Resource Name(ARN).
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string OriginationIdentity { get; set; }

        /// <summary>
        /// Checks to see if the OriginationIdentity property is set.
        /// </summary>
        internal bool IsSetOriginationIdentity() => this.OriginationIdentity != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of tags (key and value pairs) associated with the pool.
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
