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
    /// Container for the parameters to the ModifyImageAttribute operation. Modifies the specified
    /// attribute of the specified AMI. You can specify only one attribute at a time. <para>
    /// To specify the attribute, you can use the <c>Attribute</c> parameter, or one of the
    /// following parameters: <c>Description</c>, <c>ImdsSupport</c>, or <c>LaunchPermission</c>.
    /// </para> <para> Images with an Amazon Web Services Marketplace product code cannot
    /// be made public. </para> <para> To enable the SriovNetSupport enhanced networking attribute
    /// of an image, enable SriovNetSupport on an instance and create an AMI from the instance.
    /// </para>
    /// </summary>
    public partial class ModifyImageAttributeRequest : AmazonEC2Request
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public ModifyImageAttributeRequest() { }

        /// <summary>
        /// Instantiates ModifyImageAttributeRequest with the parameterized properties
        /// </summary>
        /// <param name="imageId">The ID of the AMI.</param>
        /// <param name="attribute">The name of the attribute to modify.   Valid values: <c>description</c> | <c>imdsSupport</c> |  <c>launchPermission</c>   </param>
        public ModifyImageAttributeRequest(string imageId, string attribute)
        {
            this.ImageId = imageId;
            this.Attribute = attribute;
        }

        /// <summary>
        /// Gets and sets the property Attribute. 
        /// <para>
        /// The name of the attribute to modify.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>description</c> | <c>imdsSupport</c> | <c>launchPermission</c> 
        /// </para>
        /// </summary>
        public string Attribute { get; set; }

        /// <summary>
        /// Checks to see if the Attribute property is set.
        /// </summary>
        internal bool IsSetAttribute() => this.Attribute != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A new description for the AMI.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        /// The ID of the AMI.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ImageId { get; set; }

        /// <summary>
        /// Checks to see if the ImageId property is set.
        /// </summary>
        internal bool IsSetImageId() => this.ImageId != null;

        /// <summary>
        /// Gets and sets the property ImdsSupport. 
        /// <para>
        /// Set to <c>v2.0</c> to indicate that IMDSv2 is specified in the AMI. Instances launched
        /// from this AMI will have <c>HttpTokens</c> automatically set to <c>required</c> so
        /// that, by default, the instance requires that IMDSv2 is used when requesting instance
        /// metadata. In addition, <c>HttpPutResponseHopLimit</c> is set to <c>2</c>. For more
        /// information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/configuring-IMDS-new-instances.html#configure-IMDS-new-instances-ami-configuration">Configure
        /// the AMI</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        /// Do not use this parameter unless your AMI software supports IMDSv2. After you set
        /// the value to <c>v2.0</c>, you can't undo it. The only way to “reset” your AMI is to
        /// create a new AMI from the underlying snapshot.
        /// </para>
        ///  </important>
        /// </summary>
        public string ImdsSupport { get; set; }

        /// <summary>
        /// Checks to see if the ImdsSupport property is set.
        /// </summary>
        internal bool IsSetImdsSupport() => this.ImdsSupport != null;

        /// <summary>
        /// Gets and sets the property LaunchPermission. 
        /// <para>
        /// A new launch permission for the AMI.
        /// </para>
        /// </summary>
        public LaunchPermissionModifications LaunchPermission { get; set; }

        /// <summary>
        /// Checks to see if the LaunchPermission property is set.
        /// </summary>
        internal bool IsSetLaunchPermission() => this.LaunchPermission != null;

        /// <summary>
        /// Gets and sets the property OperationType. 
        /// <para>
        /// The operation type. This parameter can be used only when the <c>Attribute</c> parameter
        /// is <c>launchPermission</c>.
        /// </para>
        /// </summary>
        public OperationType OperationType { get; set; }

        /// <summary>
        /// Checks to see if the OperationType property is set.
        /// </summary>
        internal bool IsSetOperationType() => this.OperationType != null;

        /// <summary>
        /// Gets and sets the property OrganizationArns. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an organization. This parameter can be used only
        /// when the <c>Attribute</c> parameter is <c>launchPermission</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> OrganizationArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the OrganizationArns property is set.
        /// </summary>
        internal bool IsSetOrganizationArns() => this.OrganizationArns != null && (this.OrganizationArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OrganizationalUnitArns. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an organizational unit (OU). This parameter can
        /// be used only when the <c>Attribute</c> parameter is <c>launchPermission</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> OrganizationalUnitArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the OrganizationalUnitArns property is set.
        /// </summary>
        internal bool IsSetOrganizationalUnitArns() => this.OrganizationalUnitArns != null && (this.OrganizationalUnitArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProductCodes. 
        /// <para>
        /// Not supported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ProductCodes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ProductCodes property is set.
        /// </summary>
        internal bool IsSetProductCodes() => this.ProductCodes != null && (this.ProductCodes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UserGroups. 
        /// <para>
        /// The user groups. This parameter can be used only when the <c>Attribute</c> parameter
        /// is <c>launchPermission</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> UserGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the UserGroups property is set.
        /// </summary>
        internal bool IsSetUserGroups() => this.UserGroups != null && (this.UserGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UserIds. 
        /// <para>
        /// The Amazon Web Services account IDs. This parameter can be used only when the <c>Attribute</c>
        /// parameter is <c>launchPermission</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> UserIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the UserIds property is set.
        /// </summary>
        internal bool IsSetUserIds() => this.UserIds != null && (this.UserIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of the attribute being modified. This parameter can be used only when the
        /// <c>Attribute</c> parameter is <c>description</c> or <c>imdsSupport</c>.
        /// </para>
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
