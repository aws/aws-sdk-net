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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The security configuration for <c>OnlineStore</c>.
    /// </summary>
    public partial class OnlineStoreSecurityConfig
    {
        private string _kmsKeyId;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Amazon Web Services Key Management Service (KMS) key ARN that SageMaker Feature
        /// Store uses to encrypt the Amazon S3 objects at rest using Amazon S3 server-side encryption.
        /// </para>
        ///  
        /// <para>
        /// The caller (either user or IAM role) of <c>CreateFeatureGroup</c> must have below
        /// permissions to the <c>OnlineStore</c> <c>KmsKeyId</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>"kms:Encrypt"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"kms:Decrypt"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"kms:DescribeKey"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"kms:CreateGrant"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"kms:RetireGrant"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"kms:ReEncryptFrom"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"kms:ReEncryptTo"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"kms:GenerateDataKey"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"kms:ListAliases"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"kms:ListGrants"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"kms:RevokeGrant"</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The caller (either user or IAM role) to all DataPlane operations (<c>PutRecord</c>,
        /// <c>GetRecord</c>, <c>DeleteRecord</c>) must have the following permissions to the
        /// <c>KmsKeyId</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>"kms:Decrypt"</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
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