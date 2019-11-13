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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateEmailIdentity operation.
    /// Starts the process of verifying an email identity. An <i>identity</i> is an email
    /// address or domain that you use when you send email. Before you can use an identity
    /// to send email, you first have to verify it. By verifying an identity, you demonstrate
    /// that you're the owner of the identity, and that you've given Amazon SES API v2 permission
    /// to send email from the identity.
    /// 
    ///  
    /// <para>
    /// When you verify an email address, Amazon SES sends an email to the address. Your email
    /// address is verified as soon as you follow the link in the verification email. 
    /// </para>
    ///  
    /// <para>
    /// When you verify a domain, this operation provides a set of DKIM tokens, which you
    /// can convert into CNAME tokens. You add these CNAME tokens to the DNS configuration
    /// for your domain. Your domain is verified when Amazon SES detects these records in
    /// the DNS configuration for your domain. For some DNS providers, it can take 72 hours
    /// or more to complete the domain verification process.
    /// </para>
    /// </summary>
    public partial class CreateEmailIdentityRequest : AmazonSimpleEmailServiceV2Request
    {
        private string _emailIdentity;
        private List<Tag> _tags = new List<Tag>();

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
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}