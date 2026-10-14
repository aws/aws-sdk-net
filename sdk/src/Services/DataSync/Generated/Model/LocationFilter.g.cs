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

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// Narrow down the list of resources returned by <c>ListLocations</c>. For example, to
    /// see all your Amazon S3 locations, create a filter using <c>"Name": "LocationType"</c>,
    /// <c>"Operator": "Equals"</c>, and <c>"Values": "S3"</c>.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/query-resources.html">filtering
    /// resources</a>.
    /// </para>
    /// </summary>
    public partial class LocationFilter
    {
        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the filter being used. Each API call supports a list of filters that are
        /// available for it (for example, <c>LocationType</c> for <c>ListLocations</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LocationFilterName Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// The operator that is used to compare filter values (for example, <c>Equals</c> or
        /// <c>Contains</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Operator Operator { get; set; }

        /// <summary>
        /// Checks to see if the Operator property is set.
        /// </summary>
        internal bool IsSetOperator() => this.Operator != null;

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The values that you want to filter for. For example, you might want to display only
        /// Amazon S3 locations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> Values { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Values property is set.
        /// </summary>
        internal bool IsSetValues() => this.Values != null && (this.Values.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
