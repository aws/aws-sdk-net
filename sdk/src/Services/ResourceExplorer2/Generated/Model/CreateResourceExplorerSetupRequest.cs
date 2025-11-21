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
 * Do not modify this file. This file is generated from the resource-explorer-2-2022-07-28.normal.json service model.
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
namespace Amazon.ResourceExplorer2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateResourceExplorerSetup operation.
    /// Creates a Resource Explorer setup configuration across multiple Amazon Web Services
    /// Regions. This operation sets up indexes and views in the specified Regions. This operation
    /// can also be used to set an aggregator Region for cross-Region resource search.
    /// </summary>
    public partial class CreateResourceExplorerSetupRequest : AmazonResourceExplorer2Request
    {
        private List<string> _aggregatorRegions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _regionList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _viewName;

        /// <summary>
        /// Gets and sets the property AggregatorRegions. 
        /// <para>
        /// A list of Amazon Web Services Regions that should be configured as aggregator Regions.
        /// Aggregator Regions receive replicated index information from all other Regions where
        /// there is a user-owned index.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<string> AggregatorRegions
        {
            get { return this._aggregatorRegions; }
            set { this._aggregatorRegions = value; }
        }

        // Check to see if AggregatorRegions property is set
        internal bool IsSetAggregatorRegions()
        {
            return this._aggregatorRegions != null && (this._aggregatorRegions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RegionList. 
        /// <para>
        /// A list of Amazon Web Services Regions where Resource Explorer should be configured.
        /// Each Region in the list will have a user-owned index created.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<string> RegionList
        {
            get { return this._regionList; }
            set { this._regionList = value; }
        }

        // Check to see if RegionList property is set
        internal bool IsSetRegionList()
        {
            return this._regionList != null && (this._regionList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ViewName. 
        /// <para>
        /// The name for the view to be created as part of the Resource Explorer setup. The view
        /// name must be unique within the Amazon Web Services account and Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ViewName
        {
            get { return this._viewName; }
            set { this._viewName = value; }
        }

        // Check to see if ViewName property is set
        internal bool IsSetViewName()
        {
            return this._viewName != null;
        }

    }
}