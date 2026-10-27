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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
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
namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// The authentication configuration for connecting to the source during migration.
    /// </summary>
    public partial class SourceAuthenticationConfiguration
    {
        private SecretManagerAuthConfig _secretManagerConfig;

        /// <summary>
        /// Gets and sets the property SecretManagerConfig. 
        /// <para>
        /// The Secrets Manager configuration used for authenticating with the source during migration.
        /// </para>
        /// </summary>
        public SecretManagerAuthConfig SecretManagerConfig
        {
            get { return this._secretManagerConfig; }
            set { this._secretManagerConfig = value; }
        }

        // Check to see if SecretManagerConfig property is set
        internal bool IsSetSecretManagerConfig()
        {
            return this._secretManagerConfig != null;
        }

    }
}