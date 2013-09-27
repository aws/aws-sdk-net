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
        private string dkimVerificationStatus;
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

        /// <summary>
        /// Sets the DkimEnabled property
        /// </summary>
        /// <param name="dkimEnabled">The value to set for the DkimEnabled property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public IdentityDkimAttributes WithDkimEnabled(bool dkimEnabled)
        {
            this.dkimEnabled = dkimEnabled;
            return this;
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
        ///         <description>Pending, Success, Failed, TemporaryFailure</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string DkimVerificationStatus
        {
            get { return this.dkimVerificationStatus; }
            set { this.dkimVerificationStatus = value; }
        }

        /// <summary>
        /// Sets the DkimVerificationStatus property
        /// </summary>
        /// <param name="dkimVerificationStatus">The value to set for the DkimVerificationStatus property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public IdentityDkimAttributes WithDkimVerificationStatus(string dkimVerificationStatus)
        {
            this.dkimVerificationStatus = dkimVerificationStatus;
            return this;
        }
            

        // Check to see if DkimVerificationStatus property is set
        internal bool IsSetDkimVerificationStatus()
        {
            return this.dkimVerificationStatus != null;       
        }

        /// <summary>
        /// A set of DNS records (tokens) that must be published in the domain name's DNS for DKIM verification to complete, and which must remain
        /// published in order for DKIM signing to succeed. The tokens are <c>CNAME</c> DNS records that point to DKIM public keys hosted by Amazon SES.
        /// (This only applies to domain entities, not email address identities.)
        ///  
        /// </summary>
        public List<string> DkimTokens
        {
            get { return this.dkimTokens; }
            set { this.dkimTokens = value; }
        }
        /// <summary>
        /// Adds elements to the DkimTokens collection
        /// </summary>
        /// <param name="dkimTokens">The values to add to the DkimTokens collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public IdentityDkimAttributes WithDkimTokens(params string[] dkimTokens)
        {
            foreach (string element in dkimTokens)
            {
                this.dkimTokens.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the DkimTokens collection
        /// </summary>
        /// <param name="dkimTokens">The values to add to the DkimTokens collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public IdentityDkimAttributes WithDkimTokens(IEnumerable<string> dkimTokens)
        {
            foreach (string element in dkimTokens)
            {
                this.dkimTokens.Add(element);
            }

            return this;
        }

        // Check to see if DkimTokens property is set
        internal bool IsSetDkimTokens()
        {
            return this.dkimTokens.Count > 0;       
        }
    }
}
