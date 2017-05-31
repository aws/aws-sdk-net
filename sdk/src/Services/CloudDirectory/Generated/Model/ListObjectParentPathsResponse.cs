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
 * Do not modify this file. This file is generated from the clouddirectory-2016-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudDirectory.Model
{
    /// <summary>
    /// This is the response object from the ListObjectParentPaths operation.
    /// </summary>
    public partial class ListObjectParentPathsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<PathToObjectIdentifiers> _pathToObjectIdentifiersList = new List<PathToObjectIdentifiers>();

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
        /// Gets and sets the property PathToObjectIdentifiersList. 
        /// <para>
        /// Returns the path to the <code>ObjectIdentifiers</code> that are associated with the
        /// directory.
        /// </para>
        /// </summary>
        public List<PathToObjectIdentifiers> PathToObjectIdentifiersList
        {
            get { return this._pathToObjectIdentifiersList; }
            set { this._pathToObjectIdentifiersList = value; }
        }

        // Check to see if PathToObjectIdentifiersList property is set
        internal bool IsSetPathToObjectIdentifiersList()
        {
            return this._pathToObjectIdentifiersList != null && this._pathToObjectIdentifiersList.Count > 0; 
        }

    }
}