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

namespace Amazon.Batch.Model
{
    /// <summary>
    /// Provides information used to select Amazon Machine Images (AMIs) for instances in
    /// the compute environment. If <code>Ec2Configuration</code> isn't specified, the default
    /// is <code>ECS_AL2</code> (<a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-optimized_AMI.html#al2ami">Amazon
    /// Linux 2</a>).
    /// 
    ///  <note> 
    /// <para>
    /// This object isn't applicable to jobs that are running on Fargate resources.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class Ec2Configuration
    {
        private string _imageIdOverride;
        private string _imageKubernetesVersion;
        private string _imageType;

        /// <summary>
        /// Gets and sets the property ImageIdOverride. 
        /// <para>
        /// The AMI ID used for instances launched in the compute environment that match the image
        /// type. This setting overrides the <code>imageId</code> set in the <code>computeResource</code>
        /// object.
        /// </para>
        ///  <note> 
        /// <para>
        /// The AMI that you choose for a compute environment must match the architecture of the
        /// instance types that you intend to use for that compute environment. For example, if
        /// your compute environment uses A1 instance types, the compute resource AMI that you
        /// choose must support ARM instances. Amazon ECS vends both x86 and ARM versions of the
        /// Amazon ECS-optimized Amazon Linux 2 AMI. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-optimized_AMI.html#ecs-optimized-ami-linux-variants.html">Amazon
        /// ECS-optimized Amazon Linux 2 AMI</a> in the <i>Amazon Elastic Container Service Developer
        /// Guide</i>.
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
        /// are different for <code>ECS</code> and <code>EKS</code> resources.
        /// </para>
        ///  <dl> <dt>ECS</dt> <dd> 
        /// <para>
        /// If the <code>imageIdOverride</code> parameter isn't specified, then a recent <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-optimized_AMI.html#al2ami">Amazon
        /// ECS-optimized Amazon Linux 2 AMI</a> (<code>ECS_AL2</code>) is used. If a new image
        /// type is specified in an update, but neither an <code>imageId</code> nor a <code>imageIdOverride</code>
        /// parameter is specified, then the latest Amazon ECS optimized AMI for that image type
        /// that's supported by Batch is used.
        /// </para>
        ///  <dl> <dt>ECS_AL2</dt> <dd> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-optimized_AMI.html#al2ami">Amazon
        /// Linux 2</a>: Default for all non-GPU instance families.
        /// </para>
        ///  </dd> <dt>ECS_AL2_NVIDIA</dt> <dd> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-optimized_AMI.html#gpuami">Amazon
        /// Linux 2 (GPU)</a>: Default for all GPU instance families (for example <code>P4</code>
        /// and <code>G4</code>) and can be used for all non Amazon Web Services Graviton-based
        /// instance types.
        /// </para>
        ///  </dd> <dt>ECS_AL1</dt> <dd> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-optimized_AMI.html#alami">Amazon
        /// Linux</a>. Amazon Linux has reached the end-of-life of standard support. For more
        /// information, see <a href="http://aws.amazon.com/amazon-linux-ami/">Amazon Linux AMI</a>.
        /// </para>
        ///  </dd> </dl> </dd> <dt>EKS</dt> <dd> 
        /// <para>
        /// If the <code>imageIdOverride</code> parameter isn't specified, then a recent <a href="https://docs.aws.amazon.com/eks/latest/userguide/eks-optimized-ami.html">Amazon
        /// EKS-optimized Amazon Linux AMI</a> (<code>EKS_AL2</code>) is used. If a new image
        /// type is specified in an update, but neither an <code>imageId</code> nor a <code>imageIdOverride</code>
        /// parameter is specified, then the latest Amazon EKS optimized AMI for that image type
        /// that Batch supports is used.
        /// </para>
        ///  <dl> <dt>EKS_AL2</dt> <dd> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/eks/latest/userguide/eks-optimized-ami.html">Amazon
        /// Linux 2</a>: Default for all non-GPU instance families.
        /// </para>
        ///  </dd> <dt>EKS_AL2_NVIDIA</dt> <dd> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/eks/latest/userguide/eks-optimized-ami.html">Amazon
        /// Linux 2 (accelerated)</a>: Default for all GPU instance families (for example, <code>P4</code>
        /// and <code>G4</code>) and can be used for all non Amazon Web Services Graviton-based
        /// instance types.
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