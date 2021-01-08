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
 * Do not modify this file. This file is generated from the health-2016-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AWSHealth.Model
{
    /// <summary>
    /// Container for the parameters to the DisableHealthServiceAccessForOrganization operation.
    /// Disables AWS Health from working with AWS Organizations. To call this operation, you
    /// must sign in as an AWS Identity and Access Management (IAM) user, assume an IAM role,
    /// or sign in as the root user (not recommended) in the organization's master AWS account.
    /// For more information, see <a href="https://docs.aws.amazon.com/health/latest/ug/aggregate-events.html">Aggregating
    /// AWS Health events</a> in the <i>AWS Health User Guide</i>.
    /// 
    ///  
    /// <para>
    /// This operation doesn't remove the service-linked role (SLR) from the AWS master account
    /// in your organization. You must use the IAM console, API, or AWS Command Line Interface
    /// (AWS CLI) to remove the SLR. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/using-service-linked-roles.html#delete-service-linked-role">Deleting
    /// a Service-Linked Role</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// You can also disable the organizational feature by using the Organizations <a href="https://docs.aws.amazon.com/organizations/latest/APIReference/API_DisableAWSServiceAccess.html">DisableAWSServiceAccess</a>
    /// API operation. After you call this operation, AWS Health stops aggregating events
    /// for all other AWS accounts in your organization. If you call the AWS Health API operations
    /// for organizational view, AWS Health returns an error. AWS Health continues to aggregate
    /// health events for your AWS account.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DisableHealthServiceAccessForOrganizationRequest : AmazonAWSHealthRequest
    {

    }
}