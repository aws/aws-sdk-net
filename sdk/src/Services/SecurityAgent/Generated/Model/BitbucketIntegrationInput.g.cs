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

namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// The configuration for creating a Bitbucket integration.
    /// </summary>
    public partial class BitbucketIntegrationInput
    {
        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The OAuth 2.0 authorization code returned from the consent redirect.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Code { get; set; }

        /// <summary>
        /// Checks to see if the Code property is set.
        /// </summary>
        internal bool IsSetCode() => this.Code != null;

        /// <summary>
        /// Gets and sets the property InstallationId. 
        /// <para>
        /// The Atlassian installation identifier, available from the Atlassian administration
        /// console.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string InstallationId { get; set; }

        /// <summary>
        /// Checks to see if the InstallationId property is set.
        /// </summary>
        internal bool IsSetInstallationId() => this.InstallationId != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The CSRF state token echoed back from the OAuth redirect.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Workspace. 
        /// <para>
        /// The Bitbucket workspace slug that identifies the workspace to integrate, for example
        /// acme-corp.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Workspace { get; set; }

        /// <summary>
        /// Checks to see if the Workspace property is set.
        /// </summary>
        internal bool IsSetWorkspace() => this.Workspace != null;
    }
}
