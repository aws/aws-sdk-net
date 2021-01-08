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
 * Do not modify this file. This file is generated from the organizations-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Organizations.Model
{
    /// <summary>
    /// This is the response object from the ListDelegatedAdministrators operation.
    /// </summary>
    public partial class ListDelegatedAdministratorsResponse : AmazonWebServiceResponse
    {
        private List<DelegatedAdministrator> _delegatedAdministrators = new List<DelegatedAdministrator>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property DelegatedAdministrators. 
        /// <para>
        /// The list of delegated administrators in your organization.
        /// </para>
        /// </summary>
        public List<DelegatedAdministrator> DelegatedAdministrators
        {
            get { return this._delegatedAdministrators; }
            set { this._delegatedAdministrators = value; }
        }

        // Check to see if DelegatedAdministrators property is set
        internal bool IsSetDelegatedAdministrators()
        {
            return this._delegatedAdministrators != null && this._delegatedAdministrators.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If present, indicates that more output is available than is included in the current
        /// response. Use this value in the <code>NextToken</code> request parameter in a subsequent
        /// call to the operation to get the next part of the output. You should repeat this until
        /// the <code>NextToken</code> response element comes back as <code>null</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100000)]
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