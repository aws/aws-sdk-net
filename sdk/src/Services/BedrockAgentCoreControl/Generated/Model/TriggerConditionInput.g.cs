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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Condition that triggers memory processing.
    /// </summary>
    public partial class TriggerConditionInput
    {
        /// <summary>
        /// Gets and sets the property MessageBasedTrigger. 
        /// <para>
        /// Message based trigger configuration.
        /// </para>
        /// </summary>
        public MessageBasedTriggerInput MessageBasedTrigger { get; set; }

        /// <summary>
        /// Checks to see if the MessageBasedTrigger property is set.
        /// </summary>
        internal bool IsSetMessageBasedTrigger() => this.MessageBasedTrigger != null;

        /// <summary>
        /// Gets and sets the property TimeBasedTrigger. 
        /// <para>
        /// Time based trigger configuration.
        /// </para>
        /// </summary>
        public TimeBasedTriggerInput TimeBasedTrigger { get; set; }

        /// <summary>
        /// Checks to see if the TimeBasedTrigger property is set.
        /// </summary>
        internal bool IsSetTimeBasedTrigger() => this.TimeBasedTrigger != null;

        /// <summary>
        /// Gets and sets the property TokenBasedTrigger. 
        /// <para>
        /// Token based trigger configuration.
        /// </para>
        /// </summary>
        public TokenBasedTriggerInput TokenBasedTrigger { get; set; }

        /// <summary>
        /// Checks to see if the TokenBasedTrigger property is set.
        /// </summary>
        internal bool IsSetTokenBasedTrigger() => this.TokenBasedTrigger != null;
    }
}
