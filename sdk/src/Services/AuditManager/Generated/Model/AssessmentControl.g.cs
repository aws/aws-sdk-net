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
    /// The control entity that represents a standard control or a custom control in an Audit
    /// Manager assessment.
    /// </summary>
    public partial class AssessmentControl
    {
        /// <summary>
        /// Gets and sets the property AssessmentReportEvidenceCount. 
        /// <para>
        ///  The amount of evidence in the assessment report. 
        /// </para>
        /// </summary>
        public int? AssessmentReportEvidenceCount { get; set; }

        /// <summary>
        /// Checks to see if the AssessmentReportEvidenceCount property is set.
        /// </summary>
        internal bool IsSetAssessmentReportEvidenceCount() => this.AssessmentReportEvidenceCount.HasValue;

        /// <summary>
        /// Gets and sets the property Comments. 
        /// <para>
        ///  The list of comments that's attached to the control. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ControlComment> Comments { get; set; } = AWSConfigs.InitializeCollections ? new List<ControlComment>() : null;

        /// <summary>
        /// Checks to see if the Comments property is set.
        /// </summary>
        internal bool IsSetComments() => this.Comments != null && (this.Comments.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  The description of the control. 
        /// </para>
        /// </summary>
        [Obsolete("This data type will be deprecated on May 19, 2025. To view the assessment control description, use GetControl.")]
        [AWSProperty(Sensitive = true, Min = 0, Max = 1000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EvidenceCount. 
        /// <para>
        ///  The amount of evidence that's collected for the control. 
        /// </para>
        /// </summary>
        public int? EvidenceCount { get; set; }

        /// <summary>
        /// Checks to see if the EvidenceCount property is set.
        /// </summary>
        internal bool IsSetEvidenceCount() => this.EvidenceCount.HasValue;

        /// <summary>
        /// Gets and sets the property EvidenceSources. 
        /// <para>
        ///  The list of data sources for the evidence. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EvidenceSources { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EvidenceSources property is set.
        /// </summary>
        internal bool IsSetEvidenceSources() => this.EvidenceSources != null && (this.EvidenceSources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  The identifier for the control. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the control. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 300)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Response. 
        /// <para>
        ///  The response of the control. 
        /// </para>
        /// </summary>
        public ControlResponse Response { get; set; }

        /// <summary>
        /// Checks to see if the Response property is set.
        /// </summary>
        internal bool IsSetResponse() => this.Response != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of the control. 
        /// </para>
        /// </summary>
        public ControlStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
