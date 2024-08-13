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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Container for the parameters to the ListTimeSeries operation.
    /// Retrieves a paginated list of time series (data streams).
    /// </summary>
    public partial class ListTimeSeriesRequest : AmazonIoTSiteWiseRequest
    {
        private string _aliasPrefix;
        private string _assetId;
        private int? _maxResults;
        private string _nextToken;
        private ListTimeSeriesType _timeSeriesType;

        /// <summary>
        /// Gets and sets the property AliasPrefix. 
        /// <para>
        /// The alias prefix of the time series.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string AliasPrefix
        {
            get { return this._aliasPrefix; }
            set { this._aliasPrefix = value; }
        }

        // Check to see if AliasPrefix property is set
        internal bool IsSetAliasPrefix()
        {
            return this._aliasPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property AssetId. 
        /// <para>
        /// The ID of the asset in which the asset property was created. This can be either the
        /// actual ID in UUID format, or else <c>externalId:</c> followed by the external ID,
        /// if it has one. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/object-ids.html#external-id-references">Referencing
        /// objects with external IDs</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=13, Max=139)]
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
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return for each paginated request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=250)]
        public int? MaxResults
        {
            get { return this._maxResults; }
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
        /// Gets and sets the property TimeSeriesType. 
        /// <para>
        /// The type of the time series. The time series type can be one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ASSOCIATED</c> – The time series is associated with an asset property.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISASSOCIATED</c> – The time series isn't associated with any asset property.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ListTimeSeriesType TimeSeriesType
        {
            get { return this._timeSeriesType; }
            set { this._timeSeriesType = value; }
        }

        // Check to see if TimeSeriesType property is set
        internal bool IsSetTimeSeriesType()
        {
            return this._timeSeriesType != null;
        }

    }
}