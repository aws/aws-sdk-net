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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The connectorV2 third-party provider configuration summary.
    /// </summary>
    public partial class ProviderSummary
    {
        /// <summary>
        /// Gets and sets the property ConnectorStatus. 
        /// <para>
        /// The status for the connectorV2.
        /// </para>
        /// </summary>
        public ConnectorStatus ConnectorStatus { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorStatus property is set.
        /// </summary>
        internal bool IsSetConnectorStatus() => this.ConnectorStatus != null;

        /// <summary>
        /// Gets and sets the property ProviderConfiguration.
        /// </summary>
        public ProviderDetail ProviderConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ProviderConfiguration property is set.
        /// </summary>
        internal bool IsSetProviderConfiguration() => this.ProviderConfiguration != null;

        /// <summary>
        /// Gets and sets the property ProviderName. 
        /// <para>
        /// The name of the provider.
        /// </para>
        /// </summary>
        public ConnectorProviderName ProviderName { get; set; }

        /// <summary>
        /// Checks to see if the ProviderName property is set.
        /// </summary>
        internal bool IsSetProviderName() => this.ProviderName != null;
    }
}
