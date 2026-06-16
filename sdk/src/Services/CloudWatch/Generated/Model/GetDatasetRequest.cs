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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
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
namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// Container for the parameters to the GetDataset operation.
    /// Returns information about the specified dataset. This includes its identifier, Amazon
    /// Resource Name (ARN), and any customer managed Amazon Web Services Key Management Service
    /// (Amazon Web Services KMS) key that is currently associated with it.
    /// 
    ///  
    /// <para>
    /// Only the <c>default</c> dataset is supported. The <c>default</c> dataset is implicit
    /// for every account in every Region — you can call <c>GetDataset</c> for it without
    /// first creating it. If no customer managed KMS key has been associated with the dataset,
    /// the response omits the <c>KmsKeyArn</c> field, indicating that data is encrypted at
    /// rest using an Amazon Web Services owned key managed by Amazon CloudWatch.
    /// </para>
    ///  
    /// <para>
    /// To associate a customer managed KMS key with a dataset, use <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_AssociateDatasetKmsKey.html">AssociateDatasetKmsKey</a>.
    /// To remove the association, use <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_DisassociateDatasetKmsKey.html">DisassociateDatasetKmsKey</a>.
    /// </para>
    /// </summary>
    public partial class GetDatasetRequest : AmazonCloudWatchRequest
    {
        private string _datasetIdentifier;

        /// <summary>
        /// Gets and sets the property DatasetIdentifier. 
        /// <para>
        /// Specifies the identifier of the dataset to retrieve. For the <c>default</c> dataset,
        /// you can specify either <c>default</c> or the full dataset Amazon Resource Name (ARN)
        /// in the format <c>arn:aws:cloudwatch:<i>Region</i>:<i>account-id</i>:dataset/default</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string DatasetIdentifier
        {
            get { return this._datasetIdentifier; }
            set { this._datasetIdentifier = value; }
        }

        // Check to see if DatasetIdentifier property is set
        internal bool IsSetDatasetIdentifier()
        {
            return this._datasetIdentifier != null;
        }

    }
}