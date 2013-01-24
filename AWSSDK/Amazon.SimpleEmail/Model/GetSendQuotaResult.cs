/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// <para>Represents the user's current activity limits returned from a successful <c>GetSendQuota</c> request. </para>
    /// </summary>
    public class GetSendQuotaResult  
    {
        
        private double? max24HourSend;
        private double? maxSendRate;
        private double? sentLast24Hours;

        /// <summary>
        /// The maximum number of emails the user is allowed to send in a 24-hour interval.
        ///  
        /// </summary>
        public double Max24HourSend
        {
            get { return this.max24HourSend ?? default(double); }
            set { this.max24HourSend = value; }
        }

        /// <summary>
        /// Sets the Max24HourSend property
        /// </summary>
        /// <param name="max24HourSend">The value to set for the Max24HourSend property </param>
        /// <returns>this instance</returns>
        public GetSendQuotaResult WithMax24HourSend(double max24HourSend)
        {
            this.max24HourSend = max24HourSend;
            return this;
        }
            

        // Check to see if Max24HourSend property is set
        internal bool IsSetMax24HourSend()
        {
            return this.max24HourSend.HasValue;       
        }

        /// <summary>
        /// The maximum number of emails the user is allowed to send per second.
        ///  
        /// </summary>
        public double MaxSendRate
        {
            get { return this.maxSendRate ?? default(double); }
            set { this.maxSendRate = value; }
        }

        /// <summary>
        /// Sets the MaxSendRate property
        /// </summary>
        /// <param name="maxSendRate">The value to set for the MaxSendRate property </param>
        /// <returns>this instance</returns>
        public GetSendQuotaResult WithMaxSendRate(double maxSendRate)
        {
            this.maxSendRate = maxSendRate;
            return this;
        }
            

        // Check to see if MaxSendRate property is set
        internal bool IsSetMaxSendRate()
        {
            return this.maxSendRate.HasValue;       
        }

        /// <summary>
        /// The number of emails sent during the previous 24 hours.
        ///  
        /// </summary>
        public double SentLast24Hours
        {
            get { return this.sentLast24Hours ?? default(double); }
            set { this.sentLast24Hours = value; }
        }

        /// <summary>
        /// Sets the SentLast24Hours property
        /// </summary>
        /// <param name="sentLast24Hours">The value to set for the SentLast24Hours property </param>
        /// <returns>this instance</returns>
        public GetSendQuotaResult WithSentLast24Hours(double sentLast24Hours)
        {
            this.sentLast24Hours = sentLast24Hours;
            return this;
        }
            

        // Check to see if SentLast24Hours property is set
        internal bool IsSetSentLast24Hours()
        {
            return this.sentLast24Hours.HasValue;       
        }
    }
}
