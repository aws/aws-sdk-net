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
    /// Container for the parameters to the UntagResource operation.
    /// Deletes tags from a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#customer-cmk">customer
    /// managed key</a>. To delete a tag, specify the tag key and the KMS key.
    /// 
    ///  <note> 
    /// <para>
    /// Tagging or untagging a KMS key can allow or deny permission to the KMS key. For details,
    /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/abac.html">ABAC
    /// for KMS</a> in the <i>Key Management Service Developer Guide</i>.
    /// </para>
    ///  </note> 
    /// <para>
    /// When it succeeds, the <code>UntagResource</code> operation doesn't return any output.
    /// Also, if the specified tag key isn't found on the KMS key, it doesn't throw an exception
    /// or return a response. To confirm that the operation worked, use the <a>ListResourceTags</a>
    /// operation.
    /// </para>
    ///  
    /// <para>
    /// For information about using tags in KMS, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/tagging-keys.html">Tagging
    /// keys</a>. For general information about tags, including the format and syntax, see
    /// <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging Amazon
    /// Web Services resources</a> in the <i>Amazon Web Services General Reference</i>. 
    /// </para>
    ///  
    /// <para>
    /// The KMS key that you use for this operation must be in a compatible key state. For
    /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
    /// states of KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
    /// different Amazon Web Services account.
    /// </para>
    ///  
    /// <para>
    ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:UntagResource</a>
    /// (key policy)
    /// </para>
    ///  
    /// <para>
    ///  <b>Related operations</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateKey</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListResourceTags</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ReplicateKey</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>TagResource</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class UntagResourceRequest : AmazonKeyManagementServiceRequest
    {
        private string _keyId;
        private List<string> _tagKeys = new List<string>();

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// Identifies the KMS key from which you are removing tags.
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
        /// Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>
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

        /// <summary>
        /// Gets and sets the property TagKeys. 
        /// <para>
        /// One or more tag keys. Specify only the tag keys, not the tag values.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> TagKeys
        {
            get { return this._tagKeys; }
            set { this._tagKeys = value; }
        }

        // Check to see if TagKeys property is set
        internal bool IsSetTagKeys()
        {
            return this._tagKeys != null && this._tagKeys.Count > 0; 
        }

    }
}