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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.PaymentCryptography.Model
{
    /// <summary>
    /// Container for the parameters to the TagResource operation.
    /// Adds or edits tags on an Amazon Web Services Payment Cryptography key.
    /// 
    ///  <note> 
    /// <para>
    /// Tagging or untagging an Amazon Web Services Payment Cryptography key can allow or
    /// deny permission to the key.
    /// </para>
    ///  </note> 
    /// <para>
    /// Each tag consists of a tag key and a tag value, both of which are case-sensitive strings.
    /// The tag value can be an empty (null) string. To add a tag, specify a new tag key and
    /// a tag value. To edit a tag, specify an existing tag key and a new tag value. You can
    /// also add tags to an Amazon Web Services Payment Cryptography key when you create it
    /// with <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_CreateKey.html">CreateKey</a>.
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
    ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ListTagsForResource.html">ListTagsForResource</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_UntagResource.html">UntagResource</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class TagResourceRequest : AmazonPaymentCryptographyRequest
    {
        private string _resourceArn;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The <c>KeyARN</c> of the key whose tags are being updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=70, Max=150)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// One or more tags. Each tag consists of a tag key and a tag value. The tag value can
        /// be an empty (null) string. You can't have more than one tag on an Amazon Web Services
        /// Payment Cryptography key with the same tag key. If you specify an existing tag key
        /// with a different tag value, Amazon Web Services Payment Cryptography replaces the
        /// current tag value with the new one.
        /// </para>
        ///  <important> 
        /// <para>
        /// Don't include personal, confidential or sensitive information in this field. This
        /// field may be displayed in plaintext in CloudTrail logs and other output.
        /// </para>
        ///  </important> 
        /// <para>
        /// To use this parameter, you must have <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_TagResource.html">TagResource</a>
        /// permission in an IAM policy.
        /// </para>
        ///  <important> 
        /// <para>
        /// Don't include personal, confidential or sensitive information in this field. This
        /// field may be displayed in plaintext in CloudTrail logs and other output.
        /// </para>
        ///  </important>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}