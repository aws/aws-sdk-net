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

namespace Amazon.KafkaConnect.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateConnector operation. Updates the specified
    /// connector. For request body, specify only one parameter: either <c>capacity</c> or
    /// <c>connectorConfiguration</c>.
    /// </summary>
    public partial class UpdateConnectorRequest : AmazonKafkaConnectRequest
    {
        /// <summary>
        /// Gets and sets the property Capacity. 
        /// <para>
        /// The target capacity.
        /// </para>
        /// </summary>
        public CapacityUpdate Capacity { get; set; }

        /// <summary>
        /// Checks to see if the Capacity property is set.
        /// </summary>
        internal bool IsSetCapacity() => this.Capacity != null;

        /// <summary>
        /// Gets and sets the property ConnectorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the connector that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ConnectorArn { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorArn property is set.
        /// </summary>
        internal bool IsSetConnectorArn() => this.ConnectorArn != null;

        /// <summary>
        /// Gets and sets the property ConnectorConfiguration. 
        /// <para>
        /// A map of keys to values that represent the configuration for the connector.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Dictionary<string, string> ConnectorConfiguration { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the ConnectorConfiguration property is set.
        /// </summary>
        internal bool IsSetConnectorConfiguration() => this.ConnectorConfiguration != null && (this.ConnectorConfiguration.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CurrentVersion. 
        /// <para>
        /// The current version of the connector that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CurrentVersion { get; set; }

        /// <summary>
        /// Checks to see if the CurrentVersion property is set.
        /// </summary>
        internal bool IsSetCurrentVersion() => this.CurrentVersion != null;

        /// <summary>
        /// Gets and sets the property SkipHealthValidation. 
        /// <para>
        /// Specifies whether the update bypasses connector-level and task-level health checks.
        /// If <c>true</c>, the update skips the health checks. The update stays in effect even
        /// if the connector or its tasks are unhealthy, and Amazon MSK Connect doesn't roll it
        /// back. If <c>false</c> or not specified, the health checks run. If they fail, MSK Connect
        /// automatically rolls the connector back to its previous configuration, and the update
        /// doesn't take effect. To update a connector that is in the <c>PAUSED</c> state, you
        /// must set this parameter to <c>true</c>.
        /// </para>
        /// </summary>
        public bool? SkipHealthValidation { get; set; }

        /// <summary>
        /// Checks to see if the SkipHealthValidation property is set.
        /// </summary>
        internal bool IsSetSkipHealthValidation() => this.SkipHealthValidation.HasValue;
    }
}
