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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Specifies the method used to encrypt the user’s data stores in the Athena workgroup.
    /// </summary>
    public partial class AwsAthenaWorkGroupConfigurationResultConfigurationEncryptionConfigurationDetails
    {
        private string _encryptionOption;
        private string _kmsKey;

        /// <summary>
        /// Gets and sets the property EncryptionOption. 
        /// <para>
        ///  Indicates whether Amazon Simple Storage Service (Amazon S3) server-side encryption
        /// with Amazon S3 managed keys (SSE_S3), server-side encryption with KMS keys (SSE_KMS),
        /// or client-side encryption with KMS customer managed keys (CSE_KMS) is used. 
        /// </para>
        /// </summary>
        public string EncryptionOption
        {
            get { return this._encryptionOption; }
            set { this._encryptionOption = value; }
        }

        // Check to see if EncryptionOption property is set
        internal bool IsSetEncryptionOption()
        {
            return this._encryptionOption != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKey. 
        /// <para>
        ///  For <c>SSE_KMS</c> and <c>CSE_KMS</c>, this is the KMS key Amazon Resource Name (ARN)
        /// or ID. 
        /// </para>
        /// </summary>
        public string KmsKey
        {
            get { return this._kmsKey; }
            set { this._kmsKey = value; }
        }

        // Check to see if KmsKey property is set
        internal bool IsSetKmsKey()
        {
            return this._kmsKey != null;
        }

    }
}