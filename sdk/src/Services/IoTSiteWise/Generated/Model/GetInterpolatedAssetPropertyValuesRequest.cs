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
    /// Container for the parameters to the GetInterpolatedAssetPropertyValues operation.
    /// Get interpolated values for an asset property for a specified time interval, during
    /// a period of time. If your time series is missing data points during the specified
    /// time interval, you can use interpolation to estimate the missing data.
    /// 
    ///  
    /// <para>
    /// For example, you can use this operation to return the interpolated temperature values
    /// for a wind turbine every 24 hours over a duration of 7 days.
    /// </para>
    ///  
    /// <para>
    /// To identify an asset property, you must specify one of the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The <c>assetId</c> and <c>propertyId</c> of an asset property.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A <c>propertyAlias</c>, which is a data stream alias (for example, <c>/company/windfarm/3/turbine/7/temperature</c>).
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
        private long? _intervalWindowInSeconds;
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
        /// The ID of the asset, in UUID format.
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
        [AWSProperty(Required=true, Min=1, Max=9223372036854774)]
        public long? EndTimeInSeconds
        {
            get { return this._endTimeInSeconds; }
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
        /// The nanosecond offset converted from <c>endTimeInSeconds</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=999999999)]
        public int? EndTimeOffsetInNanos
        {
            get { return this._endTimeOffsetInNanos; }
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
        public long? IntervalInSeconds
        {
            get { return this._intervalInSeconds; }
            set { this._intervalInSeconds = value; }
        }

        // Check to see if IntervalInSeconds property is set
        internal bool IsSetIntervalInSeconds()
        {
            return this._intervalInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IntervalWindowInSeconds. 
        /// <para>
        /// The query interval for the window, in seconds. IoT SiteWise computes each interpolated
        /// value by using data points from the timestamp of each interval, minus the window to
        /// the timestamp of each interval plus the window. If not specified, the window ranges
        /// between the start time minus the interval and the end time plus the interval.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// If you specify a value for the <c>intervalWindowInSeconds</c> parameter, the value
        /// for the <c>type</c> parameter must be <c>LINEAR_INTERPOLATION</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If a data point isn't found during the specified query window, IoT SiteWise won't
        /// return an interpolated value for the interval. This indicates that there's a gap in
        /// the ingested data points.
        /// </para>
        ///  </li> </ul> </note> 
        /// <para>
        /// For example, you can get the interpolated temperature values for a wind turbine every
        /// 24 hours over a duration of 7 days. If the interpolation starts on July 1, 2021, at
        /// 9 AM with a window of 2 hours, IoT SiteWise uses the data points from 7 AM (9 AM minus
        /// 2 hours) to 11 AM (9 AM plus 2 hours) on July 2, 2021 to compute the first interpolated
        /// value. Next, IoT SiteWise uses the data points from 7 AM (9 AM minus 2 hours) to 11
        /// AM (9 AM plus 2 hours) on July 3, 2021 to compute the second interpolated value, and
        /// so on. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=320000000)]
        public long? IntervalWindowInSeconds
        {
            get { return this._intervalWindowInSeconds; }
            set { this._intervalWindowInSeconds = value; }
        }

        // Check to see if IntervalWindowInSeconds property is set
        internal bool IsSetIntervalWindowInSeconds()
        {
            return this._intervalWindowInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return for each paginated request. If not specified,
        /// the default value is 10.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// Gets and sets the property PropertyAlias. 
        /// <para>
        /// The alias that identifies the property, such as an OPC-UA server data stream path
        /// (for example, <c>/company/windfarm/3/turbine/7/temperature</c>). For more information,
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
        /// The ID of the asset property, in UUID format.
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
        [AWSProperty(Required=true, Min=1, Max=9223372036854774)]
        public long? StartTimeInSeconds
        {
            get { return this._startTimeInSeconds; }
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
        /// The nanosecond offset converted from <c>startTimeInSeconds</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=999999999)]
        public int? StartTimeOffsetInNanos
        {
            get { return this._startTimeOffsetInNanos; }
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
        /// Valid values: <c>LINEAR_INTERPOLATION | LOCF_INTERPOLATION</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>LINEAR_INTERPOLATION</c> – Estimates missing data using <a href="https://en.wikipedia.org/wiki/Linear_interpolation">linear
        /// interpolation</a>.
        /// </para>
        ///  
        /// <para>
        /// For example, you can use this operation to return the interpolated temperature values
        /// for a wind turbine every 24 hours over a duration of 7 days. If the interpolation
        /// starts July 1, 2021, at 9 AM, IoT SiteWise returns the first interpolated value on
        /// July 2, 2021, at 9 AM, the second interpolated value on July 3, 2021, at 9 AM, and
        /// so on.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LOCF_INTERPOLATION</c> – Estimates missing data using last observation carried
        /// forward interpolation
        /// </para>
        ///  
        /// <para>
        /// If no data point is found for an interval, IoT SiteWise returns the last observed
        /// data point for the previous interval and carries forward this interpolated value until
        /// a new data point is found.
        /// </para>
        ///  
        /// <para>
        /// For example, you can get the state of an on-off valve every 24 hours over a duration
        /// of 7 days. If the interpolation starts July 1, 2021, at 9 AM, IoT SiteWise returns
        /// the last observed data point between July 1, 2021, at 9 AM and July 2, 2021, at 9
        /// AM as the first interpolated value. If a data point isn't found after 9 AM on July
        /// 2, 2021, IoT SiteWise uses the same interpolated value for the rest of the days.
        /// </para>
        ///  </li> </ul>
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