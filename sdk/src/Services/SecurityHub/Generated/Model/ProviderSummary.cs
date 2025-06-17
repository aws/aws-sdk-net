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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The connectorV2 third-party provider configuration summary.
    /// </summary>
    public partial class ProviderSummary
    {
        private ConnectorStatus _connectorStatus;
        private ConnectorProviderName _providerName;

        /// <summary>
        /// Gets and sets the property ConnectorStatus. 
        /// <para>
        /// The status for the connectorV2.
        /// </para>
        /// </summary>
        public ConnectorStatus ConnectorStatus
        {
            get { return this._connectorStatus; }
            set { this._connectorStatus = value; }
        }

        // Check to see if ConnectorStatus property is set
        internal bool IsSetConnectorStatus()
        {
            return this._connectorStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ProviderName. 
        /// <para>
        /// The name of the provider.
        /// </para>
        /// </summary>
        public ConnectorProviderName ProviderName
        {
            get { return this._providerName; }
            set { this._providerName = value; }
        }

        // Check to see if ProviderName property is set
        internal bool IsSetProviderName()
        {
            return this._providerName != null;
        }

    }
}