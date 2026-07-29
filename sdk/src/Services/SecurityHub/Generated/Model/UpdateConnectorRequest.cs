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
    /// Container for the parameters to the UpdateConnector operation.
    /// Updates a CSPM connector's configuration, such as the scope or regions for the connected
    /// cloud provider.
    /// </summary>
    public partial class UpdateConnectorRequest : AmazonSecurityHubRequest
    {
        private string _connectorId;
        private string _description;
        private CspmProviderUpdateConfiguration _provider;

        /// <summary>
        /// Gets and sets the property ConnectorId. 
        /// <para>
        /// The unique identifier of the connector to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ConnectorId
        {
            get { return this._connectorId; }
            set { this._connectorId = value; }
        }

        // Check to see if ConnectorId property is set
        internal bool IsSetConnectorId()
        {
            return this._connectorId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The updated description of the connector.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Provider. 
        /// <para>
        /// The updated cloud provider configuration for the connector.
        /// </para>
        /// </summary>
        public CspmProviderUpdateConfiguration Provider
        {
            get { return this._provider; }
            set { this._provider = value; }
        }

        // Check to see if Provider property is set
        internal bool IsSetProvider()
        {
            return this._provider != null;
        }

    }
}