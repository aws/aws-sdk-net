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
    /// Represents sending statistics data. Each            <code>SendDataPoint</code>   
    ///         contains statistics for a 15-minute period of sending activity.
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
        public long Bounces
        {
            get { return this._bounces.GetValueOrDefault(); }
            set { this._bounces = value; }
        }


        /// <summary>
        /// Sets the Bounces property
        /// </summary>
        /// <param name="bounces">The value to set for the Bounces property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SendDataPoint WithBounces(long bounces)
        {
            this._bounces = bounces;
            return this;
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
        public long Complaints
        {
            get { return this._complaints.GetValueOrDefault(); }
            set { this._complaints = value; }
        }


        /// <summary>
        /// Sets the Complaints property
        /// </summary>
        /// <param name="complaints">The value to set for the Complaints property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SendDataPoint WithComplaints(long complaints)
        {
            this._complaints = complaints;
            return this;
        }

        // Check to see if Complaints property is set
        internal bool IsSetComplaints()
        {
            return this._complaints.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property DeliveryAttempts. 
        /// <para>
        /// Number of emails that have been enqueued for sending.
        /// </para>
        /// </summary>
        public long DeliveryAttempts
        {
            get { return this._deliveryAttempts.GetValueOrDefault(); }
            set { this._deliveryAttempts = value; }
        }


        /// <summary>
        /// Sets the DeliveryAttempts property
        /// </summary>
        /// <param name="deliveryAttempts">The value to set for the DeliveryAttempts property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SendDataPoint WithDeliveryAttempts(long deliveryAttempts)
        {
            this._deliveryAttempts = deliveryAttempts;
            return this;
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
        public long Rejects
        {
            get { return this._rejects.GetValueOrDefault(); }
            set { this._rejects = value; }
        }


        /// <summary>
        /// Sets the Rejects property
        /// </summary>
        /// <param name="rejects">The value to set for the Rejects property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SendDataPoint WithRejects(long rejects)
        {
            this._rejects = rejects;
            return this;
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
        public DateTime Timestamp
        {
            get { return this._timestamp.GetValueOrDefault(); }
            set { this._timestamp = value; }
        }


        /// <summary>
        /// Sets the Timestamp property
        /// </summary>
        /// <param name="timestamp">The value to set for the Timestamp property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SendDataPoint WithTimestamp(DateTime timestamp)
        {
            this._timestamp = timestamp;
            return this;
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

    }
}