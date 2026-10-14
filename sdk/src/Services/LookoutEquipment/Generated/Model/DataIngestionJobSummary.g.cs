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
    /// Provides information about a specified data ingestion job, including dataset information,
    /// data ingestion configuration, and status.
    /// </summary>
    public partial class DataIngestionJobSummary
    {
        /// <summary>
        /// Gets and sets the property DatasetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the dataset used in the data ingestion job. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string DatasetArn { get; set; }

        /// <summary>
        /// Checks to see if the DatasetArn property is set.
        /// </summary>
        internal bool IsSetDatasetArn() => this.DatasetArn != null;

        /// <summary>
        /// Gets and sets the property DatasetName. 
        /// <para>
        /// The name of the dataset used for the data ingestion job. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string DatasetName { get; set; }

        /// <summary>
        /// Checks to see if the DatasetName property is set.
        /// </summary>
        internal bool IsSetDatasetName() => this.DatasetName != null;

        /// <summary>
        /// Gets and sets the property IngestionInputConfiguration. 
        /// <para>
        ///  Specifies information for the input data for the data inference job, including data
        /// Amazon S3 location parameters. 
        /// </para>
        /// </summary>
        public IngestionInputConfiguration IngestionInputConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the IngestionInputConfiguration property is set.
        /// </summary>
        internal bool IsSetIngestionInputConfiguration() => this.IngestionInputConfiguration != null;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// Indicates the job ID of the data ingestion job. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 32)]
        public string JobId { get; set; }

        /// <summary>
        /// Checks to see if the JobId property is set.
        /// </summary>
        internal bool IsSetJobId() => this.JobId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Indicates the status of the data ingestion job. 
        /// </para>
        /// </summary>
        public IngestionJobStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
