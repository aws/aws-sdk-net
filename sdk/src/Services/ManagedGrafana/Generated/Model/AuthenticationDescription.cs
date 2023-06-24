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
 * Do not modify this file. This file is generated from the grafana-2020-08-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ManagedGrafana.Model
{
    /// <summary>
    /// A structure containing information about the user authentication methods used by the
    /// workspace.
    /// </summary>
    public partial class AuthenticationDescription
    {
        private AwsSsoAuthentication _awsSso;
        private List<string> _providers = new List<string>();
        private SamlAuthentication _saml;

        /// <summary>
        /// Gets and sets the property AwsSso. 
        /// <para>
        /// A structure containing information about how this workspace works with IAM Identity
        /// Center. 
        /// </para>
        /// </summary>
        public AwsSsoAuthentication AwsSso
        {
            get { return this._awsSso; }
            set { this._awsSso = value; }
        }

        // Check to see if AwsSso property is set
        internal bool IsSetAwsSso()
        {
            return this._awsSso != null;
        }

        /// <summary>
        /// Gets and sets the property Providers. 
        /// <para>
        /// Specifies whether this workspace uses IAM Identity Center, SAML, or both methods to
        /// authenticate users to use the Grafana console in the Amazon Managed Grafana workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Providers
        {
            get { return this._providers; }
            set { this._providers = value; }
        }

        // Check to see if Providers property is set
        internal bool IsSetProviders()
        {
            return this._providers != null && this._providers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Saml. 
        /// <para>
        /// A structure containing information about how this workspace works with SAML, including
        /// what attributes within the assertion are to be mapped to user information in the workspace.
        /// 
        /// </para>
        /// </summary>
        public SamlAuthentication Saml
        {
            get { return this._saml; }
            set { this._saml = value; }
        }

        // Check to see if Saml property is set
        internal bool IsSetSaml()
        {
            return this._saml != null;
        }

    }
}