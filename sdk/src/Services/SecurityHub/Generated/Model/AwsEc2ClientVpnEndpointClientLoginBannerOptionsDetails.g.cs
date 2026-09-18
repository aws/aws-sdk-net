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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Options for enabling a customizable text banner that will be displayed on Amazon
    /// Web Services provided clients when a VPN session is established.
    /// </summary>
    public partial class AwsEc2ClientVpnEndpointClientLoginBannerOptionsDetails
    {
        /// <summary>
        /// Gets and sets the property BannerText. 
        /// <para>
        ///  Customizable text that will be displayed in a banner on Amazon Web Services provided
        /// clients when a VPN session is established. 
        /// </para>
        /// </summary>
        public string BannerText { get; set; }

        /// <summary>
        /// Checks to see if the BannerText property is set.
        /// </summary>
        internal bool IsSetBannerText() => this.BannerText != null;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        ///  Current state of text banner feature. 
        /// </para>
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;
    }
}
