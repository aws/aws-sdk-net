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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// An object that contains information about the per-day and per-second sending limits
    /// for your Amazon SES account in the current Amazon Web Services Region.
    /// </summary>
    public partial class SendQuota
    {
        private double? _max24HourSend;
        private double? _maxSendRate;
        private double? _sentLast24Hours;

        /// <summary>
        /// Gets and sets the property Max24HourSend. 
        /// <para>
        /// The maximum number of emails that you can send in the current Amazon Web Services
        /// Region over a 24-hour period. A value of -1 signifies an unlimited quota. (This value
        /// is also referred to as your <i>sending quota</i>.)
        /// </para>
        /// </summary>
        public double? Max24HourSend
        {
            get { return this._max24HourSend; }
            set { this._max24HourSend = value; }
        }

        // Check to see if Max24HourSend property is set
        internal bool IsSetMax24HourSend()
        {
            return this._max24HourSend.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxSendRate. 
        /// <para>
        /// The maximum number of emails that you can send per second in the current Amazon Web
        /// Services Region. This value is also called your <i>maximum sending rate</i> or your
        /// <i>maximum TPS (transactions per second) rate</i>.
        /// </para>
        /// </summary>
        public double? MaxSendRate
        {
            get { return this._maxSendRate; }
            set { this._maxSendRate = value; }
        }

        // Check to see if MaxSendRate property is set
        internal bool IsSetMaxSendRate()
        {
            return this._maxSendRate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SentLast24Hours. 
        /// <para>
        /// The number of emails sent from your Amazon SES account in the current Amazon Web Services
        /// Region over the past 24 hours.
        /// </para>
        /// </summary>
        public double? SentLast24Hours
        {
            get { return this._sentLast24Hours; }
            set { this._sentLast24Hours = value; }
        }

        // Check to see if SentLast24Hours property is set
        internal bool IsSetSentLast24Hours()
        {
            return this._sentLast24Hours.HasValue; 
        }

    }
}