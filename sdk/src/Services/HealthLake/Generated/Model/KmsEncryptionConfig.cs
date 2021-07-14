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
 * Do not modify this file. This file is generated from the healthlake-2017-07-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.HealthLake.Model
{
    /// <summary>
    /// The customer-managed-key(CMK) used when creating a Data Store. If a customer owned
    /// key is not specified, an AWS owned key will be used for encryption.
    /// </summary>
    public partial class KmsEncryptionConfig
    {
        private CmkType _cmkType;
        private string _kmsKeyId;

        /// <summary>
        /// Gets and sets the property CmkType. 
        /// <para>
        ///  The type of customer-managed-key(CMK) used for encyrption. The two types of supported
        /// CMKs are customer owned CMKs and AWS owned CMKs. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CmkType CmkType
        {
            get { return this._cmkType; }
            set { this._cmkType = value; }
        }

        // Check to see if CmkType property is set
        internal bool IsSetCmkType()
        {
            return this._cmkType != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        ///  The KMS encryption key id/alias used to encrypt the Data Store contents at rest.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=400)]
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