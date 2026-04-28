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
 * Do not modify this file. This file is generated from the securityagent-2025-09-06.normal.json service model.
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
namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// This is the response object from the InitiateProviderRegistration operation.
    /// </summary>
    public partial class InitiateProviderRegistrationResponse : AmazonWebServiceResponse
    {
        private string _csrfState;
        private string _redirectTo;

        /// <summary>
        /// Gets and sets the property CsrfState. 
        /// <para>
        /// CSRF state token for OAuth security
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CsrfState
        {
            get { return this._csrfState; }
            set { this._csrfState = value; }
        }

        // Check to see if CsrfState property is set
        internal bool IsSetCsrfState()
        {
            return this._csrfState != null;
        }

        /// <summary>
        /// Gets and sets the property RedirectTo. 
        /// <para>
        /// OAuth redirect URL
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RedirectTo
        {
            get { return this._redirectTo; }
            set { this._redirectTo = value; }
        }

        // Check to see if RedirectTo property is set
        internal bool IsSetRedirectTo()
        {
            return this._redirectTo != null;
        }

    }
}