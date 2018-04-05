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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Information about the compliance as defined by the resource type. For example, for
    /// a patch resource type, <code>Items</code> includes information about the PatchSeverity,
    /// Classification, etc.
    /// </summary>
    public partial class ComplianceItem
    {
        private string _complianceType;
        private Dictionary<string, string> _details = new Dictionary<string, string>();
        private ComplianceExecutionSummary _executionSummary;
        private string _id;
        private string _resourceId;
        private string _resourceType;
        private ComplianceSeverity _severity;
        private ComplianceStatus _status;
        private string _title;

        /// <summary>
        /// Gets and sets the property ComplianceType. 
        /// <para>
        /// The compliance type. For example, Association (for a State Manager association), Patch,
        /// or Custom:<code>string</code> are all valid compliance types.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Details. 
        /// <para>
        /// A "Key": "Value" tag combination for the compliance item.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Details
        {
            get { return this._details; }
            set { this._details = value; }
        }

        // Check to see if Details property is set
        internal bool IsSetDetails()
        {
            return this._details != null && this._details.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ExecutionSummary. 
        /// <para>
        /// A summary for the compliance item. The summary includes an execution ID, the execution
        /// type (for example, command), and the execution time.
        /// </para>
        /// </summary>
        public ComplianceExecutionSummary ExecutionSummary
        {
            get { return this._executionSummary; }
            set { this._executionSummary = value; }
        }

        // Check to see if ExecutionSummary property is set
        internal bool IsSetExecutionSummary()
        {
            return this._executionSummary != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// An ID for the compliance item. For example, if the compliance item is a Windows patch,
        /// the ID could be the number of the KB article; for example: KB4010320.
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
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// An ID for the resource. For a managed instance, this is the instance ID.
        /// </para>
        /// </summary>
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource. <code>ManagedInstance</code> is currently the only supported
        /// resource type.
        /// </para>
        /// </summary>
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// The severity of the compliance status. Severity can be one of the following: Critical,
        /// High, Medium, Low, Informational, Unspecified.
        /// </para>
        /// </summary>
        public ComplianceSeverity Severity
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
        /// The status of the compliance item. An item is either COMPLIANT or NON_COMPLIANT.
        /// </para>
        /// </summary>
        public ComplianceStatus Status
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
        /// A title for the compliance item. For example, if the compliance item is a Windows
        /// patch, the title could be the title of the KB article for the patch; for example:
        /// Security Update for Active Directory Federation Services.
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

    }
}