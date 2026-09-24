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

namespace Amazon.ManagedGrafana.Model
{
    /// <summary>
    /// This is the response object from the CreateWorkspaceServiceAccountToken operation.
    /// </summary>
    public partial class CreateWorkspaceServiceAccountTokenResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ServiceAccountId. 
        /// <para>
        /// The ID of the service account where the token was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ServiceAccountId { get; set; }

        /// <summary>
        /// Checks to see if the ServiceAccountId property is set.
        /// </summary>
        internal bool IsSetServiceAccountId() => this.ServiceAccountId != null;

        /// <summary>
        /// Gets and sets the property ServiceAccountToken. 
        /// <para>
        /// Information about the created token, including the key. Be sure to store the key securely.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ServiceAccountTokenSummaryWithKey ServiceAccountToken { get; set; }

        /// <summary>
        /// Checks to see if the ServiceAccountToken property is set.
        /// </summary>
        internal bool IsSetServiceAccountToken() => this.ServiceAccountToken != null;

        /// <summary>
        /// Gets and sets the property WorkspaceId. 
        /// <para>
        /// The ID of the workspace where the token was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// Checks to see if the WorkspaceId property is set.
        /// </summary>
        internal bool IsSetWorkspaceId() => this.WorkspaceId != null;
    }
}
