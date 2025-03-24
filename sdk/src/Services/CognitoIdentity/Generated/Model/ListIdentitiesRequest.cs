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
    /// Container for the parameters to the ListIdentities operation.
    /// Lists the identities in an identity pool.
    /// 
    ///  
    /// <para>
    /// You must use Amazon Web Services developer credentials to call this operation.
    /// </para>
    /// </summary>
    public partial class ListIdentitiesRequest : AmazonCognitoIdentityRequest
    {
        private bool? _hideDisabled;
        private string _identityPoolId;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property HideDisabled. 
        /// <para>
        /// An optional boolean parameter that allows you to hide disabled identities. If omitted,
        /// the ListIdentities API will include disabled identities in the response.
        /// </para>
        /// </summary>
        public bool? HideDisabled
        {
            get { return this._hideDisabled; }
            set { this._hideDisabled = value; }
        }

        // Check to see if HideDisabled property is set
        internal bool IsSetHideDisabled()
        {
            return this._hideDisabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IdentityPoolId. 
        /// <para>
        /// An identity pool ID in the format REGION:GUID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=55)]
        public string IdentityPoolId
        {
            get { return this._identityPoolId; }
            set { this._identityPoolId = value; }
        }

        // Check to see if IdentityPoolId property is set
        internal bool IsSetIdentityPoolId()
        {
            return this._identityPoolId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of identities to return.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=60)]
        public int? MaxResults
        {
            get { return this._maxResults; }
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
        /// A pagination token.
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