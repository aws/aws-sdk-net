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

namespace Amazon.MWAAServerless.Model
{
    /// <summary>
    /// This is the response object from the CreateWorkflow operation.
    /// </summary>
    public partial class CreateWorkflowResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the workflow was created, in ISO 8601 date-time format.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property IsLatestVersion. 
        /// <para>
        /// A Boolean flag that indicates whether this workflow version is the latest version
        /// of the workflow.
        /// </para>
        /// </summary>
        public bool? IsLatestVersion { get; set; }

        /// <summary>
        /// Checks to see if the IsLatestVersion property is set.
        /// </summary>
        internal bool IsSetIsLatestVersion() => this.IsLatestVersion.HasValue;

        /// <summary>
        /// Gets and sets the property RevisionId. 
        /// <para>
        /// A unique identifier for this revision of the workflow configuration. This ID changes
        /// when the workflow is updated and you can use it for optimistic concurrency control
        /// in update operations. The revision ID helps prevent conflicting updates and ensures
        /// that updates are applied to the expected version of the workflow configuration.
        /// </para>
        /// </summary>
        public string RevisionId { get; set; }

        /// <summary>
        /// Checks to see if the RevisionId property is set.
        /// </summary>
        internal bool IsSetRevisionId() => this.RevisionId != null;

        /// <summary>
        /// Gets and sets the property Warnings. 
        /// <para>
        /// Warning messages generated during workflow creation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Warnings { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Warnings property is set.
        /// </summary>
        internal bool IsSetWarnings() => this.Warnings != null && (this.Warnings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WorkflowArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the newly created workflow. This ARN uniquely identifies
        /// the workflow resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string WorkflowArn { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowArn property is set.
        /// </summary>
        internal bool IsSetWorkflowArn() => this.WorkflowArn != null;

        /// <summary>
        /// Gets and sets the property WorkflowStatus. 
        /// <para>
        /// The current status of the workflow. Possible values are <c>READY</c> (workflow is
        /// ready to run) and <c>DELETING</c> (workflow is being deleted).
        /// </para>
        /// </summary>
        public WorkflowStatus WorkflowStatus { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowStatus property is set.
        /// </summary>
        internal bool IsSetWorkflowStatus() => this.WorkflowStatus != null;

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
        [AWSProperty(Min = 32, Max = 32)]
        public string WorkflowVersion { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowVersion property is set.
        /// </summary>
        internal bool IsSetWorkflowVersion() => this.WorkflowVersion != null;
    }
}
