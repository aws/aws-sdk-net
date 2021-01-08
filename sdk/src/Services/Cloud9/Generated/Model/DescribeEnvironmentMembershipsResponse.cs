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
 * Do not modify this file. This file is generated from the cloud9-2017-09-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Cloud9.Model
{
    /// <summary>
    /// This is the response object from the DescribeEnvironmentMemberships operation.
    /// </summary>
    public partial class DescribeEnvironmentMembershipsResponse : AmazonWebServiceResponse
    {
        private List<EnvironmentMember> _memberships = new List<EnvironmentMember>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Memberships. 
        /// <para>
        /// Information about the environment members for the environment.
        /// </para>
        /// </summary>
        public List<EnvironmentMember> Memberships
        {
            get { return this._memberships; }
            set { this._memberships = value; }
        }

        // Check to see if Memberships property is set
        internal bool IsSetMemberships()
        {
            return this._memberships != null && this._memberships.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If there are more than 25 items in the list, only the first 25 items are returned,
        /// along with a unique string called a <i>next token</i>. To get the next batch of items
        /// in the list, call this operation again, adding the next token to the call.
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