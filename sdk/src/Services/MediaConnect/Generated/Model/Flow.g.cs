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

namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// The settings for a flow, including its source, outputs, and entitlements.
    /// </summary>
    public partial class Flow
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        ///  The Availability Zone that you want to create the flow in. These options are limited
        /// to the Availability Zones within the current Amazon Web Services Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  A description of the flow. This value is not used or seen outside of the current
        /// MediaConnect account.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EgressIp. 
        /// <para>
        ///  The IP address from which video will be sent to output destinations.
        /// </para>
        /// </summary>
        public string EgressIp { get; set; }

        /// <summary>
        /// Checks to see if the EgressIp property is set.
        /// </summary>
        internal bool IsSetEgressIp() => this.EgressIp != null;

        /// <summary>
        /// Gets and sets the property EncodingConfig. 
        /// <para>
        ///  The encoding configuration to apply to the NDI® source when transcoding it to a transport
        /// stream for downstream distribution. 
        /// </para>
        /// </summary>
        public EncodingConfig EncodingConfig { get; set; }

        /// <summary>
        /// Checks to see if the EncodingConfig property is set.
        /// </summary>
        internal bool IsSetEncodingConfig() => this.EncodingConfig != null;

        /// <summary>
        /// Gets and sets the property Entitlements. 
        /// <para>
        ///  The entitlements in this flow.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<Entitlement> Entitlements { get; set; } = AWSConfigs.InitializeCollections ? new List<Entitlement>() : null;

        /// <summary>
        /// Checks to see if the Entitlements property is set.
        /// </summary>
        internal bool IsSetEntitlements() => this.Entitlements != null && (this.Entitlements.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FlowArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FlowArn { get; set; }

        /// <summary>
        /// Checks to see if the FlowArn property is set.
        /// </summary>
        internal bool IsSetFlowArn() => this.FlowArn != null;

        /// <summary>
        /// Gets and sets the property FlowSize. 
        /// <para>
        ///  Determines the processing capacity and feature set of the flow. 
        /// </para>
        /// </summary>
        public FlowSize FlowSize { get; set; }

        /// <summary>
        /// Checks to see if the FlowSize property is set.
        /// </summary>
        internal bool IsSetFlowSize() => this.FlowSize != null;

        /// <summary>
        /// Gets and sets the property Maintenance. 
        /// <para>
        ///  The maintenance settings for the flow. 
        /// </para>
        /// </summary>
        public Maintenance Maintenance { get; set; }

        /// <summary>
        /// Checks to see if the Maintenance property is set.
        /// </summary>
        internal bool IsSetMaintenance() => this.Maintenance != null;

        /// <summary>
        /// Gets and sets the property MediaStreams. 
        /// <para>
        ///  The media streams that are associated with the flow. After you associate a media
        /// stream with a source, you can also associate it with outputs on the flow.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MediaStream> MediaStreams { get; set; } = AWSConfigs.InitializeCollections ? new List<MediaStream>() : null;

        /// <summary>
        /// Checks to see if the MediaStreams property is set.
        /// </summary>
        internal bool IsSetMediaStreams() => this.MediaStreams != null && (this.MediaStreams.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NdiConfig. 
        /// <para>
        /// Specifies the configuration settings for a flow's NDI source or output. Required when
        /// the flow includes an NDI source or output.
        /// </para>
        /// </summary>
        public NdiConfig NdiConfig { get; set; }

        /// <summary>
        /// Checks to see if the NdiConfig property is set.
        /// </summary>
        internal bool IsSetNdiConfig() => this.NdiConfig != null;

        /// <summary>
        /// Gets and sets the property Outputs. 
        /// <para>
        ///  The outputs in this flow.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<Output> Outputs { get; set; } = AWSConfigs.InitializeCollections ? new List<Output>() : null;

        /// <summary>
        /// Checks to see if the Outputs property is set.
        /// </summary>
        internal bool IsSetOutputs() => this.Outputs != null && (this.Outputs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        ///  The source for the flow. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Source Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property SourceFailoverConfig. 
        /// <para>
        ///  The settings for the source failover. 
        /// </para>
        /// </summary>
        public FailoverConfig SourceFailoverConfig { get; set; }

        /// <summary>
        /// Checks to see if the SourceFailoverConfig property is set.
        /// </summary>
        internal bool IsSetSourceFailoverConfig() => this.SourceFailoverConfig != null;

        /// <summary>
        /// Gets and sets the property SourceMonitoringConfig. 
        /// <para>
        ///  The settings for source monitoring. 
        /// </para>
        /// </summary>
        public MonitoringConfig SourceMonitoringConfig { get; set; }

        /// <summary>
        /// Checks to see if the SourceMonitoringConfig property is set.
        /// </summary>
        internal bool IsSetSourceMonitoringConfig() => this.SourceMonitoringConfig != null;

        /// <summary>
        /// Gets and sets the property Sources. 
        /// <para>
        /// The settings for the sources that are assigned to the flow. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Source> Sources { get; set; } = AWSConfigs.InitializeCollections ? new List<Source>() : null;

        /// <summary>
        /// Checks to see if the Sources property is set.
        /// </summary>
        internal bool IsSetSources() => this.Sources != null && (this.Sources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The current status of the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Status Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property VpcInterfaces. 
        /// <para>
        ///  The VPC Interfaces for this flow.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VpcInterface> VpcInterfaces { get; set; } = AWSConfigs.InitializeCollections ? new List<VpcInterface>() : null;

        /// <summary>
        /// Checks to see if the VpcInterfaces property is set.
        /// </summary>
        internal bool IsSetVpcInterfaces() => this.VpcInterfaces != null && (this.VpcInterfaces.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
