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
    /// Details of the infrastructure configuration.
    /// </summary>
    public partial class InfrastructureConfiguration
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the infrastructure configuration.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property DateCreated. 
        /// <para>
        /// The date on which the infrastructure configuration was created.
        /// </para>
        /// </summary>
        public string DateCreated { get; set; }

        /// <summary>
        /// Checks to see if the DateCreated property is set.
        /// </summary>
        internal bool IsSetDateCreated() => this.DateCreated != null;

        /// <summary>
        /// Gets and sets the property DateUpdated. 
        /// <para>
        /// The date on which the infrastructure configuration was last updated.
        /// </para>
        /// </summary>
        public string DateUpdated { get; set; }

        /// <summary>
        /// Checks to see if the DateUpdated property is set.
        /// </summary>
        internal bool IsSetDateUpdated() => this.DateUpdated != null;

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
        /// Gets and sets the property InstanceMetadataOptions. 
        /// <para>
        /// The instance metadata option settings for the infrastructure configuration.
        /// </para>
        /// </summary>
        public InstanceMetadataOptions InstanceMetadataOptions { get; set; }

        /// <summary>
        /// Checks to see if the InstanceMetadataOptions property is set.
        /// </summary>
        internal bool IsSetInstanceMetadataOptions() => this.InstanceMetadataOptions != null;

        /// <summary>
        /// Gets and sets the property InstanceProfileName. 
        /// <para>
        /// The instance profile of the infrastructure configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string InstanceProfileName { get; set; }

        /// <summary>
        /// Checks to see if the InstanceProfileName property is set.
        /// </summary>
        internal bool IsSetInstanceProfileName() => this.InstanceProfileName != null;

        /// <summary>
        /// Gets and sets the property InstanceTypes. 
        /// <para>
        /// The instance types of the infrastructure configuration.
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
        /// The Amazon EC2 key pair of the infrastructure configuration.
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
        /// The name of the infrastructure configuration.
        /// </para>
        /// </summary>
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
        /// The metadata tags assigned to the Amazon EC2 build and test instances that Image Builder
        /// launches during image creation.
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
        /// The security group IDs of the infrastructure configuration.
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
        /// FIFO topics.
        /// </para>
        ///  <note> 
        /// <para>
        /// EC2 Image Builder can't send notifications to SNS topics that are encrypted using
        /// keys from other accounts. If your SNS topic is encrypted, the key must be owned by
        /// the same account that owns your Image Builder resources.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string SnsTopicArn { get; set; }

        /// <summary>
        /// Checks to see if the SnsTopicArn property is set.
        /// </summary>
        internal bool IsSetSnsTopicArn() => this.SnsTopicArn != null;

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The subnet ID of the infrastructure configuration.
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
        /// The tags of the infrastructure configuration.
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
        /// ends without a failure.
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
        /// Indicates whether Image Builder terminates the build and test instances when the image
        /// build fails. When <c>false</c>, Image Builder retains the instance so that you can
        /// debug it.
        /// </para>
        /// </summary>
        public bool? TerminateInstanceOnFailure { get; set; }

        /// <summary>
        /// Checks to see if the TerminateInstanceOnFailure property is set.
        /// </summary>
        internal bool IsSetTerminateInstanceOnFailure() => this.TerminateInstanceOnFailure.HasValue;
    }
}
