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
    /// Details about a dimension that contributed to an anomaly.
    /// </summary>
    public partial class DimensionContribution
    {
        private string _dimensionName;
        private List<DimensionValueContribution> _dimensionValueContributionList = AWSConfigs.InitializeCollections ? new List<DimensionValueContribution>() : null;

        /// <summary>
        /// Gets and sets the property DimensionName. 
        /// <para>
        /// The name of the dimension.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string DimensionName
        {
            get { return this._dimensionName; }
            set { this._dimensionName = value; }
        }

        // Check to see if DimensionName property is set
        internal bool IsSetDimensionName()
        {
            return this._dimensionName != null;
        }

        /// <summary>
        /// Gets and sets the property DimensionValueContributionList. 
        /// <para>
        /// A list of dimension values that contributed to the anomaly.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DimensionValueContribution> DimensionValueContributionList
        {
            get { return this._dimensionValueContributionList; }
            set { this._dimensionValueContributionList = value; }
        }

        // Check to see if DimensionValueContributionList property is set
        internal bool IsSetDimensionValueContributionList()
        {
            return this._dimensionValueContributionList != null && (this._dimensionValueContributionList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}