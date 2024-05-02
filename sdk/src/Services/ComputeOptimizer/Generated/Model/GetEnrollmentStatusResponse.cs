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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
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
        private DateTime? _lastUpdatedTimestamp;
        private bool? _memberAccountsEnrolled;
        private int? _numberOfMemberAccountsOptedIn;
        private Status _status;
        private string _statusReason;

        /// <summary>
        /// Gets and sets the property LastUpdatedTimestamp. 
        /// <para>
        /// The Unix epoch timestamp, in seconds, of when the account enrollment status was last
        /// updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTimestamp
        {
            get { return this._lastUpdatedTimestamp; }
            set { this._lastUpdatedTimestamp = value; }
        }

        // Check to see if LastUpdatedTimestamp property is set
        internal bool IsSetLastUpdatedTimestamp()
        {
            return this._lastUpdatedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MemberAccountsEnrolled. 
        /// <para>
        /// Confirms the enrollment status of member accounts of the organization, if the account
        /// is a management account of an organization.
        /// </para>
        /// </summary>
        public bool? MemberAccountsEnrolled
        {
            get { return this._memberAccountsEnrolled; }
            set { this._memberAccountsEnrolled = value; }
        }

        // Check to see if MemberAccountsEnrolled property is set
        internal bool IsSetMemberAccountsEnrolled()
        {
            return this._memberAccountsEnrolled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfMemberAccountsOptedIn. 
        /// <para>
        /// The count of organization member accounts that are opted in to the service, if your
        /// account is an organization management account.
        /// </para>
        /// </summary>
        public int? NumberOfMemberAccountsOptedIn
        {
            get { return this._numberOfMemberAccountsOptedIn; }
            set { this._numberOfMemberAccountsOptedIn = value; }
        }

        // Check to see if NumberOfMemberAccountsOptedIn property is set
        internal bool IsSetNumberOfMemberAccountsOptedIn()
        {
            return this._numberOfMemberAccountsOptedIn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The enrollment status of the account.
        /// </para>
        /// </summary>
        public Status Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

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
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

    }
}