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

namespace Amazon.ChimeSDKVoice.Model
{
    /// <summary>
    /// The proxy configuration for an Amazon Chime SDK Voice Connector.
    /// </summary>
    public partial class Proxy
    {
        /// <summary>
        /// Gets and sets the property DefaultSessionExpiryMinutes. 
        /// <para>
        /// The default number of minutes allowed for proxy sessions.
        /// </para>
        /// </summary>
        public int? DefaultSessionExpiryMinutes { get; set; }

        /// <summary>
        /// Checks to see if the DefaultSessionExpiryMinutes property is set.
        /// </summary>
        internal bool IsSetDefaultSessionExpiryMinutes() => this.DefaultSessionExpiryMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property Disabled. 
        /// <para>
        /// When true, stops proxy sessions from being created on the specified Amazon Chime SDK
        /// Voice Connector.
        /// </para>
        /// </summary>
        public bool? Disabled { get; set; }

        /// <summary>
        /// Checks to see if the Disabled property is set.
        /// </summary>
        internal bool IsSetDisabled() => this.Disabled.HasValue;

        /// <summary>
        /// Gets and sets the property FallBackPhoneNumber. 
        /// <para>
        /// The phone number to route calls to after a proxy session expires.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string FallBackPhoneNumber { get; set; }

        /// <summary>
        /// Checks to see if the FallBackPhoneNumber property is set.
        /// </summary>
        internal bool IsSetFallBackPhoneNumber() => this.FallBackPhoneNumber != null;

        /// <summary>
        /// Gets and sets the property PhoneNumberCountries. 
        /// <para>
        /// The countries for proxy phone numbers to be selected from.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PhoneNumberCountries { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PhoneNumberCountries property is set.
        /// </summary>
        internal bool IsSetPhoneNumberCountries() => this.PhoneNumberCountries != null && (this.PhoneNumberCountries.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
