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
 * Do not modify this file. This file is generated from the iot-managed-integrations-2025-03-03.normal.json service model.
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
namespace Amazon.IoTManagedIntegrations.Model
{
    /// <summary>
    /// The authorization material containing the Secrets Manager arn and version.
    /// </summary>
    public partial class AuthMaterial
    {
        private string _authMaterialName;
        private SecretsManager _secretsManager;

        /// <summary>
        /// Gets and sets the property AuthMaterialName. 
        /// <para>
        /// The name of the authorization material.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string AuthMaterialName
        {
            get { return this._authMaterialName; }
            set { this._authMaterialName = value; }
        }

        // Check to see if AuthMaterialName property is set
        internal bool IsSetAuthMaterialName()
        {
            return this._authMaterialName != null;
        }

        /// <summary>
        /// Gets and sets the property SecretsManager.
        /// </summary>
        [AWSProperty(Required=true)]
        public SecretsManager SecretsManager
        {
            get { return this._secretsManager; }
            set { this._secretsManager = value; }
        }

        // Check to see if SecretsManager property is set
        internal bool IsSetSecretsManager()
        {
            return this._secretsManager != null;
        }

    }
}