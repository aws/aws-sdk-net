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
 * Do not modify this file. This file is generated from the forecast-2018-06-26.normal.json service model.
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
    /// Provides a summary of the dataset properties used in the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_ListDatasets.html">ListDatasets</a>
    /// operation. To get the complete set of properties, call the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_DescribeDataset.html">DescribeDataset</a>
    /// operation, and provide the <c>DatasetArn</c>.
    /// </summary>
    public partial class DatasetSummary
    {
        private DateTime? _creationTime;
        private string _datasetArn;
        private string _datasetName;
        private DatasetType _datasetType;
        private Domain _domain;
        private DateTime? _lastModificationTime;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// When the dataset was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DatasetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string DatasetArn
        {
            get { return this._datasetArn; }
            set { this._datasetArn = value; }
        }

        // Check to see if DatasetArn property is set
        internal bool IsSetDatasetArn()
        {
            return this._datasetArn != null;
        }

        /// <summary>
        /// Gets and sets the property DatasetName. 
        /// <para>
        /// The name of the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
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
        /// Gets and sets the property DatasetType. 
        /// <para>
        /// The dataset type.
        /// </para>
        /// </summary>
        public DatasetType DatasetType
        {
            get { return this._datasetType; }
            set { this._datasetType = value; }
        }

        // Check to see if DatasetType property is set
        internal bool IsSetDatasetType()
        {
            return this._datasetType != null;
        }

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The domain associated with the dataset.
        /// </para>
        /// </summary>
        public Domain Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

        /// <summary>
        /// Gets and sets the property LastModificationTime. 
        /// <para>
        /// When you create a dataset, <c>LastModificationTime</c> is the same as <c>CreationTime</c>.
        /// While data is being imported to the dataset, <c>LastModificationTime</c> is the current
        /// time of the <c>ListDatasets</c> call. After a <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_CreateDatasetImportJob.html">CreateDatasetImportJob</a>
        /// operation has finished, <c>LastModificationTime</c> is when the import job completed
        /// or failed.
        /// </para>
        /// </summary>
        public DateTime? LastModificationTime
        {
            get { return this._lastModificationTime; }
            set { this._lastModificationTime = value; }
        }

        // Check to see if LastModificationTime property is set
        internal bool IsSetLastModificationTime()
        {
            return this._lastModificationTime.HasValue; 
        }

    }
}