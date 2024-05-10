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
 * Do not modify this file. This file is generated from the pinpoint-email-2018-07-26.normal.json service model.
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
namespace Amazon.PinpointEmail.Model
{
    /// <summary>
    /// An object that defines the tracking options for a configuration set. When you use
    /// Amazon Pinpoint to send an email, it contains an invisible image that's used to track
    /// when recipients open your email. If your email contains links, those links are changed
    /// slightly in order to track when recipients click them.
    /// 
    ///  
    /// <para>
    /// These images and links include references to a domain operated by AWS. You can optionally
    /// configure Amazon Pinpoint to use a domain that you operate for these images and links.
    /// </para>
    /// </summary>
    public partial class TrackingOptions
    {
        private string _customRedirectDomain;

        /// <summary>
        /// Gets and sets the property CustomRedirectDomain. 
        /// <para>
        /// The domain that you want to use for tracking open and click events.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CustomRedirectDomain
        {
            get { return this._customRedirectDomain; }
            set { this._customRedirectDomain = value; }
        }

        // Check to see if CustomRedirectDomain property is set
        internal bool IsSetCustomRedirectDomain()
        {
            return this._customRedirectDomain != null;
        }

    }
}