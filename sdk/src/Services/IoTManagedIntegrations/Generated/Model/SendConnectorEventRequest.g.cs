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

namespace Amazon.IoTManagedIntegrations.Model
{
    /// <summary>
    /// Container for the parameters to the SendConnectorEvent operation. Relays third-party
    /// device events for a connector such as a new device or a device state change event.
    /// </summary>
    public partial class SendConnectorEventRequest : AmazonIoTManagedIntegrationsRequest
    {
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
        [AWSProperty(Sensitive = true, Min = 1, Max = 256)]
        public string ConnectorDeviceId { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorDeviceId property is set.
        /// </summary>
        internal bool IsSetConnectorDeviceId() => this.ConnectorDeviceId != null;

        /// <summary>
        /// Gets and sets the property ConnectorId. 
        /// <para>
        /// The id of the connector between the third-party cloud provider and IoT managed integrations.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ConnectorId { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorId property is set.
        /// </summary>
        internal bool IsSetConnectorId() => this.ConnectorId != null;

        /// <summary>
        /// Gets and sets the property DeviceDiscoveryId. 
        /// <para>
        /// The id for the device discovery job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string DeviceDiscoveryId { get; set; }

        /// <summary>
        /// Checks to see if the DeviceDiscoveryId property is set.
        /// </summary>
        internal bool IsSetDeviceDiscoveryId() => this.DeviceDiscoveryId != null;

        /// <summary>
        /// Gets and sets the property Devices. 
        /// <para>
        /// The list of devices.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Device> Devices { get; set; } = AWSConfigs.InitializeCollections ? new List<Device>() : null;

        /// <summary>
        /// Checks to see if the Devices property is set.
        /// </summary>
        internal bool IsSetDevices() => this.Devices != null && (this.Devices.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MatterEndpoint. 
        /// <para>
        /// The device endpoint.
        /// </para>
        /// </summary>
        public MatterEndpoint MatterEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the MatterEndpoint property is set.
        /// </summary>
        internal bool IsSetMatterEndpoint() => this.MatterEndpoint != null;

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
        [AWSProperty(Sensitive = true, Min = 1, Max = 256)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

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
        [AWSProperty(Required = true)]
        public ConnectorEventOperation Operation { get; set; }

        /// <summary>
        /// Checks to see if the Operation property is set.
        /// </summary>
        internal bool IsSetOperation() => this.Operation != null;

        /// <summary>
        /// Gets and sets the property OperationVersion. 
        /// <para>
        /// The Open Connectivity Foundation (OCF) security specification version for the operation
        /// being requested on the managed thing. For more information, see <a href="https://openconnectivity.org/specs/OCF_Security_Specification_v1.0.0.pdf">OCF
        /// Security Specification</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 6)]
        public string OperationVersion { get; set; }

        /// <summary>
        /// Checks to see if the OperationVersion property is set.
        /// </summary>
        internal bool IsSetOperationVersion() => this.OperationVersion != null;

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// The status code of the Open Connectivity Foundation (OCF) operation being performed
        /// on the managed thing.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 100, Max = 550)]
        public int? StatusCode { get; set; }

        /// <summary>
        /// Checks to see if the StatusCode property is set.
        /// </summary>
        internal bool IsSetStatusCode() => this.StatusCode.HasValue;

        /// <summary>
        /// Gets and sets the property TraceId. 
        /// <para>
        /// The trace request identifier. This is generated by IoT managed integrations and can
        /// be used to trace this command and its related operations in CloudWatch.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string TraceId { get; set; }

        /// <summary>
        /// Checks to see if the TraceId property is set.
        /// </summary>
        internal bool IsSetTraceId() => this.TraceId != null;

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The id of the third-party cloud provider.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 64)]
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;
    }
}
