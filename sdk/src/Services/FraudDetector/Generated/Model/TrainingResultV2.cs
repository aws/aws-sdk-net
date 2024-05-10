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
    /// The training result details.
    /// </summary>
    public partial class TrainingResultV2
    {
        private AggregatedVariablesImportanceMetrics _aggregatedVariablesImportanceMetrics;
        private DataValidationMetrics _dataValidationMetrics;
        private TrainingMetricsV2 _trainingMetricsV2;
        private VariableImportanceMetrics _variableImportanceMetrics;

        /// <summary>
        /// Gets and sets the property AggregatedVariablesImportanceMetrics. 
        /// <para>
        ///  The variable importance metrics of the aggregated variables. 
        /// </para>
        ///  
        /// <para>
        /// Account Takeover Insights (ATI) model uses event variables from the login data you
        /// provide to continuously calculate a set of variables (aggregated variables) based
        /// on historical events. For example, your ATI model might calculate the number of times
        /// an user has logged in using the same IP address. In this case, event variables used
        /// to derive the aggregated variables are <c>IP address</c> and <c>user</c>.
        /// </para>
        /// </summary>
        public AggregatedVariablesImportanceMetrics AggregatedVariablesImportanceMetrics
        {
            get { return this._aggregatedVariablesImportanceMetrics; }
            set { this._aggregatedVariablesImportanceMetrics = value; }
        }

        // Check to see if AggregatedVariablesImportanceMetrics property is set
        internal bool IsSetAggregatedVariablesImportanceMetrics()
        {
            return this._aggregatedVariablesImportanceMetrics != null;
        }

        /// <summary>
        /// Gets and sets the property DataValidationMetrics.
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
        /// Gets and sets the property TrainingMetricsV2. 
        /// <para>
        ///  The training metric details. 
        /// </para>
        /// </summary>
        public TrainingMetricsV2 TrainingMetricsV2
        {
            get { return this._trainingMetricsV2; }
            set { this._trainingMetricsV2 = value; }
        }

        // Check to see if TrainingMetricsV2 property is set
        internal bool IsSetTrainingMetricsV2()
        {
            return this._trainingMetricsV2 != null;
        }

        /// <summary>
        /// Gets and sets the property VariableImportanceMetrics.
        /// </summary>
        public VariableImportanceMetrics VariableImportanceMetrics
        {
            get { return this._variableImportanceMetrics; }
            set { this._variableImportanceMetrics = value; }
        }

        // Check to see if VariableImportanceMetrics property is set
        internal bool IsSetVariableImportanceMetrics()
        {
            return this._variableImportanceMetrics != null;
        }

    }
}