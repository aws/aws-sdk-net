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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
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
namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Represents sending statistics data. Each <c>SendDataPoint</c> contains statistics
    /// for a 15-minute period of sending activity.
    /// </summary>
    public partial class SendDataPoint
    {
        private long? _bounces;
        private long? _complaints;
        private long? _deliveryAttempts;
        private long? _rejects;
        private DateTime? _timestamp;

        /// <summary>
        /// Gets and sets the property Bounces. 
        /// <para>
        /// Number of emails that have bounced.
        /// </para>
        /// </summary>
        public long? Bounces
        {
            get { return this._bounces; }
            set { this._bounces = value; }
        }

        // Check to see if Bounces property is set
        internal bool IsSetBounces()
        {
            return this._bounces.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Complaints. 
        /// <para>
        /// Number of unwanted emails that were rejected by recipients.
        /// </para>
        /// </summary>
        public long? Complaints
        {
            get { return this._complaints; }
            set { this._complaints = value; }
        }

        // Check to see if Complaints property is set
        internal bool IsSetComplaints()
        {
            return this._complaints.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeliveryAttempts. 
        /// <para>
        /// Number of emails that have been sent.
        /// </para>
        /// </summary>
        public long? DeliveryAttempts
        {
            get { return this._deliveryAttempts; }
            set { this._deliveryAttempts = value; }
        }

        // Check to see if DeliveryAttempts property is set
        internal bool IsSetDeliveryAttempts()
        {
            return this._deliveryAttempts.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Rejects. 
        /// <para>
        /// Number of emails rejected by Amazon SES.
        /// </para>
        /// </summary>
        public long? Rejects
        {
            get { return this._rejects; }
            set { this._rejects = value; }
        }

        // Check to see if Rejects property is set
        internal bool IsSetRejects()
        {
            return this._rejects.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// Time of the data point.
        /// </para>
        /// </summary>
        public DateTime? Timestamp
        {
            get { return this._timestamp; }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

    }
}