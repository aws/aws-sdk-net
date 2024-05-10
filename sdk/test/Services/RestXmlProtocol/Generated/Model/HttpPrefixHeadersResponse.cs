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
 * Do not modify this file. This file is generated from the rest-xml-protocol-2019-12-16.normal.json service model.
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
namespace Amazon.RestXmlProtocol.Model
{
    /// <summary>
    /// This is the response object from the HttpPrefixHeaders operation.
    /// </summary>
    public partial class HttpPrefixHeadersResponse : AmazonWebServiceResponse
    {
        private string _foo;
        private Dictionary<string, string> _fooMap = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Foo.
        /// </summary>
        public string Foo
        {
            get { return this._foo; }
            set { this._foo = value; }
        }

        // Check to see if Foo property is set
        internal bool IsSetFoo()
        {
            return this._foo != null;
        }

        /// <summary>
        /// Gets and sets the property FooMap.
        /// </summary>
        public Dictionary<string, string> FooMap
        {
            get { return this._fooMap; }
            set { this._fooMap = value; }
        }

        // Check to see if FooMap property is set
        internal bool IsSetFooMap()
        {
            return this._fooMap != null && (this._fooMap.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}