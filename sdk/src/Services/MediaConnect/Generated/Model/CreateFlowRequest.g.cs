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
    /// Container for the parameters to the CreateFlow operation. Creates a new flow. The
    /// request must include one source. The request optionally can include outputs (up to
    /// 50) and entitlements (up to 50).
    /// </summary>
    public partial class CreateFlowRequest : AmazonMediaConnectRequest
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        ///  The Availability Zone that you want to create the flow in. These options are limited
        /// to the Availability Zones within the current Amazon Web Services Region.
        /// </para>
        /// </summary>
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property EncodingConfig.
        /// </summary>
        public EncodingConfig EncodingConfig { get; set; }

        /// <summary>
        /// Checks to see if the EncodingConfig property is set.
        /// </summary>
        internal bool IsSetEncodingConfig() => this.EncodingConfig != null;

        /// <summary>
        /// Gets and sets the property Entitlements. 
        /// <para>
        ///  The entitlements that you want to grant on a flow.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<GrantEntitlementRequest> Entitlements { get; set; } = AWSConfigs.InitializeCollections ? new List<GrantEntitlementRequest>() : null;

        /// <summary>
        /// Checks to see if the Entitlements property is set.
        /// </summary>
        internal bool IsSetEntitlements() => this.Entitlements != null && (this.Entitlements.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FlowSize. 
        /// <para>
        ///  Determines the processing capacity and feature set of the flow. Set this optional
        /// parameter to <c>LARGE</c> if you want to enable NDI sources or outputs on the flow.
        /// 
        /// </para>
        /// </summary>
        public FlowSize FlowSize { get; set; }

        /// <summary>
        /// Checks to see if the FlowSize property is set.
        /// </summary>
        internal bool IsSetFlowSize() => this.FlowSize != null;

        /// <summary>
        /// Gets and sets the property FlowTags. 
        /// <para>
        ///  The key-value pairs that can be used to tag and organize the flow. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> FlowTags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the FlowTags property is set.
        /// </summary>
        internal bool IsSetFlowTags() => this.FlowTags != null && (this.FlowTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Maintenance. 
        /// <para>
        ///  The maintenance settings you want to use for the flow. 
        /// </para>
        /// </summary>
        public AddMaintenance Maintenance { get; set; }

        /// <summary>
        /// Checks to see if the Maintenance property is set.
        /// </summary>
        internal bool IsSetMaintenance() => this.Maintenance != null;

        /// <summary>
        /// Gets and sets the property MediaStreams. 
        /// <para>
        ///  The media streams that you want to add to the flow. You can associate these media
        /// streams with sources and outputs on the flow.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AddMediaStreamRequest> MediaStreams { get; set; } = AWSConfigs.InitializeCollections ? new List<AddMediaStreamRequest>() : null;

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
        ///  Specifies the configuration settings for a flow's NDI source or output. Required
        /// when the flow includes an NDI source or output. 
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
        ///  The outputs that you want to add to this flow.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AddOutputRequest> Outputs { get; set; } = AWSConfigs.InitializeCollections ? new List<AddOutputRequest>() : null;

        /// <summary>
        /// Checks to see if the Outputs property is set.
        /// </summary>
        internal bool IsSetOutputs() => this.Outputs != null && (this.Outputs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        ///  The settings for the source that you want to use for the new flow. 
        /// </para>
        /// </summary>
        public SetSourceRequest Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property SourceFailoverConfig. 
        /// <para>
        ///  The settings for source failover. 
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
        /// The sources that are assigned to the flow. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SetSourceRequest> Sources { get; set; } = AWSConfigs.InitializeCollections ? new List<SetSourceRequest>() : null;

        /// <summary>
        /// Checks to see if the Sources property is set.
        /// </summary>
        internal bool IsSetSources() => this.Sources != null && (this.Sources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VpcInterfaces. 
        /// <para>
        ///  The VPC interfaces you want on the flow.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VpcInterfaceRequest> VpcInterfaces { get; set; } = AWSConfigs.InitializeCollections ? new List<VpcInterfaceRequest>() : null;

        /// <summary>
        /// Checks to see if the VpcInterfaces property is set.
        /// </summary>
        internal bool IsSetVpcInterfaces() => this.VpcInterfaces != null && (this.VpcInterfaces.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
