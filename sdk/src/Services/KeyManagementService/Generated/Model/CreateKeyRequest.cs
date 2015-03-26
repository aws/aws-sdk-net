/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the kms-2014-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// Container for the parameters to the CreateKey operation.
    /// Creates a customer master key. Customer master keys can be used to encrypt small amounts
    /// of data (less than 4K) directly, but they are most commonly used to encrypt or envelope
    /// data keys that are then used to encrypt customer data. For more information about
    /// data keys, see <a>GenerateDataKey</a> and <a>GenerateDataKeyWithoutPlaintext</a>.
    /// </summary>
    public partial class CreateKeyRequest : AmazonKeyManagementServiceRequest
    {
        private string _description;
        private KeyUsageType _keyUsage;
        private string _policy;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Description of the key. We recommend that you choose a description that helps your
        /// customer decide whether the key is appropriate for a task. 
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property KeyUsage. 
        /// <para>
        /// Specifies the intended use of the key. Currently this defaults to ENCRYPT/DECRYPT,
        /// and only symmetric encryption and decryption are supported. 
        /// </para>
        /// </summary>
        public KeyUsageType KeyUsage
        {
            get { return this._keyUsage; }
            set { this._keyUsage = value; }
        }

        // Check to see if KeyUsage property is set
        internal bool IsSetKeyUsage()
        {
            return this._keyUsage != null;
        }

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// Policy to be attached to the key. This is required and delegates back to the account.
        /// The key is the root of trust. 
        /// </para>
        /// </summary>
        public string Policy
        {
            get { return this._policy; }
            set { this._policy = value; }
        }

        // Check to see if Policy property is set
        internal bool IsSetPolicy()
        {
            return this._policy != null;
        }

    }
}