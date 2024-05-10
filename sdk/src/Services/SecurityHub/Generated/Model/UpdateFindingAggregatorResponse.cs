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
    /// This is the response object from the UpdateFindingAggregator operation.
    /// </summary>
    public partial class UpdateFindingAggregatorResponse : AmazonWebServiceResponse
    {
        private string _findingAggregationRegion;
        private string _findingAggregatorArn;
        private string _regionLinkingMode;
        private List<string> _regions = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property FindingAggregationRegion. 
        /// <para>
        /// The aggregation Region.
        /// </para>
        /// </summary>
        public string FindingAggregationRegion
        {
            get { return this._findingAggregationRegion; }
            set { this._findingAggregationRegion = value; }
        }

        // Check to see if FindingAggregationRegion property is set
        internal bool IsSetFindingAggregationRegion()
        {
            return this._findingAggregationRegion != null;
        }

        /// <summary>
        /// Gets and sets the property FindingAggregatorArn. 
        /// <para>
        /// The ARN of the finding aggregator.
        /// </para>
        /// </summary>
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
        /// Indicates whether to link all Regions, all Regions except for a list of excluded Regions,
        /// or a list of included Regions.
        /// </para>
        /// </summary>
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
        /// The list of excluded Regions or included Regions.
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
            return this._regions != null && (this._regions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}