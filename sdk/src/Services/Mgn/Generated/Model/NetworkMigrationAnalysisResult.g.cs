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

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// The result of a network migration analysis operation.
    /// </summary>
    public partial class NetworkMigrationAnalysisResult
    {
        /// <summary>
        /// Gets and sets the property AnalysisResult. 
        /// <para>
        /// The detailed analysis findings and recommendations.
        /// </para>
        /// </summary>
        public string AnalysisResult { get; set; }

        /// <summary>
        /// Checks to see if the AnalysisResult property is set.
        /// </summary>
        internal bool IsSetAnalysisResult() => this.AnalysisResult != null;

        /// <summary>
        /// Gets and sets the property AnalyzerType. 
        /// <para>
        /// The type of analyzer that generated this result.
        /// </para>
        /// </summary>
        public AnalyzerType AnalyzerType { get; set; }

        /// <summary>
        /// Checks to see if the AnalyzerType property is set.
        /// </summary>
        internal bool IsSetAnalyzerType() => this.AnalyzerType != null;

        /// <summary>
        /// Gets and sets the property JobID. 
        /// <para>
        /// The unique identifier of the analysis job that generated this result.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string JobID { get; set; }

        /// <summary>
        /// Checks to see if the JobID property is set.
        /// </summary>
        internal bool IsSetJobID() => this.JobID != null;

        /// <summary>
        /// Gets and sets the property NetworkMigrationDefinitionID. 
        /// <para>
        /// The unique identifier of the network migration definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 21, Max = 21)]
        public string NetworkMigrationDefinitionID { get; set; }

        /// <summary>
        /// Checks to see if the NetworkMigrationDefinitionID property is set.
        /// </summary>
        internal bool IsSetNetworkMigrationDefinitionID() => this.NetworkMigrationDefinitionID != null;

        /// <summary>
        /// Gets and sets the property NetworkMigrationExecutionID. 
        /// <para>
        /// The unique identifier of the network migration execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string NetworkMigrationExecutionID { get; set; }

        /// <summary>
        /// Checks to see if the NetworkMigrationExecutionID property is set.
        /// </summary>
        internal bool IsSetNetworkMigrationExecutionID() => this.NetworkMigrationExecutionID != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source resource that was analyzed.
        /// </para>
        /// </summary>
        public NetworkMigrationAnalysisResultSource Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the analysis result.
        /// </para>
        /// </summary>
        public NetworkMigrationAnalysisResultStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// The target resource in the analysis.
        /// </para>
        /// </summary>
        public NetworkMigrationAnalysisResultTarget Target { get; set; }

        /// <summary>
        /// Checks to see if the Target property is set.
        /// </summary>
        internal bool IsSetTarget() => this.Target != null;
    }
}
