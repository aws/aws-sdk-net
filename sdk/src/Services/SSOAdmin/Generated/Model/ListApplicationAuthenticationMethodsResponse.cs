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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SSOAdmin.Model
{
    /// <summary>
    /// This is the response object from the ListApplicationAuthenticationMethods operation.
    /// </summary>
    public partial class ListApplicationAuthenticationMethodsResponse : AmazonWebServiceResponse
    {
        private List<AuthenticationMethodItem> _authenticationMethods = AWSConfigs.InitializeCollections ? new List<AuthenticationMethodItem>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AuthenticationMethods. 
        /// <para>
        /// An array list of authentication methods for the specified application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AuthenticationMethodItem> AuthenticationMethods
        {
            get { return this._authenticationMethods; }
            set { this._authenticationMethods = value; }
        }

        // Check to see if AuthenticationMethods property is set
        internal bool IsSetAuthenticationMethods()
        {
            return this._authenticationMethods != null && (this._authenticationMethods.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If present, this value indicates that more output is available than is included in
        /// the current response. Use this value in the <c>NextToken</c> request parameter in
        /// a subsequent call to the operation to get the next part of the output. You should
        /// repeat this until the <c>NextToken</c> response element comes back as <c>null</c>.
        /// This indicates that this is the last page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
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