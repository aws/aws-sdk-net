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
    /// Container for the parameters to the AssociateDatasetKmsKey operation.
    /// Associates an Amazon Web Services Key Management Service (Amazon Web Services KMS)
    /// customer managed key with the specified dataset. After this operation completes, all
    /// data published to the dataset is encrypted at rest using the specified KMS key. Callers
    /// must have <c>kms:Decrypt</c> permission on the key to read the encrypted data.
    /// 
    ///  
    /// <para>
    /// Only the <c>default</c> dataset is supported. The <c>default</c> dataset is implicit
    /// for every account in every Region — you do not need to create it before calling this
    /// operation.
    /// </para>
    ///  
    /// <para>
    /// You can call <c>AssociateDatasetKmsKey</c> on a dataset that is already associated
    /// with a KMS key to replace the existing key with a different one. To replace a key,
    /// the caller must have <c>kms:Decrypt</c> permission on both the current key and the
    /// new key.
    /// </para>
    ///  
    /// <para>
    /// The KMS key that you specify must meet all of the following requirements:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// It must be a symmetric encryption KMS key (key spec <c>SYMMETRIC_DEFAULT</c>, key
    /// usage <c>ENCRYPT_DECRYPT</c>). Asymmetric keys, HMAC keys, and key material types
    /// other than <c>SYMMETRIC_DEFAULT</c> are not supported.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// It must be enabled and not pending deletion.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Its key policy must grant the CloudWatch service principal (<c>cloudwatch.amazonaws.com</c>)
    /// these permissions: <c>kms:DescribeKey</c>, <c>kms:GenerateDataKey</c>, <c>kms:Encrypt</c>,
    /// <c>kms:Decrypt</c>, and <c>kms:ReEncrypt*</c>. Amazon CloudWatch requires these permissions
    /// to manage the data on your behalf.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The calling principal must have <c>kms:Decrypt</c> permission on the key.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// It must be specified as a fully qualified key ARN. Key IDs, aliases, and alias ARNs
    /// are not accepted.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// It must be in the same Amazon Web Services Region as the dataset.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Before completing the association, Amazon CloudWatch validates the key by performing
    /// a series of dry-run KMS operations. Service-principal checks run first to verify that
    /// the key policy grants the required access to Amazon CloudWatch. These checks include
    /// <c>kms:DescribeKey</c>, <c>kms:GenerateDataKey</c>, <c>kms:Encrypt</c>, <c>kms:Decrypt</c>,
    /// and <c>kms:ReEncrypt*</c>. After those succeed, a <c>kms:Decrypt</c> dry-run is run
    /// with the caller's credentials to verify that the calling principal can use the key.
    /// When you are replacing an existing key, the caller's <c>kms:Decrypt</c> dry-run is
    /// run on the current key first, and only then on the new key.
    /// </para>
    ///  
    /// <para>
    /// If any of these checks fails, the operation fails and the existing key association
    /// (if any) remains unchanged. Common failure causes include the key being disabled,
    /// the key policy not granting the required permissions to Amazon CloudWatch, or the
    /// caller lacking <c>kms:Decrypt</c> permission on the key.
    /// </para>
    ///  
    /// <para>
    /// For more information about using customer managed keys with Amazon CloudWatch, see
    /// <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/cmk-encryption.html">Encryption
    /// at rest with customer managed keys</a> in the <i>Amazon CloudWatch User Guide</i>.
    /// </para>
    /// </summary>
    public partial class AssociateDatasetKmsKeyRequest : AmazonCloudWatchRequest
    {
        private string _datasetIdentifier;
        private string _kmsKeyArn;

        /// <summary>
        /// Gets and sets the property DatasetIdentifier. 
        /// <para>
        /// Specifies the identifier of the dataset that you want to associate the KMS key with.
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

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// Specifies the Amazon Resource Name (ARN) of the customer managed KMS key to associate
        /// with the dataset. The key must be a symmetric encryption KMS key (<c>SYMMETRIC_DEFAULT</c>)
        /// in the same Amazon Web Services Region as the dataset.
        /// </para>
        ///  
        /// <para>
        /// The ARN must be in the format <c>arn:aws:kms:<i>Region</i>:<i>account-id</i>:key/<i>key-id</i>
        /// </c>. Key IDs, aliases, and alias ARNs are not accepted.
        /// </para>
        ///  
        /// <para>
        /// For more information about KMS key ARNs, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#key-id-key-ARN">Key
        /// ARN</a> in the <i>Amazon Web Services Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string KmsKeyArn
        {
            get { return this._kmsKeyArn; }
            set { this._kmsKeyArn = value; }
        }

        // Check to see if KmsKeyArn property is set
        internal bool IsSetKmsKeyArn()
        {
            return this._kmsKeyArn != null;
        }

    }
}