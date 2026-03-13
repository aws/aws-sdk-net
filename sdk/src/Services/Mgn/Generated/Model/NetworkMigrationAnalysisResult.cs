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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
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
        private string _analysisResult;
        private AnalyzerType _analyzerType;
        private string _jobid;
        private string _networkMigrationDefinitionID;
        private string _networkMigrationExecutionID;
        private NetworkMigrationAnalysisResultSource _source;
        private NetworkMigrationAnalysisResultStatus _status;
        private NetworkMigrationAnalysisResultTarget _target;

        /// <summary>
        /// Gets and sets the property AnalysisResult. 
        /// <para>
        /// The detailed analysis findings and recommendations.
        /// </para>
        /// </summary>
        public string AnalysisResult
        {
            get { return this._analysisResult; }
            set { this._analysisResult = value; }
        }

        // Check to see if AnalysisResult property is set
        internal bool IsSetAnalysisResult()
        {
            return this._analysisResult != null;
        }

        /// <summary>
        /// Gets and sets the property AnalyzerType. 
        /// <para>
        /// The type of analyzer that generated this result.
        /// </para>
        /// </summary>
        public AnalyzerType AnalyzerType
        {
            get { return this._analyzerType; }
            set { this._analyzerType = value; }
        }

        // Check to see if AnalyzerType property is set
        internal bool IsSetAnalyzerType()
        {
            return this._analyzerType != null;
        }

        /// <summary>
        /// Gets and sets the property JobID. 
        /// <para>
        /// The unique identifier of the analysis job that generated this result.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string JobID
        {
            get { return this._jobid; }
            set { this._jobid = value; }
        }

        // Check to see if JobID property is set
        internal bool IsSetJobID()
        {
            return this._jobid != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkMigrationDefinitionID. 
        /// <para>
        /// The unique identifier of the network migration definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min=21, Max=21)]
        public string NetworkMigrationDefinitionID
        {
            get { return this._networkMigrationDefinitionID; }
            set { this._networkMigrationDefinitionID = value; }
        }

        // Check to see if NetworkMigrationDefinitionID property is set
        internal bool IsSetNetworkMigrationDefinitionID()
        {
            return this._networkMigrationDefinitionID != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkMigrationExecutionID. 
        /// <para>
        /// The unique identifier of the network migration execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string NetworkMigrationExecutionID
        {
            get { return this._networkMigrationExecutionID; }
            set { this._networkMigrationExecutionID = value; }
        }

        // Check to see if NetworkMigrationExecutionID property is set
        internal bool IsSetNetworkMigrationExecutionID()
        {
            return this._networkMigrationExecutionID != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source resource that was analyzed.
        /// </para>
        /// </summary>
        public NetworkMigrationAnalysisResultSource Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the analysis result.
        /// </para>
        /// </summary>
        public NetworkMigrationAnalysisResultStatus Status
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
        /// Gets and sets the property Target. 
        /// <para>
        /// The target resource in the analysis.
        /// </para>
        /// </summary>
        public NetworkMigrationAnalysisResultTarget Target
        {
            get { return this._target; }
            set { this._target = value; }
        }

        // Check to see if Target property is set
        internal bool IsSetTarget()
        {
            return this._target != null;
        }

    }
}