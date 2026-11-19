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
    /// The Azure resources to collect telemetry from. These are the resources found by <c>Subscriptions</c>,
    /// <c>Regions</c>, and <c>ResourceTypes</c>, optionally narrowed by <c>TagFilters</c>,
    /// plus any resources listed in <c>Resources</c>. You can specify:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <c>Subscriptions</c>, <c>Regions</c>, and <c>ResourceTypes</c> together
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Resources</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Both
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AzureScope
    {
        /// <summary>
        /// Gets and sets the property Regions. 
        /// <para>
        /// The Azure Regions to find resources in. Required when you use <c>Subscriptions</c>
        /// and <c>ResourceTypes</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<string> Regions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Regions property is set.
        /// </summary>
        internal bool IsSetRegions() => this.Regions != null && (this.Regions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceTypes. 
        /// <para>
        /// The Azure resource types to find. Required when you use <c>Subscriptions</c> and <c>Regions</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<string> ResourceTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ResourceTypes property is set.
        /// </summary>
        internal bool IsSetResourceTypes() => this.ResourceTypes != null && (this.ResourceTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Resources. 
        /// <para>
        /// Specific Azure resources, listed by Azure Region.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<AzureResourceIdScope> Resources { get; set; } = AWSConfigs.InitializeCollections ? new List<AzureResourceIdScope>() : null;

        /// <summary>
        /// Checks to see if the Resources property is set.
        /// </summary>
        internal bool IsSetResources() => this.Resources != null && (this.Resources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Subscriptions. 
        /// <para>
        /// The subscriptions to find resources in: all subscriptions that the connector can read,
        /// or a list of subscriptions. Required when you use <c>Regions</c> and <c>ResourceTypes</c>.
        /// </para>
        /// </summary>
        public AzureSubscriptionScope Subscriptions { get; set; }

        /// <summary>
        /// Checks to see if the Subscriptions property is set.
        /// </summary>
        internal bool IsSetSubscriptions() => this.Subscriptions != null;

        /// <summary>
        /// Gets and sets the property TagFilters. 
        /// <para>
        /// Limits the resources found by <c>Subscriptions</c>, <c>Regions</c>, and <c>ResourceTypes</c>
        /// to those that have these tags. You can specify up to 50 filters.
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
