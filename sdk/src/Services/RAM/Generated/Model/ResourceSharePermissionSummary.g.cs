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

namespace Amazon.RAM.Model
{
    /// <summary>
    /// Information about an RAM permission.
    /// </summary>
    public partial class ResourceSharePermissionSummary
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> of the permission you want information about.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time when the permission was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DefaultVersion. 
        /// <para>
        /// Specifies whether the version of the managed permission used by this resource share
        /// is the default version for this managed permission.
        /// </para>
        /// </summary>
        public bool? DefaultVersion { get; set; }

        /// <summary>
        /// Checks to see if the DefaultVersion property is set.
        /// </summary>
        internal bool IsSetDefaultVersion() => this.DefaultVersion.HasValue;

        /// <summary>
        /// Gets and sets the property FeatureSet. 
        /// <para>
        /// Indicates what features are available for this resource share. This parameter can
        /// have one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>STANDARD</b> – A resource share that supports all functionality. These resource
        /// shares are visible to all principals you share the resource share with. You can modify
        /// these resource shares in RAM using the console or APIs. This resource share might
        /// have been created by RAM, or it might have been <b>CREATED_FROM_POLICY</b> and then
        /// promoted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>CREATED_FROM_POLICY</b> – The customer manually shared a resource by attaching
        /// a resource-based policy. That policy did not match any existing managed permissions,
        /// so RAM created this customer managed permission automatically on the customer's behalf
        /// based on the attached policy document. This type of resource share is visible only
        /// to the Amazon Web Services account that created it. You can't modify it in RAM unless
        /// you promote it. For more information, see <a>PromoteResourceShareCreatedFromPolicy</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>PROMOTING_TO_STANDARD</b> – This resource share was originally <c>CREATED_FROM_POLICY</c>,
        /// but the customer ran the <a>PromoteResourceShareCreatedFromPolicy</a> and that operation
        /// is still in progress. This value changes to <c>STANDARD</c> when complete.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public PermissionFeatureSet FeatureSet { get; set; }

        /// <summary>
        /// Checks to see if the FeatureSet property is set.
        /// </summary>
        internal bool IsSetFeatureSet() => this.FeatureSet != null;

        /// <summary>
        /// Gets and sets the property IsResourceTypeDefault. 
        /// <para>
        /// Specifies whether the managed permission associated with this resource share is the
        /// default managed permission for all resources of this resource type.
        /// </para>
        /// </summary>
        public bool? IsResourceTypeDefault { get; set; }

        /// <summary>
        /// Checks to see if the IsResourceTypeDefault property is set.
        /// </summary>
        internal bool IsSetIsResourceTypeDefault() => this.IsResourceTypeDefault.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The date and time when the permission was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of this managed permission.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PermissionType. 
        /// <para>
        /// The type of managed permission. This can be one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AWS_MANAGED</c> – Amazon Web Services created and manages this managed permission.
        /// You can associate it with your resource shares, but you can't modify it.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CUSTOMER_MANAGED</c> – You, or another principal in your account created this
        /// managed permission. You can associate it with your resource shares and create new
        /// versions that have different permissions.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public PermissionType PermissionType { get; set; }

        /// <summary>
        /// Checks to see if the PermissionType property is set.
        /// </summary>
        internal bool IsSetPermissionType() => this.PermissionType != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource to which this permission applies. This takes the form of: <c>service-code</c>:<c>resource-code</c>,
        /// and is case-insensitive. For example, an Amazon EC2 Subnet would be represented by
        /// the string <c>ec2:subnet</c>.
        /// </para>
        /// </summary>
        public string ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the permission.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of the tag key value pairs currently attached to the permission.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the permission associated with this resource share.
        /// </para>
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
