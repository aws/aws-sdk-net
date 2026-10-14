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
    /// Container for the parameters to the CreateCluster operation. Creates an empty cluster.
    /// Each cluster supports five nodes. You use the <a>CreateJob</a> action separately to
    /// create the jobs for each of these nodes. The cluster does not ship until these five
    /// node jobs have been created.
    /// </summary>
    public partial class CreateClusterRequest : AmazonSnowballRequest
    {
        /// <summary>
        /// Gets and sets the property AddressId. 
        /// <para>
        /// The ID for the address that you want the cluster shipped to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 40, Max = 40)]
        public string AddressId { get; set; }

        /// <summary>
        /// Checks to see if the AddressId property is set.
        /// </summary>
        internal bool IsSetAddressId() => this.AddressId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description of this specific cluster, for example <c>Environmental Data
        /// Cluster-01</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ForceCreateJobs. 
        /// <para>
        /// Force to create cluster when user attempts to overprovision or underprovision a cluster.
        /// A cluster is overprovisioned or underprovisioned if the initial size of the cluster
        /// is more (overprovisioned) or less (underprovisioned) than what needed to meet capacity
        /// requirement specified with <c>OnDeviceServiceConfiguration</c>.
        /// </para>
        /// </summary>
        public bool? ForceCreateJobs { get; set; }

        /// <summary>
        /// Checks to see if the ForceCreateJobs property is set.
        /// </summary>
        internal bool IsSetForceCreateJobs() => this.ForceCreateJobs.HasValue;

        /// <summary>
        /// Gets and sets the property ForwardingAddressId. 
        /// <para>
        /// The forwarding address ID for a cluster. This field is not supported in most regions.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 40, Max = 40)]
        public string ForwardingAddressId { get; set; }

        /// <summary>
        /// Checks to see if the ForwardingAddressId property is set.
        /// </summary>
        internal bool IsSetForwardingAddressId() => this.ForwardingAddressId != null;

        /// <summary>
        /// Gets and sets the property InitialClusterSize. 
        /// <para>
        /// If provided, each job will be automatically created and associated with the new cluster.
        /// If not provided, will be treated as 0.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 16)]
        public int? InitialClusterSize { get; set; }

        /// <summary>
        /// Checks to see if the InitialClusterSize property is set.
        /// </summary>
        internal bool IsSetInitialClusterSize() => this.InitialClusterSize.HasValue;

        /// <summary>
        /// Gets and sets the property JobType. 
        /// <para>
        /// The type of job for this cluster. Currently, the only job type supported for clusters
        /// is <c>LOCAL_USE</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see "https://docs.aws.amazon.com/snowball/latest/snowcone-guide/snow-device-types.html"
        /// (Snow Family Devices and Capacity) in the <i>Snowcone User Guide</i> or "https://docs.aws.amazon.com/snowball/latest/developer-guide/snow-device-types.html"
        /// (Snow Family Devices and Capacity) in the <i>Snowcone User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public JobType JobType { get; set; }

        /// <summary>
        /// Checks to see if the JobType property is set.
        /// </summary>
        internal bool IsSetJobType() => this.JobType != null;

        /// <summary>
        /// Gets and sets the property KmsKeyARN. 
        /// <para>
        /// The <c>KmsKeyARN</c> value that you want to associate with this cluster. <c>KmsKeyARN</c>
        /// values are created by using the <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_CreateKey.html">CreateKey</a>
        /// API action in Key Management Service (KMS). 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string KmsKeyARN { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyARN property is set.
        /// </summary>
        internal bool IsSetKmsKeyARN() => this.KmsKeyARN != null;

        /// <summary>
        /// Gets and sets the property LongTermPricingIds. 
        /// <para>
        /// Lists long-term pricing id that will be used to associate with jobs automatically
        /// created for the new cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> LongTermPricingIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the LongTermPricingIds property is set.
        /// </summary>
        internal bool IsSetLongTermPricingIds() => this.LongTermPricingIds != null && (this.LongTermPricingIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Notification. 
        /// <para>
        /// The Amazon Simple Notification Service (Amazon SNS) notification settings for this
        /// cluster.
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
        /// data will be exported from or imported into. Amazon Web Services Snow Family device
        /// clusters support Amazon S3 and NFS (Network File System).
        /// </para>
        /// </summary>
        public OnDeviceServiceConfiguration OnDeviceServiceConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the OnDeviceServiceConfiguration property is set.
        /// </summary>
        internal bool IsSetOnDeviceServiceConfiguration() => this.OnDeviceServiceConfiguration != null;

        /// <summary>
        /// Gets and sets the property RemoteManagement. 
        /// <para>
        /// Allows you to securely operate and manage Snow devices in a cluster remotely from
        /// outside of your internal network. When set to <c>INSTALLED_AUTOSTART</c>, remote management
        /// will automatically be available when the device arrives at your location. Otherwise,
        /// you need to use the Snowball Client to manage the device.
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
        /// The resources associated with the cluster job. These resources include Amazon S3 buckets
        /// and optional Lambda functions written in the Python language. 
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
        /// The <c>RoleARN</c> that you want to associate with this cluster. <c>RoleArn</c> values
        /// are created by using the <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_CreateRole.html">CreateRole</a>
        /// API action in Identity and Access Management (IAM).
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
        /// The shipping speed for each node in this cluster. This speed doesn't dictate how soon
        /// you'll get each Snowball Edge device, rather it represents how quickly each device
        /// moves to its destination while in transit. Regional shipping speeds are as follows:
        /// 
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
        /// In the United States of America (US), you have access to one-day shipping and two-day
        /// shipping.
        /// </para>
        ///  </li> </ul> <ul> <li> 
        /// <para>
        /// In Australia, you have access to express shipping. Typically, devices shipped express
        /// are delivered in about a day.
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
        [AWSProperty(Required = true)]
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
        /// The type of Snow Family devices to use for this cluster. 
        /// </para>
        ///  <note> 
        /// <para>
        /// For cluster jobs, Amazon Web Services Snow Family currently supports only the <c>EDGE</c>
        /// device type.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information, see "https://docs.aws.amazon.com/snowball/latest/snowcone-guide/snow-device-types.html"
        /// (Snow Family Devices and Capacity) in the <i>Snowcone User Guide</i> or "https://docs.aws.amazon.com/snowball/latest/developer-guide/snow-device-types.html"
        /// (Snow Family Devices and Capacity) in the <i>Snowcone User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
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
