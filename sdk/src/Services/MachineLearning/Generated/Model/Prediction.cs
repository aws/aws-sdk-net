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
 * Do not modify this file. This file is generated from the machinelearning-2014-12-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MachineLearning.Model
{
    /// <summary>
    /// The output from a <code>Predict</code> operation: 
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <code>Details</code> - Contains the following attributes: <code>DetailsAttributes.PREDICTIVE_MODEL_TYPE
    /// - REGRESSION | BINARY | MULTICLASS</code> <code>DetailsAttributes.ALGORITHM - SGD</code>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>PredictedLabel</code> - Present for either a <code>BINARY</code> or <code>MULTICLASS</code>
    /// <code>MLModel</code> request. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>PredictedScores</code> - Contains the raw classification score corresponding
    /// to each label. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>PredictedValue</code> - Present for a <code>REGRESSION</code> <code>MLModel</code>
    /// request. 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class Prediction
    {
        private Dictionary<string, string> _details = new Dictionary<string, string>();
        private string _predictedLabel;
        private Dictionary<string, float> _predictedScores = new Dictionary<string, float>();
        private float? _predictedValue;

        /// <summary>
        /// Gets and sets the property Details.
        /// </summary>
        public Dictionary<string, string> Details
        {
            get { return this._details; }
            set { this._details = value; }
        }

        // Check to see if Details property is set
        internal bool IsSetDetails()
        {
            return this._details != null && this._details.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PredictedLabel. 
        /// <para>
        /// The prediction label for either a <code>BINARY</code> or <code>MULTICLASS</code> <code>MLModel</code>.
        /// </para>
        /// </summary>
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
        /// </summary>
        public Dictionary<string, float> PredictedScores
        {
            get { return this._predictedScores; }
            set { this._predictedScores = value; }
        }

        // Check to see if PredictedScores property is set
        internal bool IsSetPredictedScores()
        {
            return this._predictedScores != null && this._predictedScores.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PredictedValue. The prediction value for <code>REGRESSION</code>
        /// <code>MLModel</code>.
        /// </summary>
        public float PredictedValue
        {
            get { return this._predictedValue.GetValueOrDefault(); }
            set { this._predictedValue = value; }
        }

        // Check to see if PredictedValue property is set
        internal bool IsSetPredictedValue()
        {
            return this._predictedValue.HasValue; 
        }

    }
}