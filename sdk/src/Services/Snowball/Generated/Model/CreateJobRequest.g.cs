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

namespace Amazon.Snowball.Model
{
    /// <summary>
    /// Container for the parameters to the CreateJob operation. Creates a job to import or
    /// export data between Amazon S3 and your on-premises data center. Your Amazon Web Services
    /// account must have the right trust policies and permissions in place to create a job
    /// for a Snow device. If you're creating a job for a node in a cluster, you only need
    /// to provide the <c>clusterId</c> value; the other job attributes are inherited from
    /// the cluster. <note> <para> Only the Snowball; Edge device type is supported when ordering
    /// clustered jobs. </para> <para> The device capacity is optional. </para> <para> Availability
    /// of device types differ by Amazon Web Services Region. For more information about Region
    /// availability, see <a href="https://aws.amazon.com/about-aws/global-infrastructure/regional-product-services/?p=ngi&amp;loc=4">Amazon
    /// Web Services Regional Services</a>. </para> </note> <para> </para> <para> <b>Snow
    /// Family devices and their capacities.</b> </para> <ul> <li> <para> Device type: <b>SNC1_SSD</b>
    /// </para> <ul> <li> <para> Capacity: T14 </para> </li> <li> <para> Description: Snowcone
    /// </para> </li> </ul> <para> </para> </li> <li> <para> Device type: <b>SNC1_HDD</b>
    /// </para> <ul> <li> <para> Capacity: T8 </para> </li> <li> <para> Description: Snowcone
    /// </para> </li> </ul> <para> </para> </li> <li> <para> Device type: <b>EDGE_S</b> </para>
    /// <ul> <li> <para> Capacity: T98 </para> </li> <li> <para> Description: Snowball Edge
    /// Storage Optimized for data transfer only </para> </li> </ul> <para> </para> </li>
    /// <li> <para> Device type: <b>EDGE_CG</b> </para> <ul> <li> <para> Capacity: T42 </para>
    /// </li> <li> <para> Description: Snowball Edge Compute Optimized with GPU </para> </li>
    /// </ul> <para> </para> </li> <li> <para> Device type: <b>EDGE_C</b> </para> <ul> <li>
    /// <para> Capacity: T42 </para> </li> <li> <para> Description: Snowball Edge Compute
    /// Optimized without GPU </para> </li> </ul> <para> </para> </li> <li> <para> Device
    /// type: <b>EDGE</b> </para> <ul> <li> <para> Capacity: T100 </para> </li> <li> <para>
    /// Description: Snowball Edge Storage Optimized with EC2 Compute </para> </li> </ul>
    /// <note> <para> This device is replaced with T98. </para> </note> <para> </para> </li>
    /// <li> <para> Device type: <b>STANDARD</b> </para> <ul> <li> <para> Capacity: T50 </para>
    /// </li> <li> <para> Description: Original Snowball device </para> <note> <para> This
    /// device is only available in the Ningxia, Beijing, and Singapore Amazon Web Services
    /// Region </para> </note> </li> </ul> <para> </para> </li> <li> <para> Device type: <b>STANDARD</b>
    /// </para> <ul> <li> <para> Capacity: T80 </para> </li> <li> <para> Description: Original
    /// Snowball device </para> <note> <para> This device is only available in the Ningxia,
    /// Beijing, and Singapore Amazon Web Services Region. </para> </note> </li> </ul> <para>
    /// </para> </li> <li> <para> Snow Family device type: <b>RACK_5U_C</b> </para> <ul> <li>
    /// <para> Capacity: T13 </para> </li> <li> <para> Description: Snowblade. </para> </li>
    /// </ul> </li> <li> <para> Device type: <b>V3_5S</b> </para> <ul> <li> <para> Capacity:
    /// T240 </para> </li> <li> <para> Description: Snowball Edge Storage Optimized 210TB
    /// </para> </li> </ul> </li> </ul>
    /// </summary>
    public partial class CreateJobRequest : AmazonSnowballRequest
    {
        /// <summary>
        /// Gets and sets the property AddressId. 
        /// <para>
        /// The ID for the address that you want the Snow device shipped to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 40, Max = 40)]
        public string AddressId { get; set; }

        /// <summary>
        /// Checks to see if the AddressId property is set.
        /// </summary>
        internal bool IsSetAddressId() => this.AddressId != null;

        /// <summary>
        /// Gets and sets the property ClusterId. 
        /// <para>
        /// The ID of a cluster. If you're creating a job for a node in a cluster, you need to
        /// provide only this <c>clusterId</c> value. The other job attributes are inherited from
        /// the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 39, Max = 39)]
        public string ClusterId { get; set; }

        /// <summary>
        /// Checks to see if the ClusterId property is set.
        /// </summary>
        internal bool IsSetClusterId() => this.ClusterId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Defines an optional description of this specific job, for example <c>Important Photos
        /// 2016-08-11</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DeviceConfiguration. 
        /// <para>
        /// Defines the device configuration for an Snowball Edge job.
        /// </para>
        ///  
        /// <para>
        /// For more information, see "https://docs.aws.amazon.com/snowball/latest/snowcone-guide/snow-device-types.html"
        /// (Snow Family Devices and Capacity) in the <i>Snowcone User Guide</i> or "https://docs.aws.amazon.com/snowball/latest/developer-guide/snow-device-types.html"
        /// (Snow Family Devices and Capacity) in the <i>Snowcone User Guide</i>.
        /// </para>
        /// </summary>
        public DeviceConfiguration DeviceConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DeviceConfiguration property is set.
        /// </summary>
        internal bool IsSetDeviceConfiguration() => this.DeviceConfiguration != null;

        /// <summary>
        /// Gets and sets the property ForwardingAddressId. 
        /// <para>
        /// The forwarding address ID for a job. This field is not supported in most Regions.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 40, Max = 40)]
        public string ForwardingAddressId { get; set; }

        /// <summary>
        /// Checks to see if the ForwardingAddressId property is set.
        /// </summary>
        internal bool IsSetForwardingAddressId() => this.ForwardingAddressId != null;

        /// <summary>
        /// Gets and sets the property ImpactLevel. 
        /// <para>
        /// The highest impact level of data that will be stored or processed on the device, provided
        /// at job creation.
        /// </para>
        /// </summary>
        public ImpactLevel ImpactLevel { get; set; }

        /// <summary>
        /// Checks to see if the ImpactLevel property is set.
        /// </summary>
        internal bool IsSetImpactLevel() => this.ImpactLevel != null;

        /// <summary>
        /// Gets and sets the property JobType. 
        /// <para>
        /// Defines the type of job that you're creating. 
        /// </para>
        /// </summary>
        public JobType JobType { get; set; }

        /// <summary>
        /// Checks to see if the JobType property is set.
        /// </summary>
        internal bool IsSetJobType() => this.JobType != null;

        /// <summary>
        /// Gets and sets the property KmsKeyARN. 
        /// <para>
        /// The <c>KmsKeyARN</c> that you want to associate with this job. <c>KmsKeyARN</c>s are
        /// created using the <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_CreateKey.html">CreateKey</a>
        /// Key Management Service (KMS) API action.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string KmsKeyARN { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyARN property is set.
        /// </summary>
        internal bool IsSetKmsKeyARN() => this.KmsKeyARN != null;

        /// <summary>
        /// Gets and sets the property LongTermPricingId. 
        /// <para>
        /// The ID of the long-term pricing type for the device.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 41, Max = 41)]
        public string LongTermPricingId { get; set; }

        /// <summary>
        /// Checks to see if the LongTermPricingId property is set.
        /// </summary>
        internal bool IsSetLongTermPricingId() => this.LongTermPricingId != null;

        /// <summary>
        /// Gets and sets the property Notification. 
        /// <para>
        /// Defines the Amazon Simple Notification Service (Amazon SNS) notification settings
        /// for this job.
        /// </para>
        /// </summary>
        public Notification Notification { get; set; }

        /// <summary>
        /// Checks to see if the Notification property is set.
        /// </summary>
        internal bool IsSetNotification() => this.Notification != null;

        /// <summary>
        /// Gets and sets the property OnDeviceServiceConfiguration. 
        /// <para>
        /// Specifies the service or services on the Snow Family device that your transferred
        /// data will be exported from or imported into. Amazon Web Services Snow Family supports
        /// Amazon S3 and NFS (Network File System) and the Amazon Web Services Storage Gateway
        /// service Tape Gateway type.
        /// </para>
        /// </summary>
        public OnDeviceServiceConfiguration OnDeviceServiceConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the OnDeviceServiceConfiguration property is set.
        /// </summary>
        internal bool IsSetOnDeviceServiceConfiguration() => this.OnDeviceServiceConfiguration != null;

        /// <summary>
        /// Gets and sets the property PickupDetails. 
        /// <para>
        /// Information identifying the person picking up the device.
        /// </para>
        /// </summary>
        public PickupDetails PickupDetails { get; set; }

        /// <summary>
        /// Checks to see if the PickupDetails property is set.
        /// </summary>
        internal bool IsSetPickupDetails() => this.PickupDetails != null;

        /// <summary>
        /// Gets and sets the property RemoteManagement. 
        /// <para>
        /// Allows you to securely operate and manage Snowcone devices remotely from outside of
        /// your internal network. When set to <c>INSTALLED_AUTOSTART</c>, remote management will
        /// automatically be available when the device arrives at your location. Otherwise, you
        /// need to use the Snowball Edge client to manage the device. When set to <c>NOT_INSTALLED</c>,
        /// remote management will not be available on the device. 
        /// </para>
        /// </summary>
        public RemoteManagement RemoteManagement { get; set; }

        /// <summary>
        /// Checks to see if the RemoteManagement property is set.
        /// </summary>
        internal bool IsSetRemoteManagement() => this.RemoteManagement != null;

        /// <summary>
        /// Gets and sets the property Resources. 
        /// <para>
        /// Defines the Amazon S3 buckets associated with this job.
        /// </para>
        ///  
        /// <para>
        /// With <c>IMPORT</c> jobs, you specify the bucket or buckets that your transferred data
        /// will be imported into.
        /// </para>
        ///  
        /// <para>
        /// With <c>EXPORT</c> jobs, you specify the bucket or buckets that your transferred data
        /// will be exported from. Optionally, you can also specify a <c>KeyRange</c> value. If
        /// you choose to export a range, you define the length of the range by providing either
        /// an inclusive <c>BeginMarker</c> value, an inclusive <c>EndMarker</c> value, or both.
        /// Ranges are UTF-8 binary sorted.
        /// </para>
        /// </summary>
        public JobResource Resources { get; set; }

        /// <summary>
        /// Checks to see if the Resources property is set.
        /// </summary>
        internal bool IsSetResources() => this.Resources != null;

        /// <summary>
        /// Gets and sets the property RoleARN. 
        /// <para>
        /// The <c>RoleARN</c> that you want to associate with this job. <c>RoleArn</c>s are created
        /// using the <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_CreateRole.html">CreateRole</a>
        /// Identity and Access Management (IAM) API action.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string RoleARN { get; set; }

        /// <summary>
        /// Checks to see if the RoleARN property is set.
        /// </summary>
        internal bool IsSetRoleARN() => this.RoleARN != null;

        /// <summary>
        /// Gets and sets the property ShippingOption. 
        /// <para>
        /// The shipping speed for this job. This speed doesn't dictate how soon you'll get the
        /// Snow device, rather it represents how quickly the Snow device moves to its destination
        /// while in transit. Regional shipping speeds are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// In Australia, you have access to express shipping. Typically, Snow devices shipped
        /// express are delivered in about a day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// In the European Union (EU), you have access to express shipping. Typically, Snow devices
        /// shipped express are delivered in about a day. In addition, most countries in the EU
        /// have access to standard shipping, which typically takes less than a week, one way.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// In India, Snow devices are delivered in one to seven days.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// In the US, you have access to one-day shipping and two-day shipping.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ShippingOption ShippingOption { get; set; }

        /// <summary>
        /// Checks to see if the ShippingOption property is set.
        /// </summary>
        internal bool IsSetShippingOption() => this.ShippingOption != null;

        /// <summary>
        /// Gets and sets the property SnowballCapacityPreference. 
        /// <para>
        /// If your job is being created in one of the US regions, you have the option of specifying
        /// what size Snow device you'd like for this job. In all other regions, Snowballs come
        /// with 80 TB in storage capacity.
        /// </para>
        ///  
        /// <para>
        /// For more information, see "https://docs.aws.amazon.com/snowball/latest/snowcone-guide/snow-device-types.html"
        /// (Snow Family Devices and Capacity) in the <i>Snowcone User Guide</i> or "https://docs.aws.amazon.com/snowball/latest/developer-guide/snow-device-types.html"
        /// (Snow Family Devices and Capacity) in the <i>Snowcone User Guide</i>.
        /// </para>
        /// </summary>
        public SnowballCapacity SnowballCapacityPreference { get; set; }

        /// <summary>
        /// Checks to see if the SnowballCapacityPreference property is set.
        /// </summary>
        internal bool IsSetSnowballCapacityPreference() => this.SnowballCapacityPreference != null;

        /// <summary>
        /// Gets and sets the property SnowballType. 
        /// <para>
        /// The type of Snow Family devices to use for this job. 
        /// </para>
        ///  <note> 
        /// <para>
        /// For cluster jobs, Amazon Web Services Snow Family currently supports only the <c>EDGE</c>
        /// device type.
        /// </para>
        ///  </note> 
        /// <para>
        /// The type of Amazon Web Services Snow device to use for this job. Currently, the only
        /// supported device type for cluster jobs is <c>EDGE</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/snowball/latest/developer-guide/device-differences.html">Snowball
        /// Edge Device Options</a> in the Snowball Edge Developer Guide.
        /// </para>
        ///  
        /// <para>
        /// For more information, see "https://docs.aws.amazon.com/snowball/latest/snowcone-guide/snow-device-types.html"
        /// (Snow Family Devices and Capacity) in the <i>Snowcone User Guide</i> or "https://docs.aws.amazon.com/snowball/latest/developer-guide/snow-device-types.html"
        /// (Snow Family Devices and Capacity) in the <i>Snowcone User Guide</i>.
        /// </para>
        /// </summary>
        public SnowballType SnowballType { get; set; }

        /// <summary>
        /// Checks to see if the SnowballType property is set.
        /// </summary>
        internal bool IsSetSnowballType() => this.SnowballType != null;

        /// <summary>
        /// Gets and sets the property TaxDocuments. 
        /// <para>
        /// The tax documents required in your Amazon Web Services Region.
        /// </para>
        /// </summary>
        public TaxDocuments TaxDocuments { get; set; }

        /// <summary>
        /// Checks to see if the TaxDocuments property is set.
        /// </summary>
        internal bool IsSetTaxDocuments() => this.TaxDocuments != null;
    }
}
