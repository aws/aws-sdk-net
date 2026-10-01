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

namespace Amazon.SecurityIR.Model
{
    /// <summary>
    /// This is the response object from the GetMembership operation.
    /// </summary>
    public partial class GetMembershipResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// Response element for GetMembership that provides the account configured to manage
        /// the membership.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property CustomerType. 
        /// <para>
        /// Response element for GetMembership that provides the configured membership type. Options
        /// include <c> Standalone | Organizations</c>. 
        /// </para>
        /// </summary>
        public CustomerType CustomerType { get; set; }

        /// <summary>
        /// Checks to see if the CustomerType property is set.
        /// </summary>
        internal bool IsSetCustomerType() => this.CustomerType != null;

        /// <summary>
        /// Gets and sets the property IncidentResponseTeam. 
        /// <para>
        /// Response element for GetMembership that provides the configured membership incident
        /// response team members. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 2, Max = 10)]
        public List<IncidentResponder> IncidentResponseTeam { get; set; } = AWSConfigs.InitializeCollections ? new List<IncidentResponder>() : null;

        /// <summary>
        /// Checks to see if the IncidentResponseTeam property is set.
        /// </summary>
        internal bool IsSetIncidentResponseTeam() => this.IncidentResponseTeam != null && (this.IncidentResponseTeam.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MembershipAccountsConfigurations. 
        /// <para>
        /// The <c>membershipAccountsConfigurations</c> field contains the configuration details
        /// for member accounts within the Amazon Web Services Organizations membership structure.
        /// 
        /// </para>
        ///  
        /// <para>
        /// This field returns a structure containing information about:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Account configurations for member accounts
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Membership settings and preferences
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Account-level permissions and roles
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public MembershipAccountsConfigurations MembershipAccountsConfigurations { get; set; }

        /// <summary>
        /// Checks to see if the MembershipAccountsConfigurations property is set.
        /// </summary>
        internal bool IsSetMembershipAccountsConfigurations() => this.MembershipAccountsConfigurations != null;

        /// <summary>
        /// Gets and sets the property MembershipActivationTimestamp. 
        /// <para>
        /// Response element for GetMembership that provides the configured membership activation
        /// timestamp.
        /// </para>
        /// </summary>
        public DateTime? MembershipActivationTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the MembershipActivationTimestamp property is set.
        /// </summary>
        internal bool IsSetMembershipActivationTimestamp() => this.MembershipActivationTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property MembershipArn. 
        /// <para>
        /// Response element for GetMembership that provides the membership ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 80)]
        public string MembershipArn { get; set; }

        /// <summary>
        /// Checks to see if the MembershipArn property is set.
        /// </summary>
        internal bool IsSetMembershipArn() => this.MembershipArn != null;

        /// <summary>
        /// Gets and sets the property MembershipDeactivationTimestamp. 
        /// <para>
        /// Response element for GetMembership that provides the configured membership name deactivation
        /// timestamp. 
        /// </para>
        /// </summary>
        public DateTime? MembershipDeactivationTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the MembershipDeactivationTimestamp property is set.
        /// </summary>
        internal bool IsSetMembershipDeactivationTimestamp() => this.MembershipDeactivationTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property MembershipId. 
        /// <para>
        /// Response element for GetMembership that provides the queried membership ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 34)]
        public string MembershipId { get; set; }

        /// <summary>
        /// Checks to see if the MembershipId property is set.
        /// </summary>
        internal bool IsSetMembershipId() => this.MembershipId != null;

        /// <summary>
        /// Gets and sets the property MembershipName. 
        /// <para>
        /// Response element for GetMembership that provides the configured membership name.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 3, Max = 50)]
        public string MembershipName { get; set; }

        /// <summary>
        /// Checks to see if the MembershipName property is set.
        /// </summary>
        internal bool IsSetMembershipName() => this.MembershipName != null;

        /// <summary>
        /// Gets and sets the property MembershipStatus. 
        /// <para>
        /// Response element for GetMembership that provides the current membership status.
        /// </para>
        /// </summary>
        public MembershipStatus MembershipStatus { get; set; }

        /// <summary>
        /// Checks to see if the MembershipStatus property is set.
        /// </summary>
        internal bool IsSetMembershipStatus() => this.MembershipStatus != null;

        /// <summary>
        /// Gets and sets the property NumberOfAccountsCovered. 
        /// <para>
        /// Response element for GetMembership that provides the number of accounts in the membership.
        /// </para>
        /// </summary>
        public long? NumberOfAccountsCovered { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfAccountsCovered property is set.
        /// </summary>
        internal bool IsSetNumberOfAccountsCovered() => this.NumberOfAccountsCovered.HasValue;

        /// <summary>
        /// Gets and sets the property OptInFeatures. 
        /// <para>
        /// Response element for GetMembership that provides the if opt-in features have been
        /// enabled.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2)]
        public List<OptInFeature> OptInFeatures { get; set; } = AWSConfigs.InitializeCollections ? new List<OptInFeature>() : null;

        /// <summary>
        /// Checks to see if the OptInFeatures property is set.
        /// </summary>
        internal bool IsSetOptInFeatures() => this.OptInFeatures != null && (this.OptInFeatures.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// Response element for GetMembership that provides the region configured to manage the
        /// membership.
        /// </para>
        /// </summary>
        public AwsRegion Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;
    }
}
