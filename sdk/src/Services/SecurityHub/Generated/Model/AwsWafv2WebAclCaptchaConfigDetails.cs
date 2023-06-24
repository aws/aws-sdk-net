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
    /// Specifies how WAF should handle CAPTCHA evaluations for rules that don't have their
    /// own <code>CaptchaConfig</code> settings.
    /// </summary>
    public partial class AwsWafv2WebAclCaptchaConfigDetails
    {
        private AwsWafv2WebAclCaptchaConfigImmunityTimePropertyDetails _immunityTimeProperty;

        /// <summary>
        /// Gets and sets the property ImmunityTimeProperty. 
        /// <para>
        ///  Determines how long a CAPTCHA timestamp in the token remains valid after the client
        /// successfully solves a CAPTCHA puzzle. 
        /// </para>
        /// </summary>
        public AwsWafv2WebAclCaptchaConfigImmunityTimePropertyDetails ImmunityTimeProperty
        {
            get { return this._immunityTimeProperty; }
            set { this._immunityTimeProperty = value; }
        }

        // Check to see if ImmunityTimeProperty property is set
        internal bool IsSetImmunityTimeProperty()
        {
            return this._immunityTimeProperty != null;
        }

    }
}