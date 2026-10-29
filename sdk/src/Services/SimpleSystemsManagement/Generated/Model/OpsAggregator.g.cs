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
    /// One or more aggregators for viewing counts of OpsData using different dimensions such
    /// as <c>Source</c>, <c>CreatedTime</c>, or <c>Source and CreatedTime</c>, to name a
    /// few.
    /// </summary>
    public partial class OpsAggregator
    {
        /// <summary>
        /// Gets and sets the property AggregatorType. 
        /// <para>
        /// Either a <c>Range</c> or <c>Count</c> aggregator for limiting an OpsData summary.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public string AggregatorType { get; set; }

        /// <summary>
        /// Checks to see if the AggregatorType property is set.
        /// </summary>
        internal bool IsSetAggregatorType() => this.AggregatorType != null;

        /// <summary>
        /// Gets and sets the property Aggregators. 
        /// <para>
        /// A nested aggregator for viewing counts of OpsData.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 12)]
        public List<OpsAggregator> Aggregators { get; set; } = AWSConfigs.InitializeCollections ? new List<OpsAggregator>() : null;

        /// <summary>
        /// Checks to see if the Aggregators property is set.
        /// </summary>
        internal bool IsSetAggregators() => this.Aggregators != null && (this.Aggregators.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AttributeName. 
        /// <para>
        /// The name of an OpsData attribute on which to limit the count of OpsData.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string AttributeName { get; set; }

        /// <summary>
        /// Checks to see if the AttributeName property is set.
        /// </summary>
        internal bool IsSetAttributeName() => this.AttributeName != null;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The aggregator filters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<OpsFilter> Filters { get; set; } = AWSConfigs.InitializeCollections ? new List<OpsFilter>() : null;

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null && (this.Filters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TypeName. 
        /// <para>
        /// The data type name to use for viewing counts of OpsData.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string TypeName { get; set; }

        /// <summary>
        /// Checks to see if the TypeName property is set.
        /// </summary>
        internal bool IsSetTypeName() => this.TypeName != null;

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The aggregator value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public Dictionary<string, string> Values { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Values property is set.
        /// </summary>
        internal bool IsSetValues() => this.Values != null && (this.Values.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
