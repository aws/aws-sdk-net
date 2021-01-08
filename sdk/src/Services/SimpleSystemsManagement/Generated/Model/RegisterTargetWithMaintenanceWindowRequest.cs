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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterTargetWithMaintenanceWindow operation.
    /// Registers a target with a maintenance window.
    /// </summary>
    public partial class RegisterTargetWithMaintenanceWindowRequest : AmazonSimpleSystemsManagementRequest
    {
        private string _clientToken;
        private string _description;
        private string _name;
        private string _ownerInformation;
        private MaintenanceWindowResourceType _resourceType;
        private List<Target> _targets = new List<Target>();
        private string _windowId;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// User-provided idempotency token.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description for the target.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// An optional name for the target.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=128)]
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
        /// Gets and sets the property OwnerInformation. 
        /// <para>
        /// User-provided value that will be included in any CloudWatch events raised while running
        /// tasks for these targets in this maintenance window.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string OwnerInformation
        {
            get { return this._ownerInformation; }
            set { this._ownerInformation = value; }
        }

        // Check to see if OwnerInformation property is set
        internal bool IsSetOwnerInformation()
        {
            return this._ownerInformation != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of target being registered with the maintenance window.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MaintenanceWindowResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property Targets. 
        /// <para>
        /// The targets to register with the maintenance window. In other words, the instances
        /// to run commands on when the maintenance window runs.
        /// </para>
        ///  
        /// <para>
        /// You can specify targets using instance IDs, resource group names, or tags that have
        /// been applied to instances.
        /// </para>
        ///  
        /// <para>
        ///  <b>Example 1</b>: Specify instance IDs
        /// </para>
        ///  
        /// <para>
        ///  <code>Key=InstanceIds,Values=<i>instance-id-1</i>,<i>instance-id-2</i>,<i>instance-id-3</i>
        /// </code> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Example 2</b>: Use tag key-pairs applied to instances
        /// </para>
        ///  
        /// <para>
        ///  <code>Key=tag:<i>my-tag-key</i>,Values=<i>my-tag-value-1</i>,<i>my-tag-value-2</i>
        /// </code> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Example 3</b>: Use tag-keys applied to instances
        /// </para>
        ///  
        /// <para>
        ///  <code>Key=tag-key,Values=<i>my-tag-key-1</i>,<i>my-tag-key-2</i> </code> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Example 4</b>: Use resource group names
        /// </para>
        ///  
        /// <para>
        ///  <code>Key=resource-groups:Name,Values=<i>resource-group-name</i> </code> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Example 5</b>: Use filters for resource group types
        /// </para>
        ///  
        /// <para>
        ///  <code>Key=resource-groups:ResourceTypeFilters,Values=<i>resource-type-1</i>,<i>resource-type-2</i>
        /// </code> 
        /// </para>
        ///  <note> 
        /// <para>
        /// For <code>Key=resource-groups:ResourceTypeFilters</code>, specify resource types in
        /// the following format
        /// </para>
        ///  
        /// <para>
        ///  <code>Key=resource-groups:ResourceTypeFilters,Values=<i>AWS::EC2::INSTANCE</i>,<i>AWS::EC2::VPC</i>
        /// </code> 
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information about these examples formats, including the best use case for
        /// each one, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/mw-cli-tutorial-targets-examples.html">Examples:
        /// Register targets with a maintenance window</a> in the <i>AWS Systems Manager User
        /// Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=5)]
        public List<Target> Targets
        {
            get { return this._targets; }
            set { this._targets = value; }
        }

        // Check to see if Targets property is set
        internal bool IsSetTargets()
        {
            return this._targets != null && this._targets.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property WindowId. 
        /// <para>
        /// The ID of the maintenance window the target should be registered with.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=20)]
        public string WindowId
        {
            get { return this._windowId; }
            set { this._windowId = value; }
        }

        // Check to see if WindowId property is set
        internal bool IsSetWindowId()
        {
            return this._windowId != null;
        }

    }
}