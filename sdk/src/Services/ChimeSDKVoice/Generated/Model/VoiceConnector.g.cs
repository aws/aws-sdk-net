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

namespace Amazon.ChimeSDKVoice.Model
{
    /// <summary>
    /// The Amazon Chime SDK Voice Connector configuration, including outbound host name and
    /// encryption settings.
    /// </summary>
    public partial class VoiceConnector
    {
        /// <summary>
        /// Gets and sets the property AwsRegion. 
        /// <para>
        /// The AWS Region in which the Voice Connector is created. Default: us-east-1.
        /// </para>
        /// </summary>
        public VoiceConnectorAwsRegion AwsRegion { get; set; }

        /// <summary>
        /// Checks to see if the AwsRegion property is set.
        /// </summary>
        internal bool IsSetAwsRegion() => this.AwsRegion != null;

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The Voice Connector's creation timestamp, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimestamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimestamp() => this.CreatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property IntegrationType. 
        /// <para>
        /// The connectors for use with Connect Customer.
        /// </para>
        /// </summary>
        public VoiceConnectorIntegrationType IntegrationType { get; set; }

        /// <summary>
        /// Checks to see if the IntegrationType property is set.
        /// </summary>
        internal bool IsSetIntegrationType() => this.IntegrationType != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The Voice Connector's name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NetworkType. 
        /// <para>
        /// The type of network for the Voice Connector.
        /// </para>
        /// </summary>
        public NetworkType NetworkType { get; set; }

        /// <summary>
        /// Checks to see if the NetworkType property is set.
        /// </summary>
        internal bool IsSetNetworkType() => this.NetworkType != null;

        /// <summary>
        /// Gets and sets the property OutboundHostName. 
        /// <para>
        /// The outbound host name for the Voice Connector.
        /// </para>
        /// </summary>
        public string OutboundHostName { get; set; }

        /// <summary>
        /// Checks to see if the OutboundHostName property is set.
        /// </summary>
        internal bool IsSetOutboundHostName() => this.OutboundHostName != null;

        /// <summary>
        /// Gets and sets the property RequireEncryption. 
        /// <para>
        /// Enables or disables encryption for the Voice Connector.
        /// </para>
        /// </summary>
        public bool? RequireEncryption { get; set; }

        /// <summary>
        /// Checks to see if the RequireEncryption property is set.
        /// </summary>
        internal bool IsSetRequireEncryption() => this.RequireEncryption.HasValue;

        /// <summary>
        /// Gets and sets the property UpdatedTimestamp. 
        /// <para>
        /// The Voice Connector's updated timestamp, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime? UpdatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedTimestamp property is set.
        /// </summary>
        internal bool IsSetUpdatedTimestamp() => this.UpdatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property VoiceConnectorArn. 
        /// <para>
        /// The ARN of the Voice Connector.
        /// </para>
        /// </summary>
        public string VoiceConnectorArn { get; set; }

        /// <summary>
        /// Checks to see if the VoiceConnectorArn property is set.
        /// </summary>
        internal bool IsSetVoiceConnectorArn() => this.VoiceConnectorArn != null;

        /// <summary>
        /// Gets and sets the property VoiceConnectorId. 
        /// <para>
        /// The Voice Connector's ID.
        /// </para>
        /// </summary>
        public string VoiceConnectorId { get; set; }

        /// <summary>
        /// Checks to see if the VoiceConnectorId property is set.
        /// </summary>
        internal bool IsSetVoiceConnectorId() => this.VoiceConnectorId != null;
    }
}
