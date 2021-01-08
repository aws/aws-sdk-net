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
    /// The fraud prediction scores.
    /// </summary>
    public partial class ModelScores
    {
        private ModelVersion _modelVersion;
        private Dictionary<string, float> _scores = new Dictionary<string, float>();

        /// <summary>
        /// Gets and sets the property ModelVersion. 
        /// <para>
        /// The model version.
        /// </para>
        /// </summary>
        public ModelVersion ModelVersion
        {
            get { return this._modelVersion; }
            set { this._modelVersion = value; }
        }

        // Check to see if ModelVersion property is set
        internal bool IsSetModelVersion()
        {
            return this._modelVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Scores. 
        /// <para>
        /// The model's fraud prediction scores.
        /// </para>
        /// </summary>
        public Dictionary<string, float> Scores
        {
            get { return this._scores; }
            set { this._scores = value; }
        }

        // Check to see if Scores property is set
        internal bool IsSetScores()
        {
            return this._scores != null && this._scores.Count > 0; 
        }

    }
}