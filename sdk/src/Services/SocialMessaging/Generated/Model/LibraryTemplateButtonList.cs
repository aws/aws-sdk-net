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
    /// Defines a button in a template from Meta's library.
    /// </summary>
    public partial class LibraryTemplateButtonList
    {
        private string _otpType;
        private string _phoneNumber;
        private List<Dictionary<string, string>> _supportedApps = AWSConfigs.InitializeCollections ? new List<Dictionary<string, string>>() : null;
        private string _text;
        private string _type;
        private string _url;
        private bool? _zeroTapTermsAccepted;

        /// <summary>
        /// Gets and sets the property OtpType. 
        /// <para>
        /// The type of one-time password for OTP buttons.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
        public string OtpType
        {
            get { return this._otpType; }
            set { this._otpType = value; }
        }

        // Check to see if OtpType property is set
        internal bool IsSetOtpType()
        {
            return this._otpType != null;
        }

        /// <summary>
        /// Gets and sets the property PhoneNumber. 
        /// <para>
        /// The phone number in E.164 format for CALL-type buttons.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
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
        /// Gets and sets the property SupportedApps. 
        /// <para>
        /// List of supported applications for this button type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Dictionary<string, string>> SupportedApps
        {
            get { return this._supportedApps; }
            set { this._supportedApps = value; }
        }

        // Check to see if SupportedApps property is set
        internal bool IsSetSupportedApps()
        {
            return this._supportedApps != null && (this._supportedApps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// The text displayed on the button (maximum 40 characters).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=40)]
        public string Text
        {
            get { return this._text; }
            set { this._text = value; }
        }

        // Check to see if Text property is set
        internal bool IsSetText()
        {
            return this._text != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of button (for example, QUICK_REPLY, CALL, or URL).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The URL for URL-type buttons.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=400)]
        public string Url
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this._url != null;
        }

        /// <summary>
        /// Gets and sets the property ZeroTapTermsAccepted. 
        /// <para>
        /// When true, indicates acceptance of zero-tap terms for the button.
        /// </para>
        /// </summary>
        public bool? ZeroTapTermsAccepted
        {
            get { return this._zeroTapTermsAccepted; }
            set { this._zeroTapTermsAccepted = value; }
        }

        // Check to see if ZeroTapTermsAccepted property is set
        internal bool IsSetZeroTapTermsAccepted()
        {
            return this._zeroTapTermsAccepted.HasValue; 
        }

    }
}