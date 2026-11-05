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

namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Container for the parameters to the CreateExportImageTask operation. Creates a task
    /// to export a WorkSpaces Applications image to an EC2 AMI. This allows you to use your
    /// customized WorkSpaces Applications images with other AWS services or for backup purposes.
    /// </summary>
    public partial class CreateExportImageTaskRequest : AmazonAppStreamRequest
    {
        /// <summary>
        /// Gets and sets the property AmiDescription. 
        /// <para>
        /// An optional description for the exported AMI. This description will be applied to
        /// the resulting EC2 AMI.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string AmiDescription { get; set; }

        /// <summary>
        /// Checks to see if the AmiDescription property is set.
        /// </summary>
        internal bool IsSetAmiDescription() => this.AmiDescription != null;

        /// <summary>
        /// Gets and sets the property AmiName. 
        /// <para>
        /// The name for the exported EC2 AMI. This is a required field that must be unique within
        /// your account and region.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AmiName { get; set; }

        /// <summary>
        /// Checks to see if the AmiName property is set.
        /// </summary>
        internal bool IsSetAmiName() => this.AmiName != null;

        /// <summary>
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// The ARN of the IAM role that allows WorkSpaces Applications to create the AMI. The
        /// role must have permissions to copy images, describe images, and create tags, with
        /// a trust relationship allowing appstream.amazonaws.com to assume the role.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string IamRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the IamRoleArn property is set.
        /// </summary>
        internal bool IsSetIamRoleArn() => this.IamRoleArn != null;

        /// <summary>
        /// Gets and sets the property ImageName. 
        /// <para>
        /// The name of the WorkSpaces Applications image to export. The image must be in an available
        /// state and owned by your account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ImageName { get; set; }

        /// <summary>
        /// Checks to see if the ImageName property is set.
        /// </summary>
        internal bool IsSetImageName() => this.ImageName != null;

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the exported AMI. These tags help you organize and manage your
        /// EC2 AMIs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> TagSpecifications { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the TagSpecifications property is set.
        /// </summary>
        internal bool IsSetTagSpecifications() => this.TagSpecifications != null && (this.TagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
