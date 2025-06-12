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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
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
namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDataset operation.
    /// <note> 
    /// <para>
    /// This operation applies only to Amazon Rekognition Custom Labels.
    /// </para>
    ///  </note> 
    /// <para>
    /// Creates a new Amazon Rekognition Custom Labels dataset. You can create a dataset by
    /// using an Amazon Sagemaker format manifest file or by copying an existing Amazon Rekognition
    /// Custom Labels dataset.
    /// </para>
    ///  
    /// <para>
    /// To create a training dataset for a project, specify <c>TRAIN</c> for the value of
    /// <c>DatasetType</c>. To create the test dataset for a project, specify <c>TEST</c>
    /// for the value of <c>DatasetType</c>. 
    /// </para>
    ///  
    /// <para>
    /// The response from <c>CreateDataset</c> is the Amazon Resource Name (ARN) for the dataset.
    /// Creating a dataset takes a while to complete. Use <a>DescribeDataset</a> to check
    /// the current status. The dataset created successfully if the value of <c>Status</c>
    /// is <c>CREATE_COMPLETE</c>. 
    /// </para>
    ///  
    /// <para>
    /// To check if any non-terminal errors occurred, call <a>ListDatasetEntries</a> and check
    /// for the presence of <c>errors</c> lists in the JSON Lines.
    /// </para>
    ///  
    /// <para>
    /// Dataset creation fails if a terminal error occurs (<c>Status</c> = <c>CREATE_FAILED</c>).
    /// Currently, you can't access the terminal error information. 
    /// </para>
    ///  
    /// <para>
    /// For more information, see Creating dataset in the <i>Amazon Rekognition Custom Labels
    /// Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// This operation requires permissions to perform the <c>rekognition:CreateDataset</c>
    /// action. If you want to copy an existing dataset, you also require permission to perform
    /// the <c>rekognition:ListDatasetEntries</c> action.
    /// </para>
    /// </summary>
    public partial class CreateDatasetRequest : AmazonRekognitionRequest
    {
        private DatasetSource _datasetSource;
        private DatasetType _datasetType;
        private string _projectArn;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property DatasetSource. 
        /// <para>
        ///  The source files for the dataset. You can specify the ARN of an existing dataset
        /// or specify the Amazon S3 bucket location of an Amazon Sagemaker format manifest file.
        /// If you don't specify <c>datasetSource</c>, an empty dataset is created. To add labeled
        /// images to the dataset, You can use the console or call <a>UpdateDatasetEntries</a>.
        /// 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property DatasetType. 
        /// <para>
        ///  The type of the dataset. Specify <c>TRAIN</c> to create a training dataset. Specify
        /// <c>TEST</c> to create a test dataset. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ProjectArn. 
        /// <para>
        ///  The ARN of the Amazon Rekognition Custom Labels project to which you want to asssign
        /// the dataset. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ProjectArn
        {
            get { return this._projectArn; }
            set { this._projectArn = value; }
        }

        // Check to see if ProjectArn property is set
        internal bool IsSetProjectArn()
        {
            return this._projectArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A set of tags (key-value pairs) that you want to attach to the dataset.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}