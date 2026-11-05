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

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Container for the parameters to the CreateInfrastructureConfiguration operation. Creates
    /// a new infrastructure configuration. An infrastructure configuration defines the environment
    /// in which your image will be built and tested.
    /// </summary>
    public partial class CreateInfrastructureConfigurationRequest : AmazonImagebuilderRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier you provide to ensure that the operation runs
        /// no more than one time. If you retry a request with the same client token, Image Builder
        /// returns the original response without running the operation again. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// idempotency</a> in the <i>Amazon EC2 API Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the infrastructure configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Validates the required permissions and request parameters without performing the operation.
        /// If validation succeeds, the operation returns a <c>DryRunOperationException</c> error
        /// response.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceMetadataOptions. 
        /// <para>
        /// The instance metadata service (IMDS) settings that Image Builder applies to the EC2
        /// build and test instances it launches during image creation. If you don't set these
        /// options, the EC2 launch defaults for the instance apply. For more information about
        /// instance metadata options, see one of the following links:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/configuring-instance-metadata-options.html">Configure
        /// the instance metadata options</a> in the <i> <i>Amazon EC2 User Guide</i> </i> for
        /// Linux instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/configuring-instance-metadata-options.html">Configure
        /// the instance metadata options</a> in the <i> <i>Amazon EC2 Windows Guide</i> </i>
        /// for Windows instances.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public InstanceMetadataOptions InstanceMetadataOptions { get; set; }

        /// <summary>
        /// Checks to see if the InstanceMetadataOptions property is set.
        /// </summary>
        internal bool IsSetInstanceMetadataOptions() => this.InstanceMetadataOptions != null;

        /// <summary>
        /// Gets and sets the property InstanceProfileName. 
        /// <para>
        /// The instance profile to associate with the instance used to customize your Amazon
        /// EC2 AMI. The instance profile must exist in your account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string InstanceProfileName { get; set; }

        /// <summary>
        /// Checks to see if the InstanceProfileName property is set.
        /// </summary>
        internal bool IsSetInstanceProfileName() => this.InstanceProfileName != null;

        /// <summary>
        /// Gets and sets the property InstanceTypes. 
        /// <para>
        /// The instance types of the infrastructure configuration. You can specify one or more
        /// instance types to use for this build. Image Builder picks one of these instance types
        /// based on availability. If you don't specify instance types, Image Builder selects
        /// compatible instance types automatically. If you specify a Dedicated Host, Image Builder
        /// uses only instance types that the host supports.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InstanceTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InstanceTypes property is set.
        /// </summary>
        internal bool IsSetInstanceTypes() => this.InstanceTypes != null && (this.InstanceTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property KeyPair. 
        /// <para>
        /// The key pair of the infrastructure configuration. You can use this to log on to and
        /// debug the instance used to create your image.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string KeyPair { get; set; }

        /// <summary>
        /// Checks to see if the KeyPair property is set.
        /// </summary>
        internal bool IsSetKeyPair() => this.KeyPair != null;

        /// <summary>
        /// Gets and sets the property Logging. 
        /// <para>
        /// The logging configuration of the infrastructure configuration. When you configure
        /// S3 logs, Image Builder writes logs from the build and test process to the specified
        /// bucket under the key prefix.
        /// </para>
        /// </summary>
        public Logging Logging { get; set; }

        /// <summary>
        /// Checks to see if the Logging property is set.
        /// </summary>
        internal bool IsSetLogging() => this.Logging != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the infrastructure configuration. Infrastructure configuration names must
        /// be unique to your account in each Amazon Web Services Region. Image Builder generates
        /// the infrastructure configuration ARN from a normalized form of the name, so names
        /// that differ only in case, spaces, or underscores count as the same name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ParentInstance. 
        /// <para>
        /// The Amazon EC2 Auto Scaling group that Image Builder takes the build instance from,
        /// instead of launching a new instance. This applies only to the build phase.
        /// </para>
        ///  
        /// <para>
        /// To use this feature, the execution role for the build must have permissions to describe
        /// the Auto Scaling group, tag the instance while it's still in the group, and detach
        /// it from the group. For more information, see <a href="https://docs.aws.amazon.com/imagebuilder/latest/userguide/infra-config-parent-instance.html">Build
        /// on an instance from an Auto Scaling group</a> in the <i>EC2 Image Builder User Guide</i>.
        /// </para>
        /// </summary>
        public ParentInstanceConfiguration ParentInstance { get; set; }

        /// <summary>
        /// Checks to see if the ParentInstance property is set.
        /// </summary>
        internal bool IsSetParentInstance() => this.ParentInstance != null;

        /// <summary>
        /// Gets and sets the property Placement. 
        /// <para>
        /// The instance placement settings that define where the build and test instances that
        /// Image Builder launches during image creation run. These settings don't affect instances
        /// that you launch from the output image.
        /// </para>
        /// </summary>
        public Placement Placement { get; set; }

        /// <summary>
        /// Checks to see if the Placement property is set.
        /// </summary>
        internal bool IsSetPlacement() => this.Placement != null;

        /// <summary>
        /// Gets and sets the property ResourceTags. 
        /// <para>
        /// The metadata tags to assign to the Amazon EC2 instance that Image Builder launches
        /// during the build process. Tags are formatted as key value pairs. Tag keys can't begin
        /// with <c>aws:</c> or match one of the following reserved keys: <c>CreatedBy</c>, <c>Ec2ImageBuilderArn</c>,
        /// <c>Name</c>, or <c>Tags</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 30)]
        public Dictionary<string, string> ResourceTags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the ResourceTags property is set.
        /// </summary>
        internal bool IsSetResourceTags() => this.ResourceTags != null && (this.ResourceTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The security group IDs to associate with the instance used to customize your Amazon
        /// EC2 AMI.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroupIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SecurityGroupIds property is set.
        /// </summary>
        internal bool IsSetSecurityGroupIds() => this.SecurityGroupIds != null && (this.SecurityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SnsTopicArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the SNS topic to which Image Builder sends image
        /// build event notifications. Specify a standard topic. Image Builder doesn't support
        /// FIFO topics. Image Builder validates the topic when you create or update the configuration.
        /// You must have permission to publish to the topic.
        /// </para>
        ///  <note> 
        /// <para>
        /// EC2 Image Builder can't send notifications to SNS topics that are encrypted using
        /// keys from other accounts. If your SNS topic is encrypted, the key must be owned by
        /// the same account that owns your Image Builder resources.
        /// </para>
        ///  </note>
        /// </summary>
        public string SnsTopicArn { get; set; }

        /// <summary>
        /// Checks to see if the SnsTopicArn property is set.
        /// </summary>
        internal bool IsSetSnsTopicArn() => this.SnsTopicArn != null;

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The subnet ID in which to place the instance used to customize your Amazon EC2 AMI.
        /// If you specify <c>subnetId</c>, you must also specify one or more security group IDs
        /// in <c>securityGroupIds</c>. Otherwise, the request fails.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string SubnetId { get; set; }

        /// <summary>
        /// Checks to see if the SubnetId property is set.
        /// </summary>
        internal bool IsSetSubnetId() => this.SubnetId != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The metadata tags to assign to the infrastructure configuration resource that Image
        /// Builder creates as output. Tags are formatted as key value pairs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TerminateInstanceOnCompletion. 
        /// <para>
        /// Specifies whether Image Builder terminates build and test instances when image creation
        /// ends without a failure (success, cancellation, or expiration). Defaults to <c>true</c>.
        /// </para>
        /// </summary>
        public bool? TerminateInstanceOnCompletion { get; set; }

        /// <summary>
        /// Checks to see if the TerminateInstanceOnCompletion property is set.
        /// </summary>
        internal bool IsSetTerminateInstanceOnCompletion() => this.TerminateInstanceOnCompletion.HasValue;

        /// <summary>
        /// Gets and sets the property TerminateInstanceOnFailure. 
        /// <para>
        /// Specifies whether to terminate the instance on failure. Set to false if you want Image
        /// Builder to retain the instance used to configure your AMI if the build or test phase
        /// of your workflow fails. Defaults to <c>true</c>.
        /// </para>
        /// </summary>
        public bool? TerminateInstanceOnFailure { get; set; }

        /// <summary>
        /// Checks to see if the TerminateInstanceOnFailure property is set.
        /// </summary>
        internal bool IsSetTerminateInstanceOnFailure() => this.TerminateInstanceOnFailure.HasValue;
    }
}
