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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
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
namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the GenerateServiceLastAccessedDetails operation.
    /// Generates a report that includes details about when an IAM resource (user, group,
    /// role, or policy) was last used in an attempt to access Amazon Web Services services.
    /// Recent activity usually appears within four hours. IAM reports activity for at least
    /// the last 400 days, or less if your Region began supporting this feature within the
    /// last year. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_access-advisor.html#access-advisor_tracking-period">Regions
    /// where data is tracked</a>. For more information about services and actions for which
    /// action last accessed information is displayed, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_access-advisor-action-last-accessed.html">IAM
    /// action last accessed information services and actions</a>.
    /// 
    ///  <important> 
    /// <para>
    /// The service last accessed data includes all attempts to access an Amazon Web Services
    /// API, not just the successful ones. This includes all attempts that were made using
    /// the Amazon Web Services Management Console, the Amazon Web Services API through any
    /// of the SDKs, or any of the command line tools. An unexpected entry in the service
    /// last accessed data does not mean that your account has been compromised, because the
    /// request might have been denied. Refer to your CloudTrail logs as the authoritative
    /// source for information about all API calls and whether they were successful or denied
    /// access. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/cloudtrail-integration.html">Logging
    /// IAM events with CloudTrail</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  </important> 
    /// <para>
    /// The <c>GenerateServiceLastAccessedDetails</c> operation returns a <c>JobId</c>. Use
    /// this parameter in the following operations to retrieve the following details from
    /// your report: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetServiceLastAccessedDetails.html">GetServiceLastAccessedDetails</a>
    /// – Use this operation for users, groups, roles, or policies to list every Amazon Web
    /// Services service that the resource could access using permissions policies. For each
    /// service, the response includes information about the most recent access attempt.
    /// </para>
    ///  
    /// <para>
    /// The <c>JobId</c> returned by <c>GenerateServiceLastAccessedDetail</c> must be used
    /// by the same role within a session, or by the same user when used to call <c>GetServiceLastAccessedDetail</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetServiceLastAccessedDetailsWithEntities.html">GetServiceLastAccessedDetailsWithEntities</a>
    /// – Use this operation for groups and policies to list information about the associated
    /// entities (users or roles) that attempted to access a specific Amazon Web Services
    /// service. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To check the status of the <c>GenerateServiceLastAccessedDetails</c> request, use
    /// the <c>JobId</c> parameter in the same operations and test the <c>JobStatus</c> response
    /// parameter.
    /// </para>
    ///  
    /// <para>
    /// For additional information about the permissions policies that allow an identity (user,
    /// group, or role) to access specific services, use the <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ListPoliciesGrantingServiceAccess.html">ListPoliciesGrantingServiceAccess</a>
    /// operation.
    /// </para>
    ///  <note> 
    /// <para>
    /// Service last accessed data does not use other policy types when determining whether
    /// a resource could access a service. These other policy types include resource-based
    /// policies, access control lists, Organizations policies, IAM permissions boundaries,
    /// and STS assume role policies. It only applies permissions policy logic. For more about
    /// the evaluation of policy types, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_evaluation-logic.html#policy-eval-basics">Evaluating
    /// policies</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  </note> 
    /// <para>
    /// For more information about service and action last accessed data, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_access-advisor.html">Reducing
    /// permissions using service last accessed data</a> in the <i>IAM User Guide</i>.
    /// </para>
    /// </summary>
    public partial class GenerateServiceLastAccessedDetailsRequest : AmazonIdentityManagementServiceRequest
    {
        private string _arn;
        private AccessAdvisorUsageGranularityType _granularity;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the IAM resource (user, group, role, or managed policy) used to generate
        /// information about when the resource was last used in an attempt to access an Amazon
        /// Web Services service.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
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
        /// Gets and sets the property Granularity. 
        /// <para>
        /// The level of detail that you want to generate. You can specify whether you want to
        /// generate information about the last attempt to access services or actions. If you
        /// specify service-level granularity, this operation generates only service data. If
        /// you specify action-level granularity, it generates service and action data. If you
        /// don't include this optional parameter, the operation generates service data.
        /// </para>
        /// </summary>
        public AccessAdvisorUsageGranularityType Granularity
        {
            get { return this._granularity; }
            set { this._granularity = value; }
        }

        // Check to see if Granularity property is set
        internal bool IsSetGranularity()
        {
            return this._granularity != null;
        }

    }
}