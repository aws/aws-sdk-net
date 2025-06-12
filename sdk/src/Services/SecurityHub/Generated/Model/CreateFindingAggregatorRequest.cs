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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Container for the parameters to the CreateFindingAggregator operation.
    /// <note> 
    /// <para>
    /// The <i>aggregation Region</i> is now called the <i>home Region</i>.
    /// </para>
    ///  </note> 
    /// <para>
    /// Used to enable cross-Region aggregation. This operation can be invoked from the home
    /// Region only.
    /// </para>
    ///  
    /// <para>
    /// For information about how cross-Region aggregation works, see <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/finding-aggregation.html">Understanding
    /// cross-Region aggregation in Security Hub</a> in the <i>Security Hub User Guide</i>.
    /// 
    /// </para>
    /// </summary>
    public partial class CreateFindingAggregatorRequest : AmazonSecurityHubRequest
    {
        private string _regionLinkingMode;
        private List<string> _regions = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property RegionLinkingMode. 
        /// <para>
        /// Indicates whether to aggregate findings from all of the available Regions in the current
        /// partition. Also determines whether to automatically aggregate findings from new Regions
        /// as Security Hub supports them and you opt into them.
        /// </para>
        ///  
        /// <para>
        /// The selected option also determines how to use the Regions provided in the Regions
        /// list.
        /// </para>
        ///  
        /// <para>
        /// The options are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ALL_REGIONS</c> - Aggregates findings from all of the Regions where Security Hub
        /// is enabled. When you choose this option, Security Hub also automatically aggregates
        /// findings from new Regions as Security Hub supports them and you opt into them. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ALL_REGIONS_EXCEPT_SPECIFIED</c> - Aggregates findings from all of the Regions
        /// where Security Hub is enabled, except for the Regions listed in the <c>Regions</c>
        /// parameter. When you choose this option, Security Hub also automatically aggregates
        /// findings from new Regions as Security Hub supports them and you opt into them. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SPECIFIED_REGIONS</c> - Aggregates findings only from the Regions listed in the
        /// <c>Regions</c> parameter. Security Hub does not automatically aggregate findings from
        /// new Regions. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NO_REGIONS</c> - Aggregates no data because no Regions are selected as linked
        /// Regions. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RegionLinkingMode
        {
            get { return this._regionLinkingMode; }
            set { this._regionLinkingMode = value; }
        }

        // Check to see if RegionLinkingMode property is set
        internal bool IsSetRegionLinkingMode()
        {
            return this._regionLinkingMode != null;
        }

        /// <summary>
        /// Gets and sets the property Regions. 
        /// <para>
        /// If <c>RegionLinkingMode</c> is <c>ALL_REGIONS_EXCEPT_SPECIFIED</c>, then this is a
        /// space-separated list of Regions that don't replicate and send findings to the home
        /// Region.
        /// </para>
        ///  
        /// <para>
        /// If <c>RegionLinkingMode</c> is <c>SPECIFIED_REGIONS</c>, then this is a space-separated
        /// list of Regions that do replicate and send findings to the home Region. 
        /// </para>
        ///  
        /// <para>
        /// An <c>InvalidInputException</c> error results if you populate this field while <c>RegionLinkingMode</c>
        /// is <c>NO_REGIONS</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Regions
        {
            get { return this._regions; }
            set { this._regions = value; }
        }

        // Check to see if Regions property is set
        internal bool IsSetRegions()
        {
            return this._regions != null && (this._regions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}