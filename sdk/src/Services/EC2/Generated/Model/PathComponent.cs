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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a path component.
    /// </summary>
    public partial class PathComponent
    {
        private AnalysisAclRule _aclRule;
        private AnalysisComponent _component;
        private AnalysisComponent _destinationVpc;
        private AnalysisPacketHeader _inboundHeader;
        private AnalysisPacketHeader _outboundHeader;
        private AnalysisRouteTableRoute _routeTableRoute;
        private AnalysisSecurityGroupRule _securityGroupRule;
        private int? _sequenceNumber;
        private AnalysisComponent _sourceVpc;
        private AnalysisComponent _subnet;
        private AnalysisComponent _vpc;

        /// <summary>
        /// Gets and sets the property AclRule. 
        /// <para>
        /// The network ACL rule.
        /// </para>
        /// </summary>
        public AnalysisAclRule AclRule
        {
            get { return this._aclRule; }
            set { this._aclRule = value; }
        }

        // Check to see if AclRule property is set
        internal bool IsSetAclRule()
        {
            return this._aclRule != null;
        }

        /// <summary>
        /// Gets and sets the property Component. 
        /// <para>
        /// The component.
        /// </para>
        /// </summary>
        public AnalysisComponent Component
        {
            get { return this._component; }
            set { this._component = value; }
        }

        // Check to see if Component property is set
        internal bool IsSetComponent()
        {
            return this._component != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationVpc. 
        /// <para>
        /// The destination VPC.
        /// </para>
        /// </summary>
        public AnalysisComponent DestinationVpc
        {
            get { return this._destinationVpc; }
            set { this._destinationVpc = value; }
        }

        // Check to see if DestinationVpc property is set
        internal bool IsSetDestinationVpc()
        {
            return this._destinationVpc != null;
        }

        /// <summary>
        /// Gets and sets the property InboundHeader. 
        /// <para>
        /// The inbound header.
        /// </para>
        /// </summary>
        public AnalysisPacketHeader InboundHeader
        {
            get { return this._inboundHeader; }
            set { this._inboundHeader = value; }
        }

        // Check to see if InboundHeader property is set
        internal bool IsSetInboundHeader()
        {
            return this._inboundHeader != null;
        }

        /// <summary>
        /// Gets and sets the property OutboundHeader. 
        /// <para>
        /// The outbound header.
        /// </para>
        /// </summary>
        public AnalysisPacketHeader OutboundHeader
        {
            get { return this._outboundHeader; }
            set { this._outboundHeader = value; }
        }

        // Check to see if OutboundHeader property is set
        internal bool IsSetOutboundHeader()
        {
            return this._outboundHeader != null;
        }

        /// <summary>
        /// Gets and sets the property RouteTableRoute. 
        /// <para>
        /// The route table route.
        /// </para>
        /// </summary>
        public AnalysisRouteTableRoute RouteTableRoute
        {
            get { return this._routeTableRoute; }
            set { this._routeTableRoute = value; }
        }

        // Check to see if RouteTableRoute property is set
        internal bool IsSetRouteTableRoute()
        {
            return this._routeTableRoute != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupRule. 
        /// <para>
        /// The security group rule.
        /// </para>
        /// </summary>
        public AnalysisSecurityGroupRule SecurityGroupRule
        {
            get { return this._securityGroupRule; }
            set { this._securityGroupRule = value; }
        }

        // Check to see if SecurityGroupRule property is set
        internal bool IsSetSecurityGroupRule()
        {
            return this._securityGroupRule != null;
        }

        /// <summary>
        /// Gets and sets the property SequenceNumber. 
        /// <para>
        /// The sequence number.
        /// </para>
        /// </summary>
        public int SequenceNumber
        {
            get { return this._sequenceNumber.GetValueOrDefault(); }
            set { this._sequenceNumber = value; }
        }

        // Check to see if SequenceNumber property is set
        internal bool IsSetSequenceNumber()
        {
            return this._sequenceNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceVpc. 
        /// <para>
        /// The source VPC.
        /// </para>
        /// </summary>
        public AnalysisComponent SourceVpc
        {
            get { return this._sourceVpc; }
            set { this._sourceVpc = value; }
        }

        // Check to see if SourceVpc property is set
        internal bool IsSetSourceVpc()
        {
            return this._sourceVpc != null;
        }

        /// <summary>
        /// Gets and sets the property Subnet. 
        /// <para>
        /// The subnet.
        /// </para>
        /// </summary>
        public AnalysisComponent Subnet
        {
            get { return this._subnet; }
            set { this._subnet = value; }
        }

        // Check to see if Subnet property is set
        internal bool IsSetSubnet()
        {
            return this._subnet != null;
        }

        /// <summary>
        /// Gets and sets the property Vpc. 
        /// <para>
        /// The component VPC.
        /// </para>
        /// </summary>
        public AnalysisComponent Vpc
        {
            get { return this._vpc; }
            set { this._vpc = value; }
        }

        // Check to see if Vpc property is set
        internal bool IsSetVpc()
        {
            return this._vpc != null;
        }

    }
}