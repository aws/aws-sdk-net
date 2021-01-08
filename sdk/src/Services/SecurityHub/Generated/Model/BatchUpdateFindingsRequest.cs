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
    /// Container for the parameters to the BatchUpdateFindings operation.
    /// Used by Security Hub customers to update information about their investigation into
    /// a finding. Requested by master accounts or member accounts. Master accounts can update
    /// findings for their account and their member accounts. Member accounts can update findings
    /// for their account.
    /// 
    ///  
    /// <para>
    /// Updates from <code>BatchUpdateFindings</code> do not affect the value of <code>UpdatedAt</code>
    /// for a finding.
    /// </para>
    ///  
    /// <para>
    /// Master and member accounts can use <code>BatchUpdateFindings</code> to update the
    /// following finding fields and objects.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>Confidence</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Criticality</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Note</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>RelatedFindings</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Severity</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Types</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>UserDefinedFields</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>VerificationState</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Workflow</code> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You can configure IAM policies to restrict access to fields and field values. For
    /// example, you might not want member accounts to be able to suppress findings or change
    /// the finding severity. See <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/finding-update-batchupdatefindings.html#batchupdatefindings-configure-access">Configuring
    /// access to BatchUpdateFindings</a> in the <i>AWS Security Hub User Guide</i>.
    /// </para>
    /// </summary>
    public partial class BatchUpdateFindingsRequest : AmazonSecurityHubRequest
    {
        private int? _confidence;
        private int? _criticality;
        private List<AwsSecurityFindingIdentifier> _findingIdentifiers = new List<AwsSecurityFindingIdentifier>();
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
        /// The updated value for the finding confidence. Confidence is defined as the likelihood
        /// that a finding accurately identifies the behavior or issue that it was intended to
        /// identify.
        /// </para>
        ///  
        /// <para>
        /// Confidence is scored on a 0-100 basis using a ratio scale, where 0 means zero percent
        /// confidence and 100 means 100 percent confidence.
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
        /// The updated value for the level of importance assigned to the resources associated
        /// with the findings.
        /// </para>
        ///  
        /// <para>
        /// A score of 0 means that the underlying resources have no criticality, and a score
        /// of 100 is reserved for the most critical resources. 
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
        /// Gets and sets the property FindingIdentifiers. 
        /// <para>
        /// The list of findings to update. <code>BatchUpdateFindings</code> can be used to update
        /// up to 100 findings at a time.
        /// </para>
        ///  
        /// <para>
        /// For each finding, the list provides the finding identifier and the ARN of the finding
        /// provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AwsSecurityFindingIdentifier> FindingIdentifiers
        {
            get { return this._findingIdentifiers; }
            set { this._findingIdentifiers = value; }
        }

        // Check to see if FindingIdentifiers property is set
        internal bool IsSetFindingIdentifiers()
        {
            return this._findingIdentifiers != null && this._findingIdentifiers.Count > 0; 
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
        /// A list of findings that are related to the updated findings.
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
        /// <para>
        /// Used to update the finding severity.
        /// </para>
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
        /// One or more finding types in the format of namespace/category/classifier that classify
        /// a finding.
        /// </para>
        ///  
        /// <para>
        /// Valid namespace values are as follows.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Software and Configuration Checks
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// TTPs
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Effects
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Unusual Behaviors
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Sensitive Data Identifications 
        /// </para>
        ///  </li> </ul>
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
        /// A list of name/value string pairs associated with the finding. These are custom, user-defined
        /// fields added to a finding.
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
        /// Indicates the veracity of a finding.
        /// </para>
        ///  
        /// <para>
        /// The available values for <code>VerificationState</code> are as follows.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>UNKNOWN</code> – The default disposition of a security finding
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TRUE_POSITIVE</code> – The security finding is confirmed
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FALSE_POSITIVE</code> – The security finding was determined to be a false alarm
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>BENIGN_POSITIVE</code> – A special case of <code>TRUE_POSITIVE</code> where
        /// the finding doesn't pose any threat, is expected, or both
        /// </para>
        ///  </li> </ul>
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
        /// <para>
        /// Used to update the workflow status of a finding.
        /// </para>
        ///  
        /// <para>
        /// The workflow status indicates the progress of the investigation into the finding.
        /// 
        /// </para>
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