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
 * Do not modify this file. This file is generated from the codeguru-security-2018-05-10.normal.json service model.
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
namespace Amazon.CodeGuruSecurity.Model
{
    /// <summary>
    /// Information about a finding that was detected in your code.
    /// </summary>
    public partial class Finding
    {
        private DateTime? _createdAt;
        private string _description;
        private string _detectorId;
        private string _detectorName;
        private List<string> _detectorTags = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _generatorId;
        private string _id;
        private Remediation _remediation;
        private Resource _resource;
        private string _ruleId;
        private Severity _severity;
        private Status _status;
        private string _title;
        private string _type;
        private DateTime? _updatedAt;
        private Vulnerability _vulnerability;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time when the finding was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the finding.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property DetectorId. 
        /// <para>
        /// The identifier for the detector that detected the finding in your code. A detector
        /// is a defined rule based on industry standards and AWS best practices. 
        /// </para>
        /// </summary>
        public string DetectorId
        {
            get { return this._detectorId; }
            set { this._detectorId = value; }
        }

        // Check to see if DetectorId property is set
        internal bool IsSetDetectorId()
        {
            return this._detectorId != null;
        }

        /// <summary>
        /// Gets and sets the property DetectorName. 
        /// <para>
        /// The name of the detector that identified the security vulnerability in your code.
        /// 
        /// </para>
        /// </summary>
        public string DetectorName
        {
            get { return this._detectorName; }
            set { this._detectorName = value; }
        }

        // Check to see if DetectorName property is set
        internal bool IsSetDetectorName()
        {
            return this._detectorName != null;
        }

        /// <summary>
        /// Gets and sets the property DetectorTags. 
        /// <para>
        /// One or more tags or categorizations that are associated with a detector. These tags
        /// are defined by type, programming language, or other classification such as maintainability
        /// or consistency.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DetectorTags
        {
            get { return this._detectorTags; }
            set { this._detectorTags = value; }
        }

        // Check to see if DetectorTags property is set
        internal bool IsSetDetectorTags()
        {
            return this._detectorTags != null && (this._detectorTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property GeneratorId. 
        /// <para>
        /// The identifier for the component that generated a finding such as AmazonCodeGuruSecurity.
        /// </para>
        /// </summary>
        public string GeneratorId
        {
            get { return this._generatorId; }
            set { this._generatorId = value; }
        }

        // Check to see if GeneratorId property is set
        internal bool IsSetGeneratorId()
        {
            return this._generatorId != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier for a finding.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Remediation. 
        /// <para>
        /// An object that contains the details about how to remediate a finding.
        /// </para>
        /// </summary>
        public Remediation Remediation
        {
            get { return this._remediation; }
            set { this._remediation = value; }
        }

        // Check to see if Remediation property is set
        internal bool IsSetRemediation()
        {
            return this._remediation != null;
        }

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// The resource where Amazon CodeGuru Security detected a finding.
        /// </para>
        /// </summary>
        public Resource Resource
        {
            get { return this._resource; }
            set { this._resource = value; }
        }

        // Check to see if Resource property is set
        internal bool IsSetResource()
        {
            return this._resource != null;
        }

        /// <summary>
        /// Gets and sets the property RuleId. 
        /// <para>
        /// The identifier for the rule that generated the finding.
        /// </para>
        /// </summary>
        public string RuleId
        {
            get { return this._ruleId; }
            set { this._ruleId = value; }
        }

        // Check to see if RuleId property is set
        internal bool IsSetRuleId()
        {
            return this._ruleId != null;
        }

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// The severity of the finding. Severity can be critical, high, medium, low, or informational.
        /// For information on severity levels, see <a href="https://docs.aws.amazon.com/codeguru/latest/security-ug/findings-overview.html#severity-distribution">Finding
        /// severity</a> in the <i>Amazon CodeGuru Security User Guide</i>.
        /// </para>
        /// </summary>
        public Severity Severity
        {
            get { return this._severity; }
            set { this._severity = value; }
        }

        // Check to see if Severity property is set
        internal bool IsSetSeverity()
        {
            return this._severity != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the finding. A finding status can be open or closed. 
        /// </para>
        /// </summary>
        public Status Status
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
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the finding.
        /// </para>
        /// </summary>
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of finding. 
        /// </para>
        /// </summary>
        public string Type
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
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The time when the finding was last updated. Findings are updated when you remediate
        /// them or when the finding code location changes. 
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Vulnerability. 
        /// <para>
        /// An object that describes the detected security vulnerability.
        /// </para>
        /// </summary>
        public Vulnerability Vulnerability
        {
            get { return this._vulnerability; }
            set { this._vulnerability = value; }
        }

        // Check to see if Vulnerability property is set
        internal bool IsSetVulnerability()
        {
            return this._vulnerability != null;
        }

    }
}