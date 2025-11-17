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
    /// This is the response object from the CreateWorkflow operation.
    /// </summary>
    public partial class CreateWorkflowResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdAt;
        private bool? _isLatestVersion;
        private string _revisionId;
        private List<string> _warnings = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _workflowArn;
        private WorkflowStatus _workflowStatus;
        private string _workflowVersion;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the workflow was created, in ISO 8601 date-time format.
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
        /// Gets and sets the property IsLatestVersion. 
        /// <para>
        /// A Boolean flag that indicates whether this workflow version is the latest version
        /// of the workflow.
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
        /// Gets and sets the property RevisionId. 
        /// <para>
        /// A unique identifier for this revision of the workflow configuration. This ID changes
        /// when the workflow is updated and you can use it for optimistic concurrency control
        /// in update operations. The revision ID helps prevent conflicting updates and ensures
        /// that updates are applied to the expected version of the workflow configuration.
        /// </para>
        /// </summary>
        public string RevisionId
        {
            get { return this._revisionId; }
            set { this._revisionId = value; }
        }

        // Check to see if RevisionId property is set
        internal bool IsSetRevisionId()
        {
            return this._revisionId != null;
        }

        /// <summary>
        /// Gets and sets the property Warnings. 
        /// <para>
        /// Warning messages generated during workflow creation.
        /// </para>
        /// </summary>
        public List<string> Warnings
        {
            get { return this._warnings; }
            set { this._warnings = value; }
        }

        // Check to see if Warnings property is set
        internal bool IsSetWarnings()
        {
            return this._warnings != null && (this._warnings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WorkflowArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the newly created workflow. This ARN uniquely identifies
        /// the workflow resource.
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
        /// Gets and sets the property WorkflowStatus. 
        /// <para>
        /// The current status of the workflow. Possible values are <c>READY</c> (workflow is
        /// ready to run) and <c>DELETING</c> (workflow is being deleted).
        /// </para>
        /// </summary>
        public WorkflowStatus WorkflowStatus
        {
            get { return this._workflowStatus; }
            set { this._workflowStatus = value; }
        }

        // Check to see if WorkflowStatus property is set
        internal bool IsSetWorkflowStatus()
        {
            return this._workflowStatus != null;
        }

        /// <summary>
        /// Gets and sets the property WorkflowVersion. 
        /// <para>
        /// The version identifier of the workflow. This is a service-generated alphanumeric string
        /// that uniquely identifies this version of the workflow. Amazon Managed Workflows for
        /// Apache Airflow Serverless uses a version-first approach where each workflow can have
        /// multiple immutable versions, which allows you to maintain different configurations
        /// and roll back to previous versions as needed. The version identifier is used in ARNs
        /// and API operations to reference specific workflow versions.
        /// </para>
        /// </summary>
        [AWSProperty(Min=32, Max=32)]
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