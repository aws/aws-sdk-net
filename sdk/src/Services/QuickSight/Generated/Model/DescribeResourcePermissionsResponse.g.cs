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
    /// This is the response object from the DescribeResourcePermissions operation.
    /// </summary>
    public partial class DescribeResourcePermissionsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CustomerManagedRoleArn. 
        /// <para>
        /// The ARN of the customer-managed role that Amazon Quick Sight uses for your account.
        /// Amazon Quick Sight returns this value only when <c>RoleType</c> is <c>CUSTOMER_MANAGED</c>.
        /// </para>
        /// </summary>
        public string CustomerManagedRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the CustomerManagedRoleArn property is set.
        /// </summary>
        internal bool IsSetCustomerManagedRoleArn() => this.CustomerManagedRoleArn != null;

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The Amazon Web Services request ID for this operation.
        /// </para>
        /// </summary>
        public string RequestId { get; set; }

        /// <summary>
        /// Checks to see if the RequestId property is set.
        /// </summary>
        internal bool IsSetRequestId() => this.RequestId != null;

        /// <summary>
        /// Gets and sets the property RoleType. 
        /// <para>
        /// The type of service role that Amazon Quick Sight uses for your account.
        /// </para>
        /// </summary>
        public ServiceRoleType RoleType { get; set; }

        /// <summary>
        /// Checks to see if the RoleType property is set.
        /// </summary>
        internal bool IsSetRoleType() => this.RoleType != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The HTTP status of the request.
        /// </para>
        /// </summary>
        public int? Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status.HasValue;
    }
}
