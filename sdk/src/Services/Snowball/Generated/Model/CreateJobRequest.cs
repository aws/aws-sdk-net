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
 * Do not modify this file. This file is generated from the snowball-2016-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Snowball.Model
{
    /// <summary>
    /// Container for the parameters to the CreateJob operation.
    /// Creates a job to import or export data between Amazon S3 and your on-premises data
    /// center. Your Amazon Web Services account must have the right trust policies and permissions
    /// in place to create a job for a Snow device. If you're creating a job for a node in
    /// a cluster, you only need to provide the <code>clusterId</code> value; the other job
    /// attributes are inherited from the cluster. 
    /// 
    ///  <note> 
    /// <para>
    /// Only the Snowball; Edge device type is supported when ordering clustered jobs.
    /// </para>
    ///  
    /// <para>
    /// The device capacity is optional.
    /// </para>
    ///  
    /// <para>
    /// Availability of device types differ by Amazon Web Services Region. For more information
    /// about Region availability, see <a href="https://aws.amazon.com/about-aws/global-infrastructure/regional-product-services/?p=ngi&amp;loc=4">Amazon
    /// Web Services Regional Services</a>.
    /// </para>
    ///  </note>  <p class="title"> <b>Snow Family devices and their capacities.</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Snow Family device type: <b>SNC1_SSD</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Capacity: T14
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Description: Snowcone 
    /// </para>
    ///  </li> </ul>  </li> <li> 
    /// <para>
    /// Snow Family device type: <b>SNC1_HDD</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Capacity: T8
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Description: Snowcone 
    /// </para>
    ///  </li> </ul>  </li> <li> 
    /// <para>
    /// Device type: <b>EDGE_S</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Capacity: T98
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Description: Snowball Edge Storage Optimized for data transfer only 
    /// </para>
    ///  </li> </ul>  </li> <li> 
    /// <para>
    /// Device type: <b>EDGE_CG</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Capacity: T42
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Description: Snowball Edge Compute Optimized with GPU
    /// </para>
    ///  </li> </ul>  </li> <li> 
    /// <para>
    /// Device type: <b>EDGE_C</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Capacity: T42
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Description: Snowball Edge Compute Optimized without GPU
    /// </para>
    ///  </li> </ul>  </li> <li> 
    /// <para>
    /// Device type: <b>EDGE</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Capacity: T100
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Description: Snowball Edge Storage Optimized with EC2 Compute
    /// </para>
    ///  </li> </ul>  </li> <li> 
    /// <para>
    /// Device type: <b>STANDARD</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Capacity: T50
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Description: Original Snowball device
    /// </para>
    ///  <note> 
    /// <para>
    /// This device is only available in the Ningxia, Beijing, and Singapore Amazon Web Services
    /// Region 
    /// </para>
    ///  </note> </li> </ul>  </li> <li> 
    /// <para>
    /// Device type: <b>STANDARD</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Capacity: T80
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Description: Original Snowball device
    /// </para>
    ///  <note> 
    /// <para>
    /// This device is only available in the Ningxia, Beijing, and Singapore Amazon Web Services
    /// Region. 
    /// </para>
    ///  </note> </li> </ul>  </li> </ul>
    /// </summary>
    public partial class CreateJobRequest : AmazonSnowballRequest
    {
        private string _addressId;
        private string _clusterId;
        private string _description;
        private DeviceConfiguration _deviceConfiguration;
        private string _forwardingAddressId;
        private JobType _jobType;
        private string _kmsKeyARN;
        private string _longTermPricingId;
        private Notification _notification;
        private OnDeviceServiceConfiguration _onDeviceServiceConfiguration;
        private RemoteManagement _remoteManagement;
        private JobResource _resources;
        private string _roleARN;
        private ShippingOption _shippingOption;
        private SnowballCapacity _snowballCapacityPreference;
        private SnowballType _snowballType;
        private TaxDocuments _taxDocuments;

        /// <summary>
        /// Gets and sets the property AddressId. 
        /// <para>
        /// The ID for the address that you want the Snow device shipped to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=40, Max=40)]
        public string AddressId
        {
            get { return this._addressId; }
            set { this._addressId = value; }
        }

        // Check to see if AddressId property is set
        internal bool IsSetAddressId()
        {
            return this._addressId != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterId. 
        /// <para>
        /// The ID of a cluster. If you're creating a job for a node in a cluster, you need to
        /// provide only this <code>clusterId</code> value. The other job attributes are inherited
        /// from the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=39, Max=39)]
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
        /// Gets and sets the property Description. 
        /// <para>
        /// Defines an optional description of this specific job, for example <code>Important
        /// Photos 2016-08-11</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceConfiguration. 
        /// <para>
        /// Defines the device configuration for an Snowcone job.
        /// </para>
        ///  
        /// <para>
        /// For more information, see "https://docs.aws.amazon.com/snowball/latest/snowcone-guide/snow-device-types.html"
        /// (Snow Family Devices and Capacity) in the <i>Snowcone User Guide</i> or "https://docs.aws.amazon.com/snowball/latest/developer-guide/snow-device-types.html"
        /// (Snow Family Devices and Capacity) in the <i>Snowcone User Guide</i>.
        /// </para>
        /// </summary>
        public DeviceConfiguration DeviceConfiguration
        {
            get { return this._deviceConfiguration; }
            set { this._deviceConfiguration = value; }
        }

        // Check to see if DeviceConfiguration property is set
        internal bool IsSetDeviceConfiguration()
        {
            return this._deviceConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ForwardingAddressId. 
        /// <para>
        /// The forwarding address ID for a job. This field is not supported in most Regions.
        /// </para>
        /// </summary>
        [AWSProperty(Min=40, Max=40)]
        public string ForwardingAddressId
        {
            get { return this._forwardingAddressId; }
            set { this._forwardingAddressId = value; }
        }

        // Check to see if ForwardingAddressId property is set
        internal bool IsSetForwardingAddressId()
        {
            return this._forwardingAddressId != null;
        }

        /// <summary>
        /// Gets and sets the property JobType. 
        /// <para>
        /// Defines the type of job that you're creating. 
        /// </para>
        /// </summary>
        public JobType JobType
        {
            get { return this._jobType; }
            set { this._jobType = value; }
        }

        // Check to see if JobType property is set
        internal bool IsSetJobType()
        {
            return this._jobType != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyARN. 
        /// <para>
        /// The <code>KmsKeyARN</code> that you want to associate with this job. <code>KmsKeyARN</code>s
        /// are created using the <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_CreateKey.html">CreateKey</a>
        /// Key Management Service (KMS) API action.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
        public string KmsKeyARN
        {
            get { return this._kmsKeyARN; }
            set { this._kmsKeyARN = value; }
        }

        // Check to see if KmsKeyARN property is set
        internal bool IsSetKmsKeyARN()
        {
            return this._kmsKeyARN != null;
        }

        /// <summary>
        /// Gets and sets the property LongTermPricingId. 
        /// <para>
        /// The ID of the long-term pricing type for the device.
        /// </para>
        /// </summary>
        [AWSProperty(Min=41, Max=41)]
        public string LongTermPricingId
        {
            get { return this._longTermPricingId; }
            set { this._longTermPricingId = value; }
        }

        // Check to see if LongTermPricingId property is set
        internal bool IsSetLongTermPricingId()
        {
            return this._longTermPricingId != null;
        }

        /// <summary>
        /// Gets and sets the property Notification. 
        /// <para>
        /// Defines the Amazon Simple Notification Service (Amazon SNS) notification settings
        /// for this job.
        /// </para>
        /// </summary>
        public Notification Notification
        {
            get { return this._notification; }
            set { this._notification = value; }
        }

        // Check to see if Notification property is set
        internal bool IsSetNotification()
        {
            return this._notification != null;
        }

        /// <summary>
        /// Gets and sets the property OnDeviceServiceConfiguration. 
        /// <para>
        /// Specifies the service or services on the Snow Family device that your transferred
        /// data will be exported from or imported into. Amazon Web Services Snow Family supports
        /// Amazon S3 and NFS (Network File System) and the Amazon Web Services Storage Gateway
        /// service Tape Gateway type.
        /// </para>
        /// </summary>
        public OnDeviceServiceConfiguration OnDeviceServiceConfiguration
        {
            get { return this._onDeviceServiceConfiguration; }
            set { this._onDeviceServiceConfiguration = value; }
        }

        // Check to see if OnDeviceServiceConfiguration property is set
        internal bool IsSetOnDeviceServiceConfiguration()
        {
            return this._onDeviceServiceConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RemoteManagement. 
        /// <para>
        /// Allows you to securely operate and manage Snowcone devices remotely from outside of
        /// your internal network. When set to <code>INSTALLED_AUTOSTART</code>, remote management
        /// will automatically be available when the device arrives at your location. Otherwise,
        /// you need to use the Snowball Client to manage the device.
        /// </para>
        /// </summary>
        public RemoteManagement RemoteManagement
        {
            get { return this._remoteManagement; }
            set { this._remoteManagement = value; }
        }

        // Check to see if RemoteManagement property is set
        internal bool IsSetRemoteManagement()
        {
            return this._remoteManagement != null;
        }

        /// <summary>
        /// Gets and sets the property Resources. 
        /// <para>
        /// Defines the Amazon S3 buckets associated with this job.
        /// </para>
        ///  
        /// <para>
        /// With <code>IMPORT</code> jobs, you specify the bucket or buckets that your transferred
        /// data will be imported into.
        /// </para>
        ///  
        /// <para>
        /// With <code>EXPORT</code> jobs, you specify the bucket or buckets that your transferred
        /// data will be exported from. Optionally, you can also specify a <code>KeyRange</code>
        /// value. If you choose to export a range, you define the length of the range by providing
        /// either an inclusive <code>BeginMarker</code> value, an inclusive <code>EndMarker</code>
        /// value, or both. Ranges are UTF-8 binary sorted.
        /// </para>
        /// </summary>
        public JobResource Resources
        {
            get { return this._resources; }
            set { this._resources = value; }
        }

        // Check to see if Resources property is set
        internal bool IsSetResources()
        {
            return this._resources != null;
        }

        /// <summary>
        /// Gets and sets the property RoleARN. 
        /// <para>
        /// The <code>RoleARN</code> that you want to associate with this job. <code>RoleArn</code>s
        /// are created using the <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_CreateRole.html">CreateRole</a>
        /// Identity and Access Management (IAM) API action.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
        public string RoleARN
        {
            get { return this._roleARN; }
            set { this._roleARN = value; }
        }

        // Check to see if RoleARN property is set
        internal bool IsSetRoleARN()
        {
            return this._roleARN != null;
        }

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
        public ShippingOption ShippingOption
        {
            get { return this._shippingOption; }
            set { this._shippingOption = value; }
        }

        // Check to see if ShippingOption property is set
        internal bool IsSetShippingOption()
        {
            return this._shippingOption != null;
        }

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
        public SnowballCapacity SnowballCapacityPreference
        {
            get { return this._snowballCapacityPreference; }
            set { this._snowballCapacityPreference = value; }
        }

        // Check to see if SnowballCapacityPreference property is set
        internal bool IsSetSnowballCapacityPreference()
        {
            return this._snowballCapacityPreference != null;
        }

        /// <summary>
        /// Gets and sets the property SnowballType. 
        /// <para>
        /// The type of Snow Family devices to use for this job. 
        /// </para>
        ///  <note> 
        /// <para>
        /// For cluster jobs, Amazon Web Services Snow Family currently supports only the <code>EDGE</code>
        /// device type.
        /// </para>
        ///  </note> 
        /// <para>
        /// The type of Amazon Web Services Snow device to use for this job. Currently, the only
        /// supported device type for cluster jobs is <code>EDGE</code>.
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
        public SnowballType SnowballType
        {
            get { return this._snowballType; }
            set { this._snowballType = value; }
        }

        // Check to see if SnowballType property is set
        internal bool IsSetSnowballType()
        {
            return this._snowballType != null;
        }

        /// <summary>
        /// Gets and sets the property TaxDocuments. 
        /// <para>
        /// The tax documents required in your Amazon Web Services Region.
        /// </para>
        /// </summary>
        public TaxDocuments TaxDocuments
        {
            get { return this._taxDocuments; }
            set { this._taxDocuments = value; }
        }

        // Check to see if TaxDocuments property is set
        internal bool IsSetTaxDocuments()
        {
            return this._taxDocuments != null;
        }

    }
}