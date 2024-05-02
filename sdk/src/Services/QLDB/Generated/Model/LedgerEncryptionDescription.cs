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
 * Do not modify this file. This file is generated from the qldb-2019-01-02.normal.json service model.
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
namespace Amazon.QLDB.Model
{
    /// <summary>
    /// Information about the encryption of data at rest in an Amazon QLDB ledger. This includes
    /// the current status, the key in Key Management Service (KMS), and when the key became
    /// inaccessible (in the case of an error).
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/qldb/latest/developerguide/encryption-at-rest.html">Encryption
    /// at rest</a> in the <i>Amazon QLDB Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class LedgerEncryptionDescription
    {
        private EncryptionStatus _encryptionStatus;
        private DateTime? _inaccessibleKmsKeyDateTime;
        private string _kmsKeyArn;

        /// <summary>
        /// Gets and sets the property EncryptionStatus. 
        /// <para>
        /// The current state of encryption at rest for the ledger. This can be one of the following
        /// values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ENABLED</c>: Encryption is fully enabled using the specified key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATING</c>: The ledger is actively processing the specified key change.
        /// </para>
        ///  
        /// <para>
        /// Key changes in QLDB are asynchronous. The ledger is fully accessible without any performance
        /// impact while the key change is being processed. The amount of time it takes to update
        /// a key varies depending on the ledger size.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>KMS_KEY_INACCESSIBLE</c>: The specified customer managed KMS key is not accessible,
        /// and the ledger is impaired. Either the key was disabled or deleted, or the grants
        /// on the key were revoked. When a ledger is impaired, it is not accessible and does
        /// not accept any read or write requests.
        /// </para>
        ///  
        /// <para>
        /// An impaired ledger automatically returns to an active state after you restore the
        /// grants on the key, or re-enable the key that was disabled. However, deleting a customer
        /// managed KMS key is irreversible. After a key is deleted, you can no longer access
        /// the ledgers that are protected with that key, and the data becomes unrecoverable permanently.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public EncryptionStatus EncryptionStatus
        {
            get { return this._encryptionStatus; }
            set { this._encryptionStatus = value; }
        }

        // Check to see if EncryptionStatus property is set
        internal bool IsSetEncryptionStatus()
        {
            return this._encryptionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property InaccessibleKmsKeyDateTime. 
        /// <para>
        /// The date and time, in epoch time format, when the KMS key first became inaccessible,
        /// in the case of an error. (Epoch time format is the number of seconds that have elapsed
        /// since 12:00:00 AM January 1, 1970 UTC.)
        /// </para>
        ///  
        /// <para>
        /// This parameter is undefined if the KMS key is accessible.
        /// </para>
        /// </summary>
        public DateTime? InaccessibleKmsKeyDateTime
        {
            get { return this._inaccessibleKmsKeyDateTime; }
            set { this._inaccessibleKmsKeyDateTime = value; }
        }

        // Check to see if InaccessibleKmsKeyDateTime property is set
        internal bool IsSetInaccessibleKmsKeyDateTime()
        {
            return this._inaccessibleKmsKeyDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the customer managed KMS key that the ledger uses
        /// for encryption at rest. If this parameter is undefined, the ledger uses an Amazon
        /// Web Services owned KMS key for encryption. It will display <c>AWS_OWNED_KMS_KEY</c>
        /// when updating the ledger's encryption configuration to the Amazon Web Services owned
        /// KMS key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=1600)]
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