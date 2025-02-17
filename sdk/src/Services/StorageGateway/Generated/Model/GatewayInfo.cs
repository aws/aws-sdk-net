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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
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
        private string _deprecationDate;
        private string _ec2InstanceId;
        private string _ec2InstanceRegion;
        private string _gatewayARN;
        private string _gatewayId;
        private string _gatewayName;
        private string _gatewayOperationalState;
        private string _gatewayType;
        private HostEnvironment _hostEnvironment;
        private string _hostEnvironmentId;
        private string _softwareVersion;

        /// <summary>
        /// Gets and sets the property DeprecationDate. 
        /// <para>
        /// Date after which this gateway will not receive software updates for new features and
        /// bug fixes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
        public string DeprecationDate
        {
            get { return this._deprecationDate; }
            set { this._deprecationDate = value; }
        }

        // Check to see if DeprecationDate property is set
        internal bool IsSetDeprecationDate()
        {
            return this._deprecationDate != null;
        }

        /// <summary>
        /// Gets and sets the property Ec2InstanceId. 
        /// <para>
        /// The ID of the Amazon EC2 instance that was used to launch the gateway.
        /// </para>
        /// </summary>
        public string Ec2InstanceId
        {
            get { return this._ec2InstanceId; }
            set { this._ec2InstanceId = value; }
        }

        // Check to see if Ec2InstanceId property is set
        internal bool IsSetEc2InstanceId()
        {
            return this._ec2InstanceId != null;
        }

        /// <summary>
        /// Gets and sets the property Ec2InstanceRegion. 
        /// <para>
        /// The Amazon Web Services Region where the Amazon EC2 instance is located.
        /// </para>
        /// </summary>
        public string Ec2InstanceRegion
        {
            get { return this._ec2InstanceRegion; }
            set { this._ec2InstanceRegion = value; }
        }

        // Check to see if Ec2InstanceRegion property is set
        internal bool IsSetEc2InstanceRegion()
        {
            return this._ec2InstanceRegion != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the gateway. Use the <a>ListGateways</a> operation
        /// to return a list of gateways for your account and Amazon Web Services Region.
        /// </para>
        /// </summary>
        [AWSProperty(Min=50, Max=500)]
        public string GatewayARN
        {
            get { return this._gatewayARN; }
            set { this._gatewayARN = value; }
        }

        // Check to see if GatewayARN property is set
        internal bool IsSetGatewayARN()
        {
            return this._gatewayARN != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayId. 
        /// <para>
        /// The unique identifier assigned to your gateway during activation. This ID becomes
        /// part of the gateway Amazon Resource Name (ARN), which you use as input for other operations.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=30)]
        public string GatewayId
        {
            get { return this._gatewayId; }
            set { this._gatewayId = value; }
        }

        // Check to see if GatewayId property is set
        internal bool IsSetGatewayId()
        {
            return this._gatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayName. 
        /// <para>
        /// The name of the gateway.
        /// </para>
        /// </summary>
        public string GatewayName
        {
            get { return this._gatewayName; }
            set { this._gatewayName = value; }
        }

        // Check to see if GatewayName property is set
        internal bool IsSetGatewayName()
        {
            return this._gatewayName != null;
        }

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
        [AWSProperty(Min=2, Max=25)]
        public string GatewayOperationalState
        {
            get { return this._gatewayOperationalState; }
            set { this._gatewayOperationalState = value; }
        }

        // Check to see if GatewayOperationalState property is set
        internal bool IsSetGatewayOperationalState()
        {
            return this._gatewayOperationalState != null;
        }

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
        [AWSProperty(Min=2, Max=20)]
        public string GatewayType
        {
            get { return this._gatewayType; }
            set { this._gatewayType = value; }
        }

        // Check to see if GatewayType property is set
        internal bool IsSetGatewayType()
        {
            return this._gatewayType != null;
        }

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
        public HostEnvironment HostEnvironment
        {
            get { return this._hostEnvironment; }
            set { this._hostEnvironment = value; }
        }

        // Check to see if HostEnvironment property is set
        internal bool IsSetHostEnvironment()
        {
            return this._hostEnvironment != null;
        }

        /// <summary>
        /// Gets and sets the property HostEnvironmentId. 
        /// <para>
        /// A unique identifier for the specific instance of the host platform running the gateway.
        /// This value is only available for certain host environments, and its format depends
        /// on the host environment type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string HostEnvironmentId
        {
            get { return this._hostEnvironmentId; }
            set { this._hostEnvironmentId = value; }
        }

        // Check to see if HostEnvironmentId property is set
        internal bool IsSetHostEnvironmentId()
        {
            return this._hostEnvironmentId != null;
        }

        /// <summary>
        /// Gets and sets the property SoftwareVersion. 
        /// <para>
        /// The version number of the software running on the gateway appliance.
        /// </para>
        /// </summary>
        public string SoftwareVersion
        {
            get { return this._softwareVersion; }
            set { this._softwareVersion = value; }
        }

        // Check to see if SoftwareVersion property is set
        internal bool IsSetSoftwareVersion()
        {
            return this._softwareVersion != null;
        }

    }
}