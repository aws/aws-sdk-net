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

namespace Amazon.SSMIncidents.Model
{
    /// <summary>
    /// Details about what caused the incident to be created in Incident Manager.
    /// </summary>
    public partial class TriggerDetails
    {
        /// <summary>
        /// Gets and sets the property RawData. 
        /// <para>
        /// Raw data passed from either Amazon EventBridge, Amazon CloudWatch, or Incident Manager
        /// when an incident is created.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 10000)]
        public string RawData { get; set; }

        /// <summary>
        /// Checks to see if the RawData property is set.
        /// </summary>
        internal bool IsSetRawData() => this.RawData != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// Identifies the service that sourced the event. All events sourced from within Amazon
        /// Web Services begin with "<c>aws.</c>" Customer-generated events can have any value
        /// here, as long as it doesn't begin with "<c>aws.</c>" We recommend the use of Java
        /// package-name style reverse domain-name strings. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 50)]
        public string Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The timestamp for when the incident was detected.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Checks to see if the Timestamp property is set.
        /// </summary>
        internal bool IsSetTimestamp() => this.Timestamp.HasValue;

        /// <summary>
        /// Gets and sets the property TriggerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the source that detected the incident.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 1000)]
        public string TriggerArn { get; set; }

        /// <summary>
        /// Checks to see if the TriggerArn property is set.
        /// </summary>
        internal bool IsSetTriggerArn() => this.TriggerArn != null;
    }
}
