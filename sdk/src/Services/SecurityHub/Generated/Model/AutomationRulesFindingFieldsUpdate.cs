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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Identifies the finding fields that the automation rule action will update when a
    /// finding matches the defined criteria.
    /// </summary>
    public partial class AutomationRulesFindingFieldsUpdate
    {
        private int? _confidence;
        private int? _criticality;
        private NoteUpdate _note;
        private List<RelatedFinding> _relatedFindings = new List<RelatedFinding>();
        private SeverityUpdate _severity;
        private List<string> _types = new List<string>();
        private Dictionary<string, string> _userDefinedFields = new Dictionary<string, string>();
        private VerificationState _verificationState;
        private WorkflowUpdate _workflow;

        /// <summary>
        /// Gets and sets the property Confidence. 
        /// <para>
        ///  The rule action will update the <code>Confidence</code> field of a finding. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int Confidence
        {
            get { return this._confidence.GetValueOrDefault(); }
            set { this._confidence = value; }
        }

        // Check to see if Confidence property is set
        internal bool IsSetConfidence()
        {
            return this._confidence.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Criticality. 
        /// <para>
        ///  The rule action will update the <code>Criticality</code> field of a finding. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int Criticality
        {
            get { return this._criticality.GetValueOrDefault(); }
            set { this._criticality = value; }
        }

        // Check to see if Criticality property is set
        internal bool IsSetCriticality()
        {
            return this._criticality.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Note.
        /// </summary>
        public NoteUpdate Note
        {
            get { return this._note; }
            set { this._note = value; }
        }

        // Check to see if Note property is set
        internal bool IsSetNote()
        {
            return this._note != null;
        }

        /// <summary>
        /// Gets and sets the property RelatedFindings. 
        /// <para>
        ///  A list of findings that are related to a finding. 
        /// </para>
        /// </summary>
        public List<RelatedFinding> RelatedFindings
        {
            get { return this._relatedFindings; }
            set { this._relatedFindings = value; }
        }

        // Check to see if RelatedFindings property is set
        internal bool IsSetRelatedFindings()
        {
            return this._relatedFindings != null && this._relatedFindings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Severity.
        /// </summary>
        public SeverityUpdate Severity
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
        /// Gets and sets the property Types. 
        /// <para>
        ///  The rule action will update the <code>Types</code> field of a finding. 
        /// </para>
        /// </summary>
        public List<string> Types
        {
            get { return this._types; }
            set { this._types = value; }
        }

        // Check to see if Types property is set
        internal bool IsSetTypes()
        {
            return this._types != null && this._types.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UserDefinedFields. 
        /// <para>
        ///  The rule action will update the <code>UserDefinedFields</code> field of a finding.
        /// 
        /// </para>
        /// </summary>
        public Dictionary<string, string> UserDefinedFields
        {
            get { return this._userDefinedFields; }
            set { this._userDefinedFields = value; }
        }

        // Check to see if UserDefinedFields property is set
        internal bool IsSetUserDefinedFields()
        {
            return this._userDefinedFields != null && this._userDefinedFields.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VerificationState. 
        /// <para>
        ///  The rule action will update the <code>VerificationState</code> field of a finding.
        /// 
        /// </para>
        /// </summary>
        public VerificationState VerificationState
        {
            get { return this._verificationState; }
            set { this._verificationState = value; }
        }

        // Check to see if VerificationState property is set
        internal bool IsSetVerificationState()
        {
            return this._verificationState != null;
        }

        /// <summary>
        /// Gets and sets the property Workflow.
        /// </summary>
        public WorkflowUpdate Workflow
        {
            get { return this._workflow; }
            set { this._workflow = value; }
        }

        // Check to see if Workflow property is set
        internal bool IsSetWorkflow()
        {
            return this._workflow != null;
        }

    }
}