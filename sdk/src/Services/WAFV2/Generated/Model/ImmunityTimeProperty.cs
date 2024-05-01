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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
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
namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// Used for CAPTCHA and challenge token settings. Determines how long a <c>CAPTCHA</c>
    /// or challenge timestamp remains valid after WAF updates it for a successful <c>CAPTCHA</c>
    /// or challenge response.
    /// </summary>
    public partial class ImmunityTimeProperty
    {
        private long? _immunityTime;

        /// <summary>
        /// Gets and sets the property ImmunityTime. 
        /// <para>
        /// The amount of time, in seconds, that a <c>CAPTCHA</c> or challenge timestamp is considered
        /// valid by WAF. The default setting is 300. 
        /// </para>
        ///  
        /// <para>
        /// For the Challenge action, the minimum setting is 300. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=60, Max=259200)]
        public long? ImmunityTime
        {
            get { return this._immunityTime; }
            set { this._immunityTime = value; }
        }

        // Check to see if ImmunityTime property is set
        internal bool IsSetImmunityTime()
        {
            return this._immunityTime.HasValue; 
        }

    }
}