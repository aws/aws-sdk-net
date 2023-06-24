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
 * Do not modify this file. This file is generated from the resource-groups-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ResourceGroups.Model
{
    /// <summary>
    /// This is the response object from the SearchResources operation.
    /// </summary>
    public partial class SearchResourcesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<QueryError> _queryErrors = new List<QueryError>();
        private List<ResourceIdentifier> _resourceIdentifiers = new List<ResourceIdentifier>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If present, indicates that more output is available than is included in the current
        /// response. Use this value in the <code>NextToken</code> request parameter in a subsequent
        /// call to the operation to get the next part of the output. You should repeat this until
        /// the <code>NextToken</code> response element comes back as <code>null</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
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
        /// Gets and sets the property QueryErrors. 
        /// <para>
        /// A list of <code>QueryError</code> objects. Each error is an object that contains <code>ErrorCode</code>
        /// and <code>Message</code> structures.
        /// </para>
        ///  
        /// <para>
        /// Possible values for <code>ErrorCode</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CLOUDFORMATION_STACK_INACTIVE</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CLOUDFORMATION_STACK_NOT_EXISTING</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<QueryError> QueryErrors
        {
            get { return this._queryErrors; }
            set { this._queryErrors = value; }
        }

        // Check to see if QueryErrors property is set
        internal bool IsSetQueryErrors()
        {
            return this._queryErrors != null && this._queryErrors.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceIdentifiers. 
        /// <para>
        /// The ARNs and resource types of resources that are members of the group that you specified.
        /// </para>
        /// </summary>
        public List<ResourceIdentifier> ResourceIdentifiers
        {
            get { return this._resourceIdentifiers; }
            set { this._resourceIdentifiers = value; }
        }

        // Check to see if ResourceIdentifiers property is set
        internal bool IsSetResourceIdentifiers()
        {
            return this._resourceIdentifiers != null && this._resourceIdentifiers.Count > 0; 
        }

    }
}