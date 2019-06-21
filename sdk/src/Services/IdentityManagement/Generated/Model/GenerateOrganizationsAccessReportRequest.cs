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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the GenerateOrganizationsAccessReport operation.
    /// Generates a report for service last accessed data for AWS Organizations. You can generate
    /// a report for any entities (organization root, organizational unit, or account) or
    /// policies in your organization.
    /// 
    ///  
    /// <para>
    /// To call this operation, you must be signed in using your AWS Organizations master
    /// account credentials. You can use your long-term IAM user or root user credentials,
    /// or temporary credentials from assuming an IAM role. SCPs must be enabled for your
    /// organization root. You must have the required IAM and AWS Organizations permissions.
    /// For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_access-advisor.html">Refining
    /// Permissions Using Service Last Accessed Data</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// You can generate a service last accessed data report for entities by specifying only
    /// the entity's path. This data includes a list of services that are allowed by any service
    /// control policies (SCPs) that apply to the entity.
    /// </para>
    ///  
    /// <para>
    /// You can generate a service last accessed data report for a policy by specifying an
    /// entity's path and an optional AWS Organizations policy ID. This data includes a list
    /// of services that are allowed by the specified SCP.
    /// </para>
    ///  
    /// <para>
    /// For each service in both report types, the data includes the most recent account activity
    /// that the policy allows to account principals in the entity or the entity's children.
    /// For important information about the data, reporting period, permissions required,
    /// troubleshooting, and supported Regions see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_access-advisor.html">Reducing
    /// Permissions Using Service Last Accessed Data</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  <important> 
    /// <para>
    /// The data includes all attempts to access AWS, not just the successful ones. This includes
    /// all attempts that were made using the AWS Management Console, the AWS API through
    /// any of the SDKs, or any of the command line tools. An unexpected entry in the service
    /// last accessed data does not mean that an account has been compromised, because the
    /// request might have been denied. Refer to your CloudTrail logs as the authoritative
    /// source for information about all API calls and whether they were successful or denied
    /// access. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/cloudtrail-integration.html">Logging
    /// IAM Events with CloudTrail</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  </important> 
    /// <para>
    /// This operation returns a <code>JobId</code>. Use this parameter in the <code> <a>GetOrganizationsAccessReport</a>
    /// </code> operation to check the status of the report generation. To check the status
    /// of this request, use the <code>JobId</code> parameter in the <code> <a>GetOrganizationsAccessReport</a>
    /// </code> operation and test the <code>JobStatus</code> response parameter. When the
    /// job is complete, you can retrieve the report.
    /// </para>
    ///  
    /// <para>
    /// To generate a service last accessed data report for entities, specify an entity path
    /// without specifying the optional AWS Organizations policy ID. The type of entity that
    /// you specify determines the data returned in the report.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Root</b> – When you specify the organizations root as the entity, the resulting
    /// report lists all of the services allowed by SCPs that are attached to your root. For
    /// each service, the report includes data for all accounts in your organization except
    /// the master account, because the master account is not limited by SCPs.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>OU</b> – When you specify an organizational unit (OU) as the entity, the resulting
    /// report lists all of the services allowed by SCPs that are attached to the OU and its
    /// parents. For each service, the report includes data for all accounts in the OU or
    /// its children. This data excludes the master account, because the master account is
    /// not limited by SCPs.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Master account</b> – When you specify the master account, the resulting report
    /// lists all AWS services, because the master account is not limited by SCPs. For each
    /// service, the report includes data for only the master account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Account</b> – When you specify another account as the entity, the resulting report
    /// lists all of the services allowed by SCPs that are attached to the account and its
    /// parents. For each service, the report includes data for only the specified account.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To generate a service last accessed data report for policies, specify an entity path
    /// and the optional AWS Organizations policy ID. The type of entity that you specify
    /// determines the data returned for each service.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Root</b> – When you specify the root entity and a policy ID, the resulting report
    /// lists all of the services that are allowed by the specified SCP. For each service,
    /// the report includes data for all accounts in your organization to which the SCP applies.
    /// This data excludes the master account, because the master account is not limited by
    /// SCPs. If the SCP is not attached to any entities in the organization, then the report
    /// will return a list of services with no data.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>OU</b> – When you specify an OU entity and a policy ID, the resulting report lists
    /// all of the services that are allowed by the specified SCP. For each service, the report
    /// includes data for all accounts in the OU or its children to which the SCP applies.
    /// This means that other accounts outside the OU that are affected by the SCP might not
    /// be included in the data. This data excludes the master account, because the master
    /// account is not limited by SCPs. If the SCP is not attached to the OU or one of its
    /// children, the report will return a list of services with no data.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Master account</b> – When you specify the master account, the resulting report
    /// lists all AWS services, because the master account is not limited by SCPs. If you
    /// specify a policy ID in the CLI or API, the policy is ignored. For each service, the
    /// report includes data for only the master account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Account</b> – When you specify another account entity and a policy ID, the resulting
    /// report lists all of the services that are allowed by the specified SCP. For each service,
    /// the report includes data for only the specified account. This means that other accounts
    /// in the organization that are affected by the SCP might not be included in the data.
    /// If the SCP is not attached to the account, the report will return a list of services
    /// with no data.
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// Service last accessed data does not use other policy types when determining whether
    /// a principal could access a service. These other policy types include identity-based
    /// policies, resource-based policies, access control lists, IAM permissions boundaries,
    /// and STS assume role policies. It only applies SCP logic. For more about the evaluation
    /// of policy types, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_evaluation-logic.html#policy-eval-basics">Evaluating
    /// Policies</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  </note> 
    /// <para>
    /// For more information about service last accessed data, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_access-advisor.html">Reducing
    /// Policy Scope by Viewing User Activity</a> in the <i>IAM User Guide</i>.
    /// </para>
    /// </summary>
    public partial class GenerateOrganizationsAccessReportRequest : AmazonIdentityManagementServiceRequest
    {
        private string _entityPath;
        private string _organizationsPolicyId;

        /// <summary>
        /// Gets and sets the property EntityPath. 
        /// <para>
        /// The path of the AWS Organizations entity (root, OU, or account). You can build an
        /// entity path using the known structure of your organization. For example, assume that
        /// your account ID is <code>123456789012</code> and its parent OU ID is <code>ou-rge0-awsabcde</code>.
        /// The organization root ID is <code>r-f6g7h8i9j0example</code> and your organization
        /// ID is <code>o-a1b2c3d4e5</code>. Your entity path is <code>o-a1b2c3d4e5/r-f6g7h8i9j0example/ou-rge0-awsabcde/123456789012</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=19, Max=427)]
        public string EntityPath
        {
            get { return this._entityPath; }
            set { this._entityPath = value; }
        }

        // Check to see if EntityPath property is set
        internal bool IsSetEntityPath()
        {
            return this._entityPath != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationsPolicyId. 
        /// <para>
        /// The identifier of the AWS Organizations service control policy (SCP). This parameter
        /// is optional.
        /// </para>
        ///  
        /// <para>
        /// This ID is used to generate information about when an account principal that is limited
        /// by the SCP attempted to access an AWS service.
        /// </para>
        /// </summary>
        public string OrganizationsPolicyId
        {
            get { return this._organizationsPolicyId; }
            set { this._organizationsPolicyId = value; }
        }

        // Check to see if OrganizationsPolicyId property is set
        internal bool IsSetOrganizationsPolicyId()
        {
            return this._organizationsPolicyId != null;
        }

    }
}