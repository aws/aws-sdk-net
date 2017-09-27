/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Campaign Limits are used to limit the number of messages that can be sent to a user.
    /// </summary>
    public partial class CampaignLimits
    {
        private int? _daily;
        private int? _maximumDuration;
        private int? _messagesPerSecond;
        private int? _total;

        /// <summary>
        /// Gets and sets the property Daily. The maximum number of messages that the campaign
        /// can send daily.
        /// </summary>
        public int Daily
        {
            get { return this._daily.GetValueOrDefault(); }
            set { this._daily = value; }
        }

        // Check to see if Daily property is set
        internal bool IsSetDaily()
        {
            return this._daily.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaximumDuration. The maximum duration of a campaign from
        /// the scheduled start. Must be a minimum of 60 seconds.
        /// </summary>
        public int MaximumDuration
        {
            get { return this._maximumDuration.GetValueOrDefault(); }
            set { this._maximumDuration = value; }
        }

        // Check to see if MaximumDuration property is set
        internal bool IsSetMaximumDuration()
        {
            return this._maximumDuration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MessagesPerSecond. The maximum number of messages per second
        /// that the campaign will send. This is a best effort maximum cap and can go as high
        /// as 20000 and as low as 50
        /// </summary>
        public int MessagesPerSecond
        {
            get { return this._messagesPerSecond.GetValueOrDefault(); }
            set { this._messagesPerSecond = value; }
        }

        // Check to see if MessagesPerSecond property is set
        internal bool IsSetMessagesPerSecond()
        {
            return this._messagesPerSecond.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Total. The maximum total number of messages that the campaign
        /// can send.
        /// </summary>
        public int Total
        {
            get { return this._total.GetValueOrDefault(); }
            set { this._total = value; }
        }

        // Check to see if Total property is set
        internal bool IsSetTotal()
        {
            return this._total.HasValue; 
        }

    }
}