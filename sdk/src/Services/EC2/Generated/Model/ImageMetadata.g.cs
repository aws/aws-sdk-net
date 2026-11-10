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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Information about the AMI.
    /// </summary>
    public partial class ImageMetadata
    {
        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time the AMI was created.
        /// </para>
        /// </summary>
        public string CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate != null;

        /// <summary>
        /// Gets and sets the property DeprecationTime. 
        /// <para>
        /// The deprecation date and time of the AMI, in UTC, in the following format: <i>YYYY</i>-<i>MM</i>-<i>DD</i>T<i>HH</i>:<i>MM</i>:<i>SS</i>Z.
        /// </para>
        /// </summary>
        public string DeprecationTime { get; set; }

        /// <summary>
        /// Checks to see if the DeprecationTime property is set.
        /// </summary>
        internal bool IsSetDeprecationTime() => this.DeprecationTime != null;

        /// <summary>
        /// Gets and sets the property ImageAllowed. 
        /// <para>
        /// If <c>true</c>, the AMI satisfies the criteria for Allowed AMIs and can be discovered
        /// and used in the account. If <c>false</c>, the AMI can't be discovered or used in the
        /// account.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-allowed-amis.html">Control
        /// the discovery and use of AMIs in Amazon EC2 with Allowed AMIs</a> in <i>Amazon EC2
        /// User Guide</i>.
        /// </para>
        /// </summary>
        public bool? ImageAllowed { get; set; }

        /// <summary>
        /// Checks to see if the ImageAllowed property is set.
        /// </summary>
        internal bool IsSetImageAllowed() => this.ImageAllowed.HasValue;

        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        /// The ID of the AMI.
        /// </para>
        /// </summary>
        public string ImageId { get; set; }

        /// <summary>
        /// Checks to see if the ImageId property is set.
        /// </summary>
        internal bool IsSetImageId() => this.ImageId != null;

        /// <summary>
        /// Gets and sets the property ImageOwnerAlias. 
        /// <para>
        /// The alias of the AMI owner.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>amazon</c> | <c>aws-backup-vault</c> | <c>aws-marketplace</c> 
        /// </para>
        /// </summary>
        public string ImageOwnerAlias { get; set; }

        /// <summary>
        /// Checks to see if the ImageOwnerAlias property is set.
        /// </summary>
        internal bool IsSetImageOwnerAlias() => this.ImageOwnerAlias != null;

        /// <summary>
        /// Gets and sets the property ImageWatermarks. 
        /// <para>
        /// The watermarks attached to the AMI.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ImageWatermark> ImageWatermarks { get; set; } = AWSConfigs.InitializeCollections ? new List<ImageWatermark>() : null;

        /// <summary>
        /// Checks to see if the ImageWatermarks property is set.
        /// </summary>
        internal bool IsSetImageWatermarks() => this.ImageWatermarks != null && (this.ImageWatermarks.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IsPublic. 
        /// <para>
        /// Indicates whether the AMI has public launch permissions. A value of <c>true</c> means
        /// this AMI has public launch permissions, while <c>false</c> means it has only implicit
        /// (AMI owner) or explicit (shared with your account) launch permissions.
        /// </para>
        /// </summary>
        public bool? IsPublic { get; set; }

        /// <summary>
        /// Checks to see if the IsPublic property is set.
        /// </summary>
        internal bool IsSetIsPublic() => this.IsPublic.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the AMI.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the AMI.
        /// </para>
        /// </summary>
        public string OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the AMI. If the state is <c>available</c>, the AMI is successfully
        /// registered and can be used to launch an instance.
        /// </para>
        /// </summary>
        public ImageState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
