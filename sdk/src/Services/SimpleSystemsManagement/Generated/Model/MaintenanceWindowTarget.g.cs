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
    /// The target registered with the maintenance window.
    /// </summary>
    public partial class MaintenanceWindowTarget
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the target.
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
        /// The name for the maintenance window target.
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
        /// A user-provided value that will be included in any Amazon CloudWatch Events events
        /// that are raised while running tasks for these targets in this maintenance window.
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
        /// The type of target that is being registered with the maintenance window.
        /// </para>
        /// </summary>
        public MaintenanceWindowResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property Targets. 
        /// <para>
        /// The targets, either managed nodes or tags.
        /// </para>
        ///  
        /// <para>
        /// Specify managed nodes using the following format:
        /// </para>
        ///  
        /// <para>
        ///  <c>Key=instanceids,Values=&lt;instanceid1&gt;,&lt;instanceid2&gt;</c> 
        /// </para>
        ///  
        /// <para>
        /// Tags are specified using the following format:
        /// </para>
        ///  
        /// <para>
        ///  <c>Key=&lt;tag name&gt;,Values=&lt;tag value&gt;</c>.
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
        /// Gets and sets the property WindowId. 
        /// <para>
        /// The ID of the maintenance window to register the target with.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 20)]
        public string WindowId { get; set; }

        /// <summary>
        /// Checks to see if the WindowId property is set.
        /// </summary>
        internal bool IsSetWindowId() => this.WindowId != null;

        /// <summary>
        /// Gets and sets the property WindowTargetId. 
        /// <para>
        /// The ID of the target.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string WindowTargetId { get; set; }

        /// <summary>
        /// Checks to see if the WindowTargetId property is set.
        /// </summary>
        internal bool IsSetWindowTargetId() => this.WindowTargetId != null;
    }
}
