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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Current state of options for customizable text banner that will be displayed on Amazon
    /// Web Services provided clients when a VPN session is established.
    /// </summary>
    public partial class ClientLoginBannerResponseOptions
    {
        private string _bannerText;
        private bool? _enabled;

        /// <summary>
        /// Gets and sets the property BannerText. 
        /// <para>
        /// Customizable text that will be displayed in a banner on Amazon Web Services provided
        /// clients when a VPN session is established. UTF-8 encoded characters only. Maximum
        /// of 1400 characters.
        /// </para>
        /// </summary>
        public string BannerText
        {
            get { return this._bannerText; }
            set { this._bannerText = value; }
        }

        // Check to see if BannerText property is set
        internal bool IsSetBannerText()
        {
            return this._bannerText != null;
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Current state of text banner feature.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>true | false</c> 
        /// </para>
        /// </summary>
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

    }
}