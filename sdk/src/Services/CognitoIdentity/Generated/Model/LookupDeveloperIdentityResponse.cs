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
 * Do not modify this file. This file is generated from the cognito-identity-2014-06-30.normal.json service model.
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
namespace Amazon.CognitoIdentity.Model
{
    /// <summary>
    /// Returned in response to a successful <c>LookupDeveloperIdentity</c> action.
    /// </summary>
    public partial class LookupDeveloperIdentityResponse : AmazonWebServiceResponse
    {
        private List<string> _developerUserIdentifierList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _identityId;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property DeveloperUserIdentifierList. 
        /// <para>
        /// This is the list of developer user identifiers associated with an identity ID. Cognito
        /// supports the association of multiple developer user identifiers with an identity ID.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DeveloperUserIdentifierList
        {
            get { return this._developerUserIdentifierList; }
            set { this._developerUserIdentifierList = value; }
        }

        // Check to see if DeveloperUserIdentifierList property is set
        internal bool IsSetDeveloperUserIdentifierList()
        {
            return this._developerUserIdentifierList != null && (this._developerUserIdentifierList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IdentityId. 
        /// <para>
        /// A unique identifier in the format REGION:GUID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=55)]
        public string IdentityId
        {
            get { return this._identityId; }
            set { this._identityId = value; }
        }

        // Check to see if IdentityId property is set
        internal bool IsSetIdentityId()
        {
            return this._identityId != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token. The first call you make will have <c>NextToken</c> set to null.
        /// After that the service will return <c>NextToken</c> values as needed. For example,
        /// let's say you make a request with <c>MaxResults</c> set to 10, and there are 20 matches
        /// in the database. The service will return a pagination token as a part of the response.
        /// This token can be used to call the API again and get results starting from the 11th
        /// match.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=65535)]
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