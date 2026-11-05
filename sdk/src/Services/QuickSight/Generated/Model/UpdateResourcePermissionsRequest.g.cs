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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateResourcePermissions operation. Updates the
    /// service role configuration that Amazon Quick Sight uses to access resources in your
    /// Amazon Web Services account. To use this operation, you must have the <c>quicksight:UpdateResourcePermissions</c>
    /// and <c>iam:PassRole</c> permissions. <para> Call this operation in the Amazon Web
    /// Services Region where your Amazon Quick Sight account is registered (the home Region).
    /// You can switch from a role managed by Amazon Quick Sight to a customer-managed role,
    /// or replace one customer-managed role with another. You can't use this operation to
    /// switch back to a role managed by Amazon Quick Sight. </para>
    /// </summary>
    public partial class UpdateResourcePermissionsRequest : AmazonQuickSightRequest
    {
        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account whose service role configuration you want
        /// to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;

        /// <summary>
        /// Gets and sets the property CustomerManagedRoleArn. 
        /// <para>
        /// The ARN of the customer-managed role that you want Amazon Quick Sight to use. To use
        /// this operation, you must have the <c>iam:PassRole</c> permission for the role.
        /// </para>
        ///  
        /// <para>
        /// Configure the role as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The role must belong to the Amazon Web Services account specified by <c>AwsAccountId</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Configure the role trust policy to allow the Amazon Quick Sight service principal
        /// to call <c>sts:AssumeRole</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Attach a permissions policy that allows access to the resources that you want Amazon
        /// Quick Sight to use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To use features that rely on session tags, configure the role trust policy to allow
        /// the Amazon Quick Sight service principal to call <c>sts:TagSession</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the role doesn't exist or its trust policy doesn't allow <c>sts:AssumeRole</c>,
        /// the request returns an <c>AccessDeniedException</c>.
        /// </para>
        ///  
        /// <para>
        /// When you call this operation, Amazon Quick Sight attempts to assume the role with
        /// session tags and records whether the attempt succeeds. If you later add or remove
        /// <c>sts:TagSession</c> from the trust policy, call this operation again with the same
        /// role ARN to refresh the stored capability.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string CustomerManagedRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the CustomerManagedRoleArn property is set.
        /// </summary>
        internal bool IsSetCustomerManagedRoleArn() => this.CustomerManagedRoleArn != null;

        /// <summary>
        /// Gets and sets the property RoleType. 
        /// <para>
        /// The type of service role that you want Amazon Quick Sight to use. The only supported
        /// value for this operation is <c>CUSTOMER_MANAGED</c>. Requests that specify <c>QUICKSIGHT_MANAGED</c>
        /// are rejected.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ServiceRoleType RoleType { get; set; }

        /// <summary>
        /// Checks to see if the RoleType property is set.
        /// </summary>
        internal bool IsSetRoleType() => this.RoleType != null;
    }
}
