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
    /// Container for the parameters to the GetInterpolatedAssetPropertyValues operation.
    /// Get interpolated values for an asset property for a specified time interval, during
    /// a period of time. For example, you can use the this operation to return the interpolated
    /// temperature values for a wind turbine every 24 hours over a duration of 7 days.
    /// 
    ///  <note> 
    /// <para>
    /// This API isn't available in China (Beijing).
    /// </para>
    ///  </note> 
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
    public partial class GetInterpolatedAssetPropertyValuesRequest : AmazonIoTSiteWiseRequest
    {
        private string _assetId;
        private long? _endTimeInSeconds;
        private int? _endTimeOffsetInNanos;
        private long? _intervalInSeconds;
        private int? _maxResults;
        private string _nextToken;
        private string _propertyAlias;
        private string _propertyId;
        private Quality _quality;
        private long? _startTimeInSeconds;
        private int? _startTimeOffsetInNanos;
        private string _type;

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
        /// Gets and sets the property EndTimeInSeconds. 
        /// <para>
        /// The inclusive end of the range from which to interpolate data, expressed in seconds
        /// in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=31556889864403199)]
        public long EndTimeInSeconds
        {
            get { return this._endTimeInSeconds.GetValueOrDefault(); }
            set { this._endTimeInSeconds = value; }
        }

        // Check to see if EndTimeInSeconds property is set
        internal bool IsSetEndTimeInSeconds()
        {
            return this._endTimeInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndTimeOffsetInNanos. 
        /// <para>
        /// The nanosecond offset converted from <code>endTimeInSeconds</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=999999999)]
        public int EndTimeOffsetInNanos
        {
            get { return this._endTimeOffsetInNanos.GetValueOrDefault(); }
            set { this._endTimeOffsetInNanos = value; }
        }

        // Check to see if EndTimeOffsetInNanos property is set
        internal bool IsSetEndTimeOffsetInNanos()
        {
            return this._endTimeOffsetInNanos.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IntervalInSeconds. 
        /// <para>
        /// The time interval in seconds over which to interpolate data. Each interval starts
        /// when the previous one ends.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=320000000)]
        public long IntervalInSeconds
        {
            get { return this._intervalInSeconds.GetValueOrDefault(); }
            set { this._intervalInSeconds = value; }
        }

        // Check to see if IntervalInSeconds property is set
        internal bool IsSetIntervalInSeconds()
        {
            return this._intervalInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to be returned per paginated request. If not specified,
        /// the default value is 10.
        /// </para>
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
        /// The property alias that identifies the property, such as an OPC-UA server data stream
        /// path (for example, <code>/company/windfarm/3/turbine/7/temperature</code>). For more
        /// information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/connect-data-streams.html">Mapping
        /// industrial data streams to asset properties</a> in the <i>AWS IoT SiteWise User Guide</i>.
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
        /// Gets and sets the property Quality. 
        /// <para>
        /// The quality of the asset property value. You can use this parameter as a filter to
        /// choose only the asset property values that have a specific quality.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Quality Quality
        {
            get { return this._quality; }
            set { this._quality = value; }
        }

        // Check to see if Quality property is set
        internal bool IsSetQuality()
        {
            return this._quality != null;
        }

        /// <summary>
        /// Gets and sets the property StartTimeInSeconds. 
        /// <para>
        /// The exclusive start of the range from which to interpolate data, expressed in seconds
        /// in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=31556889864403199)]
        public long StartTimeInSeconds
        {
            get { return this._startTimeInSeconds.GetValueOrDefault(); }
            set { this._startTimeInSeconds = value; }
        }

        // Check to see if StartTimeInSeconds property is set
        internal bool IsSetStartTimeInSeconds()
        {
            return this._startTimeInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartTimeOffsetInNanos. 
        /// <para>
        /// The nanosecond offset converted from <code>startTimeInSeconds</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=999999999)]
        public int StartTimeOffsetInNanos
        {
            get { return this._startTimeOffsetInNanos.GetValueOrDefault(); }
            set { this._startTimeOffsetInNanos = value; }
        }

        // Check to see if StartTimeOffsetInNanos property is set
        internal bool IsSetStartTimeOffsetInNanos()
        {
            return this._startTimeOffsetInNanos.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The interpolation type.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>LINEAR_INTERPOLATION</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}