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
 * Do not modify this file. This file is generated from the workmail-2017-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkMail.Model
{
    /// <summary>
    /// This is the response object from the AssumeImpersonationRole operation.
    /// </summary>
    public partial class AssumeImpersonationRoleResponse : AmazonWebServiceResponse
    {
        private long? _expiresIn;
        private string _token;

        /// <summary>
        /// Gets and sets the property ExpiresIn. 
        /// <para>
        /// The authentication token's validity, in seconds.
        /// </para>
        /// </summary>
        public long ExpiresIn
        {
            get { return this._expiresIn.GetValueOrDefault(); }
            set { this._expiresIn = value; }
        }

        // Check to see if ExpiresIn property is set
        internal bool IsSetExpiresIn()
        {
            return this._expiresIn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Token. 
        /// <para>
        /// The authentication token for the impersonation role.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Token
        {
            get { return this._token; }
            set { this._token = value; }
        }

        // Check to see if Token property is set
        internal bool IsSetToken()
        {
            return this._token != null;
        }

    }
}