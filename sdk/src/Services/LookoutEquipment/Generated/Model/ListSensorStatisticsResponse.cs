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
 * Do not modify this file. This file is generated from the lookoutequipment-2020-12-15.normal.json service model.
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
namespace Amazon.LookoutEquipment.Model
{
    /// <summary>
    /// This is the response object from the ListSensorStatistics operation.
    /// </summary>
    public partial class ListSensorStatisticsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<SensorStatisticsSummary> _sensorStatisticsSummaries = AWSConfigs.InitializeCollections ? new List<SensorStatisticsSummary>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An opaque pagination token indicating where to continue the listing of sensor statistics.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Max=8192)]
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
        /// Gets and sets the property SensorStatisticsSummaries. 
        /// <para>
        /// Provides ingestion-based statistics regarding the specified sensor with respect to
        /// various validation types, such as whether data exists, the number and percentage of
        /// missing values, and the number and percentage of duplicate timestamps. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SensorStatisticsSummary> SensorStatisticsSummaries
        {
            get { return this._sensorStatisticsSummaries; }
            set { this._sensorStatisticsSummaries = value; }
        }

        // Check to see if SensorStatisticsSummaries property is set
        internal bool IsSetSensorStatisticsSummaries()
        {
            return this._sensorStatisticsSummaries != null && (this._sensorStatisticsSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}