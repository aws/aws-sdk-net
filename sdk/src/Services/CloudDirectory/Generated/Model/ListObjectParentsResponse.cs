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
 * Do not modify this file. This file is generated from the clouddirectory-2017-01-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudDirectory.Model
{
    /// <summary>
    /// This is the response object from the ListObjectParents operation.
    /// </summary>
    public partial class ListObjectParentsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ObjectIdentifierAndLinkNameTuple> _parentLinks = new List<ObjectIdentifierAndLinkNameTuple>();
        private Dictionary<string, string> _parents = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property ParentLinks. 
        /// <para>
        /// Returns a list of parent reference and LinkName Tuples.
        /// </para>
        /// </summary>
        public List<ObjectIdentifierAndLinkNameTuple> ParentLinks
        {
            get { return this._parentLinks; }
            set { this._parentLinks = value; }
        }

        // Check to see if ParentLinks property is set
        internal bool IsSetParentLinks()
        {
            return this._parentLinks != null && this._parentLinks.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Parents. 
        /// <para>
        /// The parent structure, which is a map with key as the <code>ObjectIdentifier</code>
        /// and LinkName as the value.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Parents
        {
            get { return this._parents; }
            set { this._parents = value; }
        }

        // Check to see if Parents property is set
        internal bool IsSetParents()
        {
            return this._parents != null && this._parents.Count > 0; 
        }

    }
}