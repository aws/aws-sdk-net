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

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// Information about a resource change that will occur when a plan is executed.
    /// </summary>
    public partial class ResourceChange
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The change action.
        /// </para>
        /// </summary>
        public ChangeAction Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property Details. 
        /// <para>
        /// Information about the resource changes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResourceChangeDetail> Details { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceChangeDetail>() : null;

        /// <summary>
        /// Checks to see if the Details property is set.
        /// </summary>
        internal bool IsSetDetails() => this.Details != null && (this.Details.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LogicalResourceId. 
        /// <para>
        /// The ID of the resource, as defined in the CloudFormation template.
        /// </para>
        /// </summary>
        public string LogicalResourceId { get; set; }

        /// <summary>
        /// Checks to see if the LogicalResourceId property is set.
        /// </summary>
        internal bool IsSetLogicalResourceId() => this.LogicalResourceId != null;

        /// <summary>
        /// Gets and sets the property PhysicalResourceId. 
        /// <para>
        /// The ID of the resource, if it was already created.
        /// </para>
        /// </summary>
        public string PhysicalResourceId { get; set; }

        /// <summary>
        /// Checks to see if the PhysicalResourceId property is set.
        /// </summary>
        internal bool IsSetPhysicalResourceId() => this.PhysicalResourceId != null;

        /// <summary>
        /// Gets and sets the property Replacement. 
        /// <para>
        /// If the change type is <c>Modify</c>, indicates whether the existing resource is deleted
        /// and replaced with a new one.
        /// </para>
        /// </summary>
        public Replacement Replacement { get; set; }

        /// <summary>
        /// Checks to see if the Replacement property is set.
        /// </summary>
        internal bool IsSetReplacement() => this.Replacement != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// The change scope.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Scope { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Scope property is set.
        /// </summary>
        internal bool IsSetScope() => this.Scope != null && (this.Scope.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
