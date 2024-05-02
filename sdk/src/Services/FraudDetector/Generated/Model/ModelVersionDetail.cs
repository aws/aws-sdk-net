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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.FraudDetector.Model
{
    /// <summary>
    /// The details of the model version.
    /// </summary>
    public partial class ModelVersionDetail
    {
        private string _arn;
        private string _createdTime;
        private ExternalEventsDetail _externalEventsDetail;
        private IngestedEventsDetail _ingestedEventsDetail;
        private string _lastUpdatedTime;
        private string _modelId;
        private ModelTypeEnum _modelType;
        private string _modelVersionNumber;
        private string _status;
        private TrainingDataSchema _trainingDataSchema;
        private TrainingDataSourceEnum _trainingDataSource;
        private TrainingResult _trainingResult;
        private TrainingResultV2 _trainingResultV2;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The model version ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The timestamp when the model was created.
        /// </para>
        /// </summary>
        [AWSProperty(Min=11, Max=30)]
        public string CreatedTime
        {
            get { return this._createdTime; }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime != null;
        }

        /// <summary>
        /// Gets and sets the property ExternalEventsDetail. 
        /// <para>
        /// The external events data details. This will be populated if the <c>trainingDataSource</c>
        /// for the model version is specified as <c>EXTERNAL_EVENTS</c>.
        /// </para>
        /// </summary>
        public ExternalEventsDetail ExternalEventsDetail
        {
            get { return this._externalEventsDetail; }
            set { this._externalEventsDetail = value; }
        }

        // Check to see if ExternalEventsDetail property is set
        internal bool IsSetExternalEventsDetail()
        {
            return this._externalEventsDetail != null;
        }

        /// <summary>
        /// Gets and sets the property IngestedEventsDetail. 
        /// <para>
        /// The ingested events data details. This will be populated if the <c>trainingDataSource</c>
        /// for the model version is specified as <c>INGESTED_EVENTS</c>.
        /// </para>
        /// </summary>
        public IngestedEventsDetail IngestedEventsDetail
        {
            get { return this._ingestedEventsDetail; }
            set { this._ingestedEventsDetail = value; }
        }

        // Check to see if IngestedEventsDetail property is set
        internal bool IsSetIngestedEventsDetail()
        {
            return this._ingestedEventsDetail != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The timestamp when the model was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=11, Max=30)]
        public string LastUpdatedTime
        {
            get { return this._lastUpdatedTime; }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime != null;
        }

        /// <summary>
        /// Gets and sets the property ModelId. 
        /// <para>
        /// The model ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ModelId
        {
            get { return this._modelId; }
            set { this._modelId = value; }
        }

        // Check to see if ModelId property is set
        internal bool IsSetModelId()
        {
            return this._modelId != null;
        }

        /// <summary>
        /// Gets and sets the property ModelType. 
        /// <para>
        /// The model type.
        /// </para>
        /// </summary>
        public ModelTypeEnum ModelType
        {
            get { return this._modelType; }
            set { this._modelType = value; }
        }

        // Check to see if ModelType property is set
        internal bool IsSetModelType()
        {
            return this._modelType != null;
        }

        /// <summary>
        /// Gets and sets the property ModelVersionNumber. 
        /// <para>
        /// The model version number.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=7)]
        public string ModelVersionNumber
        {
            get { return this._modelVersionNumber; }
            set { this._modelVersionNumber = value; }
        }

        // Check to see if ModelVersionNumber property is set
        internal bool IsSetModelVersionNumber()
        {
            return this._modelVersionNumber != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the model version.
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TrainingDataSchema. 
        /// <para>
        /// The training data schema.
        /// </para>
        /// </summary>
        public TrainingDataSchema TrainingDataSchema
        {
            get { return this._trainingDataSchema; }
            set { this._trainingDataSchema = value; }
        }

        // Check to see if TrainingDataSchema property is set
        internal bool IsSetTrainingDataSchema()
        {
            return this._trainingDataSchema != null;
        }

        /// <summary>
        /// Gets and sets the property TrainingDataSource. 
        /// <para>
        /// The model version training data source.
        /// </para>
        /// </summary>
        public TrainingDataSourceEnum TrainingDataSource
        {
            get { return this._trainingDataSource; }
            set { this._trainingDataSource = value; }
        }

        // Check to see if TrainingDataSource property is set
        internal bool IsSetTrainingDataSource()
        {
            return this._trainingDataSource != null;
        }

        /// <summary>
        /// Gets and sets the property TrainingResult. 
        /// <para>
        /// The training results.
        /// </para>
        /// </summary>
        public TrainingResult TrainingResult
        {
            get { return this._trainingResult; }
            set { this._trainingResult = value; }
        }

        // Check to see if TrainingResult property is set
        internal bool IsSetTrainingResult()
        {
            return this._trainingResult != null;
        }

        /// <summary>
        /// Gets and sets the property TrainingResultV2. 
        /// <para>
        ///  The training result details. The details include the relative importance of the variables.
        /// 
        /// </para>
        /// </summary>
        public TrainingResultV2 TrainingResultV2
        {
            get { return this._trainingResultV2; }
            set { this._trainingResultV2 = value; }
        }

        // Check to see if TrainingResultV2 property is set
        internal bool IsSetTrainingResultV2()
        {
            return this._trainingResultV2 != null;
        }

    }
}