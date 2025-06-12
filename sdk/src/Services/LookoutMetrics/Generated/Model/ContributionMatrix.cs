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
 * Do not modify this file. This file is generated from the lookoutmetrics-2017-07-25.normal.json service model.
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
namespace Amazon.LookoutMetrics.Model
{
    /// <summary>
    /// Details about dimensions that contributed to an anomaly.
    /// </summary>
    public partial class ContributionMatrix
    {
        private List<DimensionContribution> _dimensionContributionList = AWSConfigs.InitializeCollections ? new List<DimensionContribution>() : null;

        /// <summary>
        /// Gets and sets the property DimensionContributionList. 
        /// <para>
        /// A list of contributing dimensions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DimensionContribution> DimensionContributionList
        {
            get { return this._dimensionContributionList; }
            set { this._dimensionContributionList = value; }
        }

        // Check to see if DimensionContributionList property is set
        internal bool IsSetDimensionContributionList()
        {
            return this._dimensionContributionList != null && (this._dimensionContributionList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}