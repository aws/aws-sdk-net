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
    /// This is the response object from the DescribeDataset operation.
    /// </summary>
    public partial class DescribeDatasetResponse : AmazonWebServiceResponse
    {
        private string _datasetArn;
        private DateTime? _datasetCreationDate;
        private string _datasetDescription;
        private string _datasetId;
        private DateTime? _datasetLastUpdateDate;
        private string _datasetName;
        private DatasetSource _datasetSource;
        private DatasetStatus _datasetStatus;
        private string _datasetVersion;

        /// <summary>
        /// Gets and sets the property DatasetArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference-arns.html">ARN</a>
        /// of the dataset. The format is <c>arn:${Partition}:iotsitewise:${Region}:${Account}:dataset/${DatasetId}</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1600)]
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
        /// Gets and sets the property DatasetCreationDate. 
        /// <para>
        /// The dataset creation date, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? DatasetCreationDate
        {
            get { return this._datasetCreationDate; }
            set { this._datasetCreationDate = value; }
        }

        // Check to see if DatasetCreationDate property is set
        internal bool IsSetDatasetCreationDate()
        {
            return this._datasetCreationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DatasetDescription. 
        /// <para>
        /// A description about the dataset, and its functionality.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string DatasetDescription
        {
            get { return this._datasetDescription; }
            set { this._datasetDescription = value; }
        }

        // Check to see if DatasetDescription property is set
        internal bool IsSetDatasetDescription()
        {
            return this._datasetDescription != null;
        }

        /// <summary>
        /// Gets and sets the property DatasetId. 
        /// <para>
        /// The ID of the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string DatasetId
        {
            get { return this._datasetId; }
            set { this._datasetId = value; }
        }

        // Check to see if DatasetId property is set
        internal bool IsSetDatasetId()
        {
            return this._datasetId != null;
        }

        /// <summary>
        /// Gets and sets the property DatasetLastUpdateDate. 
        /// <para>
        /// The date the dataset was last updated, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? DatasetLastUpdateDate
        {
            get { return this._datasetLastUpdateDate; }
            set { this._datasetLastUpdateDate = value; }
        }

        // Check to see if DatasetLastUpdateDate property is set
        internal bool IsSetDatasetLastUpdateDate()
        {
            return this._datasetLastUpdateDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DatasetName. 
        /// <para>
        /// The name of the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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
        /// Gets and sets the property DatasetSource. 
        /// <para>
        /// The data source for the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DatasetSource DatasetSource
        {
            get { return this._datasetSource; }
            set { this._datasetSource = value; }
        }

        // Check to see if DatasetSource property is set
        internal bool IsSetDatasetSource()
        {
            return this._datasetSource != null;
        }

        /// <summary>
        /// Gets and sets the property DatasetStatus. 
        /// <para>
        /// The status of the dataset. This contains the state and any error messages. State is
        /// <c>CREATING</c> after a successfull call to this API, and any associated error message.
        /// The state is <c>ACTIVE</c> when ready to use.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DatasetStatus DatasetStatus
        {
            get { return this._datasetStatus; }
            set { this._datasetStatus = value; }
        }

        // Check to see if DatasetStatus property is set
        internal bool IsSetDatasetStatus()
        {
            return this._datasetStatus != null;
        }

        /// <summary>
        /// Gets and sets the property DatasetVersion. 
        /// <para>
        /// The version of the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public string DatasetVersion
        {
            get { return this._datasetVersion; }
            set { this._datasetVersion = value; }
        }

        // Check to see if DatasetVersion property is set
        internal bool IsSetDatasetVersion()
        {
            return this._datasetVersion != null;
        }

    }
}