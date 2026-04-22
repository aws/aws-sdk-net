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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
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
namespace Amazon.Batch.Model
{
    /// <summary>
    /// Provides information used to select Amazon Machine Images (AMIs) for instances in
    /// the compute environment. If <c>Ec2Configuration</c> isn't specified, the default is
    /// <c>ECS_AL2023</c> (<a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-optimized_AMI.html">Amazon
    /// ECS-optimized Amazon Linux 2023</a>) for EC2 (ECS) compute environments and <c>EKS_AL2023</c>
    /// (<a href="https://docs.aws.amazon.com/eks/latest/userguide/eks-optimized-ami.html">Amazon
    /// EKS-optimized Amazon Linux 2023 AMI</a>) for EKS compute environments.
    /// 
    ///  <note> 
    /// <para>
    /// This object isn't applicable to jobs that are running on Fargate resources.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class Ec2Configuration
    {
        private string _batchImageStatus;
        private string _imageIdOverride;
        private string _imageKubernetesVersion;
        private string _imageType;

        /// <summary>
        /// Gets and sets the property BatchImageStatus. 
        /// <para>
        /// The status of the Batch-provided default AMIs associated with the <c>imageType</c>.
        /// </para>
        ///  
        /// <para>
        /// The field only appears after the compute environment has begun scaling instances using
        /// the <c>imageType</c>. The field is not present when an image is specified in <c>ComputeResources.imageId</c>
        /// (deprecated), the default launch template, or <c>Ec2Configuration.imageIdOverride</c>.
        /// The field is also not present when the compute environment has a launch template override.
        /// For more information on image selection, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/ami-selection-order.html">AMI
        /// selection order</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This field is read-only and only appears in the <a href="https://docs.aws.amazon.com/batch/latest/APIReference/API_DescribeComputeEnvironments.html">DescribeComputeEnvironments</a>
        /// response.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        ///  <c>LATEST</c> − Using the most recent AMI supported
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATE_AVAILABLE</c> − An updated AMI is available
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If a compute environment has multiple AMIs for the <c>imageType</c> and any one AMI
        /// has <c>UPDATE_AVAILABLE</c>, the status shows <c>UPDATE_AVAILABLE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For compute environments that use <c>BEST_FIT</c> as their allocation strategy, you
        /// can perform a <a href="https://docs.aws.amazon.com/batch/latest/userguide/blue-green-updates.html">blue/green
        /// update</a> to update the AMI.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For all other compute environments, you can perform an <a href="https://docs.aws.amazon.com/batch/latest/userguide/managing-ami-versions.html#updating-ami-versions">AMI
        /// version update</a> to update the AMI to the latest version.
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        public string BatchImageStatus
        {
            get { return this._batchImageStatus; }
            set { this._batchImageStatus = value; }
        }

        // Check to see if BatchImageStatus property is set
        internal bool IsSetBatchImageStatus()
        {
            return this._batchImageStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ImageIdOverride. 
        /// <para>
        /// The AMI ID used for instances launched in the compute environment that match the image
        /// type. This setting overrides the <c>imageId</c> set in the <c>computeResource</c>
        /// object.
        /// </para>
        ///  <note> 
        /// <para>
        /// The AMI that you choose for a compute environment must match the architecture of the
        /// instance types that you intend to use for that compute environment. For example, if
        /// your compute environment uses A1 instance types, the compute resource AMI that you
        /// choose must support ARM instances. Amazon ECS vends both x86 and ARM versions of the
        /// Amazon ECS-optimized Amazon Linux 2023 AMI. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-optimized_AMI.html#ecs-optimized-ami-linux-variants.html">Amazon
        /// ECS-optimized Amazon Linux 2023 AMI</a> in the <i>Amazon Elastic Container Service
        /// Developer Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ImageIdOverride
        {
            get { return this._imageIdOverride; }
            set { this._imageIdOverride = value; }
        }

        // Check to see if ImageIdOverride property is set
        internal bool IsSetImageIdOverride()
        {
            return this._imageIdOverride != null;
        }

        /// <summary>
        /// Gets and sets the property ImageKubernetesVersion. 
        /// <para>
        /// The Kubernetes version for the compute environment. If you don't specify a value,
        /// the latest version that Batch supports is used.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ImageKubernetesVersion
        {
            get { return this._imageKubernetesVersion; }
            set { this._imageKubernetesVersion = value; }
        }

        // Check to see if ImageKubernetesVersion property is set
        internal bool IsSetImageKubernetesVersion()
        {
            return this._imageKubernetesVersion != null;
        }

        /// <summary>
        /// Gets and sets the property ImageType. 
        /// <para>
        /// The image type to match with the instance type to select an AMI. The supported values
        /// are different for <c>ECS</c> and <c>EKS</c> resources.
        /// </para>
        ///  <dl> <dt>ECS</dt> <dd> 
        /// <para>
        /// If the <c>imageIdOverride</c> parameter isn't specified, then a recent <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-optimized_AMI.html">Amazon
        /// ECS-optimized Amazon Linux 2023 AMI</a> (<c>ECS_AL2023</c>) is used. If a new image
        /// type is specified in an update, but neither an <c>imageId</c> nor a <c>imageIdOverride</c>
        /// parameter is specified, then the latest Amazon ECS optimized AMI for that image type
        /// that's supported by Batch is used.
        /// </para>
        ///  <important> 
        /// <para>
        /// Amazon Web Services is ending support for Amazon ECS Amazon Linux 2-optimized and
        /// accelerated AMIs on June 30, 2026. On January 12, 2026, Batch changed the default
        /// AMI for new Amazon ECS compute environments from Amazon Linux 2 to Amazon Linux 2023.
        /// Effective June 30, 2026, Batch will block creation of new Amazon ECS compute environments
        /// using Batch-provided Amazon Linux 2 AMIs. We strongly recommend migrating your existing
        /// Batch Amazon ECS compute environments to Amazon Linux 2023 prior to June 30, 2026.
        /// For more information on upgrading from AL2 to AL2023, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/ecs-migration-2023.html">How
        /// to migrate from ECS AL2 to ECS AL2023</a> in the <i>Batch User Guide</i>.
        /// </para>
        ///  </important> <dl> <dt>ECS_AL2</dt> <dd> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-optimized_AMI.html">Amazon
        /// Linux 2</a>: Used for non-GPU instance families.
        /// </para>
        ///  </dd> <dt>ECS_AL2_NVIDIA</dt> <dd> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-optimized_AMI.html#gpuami">Amazon
        /// Linux 2 (GPU)</a>: Used for GPU instance families (for example <c>P4</c> and <c>G4</c>)
        /// and non Amazon Web Services Graviton-based instance types.
        /// </para>
        ///  </dd> <dt>ECS_AL2023</dt> <dd> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-optimized_AMI.html">Amazon
        /// Linux 2023</a>: Default for all non-GPU instance families.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Linux 2023 does not support <c>A1</c> instances.
        /// </para>
        ///  </note> </dd> <dt>ECS_AL2023_NVIDIA</dt> <dd> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-optimized_AMI.html#gpuami">Amazon
        /// Linux 2023 (GPU)</a>: Default for all GPU instance families and can be used for all
        /// non Amazon Web Services Graviton-based instance types.
        /// </para>
        ///  <note> 
        /// <para>
        /// ECS_AL2023_NVIDIA doesn't support <c>p3</c> and <c>g3</c> instance types.
        /// </para>
        ///  </note> </dd> </dl> </dd> <dt>EKS</dt> <dd> 
        /// <para>
        /// If the <c>imageIdOverride</c> parameter isn't specified, then a recent <a href="https://docs.aws.amazon.com/eks/latest/userguide/eks-optimized-ami.html">Amazon
        /// EKS-optimized Amazon Linux 2023 AMI</a> (<c>EKS_AL2023</c>) is used. If a new image
        /// type is specified in an update, but neither an <c>imageId</c> nor a <c>imageIdOverride</c>
        /// parameter is specified, then the latest Amazon EKS optimized AMI for that image type
        /// that Batch supports is used.
        /// </para>
        ///  <important> 
        /// <para>
        /// Amazon Linux 2023 AMIs are the default on Batch for Amazon EKS.
        /// </para>
        ///  
        /// <para>
        /// Amazon Web Services ended support for Amazon EKS AL2-optimized and AL2-accelerated
        /// AMIs on November 26, 2025. Batch Amazon EKS compute environments using Amazon Linux
        /// 2 will no longer receive software updates, security patches, or bug fixes from Amazon
        /// Web Services. We recommend migrating to Amazon Linux 2023. For more information on
        /// upgrading from AL2 to AL2023, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/eks-migration-2023.html">How
        /// to upgrade from EKS AL2 to EKS AL2023</a> in the <i>Batch User Guide</i>.
        /// </para>
        ///  </important> <dl> <dt>EKS_AL2</dt> <dd> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/eks/latest/userguide/eks-optimized-ami.html">Amazon
        /// Linux 2</a>: Used for non-GPU instance families.
        /// </para>
        ///  </dd> <dt>EKS_AL2_NVIDIA</dt> <dd> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/eks/latest/userguide/eks-optimized-ami.html">Amazon
        /// Linux 2 (accelerated)</a>: Used for GPU instance families (for example, <c>P4</c>
        /// and <c>G4</c>) and can be used for all non Amazon Web Services Graviton-based instance
        /// types.
        /// </para>
        ///  </dd> <dt>EKS_AL2023</dt> <dd> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/eks/latest/userguide/eks-optimized-ami.html">Amazon
        /// Linux 2023</a>: Default for non-GPU instance families.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Linux 2023 does not support <c>A1</c> instances.
        /// </para>
        ///  </note> </dd> <dt>EKS_AL2023_NVIDIA</dt> <dd> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/eks/latest/userguide/eks-optimized-ami.html">Amazon
        /// Linux 2023 (accelerated)</a>: Default for GPU instance families and can be used for
        /// all non Amazon Web Services Graviton-based instance types.
        /// </para>
        ///  </dd> </dl> </dd> </dl>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ImageType
        {
            get { return this._imageType; }
            set { this._imageType = value; }
        }

        // Check to see if ImageType property is set
        internal bool IsSetImageType()
        {
            return this._imageType != null;
        }

    }
}