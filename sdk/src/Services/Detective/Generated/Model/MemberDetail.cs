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
 * Do not modify this file. This file is generated from the detective-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Detective.Model
{
    /// <summary>
    /// Details about a member account that was invited to contribute to a behavior graph.
    /// </summary>
    public partial class MemberDetail
    {
        private string _accountId;
        private MemberDisabledReason _disabledReason;
        private string _emailAddress;
        private string _graphArn;
        private DateTime? _invitedTime;
        private string _masterId;
        private double? _percentOfGraphUtilization;
        private DateTime? _percentOfGraphUtilizationUpdatedTime;
        private MemberStatus _status;
        private DateTime? _updatedTime;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The AWS account identifier for the member account.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property DisabledReason. 
        /// <para>
        /// For member accounts with a status of <code>ACCEPTED_BUT_DISABLED</code>, the reason
        /// that the member account is not enabled.
        /// </para>
        ///  
        /// <para>
        /// The reason can have one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>VOLUME_TOO_HIGH</code> - Indicates that adding the member account would cause
        /// the data volume for the behavior graph to be too high.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>VOLUME_UNKNOWN</code> - Indicates that Detective is unable to verify the data
        /// volume for the member account. This is usually because the member account is not enrolled
        /// in Amazon GuardDuty. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public MemberDisabledReason DisabledReason
        {
            get { return this._disabledReason; }
            set { this._disabledReason = value; }
        }

        // Check to see if DisabledReason property is set
        internal bool IsSetDisabledReason()
        {
            return this._disabledReason != null;
        }

        /// <summary>
        /// Gets and sets the property EmailAddress. 
        /// <para>
        /// The AWS account root user email address for the member account.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string EmailAddress
        {
            get { return this._emailAddress; }
            set { this._emailAddress = value; }
        }

        // Check to see if EmailAddress property is set
        internal bool IsSetEmailAddress()
        {
            return this._emailAddress != null;
        }

        /// <summary>
        /// Gets and sets the property GraphArn. 
        /// <para>
        /// The ARN of the behavior graph that the member account was invited to.
        /// </para>
        /// </summary>
        public string GraphArn
        {
            get { return this._graphArn; }
            set { this._graphArn = value; }
        }

        // Check to see if GraphArn property is set
        internal bool IsSetGraphArn()
        {
            return this._graphArn != null;
        }

        /// <summary>
        /// Gets and sets the property InvitedTime. 
        /// <para>
        /// The date and time that Detective sent the invitation to the member account. The value
        /// is in milliseconds since the epoch.
        /// </para>
        /// </summary>
        public DateTime InvitedTime
        {
            get { return this._invitedTime.GetValueOrDefault(); }
            set { this._invitedTime = value; }
        }

        // Check to see if InvitedTime property is set
        internal bool IsSetInvitedTime()
        {
            return this._invitedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MasterId. 
        /// <para>
        /// The AWS account identifier of the master account for the behavior graph.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string MasterId
        {
            get { return this._masterId; }
            set { this._masterId = value; }
        }

        // Check to see if MasterId property is set
        internal bool IsSetMasterId()
        {
            return this._masterId != null;
        }

        /// <summary>
        /// Gets and sets the property PercentOfGraphUtilization. 
        /// <para>
        /// The member account data volume as a percentage of the maximum allowed data volume.
        /// 0 indicates 0 percent, and 100 indicates 100 percent.
        /// </para>
        ///  
        /// <para>
        /// Note that this is not the percentage of the behavior graph data volume.
        /// </para>
        ///  
        /// <para>
        /// For example, the data volume for the behavior graph is 80 GB per day. The maximum
        /// data volume is 160 GB per day. If the data volume for the member account is 40 GB
        /// per day, then <code>PercentOfGraphUtilization</code> is 25. It represents 25% of the
        /// maximum allowed data volume. 
        /// </para>
        /// </summary>
        public double PercentOfGraphUtilization
        {
            get { return this._percentOfGraphUtilization.GetValueOrDefault(); }
            set { this._percentOfGraphUtilization = value; }
        }

        // Check to see if PercentOfGraphUtilization property is set
        internal bool IsSetPercentOfGraphUtilization()
        {
            return this._percentOfGraphUtilization.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PercentOfGraphUtilizationUpdatedTime. 
        /// <para>
        /// The date and time when the graph utilization percentage was last updated.
        /// </para>
        /// </summary>
        public DateTime PercentOfGraphUtilizationUpdatedTime
        {
            get { return this._percentOfGraphUtilizationUpdatedTime.GetValueOrDefault(); }
            set { this._percentOfGraphUtilizationUpdatedTime = value; }
        }

        // Check to see if PercentOfGraphUtilizationUpdatedTime property is set
        internal bool IsSetPercentOfGraphUtilizationUpdatedTime()
        {
            return this._percentOfGraphUtilizationUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current membership status of the member account. The status can have one of the
        /// following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>INVITED</code> - Indicates that the member was sent an invitation but has not
        /// yet responded.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>VERIFICATION_IN_PROGRESS</code> - Indicates that Detective is verifying that
        /// the account identifier and email address provided for the member account match. If
        /// they do match, then Detective sends the invitation. If the email address and account
        /// identifier don't match, then the member cannot be added to the behavior graph.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>VERIFICATION_FAILED</code> - Indicates that the account and email address provided
        /// for the member account do not match, and Detective did not send an invitation to the
        /// account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ENABLED</code> - Indicates that the member account accepted the invitation
        /// to contribute to the behavior graph.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ACCEPTED_BUT_DISABLED</code> - Indicates that the member account accepted the
        /// invitation but is prevented from contributing data to the behavior graph. <code>DisabledReason</code>
        /// provides the reason why the member account is not enabled.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Member accounts that declined an invitation or that were removed from the behavior
        /// graph are not included.
        /// </para>
        /// </summary>
        public MemberStatus Status
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
        /// Gets and sets the property UpdatedTime. 
        /// <para>
        /// The date and time that the member account was last updated. The value is in milliseconds
        /// since the epoch.
        /// </para>
        /// </summary>
        public DateTime UpdatedTime
        {
            get { return this._updatedTime.GetValueOrDefault(); }
            set { this._updatedTime = value; }
        }

        // Check to see if UpdatedTime property is set
        internal bool IsSetUpdatedTime()
        {
            return this._updatedTime.HasValue; 
        }

    }
}