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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Represents the user's current activity limits returned from a successful         
    ///   <code>GetSendQuota</code>            request.
    /// </summary>
    public partial class GetSendQuotaResult
    {
        private double? _max24HourSend;
        private double? _maxSendRate;
        private double? _sentLast24Hours;


        /// <summary>
        /// Gets and sets the property Max24HourSend. 
        /// <para>
        /// The maximum number of emails the user is allowed to send in a 24-hour interval.
        /// </para>
        /// </summary>
        public double Max24HourSend
        {
            get { return this._max24HourSend.GetValueOrDefault(); }
            set { this._max24HourSend = value; }
        }


        /// <summary>
        /// Sets the Max24HourSend property
        /// </summary>
        /// <param name="max24HourSend">The value to set for the Max24HourSend property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetSendQuotaResult WithMax24HourSend(double max24HourSend)
        {
            this._max24HourSend = max24HourSend;
            return this;
        }

        // Check to see if Max24HourSend property is set
        internal bool IsSetMax24HourSend()
        {
            return this._max24HourSend.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property MaxSendRate. 
        /// <para>
        /// The maximum number of emails the user is allowed to send per second.
        /// </para>
        /// </summary>
        public double MaxSendRate
        {
            get { return this._maxSendRate.GetValueOrDefault(); }
            set { this._maxSendRate = value; }
        }


        /// <summary>
        /// Sets the MaxSendRate property
        /// </summary>
        /// <param name="maxSendRate">The value to set for the MaxSendRate property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetSendQuotaResult WithMaxSendRate(double maxSendRate)
        {
            this._maxSendRate = maxSendRate;
            return this;
        }

        // Check to see if MaxSendRate property is set
        internal bool IsSetMaxSendRate()
        {
            return this._maxSendRate.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property SentLast24Hours. 
        /// <para>
        /// The number of emails sent during the previous 24 hours.
        /// </para>
        /// </summary>
        public double SentLast24Hours
        {
            get { return this._sentLast24Hours.GetValueOrDefault(); }
            set { this._sentLast24Hours = value; }
        }


        /// <summary>
        /// Sets the SentLast24Hours property
        /// </summary>
        /// <param name="sentLast24Hours">The value to set for the SentLast24Hours property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetSendQuotaResult WithSentLast24Hours(double sentLast24Hours)
        {
            this._sentLast24Hours = sentLast24Hours;
            return this;
        }

        // Check to see if SentLast24Hours property is set
        internal bool IsSetSentLast24Hours()
        {
            return this._sentLast24Hours.HasValue; 
        }

    }
}