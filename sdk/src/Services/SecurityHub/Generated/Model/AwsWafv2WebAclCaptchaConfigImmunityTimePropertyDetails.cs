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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Used for CAPTCHA and challenge token settings. Determines how long a CAPTCHA or challenge
    /// timestamp remains valid after WAF updates it for a successful CAPTCHA or challenge
    /// response.
    /// </summary>
    public partial class AwsWafv2WebAclCaptchaConfigImmunityTimePropertyDetails
    {
        private long? _immunityTime;

        /// <summary>
        /// Gets and sets the property ImmunityTime. 
        /// <para>
        ///  The amount of time, in seconds, that a CAPTCHA or challenge timestamp is considered
        /// valid by WAF. 
        /// </para>
        /// </summary>
        public long ImmunityTime
        {
            get { return this._immunityTime.GetValueOrDefault(); }
            set { this._immunityTime = value; }
        }

        // Check to see if ImmunityTime property is set
        internal bool IsSetImmunityTime()
        {
            return this._immunityTime.HasValue; 
        }

    }
}