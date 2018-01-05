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
    /// Container for the parameters to the CreateCluster operation.
    /// Creates an empty cluster. Each cluster supports five nodes. You use the <a>CreateJob</a>
    /// action separately to create the jobs for each of these nodes. The cluster does not
    /// ship until these five node jobs have been created.
    /// </summary>
    public partial class CreateClusterRequest : AmazonSnowballRequest
    {
        private string _addressId;
        private string _description;
        private string _forwardingAddressId;
        private JobType _jobType;
        private string _kmsKeyARN;
        private Notification _notification;
        private JobResource _resources;
        private string _roleARN;
        private ShippingOption _shippingOption;
        private SnowballType _snowballType;

        /// <summary>
        /// Gets and sets the property AddressId. 
        /// <para>
        /// The ID for the address that you want the cluster shipped to.
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
        /// An optional description of this specific cluster, for example <code>Environmental
        /// Data Cluster-01</code>.
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
        /// Gets and sets the property ForwardingAddressId. 
        /// <para>
        /// The forwarding address ID for a cluster. This field is not supported in most regions.
        /// </para>
        /// </summary>
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
        /// The type of job for this cluster. Currently, the only job type supported for clusters
        /// is <code>LOCAL_USE</code>.
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
        /// The <code>KmsKeyARN</code> value that you want to associate with this cluster. <code>KmsKeyARN</code>
        /// values are created by using the <a href="http://docs.aws.amazon.com/kms/latest/APIReference/API_CreateKey.html">CreateKey</a>
        /// API action in AWS Key Management Service (AWS KMS). 
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
        /// The Amazon Simple Notification Service (Amazon SNS) notification settings for this
        /// cluster.
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
        /// The resources associated with the cluster job. These resources include Amazon S3 buckets
        /// and optional AWS Lambda functions written in the Python language. 
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
        /// The <code>RoleARN</code> that you want to associate with this cluster. <code>RoleArn</code>
        /// values are created by using the <a href="http://docs.aws.amazon.com/IAM/latest/APIReference/API_CreateRole.html">CreateRole</a>
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
        /// Gets and sets the property ShippingOption. 
        /// <para>
        /// The shipping speed for each node in this cluster. This speed doesn't dictate how soon
        /// you'll get each Snowball Edge appliance, rather it represents how quickly each appliance
        /// moves to its destination while in transit. Regional shipping speeds are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// In Australia, you have access to express shipping. Typically, appliances shipped express
        /// are delivered in about a day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// In the European Union (EU), you have access to express shipping. Typically, Snowball
        /// Edges shipped express are delivered in about a day. In addition, most countries in
        /// the EU have access to standard shipping, which typically takes less than a week, one
        /// way.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// In India, Snowball Edges are delivered in one to seven days.
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
        /// Gets and sets the property SnowballType. 
        /// <para>
        /// The type of AWS Snowball appliance to use for this cluster. Currently, the only supported
        /// appliance type for cluster jobs is <code>EDGE</code>.
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

    }
}