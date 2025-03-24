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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateMembership operation.
    /// Updates a membership.
    /// </summary>
    public partial class UpdateMembershipRequest : AmazonCleanRoomsRequest
    {
        private MembershipProtectedJobResultConfiguration _defaultJobResultConfiguration;
        private MembershipProtectedQueryResultConfiguration _defaultResultConfiguration;
        private MembershipJobLogStatus _jobLogStatus;
        private string _membershipIdentifier;
        private MembershipQueryLogStatus _queryLogStatus;

        /// <summary>
        /// Gets and sets the property DefaultJobResultConfiguration. 
        /// <para>
        ///  The default job result configuration.
        /// </para>
        /// </summary>
        public MembershipProtectedJobResultConfiguration DefaultJobResultConfiguration
        {
            get { return this._defaultJobResultConfiguration; }
            set { this._defaultJobResultConfiguration = value; }
        }

        // Check to see if DefaultJobResultConfiguration property is set
        internal bool IsSetDefaultJobResultConfiguration()
        {
            return this._defaultJobResultConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultResultConfiguration. 
        /// <para>
        /// The default protected query result configuration as specified by the member who can
        /// receive results.
        /// </para>
        /// </summary>
        public MembershipProtectedQueryResultConfiguration DefaultResultConfiguration
        {
            get { return this._defaultResultConfiguration; }
            set { this._defaultResultConfiguration = value; }
        }

        // Check to see if DefaultResultConfiguration property is set
        internal bool IsSetDefaultResultConfiguration()
        {
            return this._defaultResultConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property JobLogStatus. 
        /// <para>
        /// An indicator as to whether job logging has been enabled or disabled for the collaboration.
        /// 
        /// </para>
        ///  
        /// <para>
        /// When <c>ENABLED</c>, Clean Rooms logs details about jobs run within this collaboration
        /// and those logs can be viewed in Amazon CloudWatch Logs. The default value is <c>DISABLED</c>.
        /// </para>
        /// </summary>
        public MembershipJobLogStatus JobLogStatus
        {
            get { return this._jobLogStatus; }
            set { this._jobLogStatus = value; }
        }

        // Check to see if JobLogStatus property is set
        internal bool IsSetJobLogStatus()
        {
            return this._jobLogStatus != null;
        }

        /// <summary>
        /// Gets and sets the property MembershipIdentifier. 
        /// <para>
        /// The unique identifier of the membership.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string MembershipIdentifier
        {
            get { return this._membershipIdentifier; }
            set { this._membershipIdentifier = value; }
        }

        // Check to see if MembershipIdentifier property is set
        internal bool IsSetMembershipIdentifier()
        {
            return this._membershipIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property QueryLogStatus. 
        /// <para>
        /// An indicator as to whether query logging has been enabled or disabled for the membership.
        /// </para>
        ///  
        /// <para>
        /// When <c>ENABLED</c>, Clean Rooms logs details about queries run within this collaboration
        /// and those logs can be viewed in Amazon CloudWatch Logs. The default value is <c>DISABLED</c>.
        /// </para>
        /// </summary>
        public MembershipQueryLogStatus QueryLogStatus
        {
            get { return this._queryLogStatus; }
            set { this._queryLogStatus = value; }
        }

        // Check to see if QueryLogStatus property is set
        internal bool IsSetQueryLogStatus()
        {
            return this._queryLogStatus != null;
        }

    }
}