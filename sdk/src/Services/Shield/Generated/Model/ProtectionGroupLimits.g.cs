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

namespace Amazon.Shield.Model
{
    /// <summary>
    /// Limits settings on protection groups for your subscription.
    /// </summary>
    public partial class ProtectionGroupLimits
    {
        /// <summary>
        /// Gets and sets the property MaxProtectionGroups. 
        /// <para>
        /// The maximum number of protection groups that you can have at one time. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? MaxProtectionGroups { get; set; }

        /// <summary>
        /// Checks to see if the MaxProtectionGroups property is set.
        /// </summary>
        internal bool IsSetMaxProtectionGroups() => this.MaxProtectionGroups.HasValue;

        /// <summary>
        /// Gets and sets the property PatternTypeLimits. 
        /// <para>
        /// Limits settings by pattern type in the protection groups for your subscription. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ProtectionGroupPatternTypeLimits PatternTypeLimits { get; set; }

        /// <summary>
        /// Checks to see if the PatternTypeLimits property is set.
        /// </summary>
        internal bool IsSetPatternTypeLimits() => this.PatternTypeLimits != null;
    }
}
