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

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateMembership operation. Updates a membership.
    /// </summary>
    public partial class UpdateMembershipRequest : AmazonCleanRoomsRequest
    {
        /// <summary>
        /// Gets and sets the property DefaultJobResultConfiguration. 
        /// <para>
        ///  The default job result configuration.
        /// </para>
        /// </summary>
        public MembershipProtectedJobResultConfiguration DefaultJobResultConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DefaultJobResultConfiguration property is set.
        /// </summary>
        internal bool IsSetDefaultJobResultConfiguration() => this.DefaultJobResultConfiguration != null;

        /// <summary>
        /// Gets and sets the property DefaultResultConfiguration. 
        /// <para>
        /// The default protected query result configuration as specified by the member who can
        /// receive results.
        /// </para>
        /// </summary>
        public MembershipProtectedQueryResultConfiguration DefaultResultConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DefaultResultConfiguration property is set.
        /// </summary>
        internal bool IsSetDefaultResultConfiguration() => this.DefaultResultConfiguration != null;

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
        public MembershipJobLogStatus JobLogStatus { get; set; }

        /// <summary>
        /// Checks to see if the JobLogStatus property is set.
        /// </summary>
        internal bool IsSetJobLogStatus() => this.JobLogStatus != null;

        /// <summary>
        /// Gets and sets the property MembershipIdentifier. 
        /// <para>
        /// The unique identifier of the membership.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string MembershipIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the MembershipIdentifier property is set.
        /// </summary>
        internal bool IsSetMembershipIdentifier() => this.MembershipIdentifier != null;

        /// <summary>
        /// Gets and sets the property MembershipPaymentConfiguration. 
        /// <para>
        /// The payment configuration to update for the membership.
        /// </para>
        /// </summary>
        public UpdateMembershipPaymentConfiguration MembershipPaymentConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the MembershipPaymentConfiguration property is set.
        /// </summary>
        internal bool IsSetMembershipPaymentConfiguration() => this.MembershipPaymentConfiguration != null;

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
        public MembershipQueryLogStatus QueryLogStatus { get; set; }

        /// <summary>
        /// Checks to see if the QueryLogStatus property is set.
        /// </summary>
        internal bool IsSetQueryLogStatus() => this.QueryLogStatus != null;
    }
}
