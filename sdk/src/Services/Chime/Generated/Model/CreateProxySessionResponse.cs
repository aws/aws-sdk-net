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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Chime.Model
{
    /// <summary>
    /// This is the response object from the CreateProxySession operation.
    /// </summary>
    public partial class CreateProxySessionResponse : AmazonWebServiceResponse
    {
        private ProxySession _proxySession;

        /// <summary>
        /// Gets and sets the property ProxySession. 
        /// <para>
        /// The proxy session details.
        /// </para>
        /// </summary>
        public ProxySession ProxySession
        {
            get { return this._proxySession; }
            set { this._proxySession = value; }
        }

        // Check to see if ProxySession property is set
        internal bool IsSetProxySession()
        {
            return this._proxySession != null;
        }

    }
}