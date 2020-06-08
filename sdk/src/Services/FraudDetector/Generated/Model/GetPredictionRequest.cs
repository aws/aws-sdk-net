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
 * Do not modify this file. This file is generated from the frauddetector-2019-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FraudDetector.Model
{
    /// <summary>
    /// Container for the parameters to the GetPrediction operation.
    /// Evaluates an event against a detector version. If a version ID is not provided, the
    /// detector’s (<code>ACTIVE</code>) version is used.
    /// </summary>
    public partial class GetPredictionRequest : AmazonFraudDetectorRequest
    {
        private string _detectorId;
        private string _detectorVersionId;
        private Dictionary<string, string> _eventAttributes = new Dictionary<string, string>();
        private string _eventId;
        private Dictionary<string, ModelEndpointDataBlob> _externalModelEndpointDataBlobs = new Dictionary<string, ModelEndpointDataBlob>();

        /// <summary>
        /// Gets and sets the property DetectorId. 
        /// <para>
        /// The detector ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DetectorId
        {
            get { return this._detectorId; }
            set { this._detectorId = value; }
        }

        // Check to see if DetectorId property is set
        internal bool IsSetDetectorId()
        {
            return this._detectorId != null;
        }

        /// <summary>
        /// Gets and sets the property DetectorVersionId. 
        /// <para>
        /// The detector version ID.
        /// </para>
        /// </summary>
        public string DetectorVersionId
        {
            get { return this._detectorVersionId; }
            set { this._detectorVersionId = value; }
        }

        // Check to see if DetectorVersionId property is set
        internal bool IsSetDetectorVersionId()
        {
            return this._detectorVersionId != null;
        }

        /// <summary>
        /// Gets and sets the property EventAttributes. 
        /// <para>
        /// Names of variables you defined in Amazon Fraud Detector to represent event data elements
        /// and their corresponding values for the event you are sending for evaluation.
        /// </para>
        /// </summary>
        public Dictionary<string, string> EventAttributes
        {
            get { return this._eventAttributes; }
            set { this._eventAttributes = value; }
        }

        // Check to see if EventAttributes property is set
        internal bool IsSetEventAttributes()
        {
            return this._eventAttributes != null && this._eventAttributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// The unique ID used to identify the event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EventId
        {
            get { return this._eventId; }
            set { this._eventId = value; }
        }

        // Check to see if EventId property is set
        internal bool IsSetEventId()
        {
            return this._eventId != null;
        }

        /// <summary>
        /// Gets and sets the property ExternalModelEndpointDataBlobs. 
        /// <para>
        /// The Amazon SageMaker model endpoint input data blobs.
        /// </para>
        /// </summary>
        public Dictionary<string, ModelEndpointDataBlob> ExternalModelEndpointDataBlobs
        {
            get { return this._externalModelEndpointDataBlobs; }
            set { this._externalModelEndpointDataBlobs = value; }
        }

        // Check to see if ExternalModelEndpointDataBlobs property is set
        internal bool IsSetExternalModelEndpointDataBlobs()
        {
            return this._externalModelEndpointDataBlobs != null && this._externalModelEndpointDataBlobs.Count > 0; 
        }

    }
}