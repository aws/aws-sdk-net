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

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// An aggregation of information about serverless functions.
    /// </summary>
    public partial class ServerlessFunctionAggregation
    {
        /// <summary>
        /// Gets and sets the property CloudAccountIds. 
        /// <para>
        /// The cloud account IDs to aggregate findings for.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<StringFilter> CloudAccountIds { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the CloudAccountIds property is set.
        /// </summary>
        internal bool IsSetCloudAccountIds() => this.CloudAccountIds != null && (this.CloudAccountIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CloudOrgIds. 
        /// <para>
        /// The cloud organization IDs to aggregate findings for.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<StringFilter> CloudOrgIds { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the CloudOrgIds property is set.
        /// </summary>
        internal bool IsSetCloudOrgIds() => this.CloudOrgIds != null && (this.CloudOrgIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CloudPartitions. 
        /// <para>
        /// The cloud partitions to aggregate findings for. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>aws</c> – Amazon Web Services commercial Regions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>aws-cn</c> – Amazon Web Services China Regions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>aws-us-gov</c> – Amazon Web Services GovCloud (US) Regions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AzureCloud</c> – Azure commercial Regions.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<StringFilter> CloudPartitions { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the CloudPartitions property is set.
        /// </summary>
        internal bool IsSetCloudPartitions() => this.CloudPartitions != null && (this.CloudPartitions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CloudProviders. 
        /// <para>
        /// The cloud providers to aggregate findings for. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AWS</c> – Findings from Amazon Web Services resources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AZURE</c> – Findings from Microsoft Azure resources.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<StringFilter> CloudProviders { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the CloudProviders property is set.
        /// </summary>
        internal bool IsSetCloudProviders() => this.CloudProviders != null && (this.CloudProviders.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CloudRegions. 
        /// <para>
        /// The cloud regions to aggregate findings for. The value format depends on the cloud
        /// provider:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An Amazon Web Services Region, such as <c>us-east-1</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An Azure region, such as <c>eastus</c>.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<StringFilter> CloudRegions { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the CloudRegions property is set.
        /// </summary>
        internal bool IsSetCloudRegions() => this.CloudRegions != null && (this.CloudRegions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FunctionNames. 
        /// <para>
        /// The function names to aggregate findings for.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<StringFilter> FunctionNames { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the FunctionNames property is set.
        /// </summary>
        internal bool IsSetFunctionNames() => this.FunctionNames != null && (this.FunctionNames.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FunctionTags. 
        /// <para>
        /// The function tags to aggregate findings for.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<MapFilter> FunctionTags { get; set; } = AWSConfigs.InitializeCollections ? new List<MapFilter>() : null;

        /// <summary>
        /// Checks to see if the FunctionTags property is set.
        /// </summary>
        internal bool IsSetFunctionTags() => this.FunctionTags != null && (this.FunctionTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceIds. 
        /// <para>
        /// The resource IDs to aggregate findings for.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<StringFilter> ResourceIds { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the ResourceIds property is set.
        /// </summary>
        internal bool IsSetResourceIds() => this.ResourceIds != null && (this.ResourceIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Runtimes. 
        /// <para>
        /// The runtimes to aggregate findings for.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<StringFilter> Runtimes { get; set; } = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Checks to see if the Runtimes property is set.
        /// </summary>
        internal bool IsSetRuntimes() => this.Runtimes != null && (this.Runtimes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// The value to sort results by. Specify a field name from the aggregation response,
        /// such as <c>CRITICAL</c>, <c>HIGH</c>, or <c>ALL</c>.
        /// </para>
        /// </summary>
        public ServerlessFunctionSortBy SortBy { get; set; }

        /// <summary>
        /// Checks to see if the SortBy property is set.
        /// </summary>
        internal bool IsSetSortBy() => this.SortBy != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The order to sort results by. Valid values are <c>ASC</c> and <c>DESC</c>.
        /// </para>
        /// </summary>
        public SortOrder SortOrder { get; set; }

        /// <summary>
        /// Checks to see if the SortOrder property is set.
        /// </summary>
        internal bool IsSetSortOrder() => this.SortOrder != null;
    }
}
