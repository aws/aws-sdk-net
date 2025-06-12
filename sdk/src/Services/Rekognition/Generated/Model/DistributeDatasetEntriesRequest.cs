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
    /// Container for the parameters to the DistributeDatasetEntries operation.
    /// <note> 
    /// <para>
    /// This operation applies only to Amazon Rekognition Custom Labels.
    /// </para>
    ///  </note> 
    /// <para>
    /// Distributes the entries (images) in a training dataset across the training dataset
    /// and the test dataset for a project. <c>DistributeDatasetEntries</c> moves 20% of the
    /// training dataset images to the test dataset. An entry is a JSON Line that describes
    /// an image. 
    /// </para>
    ///  
    /// <para>
    /// You supply the Amazon Resource Names (ARN) of a project's training dataset and test
    /// dataset. The training dataset must contain the images that you want to split. The
    /// test dataset must be empty. The datasets must belong to the same project. To create
    /// training and test datasets for a project, call <a>CreateDataset</a>.
    /// </para>
    ///  
    /// <para>
    /// Distributing a dataset takes a while to complete. To check the status call <c>DescribeDataset</c>.
    /// The operation is complete when the <c>Status</c> field for the training dataset and
    /// the test dataset is <c>UPDATE_COMPLETE</c>. If the dataset split fails, the value
    /// of <c>Status</c> is <c>UPDATE_FAILED</c>.
    /// </para>
    ///  
    /// <para>
    /// This operation requires permissions to perform the <c>rekognition:DistributeDatasetEntries</c>
    /// action.
    /// </para>
    /// </summary>
    public partial class DistributeDatasetEntriesRequest : AmazonRekognitionRequest
    {
        private List<DistributeDataset> _datasets = AWSConfigs.InitializeCollections ? new List<DistributeDataset>() : null;

        /// <summary>
        /// Gets and sets the property Datasets. 
        /// <para>
        /// The ARNS for the training dataset and test dataset that you want to use. The datasets
        /// must belong to the same project. The test dataset must be empty. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=2)]
        public List<DistributeDataset> Datasets
        {
            get { return this._datasets; }
            set { this._datasets = value; }
        }

        // Check to see if Datasets property is set
        internal bool IsSetDatasets()
        {
            return this._datasets != null && (this._datasets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}