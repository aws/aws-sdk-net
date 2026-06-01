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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
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
    /// This is the response object from the ListUserPoolReplicas operation.
    /// </summary>
    public partial class ListUserPoolReplicasResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<UserPoolReplicaType> _userPoolReplicas = AWSConfigs.InitializeCollections ? new List<UserPoolReplicaType>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token for retrieving the next page of results. If this value is null,
        /// there are no more results to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// Gets and sets the property UserPoolReplicas. 
        /// <para>
        /// A list of user pool replicas, including information about their status, role, and
        /// Region.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UserPoolReplicaType> UserPoolReplicas
        {
            get { return this._userPoolReplicas; }
            set { this._userPoolReplicas = value; }
        }

        // Check to see if UserPoolReplicas property is set
        internal bool IsSetUserPoolReplicas()
        {
            return this._userPoolReplicas != null && (this._userPoolReplicas.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}