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
    /// Container for the parameters to the DisassociateDatasetKmsKey operation.
    /// Removes the customer managed Amazon Web Services Key Management Service (Amazon Web
    /// Services KMS) key association from the specified dataset. After this operation completes,
    /// data that you publish to the dataset is encrypted at rest using an Amazon Web Services
    /// owned key managed by Amazon CloudWatch.
    /// 
    ///  
    /// <para>
    /// Only the <c>default</c> dataset is supported. To call this operation, the dataset
    /// must currently have a customer managed KMS key associated with it. If the dataset
    /// has no associated KMS key, the operation fails with <c>ResourceNotFoundException</c>.
    /// </para>
    ///  
    /// <para>
    /// Amazon CloudWatch performs a dry-run <c>kms:Decrypt</c> call on the key as part of
    /// this operation. This verifies that the caller is authorized to use the currently associated
    /// key. The caller must have <c>kms:Decrypt</c> permission on the currently associated
    /// key, and the key must be enabled and accessible. If the key has been disabled or scheduled
    /// for deletion, you must first re-enable or restore it before you can disassociate it
    /// from the dataset.
    /// </para>
    ///  <important> 
    /// <para>
    /// Disassociating a KMS key from a dataset does not immediately remove the <c>kms:Decrypt</c>
    /// requirement on data plane operations. For up to three hours after disassociation,
    /// callers must continue to have <c>kms:Decrypt</c> permission on the previously associated
    /// key. Some data may still be encrypted with that key during this window. After this
    /// enforcement window elapses, the <c>kms:Decrypt</c> requirement is lifted.
    /// </para>
    ///  </important> 
    /// <para>
    /// For more information about using customer managed keys with Amazon CloudWatch, see
    /// <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/cmk-encryption.html">Encryption
    /// at rest with customer managed keys</a> in the <i>Amazon CloudWatch User Guide</i>.
    /// </para>
    /// </summary>
    public partial class DisassociateDatasetKmsKeyRequest : AmazonCloudWatchRequest
    {
        private string _datasetIdentifier;

        /// <summary>
        /// Gets and sets the property DatasetIdentifier. 
        /// <para>
        /// Specifies the identifier of the dataset from which to remove the KMS key association.
        /// For the <c>default</c> dataset, you can specify either <c>default</c> or the full
        /// dataset Amazon Resource Name (ARN) in the format <c>arn:aws:cloudwatch:<i>Region</i>:<i>account-id</i>:dataset/default</c>.
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