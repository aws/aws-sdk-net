/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Snowball.Model
{
    /// <summary>
    /// Contains information about a specific job including shipping information, job status,
    /// and other important metadata. This information is returned as a part of the response
    /// syntax of the <code>DescribeJob</code> action.
    /// </summary>
    public partial class JobMetadata
    {
        private string _addressId;
        private DateTime? _creationDate;
        private DataTransfer _dataTransferProgress;
        private string _description;
        private string _jobId;
        private JobLogs _jobLogInfo;
        private JobState _jobState;
        private JobType _jobType;
        private string _kmsKeyARN;
        private Notification _notification;
        private JobResource _resources;
        private string _roleARN;
        private ShippingDetails _shippingDetails;
        private SnowballCapacity _snowballCapacityPreference;

        /// <summary>
        /// Gets and sets the property AddressId. 
        /// <para>
        /// The ID for the address that you want the Snowball shipped to.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The creation date for this job.
        /// </para>
        /// </summary>
        public DateTime CreationDate
        {
            get { return this._creationDate.GetValueOrDefault(); }
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
        /// A value that defines the real-time status of a Snowball's data transfer while the
        /// appliance is at AWS. Note that this data is only available while a job has a <code>JobState</code>
        /// value of <code>InProgress</code>, for both import and export jobs.
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
        /// Gets and sets the property JobId. 
        /// <para>
        /// The automatically generated ID for a job, for example <code>JID123e4567-e89b-12d3-a456-426655440000</code>.
        /// </para>
        /// </summary>
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
        /// your job report typically becomes available while the Snowball for your job part is
        /// being delivered to you.
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
        /// The current state of the jobs.
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
        /// The Amazon Resource Name (ARN) for the AWS Key Management Service (AWS KMS) key associated
        /// with this job. This ARN was created using the <code>CreateKey</code> API action in
        /// AWS KMS.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Notification. 
        /// <para>
        /// The Amazon Simple Notification Service (Amazon SNS) notification settings associated
        /// with a specific job. The <code>Notification</code> object is returned as a part of
        /// the response syntax of the <code>DescribeJob</code> action in the <code>JobMetadata</code>
        /// data type.
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
        /// Gets and sets the property Resources. 
        /// <para>
        /// An array of <code>S3Resource</code> objects. Each <code>S3Resource</code> object represents
        /// an Amazon S3 bucket that your transferred data will be exported from or imported into.
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
        /// The role ARN associated with this job. This ARN was created using the <code>CreateRole</code>
        /// API action in AWS Identity and Access Management (IAM).
        /// </para>
        /// </summary>
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
        /// The Snowball capacity preference for this job, specified at job creation. In US regions,
        /// you can choose between 50 TB and 80 TB Snowballs. All other regions use 80 TB capacity
        /// Snowballs.
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

    }
}