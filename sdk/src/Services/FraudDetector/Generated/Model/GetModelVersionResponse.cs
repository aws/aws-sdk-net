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
    /// This is the response object from the GetModelVersion operation.
    /// </summary>
    public partial class GetModelVersionResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private ExternalEventsDetail _externalEventsDetail;
        private IngestedEventsDetail _ingestedEventsDetail;
        private string _modelId;
        private ModelTypeEnum _modelType;
        private string _modelVersionNumber;
        private string _status;
        private TrainingDataSchema _trainingDataSchema;
        private TrainingDataSourceEnum _trainingDataSource;

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
        /// Gets and sets the property ExternalEventsDetail. 
        /// <para>
        /// The details of the external events data used for training the model version. This
        /// will be populated if the <c>trainingDataSource</c> is <c>EXTERNAL_EVENTS</c> 
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
        /// The details of the ingested events data used for training the model version. This
        /// will be populated if the <c>trainingDataSource</c> is <c>INGESTED_EVENTS</c>.
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
        /// The model version status.
        /// </para>
        ///  
        /// <para>
        /// Possible values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>TRAINING_IN_PROGRESS</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TRAINING_COMPLETE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTIVATE_REQUESTED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTIVATE_IN_PROGRESS</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTIVE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INACTIVATE_REQUESTED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INACTIVATE_IN_PROGRESS</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INACTIVE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ERROR</c> 
        /// </para>
        ///  </li> </ul>
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
        /// The training data source.
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

    }
}