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
    /// Container for the parameters to the UpdateAssessmentFramework operation.
    /// Updates a custom framework in AWS Audit Manager.
    /// </summary>
    public partial class UpdateAssessmentFrameworkRequest : AmazonAuditManagerRequest
    {
        private string _complianceType;
        private List<UpdateAssessmentFrameworkControlSet> _controlSets = new List<UpdateAssessmentFrameworkControlSet>();
        private string _description;
        private string _frameworkId;
        private string _name;

        /// <summary>
        /// Gets and sets the property ComplianceType. 
        /// <para>
        ///  The compliance type that the new custom framework supports, such as CIS or HIPAA.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public string ComplianceType
        {
            get { return this._complianceType; }
            set { this._complianceType = value; }
        }

        // Check to see if ComplianceType property is set
        internal bool IsSetComplianceType()
        {
            return this._complianceType != null;
        }

        /// <summary>
        /// Gets and sets the property ControlSets. 
        /// <para>
        ///  The control sets associated with the framework. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<UpdateAssessmentFrameworkControlSet> ControlSets
        {
            get { return this._controlSets; }
            set { this._controlSets = value; }
        }

        // Check to see if ControlSets property is set
        internal bool IsSetControlSets()
        {
            return this._controlSets != null && this._controlSets.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  The description of the framework that is to be updated. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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
        ///  The name of the framework to be updated. 
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

    }
}