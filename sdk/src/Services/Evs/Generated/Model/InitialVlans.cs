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
 * Do not modify this file. This file is generated from the evs-2023-07-27.normal.json service model.
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
namespace Amazon.Evs.Model
{
    /// <summary>
    /// The initial VLAN subnets for the environment. Amazon EVS VLAN subnets have a minimum
    /// CIDR block size of /28 and a maximum size of /24. Amazon EVS VLAN subnet CIDR blocks
    /// must not overlap with other subnets in the VPC.
    /// </summary>
    public partial class InitialVlans
    {
        private InitialVlanInfo _edgevTep;
        private InitialVlanInfo _expansionVlan1;
        private InitialVlanInfo _expansionVlan2;
        private InitialVlanInfo _hcx;
        private string _hcxNetworkAclId;
        private bool? _isHcxPublic;
        private InitialVlanInfo _nsxUplink;
        private InitialVlanInfo _vmkManagement;
        private InitialVlanInfo _vmManagement;
        private InitialVlanInfo _vMotion;
        private InitialVlanInfo _vSan;
        private InitialVlanInfo _vTep;

        /// <summary>
        /// Gets and sets the property EdgeVTep. 
        /// <para>
        /// The edge VTEP VLAN subnet. This VLAN subnet manages traffic flowing between the internal
        /// network and external networks, including internet access and other site connections.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InitialVlanInfo EdgeVTep
        {
            get { return this._edgevTep; }
            set { this._edgevTep = value; }
        }

        // Check to see if EdgeVTep property is set
        internal bool IsSetEdgeVTep()
        {
            return this._edgevTep != null;
        }

        /// <summary>
        /// Gets and sets the property ExpansionVlan1. 
        /// <para>
        /// An additional VLAN subnet that can be used to extend VCF capabilities once configured.
        /// For example, you can configure an expansion VLAN subnet to use NSX Federation for
        /// centralized management and synchronization of multiple NSX deployments across different
        /// locations.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InitialVlanInfo ExpansionVlan1
        {
            get { return this._expansionVlan1; }
            set { this._expansionVlan1 = value; }
        }

        // Check to see if ExpansionVlan1 property is set
        internal bool IsSetExpansionVlan1()
        {
            return this._expansionVlan1 != null;
        }

        /// <summary>
        /// Gets and sets the property ExpansionVlan2. 
        /// <para>
        /// An additional VLAN subnet that can be used to extend VCF capabilities once configured.
        /// For example, you can configure an expansion VLAN subnet to use NSX Federation for
        /// centralized management and synchronization of multiple NSX deployments across different
        /// locations.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InitialVlanInfo ExpansionVlan2
        {
            get { return this._expansionVlan2; }
            set { this._expansionVlan2 = value; }
        }

        // Check to see if ExpansionVlan2 property is set
        internal bool IsSetExpansionVlan2()
        {
            return this._expansionVlan2 != null;
        }

        /// <summary>
        /// Gets and sets the property Hcx. 
        /// <para>
        /// The HCX VLAN subnet. This VLAN subnet allows the HCX Interconnnect (IX) and HCX Network
        /// Extension (NE) to reach their peers and enable HCX Service Mesh creation.
        /// </para>
        ///  
        /// <para>
        /// If you plan to use a public HCX VLAN subnet, the following requirements must be met:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must have a /28 netmask and be allocated from the IPAM public pool. Required for HCX
        /// internet access configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The HCX public VLAN CIDR block must be added to the VPC as a secondary CIDR block.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must have at least three Elastic IP addresses to be allocated from the public IPAM
        /// pool for HCX components.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public InitialVlanInfo Hcx
        {
            get { return this._hcx; }
            set { this._hcx = value; }
        }

        // Check to see if Hcx property is set
        internal bool IsSetHcx()
        {
            return this._hcx != null;
        }

        /// <summary>
        /// Gets and sets the property HcxNetworkAclId. 
        /// <para>
        /// A unique ID for a network access control list that the HCX VLAN uses. Required when
        /// <c>isHcxPublic</c> is set to <c>true</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=21)]
        public string HcxNetworkAclId
        {
            get { return this._hcxNetworkAclId; }
            set { this._hcxNetworkAclId = value; }
        }

        // Check to see if HcxNetworkAclId property is set
        internal bool IsSetHcxNetworkAclId()
        {
            return this._hcxNetworkAclId != null;
        }

        /// <summary>
        /// Gets and sets the property IsHcxPublic. 
        /// <para>
        /// Determines if the HCX VLAN that Amazon EVS provisions is public or private.
        /// </para>
        /// </summary>
        public bool? IsHcxPublic
        {
            get { return this._isHcxPublic; }
            set { this._isHcxPublic = value; }
        }

        // Check to see if IsHcxPublic property is set
        internal bool IsSetIsHcxPublic()
        {
            return this._isHcxPublic.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NsxUplink. 
        /// <para>
        ///  The NSX uplink VLAN subnet. This VLAN subnet allows connectivity to the NSX overlay
        /// network.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InitialVlanInfo NsxUplink
        {
            get { return this._nsxUplink; }
            set { this._nsxUplink = value; }
        }

        // Check to see if NsxUplink property is set
        internal bool IsSetNsxUplink()
        {
            return this._nsxUplink != null;
        }

        /// <summary>
        /// Gets and sets the property VmkManagement. 
        /// <para>
        ///  The host VMkernel management VLAN subnet. This VLAN subnet carries traffic for managing
        /// ESXi hosts and communicating with VMware vCenter Server.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InitialVlanInfo VmkManagement
        {
            get { return this._vmkManagement; }
            set { this._vmkManagement = value; }
        }

        // Check to see if VmkManagement property is set
        internal bool IsSetVmkManagement()
        {
            return this._vmkManagement != null;
        }

        /// <summary>
        /// Gets and sets the property VmManagement. 
        /// <para>
        /// The VM management VLAN subnet. This VLAN subnet carries traffic for vSphere virtual
        /// machines.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InitialVlanInfo VmManagement
        {
            get { return this._vmManagement; }
            set { this._vmManagement = value; }
        }

        // Check to see if VmManagement property is set
        internal bool IsSetVmManagement()
        {
            return this._vmManagement != null;
        }

        /// <summary>
        /// Gets and sets the property VMotion. 
        /// <para>
        ///  The vMotion VLAN subnet. This VLAN subnet carries traffic for vSphere vMotion.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InitialVlanInfo VMotion
        {
            get { return this._vMotion; }
            set { this._vMotion = value; }
        }

        // Check to see if VMotion property is set
        internal bool IsSetVMotion()
        {
            return this._vMotion != null;
        }

        /// <summary>
        /// Gets and sets the property VSan. 
        /// <para>
        ///  The vSAN VLAN subnet. This VLAN subnet carries the communication between ESXi hosts
        /// to implement a vSAN shared storage pool.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InitialVlanInfo VSan
        {
            get { return this._vSan; }
            set { this._vSan = value; }
        }

        // Check to see if VSan property is set
        internal bool IsSetVSan()
        {
            return this._vSan != null;
        }

        /// <summary>
        /// Gets and sets the property VTep. 
        /// <para>
        ///  The VTEP VLAN subnet. This VLAN subnet handles internal network traffic between virtual
        /// machines within a VCF instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InitialVlanInfo VTep
        {
            get { return this._vTep; }
            set { this._vTep = value; }
        }

        // Check to see if VTep property is set
        internal bool IsSetVTep()
        {
            return this._vTep != null;
        }

    }
}