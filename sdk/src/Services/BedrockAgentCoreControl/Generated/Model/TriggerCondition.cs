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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
    public partial class TriggerCondition
    {
        private MessageBasedTrigger _messageBasedTrigger;
        private TimeBasedTrigger _timeBasedTrigger;
        private TokenBasedTrigger _tokenBasedTrigger;

        /// <summary>
        /// Gets and sets the property MessageBasedTrigger. 
        /// <para>
        /// Message based trigger configuration.
        /// </para>
        /// </summary>
        public MessageBasedTrigger MessageBasedTrigger
        {
            get { return this._messageBasedTrigger; }
            set { this._messageBasedTrigger = value; }
        }

        // Check to see if MessageBasedTrigger property is set
        internal bool IsSetMessageBasedTrigger()
        {
            return this._messageBasedTrigger != null;
        }

        /// <summary>
        /// Gets and sets the property TimeBasedTrigger. 
        /// <para>
        /// Time based trigger configuration.
        /// </para>
        /// </summary>
        public TimeBasedTrigger TimeBasedTrigger
        {
            get { return this._timeBasedTrigger; }
            set { this._timeBasedTrigger = value; }
        }

        // Check to see if TimeBasedTrigger property is set
        internal bool IsSetTimeBasedTrigger()
        {
            return this._timeBasedTrigger != null;
        }

        /// <summary>
        /// Gets and sets the property TokenBasedTrigger. 
        /// <para>
        /// Token based trigger configuration.
        /// </para>
        /// </summary>
        public TokenBasedTrigger TokenBasedTrigger
        {
            get { return this._tokenBasedTrigger; }
            set { this._tokenBasedTrigger = value; }
        }

        // Check to see if TokenBasedTrigger property is set
        internal bool IsSetTokenBasedTrigger()
        {
            return this._tokenBasedTrigger != null;
        }

    }
}