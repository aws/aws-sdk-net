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
    /// Container for the parameters to the DeleteImportedKeyMaterial operation.
    /// Deletes key material that you previously imported and makes the specified customer
    /// master key (CMK) unusable. For more information about importing key material into
    /// AWS KMS, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">Importing
    /// Key Material</a> in the <i>AWS Key Management Service Developer Guide</i>.
    /// 
    ///  
    /// <para>
    /// When the specified CMK is in the <code>PendingDeletion</code> state, this operation
    /// does not change the CMK's state. Otherwise, it changes the CMK's state to <code>PendingImport</code>.
    /// </para>
    ///  
    /// <para>
    /// After you delete key material, you can use <a>ImportKeyMaterial</a> to reimport the
    /// same key material into the CMK.
    /// </para>
    /// </summary>
    public partial class DeleteImportedKeyMaterialRequest : AmazonKeyManagementServiceRequest
    {
        private string _keyId;

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// The identifier of the CMK whose key material to delete. The CMK's <code>Origin</code>
        /// must be <code>EXTERNAL</code>.
        /// </para>
        ///  
        /// <para>
        /// A valid identifier is the unique key ID or the Amazon Resource Name (ARN) of the CMK.
        /// Examples:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Unique key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key ARN: <code>arn:aws:kms:us-west-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string KeyId
        {
            get { return this._keyId; }
            set { this._keyId = value; }
        }

        // Check to see if KeyId property is set
        internal bool IsSetKeyId()
        {
            return this._keyId != null;
        }

    }
}