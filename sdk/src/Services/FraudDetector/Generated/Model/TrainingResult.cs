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
    /// The training result details.
    /// </summary>
    public partial class TrainingResult
    {
        private DataValidationMetrics _dataValidationMetrics;
        private TrainingMetrics _trainingMetrics;

        /// <summary>
        /// Gets and sets the property DataValidationMetrics. 
        /// <para>
        /// The validation metrics.
        /// </para>
        /// </summary>
        public DataValidationMetrics DataValidationMetrics
        {
            get { return this._dataValidationMetrics; }
            set { this._dataValidationMetrics = value; }
        }

        // Check to see if DataValidationMetrics property is set
        internal bool IsSetDataValidationMetrics()
        {
            return this._dataValidationMetrics != null;
        }

        /// <summary>
        /// Gets and sets the property TrainingMetrics. 
        /// <para>
        /// The training metric details.
        /// </para>
        /// </summary>
        public TrainingMetrics TrainingMetrics
        {
            get { return this._trainingMetrics; }
            set { this._trainingMetrics = value; }
        }

        // Check to see if TrainingMetrics property is set
        internal bool IsSetTrainingMetrics()
        {
            return this._trainingMetrics != null;
        }

    }
}