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
        private string _addressId;
        private string _clusterId;
        private DateTime? _creationDate;
        private DataTransfer _dataTransferProgress;
        private string _description;
        private DeviceConfiguration _deviceConfiguration;
        private string _forwardingAddressId;
        private ImpactLevel _impactLevel;
        private string _jobId;
        private JobLogs _jobLogInfo;
        private JobState _jobState;
        private JobType _jobType;
        private string _kmsKeyARN;
        private string _longTermPricingId;
        private Notification _notification;
        private OnDeviceServiceConfiguration _onDeviceServiceConfiguration;
        private PickupDetails _pickupDetails;
        private RemoteManagement _remoteManagement;
        private JobResource _resources;
        private string _roleARN;
        private ShippingDetails _shippingDetails;
        private SnowballCapacity _snowballCapacityPreference;
        private string _snowballId;
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
        /// The 39-character ID for the cluster, for example <c>CID123e4567-e89b-12d3-a456-426655440000</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The creation date for this job.
        /// </para>
        /// </summary>
        public DateTime? CreationDate
        {
            get { return this._creationDate; }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataTransferProgress. 
        /// <para>
        /// A value that defines the real-time status of a Snow device's data transfer while the
        /// device is at Amazon Web Services. This data is only available while a job has a <c>JobState</c>
        /// value of <c>InProgress</c>, for both import and export jobs.
        /// </para>
        /// </summary>
        public DataTransfer DataTransferProgress
        {
            get { return this._dataTransferProgress; }
            set { this._dataTransferProgress = value; }
        }

        // Check to see if DataTransferProgress property is set
        internal bool IsSetDataTransferProgress()
        {
            return this._dataTransferProgress != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the job, provided at job creation.
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
        /// The ID of the address that you want a job shipped to, after it will be shipped to
        /// its primary address. This field is not supported in most regions.
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
        /// Gets and sets the property ImpactLevel. 
        /// <para>
        /// The highest impact level of data that will be stored or processed on the device, provided
        /// at job creation.
        /// </para>
        /// </summary>
        public ImpactLevel ImpactLevel
        {
            get { return this._impactLevel; }
            set { this._impactLevel = value; }
        }

        // Check to see if ImpactLevel property is set
        internal bool IsSetImpactLevel()
        {
            return this._impactLevel != null;
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The automatically generated ID for a job, for example <c>JID123e4567-e89b-12d3-a456-426655440000</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this._jobId != null;
        }

        /// <summary>
        /// Gets and sets the property JobLogInfo. 
        /// <para>
        /// Links to Amazon S3 presigned URLs for the job report and logs. For import jobs, the
        /// PDF job report becomes available at the end of the import process. For export jobs,
        /// your job report typically becomes available while the Snow device for your job part
        /// is being delivered to you.
        /// </para>
        /// </summary>
        public JobLogs JobLogInfo
        {
            get { return this._jobLogInfo; }
            set { this._jobLogInfo = value; }
        }

        // Check to see if JobLogInfo property is set
        internal bool IsSetJobLogInfo()
        {
            return this._jobLogInfo != null;
        }

        /// <summary>
        /// Gets and sets the property JobState. 
        /// <para>
        /// The current status of the jobs.
        /// </para>
        /// </summary>
        public JobState JobState
        {
            get { return this._jobState; }
            set { this._jobState = value; }
        }

        // Check to see if JobState property is set
        internal bool IsSetJobState()
        {
            return this._jobState != null;
        }

        /// <summary>
        /// Gets and sets the property JobType. 
        /// <para>
        /// The type of job.
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
        /// The Amazon Resource Name (ARN) for the Key Management Service (KMS) key associated
        /// with this job. This ARN was created using the <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_CreateKey.html">CreateKey</a>
        /// API action in KMS.
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
        /// The Amazon Simple Notification Service (Amazon SNS) notification settings associated
        /// with a specific job. The <c>Notification</c> object is returned as a part of the response
        /// syntax of the <c>DescribeJob</c> action in the <c>JobMetadata</c> data type.
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
        /// Represents metadata and configuration settings for services on an Amazon Web Services
        /// Snow Family device.
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
        /// Gets and sets the property PickupDetails. 
        /// <para>
        /// Information identifying the person picking up the device.
        /// </para>
        /// </summary>
        public PickupDetails PickupDetails
        {
            get { return this._pickupDetails; }
            set { this._pickupDetails = value; }
        }

        // Check to see if PickupDetails property is set
        internal bool IsSetPickupDetails()
        {
            return this._pickupDetails != null;
        }

        /// <summary>
        /// Gets and sets the property RemoteManagement. 
        /// <para>
        /// Allows you to securely operate and manage Snowcone devices remotely from outside of
        /// your internal network. When set to <c>INSTALLED_AUTOSTART</c>, remote management will
        /// automatically be available when the device arrives at your location. Otherwise, you
        /// need to use the Snowball Client to manage the device.
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
        /// An array of <c>S3Resource</c> objects. Each <c>S3Resource</c> object represents an
        /// Amazon S3 bucket that your transferred data will be exported from or imported into.
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
        /// The role ARN associated with this job. This ARN was created using the <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_CreateRole.html">CreateRole</a>
        /// API action in Identity and Access Management.
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
        /// Gets and sets the property ShippingDetails. 
        /// <para>
        /// A job's shipping information, including inbound and outbound tracking numbers and
        /// shipping speed options.
        /// </para>
        /// </summary>
        public ShippingDetails ShippingDetails
        {
            get { return this._shippingDetails; }
            set { this._shippingDetails = value; }
        }

        // Check to see if ShippingDetails property is set
        internal bool IsSetShippingDetails()
        {
            return this._shippingDetails != null;
        }

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
        /// Gets and sets the property SnowballId. 
        /// <para>
        /// Unique ID associated with a device.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string SnowballId
        {
            get { return this._snowballId; }
            set { this._snowballId = value; }
        }

        // Check to see if SnowballId property is set
        internal bool IsSetSnowballId()
        {
            return this._snowballId != null;
        }

        /// <summary>
        /// Gets and sets the property SnowballType. 
        /// <para>
        /// The type of device used with this job.
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
        /// The metadata associated with the tax documents required in your Amazon Web Services
        /// Region.
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