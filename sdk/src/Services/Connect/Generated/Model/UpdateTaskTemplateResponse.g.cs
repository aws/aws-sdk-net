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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// This is the response object from the UpdateTaskTemplate operation.
    /// </summary>
    public partial class UpdateTaskTemplateResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the task template resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Constraints. 
        /// <para>
        /// Constraints that are applicable to the fields listed. Although this parameter is marked
        /// as optional in the API model, the service requires it when calling <c>CreateTaskTemplate</c>
        /// or <c>UpdateTaskTemplate</c>. The <c>RequiredFields</c> array must contain at least
        /// one element, and the field of type <c>NAME</c> must be included in <c>RequiredFields</c>.
        /// </para>
        /// </summary>
        public TaskTemplateConstraints Constraints { get; set; }

        /// <summary>
        /// Checks to see if the Constraints property is set.
        /// </summary>
        internal bool IsSetConstraints() => this.Constraints != null;

        /// <summary>
        /// Gets and sets the property ContactFlowId. 
        /// <para>
        /// The identifier of the flow that runs by default when a task is created by referencing
        /// this template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public string ContactFlowId { get; set; }

        /// <summary>
        /// Checks to see if the ContactFlowId property is set.
        /// </summary>
        internal bool IsSetContactFlowId() => this.ContactFlowId != null;

        /// <summary>
        /// Gets and sets the property ContactHooks. 
        /// <para>
        /// The event hooks that are set on tasks created by using this template.
        /// </para>
        /// </summary>
        public TaskTemplateContactHooks ContactHooks { get; set; }

        /// <summary>
        /// Checks to see if the ContactHooks property is set.
        /// </summary>
        internal bool IsSetContactHooks() => this.ContactHooks != null;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The timestamp when the task template was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Defaults. 
        /// <para>
        /// The default values for fields when a task is created by referencing this template.
        /// </para>
        /// </summary>
        public TaskTemplateDefaults Defaults { get; set; }

        /// <summary>
        /// Checks to see if the Defaults property is set.
        /// </summary>
        internal bool IsSetDefaults() => this.Defaults != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the task template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Fields. 
        /// <para>
        /// Fields that are part of the template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TaskTemplateField> Fields { get; set; } = AWSConfigs.InitializeCollections ? new List<TaskTemplateField>() : null;

        /// <summary>
        /// Checks to see if the Fields property is set.
        /// </summary>
        internal bool IsSetFields() => this.Fields != null && (this.Fields.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the task template resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Connect Customer instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The timestamp when the task template was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the task template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property SelfAssignFlowId. 
        /// <para>
        /// The ContactFlowId for the flow that will be run if this template is used to create
        /// a self-assigned task.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public string SelfAssignFlowId { get; set; }

        /// <summary>
        /// Checks to see if the SelfAssignFlowId property is set.
        /// </summary>
        internal bool IsSetSelfAssignFlowId() => this.SelfAssignFlowId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Marks a template as <c>ACTIVE</c> or <c>INACTIVE</c> for a task to refer to it. Tasks
        /// can only be created from <c>ACTIVE</c> templates. If a template is marked as <c>INACTIVE</c>,
        /// then a task that refers to this template cannot be created.
        /// </para>
        /// </summary>
        public TaskTemplateStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
