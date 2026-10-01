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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Contains information about network endpoints involved in an Amazon GuardDuty Extended
    /// Threat Detection attack sequence. GuardDuty generates an attack sequence finding when
    /// multiple events align to a potentially suspicious activity. To receive GuardDuty attack
    /// sequence findings in Security Hub CSPM, you must have GuardDuty enabled. For more
    /// information, see <a href="https://docs.aws.amazon.com/guardduty/latest/ug/guardduty-extended-threat-detection.html">GuardDuty
    /// Extended Threat Detection </a> in the <i>Amazon GuardDuty User Guide</i>. 
    /// 
    ///  
    /// <para>
    /// This field can provide information about the network endpoints associated with the
    /// resource in the attack sequence finding, or about a specific network endpoint used
    /// for the attack.
    /// </para>
    /// </summary>
    public partial class NetworkEndpoint
    {
        /// <summary>
        /// Gets and sets the property AutonomousSystem. 
        /// <para>
        ///  The Autonomous System Number (ASN) of the network endpoint. 
        /// </para>
        /// </summary>
        public NetworkAutonomousSystem AutonomousSystem { get; set; }

        /// <summary>
        /// Checks to see if the AutonomousSystem property is set.
        /// </summary>
        internal bool IsSetAutonomousSystem() => this.AutonomousSystem != null;

        /// <summary>
        /// Gets and sets the property Connection. 
        /// <para>
        ///  Information about the network connection. 
        /// </para>
        /// </summary>
        public NetworkConnection Connection { get; set; }

        /// <summary>
        /// Checks to see if the Connection property is set.
        /// </summary>
        internal bool IsSetConnection() => this.Connection != null;

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        ///  The domain information for the network endpoint. 
        /// </para>
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// Checks to see if the Domain property is set.
        /// </summary>
        internal bool IsSetDomain() => this.Domain != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  The identifier of the network endpoint involved in the attack sequence. 
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Ip. 
        /// <para>
        ///  The IP address used in the network endpoint. 
        /// </para>
        /// </summary>
        public string Ip { get; set; }

        /// <summary>
        /// Checks to see if the Ip property is set.
        /// </summary>
        internal bool IsSetIp() => this.Ip != null;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        ///  Information about the location of the network endpoint. 
        /// </para>
        /// </summary>
        public NetworkGeoLocation Location { get; set; }

        /// <summary>
        /// Checks to see if the Location property is set.
        /// </summary>
        internal bool IsSetLocation() => this.Location != null;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        ///  The port number associated with the network endpoint. 
        /// </para>
        /// </summary>
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;
    }
}
