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
 * Do not modify this file. This file is generated from the dynamodbstreams-2012-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// A description of a unique event within a stream.
    /// </summary>
    public partial class Record
    {
        private string _awsRegion;
        private StreamRecord _dynamodb;
        private string _eventid;
        private OperationType _eventName;
        private string _eventSource;
        private string _eventVersion;

        /// <summary>
        /// Gets and sets the property AwsRegion. 
        /// <para>
        /// The region in which the <i>GetRecords</i> request was received.
        /// </para>
        /// </summary>
        public string AwsRegion
        {
            get { return this._awsRegion; }
            set { this._awsRegion = value; }
        }

        // Check to see if AwsRegion property is set
        internal bool IsSetAwsRegion()
        {
            return this._awsRegion != null;
        }

        /// <summary>
        /// Gets and sets the property Dynamodb. 
        /// <para>
        /// The main body of the stream record, containing all of the DynamoDB-specific fields.
        /// </para>
        /// </summary>
        public StreamRecord Dynamodb
        {
            get { return this._dynamodb; }
            set { this._dynamodb = value; }
        }

        // Check to see if Dynamodb property is set
        internal bool IsSetDynamodb()
        {
            return this._dynamodb != null;
        }

        /// <summary>
        /// Gets and sets the property EventID. 
        /// <para>
        /// A globally unique identifier for the event that was recorded in this stream record.
        /// </para>
        /// </summary>
        public string EventID
        {
            get { return this._eventid; }
            set { this._eventid = value; }
        }

        // Check to see if EventID property is set
        internal bool IsSetEventID()
        {
            return this._eventid != null;
        }

        /// <summary>
        /// Gets and sets the property EventName. 
        /// <para>
        /// The type of data modification that was performed on the DynamoDB table:
        /// </para>
        ///  <ul> <li>
        /// <para>
        /// <code>INSERT</code> - a new item was added to the table.
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>MODIFY</code> - one or more of the item's attributes were updated.
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>REMOVE</code> - the item was deleted from the table
        /// </para>
        /// </li> </ul>
        /// </summary>
        public OperationType EventName
        {
            get { return this._eventName; }
            set { this._eventName = value; }
        }

        // Check to see if EventName property is set
        internal bool IsSetEventName()
        {
            return this._eventName != null;
        }

        /// <summary>
        /// Gets and sets the property EventSource. 
        /// <para>
        /// The AWS service from which the stream record originated. For DynamoDB Streams, this
        /// is <i>aws:dynamodb</i>.
        /// </para>
        /// </summary>
        public string EventSource
        {
            get { return this._eventSource; }
            set { this._eventSource = value; }
        }

        // Check to see if EventSource property is set
        internal bool IsSetEventSource()
        {
            return this._eventSource != null;
        }

        /// <summary>
        /// Gets and sets the property EventVersion. 
        /// <para>
        /// The version number of the stream record format. Currently, this is <i>1.0</i>.
        /// </para>
        /// </summary>
        public string EventVersion
        {
            get { return this._eventVersion; }
            set { this._eventVersion = value; }
        }

        // Check to see if EventVersion property is set
        internal bool IsSetEventVersion()
        {
            return this._eventVersion != null;
        }

    }
}