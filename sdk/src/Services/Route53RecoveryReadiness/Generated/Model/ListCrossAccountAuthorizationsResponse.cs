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
 * Do not modify this file. This file is generated from the route53-recovery-readiness-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53RecoveryReadiness.Model
{
    /// <summary>
    /// This is the response object from the ListCrossAccountAuthorizations operation.
    /// </summary>
    public partial class ListCrossAccountAuthorizationsResponse : AmazonWebServiceResponse
    {
        private List<string> _crossAccountAuthorizations = new List<string>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property CrossAccountAuthorizations. A list of CrossAccountAuthorizations
        /// </summary>
        public List<string> CrossAccountAuthorizations
        {
            get { return this._crossAccountAuthorizations; }
            set { this._crossAccountAuthorizations = value; }
        }

        // Check to see if CrossAccountAuthorizations property is set
        internal bool IsSetCrossAccountAuthorizations()
        {
            return this._crossAccountAuthorizations != null && this._crossAccountAuthorizations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. A token that can be used to resume pagination
        /// from the end of the collection.
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