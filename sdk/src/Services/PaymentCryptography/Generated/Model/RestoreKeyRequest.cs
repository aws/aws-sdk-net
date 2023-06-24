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
 * Do not modify this file. This file is generated from the payment-cryptography-2021-09-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.PaymentCryptography.Model
{
    /// <summary>
    /// Container for the parameters to the RestoreKey operation.
    /// Cancels a scheduled key deletion during the waiting period. Use this operation to
    /// restore a <code>Key</code> that is scheduled for deletion.
    /// 
    ///  
    /// <para>
    /// During the waiting period, the <code>KeyState</code> is <code>DELETE_PENDING</code>
    /// and <code>deletePendingTimestamp</code> contains the date and time after which the
    /// <code>Key</code> will be deleted. After <code>Key</code> is restored, the <code>KeyState</code>
    /// is <code>CREATE_COMPLETE</code>, and the value for <code>deletePendingTimestamp</code>
    /// is removed.
    /// </para>
    ///  
    /// <para>
    ///  <b>Cross-account use:</b> This operation can't be used across different Amazon Web
    /// Services accounts.
    /// </para>
    ///  
    /// <para>
    ///  <b>Related operations:</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>DeleteKey</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>StartKeyUsage</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>StopKeyUsage</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class RestoreKeyRequest : AmazonPaymentCryptographyRequest
    {
        private string _keyIdentifier;

        /// <summary>
        /// Gets and sets the property KeyIdentifier. 
        /// <para>
        /// The <code>KeyARN</code> of the key to be restored within Amazon Web Services Payment
        /// Cryptography.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=7, Max=322)]
        public string KeyIdentifier
        {
            get { return this._keyIdentifier; }
            set { this._keyIdentifier = value; }
        }

        // Check to see if KeyIdentifier property is set
        internal bool IsSetKeyIdentifier()
        {
            return this._keyIdentifier != null;
        }

    }
}