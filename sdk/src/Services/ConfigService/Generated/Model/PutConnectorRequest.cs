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
    /// Container for the parameters to the PutConnector operation.
    /// Creates a connector that specifies the connection between a third-party cloud service
    /// provider and Config.
    /// 
    ///  
    /// <para>
    /// A connector is required to create a service-linked configuration recorder for a third-party
    /// cloud service provider using the <a href="https://docs.aws.amazon.com/config/latest/APIReference/API_PutThirdPartyServiceLinkedConfigurationRecorder.html">PutThirdPartyServiceLinkedConfigurationRecorder</a>
    /// operation.
    /// </para>
    ///  
    /// <para>
    /// This API creates a service-linked role <c>AWSServiceRoleForConfigThirdParty</c> in
    /// your account. The service-linked role is created only when the role does not exist
    /// in your account.
    /// </para>
    ///  <note> 
    /// <para>
    ///  <b>Connectors cannot be updated</b> 
    /// </para>
    ///  
    /// <para>
    /// To update the connector configuration, you must delete all associated configuration
    /// recorders, delete the connector, and recreate it with the updated configuration.
    /// </para>
    ///  </note> <note> 
    /// <para>
    ///  <b>Tags are added at creation and cannot be updated with this operation</b> 
    /// </para>
    ///  
    /// <para>
    /// Use <a href="https://docs.aws.amazon.com/config/latest/APIReference/API_TagResource.html">TagResource</a>
    /// and <a href="https://docs.aws.amazon.com/config/latest/APIReference/API_UntagResource.html">UntagResource</a>
    /// to update tags after creation.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class PutConnectorRequest : AmazonConfigServiceRequest
    {
        private ConnectorConfiguration _connectorConfiguration;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property ConnectorConfiguration. 
        /// <para>
        /// The provider-specific configuration for connecting to the third-party cloud service
        /// provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConnectorConfiguration ConnectorConfiguration
        {
            get { return this._connectorConfiguration; }
            set { this._connectorConfiguration = value; }
        }

        // Check to see if ConnectorConfiguration property is set
        internal bool IsSetConnectorConfiguration()
        {
            return this._connectorConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags for the connector. Each tag consists of a key and an optional value, both
        /// of which you define.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}