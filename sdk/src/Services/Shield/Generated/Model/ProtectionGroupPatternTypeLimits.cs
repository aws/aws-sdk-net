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
 * Do not modify this file. This file is generated from the shield-2016-06-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Shield.Model
{
    /// <summary>
    /// Limits settings by pattern type in the protection groups for your subscription.
    /// </summary>
    public partial class ProtectionGroupPatternTypeLimits
    {
        private ProtectionGroupArbitraryPatternLimits _arbitraryPatternLimits;

        /// <summary>
        /// Gets and sets the property ArbitraryPatternLimits. 
        /// <para>
        /// Limits settings on protection groups with arbitrary pattern type. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ProtectionGroupArbitraryPatternLimits ArbitraryPatternLimits
        {
            get { return this._arbitraryPatternLimits; }
            set { this._arbitraryPatternLimits = value; }
        }

        // Check to see if ArbitraryPatternLimits property is set
        internal bool IsSetArbitraryPatternLimits()
        {
            return this._arbitraryPatternLimits != null;
        }

    }
}