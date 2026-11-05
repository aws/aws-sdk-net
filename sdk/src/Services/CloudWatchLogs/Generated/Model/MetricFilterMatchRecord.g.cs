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

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Represents a matched event.
    /// </summary>
    public partial class MetricFilterMatchRecord
    {
        /// <summary>
        /// Gets and sets the property EventMessage. 
        /// <para>
        /// The raw event data.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string EventMessage { get; set; }

        /// <summary>
        /// Checks to see if the EventMessage property is set.
        /// </summary>
        internal bool IsSetEventMessage() => this.EventMessage != null;

        /// <summary>
        /// Gets and sets the property EventNumber. 
        /// <para>
        /// The event number.
        /// </para>
        /// </summary>
        public long? EventNumber { get; set; }

        /// <summary>
        /// Checks to see if the EventNumber property is set.
        /// </summary>
        internal bool IsSetEventNumber() => this.EventNumber.HasValue;

        /// <summary>
        /// Gets and sets the property ExtractedValues. 
        /// <para>
        /// The values extracted from the event data by the filter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> ExtractedValues { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the ExtractedValues property is set.
        /// </summary>
        internal bool IsSetExtractedValues() => this.ExtractedValues != null && (this.ExtractedValues.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
