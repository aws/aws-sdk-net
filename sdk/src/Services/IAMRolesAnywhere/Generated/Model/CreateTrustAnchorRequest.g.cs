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

namespace Amazon.IAMRolesAnywhere.Model
{
    /// <summary>
    /// Container for the parameters to the CreateTrustAnchor operation. Creates a trust anchor
    /// to establish trust between IAM Roles Anywhere and your certificate authority (CA).
    /// You can define a trust anchor as a reference to an Private Certificate Authority (Private
    /// CA) or by uploading a CA certificate. Your Amazon Web Services workloads can authenticate
    /// with the trust anchor using certificates issued by the CA in exchange for temporary
    /// Amazon Web Services credentials. <para> <b>Required permissions: </b> <c>rolesanywhere:CreateTrustAnchor</c>.
    /// </para>
    /// </summary>
    public partial class CreateTrustAnchorRequest : AmazonIAMRolesAnywhereRequest
    {
        /// <summary>
        /// Gets and sets the property AliasName. 
        /// <para>
        /// An alias for the trust anchor. When you set an alias, the response includes the alias
        /// ARN of the trust anchor in <c>aliasArn</c>.
        /// </para>
        ///  
        /// <para>
        /// An alias name contains 1 to 256 characters. It must begin with a letter (A-Z or a-z).
        /// It can contain only letters (A-Z and a-z), numbers (0-9), underscores (_), hyphens
        /// (-), and forward slashes (/). A forward slash can appear only between two other characters,
        /// so an alias name can't end with a forward slash or contain two in a row. Alias names
        /// that begin with <c>aws/</c>, in any combination of uppercase and lowercase letters,
        /// are reserved. Alias names are case sensitive.
        /// </para>
        ///  
        /// <para>
        /// The alias name must be unique among resources of the same type in your account and
        /// Region. If another resource of the same type already has the alias, the request fails
        /// with a <c>ValidationException</c>. An invalid or reserved alias name also causes a
        /// <c>ValidationException</c>.
        /// </para>
        ///  
        /// <para>
        /// If you omit this parameter or specify an empty string, the resource is created without
        /// an alias.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string AliasName { get; set; }

        /// <summary>
        /// Checks to see if the AliasName property is set.
        /// </summary>
        internal bool IsSetAliasName() => this.AliasName != null;

        /// <summary>
        /// Gets and sets the property CrlDpRevocationEnabled. 
        /// <para>
        /// Specifies whether the trust anchor checks certificate revocation status against CRL
        /// distribution points.
        /// </para>
        /// </summary>
        public bool? CrlDpRevocationEnabled { get; set; }

        /// <summary>
        /// Checks to see if the CrlDpRevocationEnabled property is set.
        /// </summary>
        internal bool IsSetCrlDpRevocationEnabled() => this.CrlDpRevocationEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Specifies whether the trust anchor is enabled.
        /// </para>
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the trust anchor.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NotificationSettings. 
        /// <para>
        /// A list of notification settings to be associated to the trust anchor.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<NotificationSetting> NotificationSettings { get; set; } = AWSConfigs.InitializeCollections ? new List<NotificationSetting>() : null;

        /// <summary>
        /// Checks to see if the NotificationSettings property is set.
        /// </summary>
        internal bool IsSetNotificationSettings() => this.NotificationSettings != null && (this.NotificationSettings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The trust anchor type and its related certificate data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Source Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to attach to the trust anchor.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
