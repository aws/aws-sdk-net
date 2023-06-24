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

namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// The settings for a flow, including its source, outputs, and entitlements.
    /// </summary>
    public partial class Flow
    {
        private string _availabilityZone;
        private string _description;
        private string _egressIp;
        private List<Entitlement> _entitlements = new List<Entitlement>();
        private string _flowArn;
        private Maintenance _maintenance;
        private List<MediaStream> _mediaStreams = new List<MediaStream>();
        private string _name;
        private List<Output> _outputs = new List<Output>();
        private Source _source;
        private FailoverConfig _sourceFailoverConfig;
        private List<Source> _sources = new List<Source>();
        private Status _status;
        private List<VpcInterface> _vpcInterfaces = new List<VpcInterface>();

        /// <summary>
        /// Gets and sets the property AvailabilityZone. The Availability Zone that you want to
        /// create the flow in. These options are limited to the Availability Zones within the
        /// current AWS.
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Description. A description of the flow. This value is not
        /// used or seen outside of the current AWS Elemental MediaConnect account.
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EgressIp. The IP address from which video will be sent
        /// to output destinations.
        /// </summary>
        public string EgressIp
        {
            get { return this._egressIp; }
            set { this._egressIp = value; }
        }

        // Check to see if EgressIp property is set
        internal bool IsSetEgressIp()
        {
            return this._egressIp != null;
        }

        /// <summary>
        /// Gets and sets the property Entitlements. The entitlements in this flow.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Entitlement> Entitlements
        {
            get { return this._entitlements; }
            set { this._entitlements = value; }
        }

        // Check to see if Entitlements property is set
        internal bool IsSetEntitlements()
        {
            return this._entitlements != null && this._entitlements.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FlowArn. The Amazon Resource Name (ARN) of the flow.
        /// </summary>
        [AWSProperty(Required=true)]
        public string FlowArn
        {
            get { return this._flowArn; }
            set { this._flowArn = value; }
        }

        // Check to see if FlowArn property is set
        internal bool IsSetFlowArn()
        {
            return this._flowArn != null;
        }

        /// <summary>
        /// Gets and sets the property Maintenance.
        /// </summary>
        public Maintenance Maintenance
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
        /// Gets and sets the property MediaStreams. The media streams that are associated with
        /// the flow. After you associate a media stream with a source, you can also associate
        /// it with outputs on the flow.
        /// </summary>
        public List<MediaStream> MediaStreams
        {
            get { return this._mediaStreams; }
            set { this._mediaStreams = value; }
        }

        // Check to see if MediaStreams property is set
        internal bool IsSetMediaStreams()
        {
            return this._mediaStreams != null && this._mediaStreams.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. The name of the flow.
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
        /// Gets and sets the property Outputs. The outputs in this flow.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Output> Outputs
        {
            get { return this._outputs; }
            set { this._outputs = value; }
        }

        // Check to see if Outputs property is set
        internal bool IsSetOutputs()
        {
            return this._outputs != null && this._outputs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Source.
        /// </summary>
        [AWSProperty(Required=true)]
        public Source Source
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
        /// Gets and sets the property Sources.
        /// </summary>
        public List<Source> Sources
        {
            get { return this._sources; }
            set { this._sources = value; }
        }

        // Check to see if Sources property is set
        internal bool IsSetSources()
        {
            return this._sources != null && this._sources.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Status. The current status of the flow.
        /// </summary>
        [AWSProperty(Required=true)]
        public Status Status
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
        /// Gets and sets the property VpcInterfaces. The VPC Interfaces for this flow.
        /// </summary>
        public List<VpcInterface> VpcInterfaces
        {
            get { return this._vpcInterfaces; }
            set { this._vpcInterfaces = value; }
        }

        // Check to see if VpcInterfaces property is set
        internal bool IsSetVpcInterfaces()
        {
            return this._vpcInterfaces != null && this._vpcInterfaces.Count > 0; 
        }

    }
}