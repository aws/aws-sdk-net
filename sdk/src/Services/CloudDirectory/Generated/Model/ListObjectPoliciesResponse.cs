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
 * Do not modify this file. This file is generated from the clouddirectory-2017-01-11.normal.json service model.
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
    /// This is the response object from the ListObjectPolicies operation.
    /// </summary>
    public partial class ListObjectPoliciesResponse : AmazonWebServiceResponse
    {
        private List<string> _attachedPolicyIds = new List<string>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AttachedPolicyIds. 
        /// <para>
        /// A list of policy <code>ObjectIdentifiers</code>, that are attached to the object.
        /// </para>
        /// </summary>
        public List<string> AttachedPolicyIds
        {
            get { return this._attachedPolicyIds; }
            set { this._attachedPolicyIds = value; }
        }

        // Check to see if AttachedPolicyIds property is set
        internal bool IsSetAttachedPolicyIds()
        {
            return this._attachedPolicyIds != null && this._attachedPolicyIds.Count > 0; 
        }

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

    }
}