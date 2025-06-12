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
    /// Represents a matched event.
    /// </summary>
    public partial class MetricFilterMatchRecord
    {
        private string _eventMessage;
        private long? _eventNumber;
        private Dictionary<string, string> _extractedValues = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property EventMessage. 
        /// <para>
        /// The raw event data.
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
        /// Gets and sets the property ExtractedValues. 
        /// <para>
        /// The values extracted from the event data by the filter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> ExtractedValues
        {
            get { return this._extractedValues; }
            set { this._extractedValues = value; }
        }

        // Check to see if ExtractedValues property is set
        internal bool IsSetExtractedValues()
        {
            return this._extractedValues != null && (this._extractedValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}