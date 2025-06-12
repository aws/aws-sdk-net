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
    /// A SageMaker Model Building Pipeline instance.
    /// </summary>
    public partial class Pipeline
    {
        private UserContext _createdBy;
        private DateTime? _creationTime;
        private UserContext _lastModifiedBy;
        private DateTime? _lastModifiedTime;
        private DateTime? _lastRunTime;
        private ParallelismConfiguration _parallelismConfiguration;
        private string _pipelineArn;
        private string _pipelineDescription;
        private string _pipelineDisplayName;
        private string _pipelineName;
        private PipelineStatus _pipelineStatus;
        private string _roleArn;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property CreatedBy.
        /// </summary>
        public UserContext CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

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
        /// Gets and sets the property LastModifiedBy.
        /// </summary>
        public UserContext LastModifiedBy
        {
            get { return this._lastModifiedBy; }
            set { this._lastModifiedBy = value; }
        }

        // Check to see if LastModifiedBy property is set
        internal bool IsSetLastModifiedBy()
        {
            return this._lastModifiedBy != null;
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
        /// Gets and sets the property LastRunTime. 
        /// <para>
        /// The time when the pipeline was last run.
        /// </para>
        /// </summary>
        public DateTime? LastRunTime
        {
            get { return this._lastRunTime; }
            set { this._lastRunTime = value; }
        }

        // Check to see if LastRunTime property is set
        internal bool IsSetLastRunTime()
        {
            return this._lastRunTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ParallelismConfiguration. 
        /// <para>
        /// The parallelism configuration applied to the pipeline.
        /// </para>
        /// </summary>
        public ParallelismConfiguration ParallelismConfiguration
        {
            get { return this._parallelismConfiguration; }
            set { this._parallelismConfiguration = value; }
        }

        // Check to see if ParallelismConfiguration property is set
        internal bool IsSetParallelismConfiguration()
        {
            return this._parallelismConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property PipelineArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the pipeline.
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
        /// Gets and sets the property PipelineStatus. 
        /// <para>
        /// The status of the pipeline.
        /// </para>
        /// </summary>
        public PipelineStatus PipelineStatus
        {
            get { return this._pipelineStatus; }
            set { this._pipelineStatus = value; }
        }

        // Check to see if PipelineStatus property is set
        internal bool IsSetPipelineStatus()
        {
            return this._pipelineStatus != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the role that created the pipeline.
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags that apply to the pipeline.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}