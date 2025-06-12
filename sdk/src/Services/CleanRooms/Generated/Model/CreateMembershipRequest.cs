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
    /// Container for the parameters to the CreateMembership operation.
    /// Creates a membership for a specific collaboration identifier and joins the collaboration.
    /// </summary>
    public partial class CreateMembershipRequest : AmazonCleanRoomsRequest
    {
        private string _collaborationIdentifier;
        private MembershipProtectedJobResultConfiguration _defaultJobResultConfiguration;
        private MembershipProtectedQueryResultConfiguration _defaultResultConfiguration;
        private MembershipJobLogStatus _jobLogStatus;
        private MembershipPaymentConfiguration _paymentConfiguration;
        private MembershipQueryLogStatus _queryLogStatus;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property CollaborationIdentifier. 
        /// <para>
        /// The unique ID for the associated collaboration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string CollaborationIdentifier
        {
            get { return this._collaborationIdentifier; }
            set { this._collaborationIdentifier = value; }
        }

        // Check to see if CollaborationIdentifier property is set
        internal bool IsSetCollaborationIdentifier()
        {
            return this._collaborationIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultJobResultConfiguration. 
        /// <para>
        /// The default job result configuration that determines how job results are protected
        /// and managed within this membership. This configuration applies to all jobs.
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
        public MembershipPaymentConfiguration PaymentConfiguration
        {
            get { return this._paymentConfiguration; }
            set { this._paymentConfiguration = value; }
        }

        // Check to see if PaymentConfiguration property is set
        internal bool IsSetPaymentConfiguration()
        {
            return this._paymentConfiguration != null;
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
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An optional label that you can assign to a resource when you create it. Each tag consists
        /// of a key and an optional value, both of which you define. When you use tagging, you
        /// can also use tag-based access control in IAM policies to control access to this resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}