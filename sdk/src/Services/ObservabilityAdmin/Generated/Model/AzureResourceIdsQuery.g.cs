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

namespace Amazon.ObservabilityAdmin.Model
{
    /// <summary>
    /// A query that lists Azure resources.
    /// </summary>
    public partial class AzureResourceIdsQuery
    {
        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// Limits the results to one Azure Region, for example <c>eastus</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// Limits the results to one Azure resource type, for example <c>Microsoft.Compute/virtualMachines</c>.
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
        /// Limits the query to a management group or to specific subscriptions.
        /// </para>
        /// </summary>
        public AzureQueryScope Scope { get; set; }

        /// <summary>
        /// Checks to see if the Scope property is set.
        /// </summary>
        internal bool IsSetScope() => this.Scope != null;

        /// <summary>
        /// Gets and sets the property TagFilters. 
        /// <para>
        /// Limits the results to resources that have these tags. A resource must match the filters
        /// for all tag keys, and any of the values for each key. The service matches tag keys
        /// and values case-insensitively, as Azure does.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<TagFilter> TagFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<TagFilter>() : null;

        /// <summary>
        /// Checks to see if the TagFilters property is set.
        /// </summary>
        internal bool IsSetTagFilters() => this.TagFilters != null && (this.TagFilters.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
