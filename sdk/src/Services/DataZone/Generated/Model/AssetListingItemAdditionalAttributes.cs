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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// Additional attributes of an inventory asset.
    /// </summary>
    public partial class AssetListingItemAdditionalAttributes
    {
        private string _forms;
        private List<TimeSeriesDataPointSummaryFormOutput> _latestTimeSeriesDataPointForms = AWSConfigs.InitializeCollections ? new List<TimeSeriesDataPointSummaryFormOutput>() : null;

        /// <summary>
        /// Gets and sets the property Forms. 
        /// <para>
        /// The metadata forms that form additional attributes of the metadata asset.
        /// </para>
        /// </summary>
        public string Forms
        {
            get { return this._forms; }
            set { this._forms = value; }
        }

        // Check to see if Forms property is set
        internal bool IsSetForms()
        {
            return this._forms != null;
        }

        /// <summary>
        /// Gets and sets the property LatestTimeSeriesDataPointForms. 
        /// <para>
        /// The latest time series data points forms included in the additional attributes of
        /// an asset.
        /// </para>
        /// </summary>
        public List<TimeSeriesDataPointSummaryFormOutput> LatestTimeSeriesDataPointForms
        {
            get { return this._latestTimeSeriesDataPointForms; }
            set { this._latestTimeSeriesDataPointForms = value; }
        }

        // Check to see if LatestTimeSeriesDataPointForms property is set
        internal bool IsSetLatestTimeSeriesDataPointForms()
        {
            return this._latestTimeSeriesDataPointForms != null && (this._latestTimeSeriesDataPointForms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}