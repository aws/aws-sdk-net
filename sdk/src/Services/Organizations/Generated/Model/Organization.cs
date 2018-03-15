/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the organizations-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Organizations.Model
{
    /// <summary>
    /// Contains details about an organization. An organization is a collection of accounts
    /// that are centrally managed together using consolidated billing, organized hierarchically
    /// with organizational units (OUs), and controlled with policies .
    /// </summary>
    public partial class Organization
    {
        private string _arn;
        private List<PolicyTypeSummary> _availablePolicyTypes = new List<PolicyTypeSummary>();
        private OrganizationFeatureSet _featureSet;
        private string _id;
        private string _masterAccountArn;
        private string _masterAccountEmail;
        private string _masterAccountId;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an organization.
        /// </para>
        ///  
        /// <para>
        /// For more information about ARNs in Organizations, see <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_permissions.html#orgs-permissions-arns">ARN
        /// Formats Supported by Organizations</a> in the <i>AWS Organizations User Guide</i>.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property AvailablePolicyTypes. 
        /// <para>
        /// A list of policy types that are enabled for this organization. For example, if your
        /// organization has all features enabled, then service control policies (SCPs) are included
        /// in the list.
        /// </para>
        ///  <note> 
        /// <para>
        /// Even if a policy type is shown as available in the organization, you can separately
        /// enable and disable them at the root level by using <a>EnablePolicyType</a> and <a>DisablePolicyType</a>.
        /// Use <a>ListRoots</a> to see the status of a policy type in that root.
        /// </para>
        ///  </note>
        /// </summary>
        public List<PolicyTypeSummary> AvailablePolicyTypes
        {
            get { return this._availablePolicyTypes; }
            set { this._availablePolicyTypes = value; }
        }

        // Check to see if AvailablePolicyTypes property is set
        internal bool IsSetAvailablePolicyTypes()
        {
            return this._availablePolicyTypes != null && this._availablePolicyTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FeatureSet. 
        /// <para>
        /// Specifies the functionality that currently is available to the organization. If set
        /// to "ALL", then all features are enabled and policies can be applied to accounts in
        /// the organization. If set to "CONSOLIDATED_BILLING", then only consolidated billing
        /// functionality is available. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/orgs_manage_org_support-all-features.html">Enabling
        /// All Features in Your Organization</a> in the <i>AWS Organizations User Guide</i>.
        /// </para>
        /// </summary>
        public OrganizationFeatureSet FeatureSet
        {
            get { return this._featureSet; }
            set { this._featureSet = value; }
        }

        // Check to see if FeatureSet property is set
        internal bool IsSetFeatureSet()
        {
            return this._featureSet != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier (ID) of an organization.
        /// </para>
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> for an organization
        /// ID string requires "o-" followed by from 10 to 32 lower-case letters or digits.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property MasterAccountArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the account that is designated as the master account
        /// for the organization.
        /// </para>
        ///  
        /// <para>
        /// For more information about ARNs in Organizations, see <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_permissions.html#orgs-permissions-arns">ARN
        /// Formats Supported by Organizations</a> in the <i>AWS Organizations User Guide</i>.
        /// </para>
        /// </summary>
        public string MasterAccountArn
        {
            get { return this._masterAccountArn; }
            set { this._masterAccountArn = value; }
        }

        // Check to see if MasterAccountArn property is set
        internal bool IsSetMasterAccountArn()
        {
            return this._masterAccountArn != null;
        }

        /// <summary>
        /// Gets and sets the property MasterAccountEmail. 
        /// <para>
        /// The email address that is associated with the AWS account that is designated as the
        /// master account for the organization.
        /// </para>
        /// </summary>
        public string MasterAccountEmail
        {
            get { return this._masterAccountEmail; }
            set { this._masterAccountEmail = value; }
        }

        // Check to see if MasterAccountEmail property is set
        internal bool IsSetMasterAccountEmail()
        {
            return this._masterAccountEmail != null;
        }

        /// <summary>
        /// Gets and sets the property MasterAccountId. 
        /// <para>
        /// The unique identifier (ID) of the master account of an organization.
        /// </para>
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> for an account ID
        /// string requires exactly 12 digits.
        /// </para>
        /// </summary>
        public string MasterAccountId
        {
            get { return this._masterAccountId; }
            set { this._masterAccountId = value; }
        }

        // Check to see if MasterAccountId property is set
        internal bool IsSetMasterAccountId()
        {
            return this._masterAccountId != null;
        }

    }
}