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
 * Do not modify this file. This file is generated from the iam-toolbox-2018-05-10.normal.json service model.
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
namespace Amazon.IAMToolbox.Model
{
    /// <summary>
    /// Container for the parameters to the GetRequestAuthorizationDetails operation.
    /// Retrieves the authorization details for a specific access denied request. The details
    /// include the request context, the evaluations performed, and the policies that were
    /// evaluated.
    /// 
    ///  
    /// <para>
    /// Use this operation to understand why a request was denied. Supported services include
    /// an authorization ID in the access denied error message. Pass that ID to this operation
    /// to retrieve the details.
    /// </para>
    ///  
    /// <para>
    /// Authorization details are available for at least 24 hours after the denial.
    /// </para>
    ///  
    /// <para>
    /// To use this operation, you must have the <c>iam:GetRequestAuthorizationDetails</c>
    /// permission.
    /// </para>
    /// </summary>
    public partial class GetRequestAuthorizationDetailsRequest : AmazonIAMToolboxRequest
    {
        private string _authorizationId;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AuthorizationId. 
        /// <para>
        /// The authorization ID received in the access denied error message. This ID identifies
        /// the specific request to retrieve details for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AuthorizationId
        {
            get { return this._authorizationId; }
            set { this._authorizationId = value; }
        }

        // Check to see if AuthorizationId property is set
        internal bool IsSetAuthorizationId()
        {
            return this._authorizationId != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token from a previous call, used to retrieve the next page of evaluations.
        /// Omit this value on the first call.
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