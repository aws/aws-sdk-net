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

namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// A record that contains the information needed to demonstrate compliance with the
    /// requirements specified by a control. Examples of evidence include change activity
    /// invoked by a user, or a system configuration snapshot.
    /// </summary>
    public partial class Evidence
    {
        /// <summary>
        /// Gets and sets the property AssessmentReportSelection. 
        /// <para>
        ///  Specifies whether the evidence is included in the assessment report. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string AssessmentReportSelection { get; set; }

        /// <summary>
        /// Checks to see if the AssessmentReportSelection property is set.
        /// </summary>
        internal bool IsSetAssessmentReportSelection() => this.AssessmentReportSelection != null;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        ///  The names and values that are used by the evidence event. This includes an attribute
        /// name (such as <c>allowUsersToChangePassword</c>) and value (such as <c>true</c> or
        /// <c>false</c>). 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Attributes { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Attributes property is set.
        /// </summary>
        internal bool IsSetAttributes() => this.Attributes != null && (this.Attributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        ///  The identifier for the Amazon Web Services account. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;

        /// <summary>
        /// Gets and sets the property AwsOrganization. 
        /// <para>
        ///  The Amazon Web Services account that the evidence is collected from, and its organization
        /// path. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string AwsOrganization { get; set; }

        /// <summary>
        /// Checks to see if the AwsOrganization property is set.
        /// </summary>
        internal bool IsSetAwsOrganization() => this.AwsOrganization != null;

        /// <summary>
        /// Gets and sets the property ComplianceCheck. 
        /// <para>
        /// The evaluation status for automated evidence that falls under the compliance check
        /// category.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Audit Manager classes evidence as non-compliant if Security Hub CSPM reports a <i>Fail</i>
        /// result, or if Config reports a <i>Non-compliant</i> result.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Audit Manager classes evidence as compliant if Security Hub CSPM reports a <i>Pass</i>
        /// result, or if Config reports a <i>Compliant</i> result.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If a compliance check isn't available or applicable, then no compliance evaluation
        /// can be made for that evidence. This is the case if the evidence uses Config or Security
        /// Hub CSPM as the underlying data source type, but those services aren't enabled. This
        /// is also the case if the evidence uses an underlying data source type that doesn't
        /// support compliance checks (such as manual evidence, Amazon Web Services API calls,
        /// or CloudTrail). 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string ComplianceCheck { get; set; }

        /// <summary>
        /// Checks to see if the ComplianceCheck property is set.
        /// </summary>
        internal bool IsSetComplianceCheck() => this.ComplianceCheck != null;

        /// <summary>
        /// Gets and sets the property DataSource. 
        /// <para>
        ///  The data source where the evidence was collected from. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string DataSource { get; set; }

        /// <summary>
        /// Checks to see if the DataSource property is set.
        /// </summary>
        internal bool IsSetDataSource() => this.DataSource != null;

        /// <summary>
        /// Gets and sets the property EventName. 
        /// <para>
        ///  The name of the evidence event. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public string EventName { get; set; }

        /// <summary>
        /// Checks to see if the EventName property is set.
        /// </summary>
        internal bool IsSetEventName() => this.EventName != null;

        /// <summary>
        /// Gets and sets the property EventSource. 
        /// <para>
        ///  The Amazon Web Services service that the evidence is collected from. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 40)]
        public string EventSource { get; set; }

        /// <summary>
        /// Checks to see if the EventSource property is set.
        /// </summary>
        internal bool IsSetEventSource() => this.EventSource != null;

        /// <summary>
        /// Gets and sets the property EvidenceAwsAccountId. 
        /// <para>
        ///  The identifier for the Amazon Web Services account. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string EvidenceAwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the EvidenceAwsAccountId property is set.
        /// </summary>
        internal bool IsSetEvidenceAwsAccountId() => this.EvidenceAwsAccountId != null;

        /// <summary>
        /// Gets and sets the property EvidenceByType. 
        /// <para>
        ///  The type of automated evidence. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string EvidenceByType { get; set; }

        /// <summary>
        /// Checks to see if the EvidenceByType property is set.
        /// </summary>
        internal bool IsSetEvidenceByType() => this.EvidenceByType != null;

        /// <summary>
        /// Gets and sets the property EvidenceFolderId. 
        /// <para>
        ///  The identifier for the folder that the evidence is stored in. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string EvidenceFolderId { get; set; }

        /// <summary>
        /// Checks to see if the EvidenceFolderId property is set.
        /// </summary>
        internal bool IsSetEvidenceFolderId() => this.EvidenceFolderId != null;

        /// <summary>
        /// Gets and sets the property IamId. 
        /// <para>
        ///  The unique identifier for the user or role that's associated with the evidence. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string IamId { get; set; }

        /// <summary>
        /// Checks to see if the IamId property is set.
        /// </summary>
        internal bool IsSetIamId() => this.IamId != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  The identifier for the evidence. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property ResourcesIncluded. 
        /// <para>
        ///  The list of resources that are assessed to generate the evidence. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Resource> ResourcesIncluded { get; set; } = AWSConfigs.InitializeCollections ? new List<Resource>() : null;

        /// <summary>
        /// Checks to see if the ResourcesIncluded property is set.
        /// </summary>
        internal bool IsSetResourcesIncluded() => this.ResourcesIncluded != null && (this.ResourcesIncluded.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Time. 
        /// <para>
        ///  The timestamp that represents when the evidence was collected. 
        /// </para>
        /// </summary>
        public DateTime? Time { get; set; }

        /// <summary>
        /// Checks to see if the Time property is set.
        /// </summary>
        internal bool IsSetTime() => this.Time.HasValue;
    }
}
