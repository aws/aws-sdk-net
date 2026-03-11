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
 * Do not modify this file. This file is generated from the sts-2011-06-15.normal.json service model.
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
namespace Amazon.SecurityToken.Model
{
    /// <summary>
    /// Container for the parameters to the GetDelegatedAccessToken operation.
    /// Exchanges a trade-in token for temporary Amazon Web Services credentials with the
    /// permissions associated with the assumed principal. This operation allows you to obtain
    /// credentials for a specific principal based on a trade-in token, enabling delegation
    /// of access to Amazon Web Services resources.
    /// </summary>
    public partial class GetDelegatedAccessTokenRequest : AmazonSecurityTokenServiceRequest
    {
        private string _tradeInToken;

        /// <summary>
        /// Gets and sets the property TradeInToken. 
        /// <para>
        /// The token to exchange for temporary Amazon Web Services credentials. This token must
        /// be valid and unexpired at the time of the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string TradeInToken
        {
            get { return this._tradeInToken; }
            set { this._tradeInToken = value; }
        }

        // Check to see if TradeInToken property is set
        internal bool IsSetTradeInToken()
        {
            return this._tradeInToken != null;
        }

    }
}