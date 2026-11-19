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

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Container for the parameters to the ListUserPoolClients operation. Given a user pool
    /// ID, lists app clients. App clients are sets of rules for the access that you want
    /// a user pool to grant to one application. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-settings-client-apps.html">App
    /// clients</a>. <note> <para> Amazon Cognito evaluates Identity and Access Management
    /// (IAM) policies in requests for this API operation. For this operation, you must use
    /// IAM credentials to authorize requests, and you must grant yourself the corresponding
    /// IAM permission in a policy. </para> <para> <b>Learn more</b> </para> <ul> <li> <para>
    /// <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
    /// Amazon Web Services API Requests</a> </para> </li> <li> <para> <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
    /// the Amazon Cognito user pools API and user pool endpoints</a> </para> </li> </ul>
    /// </note>
    /// </summary>
    public partial class ListUserPoolClientsRequest : AmazonCognitoIdentityProviderRequest
    {
        /// <summary>
        /// Gets and sets the property ClientType. 
        /// <para>
        /// Returns only app clients of this type. For dynamic client registration (<c>DCR</c>)
        /// and other app clients, the following values are valid.
        /// </para>
        ///  <dl> <dt>REGULAR</dt> <dd> 
        /// <para>
        /// An app client not created through dynamic client registration.
        /// </para>
        ///  </dd> <dt>DCR</dt> <dd> 
        /// <para>
        /// An app client created through dynamic client registration.
        /// </para>
        ///  </dd> </dl> 
        /// <para>
        /// If you omit <c>ClientType</c>, the response includes app clients of all types. When
        /// you set this filter, a page of results can contain fewer app clients than <c>MaxResults</c>,
        /// or none, while the response still includes a <c>NextToken</c>. Continue to request
        /// pages until the response has no <c>NextToken</c>. The app clients in the response
        /// don't include their type. To get the type of an app client, call <c>DescribeUserPoolClient</c>.
        /// </para>
        /// </summary>
        public ClientTypeType ClientType { get; set; }

        /// <summary>
        /// Checks to see if the ClientType property is set.
        /// </summary>
        internal bool IsSetClientType() => this.ClientType != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of app clients that you want Amazon Cognito to return in the response.
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
        /// This API operation returns a limited number of results. The pagination token is an
        /// identifier that you can present in an additional API request with the same parameters.
        /// When you include the pagination token, Amazon Cognito returns the next set of items
        /// after the current list. Subsequent requests return a new pagination token. By use
        /// of this token, you can paginate through the full list of items.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 131072)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property UserPoolId. 
        /// <para>
        /// The ID of the user pool where you want to list user pool clients.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 55)]
        public string UserPoolId { get; set; }

        /// <summary>
        /// Checks to see if the UserPoolId property is set.
        /// </summary>
        internal bool IsSetUserPoolId() => this.UserPoolId != null;
    }
}
