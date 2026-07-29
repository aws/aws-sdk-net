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
    /// The configuration details for connecting to Microsoft Azure.
    /// </summary>
    public partial class AzureConnectorConfiguration
    {
        private string _clientIdentifier;
        private string _tenantIdentifier;

        /// <summary>
        /// Gets and sets the property ClientIdentifier. 
        /// <para>
        /// The Azure client identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ClientIdentifier
        {
            get { return this._clientIdentifier; }
            set { this._clientIdentifier = value; }
        }

        // Check to see if ClientIdentifier property is set
        internal bool IsSetClientIdentifier()
        {
            return this._clientIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property TenantIdentifier. 
        /// <para>
        /// The Azure tenant identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string TenantIdentifier
        {
            get { return this._tenantIdentifier; }
            set { this._tenantIdentifier = value; }
        }

        // Check to see if TenantIdentifier property is set
        internal bool IsSetTenantIdentifier()
        {
            return this._tenantIdentifier != null;
        }

    }
}