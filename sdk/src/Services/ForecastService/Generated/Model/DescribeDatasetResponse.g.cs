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

namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// This is the response object from the DescribeDataset operation.
    /// </summary>
    public partial class DescribeDatasetResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// When the dataset was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DataFrequency. 
        /// <para>
        /// The frequency of data collection.
        /// </para>
        ///  
        /// <para>
        /// Valid intervals are Y (Year), M (Month), W (Week), D (Day), H (Hour), 30min (30 minutes),
        /// 15min (15 minutes), 10min (10 minutes), 5min (5 minutes), and 1min (1 minute). For
        /// example, "M" indicates every month and "30min" indicates every 30 minutes.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public string DataFrequency { get; set; }

        /// <summary>
        /// Checks to see if the DataFrequency property is set.
        /// </summary>
        internal bool IsSetDataFrequency() => this.DataFrequency != null;

        /// <summary>
        /// Gets and sets the property DatasetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string DatasetArn { get; set; }

        /// <summary>
        /// Checks to see if the DatasetArn property is set.
        /// </summary>
        internal bool IsSetDatasetArn() => this.DatasetArn != null;

        /// <summary>
        /// Gets and sets the property DatasetName. 
        /// <para>
        /// The name of the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string DatasetName { get; set; }

        /// <summary>
        /// Checks to see if the DatasetName property is set.
        /// </summary>
        internal bool IsSetDatasetName() => this.DatasetName != null;

        /// <summary>
        /// Gets and sets the property DatasetType. 
        /// <para>
        /// The dataset type.
        /// </para>
        /// </summary>
        public DatasetType DatasetType { get; set; }

        /// <summary>
        /// Checks to see if the DatasetType property is set.
        /// </summary>
        internal bool IsSetDatasetType() => this.DatasetType != null;

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The domain associated with the dataset.
        /// </para>
        /// </summary>
        public Domain Domain { get; set; }

        /// <summary>
        /// Checks to see if the Domain property is set.
        /// </summary>
        internal bool IsSetDomain() => this.Domain != null;

        /// <summary>
        /// Gets and sets the property EncryptionConfig. 
        /// <para>
        /// The Key Management Service (KMS) key and the Identity and Access Management (IAM)
        /// role that Amazon Forecast can assume to access the key.
        /// </para>
        /// </summary>
        public EncryptionConfig EncryptionConfig { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionConfig property is set.
        /// </summary>
        internal bool IsSetEncryptionConfig() => this.EncryptionConfig != null;

        /// <summary>
        /// Gets and sets the property LastModificationTime. 
        /// <para>
        /// When you create a dataset, <c>LastModificationTime</c> is the same as <c>CreationTime</c>.
        /// While data is being imported to the dataset, <c>LastModificationTime</c> is the current
        /// time of the <c>DescribeDataset</c> call. After a <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_CreateDatasetImportJob.html">CreateDatasetImportJob</a>
        /// operation has finished, <c>LastModificationTime</c> is when the import job completed
        /// or failed.
        /// </para>
        /// </summary>
        public DateTime? LastModificationTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModificationTime property is set.
        /// </summary>
        internal bool IsSetLastModificationTime() => this.LastModificationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Schema. 
        /// <para>
        /// An array of <c>SchemaAttribute</c> objects that specify the dataset fields. Each <c>SchemaAttribute</c>
        /// specifies the name and data type of a field.
        /// </para>
        /// </summary>
        public Schema Schema { get; set; }

        /// <summary>
        /// Checks to see if the Schema property is set.
        /// </summary>
        internal bool IsSetSchema() => this.Schema != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the dataset. States include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ACTIVE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATE_PENDING</c>, <c>CREATE_IN_PROGRESS</c>, <c>CREATE_FAILED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETE_PENDING</c>, <c>DELETE_IN_PROGRESS</c>, <c>DELETE_FAILED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATE_PENDING</c>, <c>UPDATE_IN_PROGRESS</c>, <c>UPDATE_FAILED</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The <c>UPDATE</c> states apply while data is imported to the dataset from a call to
        /// the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_CreateDatasetImportJob.html">CreateDatasetImportJob</a>
        /// operation and reflect the status of the dataset import job. For example, when the
        /// import job status is <c>CREATE_IN_PROGRESS</c>, the status of the dataset is <c>UPDATE_IN_PROGRESS</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <c>Status</c> of the dataset must be <c>ACTIVE</c> before you can import training
        /// data.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
