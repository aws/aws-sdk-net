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
    /// Returns all of the <code>ObjectIdentifiers</code> to which a given policy is attached
    /// inside a <a>BatchRead</a> operation. For more information, see <a>ListPolicyAttachments</a>
    /// and <a>BatchReadRequest$Operations</a>.
    /// </summary>
    public partial class BatchListPolicyAttachments
    {
        private int? _maxResults;
        private string _nextToken;
        private ObjectReference _policyReference;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
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

        /// <summary>
        /// Gets and sets the property PolicyReference. 
        /// <para>
        /// The reference that identifies the policy object.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ObjectReference PolicyReference
        {
            get { return this._policyReference; }
            set { this._policyReference = value; }
        }

        // Check to see if PolicyReference property is set
        internal bool IsSetPolicyReference()
        {
            return this._policyReference != null;
        }

    }
}