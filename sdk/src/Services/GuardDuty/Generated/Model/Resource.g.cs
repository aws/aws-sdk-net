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
    /// Contains information about the Amazon Web Services resource associated with the activity
    /// that prompted GuardDuty to generate a finding.
    /// </summary>
    public partial class Resource
    {
        /// <summary>
        /// Gets and sets the property AccessKeyDetails. 
        /// <para>
        /// The IAM access key details (user information) of a user that engaged in the activity
        /// that prompted GuardDuty to generate a finding.
        /// </para>
        /// </summary>
        public AccessKeyDetails AccessKeyDetails { get; set; }

        /// <summary>
        /// Checks to see if the AccessKeyDetails property is set.
        /// </summary>
        internal bool IsSetAccessKeyDetails() => this.AccessKeyDetails != null;

        /// <summary>
        /// Gets and sets the property BedrockGuardrailDetails. 
        /// <para>
        /// Contains information about the Bedrock guardrail that was involved in a finding.
        /// </para>
        /// </summary>
        public BedrockGuardrailDetails BedrockGuardrailDetails { get; set; }

        /// <summary>
        /// Checks to see if the BedrockGuardrailDetails property is set.
        /// </summary>
        internal bool IsSetBedrockGuardrailDetails() => this.BedrockGuardrailDetails != null;

        /// <summary>
        /// Gets and sets the property ContainerDetails.
        /// </summary>
        public Container ContainerDetails { get; set; }

        /// <summary>
        /// Checks to see if the ContainerDetails property is set.
        /// </summary>
        internal bool IsSetContainerDetails() => this.ContainerDetails != null;

        /// <summary>
        /// Gets and sets the property EbsSnapshotDetails. 
        /// <para>
        /// Contains details about the EBS snapshot that was scanned.
        /// </para>
        /// </summary>
        public EbsSnapshotDetails EbsSnapshotDetails { get; set; }

        /// <summary>
        /// Checks to see if the EbsSnapshotDetails property is set.
        /// </summary>
        internal bool IsSetEbsSnapshotDetails() => this.EbsSnapshotDetails != null;

        /// <summary>
        /// Gets and sets the property EbsVolumeDetails. 
        /// <para>
        /// Contains list of scanned and skipped EBS volumes with details.
        /// </para>
        /// </summary>
        public EbsVolumeDetails EbsVolumeDetails { get; set; }

        /// <summary>
        /// Checks to see if the EbsVolumeDetails property is set.
        /// </summary>
        internal bool IsSetEbsVolumeDetails() => this.EbsVolumeDetails != null;

        /// <summary>
        /// Gets and sets the property Ec2ImageDetails. 
        /// <para>
        /// Contains details about the EC2 image that was scanned.
        /// </para>
        /// </summary>
        public Ec2ImageDetails Ec2ImageDetails { get; set; }

        /// <summary>
        /// Checks to see if the Ec2ImageDetails property is set.
        /// </summary>
        internal bool IsSetEc2ImageDetails() => this.Ec2ImageDetails != null;

        /// <summary>
        /// Gets and sets the property EcsClusterDetails. 
        /// <para>
        /// Contains information about the details of the ECS Cluster.
        /// </para>
        /// </summary>
        public EcsClusterDetails EcsClusterDetails { get; set; }

        /// <summary>
        /// Checks to see if the EcsClusterDetails property is set.
        /// </summary>
        internal bool IsSetEcsClusterDetails() => this.EcsClusterDetails != null;

        /// <summary>
        /// Gets and sets the property EksClusterDetails. 
        /// <para>
        /// Details about the EKS cluster involved in a Kubernetes finding.
        /// </para>
        /// </summary>
        public EksClusterDetails EksClusterDetails { get; set; }

        /// <summary>
        /// Checks to see if the EksClusterDetails property is set.
        /// </summary>
        internal bool IsSetEksClusterDetails() => this.EksClusterDetails != null;

        /// <summary>
        /// Gets and sets the property InstanceDetails. 
        /// <para>
        /// The information about the EC2 instance associated with the activity that prompted
        /// GuardDuty to generate a finding.
        /// </para>
        /// </summary>
        public InstanceDetails InstanceDetails { get; set; }

        /// <summary>
        /// Checks to see if the InstanceDetails property is set.
        /// </summary>
        internal bool IsSetInstanceDetails() => this.InstanceDetails != null;

        /// <summary>
        /// Gets and sets the property KubernetesDetails. 
        /// <para>
        /// Details about the Kubernetes user and workload involved in a Kubernetes finding.
        /// </para>
        /// </summary>
        public KubernetesDetails KubernetesDetails { get; set; }

        /// <summary>
        /// Checks to see if the KubernetesDetails property is set.
        /// </summary>
        internal bool IsSetKubernetesDetails() => this.KubernetesDetails != null;

        /// <summary>
        /// Gets and sets the property LambdaDetails. 
        /// <para>
        /// Contains information about the Lambda function that was involved in a finding.
        /// </para>
        /// </summary>
        public LambdaDetails LambdaDetails { get; set; }

        /// <summary>
        /// Checks to see if the LambdaDetails property is set.
        /// </summary>
        internal bool IsSetLambdaDetails() => this.LambdaDetails != null;

        /// <summary>
        /// Gets and sets the property ModelDetails. 
        /// <para>
        /// Contains information about the AI models involved in a finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ModelDetail> ModelDetails { get; set; } = AWSConfigs.InitializeCollections ? new List<ModelDetail>() : null;

        /// <summary>
        /// Checks to see if the ModelDetails property is set.
        /// </summary>
        internal bool IsSetModelDetails() => this.ModelDetails != null && (this.ModelDetails.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RdsDbInstanceDetails. 
        /// <para>
        /// Contains information about the database instance to which an anomalous login attempt
        /// was made.
        /// </para>
        /// </summary>
        public RdsDbInstanceDetails RdsDbInstanceDetails { get; set; }

        /// <summary>
        /// Checks to see if the RdsDbInstanceDetails property is set.
        /// </summary>
        internal bool IsSetRdsDbInstanceDetails() => this.RdsDbInstanceDetails != null;

        /// <summary>
        /// Gets and sets the property RdsDbUserDetails. 
        /// <para>
        /// Contains information about the user details through which anomalous login attempt
        /// was made.
        /// </para>
        /// </summary>
        public RdsDbUserDetails RdsDbUserDetails { get; set; }

        /// <summary>
        /// Checks to see if the RdsDbUserDetails property is set.
        /// </summary>
        internal bool IsSetRdsDbUserDetails() => this.RdsDbUserDetails != null;

        /// <summary>
        /// Gets and sets the property RdsLimitlessDbDetails. 
        /// <para>
        /// Contains information about the RDS Limitless database that was involved in a GuardDuty
        /// finding.
        /// </para>
        /// </summary>
        public RdsLimitlessDbDetails RdsLimitlessDbDetails { get; set; }

        /// <summary>
        /// Checks to see if the RdsLimitlessDbDetails property is set.
        /// </summary>
        internal bool IsSetRdsLimitlessDbDetails() => this.RdsLimitlessDbDetails != null;

        /// <summary>
        /// Gets and sets the property RecoveryPointDetails. 
        /// <para>
        /// Contains details about the backup recovery point that was scanned.
        /// </para>
        /// </summary>
        public RecoveryPointDetails RecoveryPointDetails { get; set; }

        /// <summary>
        /// Checks to see if the RecoveryPointDetails property is set.
        /// </summary>
        internal bool IsSetRecoveryPointDetails() => this.RecoveryPointDetails != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of Amazon Web Services resource.
        /// </para>
        /// </summary>
        public string ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property S3BucketDetails. 
        /// <para>
        /// Contains information on the S3 bucket.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<S3BucketDetail> S3BucketDetails { get; set; } = AWSConfigs.InitializeCollections ? new List<S3BucketDetail>() : null;

        /// <summary>
        /// Checks to see if the S3BucketDetails property is set.
        /// </summary>
        internal bool IsSetS3BucketDetails() => this.S3BucketDetails != null && (this.S3BucketDetails.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
