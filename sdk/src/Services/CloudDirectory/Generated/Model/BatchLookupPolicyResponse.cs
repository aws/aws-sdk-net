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
    /// Represents the output of a <a>LookupPolicy</a> response operation.
    /// </summary>
    public partial class BatchLookupPolicyResponse
    {
        private string _nextToken;
        private List<PolicyToPath> _policyToPathList = new List<PolicyToPath>();

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
        /// Gets and sets the property PolicyToPathList. 
        /// <para>
        /// Provides list of path to policies. Policies contain <code>PolicyId</code>, <code>ObjectIdentifier</code>,
        /// and <code>PolicyType</code>. For more information, see <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/cd_key_concepts.html#policies">Policies</a>.
        /// </para>
        /// </summary>
        public List<PolicyToPath> PolicyToPathList
        {
            get { return this._policyToPathList; }
            set { this._policyToPathList = value; }
        }

        // Check to see if PolicyToPathList property is set
        internal bool IsSetPolicyToPathList()
        {
            return this._policyToPathList != null && this._policyToPathList.Count > 0; 
        }

    }
}