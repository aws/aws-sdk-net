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
    /// Container for the parameters to the CreateMembership operation. Creates a membership
    /// for a specific collaboration identifier and joins the collaboration.
    /// </summary>
    public partial class CreateMembershipRequest : AmazonCleanRoomsRequest
    {
        /// <summary>
        /// Gets and sets the property CollaborationIdentifier. 
        /// <para>
        /// The unique ID for the associated collaboration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string CollaborationIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the CollaborationIdentifier property is set.
        /// </summary>
        internal bool IsSetCollaborationIdentifier() => this.CollaborationIdentifier != null;

        /// <summary>
        /// Gets and sets the property DefaultJobResultConfiguration. 
        /// <para>
        /// The default job result configuration that determines how job results are protected
        /// and managed within this membership. This configuration applies to all jobs.
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
        /// Gets and sets the property IsMetricsEnabled. 
        /// <para>
        /// An indicator as to whether Amazon CloudWatch metrics have been enabled or disabled
        /// for the membership.
        /// </para>
        ///  
        /// <para>
        /// Amazon CloudWatch metrics are only available when the collaboration has metrics enabled.
        /// This option can be set by collaboration members who have the ability to run queries
        /// (analysis runners) or by members who are configured as payers.
        /// </para>
        ///  
        /// <para>
        /// When <c>true</c>, metrics about query execution are collected in Amazon CloudWatch.
        /// The default value is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? IsMetricsEnabled { get; set; }

        /// <summary>
        /// Checks to see if the IsMetricsEnabled property is set.
        /// </summary>
        internal bool IsSetIsMetricsEnabled() => this.IsMetricsEnabled.HasValue;

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
        /// Gets and sets the property PaymentConfiguration. 
        /// <para>
        /// The payment responsibilities accepted by the collaboration member.
        /// </para>
        ///  
        /// <para>
        /// Not required if the collaboration member has the member ability to run queries. 
        /// </para>
        ///  
        /// <para>
        /// Required if the collaboration member doesn't have the member ability to run queries
        /// but is configured as a payer by the collaboration creator. 
        /// </para>
        /// </summary>
        public MembershipPaymentConfiguration PaymentConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the PaymentConfiguration property is set.
        /// </summary>
        internal bool IsSetPaymentConfiguration() => this.PaymentConfiguration != null;

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
        [AWSProperty(Required = true)]
        public MembershipQueryLogStatus QueryLogStatus { get; set; }

        /// <summary>
        /// Checks to see if the QueryLogStatus property is set.
        /// </summary>
        internal bool IsSetQueryLogStatus() => this.QueryLogStatus != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An optional label that you can assign to a resource when you create it. Each tag consists
        /// of a key and an optional value, both of which you define. When you use tagging, you
        /// can also use tag-based access control in IAM policies to control access to this resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
