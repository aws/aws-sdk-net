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
    /// Container for the parameters to the UpdateAggregatorV2 operation.
    /// Udpates the configuration for the Aggregator V2. This API is in private preview and
    /// subject to change.
    /// </summary>
    public partial class UpdateAggregatorV2Request : AmazonSecurityHubRequest
    {
        private string _aggregatorV2Arn;
        private List<string> _linkedRegions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _regionLinkingMode;

        /// <summary>
        /// Gets and sets the property AggregatorV2Arn. 
        /// <para>
        /// The ARN of the Aggregator V2.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AggregatorV2Arn
        {
            get { return this._aggregatorV2Arn; }
            set { this._aggregatorV2Arn = value; }
        }

        // Check to see if AggregatorV2Arn property is set
        internal bool IsSetAggregatorV2Arn()
        {
            return this._aggregatorV2Arn != null;
        }

        /// <summary>
        /// Gets and sets the property LinkedRegions. 
        /// <para>
        /// A list of Amazon Web Services Regions linked to the aggegation Region.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> LinkedRegions
        {
            get { return this._linkedRegions; }
            set { this._linkedRegions = value; }
        }

        // Check to see if LinkedRegions property is set
        internal bool IsSetLinkedRegions()
        {
            return this._linkedRegions != null && (this._linkedRegions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RegionLinkingMode. 
        /// <para>
        /// Determines how Amazon Web Services Regions should be linked to the Aggregator V2.
        /// </para>
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

    }
}