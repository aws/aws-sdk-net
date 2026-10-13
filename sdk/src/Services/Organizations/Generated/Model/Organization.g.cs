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

namespace Amazon.Organizations.Model
{
    /// <summary>
    /// Contains details about an organization. An organization is a collection of accounts
    /// that are centrally managed together using consolidated billing, organized hierarchically
    /// with organizational units (OUs), and controlled with policies .
    /// </summary>
    public partial class Organization
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an organization.
        /// </para>
        ///  
        /// <para>
        /// For more information about ARNs in Organizations, see <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsorganizations.html#awsorganizations-resources-for-iam-policies">ARN
        /// Formats Supported by Organizations</a> in the <i>Amazon Web Services Service Authorization
        /// Reference</i>.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property AvailablePolicyTypes. <important> 
        /// <para>
        /// Do not use. This field is deprecated and doesn't provide complete information about
        /// the policies in your organization.
        /// </para>
        ///  </important> 
        /// <para>
        /// To determine the policies that are enabled and available for use in your organization,
        /// use the <a>ListRoots</a> operation instead.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PolicyTypeSummary> AvailablePolicyTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<PolicyTypeSummary>() : null;

        /// <summary>
        /// Checks to see if the AvailablePolicyTypes property is set.
        /// </summary>
        internal bool IsSetAvailablePolicyTypes() => this.AvailablePolicyTypes != null && (this.AvailablePolicyTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FeatureSet. 
        /// <para>
        /// Specifies the functionality that currently is available to the organization. If set
        /// to "ALL", then all features are enabled and policies can be applied to accounts in
        /// the organization. If set to "CONSOLIDATED_BILLING", then only consolidated billing
        /// functionality is available. For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_org_support-all-features.html">Enabling
        /// all features in your organization</a> in the <i>Organizations User Guide</i>.
        /// </para>
        /// </summary>
        public OrganizationFeatureSet FeatureSet { get; set; }

        /// <summary>
        /// Checks to see if the FeatureSet property is set.
        /// </summary>
        internal bool IsSetFeatureSet() => this.FeatureSet != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier (ID) of an organization.
        /// </para>
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> for an organization
        /// ID string requires "o-" followed by from 10 to 32 lowercase letters or digits.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property MasterAccountArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the account that is designated as the management
        /// account for the organization.
        /// </para>
        ///  
        /// <para>
        /// For more information about ARNs in Organizations, see <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsorganizations.html#awsorganizations-resources-for-iam-policies">ARN
        /// Formats Supported by Organizations</a> in the <i>Amazon Web Services Service Authorization
        /// Reference</i>.
        /// </para>
        /// </summary>
        public string MasterAccountArn { get; set; }

        /// <summary>
        /// Checks to see if the MasterAccountArn property is set.
        /// </summary>
        internal bool IsSetMasterAccountArn() => this.MasterAccountArn != null;

        /// <summary>
        /// Gets and sets the property MasterAccountEmail. 
        /// <para>
        /// The email address that is associated with the Amazon Web Services account that is
        /// designated as the management account for the organization.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 6, Max = 64)]
        public string MasterAccountEmail { get; set; }

        /// <summary>
        /// Checks to see if the MasterAccountEmail property is set.
        /// </summary>
        internal bool IsSetMasterAccountEmail() => this.MasterAccountEmail != null;

        /// <summary>
        /// Gets and sets the property MasterAccountId. 
        /// <para>
        /// The unique identifier (ID) of the management account of an organization.
        /// </para>
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> for an account ID
        /// string requires exactly 12 digits.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 12)]
        public string MasterAccountId { get; set; }

        /// <summary>
        /// Checks to see if the MasterAccountId property is set.
        /// </summary>
        internal bool IsSetMasterAccountId() => this.MasterAccountId != null;
    }
}
