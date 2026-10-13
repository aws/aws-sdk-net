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
    /// Container for the parameters to the GetEventPredictionMetadata operation. Gets details
    /// of the past fraud predictions for the specified event ID, event type, detector ID,
    /// and detector version ID that was generated in the specified time period.
    /// </summary>
    public partial class GetEventPredictionMetadataRequest : AmazonFraudDetectorRequest
    {
        /// <summary>
        /// Gets and sets the property DetectorId. 
        /// <para>
        ///  The detector ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
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
        [AWSProperty(Required = true, Min = 1, Max = 5)]
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
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string EventId { get; set; }

        /// <summary>
        /// Checks to see if the EventId property is set.
        /// </summary>
        internal bool IsSetEventId() => this.EventId != null;

        /// <summary>
        /// Gets and sets the property EventTypeName. 
        /// <para>
        ///  The event type associated with the detector specified for the prediction. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string EventTypeName { get; set; }

        /// <summary>
        /// Checks to see if the EventTypeName property is set.
        /// </summary>
        internal bool IsSetEventTypeName() => this.EventTypeName != null;

        /// <summary>
        /// Gets and sets the property PredictionTimestamp. 
        /// <para>
        ///  The timestamp that defines when the prediction was generated. The timestamp must
        /// be specified using ISO 8601 standard in UTC.
        /// </para>
        ///  
        /// <para>
        /// We recommend calling <a href="https://docs.aws.amazon.com/frauddetector/latest/api/API_ListEventPredictions.html">ListEventPredictions</a>
        /// first, and using the <c>predictionTimestamp</c> value in the response to provide an
        /// accurate prediction timestamp value.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 11, Max = 30)]
        public string PredictionTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the PredictionTimestamp property is set.
        /// </summary>
        internal bool IsSetPredictionTimestamp() => this.PredictionTimestamp != null;
    }
}
