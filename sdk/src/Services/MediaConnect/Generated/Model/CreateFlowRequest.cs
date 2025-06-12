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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
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
    /// Container for the parameters to the CreateFlow operation.
    /// Creates a new flow. The request must include one source. The request optionally can
    /// include outputs (up to 50) and entitlements (up to 50).
    /// </summary>
    public partial class CreateFlowRequest : AmazonMediaConnectRequest
    {
        private string _availabilityZone;
        private List<GrantEntitlementRequest> _entitlements = AWSConfigs.InitializeCollections ? new List<GrantEntitlementRequest>() : null;
        private FlowSize _flowSize;
        private AddMaintenance _maintenance;
        private List<AddMediaStreamRequest> _mediaStreams = AWSConfigs.InitializeCollections ? new List<AddMediaStreamRequest>() : null;
        private string _name;
        private NdiConfig _ndiConfig;
        private List<AddOutputRequest> _outputs = AWSConfigs.InitializeCollections ? new List<AddOutputRequest>() : null;
        private SetSourceRequest _source;
        private FailoverConfig _sourceFailoverConfig;
        private MonitoringConfig _sourceMonitoringConfig;
        private List<SetSourceRequest> _sources = AWSConfigs.InitializeCollections ? new List<SetSourceRequest>() : null;
        private List<VpcInterfaceRequest> _vpcInterfaces = AWSConfigs.InitializeCollections ? new List<VpcInterfaceRequest>() : null;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        ///  The Availability Zone that you want to create the flow in. These options are limited
        /// to the Availability Zones within the current Amazon Web Services Region.
        /// </para>
        /// </summary>
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property Entitlements. 
        /// <para>
        ///  The entitlements that you want to grant on a flow.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<GrantEntitlementRequest> Entitlements
        {
            get { return this._entitlements; }
            set { this._entitlements = value; }
        }

        // Check to see if Entitlements property is set
        internal bool IsSetEntitlements()
        {
            return this._entitlements != null && (this._entitlements.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FlowSize. 
        /// <para>
        ///  Determines the processing capacity and feature set of the flow. Set this optional
        /// parameter to <c>LARGE</c> if you want to enable NDI outputs on the flow. 
        /// </para>
        /// </summary>
        public FlowSize FlowSize
        {
            get { return this._flowSize; }
            set { this._flowSize = value; }
        }

        // Check to see if FlowSize property is set
        internal bool IsSetFlowSize()
        {
            return this._flowSize != null;
        }

        /// <summary>
        /// Gets and sets the property Maintenance. 
        /// <para>
        ///  The maintenance settings you want to use for the flow. 
        /// </para>
        /// </summary>
        public AddMaintenance Maintenance
        {
            get { return this._maintenance; }
            set { this._maintenance = value; }
        }

        // Check to see if Maintenance property is set
        internal bool IsSetMaintenance()
        {
            return this._maintenance != null;
        }

        /// <summary>
        /// Gets and sets the property MediaStreams. 
        /// <para>
        ///  The media streams that you want to add to the flow. You can associate these media
        /// streams with sources and outputs on the flow.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AddMediaStreamRequest> MediaStreams
        {
            get { return this._mediaStreams; }
            set { this._mediaStreams = value; }
        }

        // Check to see if MediaStreams property is set
        internal bool IsSetMediaStreams()
        {
            return this._mediaStreams != null && (this._mediaStreams.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property NdiConfig. 
        /// <para>
        ///  Specifies the configuration settings for NDI outputs. Required when the flow includes
        /// NDI outputs. 
        /// </para>
        /// </summary>
        public NdiConfig NdiConfig
        {
            get { return this._ndiConfig; }
            set { this._ndiConfig = value; }
        }

        // Check to see if NdiConfig property is set
        internal bool IsSetNdiConfig()
        {
            return this._ndiConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Outputs. 
        /// <para>
        ///  The outputs that you want to add to this flow.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AddOutputRequest> Outputs
        {
            get { return this._outputs; }
            set { this._outputs = value; }
        }

        // Check to see if Outputs property is set
        internal bool IsSetOutputs()
        {
            return this._outputs != null && (this._outputs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        ///  The settings for the source that you want to use for the new flow. 
        /// </para>
        /// </summary>
        public SetSourceRequest Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property SourceFailoverConfig. 
        /// <para>
        ///  The settings for source failover. 
        /// </para>
        /// </summary>
        public FailoverConfig SourceFailoverConfig
        {
            get { return this._sourceFailoverConfig; }
            set { this._sourceFailoverConfig = value; }
        }

        // Check to see if SourceFailoverConfig property is set
        internal bool IsSetSourceFailoverConfig()
        {
            return this._sourceFailoverConfig != null;
        }

        /// <summary>
        /// Gets and sets the property SourceMonitoringConfig. 
        /// <para>
        ///  The settings for source monitoring. 
        /// </para>
        /// </summary>
        public MonitoringConfig SourceMonitoringConfig
        {
            get { return this._sourceMonitoringConfig; }
            set { this._sourceMonitoringConfig = value; }
        }

        // Check to see if SourceMonitoringConfig property is set
        internal bool IsSetSourceMonitoringConfig()
        {
            return this._sourceMonitoringConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Sources. 
        /// <para>
        /// The sources that are assigned to the flow. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SetSourceRequest> Sources
        {
            get { return this._sources; }
            set { this._sources = value; }
        }

        // Check to see if Sources property is set
        internal bool IsSetSources()
        {
            return this._sources != null && (this._sources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VpcInterfaces. 
        /// <para>
        ///  The VPC interfaces you want on the flow.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VpcInterfaceRequest> VpcInterfaces
        {
            get { return this._vpcInterfaces; }
            set { this._vpcInterfaces = value; }
        }

        // Check to see if VpcInterfaces property is set
        internal bool IsSetVpcInterfaces()
        {
            return this._vpcInterfaces != null && (this._vpcInterfaces.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}