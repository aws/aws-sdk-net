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
    /// Container for the parameters to the GetEventPrediction operation. Evaluates an event
    /// against a detector version. If a version ID is not provided, the detector’s (<c>ACTIVE</c>)
    /// version is used.
    /// </summary>
    public partial class GetEventPredictionRequest : AmazonFraudDetectorRequest
    {
        /// <summary>
        /// Gets and sets the property DetectorId. 
        /// <para>
        /// The detector ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DetectorId { get; set; }

        /// <summary>
        /// Checks to see if the DetectorId property is set.
        /// </summary>
        internal bool IsSetDetectorId() => this.DetectorId != null;

        /// <summary>
        /// Gets and sets the property DetectorVersionId. 
        /// <para>
        /// The detector version ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public string DetectorVersionId { get; set; }

        /// <summary>
        /// Checks to see if the DetectorVersionId property is set.
        /// </summary>
        internal bool IsSetDetectorVersionId() => this.DetectorVersionId != null;

        /// <summary>
        /// Gets and sets the property Entities. 
        /// <para>
        /// The entity type (associated with the detector's event type) and specific entity ID
        /// representing who performed the event. If an entity id is not available, use "UNKNOWN."
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<Entity> Entities { get; set; } = AWSConfigs.InitializeCollections ? new List<Entity>() : null;

        /// <summary>
        /// Checks to see if the Entities property is set.
        /// </summary>
        internal bool IsSetEntities() => this.Entities != null && (this.Entities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// The unique ID used to identify the event.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string EventId { get; set; }

        /// <summary>
        /// Checks to see if the EventId property is set.
        /// </summary>
        internal bool IsSetEventId() => this.EventId != null;

        /// <summary>
        /// Gets and sets the property EventTimestamp. 
        /// <para>
        /// Timestamp that defines when the event under evaluation occurred. The timestamp must
        /// be specified using ISO 8601 standard in UTC.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 30)]
        public string EventTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the EventTimestamp property is set.
        /// </summary>
        internal bool IsSetEventTimestamp() => this.EventTimestamp != null;

        /// <summary>
        /// Gets and sets the property EventTypeName. 
        /// <para>
        /// The event type associated with the detector specified for the prediction.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string EventTypeName { get; set; }

        /// <summary>
        /// Checks to see if the EventTypeName property is set.
        /// </summary>
        internal bool IsSetEventTypeName() => this.EventTypeName != null;

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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public Dictionary<string, string> EventVariables { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the EventVariables property is set.
        /// </summary>
        internal bool IsSetEventVariables() => this.EventVariables != null && (this.EventVariables.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ExternalModelEndpointDataBlobs. 
        /// <para>
        /// The Amazon SageMaker model endpoint input data blobs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Dictionary<string, ModelEndpointDataBlob> ExternalModelEndpointDataBlobs { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, ModelEndpointDataBlob>() : null;

        /// <summary>
        /// Checks to see if the ExternalModelEndpointDataBlobs property is set.
        /// </summary>
        internal bool IsSetExternalModelEndpointDataBlobs() => this.ExternalModelEndpointDataBlobs != null && (this.ExternalModelEndpointDataBlobs.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
