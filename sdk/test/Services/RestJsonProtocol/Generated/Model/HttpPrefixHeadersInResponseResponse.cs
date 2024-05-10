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
 * Do not modify this file. This file is generated from the rest-json-protocol-2019-12-16.normal.json service model.
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
namespace Amazon.RestJsonProtocol.Model
{
    /// <summary>
    /// This is the response object from the HttpPrefixHeadersInResponse operation.
    /// </summary>
    public partial class HttpPrefixHeadersInResponseResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, string> _prefixHeaders = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property PrefixHeaders.
        /// </summary>
        public Dictionary<string, string> PrefixHeaders
        {
            get { return this._prefixHeaders; }
            set { this._prefixHeaders = value; }
        }

        // Check to see if PrefixHeaders property is set
        internal bool IsSetPrefixHeaders()
        {
            return this._prefixHeaders != null && (this._prefixHeaders.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}