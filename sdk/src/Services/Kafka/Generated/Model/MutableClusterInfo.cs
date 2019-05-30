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
    /// Information about cluster attributes that can be updated via update APIs.
    /// </summary>
    public partial class MutableClusterInfo
    {
        private List<BrokerEBSVolumeInfo> _brokerEBSVolumeInfo = new List<BrokerEBSVolumeInfo>();
        private ConfigurationInfo _configurationInfo;
        private int? _numberOfBrokerNodes;

        /// <summary>
        /// Gets and sets the property BrokerEBSVolumeInfo.             
        /// <para>
        /// Specifies the size of the EBS volume and the ID of the associated broker.
        /// </para>
        /// </summary>
        public List<BrokerEBSVolumeInfo> BrokerEBSVolumeInfo
        {
            get { return this._brokerEBSVolumeInfo; }
            set { this._brokerEBSVolumeInfo = value; }
        }

        // Check to see if BrokerEBSVolumeInfo property is set
        internal bool IsSetBrokerEBSVolumeInfo()
        {
            return this._brokerEBSVolumeInfo != null && this._brokerEBSVolumeInfo.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ConfigurationInfo.             
        /// <para>
        /// Information about the changes in the configuration of the brokers.
        /// </para>
        /// </summary>
        public ConfigurationInfo ConfigurationInfo
        {
            get { return this._configurationInfo; }
            set { this._configurationInfo = value; }
        }

        // Check to see if ConfigurationInfo property is set
        internal bool IsSetConfigurationInfo()
        {
            return this._configurationInfo != null;
        }

        /// <summary>
        /// Gets and sets the property NumberOfBrokerNodes.             
        /// <para>
        /// The number of broker nodes in the cluster.
        /// </para>
        /// </summary>
        public int NumberOfBrokerNodes
        {
            get { return this._numberOfBrokerNodes.GetValueOrDefault(); }
            set { this._numberOfBrokerNodes = value; }
        }

        // Check to see if NumberOfBrokerNodes property is set
        internal bool IsSetNumberOfBrokerNodes()
        {
            return this._numberOfBrokerNodes.HasValue; 
        }

    }
}