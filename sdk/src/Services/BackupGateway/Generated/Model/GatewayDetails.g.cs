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

namespace Amazon.BackupGateway.Model
{
    /// <summary>
    /// The details of gateway.
    /// </summary>
    public partial class GatewayDetails
    {
        /// <summary>
        /// Gets and sets the property DeprecationDate. 
        /// <para>
        /// Date after which this gateway will not receive software updates for new features and
        /// bug fixes.
        /// </para>
        /// </summary>
        public DateTime? DeprecationDate { get; set; }

        /// <summary>
        /// Checks to see if the DeprecationDate property is set.
        /// </summary>
        internal bool IsSetDeprecationDate() => this.DeprecationDate.HasValue;

        /// <summary>
        /// Gets and sets the property GatewayArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the gateway. Use the <c>ListGateways</c> operation
        /// to return a list of gateways for your account and Amazon Web Services Region.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 50, Max = 180)]
        public string GatewayArn { get; set; }

        /// <summary>
        /// Checks to see if the GatewayArn property is set.
        /// </summary>
        internal bool IsSetGatewayArn() => this.GatewayArn != null;

        /// <summary>
        /// Gets and sets the property GatewayDisplayName. 
        /// <para>
        /// The display name of the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string GatewayDisplayName { get; set; }

        /// <summary>
        /// Checks to see if the GatewayDisplayName property is set.
        /// </summary>
        internal bool IsSetGatewayDisplayName() => this.GatewayDisplayName != null;

        /// <summary>
        /// Gets and sets the property GatewayType. 
        /// <para>
        /// The type of the gateway type.
        /// </para>
        /// </summary>
        public GatewayType GatewayType { get; set; }

        /// <summary>
        /// Checks to see if the GatewayType property is set.
        /// </summary>
        internal bool IsSetGatewayType() => this.GatewayType != null;

        /// <summary>
        /// Gets and sets the property HypervisorId. 
        /// <para>
        /// The hypervisor ID of the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string HypervisorId { get; set; }

        /// <summary>
        /// Checks to see if the HypervisorId property is set.
        /// </summary>
        internal bool IsSetHypervisorId() => this.HypervisorId != null;

        /// <summary>
        /// Gets and sets the property LastSeenTime. 
        /// <para>
        /// Details showing the last time Backup gateway communicated with the cloud, in Unix
        /// format and UTC time.
        /// </para>
        /// </summary>
        public DateTime? LastSeenTime { get; set; }

        /// <summary>
        /// Checks to see if the LastSeenTime property is set.
        /// </summary>
        internal bool IsSetLastSeenTime() => this.LastSeenTime.HasValue;

        /// <summary>
        /// Gets and sets the property MaintenanceStartTime. 
        /// <para>
        /// Returns your gateway's weekly maintenance start time including the day and time of
        /// the week. Note that values are in terms of the gateway's time zone. Can be weekly
        /// or monthly.
        /// </para>
        /// </summary>
        public MaintenanceStartTime MaintenanceStartTime { get; set; }

        /// <summary>
        /// Checks to see if the MaintenanceStartTime property is set.
        /// </summary>
        internal bool IsSetMaintenanceStartTime() => this.MaintenanceStartTime != null;

        /// <summary>
        /// Gets and sets the property NextUpdateAvailabilityTime. 
        /// <para>
        /// Details showing the next update availability time of the gateway.
        /// </para>
        /// </summary>
        public DateTime? NextUpdateAvailabilityTime { get; set; }

        /// <summary>
        /// Checks to see if the NextUpdateAvailabilityTime property is set.
        /// </summary>
        internal bool IsSetNextUpdateAvailabilityTime() => this.NextUpdateAvailabilityTime.HasValue;

        /// <summary>
        /// Gets and sets the property SoftwareVersion. 
        /// <para>
        /// The version number of the software running on the gateway appliance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string SoftwareVersion { get; set; }

        /// <summary>
        /// Checks to see if the SoftwareVersion property is set.
        /// </summary>
        internal bool IsSetSoftwareVersion() => this.SoftwareVersion != null;

        /// <summary>
        /// Gets and sets the property VpcEndpoint. 
        /// <para>
        /// The DNS name for the virtual private cloud (VPC) endpoint the gateway uses to connect
        /// to the cloud for backup gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string VpcEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the VpcEndpoint property is set.
        /// </summary>
        internal bool IsSetVpcEndpoint() => this.VpcEndpoint != null;
    }
}
