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
    /// An object that contains information about the DKIM authentication status for an email
    /// identity.
    /// 
    ///  
    /// <para>
    /// Amazon SES determines the authentication status by searching for specific records
    /// in the DNS configuration for the domain. If you used <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/easy-dkim.html">Easy
    /// DKIM</a> to set up DKIM authentication, Amazon SES tries to find three unique CNAME
    /// records in the DNS configuration for your domain. If you provided a public key to
    /// perform DKIM authentication, Amazon SES tries to find a TXT record that uses the selector
    /// that you specified. The value of the TXT record must be a public key that's paired
    /// with the private key that you specified in the process of creating the identity
    /// </para>
    /// </summary>
    public partial class DkimAttributes
    {
        private DkimSigningAttributesOrigin _signingAttributesOrigin;
        private bool? _signingEnabled;
        private DkimStatus _status;
        private List<string> _tokens = new List<string>();

        /// <summary>
        /// Gets and sets the property SigningAttributesOrigin. 
        /// <para>
        /// A string that indicates how DKIM was configured for the identity. There are two possible
        /// values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>AWS_SES</code> – Indicates that DKIM was configured for the identity by using
        /// <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/easy-dkim.html">Easy
        /// DKIM</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>EXTERNAL</code> – Indicates that DKIM was configured for the identity by using
        /// Bring Your Own DKIM (BYODKIM).
        /// </para>
        ///  </li> </ul>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property SigningEnabled. 
        /// <para>
        /// If the value is <code>true</code>, then the messages that you send from the identity
        /// are signed using DKIM. If the value is <code>false</code>, then the messages that
        /// you send from the identity aren't DKIM-signed.
        /// </para>
        /// </summary>
        public bool SigningEnabled
        {
            get { return this._signingEnabled.GetValueOrDefault(); }
            set { this._signingEnabled = value; }
        }

        // Check to see if SigningEnabled property is set
        internal bool IsSetSigningEnabled()
        {
            return this._signingEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Describes whether or not Amazon SES has successfully located the DKIM records in the
        /// DNS records for the domain. The status can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>PENDING</code> – The verification process was initiated, but Amazon SES hasn't
        /// yet detected the DKIM records in the DNS configuration for the domain.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SUCCESS</code> – The verification process completed successfully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FAILED</code> – The verification process failed. This typically occurs when
        /// Amazon SES fails to find the DKIM records in the DNS configuration of the domain.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TEMPORARY_FAILURE</code> – A temporary issue is preventing Amazon SES from
        /// determining the DKIM authentication status of the domain.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NOT_STARTED</code> – The DKIM verification process hasn't been initiated for
        /// the domain.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DkimStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Tokens. 
        /// <para>
        /// If you used <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/easy-dkim.html">Easy
        /// DKIM</a> to configure DKIM authentication for the domain, then this object contains
        /// a set of unique strings that you use to create a set of CNAME records that you add
        /// to the DNS configuration for your domain. When Amazon SES detects these records in
        /// the DNS configuration for your domain, the DKIM authentication process is complete.
        /// </para>
        ///  
        /// <para>
        /// If you configured DKIM authentication for the domain by providing your own public-private
        /// key pair, then this object contains the selector for the public key.
        /// </para>
        ///  
        /// <para>
        /// Regardless of the DKIM authentication method you use, Amazon SES searches for the
        /// appropriate records in the DNS configuration of the domain for up to 72 hours.
        /// </para>
        /// </summary>
        public List<string> Tokens
        {
            get { return this._tokens; }
            set { this._tokens = value; }
        }

        // Check to see if Tokens property is set
        internal bool IsSetTokens()
        {
            return this._tokens != null && this._tokens.Count > 0; 
        }

    }
}