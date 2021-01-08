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
 * Do not modify this file. This file is generated from the sso-admin-2020-07-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SSOAdmin.Model
{
    /// <summary>
    /// This is the response object from the ListPermissionSetsProvisionedToAccount operation.
    /// </summary>
    public partial class ListPermissionSetsProvisionedToAccountResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<string> _permissionSets = new List<string>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token for the list API. Initially the value is null. Use the output
        /// of previous API calls to make subsequent calls.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
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
        /// Gets and sets the property PermissionSets. 
        /// <para>
        /// Defines the level of access that an AWS account has.
        /// </para>
        /// </summary>
        public List<string> PermissionSets
        {
            get { return this._permissionSets; }
            set { this._permissionSets = value; }
        }

        // Check to see if PermissionSets property is set
        internal bool IsSetPermissionSets()
        {
            return this._permissionSets != null && this._permissionSets.Count > 0; 
        }

    }
}