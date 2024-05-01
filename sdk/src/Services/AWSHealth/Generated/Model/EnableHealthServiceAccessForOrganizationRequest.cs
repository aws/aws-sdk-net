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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.AWSHealth.Model
{
    /// <summary>
    /// Container for the parameters to the EnableHealthServiceAccessForOrganization operation.
    /// Enables Health to work with Organizations. You can use the organizational view feature
    /// to aggregate events from all Amazon Web Services accounts in your organization in
    /// a centralized location. 
    /// 
    ///  
    /// <para>
    /// This operation also creates a service-linked role for the management account in the
    /// organization. 
    /// </para>
    ///  <note> 
    /// <para>
    /// To call this operation, you must meet the following requirements:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You must have a Business, Enterprise On-Ramp, or Enterprise Support plan from <a href="http://aws.amazon.com/premiumsupport/">Amazon
    /// Web Services Support</a> to use the Health API. If you call the Health API from an
    /// Amazon Web Services account that doesn't have a Business, Enterprise On-Ramp, or Enterprise
    /// Support plan, you receive a <c>SubscriptionRequiredException</c> error.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You must have permission to call this operation from the organization's management
    /// account. For example IAM policies, see <a href="https://docs.aws.amazon.com/health/latest/ug/security_iam_id-based-policy-examples.html">Health
    /// identity-based policy examples</a>.
    /// </para>
    ///  </li> </ul> </note> 
    /// <para>
    /// If you don't have the required support plan, you can instead use the Health console
    /// to enable the organizational view feature. For more information, see <a href="https://docs.aws.amazon.com/health/latest/ug/aggregate-events.html">Aggregating
    /// Health events</a> in the <i>Health User Guide</i>.
    /// </para>
    /// </summary>
    public partial class EnableHealthServiceAccessForOrganizationRequest : AmazonAWSHealthRequest
    {

    }
}