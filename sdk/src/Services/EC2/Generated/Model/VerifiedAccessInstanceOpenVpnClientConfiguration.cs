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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a set of routes.
    /// </summary>
    public partial class VerifiedAccessInstanceOpenVpnClientConfiguration
    {
        private string _config;
        private List<VerifiedAccessInstanceOpenVpnClientConfigurationRoute> _routes = AWSConfigs.InitializeCollections ? new List<VerifiedAccessInstanceOpenVpnClientConfigurationRoute>() : null;

        /// <summary>
        /// Gets and sets the property Config. 
        /// <para>
        /// The base64-encoded Open VPN client configuration.
        /// </para>
        /// </summary>
        public string Config
        {
            get { return this._config; }
            set { this._config = value; }
        }

        // Check to see if Config property is set
        internal bool IsSetConfig()
        {
            return this._config != null;
        }

        /// <summary>
        /// Gets and sets the property Routes. 
        /// <para>
        /// The routes.
        /// </para>
        /// </summary>
        public List<VerifiedAccessInstanceOpenVpnClientConfigurationRoute> Routes
        {
            get { return this._routes; }
            set { this._routes = value; }
        }

        // Check to see if Routes property is set
        internal bool IsSetRoutes()
        {
            return this._routes != null && (this._routes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}