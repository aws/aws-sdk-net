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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
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
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// This structure contains information for one log event that has been processed by a
    /// log transformer.
    /// </summary>
    public partial class TransformedLogRecord
    {
        private string _eventMessage;
        private long? _eventNumber;
        private string _transformedEventMessage;

        /// <summary>
        /// Gets and sets the property EventMessage. 
        /// <para>
        /// The original log event message before it was transformed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string EventMessage
        {
            get { return this._eventMessage; }
            set { this._eventMessage = value; }
        }

        // Check to see if EventMessage property is set
        internal bool IsSetEventMessage()
        {
            return this._eventMessage != null;
        }

        /// <summary>
        /// Gets and sets the property EventNumber. 
        /// <para>
        /// The event number.
        /// </para>
        /// </summary>
        public long? EventNumber
        {
            get { return this._eventNumber; }
            set { this._eventNumber = value; }
        }

        // Check to see if EventNumber property is set
        internal bool IsSetEventNumber()
        {
            return this._eventNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TransformedEventMessage. 
        /// <para>
        /// The log event message after being transformed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string TransformedEventMessage
        {
            get { return this._transformedEventMessage; }
            set { this._transformedEventMessage = value; }
        }

        // Check to see if TransformedEventMessage property is set
        internal bool IsSetTransformedEventMessage()
        {
            return this._transformedEventMessage != null;
        }

    }
}