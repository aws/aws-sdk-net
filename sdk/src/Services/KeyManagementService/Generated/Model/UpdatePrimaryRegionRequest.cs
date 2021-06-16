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

namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// Container for the parameters to the UpdatePrimaryRegion operation.
    /// Changes the primary key of a multi-Region key. 
    /// 
    ///  
    /// <para>
    /// This operation changes the replica key in the specified Region to a primary key and
    /// changes the former primary key to a replica key. For example, suppose you have a primary
    /// key in <code>us-east-1</code> and a replica key in <code>eu-west-2</code>. If you
    /// run <code>UpdatePrimaryRegion</code> with a <code>PrimaryRegion</code> value of <code>eu-west-2</code>,
    /// the primary key is now the key in <code>eu-west-2</code>, and the key in <code>us-east-1</code>
    /// becomes a replica key. For details, see 
    /// </para>
    ///  
    /// <para>
    /// This operation supports <i>multi-Region keys</i>, an AWS KMS feature that lets you
    /// create multiple interoperable CMKs in different AWS Regions. Because these CMKs have
    /// the same key ID, key material, and other metadata, you can use them to encrypt data
    /// in one AWS Region and decrypt it in a different AWS Region without making a cross-Region
    /// call or exposing the plaintext data. For more information about multi-Region keys,
    /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/multi-region-keys-overview.html">Using
    /// multi-Region keys</a> in the <i>AWS Key Management Service Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// The <i>primary key</i> of a multi-Region key is the source for properties that are
    /// always shared by primary and replica keys, including the key material, <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#key-id-key-id">key
    /// ID</a>, <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#key-spec">key
    /// spec</a>, <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#key-usage">key
    /// usage</a>, <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#key-origin">key
    /// material origin</a>, and <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html">automatic
    /// key rotation</a>. It's the only key that can be replicated. You cannot <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_ScheduleKeyDeletion.html">delete
    /// the primary key</a> until all replicas are deleted.
    /// </para>
    ///  
    /// <para>
    /// The key ID and primary Region that you specify uniquely identify the replica key that
    /// will become the primary key. The primary Region must already have a replica key. This
    /// operation does not create a CMK in the specified Region. To find the replica keys,
    /// use the <a>DescribeKey</a> operation on the primary key or any replica key. To create
    /// a replica key, use the <a>ReplicateKey</a> operation.
    /// </para>
    ///  
    /// <para>
    /// You can run this operation while using the affected multi-Region keys in cryptographic
    /// operations. This operation should not delay, interrupt, or cause failures in cryptographic
    /// operations. 
    /// </para>
    ///  
    /// <para>
    /// Even after this operation completes, the process of updating the primary Region might
    /// still be in progress for a few more seconds. Operations such as <code>DescribeKey</code>
    /// might display both the old and new primary keys as replicas. The old and new primary
    /// keys have a transient key state of <code>Updating</code>. The original key state is
    /// restored when the update is complete. While the key state is <code>Updating</code>,
    /// you can use the keys in cryptographic operations, but you cannot replicate the new
    /// primary key or perform certain management operations, such as enabling or disabling
    /// these keys. For details about the <code>Updating</code> key state, see <a href="kms/latest/developerguide/key-state.html">Key
    /// state: Effect on your CMK</a> in the <i>AWS Key Management Service Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// This operation does not return any output. To verify that primary key is changed,
    /// use the <a>DescribeKey</a> operation.
    /// </para>
    ///  
    /// <para>
    ///  <b>Cross-account use</b>: No. You cannot use this operation in a different AWS account.
    /// 
    /// </para>
    ///  
    /// <para>
    ///  <b>Required permissions</b>: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>kms:UpdatePrimaryRegion</code> on the current primary CMK (in the primary CMK's
    /// Region). Include this permission primary CMK's key policy.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>kms:UpdatePrimaryRegion</code> on the current replica CMK (in the replica CMK's
    /// Region). Include this permission in the replica CMK's key policy.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Related operations</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateKey</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ReplicateKey</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class UpdatePrimaryRegionRequest : AmazonKeyManagementServiceRequest
    {
        private string _keyId;
        private string _primaryRegion;

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// Identifies the current primary key. When the operation completes, this CMK will be
        /// a replica key.
        /// </para>
        ///  
        /// <para>
        /// Specify the key ID or key ARN of a multi-Region primary key.
        /// </para>
        ///  
        /// <para>
        /// For example:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Key ID: <code>mrk-1234abcd12ab34cd56ef1234567890ab</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/mrk-1234abcd12ab34cd56ef1234567890ab</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.
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

        /// <summary>
        /// Gets and sets the property PrimaryRegion. 
        /// <para>
        /// The AWS Region of the new primary key. Enter the Region ID, such as <code>us-east-1</code>
        /// or <code>ap-southeast-2</code>. There must be an existing replica key in this Region.
        /// 
        /// </para>
        ///  
        /// <para>
        /// When the operation completes, the multi-Region key in this Region will be the primary
        /// key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public string PrimaryRegion
        {
            get { return this._primaryRegion; }
            set { this._primaryRegion = value; }
        }

        // Check to see if PrimaryRegion property is set
        internal bool IsSetPrimaryRegion()
        {
            return this._primaryRegion != null;
        }

    }
}