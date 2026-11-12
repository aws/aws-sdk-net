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

namespace Amazon.SSOAdmin.Model
{
    /// <summary>
    /// The network access controls for your Identity Center instance. These controls restrict
    /// which networks can reach your instance and applications.
    /// </summary>
    public partial class NetworkConfigurationInfo
    {
        /// <summary>
        /// Gets and sets the property AllowSourceIps. 
        /// <para>
        /// Allows access from the IPv4 or IPv6 CIDR blocks that you specify, in addition to the
        /// VPCs allowed by <c>RestrictSourceVpcs</c>. If you don't specify this value, no additional
        /// IP address ranges are allowed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<string> AllowSourceIps { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AllowSourceIps property is set.
        /// </summary>
        internal bool IsSetAllowSourceIps() => this.AllowSourceIps != null && (this.AllowSourceIps.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ExcludeApplicationArns. 
        /// <para>
        /// Exempts the applications that you specify from the network access control, so that
        /// access to them is unchanged. You can specify both Amazon Web Services managed applications
        /// and customer managed applications, and you can use wildcards. These applications are
        /// not restricted by <c>RestrictSourceVpcs</c> or <c>AllowSourceIps</c>. If you don't
        /// specify this value, the controls apply to all applications.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<string> ExcludeApplicationArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ExcludeApplicationArns property is set.
        /// </summary>
        internal bool IsSetExcludeApplicationArns() => this.ExcludeApplicationArns != null && (this.ExcludeApplicationArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RestrictSourceVpcs. 
        /// <para>
        /// Limits access to the VPC endpoints in the VPCs that you specify. These VPCs must be
        /// in your organization, or in the Amazon Web Services account for an account instance.
        /// If you don't specify this value, access is allowed from any VPC in your organization
        /// or Amazon Web Services account.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<string> RestrictSourceVpcs { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RestrictSourceVpcs property is set.
        /// </summary>
        internal bool IsSetRestrictSourceVpcs() => this.RestrictSourceVpcs != null && (this.RestrictSourceVpcs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VpceAccessRequired. 
        /// <para>
        /// Specifies whether access to your Identity Center instance and to applications must
        /// originate from a VPC endpoint. When this value is <c>true</c> and no other field is
        /// specified, access is allowed from any VPC in your organization, or from any VPC in
        /// the Amazon Web Services account for an account instance, and applies to all applications.
        /// When this value is <c>false</c>, no network access control is enforced and the values
        /// of <c>RestrictSourceVpcs</c>, <c>AllowSourceIps</c>, and <c>ExcludeApplicationArns</c>
        /// are cleared.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? VpceAccessRequired { get; set; }

        /// <summary>
        /// Checks to see if the VpceAccessRequired property is set.
        /// </summary>
        internal bool IsSetVpceAccessRequired() => this.VpceAccessRequired.HasValue;
    }
}
