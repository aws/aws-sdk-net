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
    /// Contains information about a specific job including shipping information, job status,
    /// and other important metadata. This information is returned as a part of the response
    /// syntax of the <c>DescribeJob</c> action.
    /// </summary>
    public partial class JobMetadata
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
        /// The 39-character ID for the cluster, for example <c>CID123e4567-e89b-12d3-a456-426655440000</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ClusterId { get; set; }

        /// <summary>
        /// Checks to see if the ClusterId property is set.
        /// </summary>
        internal bool IsSetClusterId() => this.ClusterId != null;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The creation date for this job.
        /// </para>
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property DataTransferProgress. 
        /// <para>
        /// A value that defines the real-time status of a Snow device's data transfer while the
        /// device is at Amazon Web Services. This data is only available while a job has a <c>JobState</c>
        /// value of <c>InProgress</c>, for both import and export jobs.
        /// </para>
        /// </summary>
        public DataTransfer DataTransferProgress { get; set; }

        /// <summary>
        /// Checks to see if the DataTransferProgress property is set.
        /// </summary>
        internal bool IsSetDataTransferProgress() => this.DataTransferProgress != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the job, provided at job creation.
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
        /// </summary>
        public DeviceConfiguration DeviceConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DeviceConfiguration property is set.
        /// </summary>
        internal bool IsSetDeviceConfiguration() => this.DeviceConfiguration != null;

        /// <summary>
        /// Gets and sets the property ForwardingAddressId. 
        /// <para>
        /// The ID of the address that you want a job shipped to, after it will be shipped to
        /// its primary address. This field is not supported in most regions.
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
        /// Gets and sets the property JobId. 
        /// <para>
        /// The automatically generated ID for a job, for example <c>JID123e4567-e89b-12d3-a456-426655440000</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string JobId { get; set; }

        /// <summary>
        /// Checks to see if the JobId property is set.
        /// </summary>
        internal bool IsSetJobId() => this.JobId != null;

        /// <summary>
        /// Gets and sets the property JobLogInfo. 
        /// <para>
        /// Links to Amazon S3 presigned URLs for the job report and logs. For import jobs, the
        /// PDF job report becomes available at the end of the import process. For export jobs,
        /// your job report typically becomes available while the Snow device for your job part
        /// is being delivered to you.
        /// </para>
        /// </summary>
        public JobLogs JobLogInfo { get; set; }

        /// <summary>
        /// Checks to see if the JobLogInfo property is set.
        /// </summary>
        internal bool IsSetJobLogInfo() => this.JobLogInfo != null;

        /// <summary>
        /// Gets and sets the property JobState. 
        /// <para>
        /// The current status of the jobs.
        /// </para>
        /// </summary>
        public JobState JobState { get; set; }

        /// <summary>
        /// Checks to see if the JobState property is set.
        /// </summary>
        internal bool IsSetJobState() => this.JobState != null;

        /// <summary>
        /// Gets and sets the property JobType. 
        /// <para>
        /// The type of job.
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
        /// The Amazon Resource Name (ARN) for the Key Management Service (KMS) key associated
        /// with this job. This ARN was created using the <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_CreateKey.html">CreateKey</a>
        /// API action in KMS.
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
        /// The Amazon Simple Notification Service (Amazon SNS) notification settings associated
        /// with a specific job. The <c>Notification</c> object is returned as a part of the response
        /// syntax of the <c>DescribeJob</c> action in the <c>JobMetadata</c> data type.
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
        /// Represents metadata and configuration settings for services on an Amazon Web Services
        /// Snow Family device.
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
        /// need to use the Snowball Client to manage the device.
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
        /// An array of <c>S3Resource</c> objects. Each <c>S3Resource</c> object represents an
        /// Amazon S3 bucket that your transferred data will be exported from or imported into.
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
        /// The role ARN associated with this job. This ARN was created using the <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_CreateRole.html">CreateRole</a>
        /// API action in Identity and Access Management.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string RoleARN { get; set; }

        /// <summary>
        /// Checks to see if the RoleARN property is set.
        /// </summary>
        internal bool IsSetRoleARN() => this.RoleARN != null;

        /// <summary>
        /// Gets and sets the property ShippingDetails. 
        /// <para>
        /// A job's shipping information, including inbound and outbound tracking numbers and
        /// shipping speed options.
        /// </para>
        /// </summary>
        public ShippingDetails ShippingDetails { get; set; }

        /// <summary>
        /// Checks to see if the ShippingDetails property is set.
        /// </summary>
        internal bool IsSetShippingDetails() => this.ShippingDetails != null;

        /// <summary>
        /// Gets and sets the property SnowballCapacityPreference. 
        /// <para>
        /// The Snow device capacity preference for this job, specified at job creation. In US
        /// regions, you can choose between 50 TB and 80 TB Snowballs. All other regions use 80
        /// TB capacity Snowballs.
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
        /// Gets and sets the property SnowballId. 
        /// <para>
        /// Unique ID associated with a device.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string SnowballId { get; set; }

        /// <summary>
        /// Checks to see if the SnowballId property is set.
        /// </summary>
        internal bool IsSetSnowballId() => this.SnowballId != null;

        /// <summary>
        /// Gets and sets the property SnowballType. 
        /// <para>
        /// The type of device used with this job.
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
        /// The metadata associated with the tax documents required in your Amazon Web Services
        /// Region.
        /// </para>
        /// </summary>
        public TaxDocuments TaxDocuments { get; set; }

        /// <summary>
        /// Checks to see if the TaxDocuments property is set.
        /// </summary>
        internal bool IsSetTaxDocuments() => this.TaxDocuments != null;
    }
}
