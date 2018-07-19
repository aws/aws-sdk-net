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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// The endpoint configuration to indicate the types of endpoints an API (<a>RestApi</a>)
    /// or its custom domain name (<a>DomainName</a>) has.
    /// </summary>
    public partial class EndpointConfiguration
    {
        private List<string> _types = new List<string>();

        /// <summary>
        /// Gets and sets the property Types. 
        /// <para>
        /// A list of endpoint types of an API (<a>RestApi</a>) or its custom domain name (<a>DomainName</a>).
        /// For an edge-optimized API and its custom domain name, the endpoint type is <code>"EDGE"</code>.
        /// For a regional API and its custom domain name, the endpoint type is <code>REGIONAL</code>.
        /// For a private API, the endpoint type is <code>PRIVATE</code>.
        /// </para>
        /// </summary>
        public List<string> Types
        {
            get { return this._types; }
            set { this._types = value; }
        }

        // Check to see if Types property is set
        internal bool IsSetTypes()
        {
            return this._types != null && this._types.Count > 0; 
        }

    }
}