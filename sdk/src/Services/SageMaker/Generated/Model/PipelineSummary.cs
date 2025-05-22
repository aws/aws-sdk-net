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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A summary of a pipeline.
    /// </summary>
    public partial class PipelineSummary
    {
        private DateTime? _creationTime;
        private DateTime? _lastExecutionTime;
        private DateTime? _lastModifiedTime;
        private string _pipelineArn;
        private string _pipelineDescription;
        private string _pipelineDisplayName;
        private string _pipelineName;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time of the pipeline.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastExecutionTime. 
        /// <para>
        /// The last time that a pipeline execution began.
        /// </para>
        /// </summary>
        public DateTime? LastExecutionTime
        {
            get { return this._lastExecutionTime; }
            set { this._lastExecutionTime = value; }
        }

        // Check to see if LastExecutionTime property is set
        internal bool IsSetLastExecutionTime()
        {
            return this._lastExecutionTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The time that the pipeline was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PipelineArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string PipelineArn
        {
            get { return this._pipelineArn; }
            set { this._pipelineArn = value; }
        }

        // Check to see if PipelineArn property is set
        internal bool IsSetPipelineArn()
        {
            return this._pipelineArn != null;
        }

        /// <summary>
        /// Gets and sets the property PipelineDescription. 
        /// <para>
        /// The description of the pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=3072)]
        public string PipelineDescription
        {
            get { return this._pipelineDescription; }
            set { this._pipelineDescription = value; }
        }

        // Check to see if PipelineDescription property is set
        internal bool IsSetPipelineDescription()
        {
            return this._pipelineDescription != null;
        }

        /// <summary>
        /// Gets and sets the property PipelineDisplayName. 
        /// <para>
        /// The display name of the pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string PipelineDisplayName
        {
            get { return this._pipelineDisplayName; }
            set { this._pipelineDisplayName = value; }
        }

        // Check to see if PipelineDisplayName property is set
        internal bool IsSetPipelineDisplayName()
        {
            return this._pipelineDisplayName != null;
        }

        /// <summary>
        /// Gets and sets the property PipelineName. 
        /// <para>
        /// The name of the pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string PipelineName
        {
            get { return this._pipelineName; }
            set { this._pipelineName = value; }
        }

        // Check to see if PipelineName property is set
        internal bool IsSetPipelineName()
        {
            return this._pipelineName != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that the pipeline used to execute.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

    }
}