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
    /// Container for the parameters to the MediaTypeHeader operation.
    /// This example ensures that mediaType strings are base64 encoded in headers.
    /// </summary>
    public partial class MediaTypeHeaderRequest : AmazonRestJsonProtocolRequest
    {
        private string _json;

        /// <summary>
        /// Gets and sets the property Json.
        /// </summary>
        public string Json
        {
            get { return this._json; }
            set { this._json = value; }
        }

        // Check to see if Json property is set
        internal bool IsSetJson()
        {
            return this._json != null;
        }

    }
}