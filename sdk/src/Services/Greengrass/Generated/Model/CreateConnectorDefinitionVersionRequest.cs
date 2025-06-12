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
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
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
namespace Amazon.Greengrass.Model
{
    /// <summary>
    /// Container for the parameters to the CreateConnectorDefinitionVersion operation.
    /// Creates a version of a connector definition which has already been defined.
    /// </summary>
    public partial class CreateConnectorDefinitionVersionRequest : AmazonGreengrassRequest
    {
        private string _amznClientToken;
        private string _connectorDefinitionId;
        private List<Connector> _connectors = AWSConfigs.InitializeCollections ? new List<Connector>() : null;

        /// <summary>
        /// Gets and sets the property AmznClientToken. A client token used to correlate requests
        /// and responses.
        /// </summary>
        public string AmznClientToken
        {
            get { return this._amznClientToken; }
            set { this._amznClientToken = value; }
        }

        // Check to see if AmznClientToken property is set
        internal bool IsSetAmznClientToken()
        {
            return this._amznClientToken != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectorDefinitionId. The ID of the connector definition.
        /// </summary>
        [AWSProperty(Required=true)]
        public string ConnectorDefinitionId
        {
            get { return this._connectorDefinitionId; }
            set { this._connectorDefinitionId = value; }
        }

        // Check to see if ConnectorDefinitionId property is set
        internal bool IsSetConnectorDefinitionId()
        {
            return this._connectorDefinitionId != null;
        }

        /// <summary>
        /// Gets and sets the property Connectors. A list of references to connectors in this
        /// version, with their corresponding configuration settings.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Connector> Connectors
        {
            get { return this._connectors; }
            set { this._connectors = value; }
        }

        // Check to see if Connectors property is set
        internal bool IsSetConnectors()
        {
            return this._connectors != null && (this._connectors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}