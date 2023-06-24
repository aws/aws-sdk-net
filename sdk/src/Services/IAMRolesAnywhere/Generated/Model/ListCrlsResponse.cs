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
 * Do not modify this file. This file is generated from the rolesanywhere-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IAMRolesAnywhere.Model
{
    /// <summary>
    /// This is the response object from the ListCrls operation.
    /// </summary>
    public partial class ListCrlsResponse : AmazonWebServiceResponse
    {
        private List<CrlDetail> _crls = new List<CrlDetail>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Crls. 
        /// <para>
        /// A list of certificate revocation lists (CRL). 
        /// </para>
        /// </summary>
        public List<CrlDetail> Crls
        {
            get { return this._crls; }
            set { this._crls = value; }
        }

        // Check to see if Crls property is set
        internal bool IsSetCrls()
        {
            return this._crls != null && this._crls.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that indicates where the output should continue from, if a previous request
        /// did not show all results. To get the next results, make the request again with this
        /// value.
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