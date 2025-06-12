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
 * Do not modify this file. This file is generated from the machinelearning-2014-12-12.normal.json service model.
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
namespace Amazon.MachineLearning.Model
{
    /// <summary>
    /// The output from a <c>Predict</c> operation: 
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <c>Details</c> - Contains the following attributes: <c>DetailsAttributes.PREDICTIVE_MODEL_TYPE
    /// - REGRESSION | BINARY | MULTICLASS</c> <c>DetailsAttributes.ALGORITHM - SGD</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>PredictedLabel</c> - Present for either a <c>BINARY</c> or <c>MULTICLASS</c> <c>MLModel</c>
    /// request. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>PredictedScores</c> - Contains the raw classification score corresponding to each
    /// label. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>PredictedValue</c> - Present for a <c>REGRESSION</c> <c>MLModel</c> request. 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class Prediction
    {
        private Dictionary<string, string> _details = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _predictedLabel;
        private Dictionary<string, float> _predictedScores = AWSConfigs.InitializeCollections ? new Dictionary<string, float>() : null;
        private float? _predictedValue;

        /// <summary>
        /// Gets and sets the property Details.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Details
        {
            get { return this._details; }
            set { this._details = value; }
        }

        // Check to see if Details property is set
        internal bool IsSetDetails()
        {
            return this._details != null && (this._details.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PredictedLabel. 
        /// <para>
        /// The prediction label for either a <c>BINARY</c> or <c>MULTICLASS</c> <c>MLModel</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string PredictedLabel
        {
            get { return this._predictedLabel; }
            set { this._predictedLabel = value; }
        }

        // Check to see if PredictedLabel property is set
        internal bool IsSetPredictedLabel()
        {
            return this._predictedLabel != null;
        }

        /// <summary>
        /// Gets and sets the property PredictedScores.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, float> PredictedScores
        {
            get { return this._predictedScores; }
            set { this._predictedScores = value; }
        }

        // Check to see if PredictedScores property is set
        internal bool IsSetPredictedScores()
        {
            return this._predictedScores != null && (this._predictedScores.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PredictedValue. 
        /// <para>
        /// The prediction value for <c>REGRESSION</c> <c>MLModel</c>.
        /// </para>
        /// </summary>
        public float? PredictedValue
        {
            get { return this._predictedValue; }
            set { this._predictedValue = value; }
        }

        // Check to see if PredictedValue property is set
        internal bool IsSetPredictedValue()
        {
            return this._predictedValue.HasValue; 
        }

    }
}