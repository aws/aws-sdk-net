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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// This is the response object from the ListAssociationVersions operation.
    /// </summary>
    public partial class ListAssociationVersionsResponse : AmazonWebServiceResponse
    {
        private List<AssociationVersionInfo> _associationVersions = new List<AssociationVersionInfo>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AssociationVersions. 
        /// <para>
        /// Information about all versions of the association for the specified association ID.
        /// </para>
        /// </summary>
        public List<AssociationVersionInfo> AssociationVersions
        {
            get { return this._associationVersions; }
            set { this._associationVersions = value; }
        }

        // Check to see if AssociationVersions property is set
        internal bool IsSetAssociationVersions()
        {
            return this._associationVersions != null && this._associationVersions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of items to return. Use this token to get the next set
        /// of results.
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

    }
}