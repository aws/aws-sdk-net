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

namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// Filters to determine which monitored resources you want to retrieve. You can filter
    /// by resource type or resource permission status.
    /// </summary>
    public partial class ListMonitoredResourcesFilters
    {
        /// <summary>
        /// Gets and sets the property ResourcePermission. 
        /// <para>
        ///  The permission status of a resource. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ResourcePermission ResourcePermission { get; set; }

        /// <summary>
        /// Checks to see if the ResourcePermission property is set.
        /// </summary>
        internal bool IsSetResourcePermission() => this.ResourcePermission != null;

        /// <summary>
        /// Gets and sets the property ResourceTypeFilters. 
        /// <para>
        ///  The type of resource that you wish to retrieve, such as log groups. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> ResourceTypeFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ResourceTypeFilters property is set.
        /// </summary>
        internal bool IsSetResourceTypeFilters() => this.ResourceTypeFilters != null && (this.ResourceTypeFilters.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
