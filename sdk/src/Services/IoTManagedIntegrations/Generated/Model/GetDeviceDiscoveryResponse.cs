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
 * Do not modify this file. This file is generated from the iot-managed-integrations-2025-03-03.normal.json service model.
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
namespace Amazon.IoTManagedIntegrations.Model
{
    /// <summary>
    /// This is the response object from the GetDeviceDiscovery operation.
    /// </summary>
    public partial class GetDeviceDiscoveryResponse : AmazonWebServiceResponse
    {
        private string _accountAssociationId;
        private string _arn;
        private string _connectorAssociationId;
        private string _controllerId;
        private DiscoveryType _discoveryType;
        private DateTime? _finishedAt;
        private string _id;
        private DateTime? _startedAt;
        private DeviceDiscoveryStatus _status;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AccountAssociationId. 
        /// <para>
        /// The identifier of the account association used for the device discovery.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string AccountAssociationId
        {
            get { return this._accountAssociationId; }
            set { this._accountAssociationId = value; }
        }

        // Check to see if AccountAssociationId property is set
        internal bool IsSetAccountAssociationId()
        {
            return this._accountAssociationId != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the device discovery job request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectorAssociationId. 
        /// <para>
        /// The ID tracking the current discovery process for one connector association.
        /// </para>
        /// </summary>
        [Obsolete("ConnectorAssociationId has been deprecated")]
        [AWSProperty(Min=1, Max=64)]
        public string ConnectorAssociationId
        {
            get { return this._connectorAssociationId; }
            set { this._connectorAssociationId = value; }
        }

        // Check to see if ConnectorAssociationId property is set
        internal bool IsSetConnectorAssociationId()
        {
            return this._connectorAssociationId != null;
        }

        /// <summary>
        /// Gets and sets the property ControllerId. 
        /// <para>
        /// The id of the end-user's IoT hub.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ControllerId
        {
            get { return this._controllerId; }
            set { this._controllerId = value; }
        }

        // Check to see if ControllerId property is set
        internal bool IsSetControllerId()
        {
            return this._controllerId != null;
        }

        /// <summary>
        /// Gets and sets the property DiscoveryType. 
        /// <para>
        /// The discovery type supporting the type of device to be discovered in the device discovery
        /// job request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DiscoveryType DiscoveryType
        {
            get { return this._discoveryType; }
            set { this._discoveryType = value; }
        }

        // Check to see if DiscoveryType property is set
        internal bool IsSetDiscoveryType()
        {
            return this._discoveryType != null;
        }

        /// <summary>
        /// Gets and sets the property FinishedAt. 
        /// <para>
        /// The timestamp value for the completion time of the device discovery.
        /// </para>
        /// </summary>
        public DateTime? FinishedAt
        {
            get { return this._finishedAt; }
            set { this._finishedAt = value; }
        }

        // Check to see if FinishedAt property is set
        internal bool IsSetFinishedAt()
        {
            return this._finishedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The id of the device discovery job request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The timestamp value for the start time of the device discovery.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? StartedAt
        {
            get { return this._startedAt; }
            set { this._startedAt = value; }
        }

        // Check to see if StartedAt property is set
        internal bool IsSetStartedAt()
        {
            return this._startedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the device discovery job request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DeviceDiscoveryStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A set of key/value pairs that are used to manage the device discovery request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [Obsolete("Tags have been deprecated from this api")]
        [AWSProperty(Sensitive=true, Min=1, Max=50)]
        public Dictionary<string, string> Tags
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