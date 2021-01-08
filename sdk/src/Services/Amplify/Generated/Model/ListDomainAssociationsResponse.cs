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
 * Do not modify this file. This file is generated from the amplify-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Amplify.Model
{
    /// <summary>
    /// The result structure for the list domain association request.
    /// </summary>
    public partial class ListDomainAssociationsResponse : AmazonWebServiceResponse
    {
        private List<DomainAssociation> _domainAssociations = new List<DomainAssociation>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property DomainAssociations. 
        /// <para>
        ///  A list of domain associations. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
        public List<DomainAssociation> DomainAssociations
        {
            get { return this._domainAssociations; }
            set { this._domainAssociations = value; }
        }

        // Check to see if DomainAssociations property is set
        internal bool IsSetDomainAssociations()
        {
            return this._domainAssociations != null && this._domainAssociations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  A pagination token. If non-null, a pagination token is returned in a result. Pass
        /// its value in another request to retrieve more entries. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=2000)]
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