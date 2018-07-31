/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// The findings (results) of the audit.
    /// </summary>
    public partial class AuditFinding
    {
        private string _checkName;
        private DateTime? _findingTime;
        private NonCompliantResource _nonCompliantResource;
        private string _reasonForNonCompliance;
        private string _reasonForNonComplianceCode;
        private List<RelatedResource> _relatedResources = new List<RelatedResource>();
        private AuditFindingSeverity _severity;
        private string _taskId;
        private DateTime? _taskStartTime;

        /// <summary>
        /// Gets and sets the property CheckName. 
        /// <para>
        /// The audit check that generated this result.
        /// </para>
        /// </summary>
        public string CheckName
        {
            get { return this._checkName; }
            set { this._checkName = value; }
        }

        // Check to see if CheckName property is set
        internal bool IsSetCheckName()
        {
            return this._checkName != null;
        }

        /// <summary>
        /// Gets and sets the property FindingTime. 
        /// <para>
        /// The time the result (finding) was discovered.
        /// </para>
        /// </summary>
        public DateTime FindingTime
        {
            get { return this._findingTime.GetValueOrDefault(); }
            set { this._findingTime = value; }
        }

        // Check to see if FindingTime property is set
        internal bool IsSetFindingTime()
        {
            return this._findingTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NonCompliantResource. 
        /// <para>
        /// The resource that was found to be non-compliant with the audit check.
        /// </para>
        /// </summary>
        public NonCompliantResource NonCompliantResource
        {
            get { return this._nonCompliantResource; }
            set { this._nonCompliantResource = value; }
        }

        // Check to see if NonCompliantResource property is set
        internal bool IsSetNonCompliantResource()
        {
            return this._nonCompliantResource != null;
        }

        /// <summary>
        /// Gets and sets the property ReasonForNonCompliance. 
        /// <para>
        /// The reason the resource was non-compliant.
        /// </para>
        /// </summary>
        public string ReasonForNonCompliance
        {
            get { return this._reasonForNonCompliance; }
            set { this._reasonForNonCompliance = value; }
        }

        // Check to see if ReasonForNonCompliance property is set
        internal bool IsSetReasonForNonCompliance()
        {
            return this._reasonForNonCompliance != null;
        }

        /// <summary>
        /// Gets and sets the property ReasonForNonComplianceCode. 
        /// <para>
        /// A code which indicates the reason that the resource was non-compliant.
        /// </para>
        /// </summary>
        public string ReasonForNonComplianceCode
        {
            get { return this._reasonForNonComplianceCode; }
            set { this._reasonForNonComplianceCode = value; }
        }

        // Check to see if ReasonForNonComplianceCode property is set
        internal bool IsSetReasonForNonComplianceCode()
        {
            return this._reasonForNonComplianceCode != null;
        }

        /// <summary>
        /// Gets and sets the property RelatedResources. 
        /// <para>
        /// The list of related resources.
        /// </para>
        /// </summary>
        public List<RelatedResource> RelatedResources
        {
            get { return this._relatedResources; }
            set { this._relatedResources = value; }
        }

        // Check to see if RelatedResources property is set
        internal bool IsSetRelatedResources()
        {
            return this._relatedResources != null && this._relatedResources.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// The severity of the result (finding).
        /// </para>
        /// </summary>
        public AuditFindingSeverity Severity
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
        /// Gets and sets the property TaskId. 
        /// <para>
        /// The ID of the audit that generated this result (finding)
        /// </para>
        /// </summary>
        public string TaskId
        {
            get { return this._taskId; }
            set { this._taskId = value; }
        }

        // Check to see if TaskId property is set
        internal bool IsSetTaskId()
        {
            return this._taskId != null;
        }

        /// <summary>
        /// Gets and sets the property TaskStartTime. 
        /// <para>
        /// The time the audit started.
        /// </para>
        /// </summary>
        public DateTime TaskStartTime
        {
            get { return this._taskStartTime.GetValueOrDefault(); }
            set { this._taskStartTime = value; }
        }

        // Check to see if TaskStartTime property is set
        internal bool IsSetTaskStartTime()
        {
            return this._taskStartTime.HasValue; 
        }

    }
}