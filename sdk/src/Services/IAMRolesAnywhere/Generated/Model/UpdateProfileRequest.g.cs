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
    /// Container for the parameters to the UpdateProfile operation. Updates a <i>profile</i>,
    /// a list of the roles that IAM Roles Anywhere service is trusted to assume. You use
    /// profiles to intersect permissions with IAM managed policies. <para> <b>Required permissions:
    /// </b> <c>rolesanywhere:UpdateProfile</c>. </para>
    /// </summary>
    public partial class UpdateProfileRequest : AmazonIAMRolesAnywhereRequest
    {
        /// <summary>
        /// Gets and sets the property AcceptRoleSessionName. 
        /// <para>
        /// Used to determine if a custom role session name will be accepted in a temporary credential
        /// request.
        /// </para>
        /// </summary>
        public bool? AcceptRoleSessionName { get; set; }

        /// <summary>
        /// Checks to see if the AcceptRoleSessionName property is set.
        /// </summary>
        internal bool IsSetAcceptRoleSessionName() => this.AcceptRoleSessionName.HasValue;

        /// <summary>
        /// Gets and sets the property AliasName. 
        /// <para>
        /// The alias for the profile.
        /// </para>
        ///  
        /// <para>
        /// You can use this parameter in the following ways:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To set or change the alias, specify the new alias name. After the change, the previous
        /// alias ARN no longer identifies the resource. You can then assign the previous alias
        /// to another resource of the same type. A change can take a short time to take effect
        /// for requests that use an alias ARN.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To remove the alias, specify an empty string.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To keep the current alias, omit this parameter.
        /// </para>
        ///  </li> </ul> 
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
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string AliasName { get; set; }

        /// <summary>
        /// Checks to see if the AliasName property is set.
        /// </summary>
        internal bool IsSetAliasName() => this.AliasName != null;

        /// <summary>
        /// Gets and sets the property DurationSeconds. 
        /// <para>
        ///  Used to determine how long sessions vended using this profile are valid for. See
        /// the <c>Expiration</c> section of the <a href="https://docs.aws.amazon.com/rolesanywhere/latest/userguide/authentication-create-session.html#credentials-object">CreateSession
        /// API documentation</a> page for more details. In requests, if this value is not provided,
        /// the default value will be 3600. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 900, Max = 43200)]
        public int? DurationSeconds { get; set; }

        /// <summary>
        /// Checks to see if the DurationSeconds property is set.
        /// </summary>
        internal bool IsSetDurationSeconds() => this.DurationSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property ManagedPolicyArns. 
        /// <para>
        /// A list of managed policy ARNs that apply to the vended session credentials. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<string> ManagedPolicyArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ManagedPolicyArns property is set.
        /// </summary>
        internal bool IsSetManagedPolicyArns() => this.ManagedPolicyArns != null && (this.ManagedPolicyArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ProfileId. 
        /// <para>
        /// The profile to act on. You can specify one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The profile ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The profile ARN.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The alias ARN of the profile.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// An ARN must be for a profile in your account and Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1011)]
        public string ProfileId { get; set; }

        /// <summary>
        /// Checks to see if the ProfileId property is set.
        /// </summary>
        internal bool IsSetProfileId() => this.ProfileId != null;

        /// <summary>
        /// Gets and sets the property RoleArns. 
        /// <para>
        /// A list of IAM roles that this profile can assume in a temporary credential request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 250)]
        public List<string> RoleArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RoleArns property is set.
        /// </summary>
        internal bool IsSetRoleArns() => this.RoleArns != null && (this.RoleArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SessionPolicy. 
        /// <para>
        /// A session policy that applies to the trust boundary of the vended session credentials.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100000)]
        public string SessionPolicy { get; set; }

        /// <summary>
        /// Checks to see if the SessionPolicy property is set.
        /// </summary>
        internal bool IsSetSessionPolicy() => this.SessionPolicy != null;
    }
}
