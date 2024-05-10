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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
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
namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// Returns a summary of a pipeline.
    /// </summary>
    public partial class PipelineSummary
    {
        private DateTime? _created;
        private ExecutionMode _executionMode;
        private string _name;
        private PipelineType _pipelineType;
        private DateTime? _updated;
        private int? _version;

        /// <summary>
        /// Gets and sets the property Created. 
        /// <para>
        /// The date and time the pipeline was created, in timestamp format.
        /// </para>
        /// </summary>
        public DateTime? Created
        {
            get { return this._created; }
            set { this._created = value; }
        }

        // Check to see if Created property is set
        internal bool IsSetCreated()
        {
            return this._created.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExecutionMode. 
        /// <para>
        /// The method that the pipeline will use to handle multiple executions. The default mode
        /// is SUPERSEDED.
        /// </para>
        /// </summary>
        public ExecutionMode ExecutionMode
        {
            get { return this._executionMode; }
            set { this._executionMode = value; }
        }

        // Check to see if ExecutionMode property is set
        internal bool IsSetExecutionMode()
        {
            return this._executionMode != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PipelineType. 
        /// <para>
        /// CodePipeline provides the following pipeline types, which differ in characteristics
        /// and price, so that you can tailor your pipeline features and cost to the needs of
        /// your applications.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// V1 type pipelines have a JSON structure that contains standard pipeline, stage, and
        /// action-level parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// V2 type pipelines have the same structure as a V1 type, along with additional parameters
        /// for release safety and trigger configuration.
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// Including V2 parameters, such as triggers on Git tags, in the pipeline JSON when creating
        /// or updating a pipeline will result in the pipeline having the V2 type of pipeline
        /// and the associated costs.
        /// </para>
        ///  </important> 
        /// <para>
        /// For information about pricing for CodePipeline, see <a href="http://aws.amazon.com/codepipeline/pricing/">Pricing</a>.
        /// </para>
        ///  
        /// <para>
        ///  For information about which type of pipeline to choose, see <a href="https://docs.aws.amazon.com/codepipeline/latest/userguide/pipeline-types-planning.html">What
        /// type of pipeline is right for me?</a>.
        /// </para>
        /// </summary>
        public PipelineType PipelineType
        {
            get { return this._pipelineType; }
            set { this._pipelineType = value; }
        }

        // Check to see if PipelineType property is set
        internal bool IsSetPipelineType()
        {
            return this._pipelineType != null;
        }

        /// <summary>
        /// Gets and sets the property Updated. 
        /// <para>
        /// The date and time of the last update to the pipeline, in timestamp format.
        /// </para>
        /// </summary>
        public DateTime? Updated
        {
            get { return this._updated; }
            set { this._updated = value; }
        }

        // Check to see if Updated property is set
        internal bool IsSetUpdated()
        {
            return this._updated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version number of the pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version.HasValue; 
        }

    }
}