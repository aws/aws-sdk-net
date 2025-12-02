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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about the Amazon Web Services resource that is associated with
    /// the activity that prompted GuardDuty to generate a finding.
    /// </summary>
    public partial class ResourceData
    {
        private AccessKey _accessKey;
        private AutoscalingAutoScalingGroup _autoscalingAutoScalingGroup;
        private CloudformationStack _cloudformationStack;
        private ContainerFindingResource _container;
        private Ec2Image _ec2Image;
        private Ec2Instance _ec2Instance;
        private Ec2LaunchTemplate _ec2LaunchTemplate;
        private Ec2NetworkInterface _ec2NetworkInterface;
        private Ec2Vpc _ec2Vpc;
        private EcsCluster _ecsCluster;
        private EcsTask _ecsTask;
        private EksCluster _eksCluster;
        private IamInstanceProfileV2 _iamInstanceProfile;
        private KubernetesWorkload _kubernetesWorkload;
        private S3Bucket _s3Bucket;
        private S3Object _s3Object;

        /// <summary>
        /// Gets and sets the property AccessKey. 
        /// <para>
        /// Contains information about the IAM access key details of a user that involved in the
        /// GuardDuty finding.
        /// </para>
        /// </summary>
        public AccessKey AccessKey
        {
            get { return this._accessKey; }
            set { this._accessKey = value; }
        }

        // Check to see if AccessKey property is set
        internal bool IsSetAccessKey()
        {
            return this._accessKey != null;
        }

        /// <summary>
        /// Gets and sets the property AutoscalingAutoScalingGroup. 
        /// <para>
        /// Contains detailed information about the Auto Scaling Group associated with the activity
        /// that prompted GuardDuty to generate a finding.
        /// </para>
        /// </summary>
        public AutoscalingAutoScalingGroup AutoscalingAutoScalingGroup
        {
            get { return this._autoscalingAutoScalingGroup; }
            set { this._autoscalingAutoScalingGroup = value; }
        }

        // Check to see if AutoscalingAutoScalingGroup property is set
        internal bool IsSetAutoscalingAutoScalingGroup()
        {
            return this._autoscalingAutoScalingGroup != null;
        }

        /// <summary>
        /// Gets and sets the property CloudformationStack. 
        /// <para>
        /// Contains detailed information about the CloudFormation stack associated with the activity
        /// that prompted GuardDuty to generate a finding.
        /// </para>
        /// </summary>
        public CloudformationStack CloudformationStack
        {
            get { return this._cloudformationStack; }
            set { this._cloudformationStack = value; }
        }

        // Check to see if CloudformationStack property is set
        internal bool IsSetCloudformationStack()
        {
            return this._cloudformationStack != null;
        }

        /// <summary>
        /// Gets and sets the property Container. 
        /// <para>
        /// Contains detailed information about the container associated with the activity that
        /// prompted GuardDuty to generate a finding.
        /// </para>
        /// </summary>
        public ContainerFindingResource Container
        {
            get { return this._container; }
            set { this._container = value; }
        }

        // Check to see if Container property is set
        internal bool IsSetContainer()
        {
            return this._container != null;
        }

        /// <summary>
        /// Gets and sets the property Ec2Image. 
        /// <para>
        /// Contains detailed information about the EC2 Image associated with the activity that
        /// prompted GuardDuty to generate a finding.
        /// </para>
        /// </summary>
        public Ec2Image Ec2Image
        {
            get { return this._ec2Image; }
            set { this._ec2Image = value; }
        }

        // Check to see if Ec2Image property is set
        internal bool IsSetEc2Image()
        {
            return this._ec2Image != null;
        }

        /// <summary>
        /// Gets and sets the property Ec2Instance. 
        /// <para>
        /// Contains information about the Amazon EC2 instance.
        /// </para>
        /// </summary>
        public Ec2Instance Ec2Instance
        {
            get { return this._ec2Instance; }
            set { this._ec2Instance = value; }
        }

        // Check to see if Ec2Instance property is set
        internal bool IsSetEc2Instance()
        {
            return this._ec2Instance != null;
        }

        /// <summary>
        /// Gets and sets the property Ec2LaunchTemplate. 
        /// <para>
        /// Contains detailed information about the EC2 launch template associated with the activity
        /// that prompted GuardDuty to generate a finding.
        /// </para>
        /// </summary>
        public Ec2LaunchTemplate Ec2LaunchTemplate
        {
            get { return this._ec2LaunchTemplate; }
            set { this._ec2LaunchTemplate = value; }
        }

        // Check to see if Ec2LaunchTemplate property is set
        internal bool IsSetEc2LaunchTemplate()
        {
            return this._ec2LaunchTemplate != null;
        }

        /// <summary>
        /// Gets and sets the property Ec2NetworkInterface. 
        /// <para>
        /// Contains information about the elastic network interface of the Amazon EC2 instance.
        /// </para>
        /// </summary>
        public Ec2NetworkInterface Ec2NetworkInterface
        {
            get { return this._ec2NetworkInterface; }
            set { this._ec2NetworkInterface = value; }
        }

        // Check to see if Ec2NetworkInterface property is set
        internal bool IsSetEc2NetworkInterface()
        {
            return this._ec2NetworkInterface != null;
        }

        /// <summary>
        /// Gets and sets the property Ec2Vpc. 
        /// <para>
        /// Contains detailed information about the EC2 VPC associated with the activity that
        /// prompted GuardDuty to generate a finding.
        /// </para>
        /// </summary>
        public Ec2Vpc Ec2Vpc
        {
            get { return this._ec2Vpc; }
            set { this._ec2Vpc = value; }
        }

        // Check to see if Ec2Vpc property is set
        internal bool IsSetEc2Vpc()
        {
            return this._ec2Vpc != null;
        }

        /// <summary>
        /// Gets and sets the property EcsCluster. 
        /// <para>
        /// Contains detailed information about the Amazon ECS cluster associated with the activity
        /// that prompted GuardDuty to generate a finding.
        /// </para>
        /// </summary>
        public EcsCluster EcsCluster
        {
            get { return this._ecsCluster; }
            set { this._ecsCluster = value; }
        }

        // Check to see if EcsCluster property is set
        internal bool IsSetEcsCluster()
        {
            return this._ecsCluster != null;
        }

        /// <summary>
        /// Gets and sets the property EcsTask. 
        /// <para>
        /// Contains detailed information about the Amazon ECS task associated with the activity
        /// that prompted GuardDuty to generate a finding.
        /// </para>
        /// </summary>
        public EcsTask EcsTask
        {
            get { return this._ecsTask; }
            set { this._ecsTask = value; }
        }

        // Check to see if EcsTask property is set
        internal bool IsSetEcsTask()
        {
            return this._ecsTask != null;
        }

        /// <summary>
        /// Gets and sets the property EksCluster. 
        /// <para>
        /// Contains detailed information about the Amazon EKS cluster associated with the activity
        /// that prompted GuardDuty to generate a finding.
        /// </para>
        /// </summary>
        public EksCluster EksCluster
        {
            get { return this._eksCluster; }
            set { this._eksCluster = value; }
        }

        // Check to see if EksCluster property is set
        internal bool IsSetEksCluster()
        {
            return this._eksCluster != null;
        }

        /// <summary>
        /// Gets and sets the property IamInstanceProfile. 
        /// <para>
        /// Contains detailed information about the IAM instance profile associated with the activity
        /// that prompted GuardDuty to generate a finding.
        /// </para>
        /// </summary>
        public IamInstanceProfileV2 IamInstanceProfile
        {
            get { return this._iamInstanceProfile; }
            set { this._iamInstanceProfile = value; }
        }

        // Check to see if IamInstanceProfile property is set
        internal bool IsSetIamInstanceProfile()
        {
            return this._iamInstanceProfile != null;
        }

        /// <summary>
        /// Gets and sets the property KubernetesWorkload. 
        /// <para>
        /// Contains detailed information about the Kubernetes workload associated with the activity
        /// that prompted GuardDuty to generate a finding.
        /// </para>
        /// </summary>
        public KubernetesWorkload KubernetesWorkload
        {
            get { return this._kubernetesWorkload; }
            set { this._kubernetesWorkload = value; }
        }

        // Check to see if KubernetesWorkload property is set
        internal bool IsSetKubernetesWorkload()
        {
            return this._kubernetesWorkload != null;
        }

        /// <summary>
        /// Gets and sets the property S3Bucket. 
        /// <para>
        /// Contains information about the Amazon S3 bucket.
        /// </para>
        /// </summary>
        public S3Bucket S3Bucket
        {
            get { return this._s3Bucket; }
            set { this._s3Bucket = value; }
        }

        // Check to see if S3Bucket property is set
        internal bool IsSetS3Bucket()
        {
            return this._s3Bucket != null;
        }

        /// <summary>
        /// Gets and sets the property S3Object. 
        /// <para>
        /// Contains information about the Amazon S3 object.
        /// </para>
        /// </summary>
        public S3Object S3Object
        {
            get { return this._s3Object; }
            set { this._s3Object = value; }
        }

        // Check to see if S3Object property is set
        internal bool IsSetS3Object()
        {
            return this._s3Object != null;
        }

    }
}