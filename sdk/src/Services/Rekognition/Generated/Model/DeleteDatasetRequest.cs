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
    /// Container for the parameters to the DeleteDataset operation.
    /// <note> 
    /// <para>
    /// This operation applies only to Amazon Rekognition Custom Labels.
    /// </para>
    ///  </note> 
    /// <para>
    /// Deletes an existing Amazon Rekognition Custom Labels dataset. Deleting a dataset might
    /// take while. Use <a>DescribeDataset</a> to check the current status. The dataset is
    /// still deleting if the value of <c>Status</c> is <c>DELETE_IN_PROGRESS</c>. If you
    /// try to access the dataset after it is deleted, you get a <c>ResourceNotFoundException</c>
    /// exception. 
    /// </para>
    ///  
    /// <para>
    /// You can't delete a dataset while it is creating (<c>Status</c> = <c>CREATE_IN_PROGRESS</c>)
    /// or if the dataset is updating (<c>Status</c> = <c>UPDATE_IN_PROGRESS</c>).
    /// </para>
    ///  
    /// <para>
    /// This operation requires permissions to perform the <c>rekognition:DeleteDataset</c>
    /// action.
    /// </para>
    /// </summary>
    public partial class DeleteDatasetRequest : AmazonRekognitionRequest
    {
        private string _datasetArn;

        /// <summary>
        /// Gets and sets the property DatasetArn. 
        /// <para>
        ///  The ARN of the Amazon Rekognition Custom Labels dataset that you want to delete.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
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

    }
}