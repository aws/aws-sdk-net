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
 * Do not modify this file. This file is generated from the mwaa-serverless-2024-07-26.normal.json service model.
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
namespace Amazon.MWAAServerless.Model
{
    /// <summary>
    /// Summary information about a workflow version, including identification and configuration
    /// details.
    /// </summary>
    public partial class WorkflowVersionSummary
    {
        private DateTime? _createdAt;
        private DefinitionS3Location _definitionS3Location;
        private bool? _isLatestVersion;
        private DateTime? _modifiedAt;
        private ScheduleConfiguration _scheduleConfiguration;
        private string _triggerMode;
        private string _workflowArn;
        private string _workflowVersion;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the workflow version was created, in ISO 8601 date-time format.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefinitionS3Location. 
        /// <para>
        /// The Amazon S3 location of the workflow definition file for this version.
        /// </para>
        /// </summary>
        public DefinitionS3Location DefinitionS3Location
        {
            get { return this._definitionS3Location; }
            set { this._definitionS3Location = value; }
        }

        // Check to see if DefinitionS3Location property is set
        internal bool IsSetDefinitionS3Location()
        {
            return this._definitionS3Location != null;
        }

        /// <summary>
        /// Gets and sets the property IsLatestVersion. 
        /// <para>
        /// Boolean flag that indicates whether this is the latest version of the workflow.
        /// </para>
        /// </summary>
        public bool IsLatestVersion
        {
            get { return this._isLatestVersion.GetValueOrDefault(); }
            set { this._isLatestVersion = value; }
        }

        // Check to see if IsLatestVersion property is set
        internal bool IsSetIsLatestVersion()
        {
            return this._isLatestVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModifiedAt. 
        /// <para>
        /// The timestamp when the workflow version was last modified, in ISO 8601 date-time format.
        /// </para>
        /// </summary>
        public DateTime ModifiedAt
        {
            get { return this._modifiedAt.GetValueOrDefault(); }
            set { this._modifiedAt = value; }
        }

        // Check to see if ModifiedAt property is set
        internal bool IsSetModifiedAt()
        {
            return this._modifiedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScheduleConfiguration. 
        /// <para>
        /// The schedule configuration for this workflow version.
        /// </para>
        /// </summary>
        public ScheduleConfiguration ScheduleConfiguration
        {
            get { return this._scheduleConfiguration; }
            set { this._scheduleConfiguration = value; }
        }

        // Check to see if ScheduleConfiguration property is set
        internal bool IsSetScheduleConfiguration()
        {
            return this._scheduleConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property TriggerMode. 
        /// <para>
        /// The trigger mode for the workflow execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string TriggerMode
        {
            get { return this._triggerMode; }
            set { this._triggerMode = value; }
        }

        // Check to see if TriggerMode property is set
        internal bool IsSetTriggerMode()
        {
            return this._triggerMode != null;
        }

        /// <summary>
        /// Gets and sets the property WorkflowArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the workflow that contains this version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string WorkflowArn
        {
            get { return this._workflowArn; }
            set { this._workflowArn = value; }
        }

        // Check to see if WorkflowArn property is set
        internal bool IsSetWorkflowArn()
        {
            return this._workflowArn != null;
        }

        /// <summary>
        /// Gets and sets the property WorkflowVersion. 
        /// <para>
        /// The version identifier of the workflow version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=32, Max=32)]
        public string WorkflowVersion
        {
            get { return this._workflowVersion; }
            set { this._workflowVersion = value; }
        }

        // Check to see if WorkflowVersion property is set
        internal bool IsSetWorkflowVersion()
        {
            return this._workflowVersion != null;
        }

    }
}