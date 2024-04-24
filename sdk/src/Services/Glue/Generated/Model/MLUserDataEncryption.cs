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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// The encryption-at-rest settings of the transform that apply to accessing user data.
    /// </summary>
    public partial class MLUserDataEncryption
    {
        private string _kmsKeyId;
        private MLUserDataEncryptionModeString _mlUserDataEncryptionMode;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ID for the customer-provided KMS key.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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

        /// <summary>
        /// Gets and sets the property MlUserDataEncryptionMode. 
        /// <para>
        /// The encryption mode applied to user data. Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// DISABLED: encryption is disabled
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSEKMS: use of server-side encryption with Key Management Service (SSE-KMS) for user
        /// data stored in Amazon S3.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public MLUserDataEncryptionModeString MlUserDataEncryptionMode
        {
            get { return this._mlUserDataEncryptionMode; }
            set { this._mlUserDataEncryptionMode = value; }
        }

        // Check to see if MlUserDataEncryptionMode property is set
        internal bool IsSetMlUserDataEncryptionMode()
        {
            return this._mlUserDataEncryptionMode != null;
        }

    }
}