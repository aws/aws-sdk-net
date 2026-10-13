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

namespace Amazon.FraudDetector.Model
{
    /// <summary>
    /// Information about the summary of an event prediction.
    /// </summary>
    public partial class EventPredictionSummary
    {
        /// <summary>
        /// Gets and sets the property DetectorId. 
        /// <para>
        ///  The detector ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string DetectorId { get; set; }

        /// <summary>
        /// Checks to see if the DetectorId property is set.
        /// </summary>
        internal bool IsSetDetectorId() => this.DetectorId != null;

        /// <summary>
        /// Gets and sets the property DetectorVersionId. 
        /// <para>
        ///  The detector version ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public string DetectorVersionId { get; set; }

        /// <summary>
        /// Checks to see if the DetectorVersionId property is set.
        /// </summary>
        internal bool IsSetDetectorVersionId() => this.DetectorVersionId != null;

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        ///  The event ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string EventId { get; set; }

        /// <summary>
        /// Checks to see if the EventId property is set.
        /// </summary>
        internal bool IsSetEventId() => this.EventId != null;

        /// <summary>
        /// Gets and sets the property EventTimestamp. 
        /// <para>
        ///  The timestamp of the event. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 11, Max = 30)]
        public string EventTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the EventTimestamp property is set.
        /// </summary>
        internal bool IsSetEventTimestamp() => this.EventTimestamp != null;

        /// <summary>
        /// Gets and sets the property EventTypeName. 
        /// <para>
        ///  The event type. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string EventTypeName { get; set; }

        /// <summary>
        /// Checks to see if the EventTypeName property is set.
        /// </summary>
        internal bool IsSetEventTypeName() => this.EventTypeName != null;

        /// <summary>
        /// Gets and sets the property PredictionTimestamp. 
        /// <para>
        ///  The timestamp when the prediction was generated. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 11, Max = 30)]
        public string PredictionTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the PredictionTimestamp property is set.
        /// </summary>
        internal bool IsSetPredictionTimestamp() => this.PredictionTimestamp != null;
    }
}
