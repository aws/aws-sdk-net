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
    /// Container for the parameters to the GetAssetPropertyAggregates operation. Gets aggregated
    /// values for an asset property. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/query-industrial-data.html#aggregates">Querying
    /// aggregates</a> in the <i>IoT SiteWise User Guide</i>. <para> To identify an asset
    /// property, you must specify one of the following: </para> <ul> <li> <para> The <c>assetId</c>
    /// and <c>propertyId</c> of an asset property. </para> </li> <li> <para> A <c>propertyAlias</c>,
    /// which is a data stream alias (for example, <c>/company/windfarm/3/turbine/7/temperature</c>).
    /// To define an asset property's alias, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_UpdateAssetProperty.html">UpdateAssetProperty</a>.
    /// </para> </li> </ul>
    /// </summary>
    public partial class GetAssetPropertyAggregatesRequest : AmazonIoTSiteWiseRequest
    {
        /// <summary>
        /// Gets and sets the property AggregateTypes. 
        /// <para>
        /// The data aggregating function.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public List<string> AggregateTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AggregateTypes property is set.
        /// </summary>
        internal bool IsSetAggregateTypes() => this.AggregateTypes != null && (this.AggregateTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AssetId. 
        /// <para>
        /// The ID of the asset, in UUID format.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string AssetId { get; set; }

        /// <summary>
        /// Checks to see if the AssetId property is set.
        /// </summary>
        internal bool IsSetAssetId() => this.AssetId != null;

        /// <summary>
        /// Gets and sets the property EndDate. 
        /// <para>
        /// The inclusive end of the range from which to query historical data, expressed in seconds
        /// in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Checks to see if the EndDate property is set.
        /// </summary>
        internal bool IsSetEndDate() => this.EndDate.HasValue;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return for each paginated request. A result set is
        /// returned in the two cases, whichever occurs first.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The size of the result set is equal to 1 MB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The number of data points in the result set is equal to the value of <c>maxResults</c>.
        /// The maximum value of <c>maxResults</c> is 2500.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 1)]
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

        /// <summary>
        /// Gets and sets the property PropertyAlias. 
        /// <para>
        /// The alias that identifies the property, such as an OPC-UA server data stream path
        /// (for example, <c>/company/windfarm/3/turbine/7/temperature</c>). For more information,
        /// see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/connect-data-streams.html">Mapping
        /// industrial data streams to asset properties</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string PropertyAlias { get; set; }

        /// <summary>
        /// Checks to see if the PropertyAlias property is set.
        /// </summary>
        internal bool IsSetPropertyAlias() => this.PropertyAlias != null;

        /// <summary>
        /// Gets and sets the property PropertyId. 
        /// <para>
        /// The ID of the asset property, in UUID format.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string PropertyId { get; set; }

        /// <summary>
        /// Checks to see if the PropertyId property is set.
        /// </summary>
        internal bool IsSetPropertyId() => this.PropertyId != null;

        /// <summary>
        /// Gets and sets the property Qualities. 
        /// <para>
        /// The quality by which to filter asset data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<string> Qualities { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Qualities property is set.
        /// </summary>
        internal bool IsSetQualities() => this.Qualities != null && (this.Qualities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Resolution. 
        /// <para>
        /// The time interval over which to aggregate data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 3)]
        public string Resolution { get; set; }

        /// <summary>
        /// Checks to see if the Resolution property is set.
        /// </summary>
        internal bool IsSetResolution() => this.Resolution != null;

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The exclusive start of the range from which to query historical data, expressed in
        /// seconds in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Checks to see if the StartDate property is set.
        /// </summary>
        internal bool IsSetStartDate() => this.StartDate.HasValue;

        /// <summary>
        /// Gets and sets the property TimeOrdering. 
        /// <para>
        /// The chronological sorting order of the requested information.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>ASCENDING</c> 
        /// </para>
        /// </summary>
        public TimeOrdering TimeOrdering { get; set; }

        /// <summary>
        /// Checks to see if the TimeOrdering property is set.
        /// </summary>
        internal bool IsSetTimeOrdering() => this.TimeOrdering != null;
    }
}
