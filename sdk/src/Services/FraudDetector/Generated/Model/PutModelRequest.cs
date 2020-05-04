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
    /// Container for the parameters to the PutModel operation.
    /// Creates or updates a model.
    /// </summary>
    public partial class PutModelRequest : AmazonFraudDetectorRequest
    {
        private string _description;
        private LabelSchema _labelSchema;
        private string _modelId;
        private ModelTypeEnum _modelType;
        private List<ModelVariable> _modelVariables = new List<ModelVariable>();
        private TrainingDataSource _trainingDataSource;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The model description. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property LabelSchema. 
        /// <para>
        /// The label schema.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LabelSchema LabelSchema
        {
            get { return this._labelSchema; }
            set { this._labelSchema = value; }
        }

        // Check to see if LabelSchema property is set
        internal bool IsSetLabelSchema()
        {
            return this._labelSchema != null;
        }

        /// <summary>
        /// Gets and sets the property ModelId. 
        /// <para>
        /// The model ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ModelVariables. 
        /// <para>
        /// The model input variables.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ModelVariable> ModelVariables
        {
            get { return this._modelVariables; }
            set { this._modelVariables = value; }
        }

        // Check to see if ModelVariables property is set
        internal bool IsSetModelVariables()
        {
            return this._modelVariables != null && this._modelVariables.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TrainingDataSource. 
        /// <para>
        /// The training data source location in Amazon S3. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TrainingDataSource TrainingDataSource
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