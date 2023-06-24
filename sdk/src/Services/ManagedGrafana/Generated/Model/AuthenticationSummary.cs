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
    /// A structure that describes whether the workspace uses SAML, IAM Identity Center, or
    /// both methods for user authentication, and whether that authentication is fully configured.
    /// </summary>
    public partial class AuthenticationSummary
    {
        private List<string> _providers = new List<string>();
        private SamlConfigurationStatus _samlConfigurationStatus;

        /// <summary>
        /// Gets and sets the property Providers. 
        /// <para>
        /// Specifies whether the workspace uses SAML, IAM Identity Center, or both methods for
        /// user authentication.
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
        /// Gets and sets the property SamlConfigurationStatus. 
        /// <para>
        /// Specifies whether the workplace's user authentication method is fully configured.
        /// </para>
        /// </summary>
        public SamlConfigurationStatus SamlConfigurationStatus
        {
            get { return this._samlConfigurationStatus; }
            set { this._samlConfigurationStatus = value; }
        }

        // Check to see if SamlConfigurationStatus property is set
        internal bool IsSetSamlConfigurationStatus()
        {
            return this._samlConfigurationStatus != null;
        }

    }
}