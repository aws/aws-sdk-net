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
    /// Specifies values used to filter responses when searching for insights. You can use
    /// a <c>ResourceCollection</c>, <c>ServiceCollection</c>, array of severities, and an
    /// array of status values. Each filter type contains one or more values to search for.
    /// If you specify multiple filter types, the filter types are joined with an <c>AND</c>,
    /// and the request returns only results that match all of the specified filters.
    /// </summary>
    public partial class SearchInsightsFilters
    {
        /// <summary>
        /// Gets and sets the property ResourceCollection.
        /// </summary>
        public ResourceCollection ResourceCollection { get; set; }

        /// <summary>
        /// Checks to see if the ResourceCollection property is set.
        /// </summary>
        internal bool IsSetResourceCollection() => this.ResourceCollection != null;

        /// <summary>
        /// Gets and sets the property ServiceCollection. 
        /// <para>
        /// A collection of the names of Amazon Web Services services.
        /// </para>
        /// </summary>
        public ServiceCollection ServiceCollection { get; set; }

        /// <summary>
        /// Checks to see if the ServiceCollection property is set.
        /// </summary>
        internal bool IsSetServiceCollection() => this.ServiceCollection != null;

        /// <summary>
        /// Gets and sets the property Severities. 
        /// <para>
        ///  An array of severity values used to search for insights. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 3)]
        public List<string> Severities { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Severities property is set.
        /// </summary>
        internal bool IsSetSeverities() => this.Severities != null && (this.Severities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Statuses. 
        /// <para>
        ///  An array of status values used to search for insights. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2)]
        public List<string> Statuses { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Statuses property is set.
        /// </summary>
        internal bool IsSetStatuses() => this.Statuses != null && (this.Statuses.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
