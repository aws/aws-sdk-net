/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// <para>Represents the DKIM attributes of a verified email address or a domain.</para>
    /// </summary>
    public class IdentityDkimAttributes
    {
        
        private bool? dkimEnabled;
        private VerificationStatus dkimVerificationStatus;
        private List<string> dkimTokens = new List<string>();

        /// <summary>
        /// True if DKIM signing is enabled for email sent from the identity; false otherwise.
        ///  
        /// </summary>
        public bool DkimEnabled
        {
            get { return this.dkimEnabled ?? default(bool); }
            set { this.dkimEnabled = value; }
        }

        // Check to see if DkimEnabled property is set
        internal bool IsSetDkimEnabled()
        {
            return this.dkimEnabled.HasValue;
        }

        /// <summary>
        /// Describes whether Amazon SES has successfully verified the DKIM DNS records (tokens) published in the domain name's DNS. (This only applies
        /// to domain identities, not email address identities.)
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>Pending, Success, Failed, TemporaryFailure, NotStarted</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public VerificationStatus DkimVerificationStatus
        {
            get { return this.dkimVerificationStatus; }
            set { this.dkimVerificationStatus = value; }
        }

        // Check to see if DkimVerificationStatus property is set
        internal bool IsSetDkimVerificationStatus()
        {
            return this.dkimVerificationStatus != null;
        }

        /// <summary>
        /// A set of character strings that represent the domain's identity. Using these tokens, you will need to create DNS CNAME records that point to
        /// DKIM public keys hosted by Amazon SES. Amazon Web Services will eventually detect that you have updated your DNS records; this detection
        /// process may take up to 72 hours. Upon successful detection, Amazon SES will be able to DKIM-sign email originating from that domain. (This
        /// only applies to domain identities, not email address identities.) For more information about creating DNS records using DKIM tokens, go to
        /// the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/easy-dkim-dns-records.html">Amazon SES Developer Guide</a>.
        ///  
        /// </summary>
        public List<string> DkimTokens
        {
            get { return this.dkimTokens; }
            set { this.dkimTokens = value; }
        }

        // Check to see if DkimTokens property is set
        internal bool IsSetDkimTokens()
        {
            return this.dkimTokens.Count > 0;
        }
    }
}
