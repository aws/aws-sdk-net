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
    /// The model version evaluated for generating prediction.
    /// </summary>
    public partial class EvaluatedModelVersion
    {
        private List<ModelVersionEvaluation> _evaluations = AWSConfigs.InitializeCollections ? new List<ModelVersionEvaluation>() : null;
        private string _modelId;
        private string _modelType;
        private string _modelVersion;

        /// <summary>
        /// Gets and sets the property Evaluations. 
        /// <para>
        ///  Evaluations generated for the model version. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ModelVersionEvaluation> Evaluations
        {
            get { return this._evaluations; }
            set { this._evaluations = value; }
        }

        // Check to see if Evaluations property is set
        internal bool IsSetEvaluations()
        {
            return this._evaluations != null && (this._evaluations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ModelId. 
        /// <para>
        ///  The model ID. 
        /// </para>
        /// </summary>
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
        ///  
        /// <para>
        /// Valid values: <c>ONLINE_FRAUD_INSIGHTS</c> | <c>TRANSACTION_FRAUD_INSIGHTS</c> 
        /// </para>
        /// </summary>
        public string ModelType
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
        /// Gets and sets the property ModelVersion. 
        /// <para>
        ///  The model version. 
        /// </para>
        /// </summary>
        public string ModelVersion
        {
            get { return this._modelVersion; }
            set { this._modelVersion = value; }
        }

        // Check to see if ModelVersion property is set
        internal bool IsSetModelVersion()
        {
            return this._modelVersion != null;
        }

    }
}