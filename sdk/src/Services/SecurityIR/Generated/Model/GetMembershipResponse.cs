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
 * Do not modify this file. This file is generated from the security-ir-2018-05-10.normal.json service model.
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
        private string _accountId;
        private CustomerType _customerType;
        private List<IncidentResponder> _incidentResponseTeam = AWSConfigs.InitializeCollections ? new List<IncidentResponder>() : null;
        private MembershipAccountsConfigurations _membershipAccountsConfigurations;
        private DateTime? _membershipActivationTimestamp;
        private string _membershipArn;
        private DateTime? _membershipDeactivationTimestamp;
        private string _membershipId;
        private string _membershipName;
        private MembershipStatus _membershipStatus;
        private long? _numberOfAccountsCovered;
        private List<OptInFeature> _optInFeatures = AWSConfigs.InitializeCollections ? new List<OptInFeature>() : null;
        private AwsRegion _region;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// Response element for GetMembership that provides the account configured to manage
        /// the membership.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property CustomerType. 
        /// <para>
        /// Response element for GetMembership that provides the configured membership type. Options
        /// include <c> Standalone | Organizations</c>. 
        /// </para>
        /// </summary>
        public CustomerType CustomerType
        {
            get { return this._customerType; }
            set { this._customerType = value; }
        }

        // Check to see if CustomerType property is set
        internal bool IsSetCustomerType()
        {
            return this._customerType != null;
        }

        /// <summary>
        /// Gets and sets the property IncidentResponseTeam. 
        /// <para>
        /// Response element for GetMembership that provides the configured membership incident
        /// response team members. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=2, Max=10)]
        public List<IncidentResponder> IncidentResponseTeam
        {
            get { return this._incidentResponseTeam; }
            set { this._incidentResponseTeam = value; }
        }

        // Check to see if IncidentResponseTeam property is set
        internal bool IsSetIncidentResponseTeam()
        {
            return this._incidentResponseTeam != null && (this._incidentResponseTeam.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        public MembershipAccountsConfigurations MembershipAccountsConfigurations
        {
            get { return this._membershipAccountsConfigurations; }
            set { this._membershipAccountsConfigurations = value; }
        }

        // Check to see if MembershipAccountsConfigurations property is set
        internal bool IsSetMembershipAccountsConfigurations()
        {
            return this._membershipAccountsConfigurations != null;
        }

        /// <summary>
        /// Gets and sets the property MembershipActivationTimestamp. 
        /// <para>
        /// Response element for GetMembership that provides the configured membership activation
        /// timestamp.
        /// </para>
        /// </summary>
        public DateTime? MembershipActivationTimestamp
        {
            get { return this._membershipActivationTimestamp; }
            set { this._membershipActivationTimestamp = value; }
        }

        // Check to see if MembershipActivationTimestamp property is set
        internal bool IsSetMembershipActivationTimestamp()
        {
            return this._membershipActivationTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MembershipArn. 
        /// <para>
        /// Response element for GetMembership that provides the membership ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=80)]
        public string MembershipArn
        {
            get { return this._membershipArn; }
            set { this._membershipArn = value; }
        }

        // Check to see if MembershipArn property is set
        internal bool IsSetMembershipArn()
        {
            return this._membershipArn != null;
        }

        /// <summary>
        /// Gets and sets the property MembershipDeactivationTimestamp. 
        /// <para>
        /// Response element for GetMembership that provides the configured membership name deactivation
        /// timestamp. 
        /// </para>
        /// </summary>
        public DateTime? MembershipDeactivationTimestamp
        {
            get { return this._membershipDeactivationTimestamp; }
            set { this._membershipDeactivationTimestamp = value; }
        }

        // Check to see if MembershipDeactivationTimestamp property is set
        internal bool IsSetMembershipDeactivationTimestamp()
        {
            return this._membershipDeactivationTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MembershipId. 
        /// <para>
        /// Response element for GetMembership that provides the queried membership ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=34)]
        public string MembershipId
        {
            get { return this._membershipId; }
            set { this._membershipId = value; }
        }

        // Check to see if MembershipId property is set
        internal bool IsSetMembershipId()
        {
            return this._membershipId != null;
        }

        /// <summary>
        /// Gets and sets the property MembershipName. 
        /// <para>
        /// Response element for GetMembership that provides the configured membership name.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=3, Max=50)]
        public string MembershipName
        {
            get { return this._membershipName; }
            set { this._membershipName = value; }
        }

        // Check to see if MembershipName property is set
        internal bool IsSetMembershipName()
        {
            return this._membershipName != null;
        }

        /// <summary>
        /// Gets and sets the property MembershipStatus. 
        /// <para>
        /// Response element for GetMembership that provides the current membership status.
        /// </para>
        /// </summary>
        public MembershipStatus MembershipStatus
        {
            get { return this._membershipStatus; }
            set { this._membershipStatus = value; }
        }

        // Check to see if MembershipStatus property is set
        internal bool IsSetMembershipStatus()
        {
            return this._membershipStatus != null;
        }

        /// <summary>
        /// Gets and sets the property NumberOfAccountsCovered. 
        /// <para>
        /// Response element for GetMembership that provides the number of accounts in the membership.
        /// </para>
        /// </summary>
        public long? NumberOfAccountsCovered
        {
            get { return this._numberOfAccountsCovered; }
            set { this._numberOfAccountsCovered = value; }
        }

        // Check to see if NumberOfAccountsCovered property is set
        internal bool IsSetNumberOfAccountsCovered()
        {
            return this._numberOfAccountsCovered.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OptInFeatures. 
        /// <para>
        /// Response element for GetMembership that provides the if opt-in features have been
        /// enabled.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public List<OptInFeature> OptInFeatures
        {
            get { return this._optInFeatures; }
            set { this._optInFeatures = value; }
        }

        // Check to see if OptInFeatures property is set
        internal bool IsSetOptInFeatures()
        {
            return this._optInFeatures != null && (this._optInFeatures.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// Response element for GetMembership that provides the region configured to manage the
        /// membership.
        /// </para>
        /// </summary>
        public AwsRegion Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

    }
}