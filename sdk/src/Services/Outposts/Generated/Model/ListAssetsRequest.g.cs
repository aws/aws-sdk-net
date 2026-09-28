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

namespace Amazon.Outposts.Model
{
    /// <summary>
    /// Container for the parameters to the ListAssets operation. Lists the hardware assets
    /// for the specified Outpost. <para> Use filters to return specific results. If you specify
    /// multiple filters, the results include only the resources that match all of the specified
    /// filters. For a filter where you can specify multiple values, the results include items
    /// that match any of the values that you specify for the filter. </para>
    /// </summary>
    public partial class ListAssetsRequest : AmazonOutpostsRequest
    {
        /// <summary>
        /// Gets and sets the property AssetTypeFilter. 
        /// <para>
        /// Filters the results by asset type.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// COMPUTE - Server asset used for customer compute 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// STORAGE - Server asset used by storage services 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POWERSHELF - Powershelf assets 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SWITCH - Switch assets 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// NETWORKING - Asset managed by Amazon Web Services for networking purposes 
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<string> AssetTypeFilter { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AssetTypeFilter property is set.
        /// </summary>
        internal bool IsSetAssetTypeFilter() => this.AssetTypeFilter != null && (this.AssetTypeFilter.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property HostIdFilter. 
        /// <para>
        /// Filters the results by the host ID of a Dedicated Host.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> HostIdFilter { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the HostIdFilter property is set.
        /// </summary>
        internal bool IsSetHostIdFilter() => this.HostIdFilter != null && (this.HostIdFilter.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxResults.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property OutpostIdentifier. 
        /// <para>
        ///  The ID or the Amazon Resource Name (ARN) of the Outpost. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 180)]
        public string OutpostIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the OutpostIdentifier property is set.
        /// </summary>
        internal bool IsSetOutpostIdentifier() => this.OutpostIdentifier != null;

        /// <summary>
        /// Gets and sets the property StatusFilter. 
        /// <para>
        /// Filters the results by state.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<string> StatusFilter { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the StatusFilter property is set.
        /// </summary>
        internal bool IsSetStatusFilter() => this.StatusFilter != null && (this.StatusFilter.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
