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
    /// <para>Represents sending statistics data. Each <c>SendDataPoint</c> contains statistics for a 15-minute period of sending activity. </para>
    /// </summary>
    public class SendDataPoint  
    {
        
        private DateTime? timestamp;
        private long? deliveryAttempts;
        private long? bounces;
        private long? complaints;
        private long? rejects;

        /// <summary>
        /// Time of the data point.
        ///  
        /// </summary>
        public DateTime Timestamp
        {
            get { return this.timestamp ?? default(DateTime); }
            set { this.timestamp = value; }
        }

        /// <summary>
        /// Sets the Timestamp property
        /// </summary>
        /// <param name="timestamp">The value to set for the Timestamp property </param>
        /// <returns>this instance</returns>
        public SendDataPoint WithTimestamp(DateTime timestamp)
        {
            this.timestamp = timestamp;
            return this;
        }
            

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this.timestamp.HasValue;       
        }

        /// <summary>
        /// Number of emails that have been enqueued for sending.
        ///  
        /// </summary>
        public long DeliveryAttempts
        {
            get { return this.deliveryAttempts ?? default(long); }
            set { this.deliveryAttempts = value; }
        }

        /// <summary>
        /// Sets the DeliveryAttempts property
        /// </summary>
        /// <param name="deliveryAttempts">The value to set for the DeliveryAttempts property </param>
        /// <returns>this instance</returns>
        public SendDataPoint WithDeliveryAttempts(long deliveryAttempts)
        {
            this.deliveryAttempts = deliveryAttempts;
            return this;
        }
            

        // Check to see if DeliveryAttempts property is set
        internal bool IsSetDeliveryAttempts()
        {
            return this.deliveryAttempts.HasValue;       
        }

        /// <summary>
        /// Number of emails that have bounced.
        ///  
        /// </summary>
        public long Bounces
        {
            get { return this.bounces ?? default(long); }
            set { this.bounces = value; }
        }

        /// <summary>
        /// Sets the Bounces property
        /// </summary>
        /// <param name="bounces">The value to set for the Bounces property </param>
        /// <returns>this instance</returns>
        public SendDataPoint WithBounces(long bounces)
        {
            this.bounces = bounces;
            return this;
        }
            

        // Check to see if Bounces property is set
        internal bool IsSetBounces()
        {
            return this.bounces.HasValue;       
        }

        /// <summary>
        /// Number of unwanted emails that were rejected by recipients.
        ///  
        /// </summary>
        public long Complaints
        {
            get { return this.complaints ?? default(long); }
            set { this.complaints = value; }
        }

        /// <summary>
        /// Sets the Complaints property
        /// </summary>
        /// <param name="complaints">The value to set for the Complaints property </param>
        /// <returns>this instance</returns>
        public SendDataPoint WithComplaints(long complaints)
        {
            this.complaints = complaints;
            return this;
        }
            

        // Check to see if Complaints property is set
        internal bool IsSetComplaints()
        {
            return this.complaints.HasValue;       
        }

        /// <summary>
        /// Number of emails rejected by Amazon SES.
        ///  
        /// </summary>
        public long Rejects
        {
            get { return this.rejects ?? default(long); }
            set { this.rejects = value; }
        }

        /// <summary>
        /// Sets the Rejects property
        /// </summary>
        /// <param name="rejects">The value to set for the Rejects property </param>
        /// <returns>this instance</returns>
        public SendDataPoint WithRejects(long rejects)
        {
            this.rejects = rejects;
            return this;
        }
            

        // Check to see if Rejects property is set
        internal bool IsSetRejects()
        {
            return this.rejects.HasValue;       
        }
    }
}
