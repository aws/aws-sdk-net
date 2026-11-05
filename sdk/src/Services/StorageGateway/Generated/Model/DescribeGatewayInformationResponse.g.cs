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
    /// This is the response object from the DescribeGatewayInformation operation.
    /// </summary>
    public partial class DescribeGatewayInformationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CloudWatchLogGroupARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon CloudWatch log group that is used to
        /// monitor events in the gateway. This field only only exist and returns once it have
        /// been chosen and set by the SGW service, based on the OS version of the gateway VM
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 562)]
        public string CloudWatchLogGroupARN { get; set; }

        /// <summary>
        /// Checks to see if the CloudWatchLogGroupARN property is set.
        /// </summary>
        internal bool IsSetCloudWatchLogGroupARN() => this.CloudWatchLogGroupARN != null;

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
        /// Gets and sets the property EndpointType. 
        /// <para>
        /// The type of endpoint for your gateway.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>STANDARD</c> | <c>FIPS</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 4, Max = 8)]
        public string EndpointType { get; set; }

        /// <summary>
        /// Checks to see if the EndpointType property is set.
        /// </summary>
        internal bool IsSetEndpointType() => this.EndpointType != null;

        /// <summary>
        /// Gets and sets the property GatewayARN.
        /// </summary>
        [AWSProperty(Min = 50, Max = 500)]
        public string GatewayARN { get; set; }

        /// <summary>
        /// Checks to see if the GatewayARN property is set.
        /// </summary>
        internal bool IsSetGatewayARN() => this.GatewayARN != null;

        /// <summary>
        /// Gets and sets the property GatewayCapacity. 
        /// <para>
        /// Specifies the size of the gateway's metadata cache.
        /// </para>
        /// </summary>
        public GatewayCapacity GatewayCapacity { get; set; }

        /// <summary>
        /// Checks to see if the GatewayCapacity property is set.
        /// </summary>
        internal bool IsSetGatewayCapacity() => this.GatewayCapacity != null;

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
        /// The name you configured for your gateway.
        /// </para>
        /// </summary>
        public string GatewayName { get; set; }

        /// <summary>
        /// Checks to see if the GatewayName property is set.
        /// </summary>
        internal bool IsSetGatewayName() => this.GatewayName != null;

        /// <summary>
        /// Gets and sets the property GatewayNetworkInterfaces. 
        /// <para>
        /// A <a>NetworkInterface</a> array that contains descriptions of the gateway network
        /// interfaces.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NetworkInterface> GatewayNetworkInterfaces { get; set; } = AWSConfigs.InitializeCollections ? new List<NetworkInterface>() : null;

        /// <summary>
        /// Checks to see if the GatewayNetworkInterfaces property is set.
        /// </summary>
        internal bool IsSetGatewayNetworkInterfaces() => this.GatewayNetworkInterfaces != null && (this.GatewayNetworkInterfaces.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GatewayState. 
        /// <para>
        /// A value that indicates the operating state of the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 25)]
        public string GatewayState { get; set; }

        /// <summary>
        /// Checks to see if the GatewayState property is set.
        /// </summary>
        internal bool IsSetGatewayState() => this.GatewayState != null;

        /// <summary>
        /// Gets and sets the property GatewayTimezone. 
        /// <para>
        /// A value that indicates the time zone configured for the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 10)]
        public string GatewayTimezone { get; set; }

        /// <summary>
        /// Checks to see if the GatewayTimezone property is set.
        /// </summary>
        internal bool IsSetGatewayTimezone() => this.GatewayTimezone != null;

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
        /// Gets and sets the property LastSoftwareUpdate. 
        /// <para>
        /// The date on which the last software update was applied to the gateway. If the gateway
        /// has never been updated, this field does not return a value in the response. This only
        /// only exist and returns once it have been chosen and set by the SGW service, based
        /// on the OS version of the gateway VM
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 25)]
        public string LastSoftwareUpdate { get; set; }

        /// <summary>
        /// Checks to see if the LastSoftwareUpdate property is set.
        /// </summary>
        internal bool IsSetLastSoftwareUpdate() => this.LastSoftwareUpdate != null;

        /// <summary>
        /// Gets and sets the property NextUpdateAvailabilityDate. 
        /// <para>
        /// The date on which an update to the gateway is available. This date is in the time
        /// zone of the gateway. If the gateway is not available for an update this field is not
        /// returned in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 25)]
        public string NextUpdateAvailabilityDate { get; set; }

        /// <summary>
        /// Checks to see if the NextUpdateAvailabilityDate property is set.
        /// </summary>
        internal bool IsSetNextUpdateAvailabilityDate() => this.NextUpdateAvailabilityDate != null;

        /// <summary>
        /// Gets and sets the property SoftwareUpdatesEndDate. 
        /// <para>
        /// Date after which this gateway will not receive software updates for new features.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 25)]
        public string SoftwareUpdatesEndDate { get; set; }

        /// <summary>
        /// Checks to see if the SoftwareUpdatesEndDate property is set.
        /// </summary>
        internal bool IsSetSoftwareUpdatesEndDate() => this.SoftwareUpdatesEndDate != null;

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

        /// <summary>
        /// Gets and sets the property SupportedGatewayCapacities. 
        /// <para>
        /// A list of the metadata cache sizes that the gateway can support based on its current
        /// hardware specifications.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedGatewayCapacities { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupportedGatewayCapacities property is set.
        /// </summary>
        internal bool IsSetSupportedGatewayCapacities() => this.SupportedGatewayCapacities != null && (this.SupportedGatewayCapacities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of up to 50 tags assigned to the gateway, sorted alphabetically by key name.
        /// Each tag is a key-value pair. For a gateway with more than 10 tags assigned, you can
        /// view all tags using the <c>ListTagsForResource</c> API operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VPCEndpoint. 
        /// <para>
        /// The configuration settings for the virtual private cloud (VPC) endpoint for your gateway.
        /// </para>
        /// </summary>
        public string VPCEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the VPCEndpoint property is set.
        /// </summary>
        internal bool IsSetVPCEndpoint() => this.VPCEndpoint != null;
    }
}
