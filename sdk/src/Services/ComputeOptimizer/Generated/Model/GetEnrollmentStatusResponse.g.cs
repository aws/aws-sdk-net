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

namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// This is the response object from the GetEnrollmentStatus operation.
    /// </summary>
    public partial class GetEnrollmentStatusResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property LastUpdatedTimestamp. 
        /// <para>
        /// The Unix epoch timestamp, in seconds, of when the account enrollment status was last
        /// updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTimestamp property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTimestamp() => this.LastUpdatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property MemberAccountsEnrolled. 
        /// <para>
        /// Confirms the enrollment status of member accounts of the organization, if the account
        /// is a management account of an organization.
        /// </para>
        /// </summary>
        public bool? MemberAccountsEnrolled { get; set; }

        /// <summary>
        /// Checks to see if the MemberAccountsEnrolled property is set.
        /// </summary>
        internal bool IsSetMemberAccountsEnrolled() => this.MemberAccountsEnrolled.HasValue;

        /// <summary>
        /// Gets and sets the property NumberOfMemberAccountsOptedIn. 
        /// <para>
        /// The count of organization member accounts that are opted in to the service, if your
        /// account is an organization management account.
        /// </para>
        /// </summary>
        public int? NumberOfMemberAccountsOptedIn { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfMemberAccountsOptedIn property is set.
        /// </summary>
        internal bool IsSetNumberOfMemberAccountsOptedIn() => this.NumberOfMemberAccountsOptedIn.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The enrollment status of the account.
        /// </para>
        /// </summary>
        public Status Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The reason for the enrollment status of the account.
        /// </para>
        ///  
        /// <para>
        /// For example, an account might show a status of <c>Pending</c> because member accounts
        /// of an organization require more time to be enrolled in the service.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;
    }
}
