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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Container for the parameters to the GetAssetPropertyAggregates operation.
    /// Gets aggregated values for an asset property. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/query-industrial-data.html#aggregates">Querying
    /// aggregates</a> in the <i>IoT SiteWise User Guide</i>.
    /// 
    ///  
    /// <para>
    /// To identify an asset property, you must specify one of the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The <code>assetId</code> and <code>propertyId</code> of an asset property.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A <code>propertyAlias</code>, which is a data stream alias (for example, <code>/company/windfarm/3/turbine/7/temperature</code>).
    /// To define an asset property's alias, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_UpdateAssetProperty.html">UpdateAssetProperty</a>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GetAssetPropertyAggregatesRequest : AmazonIoTSiteWiseRequest
    {
        private List<string> _aggregateTypes = new List<string>();
        private string _assetId;
        private DateTime? _endDate;
        private int? _maxResults;
        private string _nextToken;
        private string _propertyAlias;
        private string _propertyId;
        private List<string> _qualities = new List<string>();
        private string _resolution;
        private DateTime? _startDate;
        private TimeOrdering _timeOrdering;

        /// <summary>
        /// Gets and sets the property AggregateTypes. 
        /// <para>
        /// The data aggregating function.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<string> AggregateTypes
        {
            get { return this._aggregateTypes; }
            set { this._aggregateTypes = value; }
        }

        // Check to see if AggregateTypes property is set
        internal bool IsSetAggregateTypes()
        {
            return this._aggregateTypes != null && this._aggregateTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AssetId. 
        /// <para>
        /// The ID of the asset.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string AssetId
        {
            get { return this._assetId; }
            set { this._assetId = value; }
        }

        // Check to see if AssetId property is set
        internal bool IsSetAssetId()
        {
            return this._assetId != null;
        }

        /// <summary>
        /// Gets and sets the property EndDate. 
        /// <para>
        /// The inclusive end of the range from which to query historical data, expressed in seconds
        /// in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime EndDate
        {
            get { return this._endDate.GetValueOrDefault(); }
            set { this._endDate = value; }
        }

        // Check to see if EndDate property is set
        internal bool IsSetEndDate()
        {
            return this._endDate.HasValue; 
        }

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
        /// The number of data points in the result set is equal to the value of <code>maxResults</code>.
        /// The maximum value of <code>maxResults</code> is 250.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to be used for the next set of paginated results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property PropertyAlias. 
        /// <para>
        /// The alias that identifies the property, such as an OPC-UA server data stream path
        /// (for example, <code>/company/windfarm/3/turbine/7/temperature</code>). For more information,
        /// see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/connect-data-streams.html">Mapping
        /// industrial data streams to asset properties</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string PropertyAlias
        {
            get { return this._propertyAlias; }
            set { this._propertyAlias = value; }
        }

        // Check to see if PropertyAlias property is set
        internal bool IsSetPropertyAlias()
        {
            return this._propertyAlias != null;
        }

        /// <summary>
        /// Gets and sets the property PropertyId. 
        /// <para>
        /// The ID of the asset property.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string PropertyId
        {
            get { return this._propertyId; }
            set { this._propertyId = value; }
        }

        // Check to see if PropertyId property is set
        internal bool IsSetPropertyId()
        {
            return this._propertyId != null;
        }

        /// <summary>
        /// Gets and sets the property Qualities. 
        /// <para>
        /// The quality by which to filter asset data.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<string> Qualities
        {
            get { return this._qualities; }
            set { this._qualities = value; }
        }

        // Check to see if Qualities property is set
        internal bool IsSetQualities()
        {
            return this._qualities != null && this._qualities.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Resolution. 
        /// <para>
        /// The time interval over which to aggregate data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=3)]
        public string Resolution
        {
            get { return this._resolution; }
            set { this._resolution = value; }
        }

        // Check to see if Resolution property is set
        internal bool IsSetResolution()
        {
            return this._resolution != null;
        }

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The exclusive start of the range from which to query historical data, expressed in
        /// seconds in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime StartDate
        {
            get { return this._startDate.GetValueOrDefault(); }
            set { this._startDate = value; }
        }

        // Check to see if StartDate property is set
        internal bool IsSetStartDate()
        {
            return this._startDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeOrdering. 
        /// <para>
        /// The chronological sorting order of the requested information.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>ASCENDING</code> 
        /// </para>
        /// </summary>
        public TimeOrdering TimeOrdering
        {
            get { return this._timeOrdering; }
            set { this._timeOrdering = value; }
        }

        // Check to see if TimeOrdering property is set
        internal bool IsSetTimeOrdering()
        {
            return this._timeOrdering != null;
        }

    }
}