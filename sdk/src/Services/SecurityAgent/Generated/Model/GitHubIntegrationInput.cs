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
 * Do not modify this file. This file is generated from the securityagent-2025-09-06.normal.json service model.
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
namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// The input required to create a GitHub integration, including the OAuth authorization
    /// code and CSRF state.
    /// </summary>
    public partial class GitHubIntegrationInput
    {
        private string _code;
        private string _installationId;
        private string _organizationName;
        private string _state;
        private string _targetUrl;

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The OAuth authorization code received from GitHub.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this._code != null;
        }

        /// <summary>
        /// Gets and sets the property InstallationId. 
        /// <para>
        /// The installation identifier provided by GitHub Enterprise Server on the install callback.
        /// Required for GitHub Enterprise Server integrations and ignored for GitHub.com.
        /// </para>
        /// </summary>
        public string InstallationId
        {
            get { return this._installationId; }
            set { this._installationId = value; }
        }

        // Check to see if InstallationId property is set
        internal bool IsSetInstallationId()
        {
            return this._installationId != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationName. 
        /// <para>
        /// The name of the GitHub organization to integrate with.
        /// </para>
        /// </summary>
        public string OrganizationName
        {
            get { return this._organizationName; }
            set { this._organizationName = value; }
        }

        // Check to see if OrganizationName property is set
        internal bool IsSetOrganizationName()
        {
            return this._organizationName != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The CSRF state token for validating the OAuth flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property TargetUrl. 
        /// <para>
        /// The HTTPS URL of a self-hosted GitHub Enterprise Server instance. Omit this value
        /// for GitHub.com.
        /// </para>
        /// </summary>
        public string TargetUrl
        {
            get { return this._targetUrl; }
            set { this._targetUrl = value; }
        }

        // Check to see if TargetUrl property is set
        internal bool IsSetTargetUrl()
        {
            return this._targetUrl != null;
        }

    }
}