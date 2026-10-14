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

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Container for the parameters to the CreateFleet operation. Creates a compute fleet.
    /// </summary>
    public partial class CreateFleetRequest : AmazonCodeBuildRequest
    {
        /// <summary>
        /// Gets and sets the property BaseCapacity. 
        /// <para>
        /// The initial number of machines allocated to the ﬂeet, which deﬁnes the number of builds
        /// that can run in parallel.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? BaseCapacity { get; set; }

        /// <summary>
        /// Checks to see if the BaseCapacity property is set.
        /// </summary>
        internal bool IsSetBaseCapacity() => this.BaseCapacity.HasValue;

        /// <summary>
        /// Gets and sets the property ComputeConfiguration. 
        /// <para>
        /// The compute configuration of the compute fleet. This is only required if <c>computeType</c>
        /// is set to <c>ATTRIBUTE_BASED_COMPUTE</c> or <c>CUSTOM_INSTANCE_TYPE</c>.
        /// </para>
        /// </summary>
        public ComputeConfiguration ComputeConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ComputeConfiguration property is set.
        /// </summary>
        internal bool IsSetComputeConfiguration() => this.ComputeConfiguration != null;

        /// <summary>
        /// Gets and sets the property ComputeType. 
        /// <para>
        /// Information about the compute resources the compute fleet uses. Available values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ATTRIBUTE_BASED_COMPUTE</c>: Specify the amount of vCPUs, memory, disk space,
        /// and the type of machine.
        /// </para>
        ///  <note> 
        /// <para>
        ///  If you use <c>ATTRIBUTE_BASED_COMPUTE</c>, you must define your attributes by using
        /// <c>computeConfiguration</c>. CodeBuild will select the cheapest instance that satisfies
        /// your specified attributes. For more information, see <a href="https://docs.aws.amazon.com/codebuild/latest/userguide/build-env-ref-compute-types.html#environment-reserved-capacity.types">Reserved
        /// capacity environment types</a> in the <i>CodeBuild User Guide</i>.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        ///  <c>CUSTOM_INSTANCE_TYPE</c>: Specify the instance type for your compute fleet. For
        /// a list of supported instance types, see <a href="https://docs.aws.amazon.com/codebuild/latest/userguide/build-env-ref-compute-types.html#environment-reserved-capacity.instance-types">Supported
        /// instance families </a> in the <i>CodeBuild User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BUILD_GENERAL1_SMALL</c>: Use up to 4 GiB memory and 2 vCPUs for builds.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BUILD_GENERAL1_MEDIUM</c>: Use up to 8 GiB memory and 4 vCPUs for builds.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BUILD_GENERAL1_LARGE</c>: Use up to 16 GiB memory and 8 vCPUs for builds, depending
        /// on your environment type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BUILD_GENERAL1_XLARGE</c>: Use up to 72 GiB memory and 36 vCPUs for builds, depending
        /// on your environment type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BUILD_GENERAL1_2XLARGE</c>: Use up to 144 GiB memory, 72 vCPUs, and 824 GB of
        /// SSD storage for builds. This compute type supports Docker images up to 100 GB uncompressed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BUILD_LAMBDA_1GB</c>: Use up to 1 GiB memory for builds. Only available for environment
        /// type <c>LINUX_LAMBDA_CONTAINER</c> and <c>ARM_LAMBDA_CONTAINER</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BUILD_LAMBDA_2GB</c>: Use up to 2 GiB memory for builds. Only available for environment
        /// type <c>LINUX_LAMBDA_CONTAINER</c> and <c>ARM_LAMBDA_CONTAINER</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BUILD_LAMBDA_4GB</c>: Use up to 4 GiB memory for builds. Only available for environment
        /// type <c>LINUX_LAMBDA_CONTAINER</c> and <c>ARM_LAMBDA_CONTAINER</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BUILD_LAMBDA_8GB</c>: Use up to 8 GiB memory for builds. Only available for environment
        /// type <c>LINUX_LAMBDA_CONTAINER</c> and <c>ARM_LAMBDA_CONTAINER</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BUILD_LAMBDA_10GB</c>: Use up to 10 GiB memory for builds. Only available for
        /// environment type <c>LINUX_LAMBDA_CONTAINER</c> and <c>ARM_LAMBDA_CONTAINER</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  If you use <c>BUILD_GENERAL1_SMALL</c>: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  For environment type <c>LINUX_CONTAINER</c>, you can use up to 4 GiB memory and 2
        /// vCPUs for builds. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  For environment type <c>LINUX_GPU_CONTAINER</c>, you can use up to 16 GiB memory,
        /// 4 vCPUs, and 1 NVIDIA A10G Tensor Core GPU for builds.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  For environment type <c>ARM_CONTAINER</c>, you can use up to 4 GiB memory and 2 vCPUs
        /// on ARM-based processors for builds.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  If you use <c>BUILD_GENERAL1_LARGE</c>: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  For environment type <c>LINUX_CONTAINER</c>, you can use up to 16 GiB memory and
        /// 8 vCPUs for builds. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  For environment type <c>LINUX_GPU_CONTAINER</c>, you can use up to 255 GiB memory,
        /// 32 vCPUs, and 4 NVIDIA Tesla V100 GPUs for builds.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  For environment type <c>ARM_CONTAINER</c>, you can use up to 16 GiB memory and 8
        /// vCPUs on ARM-based processors for builds.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/codebuild/latest/userguide/build-env-ref-compute-types.html#environment.types">On-demand
        /// environment types</a> in the <i>CodeBuild User Guide.</i> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ComputeType ComputeType { get; set; }

        /// <summary>
        /// Checks to see if the ComputeType property is set.
        /// </summary>
        internal bool IsSetComputeType() => this.ComputeType != null;

        /// <summary>
        /// Gets and sets the property EnvironmentType. 
        /// <para>
        /// The environment type of the compute fleet.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The environment type <c>ARM_CONTAINER</c> is available only in regions US East (N.
        /// Virginia), US East (Ohio), US West (Oregon), EU (Ireland), Asia Pacific (Mumbai),
        /// Asia Pacific (Tokyo), Asia Pacific (Singapore), Asia Pacific (Sydney), EU (Frankfurt),
        /// and South America (São Paulo).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The environment type <c>ARM_EC2</c> is available only in regions US East (N. Virginia),
        /// US East (Ohio), US West (Oregon), EU (Ireland), EU (Frankfurt), Asia Pacific (Tokyo),
        /// Asia Pacific (Singapore), Asia Pacific (Sydney), South America (São Paulo), and Asia
        /// Pacific (Mumbai).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The environment type <c>LINUX_CONTAINER</c> is available only in regions US East (N.
        /// Virginia), US East (Ohio), US West (Oregon), EU (Ireland), EU (Frankfurt), Asia Pacific
        /// (Tokyo), Asia Pacific (Singapore), Asia Pacific (Sydney), South America (São Paulo),
        /// and Asia Pacific (Mumbai).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The environment type <c>LINUX_EC2</c> is available only in regions US East (N. Virginia),
        /// US East (Ohio), US West (Oregon), EU (Ireland), EU (Frankfurt), Asia Pacific (Tokyo),
        /// Asia Pacific (Singapore), Asia Pacific (Sydney), South America (São Paulo), and Asia
        /// Pacific (Mumbai).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The environment type <c>LINUX_GPU_CONTAINER</c> is available only in regions US East
        /// (N. Virginia), US East (Ohio), US West (Oregon), EU (Ireland), EU (Frankfurt), Asia
        /// Pacific (Tokyo), and Asia Pacific (Sydney).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The environment type <c>MAC_ARM</c> is available for Medium fleets only in regions
        /// US East (N. Virginia), US East (Ohio), US West (Oregon), Asia Pacific (Sydney), and
        /// EU (Frankfurt)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The environment type <c>MAC_ARM</c> is available for Large fleets only in regions
        /// US East (N. Virginia), US East (Ohio), US West (Oregon), and Asia Pacific (Sydney).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The environment type <c>WINDOWS_EC2</c> is available only in regions US East (N. Virginia),
        /// US East (Ohio), US West (Oregon), EU (Ireland), EU (Frankfurt), Asia Pacific (Tokyo),
        /// Asia Pacific (Singapore), Asia Pacific (Sydney), South America (São Paulo), and Asia
        /// Pacific (Mumbai).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The environment type <c>WINDOWS_SERVER_2019_CONTAINER</c> is available only in regions
        /// US East (N. Virginia), US East (Ohio), US West (Oregon), Asia Pacific (Sydney), Asia
        /// Pacific (Tokyo), Asia Pacific (Mumbai) and EU (Ireland).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The environment type <c>WINDOWS_SERVER_2022_CONTAINER</c> is available only in regions
        /// US East (N. Virginia), US East (Ohio), US West (Oregon), EU (Ireland), EU (Frankfurt),
        /// Asia Pacific (Sydney), Asia Pacific (Singapore), Asia Pacific (Tokyo), South America
        /// (São Paulo) and Asia Pacific (Mumbai).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/codebuild/latest/userguide/build-env-ref-compute-types.html">Build
        /// environment compute types</a> in the <i>CodeBuild user guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EnvironmentType EnvironmentType { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentType property is set.
        /// </summary>
        internal bool IsSetEnvironmentType() => this.EnvironmentType != null;

        /// <summary>
        /// Gets and sets the property FleetServiceRole. 
        /// <para>
        /// The service role associated with the compute fleet. For more information, see <a href="https://docs.aws.amazon.com/codebuild/latest/userguide/auth-and-access-control-iam-identity-based-access-control.html#customer-managed-policies-example-permission-policy-fleet-service-role.html">
        /// Allow a user to add a permission policy for a fleet service role</a> in the <i>CodeBuild
        /// User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string FleetServiceRole { get; set; }

        /// <summary>
        /// Checks to see if the FleetServiceRole property is set.
        /// </summary>
        internal bool IsSetFleetServiceRole() => this.FleetServiceRole != null;

        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        /// The Amazon Machine Image (AMI) of the compute fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string ImageId { get; set; }

        /// <summary>
        /// Checks to see if the ImageId property is set.
        /// </summary>
        internal bool IsSetImageId() => this.ImageId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the compute fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OverflowBehavior. 
        /// <para>
        /// The compute fleet overflow behavior.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For overflow behavior <c>QUEUE</c>, your overflow builds need to wait on the existing
        /// fleet instance to become available.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For overflow behavior <c>ON_DEMAND</c>, your overflow builds run on CodeBuild on-demand.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you choose to set your overflow behavior to on-demand while creating a VPC-connected
        /// fleet, make sure that you add the required VPC permissions to your project service
        /// role. For more information, see <a href="https://docs.aws.amazon.com/codebuild/latest/userguide/auth-and-access-control-iam-identity-based-access-control.html#customer-managed-policies-example-create-vpc-network-interface">Example
        /// policy statement to allow CodeBuild access to Amazon Web Services services required
        /// to create a VPC network interface</a>.
        /// </para>
        ///  </note> </li> </ul>
        /// </summary>
        public FleetOverflowBehavior OverflowBehavior { get; set; }

        /// <summary>
        /// Checks to see if the OverflowBehavior property is set.
        /// </summary>
        internal bool IsSetOverflowBehavior() => this.OverflowBehavior != null;

        /// <summary>
        /// Gets and sets the property ProxyConfiguration. 
        /// <para>
        /// The proxy configuration of the compute fleet.
        /// </para>
        /// </summary>
        public ProxyConfiguration ProxyConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ProxyConfiguration property is set.
        /// </summary>
        internal bool IsSetProxyConfiguration() => this.ProxyConfiguration != null;

        /// <summary>
        /// Gets and sets the property ScalingConfiguration. 
        /// <para>
        /// The scaling configuration of the compute fleet.
        /// </para>
        /// </summary>
        public ScalingConfigurationInput ScalingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ScalingConfiguration property is set.
        /// </summary>
        internal bool IsSetScalingConfiguration() => this.ScalingConfiguration != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tag key and value pairs associated with this compute fleet.
        /// </para>
        ///  
        /// <para>
        /// These tags are available for use by Amazon Web Services services that support CodeBuild
        /// build project tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VpcConfig.
        /// </summary>
        public VpcConfig VpcConfig { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfig property is set.
        /// </summary>
        internal bool IsSetVpcConfig() => this.VpcConfig != null;
    }
}
