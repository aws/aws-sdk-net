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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Identifies the finding fields that the automation rule action updates when a finding
    /// matches the defined criteria.
    /// </summary>
    public partial class AutomationRulesFindingFieldsUpdate
    {
        /// <summary>
        /// Gets and sets the property Confidence. 
        /// <para>
        ///  The rule action updates the <c>Confidence</c> field of a finding. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public int? Confidence { get; set; }

        /// <summary>
        /// Checks to see if the Confidence property is set.
        /// </summary>
        internal bool IsSetConfidence() => this.Confidence.HasValue;

        /// <summary>
        /// Gets and sets the property Criticality. 
        /// <para>
        ///  The rule action updates the <c>Criticality</c> field of a finding. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public int? Criticality { get; set; }

        /// <summary>
        /// Checks to see if the Criticality property is set.
        /// </summary>
        internal bool IsSetCriticality() => this.Criticality.HasValue;

        /// <summary>
        /// Gets and sets the property Note.
        /// </summary>
        public NoteUpdate Note { get; set; }

        /// <summary>
        /// Checks to see if the Note property is set.
        /// </summary>
        internal bool IsSetNote() => this.Note != null;

        /// <summary>
        /// Gets and sets the property RelatedFindings. 
        /// <para>
        ///  The rule action updates the <c>RelatedFindings</c> field of a finding. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RelatedFinding> RelatedFindings { get; set; } = AWSConfigs.InitializeCollections ? new List<RelatedFinding>() : null;

        /// <summary>
        /// Checks to see if the RelatedFindings property is set.
        /// </summary>
        internal bool IsSetRelatedFindings() => this.RelatedFindings != null && (this.RelatedFindings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Severity.
        /// </summary>
        public SeverityUpdate Severity { get; set; }

        /// <summary>
        /// Checks to see if the Severity property is set.
        /// </summary>
        internal bool IsSetSeverity() => this.Severity != null;

        /// <summary>
        /// Gets and sets the property Types. 
        /// <para>
        ///  The rule action updates the <c>Types</c> field of a finding. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Types { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Types property is set.
        /// </summary>
        internal bool IsSetTypes() => this.Types != null && (this.Types.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UserDefinedFields. 
        /// <para>
        ///  The rule action updates the <c>UserDefinedFields</c> field of a finding. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> UserDefinedFields { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the UserDefinedFields property is set.
        /// </summary>
        internal bool IsSetUserDefinedFields() => this.UserDefinedFields != null && (this.UserDefinedFields.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VerificationState. 
        /// <para>
        ///  The rule action updates the <c>VerificationState</c> field of a finding. 
        /// </para>
        /// </summary>
        public VerificationState VerificationState { get; set; }

        /// <summary>
        /// Checks to see if the VerificationState property is set.
        /// </summary>
        internal bool IsSetVerificationState() => this.VerificationState != null;

        /// <summary>
        /// Gets and sets the property Workflow.
        /// </summary>
        public WorkflowUpdate Workflow { get; set; }

        /// <summary>
        /// Checks to see if the Workflow property is set.
        /// </summary>
        internal bool IsSetWorkflow() => this.Workflow != null;
    }
}
