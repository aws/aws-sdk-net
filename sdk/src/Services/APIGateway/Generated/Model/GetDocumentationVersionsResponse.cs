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
    /// The collection of documentation snapshots of an API. 
    /// 
    ///  <div class="remarks">
    /// <para>
    /// A snapshot represented by a <a>DocumentationVersion</a> associated with an API <code>Stage</code>.
    /// </para>
    /// </div> <div class="seeAlso"> <a href="http://docs.aws.amazon.com/apigateway/latest/developerguide/api-gateway-documenting-api.html">Documenting
    /// an API</a>, <a>DocumentationPart</a>, <a>DocumentationVersion</a> </div>
    /// </summary>
    public partial class GetDocumentationVersionsResponse : AmazonWebServiceResponse
    {
        private List<DocumentationVersion> _items = new List<DocumentationVersion>();
        private string _position;

        /// <summary>
        /// Gets and sets the property Items. 
        /// <para>
        /// The current page of <a>DocumentationVersion</a> items from the <a>DocumentationVersions</a>
        /// collection of an API.
        /// </para>
        /// </summary>
        public List<DocumentationVersion> Items
        {
            get { return this._items; }
            set { this._items = value; }
        }

        // Check to see if Items property is set
        internal bool IsSetItems()
        {
            return this._items != null && this._items.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Position.
        /// </summary>
        public string Position
        {
            get { return this._position; }
            set { this._position = value; }
        }

        // Check to see if Position property is set
        internal bool IsSetPosition()
        {
            return this._position != null;
        }

    }
}