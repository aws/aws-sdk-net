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
    /// The details of a linked phone number.
    /// </summary>
    public partial class WhatsAppPhoneNumberSummary
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The full Amazon Resource Name (ARN) for the phone number.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 2048)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property DataLocalizationRegion. 
        /// <para>
        /// The geographic region where the WhatsApp phone number's data is stored and processed.
        /// </para>
        /// </summary>
        public string DataLocalizationRegion { get; set; }

        /// <summary>
        /// Checks to see if the DataLocalizationRegion property is set.
        /// </summary>
        internal bool IsSetDataLocalizationRegion() => this.DataLocalizationRegion != null;

        /// <summary>
        /// Gets and sets the property DisplayPhoneNumber. 
        /// <para>
        /// The phone number that appears in the recipients display.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 20)]
        public string DisplayPhoneNumber { get; set; }

        /// <summary>
        /// Checks to see if the DisplayPhoneNumber property is set.
        /// </summary>
        internal bool IsSetDisplayPhoneNumber() => this.DisplayPhoneNumber != null;

        /// <summary>
        /// Gets and sets the property DisplayPhoneNumberName. 
        /// <para>
        /// The display name for this phone number.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 200)]
        public string DisplayPhoneNumberName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayPhoneNumberName property is set.
        /// </summary>
        internal bool IsSetDisplayPhoneNumberName() => this.DisplayPhoneNumberName != null;

        /// <summary>
        /// Gets and sets the property MetaPhoneNumberId. 
        /// <para>
        /// The phone number ID from Meta.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string MetaPhoneNumberId { get; set; }

        /// <summary>
        /// Checks to see if the MetaPhoneNumberId property is set.
        /// </summary>
        internal bool IsSetMetaPhoneNumberId() => this.MetaPhoneNumberId != null;

        /// <summary>
        /// Gets and sets the property PhoneNumber. 
        /// <para>
        /// The phone number associated with the Linked WhatsApp Business Account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 20)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Checks to see if the PhoneNumber property is set.
        /// </summary>
        internal bool IsSetPhoneNumber() => this.PhoneNumber != null;

        /// <summary>
        /// Gets and sets the property PhoneNumberId. 
        /// <para>
        /// The phone number ID. Phone number identifiers are formatted as <c>phone-number-id-01234567890123456789012345678901</c>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 115)]
        public string PhoneNumberId { get; set; }

        /// <summary>
        /// Checks to see if the PhoneNumberId property is set.
        /// </summary>
        internal bool IsSetPhoneNumberId() => this.PhoneNumberId != null;

        /// <summary>
        /// Gets and sets the property QualityRating. 
        /// <para>
        /// The quality rating of the phone number. This is from Meta.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 10)]
        public string QualityRating { get; set; }

        /// <summary>
        /// Checks to see if the QualityRating property is set.
        /// </summary>
        internal bool IsSetQualityRating() => this.QualityRating != null;
    }
}
