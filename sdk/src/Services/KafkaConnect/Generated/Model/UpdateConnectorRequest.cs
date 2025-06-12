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
 * Do not modify this file. This file is generated from the kafkaconnect-2021-09-14.normal.json service model.
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
namespace Amazon.KafkaConnect.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateConnector operation.
    /// Updates the specified connector.
    /// </summary>
    public partial class UpdateConnectorRequest : AmazonKafkaConnectRequest
    {
        private CapacityUpdate _capacity;
        private string _connectorArn;
        private Dictionary<string, string> _connectorConfiguration = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _currentVersion;

        /// <summary>
        /// Gets and sets the property Capacity. 
        /// <para>
        /// The target capacity.
        /// </para>
        /// </summary>
        public CapacityUpdate Capacity
        {
            get { return this._capacity; }
            set { this._capacity = value; }
        }

        // Check to see if Capacity property is set
        internal bool IsSetCapacity()
        {
            return this._capacity != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the connector that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ConnectorArn
        {
            get { return this._connectorArn; }
            set { this._connectorArn = value; }
        }

        // Check to see if ConnectorArn property is set
        internal bool IsSetConnectorArn()
        {
            return this._connectorArn != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectorConfiguration. 
        /// <para>
        /// A map of keys to values that represent the configuration for the connector.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, string> ConnectorConfiguration
        {
            get { return this._connectorConfiguration; }
            set { this._connectorConfiguration = value; }
        }

        // Check to see if ConnectorConfiguration property is set
        internal bool IsSetConnectorConfiguration()
        {
            return this._connectorConfiguration != null && (this._connectorConfiguration.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CurrentVersion. 
        /// <para>
        /// The current version of the connector that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CurrentVersion
        {
            get { return this._currentVersion; }
            set { this._currentVersion = value; }
        }

        // Check to see if CurrentVersion property is set
        internal bool IsSetCurrentVersion()
        {
            return this._currentVersion != null;
        }

    }
}