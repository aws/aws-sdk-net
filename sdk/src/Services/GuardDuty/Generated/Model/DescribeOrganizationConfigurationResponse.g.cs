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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// This is the response object from the DescribeOrganizationConfiguration operation.
    /// </summary>
    public partial class DescribeOrganizationConfigurationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AutoEnable. 
        /// <para>
        /// Indicates whether GuardDuty is automatically enabled for accounts added to the organization.
        /// </para>
        ///  
        /// <para>
        /// Even though this is still supported, we recommend using <c>AutoEnableOrganizationMembers</c>
        /// to achieve the similar results.
        /// </para>
        /// </summary>
        [Obsolete("This field is deprecated, use AutoEnableOrganizationMembers instead")]
        public bool? AutoEnable { get; set; }

        /// <summary>
        /// Checks to see if the AutoEnable property is set.
        /// </summary>
        internal bool IsSetAutoEnable() => this.AutoEnable.HasValue;

        /// <summary>
        /// Gets and sets the property AutoEnableOrganizationMembers. 
        /// <para>
        /// Indicates the auto-enablement configuration of GuardDuty or any of the corresponding
        /// protection plans for the member accounts in the organization.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>NEW</c>: Indicates that when a new account joins the organization, they will have
        /// GuardDuty or any of the corresponding protection plans enabled automatically. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ALL</c>: Indicates that all accounts in the organization have GuardDuty and any
        /// of the corresponding protection plans enabled automatically. This includes <c>NEW</c>
        /// accounts that join the organization and accounts that may have been suspended or removed
        /// from the organization in GuardDuty.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NONE</c>: Indicates that GuardDuty or any of the corresponding protection plans
        /// will not be automatically enabled for any account in the organization. The administrator
        /// must manage GuardDuty for each account in the organization individually.
        /// </para>
        ///  
        /// <para>
        /// When you update the auto-enable setting from <c>ALL</c> or <c>NEW</c> to <c>NONE</c>,
        /// this action doesn't disable the corresponding option for your existing accounts. This
        /// configuration will apply to the new accounts that join the organization. After you
        /// update the auto-enable settings, no new account will have the corresponding option
        /// as enabled.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AutoEnableMembers AutoEnableOrganizationMembers { get; set; }

        /// <summary>
        /// Checks to see if the AutoEnableOrganizationMembers property is set.
        /// </summary>
        internal bool IsSetAutoEnableOrganizationMembers() => this.AutoEnableOrganizationMembers != null;

        /// <summary>
        /// Gets and sets the property DataSources. 
        /// <para>
        /// Describes which data sources are enabled automatically for member accounts.
        /// </para>
        /// </summary>
        [Obsolete("This parameter is deprecated, use Features instead")]
        public OrganizationDataSourceConfigurationsResult DataSources { get; set; }

        /// <summary>
        /// Checks to see if the DataSources property is set.
        /// </summary>
        internal bool IsSetDataSources() => this.DataSources != null;

        /// <summary>
        /// Gets and sets the property Features. 
        /// <para>
        /// A list of features that are configured for this organization.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OrganizationFeatureConfigurationResult> Features { get; set; } = AWSConfigs.InitializeCollections ? new List<OrganizationFeatureConfigurationResult>() : null;

        /// <summary>
        /// Checks to see if the Features property is set.
        /// </summary>
        internal bool IsSetFeatures() => this.Features != null && (this.Features.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MemberAccountLimitReached. 
        /// <para>
        /// Indicates whether the maximum number of allowed member accounts are already associated
        /// with the delegated administrator account for your organization.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? MemberAccountLimitReached { get; set; }

        /// <summary>
        /// Checks to see if the MemberAccountLimitReached property is set.
        /// </summary>
        internal bool IsSetMemberAccountLimitReached() => this.MemberAccountLimitReached.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination parameter to be used on the next list operation to retrieve more items.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
