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
    /// Container for the parameters to the CreateAssessment operation.
    /// Creates an assessment in AWS Audit Manager.
    /// </summary>
    public partial class CreateAssessmentRequest : AmazonAuditManagerRequest
    {
        private AssessmentReportsDestination _assessmentReportsDestination;
        private string _description;
        private string _frameworkId;
        private string _name;
        private List<Role> _roles = new List<Role>();
        private Scope _scope;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property AssessmentReportsDestination. 
        /// <para>
        ///  The assessment report storage destination for the specified assessment that is being
        /// created. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Description. 
        /// <para>
        ///  The optional description of the assessment to be created. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=1000)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property FrameworkId. 
        /// <para>
        ///  The identifier for the specified framework. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string FrameworkId
        {
            get { return this._frameworkId; }
            set { this._frameworkId = value; }
        }

        // Check to see if FrameworkId property is set
        internal bool IsSetFrameworkId()
        {
            return this._frameworkId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the assessment to be created. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=300)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Roles. 
        /// <para>
        ///  The list of roles for the specified assessment. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  The tags associated with the assessment. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}