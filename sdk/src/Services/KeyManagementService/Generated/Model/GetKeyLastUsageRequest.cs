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
 * Do not modify this file. This file is generated from the kms-2014-11-01.normal.json service model.
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
namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// Container for the parameters to the GetKeyLastUsage operation.
    /// Returns usage information about the last successful cryptographic operation performed
    /// with a specified KMS key, including the operation type, timestamp, and associated
    /// CloudTrail event ID.
    /// 
    ///  
    /// <para>
    /// The <c>TrackingStartDate</c> in the <c>GetKeyLastUsage</c> response indicates the
    /// date from which KMS began recording cryptographic activity for a given key. Use this
    /// value together with <c>KeyCreationDate</c> to understand the key's usage history:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If the <c>KeyLastUsage</c> response element is <i>present</i>, the key has been used
    /// for a successful cryptographic operation since the <c>TrackingStartDate</c>. The response
    /// includes the operation type, timestamp, and associated CloudTrail event ID.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the <c>KeyLastUsage</c> response element is <i>empty</i> and <c>KeyCreationDate</c>
    /// is on or after <c>TrackingStartDate</c>, the key has not been used for a successful
    /// cryptographic operation since it was created.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the <c>KeyLastUsage</c> response element is <i>empty</i> and <c>KeyCreationDate</c>
    /// is before <c>TrackingStartDate</c>, there is no record of the key being used for a
    /// successful cryptographic operation since the <c>TrackingStartDate</c>. However, the
    /// key may have been used before tracking began. To determine whether the key was used
    /// before the <c>TrackingStartDate</c>, examine your past CloudTrail logs.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For multi-Region KMS keys, primary and replica keys track last usage independently.
    /// Each key in a multi-Region key set maintains its own usage information.
    /// </para>
    ///  
    /// <para>
    /// The <c>ReEncrypt</c> operation uses two keys: a source key for decryption and a destination
    /// key for encryption. Usage information is recorded for both keys independently, each
    /// with the CloudTrail event ID from the respective key owner's account.
    /// </para>
    ///  <note> 
    /// <para>
    /// Do not use <c>GetKeyLastUsage</c> as the sole indicator when scheduling a key for
    /// deletion. Instead, first <a href="https://docs.aws.amazon.com/kms/latest/developerguide/enabling-keys.html">disable
    /// the key</a> and monitor CloudTrail for <c>DisabledException</c> entries, as there
    /// could be infrequent workflows that are dependent on the key. By looking for this exception,
    /// you can identify potential dependencies and workload failures before they occur.
    /// </para>
    ///  </note> 
    /// <para>
    ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
    /// different Amazon Web Services account.
    /// </para>
    ///  
    /// <para>
    ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:GetKeyLastUsage</a>
    /// (key policy)
    /// </para>
    ///  
    /// <para>
    ///  <b>Related operations:</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>DescribeKey</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DisableKey</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ScheduleKeyDeletion</a> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
    /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
    /// eventual consistency</a>.
    /// </para>
    /// </summary>
    public partial class GetKeyLastUsageRequest : AmazonKeyManagementServiceRequest
    {
        private string _keyId;

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// Identifies the KMS key to get usage information for. To specify a KMS key, use its
        /// key ID or key ARN. Alias names are not supported.
        /// </para>
        ///  
        /// <para>
        /// Specify the key ID or key ARN of the KMS key.
        /// </para>
        ///  
        /// <para>
        /// For example:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Key ID: <c>1234abcd-12ab-34cd-56ef-1234567890ab</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key ARN: <c>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To get the key ID and key ARN for a KMS key, use <a>ListKeys</a> or <a>DescribeKey</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
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