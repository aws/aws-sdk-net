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
    /// Defines a button in a template from Meta's library.
    /// </summary>
    public partial class LibraryTemplateButtonList
    {
        /// <summary>
        /// Gets and sets the property OtpType. 
        /// <para>
        /// The type of one-time password for OTP buttons.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 25)]
        public string OtpType { get; set; }

        /// <summary>
        /// Checks to see if the OtpType property is set.
        /// </summary>
        internal bool IsSetOtpType() => this.OtpType != null;

        /// <summary>
        /// Gets and sets the property PhoneNumber. 
        /// <para>
        /// The phone number in E.164 format for CALL-type buttons.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Checks to see if the PhoneNumber property is set.
        /// </summary>
        internal bool IsSetPhoneNumber() => this.PhoneNumber != null;

        /// <summary>
        /// Gets and sets the property SupportedApps. 
        /// <para>
        /// List of supported applications for this button type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Dictionary<string, string>> SupportedApps { get; set; } = AWSConfigs.InitializeCollections ? new List<Dictionary<string, string>>() : null;

        /// <summary>
        /// Checks to see if the SupportedApps property is set.
        /// </summary>
        internal bool IsSetSupportedApps() => this.SupportedApps != null && (this.SupportedApps.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// The text displayed on the button (maximum 40 characters).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 40)]
        public string Text { get; set; }

        /// <summary>
        /// Checks to see if the Text property is set.
        /// </summary>
        internal bool IsSetText() => this.Text != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of button (for example, QUICK_REPLY, CALL, or URL).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 25)]
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The URL for URL-type buttons.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 400)]
        public string Url { get; set; }

        /// <summary>
        /// Checks to see if the Url property is set.
        /// </summary>
        internal bool IsSetUrl() => this.Url != null;

        /// <summary>
        /// Gets and sets the property ZeroTapTermsAccepted. 
        /// <para>
        /// When true, indicates acceptance of zero-tap terms for the button.
        /// </para>
        /// </summary>
        public bool? ZeroTapTermsAccepted { get; set; }

        /// <summary>
        /// Checks to see if the ZeroTapTermsAccepted property is set.
        /// </summary>
        internal bool IsSetZeroTapTermsAccepted() => this.ZeroTapTermsAccepted.HasValue;
    }
}
