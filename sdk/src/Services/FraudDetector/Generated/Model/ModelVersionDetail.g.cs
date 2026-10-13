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
    /// The details of the model version.
    /// </summary>
    public partial class ModelVersionDetail
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The model version ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The timestamp when the model was created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 11, Max = 30)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime != null;

        /// <summary>
        /// Gets and sets the property ExternalEventsDetail. 
        /// <para>
        /// The external events data details. This will be populated if the <c>trainingDataSource</c>
        /// for the model version is specified as <c>EXTERNAL_EVENTS</c>.
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
        /// The ingested events data details. This will be populated if the <c>trainingDataSource</c>
        /// for the model version is specified as <c>INGESTED_EVENTS</c>.
        /// </para>
        /// </summary>
        public IngestedEventsDetail IngestedEventsDetail { get; set; }

        /// <summary>
        /// Checks to see if the IngestedEventsDetail property is set.
        /// </summary>
        internal bool IsSetIngestedEventsDetail() => this.IngestedEventsDetail != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The timestamp when the model was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 11, Max = 30)]
        public string LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime != null;

        /// <summary>
        /// Gets and sets the property ModelId. 
        /// <para>
        /// The model ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
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
        public ModelTypeEnum ModelType { get; set; }

        /// <summary>
        /// Checks to see if the ModelType property is set.
        /// </summary>
        internal bool IsSetModelType() => this.ModelType != null;

        /// <summary>
        /// Gets and sets the property ModelVersionNumber. 
        /// <para>
        /// The model version number.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 7)]
        public string ModelVersionNumber { get; set; }

        /// <summary>
        /// Checks to see if the ModelVersionNumber property is set.
        /// </summary>
        internal bool IsSetModelVersionNumber() => this.ModelVersionNumber != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the model version.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TrainingDataSchema. 
        /// <para>
        /// The training data schema.
        /// </para>
        /// </summary>
        public TrainingDataSchema TrainingDataSchema { get; set; }

        /// <summary>
        /// Checks to see if the TrainingDataSchema property is set.
        /// </summary>
        internal bool IsSetTrainingDataSchema() => this.TrainingDataSchema != null;

        /// <summary>
        /// Gets and sets the property TrainingDataSource. 
        /// <para>
        /// The model version training data source.
        /// </para>
        /// </summary>
        public TrainingDataSourceEnum TrainingDataSource { get; set; }

        /// <summary>
        /// Checks to see if the TrainingDataSource property is set.
        /// </summary>
        internal bool IsSetTrainingDataSource() => this.TrainingDataSource != null;

        /// <summary>
        /// Gets and sets the property TrainingResult. 
        /// <para>
        /// The training results.
        /// </para>
        /// </summary>
        public TrainingResult TrainingResult { get; set; }

        /// <summary>
        /// Checks to see if the TrainingResult property is set.
        /// </summary>
        internal bool IsSetTrainingResult() => this.TrainingResult != null;

        /// <summary>
        /// Gets and sets the property TrainingResultV2. 
        /// <para>
        ///  The training result details. The details include the relative importance of the variables.
        /// 
        /// </para>
        /// </summary>
        public TrainingResultV2 TrainingResultV2 { get; set; }

        /// <summary>
        /// Checks to see if the TrainingResultV2 property is set.
        /// </summary>
        internal bool IsSetTrainingResultV2() => this.TrainingResultV2 != null;
    }
}
