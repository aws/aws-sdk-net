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

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// Determines how long a <code>CAPTCHA</code> token remains valid after the client successfully
    /// solves a <code>CAPTCHA</code> puzzle.
    /// </summary>
    public partial class ImmunityTimeProperty
    {
        private long? _immunityTime;

        /// <summary>
        /// Gets and sets the property ImmunityTime. 
        /// <para>
        /// The amount of time, in seconds, that a <code>CAPTCHA</code> token is valid. The default
        /// setting is 300.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=60, Max=259200)]
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