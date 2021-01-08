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
    /// Container for the parameters to the UpdateAssessment operation.
    /// Edits an AWS Audit Manager assessment.
    /// </summary>
    public partial class UpdateAssessmentRequest : AmazonAuditManagerRequest
    {
        private string _assessmentDescription;
        private string _assessmentId;
        private string _assessmentName;
        private AssessmentReportsDestination _assessmentReportsDestination;
        private List<Role> _roles = new List<Role>();
        private Scope _scope;

        /// <summary>
        /// Gets and sets the property AssessmentDescription. 
        /// <para>
        ///  The description of the specified assessment. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=1000)]
        public string AssessmentDescription
        {
            get { return this._assessmentDescription; }
            set { this._assessmentDescription = value; }
        }

        // Check to see if AssessmentDescription property is set
        internal bool IsSetAssessmentDescription()
        {
            return this._assessmentDescription != null;
        }

        /// <summary>
        /// Gets and sets the property AssessmentId. 
        /// <para>
        ///  The identifier for the specified assessment. 
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
        /// Gets and sets the property AssessmentName. 
        /// <para>
        ///  The name of the specified assessment to be updated. 
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
        /// Gets and sets the property AssessmentReportsDestination. 
        /// <para>
        ///  The assessment report storage destination for the specified assessment that is being
        /// updated. 
        /// </para>
        /// </summary>
        public AssessmentReportsDestination AssessmentReportsDestination
        {
            get { return this._assessmentReportsDestination; }
            set { this._assessmentReportsDestination = value; }
        }

        // Check to see if AssessmentReportsDestination property is set
        internal bool IsSetAssessmentReportsDestination()
        {
            return this._assessmentReportsDestination != null;
        }

        /// <summary>
        /// Gets and sets the property Roles. 
        /// <para>
        ///  The list of roles for the specified assessment. 
        /// </para>
        /// </summary>
        public List<Role> Roles
        {
            get { return this._roles; }
            set { this._roles = value; }
        }

        // Check to see if Roles property is set
        internal bool IsSetRoles()
        {
            return this._roles != null && this._roles.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        ///  The scope of the specified assessment. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Scope Scope
        {
            get { return this._scope; }
            set { this._scope = value; }
        }

        // Check to see if Scope property is set
        internal bool IsSetScope()
        {
            return this._scope != null;
        }

    }
}