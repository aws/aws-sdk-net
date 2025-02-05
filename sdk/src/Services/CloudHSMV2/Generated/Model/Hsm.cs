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
 * Do not modify this file. This file is generated from the cloudhsmv2-2017-04-28.normal.json service model.
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
namespace Amazon.CloudHSMV2.Model
{
    /// <summary>
    /// Contains information about a hardware security module (HSM) in an CloudHSM cluster.
    /// </summary>
    public partial class Hsm
    {
        private string _availabilityZone;
        private string _clusterId;
        private string _eniId;
        private string _eniIp;
        private string _eniIpV6;
        private string _hsmId;
        private string _hsmType;
        private HsmState _state;
        private string _stateMessage;
        private string _subnetId;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone that contains the HSM.
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
        /// Gets and sets the property ClusterId. 
        /// <para>
        /// The identifier (ID) of the cluster that contains the HSM.
        /// </para>
        /// </summary>
        public string ClusterId
        {
            get { return this._clusterId; }
            set { this._clusterId = value; }
        }

        // Check to see if ClusterId property is set
        internal bool IsSetClusterId()
        {
            return this._clusterId != null;
        }

        /// <summary>
        /// Gets and sets the property EniId. 
        /// <para>
        /// The identifier (ID) of the HSM's elastic network interface (ENI).
        /// </para>
        /// </summary>
        public string EniId
        {
            get { return this._eniId; }
            set { this._eniId = value; }
        }

        // Check to see if EniId property is set
        internal bool IsSetEniId()
        {
            return this._eniId != null;
        }

        /// <summary>
        /// Gets and sets the property EniIp. 
        /// <para>
        /// The IP address of the HSM's elastic network interface (ENI).
        /// </para>
        /// </summary>
        public string EniIp
        {
            get { return this._eniIp; }
            set { this._eniIp = value; }
        }

        // Check to see if EniIp property is set
        internal bool IsSetEniIp()
        {
            return this._eniIp != null;
        }

        /// <summary>
        /// Gets and sets the property EniIpV6. 
        /// <para>
        /// The IPv6 address (if any) of the HSM's elastic network interface (ENI).
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public string EniIpV6
        {
            get { return this._eniIpV6; }
            set { this._eniIpV6 = value; }
        }

        // Check to see if EniIpV6 property is set
        internal bool IsSetEniIpV6()
        {
            return this._eniIpV6 != null;
        }

        /// <summary>
        /// Gets and sets the property HsmId. 
        /// <para>
        /// The HSM's identifier (ID).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string HsmId
        {
            get { return this._hsmId; }
            set { this._hsmId = value; }
        }

        // Check to see if HsmId property is set
        internal bool IsSetHsmId()
        {
            return this._hsmId != null;
        }

        /// <summary>
        /// Gets and sets the property HsmType. 
        /// <para>
        /// The type of HSM.
        /// </para>
        /// </summary>
        [AWSProperty(Max=32)]
        public string HsmType
        {
            get { return this._hsmType; }
            set { this._hsmType = value; }
        }

        // Check to see if HsmType property is set
        internal bool IsSetHsmType()
        {
            return this._hsmType != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The HSM's state.
        /// </para>
        /// </summary>
        public HsmState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property StateMessage. 
        /// <para>
        /// A description of the HSM's state.
        /// </para>
        /// </summary>
        public string StateMessage
        {
            get { return this._stateMessage; }
            set { this._stateMessage = value; }
        }

        // Check to see if StateMessage property is set
        internal bool IsSetStateMessage()
        {
            return this._stateMessage != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The subnet that contains the HSM's elastic network interface (ENI).
        /// </para>
        /// </summary>
        public string SubnetId
        {
            get { return this._subnetId; }
            set { this._subnetId = value; }
        }

        // Check to see if SubnetId property is set
        internal bool IsSetSubnetId()
        {
            return this._subnetId != null;
        }

    }
}