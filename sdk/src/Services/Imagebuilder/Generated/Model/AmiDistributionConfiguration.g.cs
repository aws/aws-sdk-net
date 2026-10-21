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
    /// Define and configure the output AMIs of the pipeline.
    /// </summary>
    public partial class AmiDistributionConfiguration
    {
        /// <summary>
        /// Gets and sets the property AmiTags. 
        /// <para>
        /// The tags to apply to AMIs distributed to this Region.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> AmiTags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the AmiTags property is set.
        /// </summary>
        internal bool IsSetAmiTags() => this.AmiTags != null && (this.AmiTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description to apply to the distributed AMI. Image Builder sets this as the output
        /// AMI's description in each target Region and account. If you don't specify a description,
        /// the AMI in the build Region uses the image recipe's description, if the recipe has
        /// one. Copies distributed to other Regions and accounts don't receive a default description.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies the KMS key used to encrypt
        /// the distributed image. This can be either the Key ARN or the Alias ARN. For more information,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#key-id-key-ARN">Key
        /// identifiers (KeyId)</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property LaunchPermission. 
        /// <para>
        /// Launch permissions can be used to configure which Amazon Web Services accounts can
        /// use the AMI to launch instances.
        /// </para>
        /// </summary>
        public LaunchPermissionConfiguration LaunchPermission { get; set; }

        /// <summary>
        /// Checks to see if the LaunchPermission property is set.
        /// </summary>
        internal bool IsSetLaunchPermission() => this.LaunchPermission != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the output AMI. The name must include the <c>{{ imagebuilder:buildDate
        /// }}</c> dynamic tag so that each build produces a uniquely named AMI. If you don't
        /// specify a name, Image Builder names the output AMI with the image name followed by
        /// the build timestamp, for example <c>my-image 2022-10-26T22-30-05.912619Z</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 127)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property TargetAccountIds. 
        /// <para>
        /// The Amazon Web Services account IDs to distribute the AMI to in this Region. Each
        /// listed account receives its own copy of the output AMI. If you don't specify accounts,
        /// Image Builder distributes the AMI only to your own account.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1536)]
        public List<string> TargetAccountIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TargetAccountIds property is set.
        /// </summary>
        internal bool IsSetTargetAccountIds() => this.TargetAccountIds != null && (this.TargetAccountIds.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
