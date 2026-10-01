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

namespace Amazon.EMRContainers.Model
{
    /// <summary>
    /// This is the response object from the GetManagedEndpointSessionCredentials operation.
    /// </summary>
    public partial class GetManagedEndpointSessionCredentialsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Credentials. 
        /// <para>
        /// The structure containing the session credentials.
        /// </para>
        /// </summary>
        public Credentials Credentials { get; set; }

        /// <summary>
        /// Checks to see if the Credentials property is set.
        /// </summary>
        internal bool IsSetCredentials() => this.Credentials != null;

        /// <summary>
        /// Gets and sets the property EndpointCredentials. 
        /// <para>
        /// The session credentials that the operation returns.
        /// </para>
        /// </summary>
        public Credentials EndpointCredentials { get; set; }

        /// <summary>
        /// Checks to see if the EndpointCredentials property is set.
        /// </summary>
        internal bool IsSetEndpointCredentials() => this.EndpointCredentials != null;

        /// <summary>
        /// Gets and sets the property ExpiresAt. 
        /// <para>
        /// The date and time when the session token will expire.
        /// </para>
        /// </summary>
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Checks to see if the ExpiresAt property is set.
        /// </summary>
        internal bool IsSetExpiresAt() => this.ExpiresAt.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the session token returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;
    }
}
