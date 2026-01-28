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
 * Do not modify this file. This file is generated from the route53globalresolver-2022-09-27.normal.json service model.
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
namespace Amazon.Route53GlobalResolver.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteAccessToken operation.
    /// Deletes an access token. This operation cannot be undone.
    /// </summary>
    public partial class DeleteAccessTokenRequest : AmazonRoute53GlobalResolverRequest
    {
        private string _accessTokenId;

        /// <summary>
        /// Gets and sets the property AccessTokenId. 
        /// <para>
        /// The unique identifier of the access token to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string AccessTokenId
        {
            get { return this._accessTokenId; }
            set { this._accessTokenId = value; }
        }

        // Check to see if AccessTokenId property is set
        internal bool IsSetAccessTokenId()
        {
            return this._accessTokenId != null;
        }

    }
}