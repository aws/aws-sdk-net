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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// This is the response object from the ListTypeRegistrations operation.
    /// </summary>
    public partial class ListTypeRegistrationsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<string> _registrationTokenList = new List<string>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the request doesn't return all of the remaining results, <code>NextToken</code>
        /// is set to a token. To retrieve the next set of results, call this action again and
        /// assign that token to the request object's <code>NextToken</code> parameter. If the
        /// request returns all results, <code>NextToken</code> is set to <code>null</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property RegistrationTokenList. 
        /// <para>
        ///  A list of type registration tokens.
        /// </para>
        ///  
        /// <para>
        /// Use <code> <a>DescribeTypeRegistration</a> </code> to return detailed information
        /// about a type registration request.
        /// </para>
        /// </summary>
        public List<string> RegistrationTokenList
        {
            get { return this._registrationTokenList; }
            set { this._registrationTokenList = value; }
        }

        // Check to see if RegistrationTokenList property is set
        internal bool IsSetRegistrationTokenList()
        {
            return this._registrationTokenList != null && this._registrationTokenList.Count > 0; 
        }

    }
}