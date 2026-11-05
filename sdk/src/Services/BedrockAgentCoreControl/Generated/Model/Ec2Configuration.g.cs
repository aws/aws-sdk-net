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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// The configuration for Amazon EC2-based compute, including the launch template source,
    /// networking, storage volumes, and instance lifecycle settings.
    /// </summary>
    public partial class Ec2Configuration
    {
        /// <summary>
        /// Gets and sets the property LaunchTemplateSource. 
        /// <para>
        /// The source of the launch template configuration that defines how instances are launched.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LaunchTemplateSource LaunchTemplateSource { get; set; }

        /// <summary>
        /// Checks to see if the LaunchTemplateSource property is set.
        /// </summary>
        internal bool IsSetLaunchTemplateSource() => this.LaunchTemplateSource != null;

        /// <summary>
        /// Gets and sets the property LifecycleConfiguration. 
        /// <para>
        /// The lifecycle configuration for instances in the capacity provider.
        /// </para>
        /// </summary>
        public InstanceLifecycleConfiguration LifecycleConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LifecycleConfiguration property is set.
        /// </summary>
        internal bool IsSetLifecycleConfiguration() => this.LifecycleConfiguration != null;

        /// <summary>
        /// Gets and sets the property RootVolume. 
        /// <para>
        /// The configuration for the instance root volume. Specify the amount of free space to
        /// guarantee and, optionally, the Amazon EBS performance and encryption settings. The
        /// device name and delete-on-termination behavior are not configurable.
        /// </para>
        /// </summary>
        public RootVolumeConfiguration RootVolume { get; set; }

        /// <summary>
        /// Checks to see if the RootVolume property is set.
        /// </summary>
        internal bool IsSetRootVolume() => this.RootVolume != null;

        /// <summary>
        /// Gets and sets the property Volumes. 
        /// <para>
        /// The named persistent Amazon EBS volumes for the capacity provider. A capacity provider
        /// can define up to five volumes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 5)]
        public List<VolumeConfiguration> Volumes { get; set; } = AWSConfigs.InitializeCollections ? new List<VolumeConfiguration>() : null;

        /// <summary>
        /// Checks to see if the Volumes property is set.
        /// </summary>
        internal bool IsSetVolumes() => this.Volumes != null && (this.Volumes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VpcConfiguration. 
        /// <para>
        /// The VPC configuration for launching instances, including subnets and security groups.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public VpcConfiguration VpcConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfiguration property is set.
        /// </summary>
        internal bool IsSetVpcConfiguration() => this.VpcConfiguration != null;
    }
}
