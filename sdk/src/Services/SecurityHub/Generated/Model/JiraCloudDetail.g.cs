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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information about the configuration and status of a Jira Cloud integration.
    /// </summary>
    public partial class JiraCloudDetail
    {
        /// <summary>
        /// Gets and sets the property AuthStatus. 
        /// <para>
        /// The status of the authorization between Jira Cloud and the service.
        /// </para>
        /// </summary>
        public ConnectorAuthStatus AuthStatus { get; set; }

        /// <summary>
        /// Checks to see if the AuthStatus property is set.
        /// </summary>
        internal bool IsSetAuthStatus() => this.AuthStatus != null;

        /// <summary>
        /// Gets and sets the property AuthUrl. 
        /// <para>
        /// The URL to provide to customers for OAuth auth code flow.
        /// </para>
        /// </summary>
        public string AuthUrl { get; set; }

        /// <summary>
        /// Checks to see if the AuthUrl property is set.
        /// </summary>
        internal bool IsSetAuthUrl() => this.AuthUrl != null;

        /// <summary>
        /// Gets and sets the property CloudId. 
        /// <para>
        /// The cloud id of the Jira Cloud.
        /// </para>
        /// </summary>
        public string CloudId { get; set; }

        /// <summary>
        /// Checks to see if the CloudId property is set.
        /// </summary>
        internal bool IsSetCloudId() => this.CloudId != null;

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The URL domain of your Jira Cloud instance.
        /// </para>
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// Checks to see if the Domain property is set.
        /// </summary>
        internal bool IsSetDomain() => this.Domain != null;

        /// <summary>
        /// Gets and sets the property ProjectKey. 
        /// <para>
        /// The projectKey of Jira Cloud.
        /// </para>
        /// </summary>
        public string ProjectKey { get; set; }

        /// <summary>
        /// Checks to see if the ProjectKey property is set.
        /// </summary>
        internal bool IsSetProjectKey() => this.ProjectKey != null;
    }
}
