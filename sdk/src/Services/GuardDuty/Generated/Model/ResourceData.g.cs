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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about the Amazon Web Services resource that is associated with
    /// the activity that prompted GuardDuty to generate a finding.
    /// </summary>
    public partial class ResourceData
    {
        /// <summary>
        /// Gets and sets the property AccessKey. 
        /// <para>
        /// Contains information about the IAM access key details of a user that involved in the
        /// GuardDuty finding.
        /// </para>
        /// </summary>
        public AccessKey AccessKey { get; set; }

        /// <summary>
        /// Checks to see if the AccessKey property is set.
        /// </summary>
        internal bool IsSetAccessKey() => this.AccessKey != null;

        /// <summary>
        /// Gets and sets the property AutoscalingAutoScalingGroup. 
        /// <para>
        /// Contains detailed information about the Auto Scaling Group associated with the activity
        /// that prompted GuardDuty to generate a finding.
        /// </para>
        /// </summary>
        public AutoscalingAutoScalingGroup AutoscalingAutoScalingGroup { get; set; }

        /// <summary>
        /// Checks to see if the AutoscalingAutoScalingGroup property is set.
        /// </summary>
        internal bool IsSetAutoscalingAutoScalingGroup() => this.AutoscalingAutoScalingGroup != null;

        /// <summary>
        /// Gets and sets the property BedrockGuardrail. 
        /// <para>
        /// Contains detailed information about the Amazon Bedrock guardrail associated with the
        /// activity that prompted GuardDuty to generate a finding.
        /// </para>
        /// </summary>
        public BedrockGuardrailResource BedrockGuardrail { get; set; }

        /// <summary>
        /// Checks to see if the BedrockGuardrail property is set.
        /// </summary>
        internal bool IsSetBedrockGuardrail() => this.BedrockGuardrail != null;

        /// <summary>
        /// Gets and sets the property CloudformationStack. 
        /// <para>
        /// Contains detailed information about the CloudFormation stack associated with the activity
        /// that prompted GuardDuty to generate a finding.
        /// </para>
        /// </summary>
        public CloudformationStack CloudformationStack { get; set; }

        /// <summary>
        /// Checks to see if the CloudformationStack property is set.
        /// </summary>
        internal bool IsSetCloudformationStack() => this.CloudformationStack != null;

        /// <summary>
        /// Gets and sets the property Container. 
        /// <para>
        /// Contains detailed information about the container associated with the activity that
        /// prompted GuardDuty to generate a finding.
        /// </para>
        /// </summary>
        public ContainerFindingResource Container { get; set; }

        /// <summary>
        /// Checks to see if the Container property is set.
        /// </summary>
        internal bool IsSetContainer() => this.Container != null;

        /// <summary>
        /// Gets and sets the property Ec2Image. 
        /// <para>
        /// Contains detailed information about the EC2 Image associated with the activity that
        /// prompted GuardDuty to generate a finding.
        /// </para>
        /// </summary>
        public Ec2Image Ec2Image { get; set; }

        /// <summary>
        /// Checks to see if the Ec2Image property is set.
        /// </summary>
        internal bool IsSetEc2Image() => this.Ec2Image != null;

        /// <summary>
        /// Gets and sets the property Ec2Instance. 
        /// <para>
        /// Contains information about the Amazon EC2 instance.
        /// </para>
        /// </summary>
        public Ec2Instance Ec2Instance { get; set; }

        /// <summary>
        /// Checks to see if the Ec2Instance property is set.
        /// </summary>
        internal bool IsSetEc2Instance() => this.Ec2Instance != null;

        /// <summary>
        /// Gets and sets the property Ec2LaunchTemplate. 
        /// <para>
        /// Contains detailed information about the EC2 launch template associated with the activity
        /// that prompted GuardDuty to generate a finding.
        /// </para>
        /// </summary>
        public Ec2LaunchTemplate Ec2LaunchTemplate { get; set; }

        /// <summary>
        /// Checks to see if the Ec2LaunchTemplate property is set.
        /// </summary>
        internal bool IsSetEc2LaunchTemplate() => this.Ec2LaunchTemplate != null;

        /// <summary>
        /// Gets and sets the property Ec2NetworkInterface. 
        /// <para>
        /// Contains information about the elastic network interface of the Amazon EC2 instance.
        /// </para>
        /// </summary>
        public Ec2NetworkInterface Ec2NetworkInterface { get; set; }

        /// <summary>
        /// Checks to see if the Ec2NetworkInterface property is set.
        /// </summary>
        internal bool IsSetEc2NetworkInterface() => this.Ec2NetworkInterface != null;

        /// <summary>
        /// Gets and sets the property Ec2Vpc. 
        /// <para>
        /// Contains detailed information about the EC2 VPC associated with the activity that
        /// prompted GuardDuty to generate a finding.
        /// </para>
        /// </summary>
        public Ec2Vpc Ec2Vpc { get; set; }

        /// <summary>
        /// Checks to see if the Ec2Vpc property is set.
        /// </summary>
        internal bool IsSetEc2Vpc() => this.Ec2Vpc != null;

        /// <summary>
        /// Gets and sets the property EcsCluster. 
        /// <para>
        /// Contains detailed information about the Amazon ECS cluster associated with the activity
        /// that prompted GuardDuty to generate a finding.
        /// </para>
        /// </summary>
        public EcsCluster EcsCluster { get; set; }

        /// <summary>
        /// Checks to see if the EcsCluster property is set.
        /// </summary>
        internal bool IsSetEcsCluster() => this.EcsCluster != null;

        /// <summary>
        /// Gets and sets the property EcsTask. 
        /// <para>
        /// Contains detailed information about the Amazon ECS task associated with the activity
        /// that prompted GuardDuty to generate a finding.
        /// </para>
        /// </summary>
        public EcsTask EcsTask { get; set; }

        /// <summary>
        /// Checks to see if the EcsTask property is set.
        /// </summary>
        internal bool IsSetEcsTask() => this.EcsTask != null;

        /// <summary>
        /// Gets and sets the property EksCluster. 
        /// <para>
        /// Contains detailed information about the Amazon EKS cluster associated with the activity
        /// that prompted GuardDuty to generate a finding.
        /// </para>
        /// </summary>
        public EksCluster EksCluster { get; set; }

        /// <summary>
        /// Checks to see if the EksCluster property is set.
        /// </summary>
        internal bool IsSetEksCluster() => this.EksCluster != null;

        /// <summary>
        /// Gets and sets the property IamInstanceProfile. 
        /// <para>
        /// Contains detailed information about the IAM instance profile associated with the activity
        /// that prompted GuardDuty to generate a finding.
        /// </para>
        /// </summary>
        public IamInstanceProfileV2 IamInstanceProfile { get; set; }

        /// <summary>
        /// Checks to see if the IamInstanceProfile property is set.
        /// </summary>
        internal bool IsSetIamInstanceProfile() => this.IamInstanceProfile != null;

        /// <summary>
        /// Gets and sets the property KubernetesWorkload. 
        /// <para>
        /// Contains detailed information about the Kubernetes workload associated with the activity
        /// that prompted GuardDuty to generate a finding.
        /// </para>
        /// </summary>
        public KubernetesWorkload KubernetesWorkload { get; set; }

        /// <summary>
        /// Checks to see if the KubernetesWorkload property is set.
        /// </summary>
        internal bool IsSetKubernetesWorkload() => this.KubernetesWorkload != null;

        /// <summary>
        /// Gets and sets the property S3Bucket. 
        /// <para>
        /// Contains information about the Amazon S3 bucket.
        /// </para>
        /// </summary>
        public S3Bucket S3Bucket { get; set; }

        /// <summary>
        /// Checks to see if the S3Bucket property is set.
        /// </summary>
        internal bool IsSetS3Bucket() => this.S3Bucket != null;

        /// <summary>
        /// Gets and sets the property S3Object. 
        /// <para>
        /// Contains information about the Amazon S3 object.
        /// </para>
        /// </summary>
        public S3Object S3Object { get; set; }

        /// <summary>
        /// Checks to see if the S3Object property is set.
        /// </summary>
        internal bool IsSetS3Object() => this.S3Object != null;
    }
}
