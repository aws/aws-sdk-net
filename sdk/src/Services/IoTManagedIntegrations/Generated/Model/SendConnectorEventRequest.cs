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
    /// Container for the parameters to the SendConnectorEvent operation.
    /// Relays third-party device events for a connector such as a new device or a device
    /// state change event.
    /// </summary>
    public partial class SendConnectorEventRequest : AmazonIoTManagedIntegrationsRequest
    {
        private string _connectorDeviceId;
        private string _connectorId;
        private string _deviceDiscoveryId;
        private List<Device> _devices = AWSConfigs.InitializeCollections ? new List<Device>() : null;
        private MatterEndpoint _matterEndpoint;
        private string _message;
        private ConnectorEventOperation _operation;
        private string _operationVersion;
        private int? _statusCode;
        private string _traceId;
        private string _userId;

        /// <summary>
        /// Gets and sets the property ConnectorDeviceId. 
        /// <para>
        /// The third-party device id as defined by the connector. This device id must not contain
        /// personal identifiable information (PII).
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is used for cloud-to-cloud devices only.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=256)]
        public string ConnectorDeviceId
        {
            get { return this._connectorDeviceId; }
            set { this._connectorDeviceId = value; }
        }

        // Check to see if ConnectorDeviceId property is set
        internal bool IsSetConnectorDeviceId()
        {
            return this._connectorDeviceId != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectorId. 
        /// <para>
        /// The id of the connector between the third-party cloud provider and IoT managed integrations.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// Gets and sets the property DeviceDiscoveryId. 
        /// <para>
        /// The id for the device discovery job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string DeviceDiscoveryId
        {
            get { return this._deviceDiscoveryId; }
            set { this._deviceDiscoveryId = value; }
        }

        // Check to see if DeviceDiscoveryId property is set
        internal bool IsSetDeviceDiscoveryId()
        {
            return this._deviceDiscoveryId != null;
        }

        /// <summary>
        /// Gets and sets the property Devices. 
        /// <para>
        /// The list of devices.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Device> Devices
        {
            get { return this._devices; }
            set { this._devices = value; }
        }

        // Check to see if Devices property is set
        internal bool IsSetDevices()
        {
            return this._devices != null && (this._devices.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MatterEndpoint. 
        /// <para>
        /// The device endpoint.
        /// </para>
        /// </summary>
        public MatterEndpoint MatterEndpoint
        {
            get { return this._matterEndpoint; }
            set { this._matterEndpoint = value; }
        }

        // Check to see if MatterEndpoint property is set
        internal bool IsSetMatterEndpoint()
        {
            return this._matterEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The device state change event payload.
        /// </para>
        ///  
        /// <para>
        /// This parameter will include the following three fields:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>uri</c>: <c>schema auc://&lt;PARTNER-DEVICE-ID&gt;/ResourcePath</c> (The <c>Resourcepath</c>
        /// corresponds to an OCF resource.)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>op</c>: For device state changes, this field must populate as <c>n+d</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>cn</c>: The content depends on the OCF resource referenced in <c>ResourcePath</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=256)]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property Operation. 
        /// <para>
        /// The Open Connectivity Foundation (OCF) operation requested to be performed on the
        /// managed thing.
        /// </para>
        ///  <note> 
        /// <para>
        /// The field op can have a value of "I" or "U". The field "cn" will contain the capability
        /// types.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConnectorEventOperation Operation
        {
            get { return this._operation; }
            set { this._operation = value; }
        }

        // Check to see if Operation property is set
        internal bool IsSetOperation()
        {
            return this._operation != null;
        }

        /// <summary>
        /// Gets and sets the property OperationVersion. 
        /// <para>
        /// The Open Connectivity Foundation (OCF) security specification version for the operation
        /// being requested on the managed thing. For more information, see <a href="https://openconnectivity.org/specs/OCF_Security_Specification_v1.0.0.pdf">OCF
        /// Security Specification</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=6)]
        public string OperationVersion
        {
            get { return this._operationVersion; }
            set { this._operationVersion = value; }
        }

        // Check to see if OperationVersion property is set
        internal bool IsSetOperationVersion()
        {
            return this._operationVersion != null;
        }

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// The status code of the Open Connectivity Foundation (OCF) operation being performed
        /// on the managed thing.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=100, Max=550)]
        public int? StatusCode
        {
            get { return this._statusCode; }
            set { this._statusCode = value; }
        }

        // Check to see if StatusCode property is set
        internal bool IsSetStatusCode()
        {
            return this._statusCode.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TraceId. 
        /// <para>
        /// The trace request identifier used to correlate a command request and response. This
        /// is specified by the device owner, but will be generated by IoT managed integrations
        /// if not provided by the device owner.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string TraceId
        {
            get { return this._traceId; }
            set { this._traceId = value; }
        }

        // Check to see if TraceId property is set
        internal bool IsSetTraceId()
        {
            return this._traceId != null;
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The id of the third-party cloud provider.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=64)]
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

    }
}