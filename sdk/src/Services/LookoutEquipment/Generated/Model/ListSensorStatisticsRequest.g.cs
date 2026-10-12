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

namespace Amazon.LookoutEquipment.Model
{
    /// <summary>
    /// Container for the parameters to the ListSensorStatistics operation. Lists statistics
    /// about the data collected for each of the sensors that have been successfully ingested
    /// in the particular dataset. Can also be used to retreive Sensor Statistics for a previous
    /// ingestion job.
    /// </summary>
    public partial class ListSensorStatisticsRequest : AmazonLookoutEquipmentRequest
    {
        /// <summary>
        /// Gets and sets the property DatasetName. 
        /// <para>
        ///  The name of the dataset associated with the list of Sensor Statistics. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string DatasetName { get; set; }

        /// <summary>
        /// Checks to see if the DatasetName property is set.
        /// </summary>
        internal bool IsSetDatasetName() => this.DatasetName != null;

        /// <summary>
        /// Gets and sets the property IngestionJobId. 
        /// <para>
        ///  The ingestion job id associated with the list of Sensor Statistics. To get sensor
        /// statistics for a particular ingestion job id, both dataset name and ingestion job
        /// id must be submitted as inputs. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 32)]
        public string IngestionJobId { get; set; }

        /// <summary>
        /// Checks to see if the IngestionJobId property is set.
        /// </summary>
        internal bool IsSetIngestionJobId() => this.IngestionJobId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Specifies the maximum number of sensors for which to retrieve statistics. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An opaque pagination token indicating where to continue the listing of sensor statistics.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8192)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
