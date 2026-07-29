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
    /// The configuration for creating a Bitbucket integration.
    /// </summary>
    public partial class BitbucketIntegrationInput
    {
        private string _code;
        private string _installationId;
        private string _state;
        private string _workspace;

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The OAuth 2.0 authorization code returned from the consent redirect.
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
        /// The Atlassian installation identifier, available from the Atlassian administration
        /// console.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property State. 
        /// <para>
        /// The CSRF state token echoed back from the OAuth redirect.
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
        /// Gets and sets the property Workspace. 
        /// <para>
        /// The Bitbucket workspace slug that identifies the workspace to integrate, for example
        /// acme-corp.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Workspace
        {
            get { return this._workspace; }
            set { this._workspace = value; }
        }

        // Check to see if Workspace property is set
        internal bool IsSetWorkspace()
        {
            return this._workspace != null;
        }

    }
}