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
 * Do not modify this file. This file is generated from the verifiedpermissions-2021-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.VerifiedPermissions.Model
{
    /// <summary>
    /// This is the response object from the ListIdentitySources operation.
    /// </summary>
    public partial class ListIdentitySourcesResponse : AmazonWebServiceResponse
    {
        private List<IdentitySourceItem> _identitySources = new List<IdentitySourceItem>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property IdentitySources. 
        /// <para>
        /// The list of identity sources stored in the specified policy store.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<IdentitySourceItem> IdentitySources
        {
            get { return this._identitySources; }
            set { this._identitySources = value; }
        }

        // Check to see if IdentitySources property is set
        internal bool IsSetIdentitySources()
        {
            return this._identitySources != null && this._identitySources.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If present, this value indicates that more output is available than is included in
        /// the current response. Use this value in the <code>NextToken</code> request parameter
        /// in a subsequent call to the operation to get the next part of the output. You should
        /// repeat this until the <code>NextToken</code> response element comes back as <code>null</code>.
        /// This indicates that this is the last page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=8000)]
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