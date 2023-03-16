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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about the Amazon Web Services resource associated with the activity
    /// that prompted GuardDuty to generate a finding.
    /// </summary>
    public partial class Resource
    {
        private AccessKeyDetails _accessKeyDetails;
        private Container _containerDetails;
        private EbsVolumeDetails _ebsVolumeDetails;
        private EcsClusterDetails _ecsClusterDetails;
        private EksClusterDetails _eksClusterDetails;
        private InstanceDetails _instanceDetails;
        private KubernetesDetails _kubernetesDetails;
        private RdsDbInstanceDetails _rdsDbInstanceDetails;
        private RdsDbUserDetails _rdsDbUserDetails;
        private string _resourceType;
        private List<S3BucketDetail> _s3BucketDetails = new List<S3BucketDetail>();

        /// <summary>
        /// Gets and sets the property AccessKeyDetails. 
        /// <para>
        /// The IAM access key details (user information) of a user that engaged in the activity
        /// that prompted GuardDuty to generate a finding.
        /// </para>
        /// </summary>
        public AccessKeyDetails AccessKeyDetails
        {
            get { return this._accessKeyDetails; }
            set { this._accessKeyDetails = value; }
        }

        // Check to see if AccessKeyDetails property is set
        internal bool IsSetAccessKeyDetails()
        {
            return this._accessKeyDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ContainerDetails.
        /// </summary>
        public Container ContainerDetails
        {
            get { return this._containerDetails; }
            set { this._containerDetails = value; }
        }

        // Check to see if ContainerDetails property is set
        internal bool IsSetContainerDetails()
        {
            return this._containerDetails != null;
        }

        /// <summary>
        /// Gets and sets the property EbsVolumeDetails. 
        /// <para>
        /// Contains list of scanned and skipped EBS volumes with details.
        /// </para>
        /// </summary>
        public EbsVolumeDetails EbsVolumeDetails
        {
            get { return this._ebsVolumeDetails; }
            set { this._ebsVolumeDetails = value; }
        }

        // Check to see if EbsVolumeDetails property is set
        internal bool IsSetEbsVolumeDetails()
        {
            return this._ebsVolumeDetails != null;
        }

        /// <summary>
        /// Gets and sets the property EcsClusterDetails. 
        /// <para>
        /// Contains information about the details of the ECS Cluster.
        /// </para>
        /// </summary>
        public EcsClusterDetails EcsClusterDetails
        {
            get { return this._ecsClusterDetails; }
            set { this._ecsClusterDetails = value; }
        }

        // Check to see if EcsClusterDetails property is set
        internal bool IsSetEcsClusterDetails()
        {
            return this._ecsClusterDetails != null;
        }

        /// <summary>
        /// Gets and sets the property EksClusterDetails. 
        /// <para>
        /// Details about the EKS cluster involved in a Kubernetes finding.
        /// </para>
        /// </summary>
        public EksClusterDetails EksClusterDetails
        {
            get { return this._eksClusterDetails; }
            set { this._eksClusterDetails = value; }
        }

        // Check to see if EksClusterDetails property is set
        internal bool IsSetEksClusterDetails()
        {
            return this._eksClusterDetails != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceDetails. 
        /// <para>
        /// The information about the EC2 instance associated with the activity that prompted
        /// GuardDuty to generate a finding.
        /// </para>
        /// </summary>
        public InstanceDetails InstanceDetails
        {
            get { return this._instanceDetails; }
            set { this._instanceDetails = value; }
        }

        // Check to see if InstanceDetails property is set
        internal bool IsSetInstanceDetails()
        {
            return this._instanceDetails != null;
        }

        /// <summary>
        /// Gets and sets the property KubernetesDetails. 
        /// <para>
        /// Details about the Kubernetes user and workload involved in a Kubernetes finding.
        /// </para>
        /// </summary>
        public KubernetesDetails KubernetesDetails
        {
            get { return this._kubernetesDetails; }
            set { this._kubernetesDetails = value; }
        }

        // Check to see if KubernetesDetails property is set
        internal bool IsSetKubernetesDetails()
        {
            return this._kubernetesDetails != null;
        }

        /// <summary>
        /// Gets and sets the property RdsDbInstanceDetails. 
        /// <para>
        /// Contains information about the database instance to which an anomalous login attempt
        /// was made.
        /// </para>
        /// </summary>
        public RdsDbInstanceDetails RdsDbInstanceDetails
        {
            get { return this._rdsDbInstanceDetails; }
            set { this._rdsDbInstanceDetails = value; }
        }

        // Check to see if RdsDbInstanceDetails property is set
        internal bool IsSetRdsDbInstanceDetails()
        {
            return this._rdsDbInstanceDetails != null;
        }

        /// <summary>
        /// Gets and sets the property RdsDbUserDetails. 
        /// <para>
        /// Contains information about the user details through which anomalous login attempt
        /// was made.
        /// </para>
        /// </summary>
        public RdsDbUserDetails RdsDbUserDetails
        {
            get { return this._rdsDbUserDetails; }
            set { this._rdsDbUserDetails = value; }
        }

        // Check to see if RdsDbUserDetails property is set
        internal bool IsSetRdsDbUserDetails()
        {
            return this._rdsDbUserDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of Amazon Web Services resource.
        /// </para>
        /// </summary>
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property S3BucketDetails. 
        /// <para>
        /// Contains information on the S3 bucket.
        /// </para>
        /// </summary>
        public List<S3BucketDetail> S3BucketDetails
        {
            get { return this._s3BucketDetails; }
            set { this._s3BucketDetails = value; }
        }

        // Check to see if S3BucketDetails property is set
        internal bool IsSetS3BucketDetails()
        {
            return this._s3BucketDetails != null && this._s3BucketDetails.Count > 0; 
        }

    }
}