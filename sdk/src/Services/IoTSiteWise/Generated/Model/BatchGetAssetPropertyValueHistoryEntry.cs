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
    /// Contains information for an asset property historical value entry that is associated
    /// with the <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_BatchGetAssetPropertyValue.html">BatchGetAssetPropertyValueHistory</a>
    /// API.
    /// 
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
    public partial class BatchGetAssetPropertyValueHistoryEntry
    {
        private string _assetId;
        private DateTime? _endDate;
        private string _entryId;
        private string _propertyAlias;
        private string _propertyId;
        private List<string> _qualities = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _startDate;
        private TimeOrdering _timeOrdering;

        /// <summary>
        /// Gets and sets the property AssetId. 
        /// <para>
        /// The ID of the asset in which the asset property was created.
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
        public DateTime? EndDate
        {
            get { return this._endDate; }
            set { this._endDate = value; }
        }

        // Check to see if EndDate property is set
        internal bool IsSetEndDate()
        {
            return this._endDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EntryId. 
        /// <para>
        /// The ID of the entry.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string EntryId
        {
            get { return this._entryId; }
            set { this._entryId = value; }
        }

        // Check to see if EntryId property is set
        internal bool IsSetEntryId()
        {
            return this._entryId != null;
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
        /// Gets and sets the property Qualities. 
        /// <para>
        /// The quality by which to filter asset data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._qualities != null && (this._qualities.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The exclusive start of the range from which to query historical data, expressed in
        /// seconds in Unix epoch time.
        /// </para>
        /// </summary>
        public DateTime? StartDate
        {
            get { return this._startDate; }
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
        /// Default: <c>ASCENDING</c> 
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