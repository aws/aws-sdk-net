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
    /// Container for the parameters to the GetEventPrediction operation.
    /// Evaluates an event against a detector version. If a version ID is not provided, the
    /// detector’s (<code>ACTIVE</code>) version is used.
    /// </summary>
    public partial class GetEventPredictionRequest : AmazonFraudDetectorRequest
    {
        private string _detectorId;
        private string _detectorVersionId;
        private List<Entity> _entities = new List<Entity>();
        private string _eventId;
        private string _eventTimestamp;
        private string _eventTypeName;
        private Dictionary<string, string> _eventVariables = new Dictionary<string, string>();
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
        [AWSProperty(Min=1, Max=5)]
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
        /// Gets and sets the property Entities. 
        /// <para>
        /// The entity type (associated with the detector's event type) and specific entity ID
        /// representing who performed the event. If an entity id is not available, use "UNKNOWN."
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Entity> Entities
        {
            get { return this._entities; }
            set { this._entities = value; }
        }

        // Check to see if Entities property is set
        internal bool IsSetEntities()
        {
            return this._entities != null && this._entities.Count > 0; 
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
        /// Gets and sets the property EventTimestamp. 
        /// <para>
        /// Timestamp that defines when the event under evaluation occurred. The timestamp must
        /// be specified using ISO 8601 standard in UTC.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=30)]
        public string EventTimestamp
        {
            get { return this._eventTimestamp; }
            set { this._eventTimestamp = value; }
        }

        // Check to see if EventTimestamp property is set
        internal bool IsSetEventTimestamp()
        {
            return this._eventTimestamp != null;
        }

        /// <summary>
        /// Gets and sets the property EventTypeName. 
        /// <para>
        /// The event type associated with the detector specified for the prediction.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EventTypeName
        {
            get { return this._eventTypeName; }
            set { this._eventTypeName = value; }
        }

        // Check to see if EventTypeName property is set
        internal bool IsSetEventTypeName()
        {
            return this._eventTypeName != null;
        }

        /// <summary>
        /// Gets and sets the property EventVariables. 
        /// <para>
        /// Names of the event type's variables you defined in Amazon Fraud Detector to represent
        /// data elements and their corresponding values for the event you are sending for evaluation.
        /// </para>
        ///  <important> 
        /// <para>
        /// You must provide at least one eventVariable
        /// </para>
        ///  </important> 
        /// <para>
        /// To ensure most accurate fraud prediction and to simplify your data preparation, Amazon
        /// Fraud Detector will replace all missing variables or values as follows:
        /// </para>
        ///  
        /// <para>
        ///  <b>For Amazon Fraud Detector trained models:</b> 
        /// </para>
        ///  
        /// <para>
        /// If a null value is provided explicitly for a variable or if a variable is missing,
        /// model will replace the null value or the missing variable (no variable name in the
        /// eventVariables map) with calculated default mean/medians for numeric variables and
        /// with special values for categorical variables.
        /// </para>
        ///  
        /// <para>
        ///  <b>For imported SageMaker models:</b> 
        /// </para>
        ///  
        /// <para>
        /// If a null value is provided explicitly for a variable, the model and rules will use
        /// “null” as the value. If a variable is not provided (no variable name in the eventVariables
        /// map), model and rules will use the default value that is provided for the variable.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public Dictionary<string, string> EventVariables
        {
            get { return this._eventVariables; }
            set { this._eventVariables = value; }
        }

        // Check to see if EventVariables property is set
        internal bool IsSetEventVariables()
        {
            return this._eventVariables != null && this._eventVariables.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ExternalModelEndpointDataBlobs. 
        /// <para>
        /// The Amazon SageMaker model endpoint input data blobs.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
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