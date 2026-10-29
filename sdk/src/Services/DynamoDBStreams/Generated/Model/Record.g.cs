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

namespace Amazon.DynamoDBStreams.Model
{
    /// <summary>
    /// A description of a unique event within a stream.
    /// </summary>
    public partial class Record
    {
        /// <summary>
        /// Gets and sets the property AwsRegion. 
        /// <para>
        /// The region in which the <c>GetRecords</c> request was received.
        /// </para>
        /// </summary>
        public string AwsRegion { get; set; }

        /// <summary>
        /// Checks to see if the AwsRegion property is set.
        /// </summary>
        internal bool IsSetAwsRegion() => this.AwsRegion != null;

        /// <summary>
        /// Gets and sets the property Dynamodb. 
        /// <para>
        /// The main body of the stream record, containing all of the DynamoDB-specific fields.
        /// </para>
        /// </summary>
        public StreamRecord Dynamodb { get; set; }

        /// <summary>
        /// Checks to see if the Dynamodb property is set.
        /// </summary>
        internal bool IsSetDynamodb() => this.Dynamodb != null;

        /// <summary>
        /// Gets and sets the property EventID. 
        /// <para>
        /// A globally unique identifier for the event that was recorded in this stream record.
        /// </para>
        /// </summary>
        public string EventID { get; set; }

        /// <summary>
        /// Checks to see if the EventID property is set.
        /// </summary>
        internal bool IsSetEventID() => this.EventID != null;

        /// <summary>
        /// Gets and sets the property EventName. 
        /// <para>
        /// The type of data modification that was performed on the DynamoDB table:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>INSERT</c> - a new item was added to the table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MODIFY</c> - one or more of an existing item's attributes were modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REMOVE</c> - the item was deleted from the table
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public OperationType EventName { get; set; }

        /// <summary>
        /// Checks to see if the EventName property is set.
        /// </summary>
        internal bool IsSetEventName() => this.EventName != null;

        /// <summary>
        /// Gets and sets the property EventSource. 
        /// <para>
        /// The Amazon Web Services service from which the stream record originated. For DynamoDB
        /// Streams, this is <c>aws:dynamodb</c>.
        /// </para>
        /// </summary>
        public string EventSource { get; set; }

        /// <summary>
        /// Checks to see if the EventSource property is set.
        /// </summary>
        internal bool IsSetEventSource() => this.EventSource != null;

        /// <summary>
        /// Gets and sets the property EventVersion. 
        /// <para>
        /// The version number of the stream record format. This number is updated whenever the
        /// structure of <c>Record</c> is modified.
        /// </para>
        ///  
        /// <para>
        /// Client applications must not assume that <c>eventVersion</c> will remain at a particular
        /// value, as this number is subject to change at any time. In general, <c>eventVersion</c>
        /// will only increase as the low-level DynamoDB Streams API evolves.
        /// </para>
        /// </summary>
        public string EventVersion { get; set; }

        /// <summary>
        /// Checks to see if the EventVersion property is set.
        /// </summary>
        internal bool IsSetEventVersion() => this.EventVersion != null;

        /// <summary>
        /// Gets and sets the property UserIdentity. 
        /// <para>
        /// Items that are deleted by the Time to Live process after expiration have the following
        /// fields: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Records[].userIdentity.type
        /// </para>
        ///  
        /// <para>
        /// "Service"
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Records[].userIdentity.principalId
        /// </para>
        ///  
        /// <para>
        /// "dynamodb.amazonaws.com"
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Identity UserIdentity { get; set; }

        /// <summary>
        /// Checks to see if the UserIdentity property is set.
        /// </summary>
        internal bool IsSetUserIdentity() => this.UserIdentity != null;
    }
}
