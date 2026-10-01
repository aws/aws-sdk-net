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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Container for the parameters to the ListAssetModels operation. Retrieves a paginated
    /// list of summaries of all asset models.
    /// </summary>
    public partial class ListAssetModelsRequest : AmazonIoTSiteWiseRequest
    {
        /// <summary>
        /// Gets and sets the property AssetModelTypes. 
        /// <para>
        /// The type of asset model. If you don't provide an <c>assetModelTypes</c>, all types
        /// of asset models are returned.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>ASSET_MODEL</b> – An asset model that you can use to create assets. Can't be included
        /// as a component in another asset model.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>COMPONENT_MODEL</b> – A reusable component that you can include in the composite
        /// models of other asset models. You can't create assets directly from this type of asset
        /// model. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>INTERFACE</b> – An interface is a type of model that defines a standard structure
        /// that can be applied to different asset models.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AssetModelTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AssetModelTypes property is set.
        /// </summary>
        internal bool IsSetAssetModelTypes() => this.AssetModelTypes != null && (this.AssetModelTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AssetModelVersion. 
        /// <para>
        /// The version alias that specifies the latest or active version of the asset model.
        /// The details are returned in the response. The default value is <c>LATEST</c>. See
        /// <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/model-active-version.html">
        /// Asset model versions</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </summary>
        public string AssetModelVersion { get; set; }

        /// <summary>
        /// Checks to see if the AssetModelVersion property is set.
        /// </summary>
        internal bool IsSetAssetModelVersion() => this.AssetModelVersion != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return for each paginated request.
        /// </para>
        ///  
        /// <para>
        /// Default: 50
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 250)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to be used for the next set of paginated results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
