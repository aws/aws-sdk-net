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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The security configuration for <code>OnlineStore</code>.
    /// </summary>
    public partial class OnlineStoreSecurityConfig
    {
        private string _kmsKeyId;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ID of the Amazon Web Services Key Management Service (Amazon Web Services KMS)
        /// key that SageMaker Feature Store uses to encrypt the Amazon S3 objects at rest using
        /// Amazon S3 server-side encryption.
        /// </para>
        ///  
        /// <para>
        /// The caller (either IAM user or IAM role) of <code>CreateFeatureGroup</code> must have
        /// below permissions to the <code>OnlineStore</code> <code>KmsKeyId</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>"kms:Encrypt"</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>"kms:Decrypt"</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>"kms:DescribeKey"</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>"kms:CreateGrant"</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>"kms:RetireGrant"</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>"kms:ReEncryptFrom"</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>"kms:ReEncryptTo"</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>"kms:GenerateDataKey"</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>"kms:ListAliases"</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>"kms:ListGrants"</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>"kms:RevokeGrant"</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The caller (either user or IAM role) to all DataPlane operations (<code>PutRecord</code>,
        /// <code>GetRecord</code>, <code>DeleteRecord</code>) must have the following permissions
        /// to the <code>KmsKeyId</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>"kms:Decrypt"</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

    }
}