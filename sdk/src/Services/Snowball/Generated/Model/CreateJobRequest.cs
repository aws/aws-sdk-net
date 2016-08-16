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
    /// Container for the parameters to the CreateJob operation.
    /// Creates a job to import or export data between Amazon S3 and your on-premises data
    /// center. Note that your AWS account must have the right trust policies and permissions
    /// in place to create a job for Snowball. For more information, see <a>api-reference-policies</a>.
    /// </summary>
    public partial class CreateJobRequest : AmazonSnowballRequest
    {
        private string _addressId;
        private string _description;
        private JobType _jobType;
        private string _kmsKeyARN;
        private Notification _notification;
        private JobResource _resources;
        private string _roleARN;
        private ShippingOption _shippingOption;
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
        /// Gets and sets the property Description. 
        /// <para>
        /// Defines an optional description of this specific job, for example <code>Important
        /// Photos 2016-08-11</code>.
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
        /// are created using the <a href="http://docs.aws.amazon.com/kms/latest/APIReference/API_CreateKey.html">CreateKey</a>
        /// AWS Key Management Service (KMS) API action.
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
        /// are created using the <a href="http://docs.aws.amazon.com/IAM/latest/APIReference/API_CreateRole.html">CreateRole</a>
        /// AWS Identity and Access Management (IAM) API action.
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
        /// Gets and sets the property ShippingOption. 
        /// <para>
        /// The shipping speed for this job. Note that this speed does not dictate how soon you'll
        /// get the Snowball, rather it represents how quickly the Snowball moves to its destination
        /// while in transit. Regional shipping speeds are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// In Australia, you have access to express shipping. Typically, Snowballs shipped express
        /// are delivered in about a day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// In the European Union (EU), you have access to express shipping. Typically, Snowballs
        /// shipped express are delivered in about a day. In addition, most countries in the EU
        /// have access to standard shipping, which typically takes less than a week, one way.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// In India, Snowballs are delivered in one to seven days.
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
        /// what size Snowball you'd like for this job. In all other regions, Snowballs come with
        /// 80 TB in storage capacity.
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