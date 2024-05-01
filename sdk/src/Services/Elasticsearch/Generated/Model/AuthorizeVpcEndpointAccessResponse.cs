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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
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
namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// Container for response parameters to the <c><a>AuthorizeVpcEndpointAccess</a></c>
    /// operation. Contains the account ID and the type of the account being authorized to
    /// access the VPC endpoint.
    /// </summary>
    public partial class AuthorizeVpcEndpointAccessResponse : AmazonWebServiceResponse
    {
        private AuthorizedPrincipal _authorizedPrincipal;

        /// <summary>
        /// Gets and sets the property AuthorizedPrincipal. 
        /// <para>
        /// Information about the account or service that was provided access to the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AuthorizedPrincipal AuthorizedPrincipal
        {
            get { return this._authorizedPrincipal; }
            set { this._authorizedPrincipal = value; }
        }

        // Check to see if AuthorizedPrincipal property is set
        internal bool IsSetAuthorizedPrincipal()
        {
            return this._authorizedPrincipal != null;
        }

    }
}