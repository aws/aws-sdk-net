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
    /// Container for the parameters to the CreateModelVersion operation. Creates a version
    /// of the model using the specified model type and model id.
    /// </summary>
    public partial class CreateModelVersionRequest : AmazonFraudDetectorRequest
    {
        /// <summary>
        /// Gets and sets the property ExternalEventsDetail. 
        /// <para>
        /// Details of the external events data used for model version training. Required if <c>trainingDataSource</c>
        /// is <c>EXTERNAL_EVENTS</c>.
        /// </para>
        /// </summary>
        public ExternalEventsDetail ExternalEventsDetail { get; set; }

        /// <summary>
        /// Checks to see if the ExternalEventsDetail property is set.
        /// </summary>
        internal bool IsSetExternalEventsDetail() => this.ExternalEventsDetail != null;

        /// <summary>
        /// Gets and sets the property IngestedEventsDetail. 
        /// <para>
        /// Details of the ingested events data used for model version training. Required if <c>trainingDataSource</c>
        /// is <c>INGESTED_EVENTS</c>.
        /// </para>
        /// </summary>
        public IngestedEventsDetail IngestedEventsDetail { get; set; }

        /// <summary>
        /// Checks to see if the IngestedEventsDetail property is set.
        /// </summary>
        internal bool IsSetIngestedEventsDetail() => this.IngestedEventsDetail != null;

        /// <summary>
        /// Gets and sets the property ModelId. 
        /// <para>
        /// The model ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ModelId { get; set; }

        /// <summary>
        /// Checks to see if the ModelId property is set.
        /// </summary>
        internal bool IsSetModelId() => this.ModelId != null;

        /// <summary>
        /// Gets and sets the property ModelType. 
        /// <para>
        /// The model type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ModelTypeEnum ModelType { get; set; }

        /// <summary>
        /// Checks to see if the ModelType property is set.
        /// </summary>
        internal bool IsSetModelType() => this.ModelType != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A collection of key and value pairs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TrainingDataSchema. 
        /// <para>
        /// The training data schema.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TrainingDataSchema TrainingDataSchema { get; set; }

        /// <summary>
        /// Checks to see if the TrainingDataSchema property is set.
        /// </summary>
        internal bool IsSetTrainingDataSchema() => this.TrainingDataSchema != null;

        /// <summary>
        /// Gets and sets the property TrainingDataSource. 
        /// <para>
        /// The training data source location in Amazon S3. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TrainingDataSourceEnum TrainingDataSource { get; set; }

        /// <summary>
        /// Checks to see if the TrainingDataSource property is set.
        /// </summary>
        internal bool IsSetTrainingDataSource() => this.TrainingDataSource != null;
    }
}
