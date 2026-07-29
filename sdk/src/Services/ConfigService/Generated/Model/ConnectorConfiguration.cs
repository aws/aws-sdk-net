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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// The provider-specific configuration for connecting to the third-party cloud service
    /// provider. You must specify exactly one provider configuration.
    /// </summary>
    public partial class ConnectorConfiguration
    {
        private AzureConnectorConfiguration _azure;

        /// <summary>
        /// Gets and sets the property Azure. 
        /// <para>
        /// The configuration for an Azure connector.
        /// </para>
        /// </summary>
        public AzureConnectorConfiguration Azure
        {
            get { return this._azure; }
            set { this._azure = value; }
        }

        // Check to see if Azure property is set
        internal bool IsSetAzure()
        {
            return this._azure != null;
        }

    }
}