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

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Properties associated with the dataset.
    /// </summary>
    public partial class DatasetProperties
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// Creation time of the dataset.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DatasetArn. 
        /// <para>
        /// The ARN of the dataset.
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
        [AWSProperty(Min = 0, Max = 63)]
        public string DatasetName { get; set; }

        /// <summary>
        /// Checks to see if the DatasetName property is set.
        /// </summary>
        internal bool IsSetDatasetName() => this.DatasetName != null;

        /// <summary>
        /// Gets and sets the property DatasetS3Uri. 
        /// <para>
        /// The S3 URI where the dataset is stored.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string DatasetS3Uri { get; set; }

        /// <summary>
        /// Checks to see if the DatasetS3Uri property is set.
        /// </summary>
        internal bool IsSetDatasetS3Uri() => this.DatasetS3Uri != null;

        /// <summary>
        /// Gets and sets the property DatasetType. 
        /// <para>
        /// The dataset type (training data or test data).
        /// </para>
        /// </summary>
        public DatasetType DatasetType { get; set; }

        /// <summary>
        /// Checks to see if the DatasetType property is set.
        /// </summary>
        internal bool IsSetDatasetType() => this.DatasetType != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Description of the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// Time when the data from the dataset becomes available in the data lake.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A description of the status of the dataset.
        /// </para>
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property NumberOfDocuments. 
        /// <para>
        /// The number of documents in the dataset.
        /// </para>
        /// </summary>
        public long? NumberOfDocuments { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfDocuments property is set.
        /// </summary>
        internal bool IsSetNumberOfDocuments() => this.NumberOfDocuments.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The dataset status. While the system creates the dataset, the status is <c>CREATING</c>.
        /// When the dataset is ready to use, the status changes to <c>COMPLETED</c>. 
        /// </para>
        /// </summary>
        public DatasetStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
