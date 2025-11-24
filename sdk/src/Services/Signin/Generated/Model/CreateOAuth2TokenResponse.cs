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
 * Do not modify this file. This file is generated from the signin-2023-01-01.normal.json service model.
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
namespace Amazon.Signin.Model
{
    /// <summary>
    /// Output structure for CreateOAuth2Token operation
    /// 
    ///  
    /// <para>
    /// Contains flattened token operation outputs for both authorization code and refresh
    /// token flows. The response content depends on the grant_type from the original request.
    /// </para>
    /// </summary>
    public partial class CreateOAuth2TokenResponse : AmazonWebServiceResponse
    {
        private CreateOAuth2TokenResponseBody _tokenOutput;

        /// <summary>
        /// Gets and sets the property TokenOutput. 
        /// <para>
        /// Flattened token operation outputs The specific response fields depend on the grant_type
        /// used in the request
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CreateOAuth2TokenResponseBody TokenOutput
        {
            get { return this._tokenOutput; }
            set { this._tokenOutput = value; }
        }

        // Check to see if TokenOutput property is set
        internal bool IsSetTokenOutput()
        {
            return this._tokenOutput != null;
        }

    }
}