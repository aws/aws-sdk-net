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
    /// A JSON object containing the following fields:
    /// </summary>
    public partial class DescribeGatewayInformationResponse : AmazonWebServiceResponse
    {
        private string _cloudWatchLogGroupARN;
        private string _deprecationDate;
        private string _ec2InstanceId;
        private string _ec2InstanceRegion;
        private string _endpointType;
        private string _gatewayARN;
        private GatewayCapacity _gatewayCapacity;
        private string _gatewayId;
        private string _gatewayName;
        private List<NetworkInterface> _gatewayNetworkInterfaces = AWSConfigs.InitializeCollections ? new List<NetworkInterface>() : null;
        private string _gatewayState;
        private string _gatewayTimezone;
        private string _gatewayType;
        private HostEnvironment _hostEnvironment;
        private string _hostEnvironmentId;
        private string _lastSoftwareUpdate;
        private string _nextUpdateAvailabilityDate;
        private string _softwareUpdatesEndDate;
        private string _softwareVersion;
        private List<string> _supportedGatewayCapacities = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _vpcEndpoint;

        /// <summary>
        /// Gets and sets the property CloudWatchLogGroupARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon CloudWatch log group that is used to
        /// monitor events in the gateway. This field only only exist and returns once it have
        /// been chosen and set by the SGW service, based on the OS version of the gateway VM
        /// </para>
        /// </summary>
        [AWSProperty(Max=562)]
        public string CloudWatchLogGroupARN
        {
            get { return this._cloudWatchLogGroupARN; }
            set { this._cloudWatchLogGroupARN = value; }
        }

        // Check to see if CloudWatchLogGroupARN property is set
        internal bool IsSetCloudWatchLogGroupARN()
        {
            return this._cloudWatchLogGroupARN != null;
        }

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
        /// Gets and sets the property EndpointType. 
        /// <para>
        /// The type of endpoint for your gateway.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>STANDARD</c> | <c>FIPS</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=8)]
        public string EndpointType
        {
            get { return this._endpointType; }
            set { this._endpointType = value; }
        }

        // Check to see if EndpointType property is set
        internal bool IsSetEndpointType()
        {
            return this._endpointType != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayARN.
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
        /// Gets and sets the property GatewayCapacity. 
        /// <para>
        /// Specifies the size of the gateway's metadata cache.
        /// </para>
        /// </summary>
        public GatewayCapacity GatewayCapacity
        {
            get { return this._gatewayCapacity; }
            set { this._gatewayCapacity = value; }
        }

        // Check to see if GatewayCapacity property is set
        internal bool IsSetGatewayCapacity()
        {
            return this._gatewayCapacity != null;
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
        /// The name you configured for your gateway.
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
        /// Gets and sets the property GatewayNetworkInterfaces. 
        /// <para>
        /// A <a>NetworkInterface</a> array that contains descriptions of the gateway network
        /// interfaces.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NetworkInterface> GatewayNetworkInterfaces
        {
            get { return this._gatewayNetworkInterfaces; }
            set { this._gatewayNetworkInterfaces = value; }
        }

        // Check to see if GatewayNetworkInterfaces property is set
        internal bool IsSetGatewayNetworkInterfaces()
        {
            return this._gatewayNetworkInterfaces != null && (this._gatewayNetworkInterfaces.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property GatewayState. 
        /// <para>
        /// A value that indicates the operating state of the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=25)]
        public string GatewayState
        {
            get { return this._gatewayState; }
            set { this._gatewayState = value; }
        }

        // Check to see if GatewayState property is set
        internal bool IsSetGatewayState()
        {
            return this._gatewayState != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayTimezone. 
        /// <para>
        /// A value that indicates the time zone configured for the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=10)]
        public string GatewayTimezone
        {
            get { return this._gatewayTimezone; }
            set { this._gatewayTimezone = value; }
        }

        // Check to see if GatewayTimezone property is set
        internal bool IsSetGatewayTimezone()
        {
            return this._gatewayTimezone != null;
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
        /// Gets and sets the property LastSoftwareUpdate. 
        /// <para>
        /// The date on which the last software update was applied to the gateway. If the gateway
        /// has never been updated, this field does not return a value in the response. This only
        /// only exist and returns once it have been chosen and set by the SGW service, based
        /// on the OS version of the gateway VM
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
        public string LastSoftwareUpdate
        {
            get { return this._lastSoftwareUpdate; }
            set { this._lastSoftwareUpdate = value; }
        }

        // Check to see if LastSoftwareUpdate property is set
        internal bool IsSetLastSoftwareUpdate()
        {
            return this._lastSoftwareUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property NextUpdateAvailabilityDate. 
        /// <para>
        /// The date on which an update to the gateway is available. This date is in the time
        /// zone of the gateway. If the gateway is not available for an update this field is not
        /// returned in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
        public string NextUpdateAvailabilityDate
        {
            get { return this._nextUpdateAvailabilityDate; }
            set { this._nextUpdateAvailabilityDate = value; }
        }

        // Check to see if NextUpdateAvailabilityDate property is set
        internal bool IsSetNextUpdateAvailabilityDate()
        {
            return this._nextUpdateAvailabilityDate != null;
        }

        /// <summary>
        /// Gets and sets the property SoftwareUpdatesEndDate. 
        /// <para>
        /// Date after which this gateway will not receive software updates for new features.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
        public string SoftwareUpdatesEndDate
        {
            get { return this._softwareUpdatesEndDate; }
            set { this._softwareUpdatesEndDate = value; }
        }

        // Check to see if SoftwareUpdatesEndDate property is set
        internal bool IsSetSoftwareUpdatesEndDate()
        {
            return this._softwareUpdatesEndDate != null;
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

        /// <summary>
        /// Gets and sets the property SupportedGatewayCapacities. 
        /// <para>
        /// A list of the metadata cache sizes that the gateway can support based on its current
        /// hardware specifications.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedGatewayCapacities
        {
            get { return this._supportedGatewayCapacities; }
            set { this._supportedGatewayCapacities = value; }
        }

        // Check to see if SupportedGatewayCapacities property is set
        internal bool IsSetSupportedGatewayCapacities()
        {
            return this._supportedGatewayCapacities != null && (this._supportedGatewayCapacities.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of up to 50 tags assigned to the gateway, sorted alphabetically by key name.
        /// Each tag is a key-value pair. For a gateway with more than 10 tags assigned, you can
        /// view all tags using the <c>ListTagsForResource</c> API operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VPCEndpoint. 
        /// <para>
        /// The configuration settings for the virtual private cloud (VPC) endpoint for your gateway.
        /// </para>
        /// </summary>
        public string VPCEndpoint
        {
            get { return this._vpcEndpoint; }
            set { this._vpcEndpoint = value; }
        }

        // Check to see if VPCEndpoint property is set
        internal bool IsSetVPCEndpoint()
        {
            return this._vpcEndpoint != null;
        }

    }
}