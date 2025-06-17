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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
        private ConnectorAuthStatus _authStatus;
        private string _authUrl;
        private string _cloudId;
        private string _domain;
        private string _projectKey;

        /// <summary>
        /// Gets and sets the property AuthStatus. 
        /// <para>
        /// The status of the authorization between Jira Cloud and the service.
        /// </para>
        /// </summary>
        public ConnectorAuthStatus AuthStatus
        {
            get { return this._authStatus; }
            set { this._authStatus = value; }
        }

        // Check to see if AuthStatus property is set
        internal bool IsSetAuthStatus()
        {
            return this._authStatus != null;
        }

        /// <summary>
        /// Gets and sets the property AuthUrl. 
        /// <para>
        /// The URL to provide to customers for OAuth auth code flow.
        /// </para>
        /// </summary>
        public string AuthUrl
        {
            get { return this._authUrl; }
            set { this._authUrl = value; }
        }

        // Check to see if AuthUrl property is set
        internal bool IsSetAuthUrl()
        {
            return this._authUrl != null;
        }

        /// <summary>
        /// Gets and sets the property CloudId. 
        /// <para>
        /// The cloud id of the Jira Cloud.
        /// </para>
        /// </summary>
        public string CloudId
        {
            get { return this._cloudId; }
            set { this._cloudId = value; }
        }

        // Check to see if CloudId property is set
        internal bool IsSetCloudId()
        {
            return this._cloudId != null;
        }

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The URL domain of your Jira Cloud instance.
        /// </para>
        /// </summary>
        public string Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

        /// <summary>
        /// Gets and sets the property ProjectKey. 
        /// <para>
        /// The projectKey of Jira Cloud.
        /// </para>
        /// </summary>
        public string ProjectKey
        {
            get { return this._projectKey; }
            set { this._projectKey = value; }
        }

        // Check to see if ProjectKey property is set
        internal bool IsSetProjectKey()
        {
            return this._projectKey != null;
        }

    }
}