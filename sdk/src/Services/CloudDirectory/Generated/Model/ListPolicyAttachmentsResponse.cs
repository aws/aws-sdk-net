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
    /// This is the response object from the ListPolicyAttachments operation.
    /// </summary>
    public partial class ListPolicyAttachmentsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<string> _objectIdentifiers = new List<string>();

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
        /// Gets and sets the property ObjectIdentifiers. 
        /// <para>
        /// A list of <code>ObjectIdentifiers</code> to which the policy is attached.
        /// </para>
        /// </summary>
        public List<string> ObjectIdentifiers
        {
            get { return this._objectIdentifiers; }
            set { this._objectIdentifiers = value; }
        }

        // Check to see if ObjectIdentifiers property is set
        internal bool IsSetObjectIdentifiers()
        {
            return this._objectIdentifiers != null && this._objectIdentifiers.Count > 0; 
        }

    }
}