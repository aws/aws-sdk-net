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
    /// A structure for specifying the conditions under which the operations permitted by
    /// the grant are allowed.
    /// 
    ///  
    /// <para>
    /// You can use this structure to allow the operations permitted by the grant only when
    /// a specified encryption context is present. For more information about encryption context,
    /// see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/encryption-context.html">Encryption
    /// Context</a> in the <i>AWS Key Management Service Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class GrantConstraints
    {
        private Dictionary<string, string> _encryptionContextEquals = new Dictionary<string, string>();
        private Dictionary<string, string> _encryptionContextSubset = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property EncryptionContextEquals. 
        /// <para>
        /// Contains a list of key-value pairs that must be present in the encryption context
        /// of a subsequent operation permitted by the grant. When a subsequent operation permitted
        /// by the grant includes an encryption context that matches this list, the grant allows
        /// the operation. Otherwise, the operation is not allowed.
        /// </para>
        /// </summary>
        public Dictionary<string, string> EncryptionContextEquals
        {
            get { return this._encryptionContextEquals; }
            set { this._encryptionContextEquals = value; }
        }

        // Check to see if EncryptionContextEquals property is set
        internal bool IsSetEncryptionContextEquals()
        {
            return this._encryptionContextEquals != null && this._encryptionContextEquals.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EncryptionContextSubset. 
        /// <para>
        /// Contains a list of key-value pairs, a subset of which must be present in the encryption
        /// context of a subsequent operation permitted by the grant. When a subsequent operation
        /// permitted by the grant includes an encryption context that matches this list or is
        /// a subset of this list, the grant allows the operation. Otherwise, the operation is
        /// not allowed.
        /// </para>
        /// </summary>
        public Dictionary<string, string> EncryptionContextSubset
        {
            get { return this._encryptionContextSubset; }
            set { this._encryptionContextSubset = value; }
        }

        // Check to see if EncryptionContextSubset property is set
        internal bool IsSetEncryptionContextSubset()
        {
            return this._encryptionContextSubset != null && this._encryptionContextSubset.Count > 0; 
        }

    }
}