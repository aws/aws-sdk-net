/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kafka.Model
{
    /// <summary>
    /// BrokerNodeInfo
    /// </summary>
    public partial class BrokerNodeInfo
    {
        private string _attachedENIId;
        private double? _brokerId;
        private string _clientSubnet;
        private string _clientVpcIpAddress;
        private BrokerSoftwareInfo _currentBrokerSoftwareInfo;

        /// <summary>
        /// Gets and sets the property AttachedENIId. 
        /// <para>
        /// The attached elastic network interface of the broker.
        /// </para>
        /// </summary>
        public string AttachedENIId
        {
            get { return this._attachedENIId; }
            set { this._attachedENIId = value; }
        }

        // Check to see if AttachedENIId property is set
        internal bool IsSetAttachedENIId()
        {
            return this._attachedENIId != null;
        }

        /// <summary>
        /// Gets and sets the property BrokerId. 
        /// <para>
        /// The ID of the broker.
        /// </para>
        /// </summary>
        public double BrokerId
        {
            get { return this._brokerId.GetValueOrDefault(); }
            set { this._brokerId = value; }
        }

        // Check to see if BrokerId property is set
        internal bool IsSetBrokerId()
        {
            return this._brokerId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ClientSubnet. 
        /// <para>
        /// The client subnet to which this broker node belongs.
        /// </para>
        /// </summary>
        public string ClientSubnet
        {
            get { return this._clientSubnet; }
            set { this._clientSubnet = value; }
        }

        // Check to see if ClientSubnet property is set
        internal bool IsSetClientSubnet()
        {
            return this._clientSubnet != null;
        }

        /// <summary>
        /// Gets and sets the property ClientVpcIpAddress. 
        /// <para>
        /// The virtual private cloud (VPC) of the client.
        /// </para>
        /// </summary>
        public string ClientVpcIpAddress
        {
            get { return this._clientVpcIpAddress; }
            set { this._clientVpcIpAddress = value; }
        }

        // Check to see if ClientVpcIpAddress property is set
        internal bool IsSetClientVpcIpAddress()
        {
            return this._clientVpcIpAddress != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentBrokerSoftwareInfo. 
        /// <para>
        /// Information about the version of software currently deployed on the Kafka brokers
        /// in the cluster.
        /// </para>
        /// </summary>
        public BrokerSoftwareInfo CurrentBrokerSoftwareInfo
        {
            get { return this._currentBrokerSoftwareInfo; }
            set { this._currentBrokerSoftwareInfo = value; }
        }

        // Check to see if CurrentBrokerSoftwareInfo property is set
        internal bool IsSetCurrentBrokerSoftwareInfo()
        {
            return this._currentBrokerSoftwareInfo != null;
        }

    }
}