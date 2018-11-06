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
 * Do not modify this file. This file is generated from the pinpoint-email-2018-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.PinpointEmail.Model
{
    /// <summary>
    /// An object that contains information about the DKIM configuration for an email identity.
    /// </summary>
    public partial class DkimAttributes
    {
        private bool? _signingEnabled;
        private DkimStatus _status;
        private List<string> _tokens = new List<string>();

        /// <summary>
        /// Gets and sets the property SigningEnabled. 
        /// <para>
        /// If the value is <code>true</code>, then the messages that Amazon Pinpoint sends from
        /// the identity are DKIM-signed. If the value is <code>false</code>, then the messages
        /// that Amazon Pinpoint sends from the identity aren't DKIM-signed.
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
        /// Describes whether or not Amazon Pinpoint has successfully located the DKIM records
        /// in the DNS records for the domain. The status can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>PENDING</code> – Amazon Pinpoint hasn't yet located the DKIM records in the
        /// DNS configuration for the domain, but will continue to attempt to locate them.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SUCCESS</code> – Amazon Pinpoint located the DKIM records in the DNS configuration
        /// for the domain and determined that they're correct. Amazon Pinpoint can now send DKIM-signed
        /// email from the identity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FAILED</code> – Amazon Pinpoint was unable to locate the DKIM records in the
        /// DNS settings for the domain, and won't continue to search for them.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TEMPORARY_FAILURE</code> – A temporary issue occurred, which prevented Amazon
        /// Pinpoint from determining the DKIM status for the domain.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NOT_STARTED</code> – Amazon Pinpoint hasn't yet started searching for the DKIM
        /// records in the DKIM records for the domain.
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
        /// A set of unique strings that you use to create a set of CNAME records that you add
        /// to the DNS configuration for your domain. When Amazon Pinpoint detects these records
        /// in the DNS configuration for your domain, the DKIM authentication process is complete.
        /// Amazon Pinpoint usually detects these records within about 72 hours of adding them
        /// to the DNS configuration for your domain.
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