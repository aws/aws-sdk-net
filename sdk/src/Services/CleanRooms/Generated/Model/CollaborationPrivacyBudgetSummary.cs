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
    /// A summary of the collaboration privacy budgets. This summary includes the collaboration
    /// information, creation information, epsilon provided, and utility in terms of aggregations.
    /// </summary>
    public partial class CollaborationPrivacyBudgetSummary
    {
        private PrivacyBudget _budget;
        private string _collaborationArn;
        private string _collaborationId;
        private DateTime? _createTime;
        private string _creatorAccountId;
        private string _id;
        private string _privacyBudgetTemplateArn;
        private string _privacyBudgetTemplateId;
        private PrivacyBudgetType _type;
        private DateTime? _updateTime;

        /// <summary>
        /// Gets and sets the property Budget. 
        /// <para>
        /// The includes epsilon provided and utility in terms of aggregations.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PrivacyBudget Budget
        {
            get { return this._budget; }
            set { this._budget = value; }
        }

        // Check to see if Budget property is set
        internal bool IsSetBudget()
        {
            return this._budget != null;
        }

        /// <summary>
        /// Gets and sets the property CollaborationArn. 
        /// <para>
        /// The ARN of the collaboration that includes this privacy budget.
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
        /// The unique identifier of the collaboration that includes this privacy budget.
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
        /// The time at which the privacy budget was created.
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
        /// Gets and sets the property CreatorAccountId. 
        /// <para>
        /// The unique identifier of the account that created this privacy budget.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string CreatorAccountId
        {
            get { return this._creatorAccountId; }
            set { this._creatorAccountId = value; }
        }

        // Check to see if CreatorAccountId property is set
        internal bool IsSetCreatorAccountId()
        {
            return this._creatorAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the collaboration privacy budget.
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
        /// Gets and sets the property PrivacyBudgetTemplateArn. 
        /// <para>
        /// The ARN of the collaboration privacy budget template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public string PrivacyBudgetTemplateArn
        {
            get { return this._privacyBudgetTemplateArn; }
            set { this._privacyBudgetTemplateArn = value; }
        }

        // Check to see if PrivacyBudgetTemplateArn property is set
        internal bool IsSetPrivacyBudgetTemplateArn()
        {
            return this._privacyBudgetTemplateArn != null;
        }

        /// <summary>
        /// Gets and sets the property PrivacyBudgetTemplateId. 
        /// <para>
        /// The unique identifier of the collaboration privacy budget template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string PrivacyBudgetTemplateId
        {
            get { return this._privacyBudgetTemplateId; }
            set { this._privacyBudgetTemplateId = value; }
        }

        // Check to see if PrivacyBudgetTemplateId property is set
        internal bool IsSetPrivacyBudgetTemplateId()
        {
            return this._privacyBudgetTemplateId != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of privacy budget template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PrivacyBudgetType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// The most recent time at which the privacy budget was updated.
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