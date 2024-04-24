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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateAssessmentControl operation.
    /// Updates a control within an assessment in Audit Manager.
    /// </summary>
    public partial class UpdateAssessmentControlRequest : AmazonAuditManagerRequest
    {
        private string _assessmentId;
        private string _commentBody;
        private string _controlId;
        private string _controlSetId;
        private ControlStatus _controlStatus;

        /// <summary>
        /// Gets and sets the property AssessmentId. 
        /// <para>
        ///  The unique identifier for the assessment. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
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
        /// Gets and sets the property CommentBody. 
        /// <para>
        ///  The comment body text for the control. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=500)]
        public string CommentBody
        {
            get { return this._commentBody; }
            set { this._commentBody = value; }
        }

        // Check to see if CommentBody property is set
        internal bool IsSetCommentBody()
        {
            return this._commentBody != null;
        }

        /// <summary>
        /// Gets and sets the property ControlId. 
        /// <para>
        ///  The unique identifier for the control. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string ControlId
        {
            get { return this._controlId; }
            set { this._controlId = value; }
        }

        // Check to see if ControlId property is set
        internal bool IsSetControlId()
        {
            return this._controlId != null;
        }

        /// <summary>
        /// Gets and sets the property ControlSetId. 
        /// <para>
        ///  The unique identifier for the control set. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=300)]
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
        /// Gets and sets the property ControlStatus. 
        /// <para>
        ///  The status of the control. 
        /// </para>
        /// </summary>
        public ControlStatus ControlStatus
        {
            get { return this._controlStatus; }
            set { this._controlStatus = value; }
        }

        // Check to see if ControlStatus property is set
        internal bool IsSetControlStatus()
        {
            return this._controlStatus != null;
        }

    }
}