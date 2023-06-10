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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Properties associated with the dataset.
    /// </summary>
    public partial class DatasetProperties
    {
        private DateTime? _creationTime;
        private string _datasetArn;
        private string _datasetName;
        private string _datasetS3Uri;
        private DatasetType _datasetType;
        private string _description;
        private DateTime? _endTime;
        private string _message;
        private long? _numberOfDocuments;
        private DatasetStatus _status;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// Creation time of the dataset.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
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
        /// The ARN of the dataset.
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
        [AWSProperty(Max=63)]
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
        /// Gets and sets the property DatasetS3Uri. 
        /// <para>
        /// The S3 URI where the dataset is stored.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string DatasetS3Uri
        {
            get { return this._datasetS3Uri; }
            set { this._datasetS3Uri = value; }
        }

        // Check to see if DatasetS3Uri property is set
        internal bool IsSetDatasetS3Uri()
        {
            return this._datasetS3Uri != null;
        }

        /// <summary>
        /// Gets and sets the property DatasetType. 
        /// <para>
        /// The dataset type (training data or test data).
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
        /// Gets and sets the property Description. 
        /// <para>
        /// Description of the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// Time when the data from the dataset becomes available in the data lake.
        /// </para>
        /// </summary>
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A description of the status of the dataset.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property NumberOfDocuments. 
        /// <para>
        /// The number of documents in the dataset.
        /// </para>
        /// </summary>
        public long NumberOfDocuments
        {
            get { return this._numberOfDocuments.GetValueOrDefault(); }
            set { this._numberOfDocuments = value; }
        }

        // Check to see if NumberOfDocuments property is set
        internal bool IsSetNumberOfDocuments()
        {
            return this._numberOfDocuments.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The dataset status. While the system creates the dataset, the status is <code>CREATING</code>.
        /// When the dataset is ready to use, the status changes to <code>COMPLETED</code>. 
        /// </para>
        /// </summary>
        public DatasetStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}