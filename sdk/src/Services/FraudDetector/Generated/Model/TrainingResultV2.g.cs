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
    /// The training result details.
    /// </summary>
    public partial class TrainingResultV2
    {
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
        public AggregatedVariablesImportanceMetrics AggregatedVariablesImportanceMetrics { get; set; }

        /// <summary>
        /// Checks to see if the AggregatedVariablesImportanceMetrics property is set.
        /// </summary>
        internal bool IsSetAggregatedVariablesImportanceMetrics() => this.AggregatedVariablesImportanceMetrics != null;

        /// <summary>
        /// Gets and sets the property DataValidationMetrics.
        /// </summary>
        public DataValidationMetrics DataValidationMetrics { get; set; }

        /// <summary>
        /// Checks to see if the DataValidationMetrics property is set.
        /// </summary>
        internal bool IsSetDataValidationMetrics() => this.DataValidationMetrics != null;

        /// <summary>
        /// Gets and sets the property TrainingMetricsV2. 
        /// <para>
        ///  The training metric details. 
        /// </para>
        /// </summary>
        public TrainingMetricsV2 TrainingMetricsV2 { get; set; }

        /// <summary>
        /// Checks to see if the TrainingMetricsV2 property is set.
        /// </summary>
        internal bool IsSetTrainingMetricsV2() => this.TrainingMetricsV2 != null;

        /// <summary>
        /// Gets and sets the property VariableImportanceMetrics.
        /// </summary>
        public VariableImportanceMetrics VariableImportanceMetrics { get; set; }

        /// <summary>
        /// Checks to see if the VariableImportanceMetrics property is set.
        /// </summary>
        internal bool IsSetVariableImportanceMetrics() => this.VariableImportanceMetrics != null;
    }
}
