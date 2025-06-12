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
    /// The membership object.
    /// </summary>
    public partial class Membership
    {
        private string _arn;
        private string _collaborationArn;
        private string _collaborationCreatorAccountId;
        private string _collaborationCreatorDisplayName;
        private string _collaborationId;
        private string _collaborationName;
        private DateTime? _createTime;
        private MembershipProtectedJobResultConfiguration _defaultJobResultConfiguration;
        private MembershipProtectedQueryResultConfiguration _defaultResultConfiguration;
        private string _id;
        private MembershipJobLogStatus _jobLogStatus;
        private List<string> _memberAbilities = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private MLMemberAbilities _mlMemberAbilities;
        private MembershipPaymentConfiguration _paymentConfiguration;
        private MembershipQueryLogStatus _queryLogStatus;
        private MembershipStatus _status;
        private DateTime? _updateTime;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The unique ARN for the membership.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CollaborationArn. 
        /// <para>
        /// The unique ARN for the membership's associated collaboration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public string CollaborationArn
        {
            get { return this._collaborationArn; }
            set { this._collaborationArn = value; }
        }

        // Check to see if CollaborationArn property is set
        internal bool IsSetCollaborationArn()
        {
            return this._collaborationArn != null;
        }

        /// <summary>
        /// Gets and sets the property CollaborationCreatorAccountId. 
        /// <para>
        /// The identifier used to reference members of the collaboration. Currently only supports
        /// Amazon Web Services account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string CollaborationCreatorAccountId
        {
            get { return this._collaborationCreatorAccountId; }
            set { this._collaborationCreatorAccountId = value; }
        }

        // Check to see if CollaborationCreatorAccountId property is set
        internal bool IsSetCollaborationCreatorAccountId()
        {
            return this._collaborationCreatorAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property CollaborationCreatorDisplayName. 
        /// <para>
        /// The display name of the collaboration creator.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string CollaborationCreatorDisplayName
        {
            get { return this._collaborationCreatorDisplayName; }
            set { this._collaborationCreatorDisplayName = value; }
        }

        // Check to see if CollaborationCreatorDisplayName property is set
        internal bool IsSetCollaborationCreatorDisplayName()
        {
            return this._collaborationCreatorDisplayName != null;
        }

        /// <summary>
        /// Gets and sets the property CollaborationId. 
        /// <para>
        /// The unique ID for the membership's collaboration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string CollaborationId
        {
            get { return this._collaborationId; }
            set { this._collaborationId = value; }
        }

        // Check to see if CollaborationId property is set
        internal bool IsSetCollaborationId()
        {
            return this._collaborationId != null;
        }

        /// <summary>
        /// Gets and sets the property CollaborationName. 
        /// <para>
        /// The name of the membership's collaboration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string CollaborationName
        {
            get { return this._collaborationName; }
            set { this._collaborationName = value; }
        }

        // Check to see if CollaborationName property is set
        internal bool IsSetCollaborationName()
        {
            return this._collaborationName != null;
        }

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The time when the membership was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreateTime
        {
            get { return this._createTime; }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultJobResultConfiguration. 
        /// <para>
        ///  The default job result configuration for the membership.
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique ID of the membership.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
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
        /// Gets and sets the property MemberAbilities. 
        /// <para>
        /// The abilities granted to the collaboration member.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> MemberAbilities
        {
            get { return this._memberAbilities; }
            set { this._memberAbilities = value; }
        }

        // Check to see if MemberAbilities property is set
        internal bool IsSetMemberAbilities()
        {
            return this._memberAbilities != null && (this._memberAbilities.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MlMemberAbilities. 
        /// <para>
        /// Specifies the ML member abilities that are granted to a collaboration member.
        /// </para>
        /// </summary>
        public MLMemberAbilities MlMemberAbilities
        {
            get { return this._mlMemberAbilities; }
            set { this._mlMemberAbilities = value; }
        }

        // Check to see if MlMemberAbilities property is set
        internal bool IsSetMlMemberAbilities()
        {
            return this._mlMemberAbilities != null;
        }

        /// <summary>
        /// Gets and sets the property PaymentConfiguration. 
        /// <para>
        /// The payment responsibilities accepted by the collaboration member.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the membership.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MembershipStatus Status
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
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// The time the membership metadata was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdateTime
        {
            get { return this._updateTime; }
            set { this._updateTime = value; }
        }

        // Check to see if UpdateTime property is set
        internal bool IsSetUpdateTime()
        {
            return this._updateTime.HasValue; 
        }

    }
}