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

namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// The position in a data stream from which a queue begins delivering records.
    /// </summary>
    public partial class QueueStartingPosition
    {
        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The approximate time from which the queue begins delivering records. Records that
        /// arrive at approximately this time or later are delivered.
        /// </para>
        ///  
        /// <para>
        /// In a request, specify this value only when <c>Type</c> is <c>AT_TIMESTAMP</c>. It
        /// is required in that case, and specifying it for any other type returns a <c>ValidationException</c>.
        /// </para>
        ///  
        /// <para>
        /// In a response, this value is approximate and reflects the queue's effective starting
        /// position. While the queue is <c>CREATING</c>, the response echoes what you configured:
        /// for <c>AT_TIMESTAMP</c>, the timestamp you provided, and for <c>TRIM_HORIZON</c> and
        /// <c>LATEST</c>, this member is absent because the effective position is not yet determined.
        /// Once the queue is <c>ACTIVE</c>, the response always includes this member. For <c>AT_TIMESTAMP</c>,
        /// it is the timestamp you provided or the earliest time the stream can be read from,
        /// whichever is later.
        /// </para>
        /// </summary>
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Checks to see if the Timestamp property is set.
        /// </summary>
        internal bool IsSetTimestamp() => this.Timestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// You can set the starting position to one of the following values:
        /// </para>
        ///  
        /// <para>
        ///  <c>LATEST</c>: Delivers records that arrive after you create the queue. This is the
        /// default.
        /// </para>
        ///  
        /// <para>
        ///  <c>TRIM_HORIZON</c>: Start delivering at the last untrimmed record in the stream,
        /// which is the oldest record the stream still retains.
        /// </para>
        ///  
        /// <para>
        ///  <c>AT_TIMESTAMP</c>: Delivers records that arrive at or after a time stamp that you
        /// provide.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public QueueStartingPositionType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
