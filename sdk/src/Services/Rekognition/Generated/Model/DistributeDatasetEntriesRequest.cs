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

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Container for the parameters to the DistributeDatasetEntries operation.
    /// Distributes the entries (images) in a training dataset across the training dataset
    /// and the test dataset for a project. <code>DistributeDatasetEntries</code> moves 20%
    /// of the training dataset images to the test dataset. An entry is a JSON Line that describes
    /// an image. 
    /// 
    ///  
    /// <para>
    /// You supply the Amazon Resource Names (ARN) of a project's training dataset and test
    /// dataset. The training dataset must contain the images that you want to split. The
    /// test dataset must be empty. The datasets must belong to the same project. To create
    /// training and test datasets for a project, call <a>CreateDataset</a>.
    /// </para>
    ///  
    /// <para>
    /// Distributing a dataset takes a while to complete. To check the status call <code>DescribeDataset</code>.
    /// The operation is complete when the <code>Status</code> field for the training dataset
    /// and the test dataset is <code>UPDATE_COMPLETE</code>. If the dataset split fails,
    /// the value of <code>Status</code> is <code>UPDATE_FAILED</code>.
    /// </para>
    ///  
    /// <para>
    /// This operation requires permissions to perform the <code>rekognition:DistributeDatasetEntries</code>
    /// action.
    /// </para>
    /// </summary>
    public partial class DistributeDatasetEntriesRequest : AmazonRekognitionRequest
    {
        private List<DistributeDataset> _datasets = new List<DistributeDataset>();

        /// <summary>
        /// Gets and sets the property Datasets. 
        /// <para>
        /// The ARNS for the training dataset and test dataset that you want to use. The datasets
        /// must belong to the same project. The test dataset must be empty. 
        /// </para>
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
            return this._datasets != null && this._datasets.Count > 0; 
        }

    }
}