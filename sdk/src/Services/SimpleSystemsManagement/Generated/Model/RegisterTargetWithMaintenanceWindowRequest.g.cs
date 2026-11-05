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
    /// Container for the parameters to the RegisterTargetWithMaintenanceWindow operation.
    /// Registers a target with a maintenance window.
    /// </summary>
    public partial class RegisterTargetWithMaintenanceWindowRequest : AmazonSimpleSystemsManagementRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// User-provided idempotency token.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description for the target.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 128)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// An optional name for the target.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OwnerInformation. 
        /// <para>
        /// User-provided value that will be included in any Amazon CloudWatch Events events raised
        /// while running tasks for these targets in this maintenance window.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 128)]
        public string OwnerInformation { get; set; }

        /// <summary>
        /// Checks to see if the OwnerInformation property is set.
        /// </summary>
        internal bool IsSetOwnerInformation() => this.OwnerInformation != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of target being registered with the maintenance window.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MaintenanceWindowResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property Targets. 
        /// <para>
        /// The targets to register with the maintenance window. In other words, the managed nodes
        /// to run commands on when the maintenance window runs.
        /// </para>
        ///  <note> 
        /// <para>
        /// If a single maintenance window task is registered with multiple targets, its task
        /// invocations occur sequentially and not in parallel. If your task must run on multiple
        /// targets at the same time, register a task for each target individually and assign
        /// each task the same priority level.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can specify targets using managed node IDs, resource group names, or tags that
        /// have been applied to managed nodes.
        /// </para>
        ///  
        /// <para>
        ///  <b>Example 1</b>: Specify managed node IDs
        /// </para>
        ///  
        /// <para>
        ///  <c>Key=InstanceIds,Values=&lt;instance-id-1&gt;,&lt;instance-id-2&gt;,&lt;instance-id-3&gt;</c>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <b>Example 2</b>: Use tag key-pairs applied to managed nodes
        /// </para>
        ///  
        /// <para>
        ///  <c>Key=tag:&lt;my-tag-key&gt;,Values=&lt;my-tag-value-1&gt;,&lt;my-tag-value-2&gt;</c>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <b>Example 3</b>: Use tag-keys applied to managed nodes
        /// </para>
        ///  
        /// <para>
        ///  <c>Key=tag-key,Values=&lt;my-tag-key-1&gt;,&lt;my-tag-key-2&gt;</c> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Example 4</b>: Use resource group names
        /// </para>
        ///  
        /// <para>
        ///  <c>Key=resource-groups:Name,Values=&lt;resource-group-name&gt;</c> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Example 5</b>: Use filters for resource group types
        /// </para>
        ///  
        /// <para>
        ///  <c>Key=resource-groups:ResourceTypeFilters,Values=&lt;resource-type-1&gt;,&lt;resource-type-2&gt;</c>
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// For <c>Key=resource-groups:ResourceTypeFilters</c>, specify resource types in the
        /// following format
        /// </para>
        ///  
        /// <para>
        ///  <c>Key=resource-groups:ResourceTypeFilters,Values=AWS::EC2::INSTANCE,AWS::EC2::VPC</c>
        /// 
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information about these examples formats, including the best use case for
        /// each one, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/mw-cli-tutorial-targets-examples.html">Examples:
        /// Register targets with a maintenance window</a> in the <i>Amazon Web Services Systems
        /// Manager User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 5)]
        public List<Target> Targets { get; set; } = AWSConfigs.InitializeCollections ? new List<Target>() : null;

        /// <summary>
        /// Checks to see if the Targets property is set.
        /// </summary>
        internal bool IsSetTargets() => this.Targets != null && (this.Targets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WindowId. 
        /// <para>
        /// The ID of the maintenance window the target should be registered with.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 20)]
        public string WindowId { get; set; }

        /// <summary>
        /// Checks to see if the WindowId property is set.
        /// </summary>
        internal bool IsSetWindowId() => this.WindowId != null;
    }
}
