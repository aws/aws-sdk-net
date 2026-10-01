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
    /// Container for the parameters to the BatchUpdateFindings operation. Used by Security
    /// Hub CSPM customers to update information about their investigation into one or more
    /// findings. Requested by administrator accounts or member accounts. Administrator accounts
    /// can update findings for their account and their member accounts. A member account
    /// can update findings only for their own account. Administrator and member accounts
    /// can use this operation to update the following fields and objects for one or more
    /// findings: <ul> <li> <para> <c>Confidence</c> </para> </li> <li> <para> <c>Criticality</c>
    /// </para> </li> <li> <para> <c>Note</c> </para> </li> <li> <para> <c>RelatedFindings</c>
    /// </para> </li> <li> <para> <c>Severity</c> </para> </li> <li> <para> <c>Types</c> </para>
    /// </li> <li> <para> <c>UserDefinedFields</c> </para> </li> <li> <para> <c>VerificationState</c>
    /// </para> </li> <li> <para> <c>Workflow</c> </para> </li> </ul> <para> If you use this
    /// operation to update a finding, your updates don’t affect the value for the <c>UpdatedAt</c>
    /// field of the finding. Also note that it can take several minutes for Security Hub
    /// CSPM to process your request and update each finding specified in the request. </para>
    /// <para> You can configure IAM policies to restrict access to fields and field values.
    /// For example, you might not want member accounts to be able to suppress findings or
    /// change the finding severity. For more information see <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/finding-update-batchupdatefindings.html#batchupdatefindings-configure-access">Configuring
    /// access to BatchUpdateFindings</a> in the <i>Security Hub CSPM User Guide</i>. </para>
    /// </summary>
    public partial class BatchUpdateFindingsRequest : AmazonSecurityHubRequest
    {
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
        [AWSProperty(Min = 0, Max = 100)]
        public int? Confidence { get; set; }

        /// <summary>
        /// Checks to see if the Confidence property is set.
        /// </summary>
        internal bool IsSetConfidence() => this.Confidence.HasValue;

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
        [AWSProperty(Min = 0, Max = 100)]
        public int? Criticality { get; set; }

        /// <summary>
        /// Checks to see if the Criticality property is set.
        /// </summary>
        internal bool IsSetCriticality() => this.Criticality.HasValue;

        /// <summary>
        /// Gets and sets the property FindingIdentifiers. 
        /// <para>
        /// The list of findings to update. <c>BatchUpdateFindings</c> can be used to update up
        /// to 100 findings at a time.
        /// </para>
        ///  
        /// <para>
        /// For each finding, the list provides the finding identifier and the ARN of the finding
        /// provider.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<AwsSecurityFindingIdentifier> FindingIdentifiers { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsSecurityFindingIdentifier>() : null;

        /// <summary>
        /// Checks to see if the FindingIdentifiers property is set.
        /// </summary>
        internal bool IsSetFindingIdentifiers() => this.FindingIdentifiers != null && (this.FindingIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// A list of findings that are related to the updated findings.
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
        /// <para>
        /// Used to update the finding severity.
        /// </para>
        /// </summary>
        public SeverityUpdate Severity { get; set; }

        /// <summary>
        /// Checks to see if the Severity property is set.
        /// </summary>
        internal bool IsSetSeverity() => this.Severity != null;

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
        /// A list of name/value string pairs associated with the finding. These are custom, user-defined
        /// fields added to a finding.
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
        /// Indicates the veracity of a finding.
        /// </para>
        ///  
        /// <para>
        /// The available values for <c>VerificationState</c> are as follows.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>UNKNOWN</c> – The default disposition of a security finding
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TRUE_POSITIVE</c> – The security finding is confirmed
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FALSE_POSITIVE</c> – The security finding was determined to be a false alarm
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BENIGN_POSITIVE</c> – A special case of <c>TRUE_POSITIVE</c> where the finding
        /// doesn't pose any threat, is expected, or both
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public VerificationState VerificationState { get; set; }

        /// <summary>
        /// Checks to see if the VerificationState property is set.
        /// </summary>
        internal bool IsSetVerificationState() => this.VerificationState != null;

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
        public WorkflowUpdate Workflow { get; set; }

        /// <summary>
        /// Checks to see if the Workflow property is set.
        /// </summary>
        internal bool IsSetWorkflow() => this.Workflow != null;
    }
}
