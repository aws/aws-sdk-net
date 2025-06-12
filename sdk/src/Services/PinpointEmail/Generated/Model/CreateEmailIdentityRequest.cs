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
 * Do not modify this file. This file is generated from the pinpoint-email-2018-07-26.normal.json service model.
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
namespace Amazon.PinpointEmail.Model
{
    /// <summary>
    /// Container for the parameters to the CreateEmailIdentity operation.
    /// Verifies an email identity for use with Amazon Pinpoint. In Amazon Pinpoint, an identity
    /// is an email address or domain that you use when you send email. Before you can use
    /// an identity to send email with Amazon Pinpoint, you first have to verify it. By verifying
    /// an address, you demonstrate that you're the owner of the address, and that you've
    /// given Amazon Pinpoint permission to send email from the address.
    /// 
    ///  
    /// <para>
    /// When you verify an email address, Amazon Pinpoint sends an email to the address. Your
    /// email address is verified as soon as you follow the link in the verification email.
    /// 
    /// </para>
    ///  
    /// <para>
    /// When you verify a domain, this operation provides a set of DKIM tokens, which you
    /// can convert into CNAME tokens. You add these CNAME tokens to the DNS configuration
    /// for your domain. Your domain is verified when Amazon Pinpoint detects these records
    /// in the DNS configuration for your domain. It usually takes around 72 hours to complete
    /// the domain verification process.
    /// </para>
    /// </summary>
    public partial class CreateEmailIdentityRequest : AmazonPinpointEmailRequest
    {
        private string _emailIdentity;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property EmailIdentity. 
        /// <para>
        /// The email address or domain that you want to verify.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EmailIdentity
        {
            get { return this._emailIdentity; }
            set { this._emailIdentity = value; }
        }

        // Check to see if EmailIdentity property is set
        internal bool IsSetEmailIdentity()
        {
            return this._emailIdentity != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of objects that define the tags (keys and values) that you want to associate
        /// with the email identity.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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