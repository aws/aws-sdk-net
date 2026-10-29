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

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Describes a gateway object.
    /// </summary>
    public partial class GatewayInfo
    {
        /// <summary>
        /// Gets and sets the property DeprecationDate. 
        /// <para>
        /// Date after which this gateway will not receive software updates for new features and
        /// bug fixes.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 25)]
        public string DeprecationDate { get; set; }

        /// <summary>
        /// Checks to see if the DeprecationDate property is set.
        /// </summary>
        internal bool IsSetDeprecationDate() => this.DeprecationDate != null;

        /// <summary>
        /// Gets and sets the property Ec2InstanceId. 
        /// <para>
        /// The ID of the Amazon EC2 instance that was used to launch the gateway.
        /// </para>
        /// </summary>
        public string Ec2InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the Ec2InstanceId property is set.
        /// </summary>
        internal bool IsSetEc2InstanceId() => this.Ec2InstanceId != null;

        /// <summary>
        /// Gets and sets the property Ec2InstanceRegion. 
        /// <para>
        /// The Amazon Web Services Region where the Amazon EC2 instance is located.
        /// </para>
        /// </summary>
        public string Ec2InstanceRegion { get; set; }

        /// <summary>
        /// Checks to see if the Ec2InstanceRegion property is set.
        /// </summary>
        internal bool IsSetEc2InstanceRegion() => this.Ec2InstanceRegion != null;

        /// <summary>
        /// Gets and sets the property GatewayARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the gateway. Use the <a>ListGateways</a> operation
        /// to return a list of gateways for your account and Amazon Web Services Region.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 50, Max = 500)]
        public string GatewayARN { get; set; }

        /// <summary>
        /// Checks to see if the GatewayARN property is set.
        /// </summary>
        internal bool IsSetGatewayARN() => this.GatewayARN != null;

        /// <summary>
        /// Gets and sets the property GatewayId. 
        /// <para>
        /// The unique identifier assigned to your gateway during activation. This ID becomes
        /// part of the gateway Amazon Resource Name (ARN), which you use as input for other operations.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 30)]
        public string GatewayId { get; set; }

        /// <summary>
        /// Checks to see if the GatewayId property is set.
        /// </summary>
        internal bool IsSetGatewayId() => this.GatewayId != null;

        /// <summary>
        /// Gets and sets the property GatewayName. 
        /// <para>
        /// The name of the gateway.
        /// </para>
        /// </summary>
        public string GatewayName { get; set; }

        /// <summary>
        /// Checks to see if the GatewayName property is set.
        /// </summary>
        internal bool IsSetGatewayName() => this.GatewayName != null;

        /// <summary>
        /// Gets and sets the property GatewayOperationalState. 
        /// <para>
        /// The state of the gateway.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>DISABLED</c> | <c>ACTIVE</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 25)]
        public string GatewayOperationalState { get; set; }

        /// <summary>
        /// Checks to see if the GatewayOperationalState property is set.
        /// </summary>
        internal bool IsSetGatewayOperationalState() => this.GatewayOperationalState != null;

        /// <summary>
        /// Gets and sets the property GatewayType. 
        /// <para>
        /// The type of the gateway.
        /// </para>
        ///  <important> 
        /// <para>
        /// Amazon FSx File Gateway is no longer available to new customers. Existing customers
        /// of FSx File Gateway can continue to use the service normally. For capabilities similar
        /// to FSx File Gateway, visit <a href="https://aws.amazon.com/blogs/storage/switch-your-file-share-access-from-amazon-fsx-file-gateway-to-amazon-fsx-for-windows-file-server/">this
        /// blog post</a>.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min = 2, Max = 20)]
        public string GatewayType { get; set; }

        /// <summary>
        /// Checks to see if the GatewayType property is set.
        /// </summary>
        internal bool IsSetGatewayType() => this.GatewayType != null;

        /// <summary>
        /// Gets and sets the property HostEnvironment. 
        /// <para>
        /// The type of hardware or software platform on which the gateway is running.
        /// </para>
        ///  <note> 
        /// <para>
        /// Tape Gateway is no longer available on Snow Family devices.
        /// </para>
        ///  </note>
        /// </summary>
        public HostEnvironment HostEnvironment { get; set; }

        /// <summary>
        /// Checks to see if the HostEnvironment property is set.
        /// </summary>
        internal bool IsSetHostEnvironment() => this.HostEnvironment != null;

        /// <summary>
        /// Gets and sets the property HostEnvironmentId. 
        /// <para>
        /// A unique identifier for the specific instance of the host platform running the gateway.
        /// This value is only available for certain host environments, and its format depends
        /// on the host environment type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string HostEnvironmentId { get; set; }

        /// <summary>
        /// Checks to see if the HostEnvironmentId property is set.
        /// </summary>
        internal bool IsSetHostEnvironmentId() => this.HostEnvironmentId != null;

        /// <summary>
        /// Gets and sets the property SoftwareVersion. 
        /// <para>
        /// The version number of the software running on the gateway appliance.
        /// </para>
        /// </summary>
        public string SoftwareVersion { get; set; }

        /// <summary>
        /// Checks to see if the SoftwareVersion property is set.
        /// </summary>
        internal bool IsSetSoftwareVersion() => this.SoftwareVersion != null;
    }
}
