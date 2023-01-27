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
    /// The file that's used to structure and automate Audit Manager assessments for a given
    /// compliance standard.
    /// </summary>
    public partial class Framework
    {
        private string _arn;
        private string _complianceType;
        private List<ControlSet> _controlSets = new List<ControlSet>();
        private string _controlSources;
        private DateTime? _createdAt;
        private string _createdBy;
        private string _description;
        private string _id;
        private DateTime? _lastUpdatedAt;
        private string _lastUpdatedBy;
        private string _logo;
        private string _name;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private FrameworkType _type;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the framework. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
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
        ///  The control sets that are associated with the framework. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<ControlSet> ControlSets
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
        /// Gets and sets the property ControlSources. 
        /// <para>
        ///  The sources that Audit Manager collects evidence from for the control. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ControlSources
        {
            get { return this._controlSources; }
            set { this._controlSources = value; }
        }

        // Check to see if ControlSources property is set
        internal bool IsSetControlSources()
        {
            return this._controlSources != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        ///  The time when the framework was created. 
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        ///  The IAM user or role that created the framework. 
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
        /// Gets and sets the property Description. 
        /// <para>
        ///  The description of the framework. 
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
        /// Gets and sets the property Id. 
        /// <para>
        ///  The unique identifier for the framework. 
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
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        ///  The time when the framework was most recently updated. 
        /// </para>
        /// </summary>
        public DateTime LastUpdatedAt
        {
            get { return this._lastUpdatedAt.GetValueOrDefault(); }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedBy. 
        /// <para>
        ///  The IAM user or role that most recently updated the framework. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string LastUpdatedBy
        {
            get { return this._lastUpdatedBy; }
            set { this._lastUpdatedBy = value; }
        }

        // Check to see if LastUpdatedBy property is set
        internal bool IsSetLastUpdatedBy()
        {
            return this._lastUpdatedBy != null;
        }

        /// <summary>
        /// Gets and sets the property Logo. 
        /// <para>
        ///  The logo that's associated with the framework. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Logo
        {
            get { return this._logo; }
            set { this._logo = value; }
        }

        // Check to see if Logo property is set
        internal bool IsSetLogo()
        {
            return this._logo != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the framework. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=300)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        ///  The tags that are associated with the framework. 
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

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        ///  The framework type, such as a custom framework or a standard framework. 
        /// </para>
        /// </summary>
        public FrameworkType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}