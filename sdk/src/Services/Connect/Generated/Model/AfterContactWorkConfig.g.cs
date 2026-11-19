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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Configuration settings for after contact work (ACW) timeout.
    /// </summary>
    public partial class AfterContactWorkConfig
    {
        /// <summary>
        /// Gets and sets the property AfterContactWorkTimeLimit. 
        /// <para>
        /// The after contact work (ACW) timeout duration in seconds. Minimum: 1 second. Maximum:
        /// 2,000,000 seconds (24 days). For the CHAT channel, the maximum for a specific duration
        /// is 5,400 seconds (90 minutes); higher values end ACW after 90 minutes. For all channels,
        /// including chat, you can enter 0 for an indefinite amount of time, meaning agents must
        /// manually choose to end ACW.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? AfterContactWorkTimeLimit { get; set; }

        /// <summary>
        /// Checks to see if the AfterContactWorkTimeLimit property is set.
        /// </summary>
        internal bool IsSetAfterContactWorkTimeLimit() => this.AfterContactWorkTimeLimit.HasValue;
    }
}
