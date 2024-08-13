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
 * Do not modify this file. This file is generated from the codecatalyst-2022-09-28.normal.json service model.
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
namespace Amazon.CodeCatalyst.Model
{
    /// <summary>
    /// This is the response object from the GetWorkflow operation.
    /// </summary>
    public partial class GetWorkflowResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdTime;
        private WorkflowDefinition _definition;
        private string _id;
        private DateTime? _lastUpdatedTime;
        private string _name;
        private string _projectName;
        private WorkflowRunMode _runMode;
        private string _sourceBranchName;
        private string _sourceRepositoryName;
        private string _spaceName;
        private WorkflowStatus _status;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The date and time the workflow was created, in coordinated universal time (UTC) timestamp
        /// format as specified in <a href="https://www.rfc-editor.org/rfc/rfc3339#section-5.6">RFC
        /// 3339</a> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedTime
        {
            get { return this._createdTime; }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Definition. 
        /// <para>
        /// Information about the workflow definition file for the workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public WorkflowDefinition Definition
        {
            get { return this._definition; }
            set { this._definition = value; }
        }

        // Check to see if Definition property is set
        internal bool IsSetDefinition()
        {
            return this._definition != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The date and time the workflow was last updated, in coordinated universal time (UTC)
        /// timestamp format as specified in <a href="https://www.rfc-editor.org/rfc/rfc3339#section-5.6">RFC
        /// 3339</a> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastUpdatedTime
        {
            get { return this._lastUpdatedTime; }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ProjectName. 
        /// <para>
        /// The name of the project in the space.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=63)]
        public string ProjectName
        {
            get { return this._projectName; }
            set { this._projectName = value; }
        }

        // Check to see if ProjectName property is set
        internal bool IsSetProjectName()
        {
            return this._projectName != null;
        }

        /// <summary>
        /// Gets and sets the property RunMode. 
        /// <para>
        /// The behavior to use when multiple workflows occur at the same time. For more information,
        /// see <a href="https://docs.aws.amazon.com/codecatalyst/latest/userguide/workflows-configure-runs.html">https://docs.aws.amazon.com/codecatalyst/latest/userguide/workflows-configure-runs.html</a>
        /// in the Amazon CodeCatalyst User Guide.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public WorkflowRunMode RunMode
        {
            get { return this._runMode; }
            set { this._runMode = value; }
        }

        // Check to see if RunMode property is set
        internal bool IsSetRunMode()
        {
            return this._runMode != null;
        }

        /// <summary>
        /// Gets and sets the property SourceBranchName. 
        /// <para>
        /// The name of the branch that contains the workflow YAML.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string SourceBranchName
        {
            get { return this._sourceBranchName; }
            set { this._sourceBranchName = value; }
        }

        // Check to see if SourceBranchName property is set
        internal bool IsSetSourceBranchName()
        {
            return this._sourceBranchName != null;
        }

        /// <summary>
        /// Gets and sets the property SourceRepositoryName. 
        /// <para>
        /// The name of the source repository where the workflow YAML is stored.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string SourceRepositoryName
        {
            get { return this._sourceRepositoryName; }
            set { this._sourceRepositoryName = value; }
        }

        // Check to see if SourceRepositoryName property is set
        internal bool IsSetSourceRepositoryName()
        {
            return this._sourceRepositoryName != null;
        }

        /// <summary>
        /// Gets and sets the property SpaceName. 
        /// <para>
        /// The name of the space.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=63)]
        public string SpaceName
        {
            get { return this._spaceName; }
            set { this._spaceName = value; }
        }

        // Check to see if SpaceName property is set
        internal bool IsSetSpaceName()
        {
            return this._spaceName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public WorkflowStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}