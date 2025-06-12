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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
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
namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Container for the parameters to the GetApproximateUsageRecords operation.
    /// Retrieves estimated usage records for hourly granularity or resource-level data at
    /// daily granularity.
    /// </summary>
    public partial class GetApproximateUsageRecordsRequest : AmazonCostExplorerRequest
    {
        private ApproximationDimension _approximationDimension;
        private Granularity _granularity;
        private List<string> _services = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ApproximationDimension. 
        /// <para>
        /// The service to evaluate for the usage records. You can choose resource-level data
        /// at daily granularity, or hourly granularity with or without resource-level data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ApproximationDimension ApproximationDimension
        {
            get { return this._approximationDimension; }
            set { this._approximationDimension = value; }
        }

        // Check to see if ApproximationDimension property is set
        internal bool IsSetApproximationDimension()
        {
            return this._approximationDimension != null;
        }

        /// <summary>
        /// Gets and sets the property Granularity. 
        /// <para>
        /// How granular you want the data to be. You can enable data at hourly or daily granularity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Granularity Granularity
        {
            get { return this._granularity; }
            set { this._granularity = value; }
        }

        // Check to see if Granularity property is set
        internal bool IsSetGranularity()
        {
            return this._granularity != null;
        }

        /// <summary>
        /// Gets and sets the property Services. 
        /// <para>
        /// The service metadata for the service or services you want to query. If not specified,
        /// all elements are returned.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Services
        {
            get { return this._services; }
            set { this._services = value; }
        }

        // Check to see if Services property is set
        internal bool IsSetServices()
        {
            return this._services != null && (this._services.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}