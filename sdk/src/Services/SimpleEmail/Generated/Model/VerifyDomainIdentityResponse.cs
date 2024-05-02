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
    /// Returns a TXT record that you must publish to the DNS server of your domain to complete
    /// domain verification with Amazon SES.
    /// </summary>
    public partial class VerifyDomainIdentityResponse : AmazonWebServiceResponse
    {
        private string _verificationToken;

        /// <summary>
        /// Gets and sets the property VerificationToken. 
        /// <para>
        /// A TXT record that you must place in the DNS settings of the domain to complete domain
        /// verification with Amazon SES.
        /// </para>
        ///  
        /// <para>
        /// As Amazon SES searches for the TXT record, the domain's verification status is "Pending".
        /// When Amazon SES detects the record, the domain's verification status changes to "Success".
        /// If Amazon SES is unable to detect the record within 72 hours, the domain's verification
        /// status changes to "Failed." In that case, to verify the domain, you must restart the
        /// verification process from the beginning. The domain's verification status also changes
        /// to "Success" when it is DKIM verified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VerificationToken
        {
            get { return this._verificationToken; }
            set { this._verificationToken = value; }
        }

        // Check to see if VerificationToken property is set
        internal bool IsSetVerificationToken()
        {
            return this._verificationToken != null;
        }

    }
}