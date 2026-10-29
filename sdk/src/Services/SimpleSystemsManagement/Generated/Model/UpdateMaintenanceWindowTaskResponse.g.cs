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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// This is the response object from the UpdateMaintenanceWindowTask operation.
    /// </summary>
    public partial class UpdateMaintenanceWindowTaskResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AlarmConfiguration. 
        /// <para>
        /// The details for the CloudWatch alarm you applied to your maintenance window task.
        /// </para>
        /// </summary>
        public AlarmConfiguration AlarmConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AlarmConfiguration property is set.
        /// </summary>
        internal bool IsSetAlarmConfiguration() => this.AlarmConfiguration != null;

        /// <summary>
        /// Gets and sets the property CutoffBehavior. 
        /// <para>
        /// The specification for whether tasks should continue to run after the cutoff time specified
        /// in the maintenance windows is reached. 
        /// </para>
        /// </summary>
        public MaintenanceWindowTaskCutoffBehavior CutoffBehavior { get; set; }

        /// <summary>
        /// Checks to see if the CutoffBehavior property is set.
        /// </summary>
        internal bool IsSetCutoffBehavior() => this.CutoffBehavior != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The updated task description.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 128)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property LoggingInfo. 
        /// <para>
        /// The updated logging information in Amazon S3.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>LoggingInfo</c> has been deprecated. To specify an Amazon Simple Storage Service
        /// (Amazon S3) bucket to contain logs, instead use the <c>OutputS3BucketName</c> and
        /// <c>OutputS3KeyPrefix</c> options in the <c>TaskInvocationParameters</c> structure.
        /// For information about how Amazon Web Services Systems Manager handles these options
        /// for the supported maintenance window task types, see <a>MaintenanceWindowTaskInvocationParameters</a>.
        /// </para>
        ///  </note>
        /// </summary>
        public LoggingInfo LoggingInfo { get; set; }

        /// <summary>
        /// Checks to see if the LoggingInfo property is set.
        /// </summary>
        internal bool IsSetLoggingInfo() => this.LoggingInfo != null;

        /// <summary>
        /// Gets and sets the property MaxConcurrency. 
        /// <para>
        /// The updated <c>MaxConcurrency</c> value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 7)]
        public string MaxConcurrency { get; set; }

        /// <summary>
        /// Checks to see if the MaxConcurrency property is set.
        /// </summary>
        internal bool IsSetMaxConcurrency() => this.MaxConcurrency != null;

        /// <summary>
        /// Gets and sets the property MaxErrors. 
        /// <para>
        /// The updated <c>MaxErrors</c> value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 7)]
        public string MaxErrors { get; set; }

        /// <summary>
        /// Checks to see if the MaxErrors property is set.
        /// </summary>
        internal bool IsSetMaxErrors() => this.MaxErrors != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The updated task name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The updated priority value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? Priority { get; set; }

        /// <summary>
        /// Checks to see if the Priority property is set.
        /// </summary>
        internal bool IsSetPriority() => this.Priority.HasValue;

        /// <summary>
        /// Gets and sets the property ServiceRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM service role for Amazon Web Services Systems
        /// Manager to assume when running a maintenance window task. If you do not specify a
        /// service role ARN, Systems Manager uses a service-linked role in your account. If no
        /// appropriate service-linked role for Systems Manager exists in your account, it is
        /// created when you run <c>RegisterTaskWithMaintenanceWindow</c>.
        /// </para>
        ///  
        /// <para>
        /// However, for an improved security posture, we strongly recommend creating a custom
        /// policy and custom service role for running your maintenance window tasks. The policy
        /// can be crafted to provide only the permissions needed for your particular maintenance
        /// window tasks. For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/sysman-maintenance-permissions.html">Setting
        /// up Maintenance Windows</a> in the in the <i>Amazon Web Services Systems Manager User
        /// Guide</i>.
        /// </para>
        /// </summary>
        public string ServiceRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ServiceRoleArn property is set.
        /// </summary>
        internal bool IsSetServiceRoleArn() => this.ServiceRoleArn != null;

        /// <summary>
        /// Gets and sets the property Targets. 
        /// <para>
        /// The updated target values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<Target> Targets { get; set; } = AWSConfigs.InitializeCollections ? new List<Target>() : null;

        /// <summary>
        /// Checks to see if the Targets property is set.
        /// </summary>
        internal bool IsSetTargets() => this.Targets != null && (this.Targets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TaskArn. 
        /// <para>
        /// The updated task ARN value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1600)]
        public string TaskArn { get; set; }

        /// <summary>
        /// Checks to see if the TaskArn property is set.
        /// </summary>
        internal bool IsSetTaskArn() => this.TaskArn != null;

        /// <summary>
        /// Gets and sets the property TaskInvocationParameters. 
        /// <para>
        /// The updated parameter values.
        /// </para>
        /// </summary>
        public MaintenanceWindowTaskInvocationParameters TaskInvocationParameters { get; set; }

        /// <summary>
        /// Checks to see if the TaskInvocationParameters property is set.
        /// </summary>
        internal bool IsSetTaskInvocationParameters() => this.TaskInvocationParameters != null;

        /// <summary>
        /// Gets and sets the property TaskParameters. 
        /// <para>
        /// The updated parameter values.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>TaskParameters</c> has been deprecated. To specify parameters to pass to a task
        /// when it runs, instead use the <c>Parameters</c> option in the <c>TaskInvocationParameters</c>
        /// structure. For information about how Systems Manager handles these options for the
        /// supported maintenance window task types, see <a>MaintenanceWindowTaskInvocationParameters</a>.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Dictionary<string, MaintenanceWindowTaskParameterValueExpression> TaskParameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, MaintenanceWindowTaskParameterValueExpression>() : null;

        /// <summary>
        /// Checks to see if the TaskParameters property is set.
        /// </summary>
        internal bool IsSetTaskParameters() => this.TaskParameters != null && (this.TaskParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WindowId. 
        /// <para>
        /// The ID of the maintenance window that was updated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 20)]
        public string WindowId { get; set; }

        /// <summary>
        /// Checks to see if the WindowId property is set.
        /// </summary>
        internal bool IsSetWindowId() => this.WindowId != null;

        /// <summary>
        /// Gets and sets the property WindowTaskId. 
        /// <para>
        /// The task ID of the maintenance window that was updated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string WindowTaskId { get; set; }

        /// <summary>
        /// Checks to see if the WindowTaskId property is set.
        /// </summary>
        internal bool IsSetWindowTaskId() => this.WindowTaskId != null;
    }
}
