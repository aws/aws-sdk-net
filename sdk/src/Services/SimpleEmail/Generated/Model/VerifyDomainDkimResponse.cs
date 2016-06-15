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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Returns CNAME records that you must publish to the DNS server of your domain to set
    /// up Easy DKIM with Amazon SES.
    /// </summary>
    public partial class VerifyDomainDkimResponse : AmazonWebServiceResponse
    {
        private List<string> _dkimTokens = new List<string>();

        /// <summary>
        /// Gets and sets the property DkimTokens. 
        /// <para>
        /// A set of character strings that represent the domain's identity. If the identity is
        /// an email address, the tokens represent the domain of that address.
        /// </para>
        ///  
        /// <para>
        /// Using these tokens, you will need to create DNS CNAME records that point to DKIM public
        /// keys hosted by Amazon SES. Amazon Web Services will eventually detect that you have
        /// updated your DNS records; this detection process may take up to 72 hours. Upon successful
        /// detection, Amazon SES will be able to DKIM-sign emails originating from that domain.
        /// </para>
        ///  
        /// <para>
        /// For more information about creating DNS records using DKIM tokens, go to the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/easy-dkim-dns-records.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        /// </summary>
        public List<string> DkimTokens
        {
            get { return this._dkimTokens; }
            set { this._dkimTokens = value; }
        }

        // Check to see if DkimTokens property is set
        internal bool IsSetDkimTokens()
        {
            return this._dkimTokens != null && this._dkimTokens.Count > 0; 
        }

    }
}