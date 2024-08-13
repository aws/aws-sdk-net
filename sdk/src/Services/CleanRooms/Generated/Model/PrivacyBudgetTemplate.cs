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
    /// An object that defines the privacy budget template.
    /// </summary>
    public partial class PrivacyBudgetTemplate
    {
        private string _arn;
        private PrivacyBudgetTemplateAutoRefresh _autoRefresh;
        private string _collaborationArn;
        private string _collaborationId;
        private DateTime? _createTime;
        private string _id;
        private string _membershipArn;
        private string _membershipId;
        private PrivacyBudgetTemplateParametersOutput _parameters;
        private PrivacyBudgetType _privacyBudgetType;
        private DateTime? _updateTime;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the privacy budget template.
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
        /// Gets and sets the property AutoRefresh. 
        /// <para>
        /// How often the privacy budget refreshes.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you plan to regularly bring new data into the collaboration, use <c>CALENDAR_MONTH</c>
        /// to automatically get a new privacy budget for the collaboration every calendar month.
        /// Choosing this option allows arbitrary amounts of information to be revealed about
        /// rows of the data when repeatedly queried across refreshes. Avoid choosing this if
        /// the same rows will be repeatedly queried between privacy budget refreshes.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required=true)]
        public PrivacyBudgetTemplateAutoRefresh AutoRefresh
        {
            get { return this._autoRefresh; }
            set { this._autoRefresh = value; }
        }

        // Check to see if AutoRefresh property is set
        internal bool IsSetAutoRefresh()
        {
            return this._autoRefresh != null;
        }

        /// <summary>
        /// Gets and sets the property CollaborationArn. 
        /// <para>
        /// The ARN of the collaboration that contains this privacy budget template.
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
        /// Gets and sets the property CollaborationId. 
        /// <para>
        /// The unique ID of the collaboration that contains this privacy budget template.
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
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The time at which the privacy budget template was created.
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the privacy budget template.
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
        /// Gets and sets the property MembershipArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the member who created the privacy budget template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public string MembershipArn
        {
            get { return this._membershipArn; }
            set { this._membershipArn = value; }
        }

        // Check to see if MembershipArn property is set
        internal bool IsSetMembershipArn()
        {
            return this._membershipArn != null;
        }

        /// <summary>
        /// Gets and sets the property MembershipId. 
        /// <para>
        /// The identifier for a membership resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string MembershipId
        {
            get { return this._membershipId; }
            set { this._membershipId = value; }
        }

        // Check to see if MembershipId property is set
        internal bool IsSetMembershipId()
        {
            return this._membershipId != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// Specifies the epsilon and noise parameters for the privacy budget template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PrivacyBudgetTemplateParametersOutput Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null;
        }

        /// <summary>
        /// Gets and sets the property PrivacyBudgetType. 
        /// <para>
        /// Specifies the type of the privacy budget template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PrivacyBudgetType PrivacyBudgetType
        {
            get { return this._privacyBudgetType; }
            set { this._privacyBudgetType = value; }
        }

        // Check to see if PrivacyBudgetType property is set
        internal bool IsSetPrivacyBudgetType()
        {
            return this._privacyBudgetType != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// The most recent time at which the privacy budget template was updated.
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