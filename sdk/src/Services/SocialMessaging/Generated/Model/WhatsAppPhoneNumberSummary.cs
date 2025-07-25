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
 * Do not modify this file. This file is generated from the socialmessaging-2024-01-01.normal.json service model.
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
        private string _arn;
        private string _dataLocalizationRegion;
        private string _displayPhoneNumber;
        private string _displayPhoneNumberName;
        private string _metaPhoneNumberId;
        private string _phoneNumber;
        private string _phoneNumberId;
        private string _qualityRating;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The full Amazon Resource Name (ARN) for the phone number.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property DataLocalizationRegion. 
        /// <para>
        /// The geographic region where the WhatsApp phone number's data is stored and processed.
        /// </para>
        /// </summary>
        public string DataLocalizationRegion
        {
            get { return this._dataLocalizationRegion; }
            set { this._dataLocalizationRegion = value; }
        }

        // Check to see if DataLocalizationRegion property is set
        internal bool IsSetDataLocalizationRegion()
        {
            return this._dataLocalizationRegion != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayPhoneNumber. 
        /// <para>
        /// The phone number that appears in the recipients display.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=20)]
        public string DisplayPhoneNumber
        {
            get { return this._displayPhoneNumber; }
            set { this._displayPhoneNumber = value; }
        }

        // Check to see if DisplayPhoneNumber property is set
        internal bool IsSetDisplayPhoneNumber()
        {
            return this._displayPhoneNumber != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayPhoneNumberName. 
        /// <para>
        /// The display name for this phone number.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=200)]
        public string DisplayPhoneNumberName
        {
            get { return this._displayPhoneNumberName; }
            set { this._displayPhoneNumberName = value; }
        }

        // Check to see if DisplayPhoneNumberName property is set
        internal bool IsSetDisplayPhoneNumberName()
        {
            return this._displayPhoneNumberName != null;
        }

        /// <summary>
        /// Gets and sets the property MetaPhoneNumberId. 
        /// <para>
        /// The phone number ID from Meta.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string MetaPhoneNumberId
        {
            get { return this._metaPhoneNumberId; }
            set { this._metaPhoneNumberId = value; }
        }

        // Check to see if MetaPhoneNumberId property is set
        internal bool IsSetMetaPhoneNumberId()
        {
            return this._metaPhoneNumberId != null;
        }

        /// <summary>
        /// Gets and sets the property PhoneNumber. 
        /// <para>
        /// The phone number associated with the Linked WhatsApp Business Account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public string PhoneNumber
        {
            get { return this._phoneNumber; }
            set { this._phoneNumber = value; }
        }

        // Check to see if PhoneNumber property is set
        internal bool IsSetPhoneNumber()
        {
            return this._phoneNumber != null;
        }

        /// <summary>
        /// Gets and sets the property PhoneNumberId. 
        /// <para>
        /// The phone number ID. Phone number identifiers are formatted as <c>phone-number-id-01234567890123456789012345678901</c>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string PhoneNumberId
        {
            get { return this._phoneNumberId; }
            set { this._phoneNumberId = value; }
        }

        // Check to see if PhoneNumberId property is set
        internal bool IsSetPhoneNumberId()
        {
            return this._phoneNumberId != null;
        }

        /// <summary>
        /// Gets and sets the property QualityRating. 
        /// <para>
        /// The quality rating of the phone number. This is from Meta.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10)]
        public string QualityRating
        {
            get { return this._qualityRating; }
            set { this._qualityRating = value; }
        }

        // Check to see if QualityRating property is set
        internal bool IsSetQualityRating()
        {
            return this._qualityRating != null;
        }

    }
}