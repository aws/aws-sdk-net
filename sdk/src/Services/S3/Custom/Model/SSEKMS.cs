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

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.S3.Model
{
    /// <summary>
    /// SSEKMS class
    /// </summary>
    public class SSEKMS
    {
        private string keyId;

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// Specifies the ID of the Amazon Web Services Key Management Service (Amazon Web Services
        /// KMS) symmetric encryption customer managed key to use for encrypting inventory reports.
        /// </para>
        /// </summary>
        public string KeyId
        {
            get { return this.keyId; }
            set { this.keyId = value; }
        }

        // Check to see if KeyId property is set
        internal bool IsSetKeyId()
        {
            return this.keyId != null;
        }

    }
}
