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
    /// If the action is successful, the service sends back an HTTP 200 response.
    /// 
    ///  
    /// <para>
    /// The following data is returned in JSON format by the service.
    /// </para>
    /// </summary>
    public partial class PutEmailIdentityDkimSigningAttributesResponse : AmazonWebServiceResponse
    {
        private DkimStatus _dkimStatus;
        private List<string> _dkimTokens = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property DkimStatus. 
        /// <para>
        /// The DKIM authentication status of the identity. Amazon SES determines the authentication
        /// status by searching for specific records in the DNS configuration for your domain.
        /// If you used <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/easy-dkim.html">Easy
        /// DKIM</a> to set up DKIM authentication, Amazon SES tries to find three unique CNAME
        /// records in the DNS configuration for your domain.
        /// </para>
        ///  
        /// <para>
        /// If you provided a public key to perform DKIM authentication, Amazon SES tries to find
        /// a TXT record that uses the selector that you specified. The value of the TXT record
        /// must be a public key that's paired with the private key that you specified in the
        /// process of creating the identity.
        /// </para>
        ///  
        /// <para>
        /// The status can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PENDING</c> – The verification process was initiated, but Amazon SES hasn't yet
        /// detected the DKIM records in the DNS configuration for the domain.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SUCCESS</c> – The verification process completed successfully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> – The verification process failed. This typically occurs when Amazon
        /// SES fails to find the DKIM records in the DNS configuration of the domain.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TEMPORARY_FAILURE</c> – A temporary issue is preventing Amazon SES from determining
        /// the DKIM authentication status of the domain.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NOT_STARTED</c> – The DKIM verification process hasn't been initiated for the
        /// domain.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DkimStatus DkimStatus
        {
            get { return this._dkimStatus; }
            set { this._dkimStatus = value; }
        }

        // Check to see if DkimStatus property is set
        internal bool IsSetDkimStatus()
        {
            return this._dkimStatus != null;
        }

        /// <summary>
        /// Gets and sets the property DkimTokens. 
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
        /// key pair, then this object contains the selector that's associated with your public
        /// key.
        /// </para>
        ///  
        /// <para>
        /// Regardless of the DKIM authentication method you use, Amazon SES searches for the
        /// appropriate records in the DNS configuration of the domain for up to 72 hours.
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

    }
}