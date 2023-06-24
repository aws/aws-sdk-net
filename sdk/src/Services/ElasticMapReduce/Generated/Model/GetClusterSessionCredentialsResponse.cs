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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// This is the response object from the GetClusterSessionCredentials operation.
    /// </summary>
    public partial class GetClusterSessionCredentialsResponse : AmazonWebServiceResponse
    {
        private Credentials _credentials;
        private DateTime? _expiresAt;

        /// <summary>
        /// Gets and sets the property Credentials. 
        /// <para>
        /// The credentials that you can use to connect to cluster endpoints that support username
        /// and password authentication.
        /// </para>
        /// </summary>
        public Credentials Credentials
        {
            get { return this._credentials; }
            set { this._credentials = value; }
        }

        // Check to see if Credentials property is set
        internal bool IsSetCredentials()
        {
            return this._credentials != null;
        }

        /// <summary>
        /// Gets and sets the property ExpiresAt. 
        /// <para>
        /// The time when the credentials that are returned by the <code>GetClusterSessionCredentials</code>
        /// API expire.
        /// </para>
        /// </summary>
        public DateTime ExpiresAt
        {
            get { return this._expiresAt.GetValueOrDefault(); }
            set { this._expiresAt = value; }
        }

        // Check to see if ExpiresAt property is set
        internal bool IsSetExpiresAt()
        {
            return this._expiresAt.HasValue; 
        }

    }
}