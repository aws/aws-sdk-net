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
 * Do not modify this file. This file is generated from the auditmanager-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// The assignment of a control set to a delegate for review.
    /// </summary>
    public partial class Delegation
    {
        private string _assessmentId;
        private string _assessmentName;
        private string _comment;
        private string _controlSetId;
        private string _createdBy;
        private DateTime? _creationTime;
        private string _id;
        private DateTime? _lastUpdated;
        private string _roleArn;
        private RoleType _roleType;
        private DelegationStatus _status;

        /// <summary>
        /// Gets and sets the property AssessmentId. 
        /// <para>
        ///  The identifier for the assessment that's associated with the delegation. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string AssessmentId
        {
            get { return this._assessmentId; }
            set { this._assessmentId = value; }
        }

        // Check to see if AssessmentId property is set
        internal bool IsSetAssessmentId()
        {
            return this._assessmentId != null;
        }

        /// <summary>
        /// Gets and sets the property AssessmentName. 
        /// <para>
        ///  The name of the assessment that's associated with the delegation. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=300)]
        public string AssessmentName
        {
            get { return this._assessmentName; }
            set { this._assessmentName = value; }
        }

        // Check to see if AssessmentName property is set
        internal bool IsSetAssessmentName()
        {
            return this._assessmentName != null;
        }

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        ///  The comment that's related to the delegation. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=350)]
        public string Comment
        {
            get { return this._comment; }
            set { this._comment = value; }
        }

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this._comment != null;
        }

        /// <summary>
        /// Gets and sets the property ControlSetId. 
        /// <para>
        ///  The identifier for the control set that's associated with the delegation. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=300)]
        public string ControlSetId
        {
            get { return this._controlSetId; }
            set { this._controlSetId = value; }
        }

        // Check to see if ControlSetId property is set
        internal bool IsSetControlSetId()
        {
            return this._controlSetId != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        ///  The user or role that created the delegation. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        ///  Specifies when the delegation was created. 
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  The unique identifier for the delegation. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
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
        /// Gets and sets the property LastUpdated. 
        /// <para>
        ///  Specifies when the delegation was last updated. 
        /// </para>
        /// </summary>
        public DateTime LastUpdated
        {
            get { return this._lastUpdated.GetValueOrDefault(); }
            set { this._lastUpdated = value; }
        }

        // Check to see if LastUpdated property is set
        internal bool IsSetLastUpdated()
        {
            return this._lastUpdated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the IAM role. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property RoleType. 
        /// <para>
        ///  The type of customer persona. 
        /// </para>
        ///  <note> 
        /// <para>
        /// In <code>CreateAssessment</code>, <code>roleType</code> can only be <code>PROCESS_OWNER</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// In <code>UpdateSettings</code>, <code>roleType</code> can only be <code>PROCESS_OWNER</code>.
        /// </para>
        ///  
        /// <para>
        /// In <code>BatchCreateDelegationByAssessment</code>, <code>roleType</code> can only
        /// be <code>RESOURCE_OWNER</code>.
        /// </para>
        ///  </note>
        /// </summary>
        public RoleType RoleType
        {
            get { return this._roleType; }
            set { this._roleType = value; }
        }

        // Check to see if RoleType property is set
        internal bool IsSetRoleType()
        {
            return this._roleType != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of the delegation. 
        /// </para>
        /// </summary>
        public DelegationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}