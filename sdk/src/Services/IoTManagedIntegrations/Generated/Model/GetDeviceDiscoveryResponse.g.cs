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
    /// This is the response object from the GetDeviceDiscovery operation.
    /// </summary>
    public partial class GetDeviceDiscoveryResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AccountAssociationId. 
        /// <para>
        /// The identifier of the account association used for the device discovery.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string AccountAssociationId { get; set; }

        /// <summary>
        /// Checks to see if the AccountAssociationId property is set.
        /// </summary>
        internal bool IsSetAccountAssociationId() => this.AccountAssociationId != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the device discovery job request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property ConnectorAssociationId. 
        /// <para>
        /// The ID tracking the current discovery process for one connector association.
        /// </para>
        /// </summary>
        [Obsolete("ConnectorAssociationId has been deprecated")]
        [AWSProperty(Min = 1, Max = 64)]
        public string ConnectorAssociationId { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorAssociationId property is set.
        /// </summary>
        internal bool IsSetConnectorAssociationId() => this.ConnectorAssociationId != null;

        /// <summary>
        /// Gets and sets the property ControllerId. 
        /// <para>
        /// The id of the end-user's IoT hub.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ControllerId { get; set; }

        /// <summary>
        /// Checks to see if the ControllerId property is set.
        /// </summary>
        internal bool IsSetControllerId() => this.ControllerId != null;

        /// <summary>
        /// Gets and sets the property DiscoveryType. 
        /// <para>
        /// The discovery type supporting the type of device to be discovered in the device discovery
        /// job request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DiscoveryType DiscoveryType { get; set; }

        /// <summary>
        /// Checks to see if the DiscoveryType property is set.
        /// </summary>
        internal bool IsSetDiscoveryType() => this.DiscoveryType != null;

        /// <summary>
        /// Gets and sets the property FinishedAt. 
        /// <para>
        /// The timestamp value for the completion time of the device discovery.
        /// </para>
        /// </summary>
        public DateTime? FinishedAt { get; set; }

        /// <summary>
        /// Checks to see if the FinishedAt property is set.
        /// </summary>
        internal bool IsSetFinishedAt() => this.FinishedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The id of the device discovery job request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The timestamp value for the start time of the device discovery.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Checks to see if the StartedAt property is set.
        /// </summary>
        internal bool IsSetStartedAt() => this.StartedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the device discovery job request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DeviceDiscoveryStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A set of key/value pairs that are used to manage the device discovery request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [Obsolete("Tags have been deprecated from this api")]
        [AWSProperty(Sensitive = true, Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
