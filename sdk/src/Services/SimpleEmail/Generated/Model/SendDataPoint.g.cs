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

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Represents sending statistics data. Each <c>SendDataPoint</c> contains statistics
    /// for a 15-minute period of sending activity.
    /// </summary>
    public partial class SendDataPoint
    {
        /// <summary>
        /// Gets and sets the property Bounces. 
        /// <para>
        /// Number of emails that have bounced.
        /// </para>
        /// </summary>
        public long? Bounces { get; set; }

        /// <summary>
        /// Checks to see if the Bounces property is set.
        /// </summary>
        internal bool IsSetBounces() => this.Bounces.HasValue;

        /// <summary>
        /// Gets and sets the property Complaints. 
        /// <para>
        /// Number of unwanted emails that were rejected by recipients.
        /// </para>
        /// </summary>
        public long? Complaints { get; set; }

        /// <summary>
        /// Checks to see if the Complaints property is set.
        /// </summary>
        internal bool IsSetComplaints() => this.Complaints.HasValue;

        /// <summary>
        /// Gets and sets the property DeliveryAttempts. 
        /// <para>
        /// Number of emails that have been sent.
        /// </para>
        /// </summary>
        public long? DeliveryAttempts { get; set; }

        /// <summary>
        /// Checks to see if the DeliveryAttempts property is set.
        /// </summary>
        internal bool IsSetDeliveryAttempts() => this.DeliveryAttempts.HasValue;

        /// <summary>
        /// Gets and sets the property Rejects. 
        /// <para>
        /// Number of emails rejected by Amazon SES.
        /// </para>
        /// </summary>
        public long? Rejects { get; set; }

        /// <summary>
        /// Checks to see if the Rejects property is set.
        /// </summary>
        internal bool IsSetRejects() => this.Rejects.HasValue;

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// Time of the data point.
        /// </para>
        /// </summary>
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Checks to see if the Timestamp property is set.
        /// </summary>
        internal bool IsSetTimestamp() => this.Timestamp.HasValue;
    }
}
