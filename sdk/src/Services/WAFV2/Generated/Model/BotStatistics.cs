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
    /// Statistics about a specific bot's traffic to a path, including the bot name, request
    /// count, and percentage of traffic.
    /// </summary>
    public partial class BotStatistics
    {
        private string _botName;
        private double? _percentage;
        private long? _requestCount;

        /// <summary>
        /// Gets and sets the property BotName. 
        /// <para>
        /// The name of the bot. For example, <c>gptbot</c> or <c>googlebot</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string BotName
        {
            get { return this._botName; }
            set { this._botName = value; }
        }

        // Check to see if BotName property is set
        internal bool IsSetBotName()
        {
            return this._botName != null;
        }

        /// <summary>
        /// Gets and sets the property Percentage. 
        /// <para>
        /// The percentage of total requests to the associated path that came from this bot.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public double Percentage
        {
            get { return this._percentage.GetValueOrDefault(); }
            set { this._percentage = value; }
        }

        // Check to see if Percentage property is set
        internal bool IsSetPercentage()
        {
            return this._percentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequestCount. 
        /// <para>
        /// The number of requests from this bot to the associated path within the specified time
        /// window.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public long RequestCount
        {
            get { return this._requestCount.GetValueOrDefault(); }
            set { this._requestCount = value; }
        }

        // Check to see if RequestCount property is set
        internal bool IsSetRequestCount()
        {
            return this._requestCount.HasValue; 
        }

    }
}