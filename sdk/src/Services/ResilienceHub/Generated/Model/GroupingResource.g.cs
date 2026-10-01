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

namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// Indicates the resource that will be grouped in the recommended Application Component
    /// (AppComponent).
    /// </summary>
    public partial class GroupingResource
    {
        /// <summary>
        /// Gets and sets the property LogicalResourceId. 
        /// <para>
        /// Indicates the logical identifier of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LogicalResourceId LogicalResourceId { get; set; }

        /// <summary>
        /// Checks to see if the LogicalResourceId property is set.
        /// </summary>
        internal bool IsSetLogicalResourceId() => this.LogicalResourceId != null;

        /// <summary>
        /// Gets and sets the property PhysicalResourceId. 
        /// <para>
        /// Indicates the physical identifier of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PhysicalResourceId PhysicalResourceId { get; set; }

        /// <summary>
        /// Checks to see if the PhysicalResourceId property is set.
        /// </summary>
        internal bool IsSetPhysicalResourceId() => this.PhysicalResourceId != null;

        /// <summary>
        /// Gets and sets the property ResourceName. 
        /// <para>
        /// Indicates the resource name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string ResourceName { get; set; }

        /// <summary>
        /// Checks to see if the ResourceName property is set.
        /// </summary>
        internal bool IsSetResourceName() => this.ResourceName != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// Indicates the resource type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property SourceAppComponentIds. 
        /// <para>
        /// Indicates the identifier of the source AppComponents in which the resources were previously
        /// grouped into.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> SourceAppComponentIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SourceAppComponentIds property is set.
        /// </summary>
        internal bool IsSetSourceAppComponentIds() => this.SourceAppComponentIds != null && (this.SourceAppComponentIds.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
