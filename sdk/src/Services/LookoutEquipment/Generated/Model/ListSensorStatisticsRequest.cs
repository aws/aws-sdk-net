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
    /// Container for the parameters to the ListSensorStatistics operation.
    /// Lists statistics about the data collected for each of the sensors that have been
    /// successfully ingested in the particular dataset. Can also be used to retreive Sensor
    /// Statistics for a previous ingestion job.
    /// </summary>
    public partial class ListSensorStatisticsRequest : AmazonLookoutEquipmentRequest
    {
        private string _datasetName;
        private string _ingestionJobId;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property DatasetName. 
        /// <para>
        ///  The name of the dataset associated with the list of Sensor Statistics. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string DatasetName
        {
            get { return this._datasetName; }
            set { this._datasetName = value; }
        }

        // Check to see if DatasetName property is set
        internal bool IsSetDatasetName()
        {
            return this._datasetName != null;
        }

        /// <summary>
        /// Gets and sets the property IngestionJobId. 
        /// <para>
        ///  The ingestion job id associated with the list of Sensor Statistics. To get sensor
        /// statistics for a particular ingestion job id, both dataset name and ingestion job
        /// id must be submitted as inputs. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=32)]
        public string IngestionJobId
        {
            get { return this._ingestionJobId; }
            set { this._ingestionJobId = value; }
        }

        // Check to see if IngestionJobId property is set
        internal bool IsSetIngestionJobId()
        {
            return this._ingestionJobId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Specifies the maximum number of sensors for which to retrieve statistics. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
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

    }
}