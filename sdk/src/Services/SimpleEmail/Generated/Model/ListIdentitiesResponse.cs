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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// A list of all identities that you have attempted to verify under your AWS account,
    /// regardless of verification status.
    /// </summary>
    public partial class ListIdentitiesResponse : AmazonWebServiceResponse
    {
        private List<string> _identities = new List<string>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Identities. 
        /// <para>
        /// A list of identities.
        /// </para>
        /// </summary>
        public List<string> Identities
        {
            get { return this._identities; }
            set { this._identities = value; }
        }

        // Check to see if Identities property is set
        internal bool IsSetIdentities()
        {
            return this._identities != null && this._identities.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token used for pagination.
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