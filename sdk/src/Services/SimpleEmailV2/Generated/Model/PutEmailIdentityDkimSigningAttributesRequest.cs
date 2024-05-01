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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Container for the parameters to the PutEmailIdentityDkimSigningAttributes operation.
    /// Used to configure or change the DKIM authentication settings for an email domain identity.
    /// You can use this operation to do any of the following:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Update the signing attributes for an identity that uses Bring Your Own DKIM (BYODKIM).
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Update the key length that should be used for Easy DKIM.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Change from using no DKIM authentication to using Easy DKIM.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Change from using no DKIM authentication to using BYODKIM.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Change from using Easy DKIM to using BYODKIM.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Change from using BYODKIM to using Easy DKIM.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class PutEmailIdentityDkimSigningAttributesRequest : AmazonSimpleEmailServiceV2Request
    {
        private string _emailIdentity;
        private DkimSigningAttributes _signingAttributes;
        private DkimSigningAttributesOrigin _signingAttributesOrigin;

        /// <summary>
        /// Gets and sets the property EmailIdentity. 
        /// <para>
        /// The email identity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
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
        /// Gets and sets the property SigningAttributes. 
        /// <para>
        /// An object that contains information about the private key and selector that you want
        /// to use to configure DKIM for the identity for Bring Your Own DKIM (BYODKIM) for the
        /// identity, or, configures the key length to be used for <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/easy-dkim.html">Easy
        /// DKIM</a>.
        /// </para>
        /// </summary>
        public DkimSigningAttributes SigningAttributes
        {
            get { return this._signingAttributes; }
            set { this._signingAttributes = value; }
        }

        // Check to see if SigningAttributes property is set
        internal bool IsSetSigningAttributes()
        {
            return this._signingAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property SigningAttributesOrigin. 
        /// <para>
        /// The method to use to configure DKIM for the identity. There are the following possible
        /// values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AWS_SES</c> – Configure DKIM for the identity by using <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/easy-dkim.html">Easy
        /// DKIM</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EXTERNAL</c> – Configure DKIM for the identity by using Bring Your Own DKIM (BYODKIM).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public DkimSigningAttributesOrigin SigningAttributesOrigin
        {
            get { return this._signingAttributesOrigin; }
            set { this._signingAttributesOrigin = value; }
        }

        // Check to see if SigningAttributesOrigin property is set
        internal bool IsSetSigningAttributesOrigin()
        {
            return this._signingAttributesOrigin != null;
        }

    }
}