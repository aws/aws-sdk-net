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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateFindingAggregator operation.
    /// Updates the finding aggregation configuration. Used to update the Region linking mode
    /// and the list of included or excluded Regions. You cannot use <code>UpdateFindingAggregator</code>
    /// to change the aggregation Region.
    /// 
    ///  
    /// <para>
    /// You must run <code>UpdateFindingAggregator</code> from the current aggregation Region.
    /// 
    /// </para>
    /// </summary>
    public partial class UpdateFindingAggregatorRequest : AmazonSecurityHubRequest
    {
        private string _findingAggregatorArn;
        private string _regionLinkingMode;
        private List<string> _regions = new List<string>();

        /// <summary>
        /// Gets and sets the property FindingAggregatorArn. 
        /// <para>
        /// The ARN of the finding aggregator. To obtain the ARN, use <code>ListFindingAggregators</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FindingAggregatorArn
        {
            get { return this._findingAggregatorArn; }
            set { this._findingAggregatorArn = value; }
        }

        // Check to see if FindingAggregatorArn property is set
        internal bool IsSetFindingAggregatorArn()
        {
            return this._findingAggregatorArn != null;
        }

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
        ///  <code>ALL_REGIONS</code> - Indicates to aggregate findings from all of the Regions
        /// where Security Hub is enabled. When you choose this option, Security Hub also automatically
        /// aggregates findings from new Regions as Security Hub supports them and you opt into
        /// them. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ALL_REGIONS_EXCEPT_SPECIFIED</code> - Indicates to aggregate findings from
        /// all of the Regions where Security Hub is enabled, except for the Regions listed in
        /// the <code>Regions</code> parameter. When you choose this option, Security Hub also
        /// automatically aggregates findings from new Regions as Security Hub supports them and
        /// you opt into them. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SPECIFIED_REGIONS</code> - Indicates to aggregate findings only from the Regions
        /// listed in the <code>Regions</code> parameter. Security Hub does not automatically
        /// aggregate findings from new Regions. 
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
        /// If <code>RegionLinkingMode</code> is <code>ALL_REGIONS_EXCEPT_SPECIFIED</code>, then
        /// this is a space-separated list of Regions that do not aggregate findings to the aggregation
        /// Region.
        /// </para>
        ///  
        /// <para>
        /// If <code>RegionLinkingMode</code> is <code>SPECIFIED_REGIONS</code>, then this is
        /// a space-separated list of Regions that do aggregate findings to the aggregation Region.
        /// </para>
        /// </summary>
        public List<string> Regions
        {
            get { return this._regions; }
            set { this._regions = value; }
        }

        // Check to see if Regions property is set
        internal bool IsSetRegions()
        {
            return this._regions != null && this._regions.Count > 0; 
        }

    }
}