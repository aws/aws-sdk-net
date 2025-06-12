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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
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
namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Represents the DKIM attributes of a verified email address or a domain.
    /// </summary>
    public partial class IdentityDkimAttributes
    {
        private bool? _dkimEnabled;
        private List<string> _dkimTokens = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private VerificationStatus _dkimVerificationStatus;

        /// <summary>
        /// Gets and sets the property DkimEnabled. 
        /// <para>
        /// Is true if DKIM signing is enabled for email sent from the identity. It's false otherwise.
        /// The default value is true.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? DkimEnabled
        {
            get { return this._dkimEnabled; }
            set { this._dkimEnabled = value; }
        }

        // Check to see if DkimEnabled property is set
        internal bool IsSetDkimEnabled()
        {
            return this._dkimEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DkimTokens. 
        /// <para>
        /// A set of character strings that represent the domain's identity. Using these tokens,
        /// you need to create DNS CNAME records that point to DKIM public keys that are hosted
        /// by Amazon SES. Amazon Web Services eventually detects that you've updated your DNS
        /// records. This detection process might take up to 72 hours. After successful detection,
        /// Amazon SES is able to DKIM-sign email originating from that domain. (This only applies
        /// to domain identities, not email address identities.)
        /// </para>
        ///  
        /// <para>
        /// For more information about creating DNS records using DKIM tokens, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/send-email-authentication-dkim-easy.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DkimTokens
        {
            get { return this._dkimTokens; }
            set { this._dkimTokens = value; }
        }

        // Check to see if DkimTokens property is set
        internal bool IsSetDkimTokens()
        {
            return this._dkimTokens != null && (this._dkimTokens.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DkimVerificationStatus. 
        /// <para>
        /// Describes whether Amazon SES has successfully verified the DKIM DNS records (tokens)
        /// published in the domain name's DNS. (This only applies to domain identities, not email
        /// address identities.)
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VerificationStatus DkimVerificationStatus
        {
            get { return this._dkimVerificationStatus; }
            set { this._dkimVerificationStatus = value; }
        }

        // Check to see if DkimVerificationStatus property is set
        internal bool IsSetDkimVerificationStatus()
        {
            return this._dkimVerificationStatus != null;
        }

    }
}