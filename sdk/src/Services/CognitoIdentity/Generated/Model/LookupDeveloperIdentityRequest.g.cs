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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the LookupDeveloperIdentity operation. Retrieves the
    /// <c>IdentityID</c> associated with a <c>DeveloperUserIdentifier</c> or the list of
    /// <c>DeveloperUserIdentifier</c> values associated with an <c>IdentityId</c> for an
    /// existing identity. Either <c>IdentityID</c> or <c>DeveloperUserIdentifier</c> must
    /// not be null. If you supply only one of these values, the other value will be searched
    /// in the database and returned as a part of the response. If you supply both, <c>DeveloperUserIdentifier</c>
    /// will be matched against <c>IdentityID</c>. If the values are verified against the
    /// database, the response returns both values and is the same as the request. Otherwise,
    /// a <c>ResourceConflictException</c> is thrown. <para> <c>LookupDeveloperIdentity</c>
    /// is intended for low-throughput control plane operations: for example, to enable customer
    /// service to locate an identity ID by username. If you are using it for higher-volume
    /// operations such as user authentication, your requests are likely to be throttled.
    /// <a>GetOpenIdTokenForDeveloperIdentity</a> is a better option for higher-volume operations
    /// for user authentication. </para> <para> You must use Amazon Web Services developer
    /// credentials to call this operation. </para>
    /// </summary>
    public partial class LookupDeveloperIdentityRequest : AmazonCognitoIdentityRequest
    {
        /// <summary>
        /// Gets and sets the property DeveloperUserIdentifier. 
        /// <para>
        /// A unique ID used by your backend authentication process to identify a user. Typically,
        /// a developer identity provider would issue many developer user identifiers, in keeping
        /// with the number of users.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string DeveloperUserIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DeveloperUserIdentifier property is set.
        /// </summary>
        internal bool IsSetDeveloperUserIdentifier() => this.DeveloperUserIdentifier != null;

        /// <summary>
        /// Gets and sets the property IdentityId. 
        /// <para>
        /// A unique identifier in the format REGION:GUID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 55)]
        public string IdentityId { get; set; }

        /// <summary>
        /// Checks to see if the IdentityId property is set.
        /// </summary>
        internal bool IsSetIdentityId() => this.IdentityId != null;

        /// <summary>
        /// Gets and sets the property IdentityPoolId. 
        /// <para>
        /// An identity pool ID in the format REGION:GUID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 55)]
        public string IdentityPoolId { get; set; }

        /// <summary>
        /// Checks to see if the IdentityPoolId property is set.
        /// </summary>
        internal bool IsSetIdentityPoolId() => this.IdentityPoolId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of identities to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 60)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

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
        [AWSProperty(Min = 1, Max = 65535)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
