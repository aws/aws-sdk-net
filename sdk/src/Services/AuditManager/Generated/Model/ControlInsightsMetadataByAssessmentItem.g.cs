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
    /// A summary of the latest analytics data for a specific control in a specific active
    /// assessment.
    /// 
    ///  
    /// <para>
    /// Control insights are grouped by control domain, and ranked by the highest total count
    /// of non-compliant evidence. 
    /// </para>
    /// </summary>
    public partial class ControlInsightsMetadataByAssessmentItem
    {
        /// <summary>
        /// Gets and sets the property ControlSetName. 
        /// <para>
        /// The name of the control set that the assessment control belongs to. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ControlSetName { get; set; }

        /// <summary>
        /// Checks to see if the ControlSetName property is set.
        /// </summary>
        internal bool IsSetControlSetName() => this.ControlSetName != null;

        /// <summary>
        /// Gets and sets the property EvidenceInsights. 
        /// <para>
        /// A breakdown of the compliance check status for the evidence that’s associated with
        /// the assessment control. 
        /// </para>
        /// </summary>
        public EvidenceInsights EvidenceInsights { get; set; }

        /// <summary>
        /// Checks to see if the EvidenceInsights property is set.
        /// </summary>
        internal bool IsSetEvidenceInsights() => this.EvidenceInsights != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the assessment control. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 13, Max = 2048)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LastUpdated. 
        /// <para>
        /// The time when the assessment control insights were last updated. 
        /// </para>
        /// </summary>
        public DateTime? LastUpdated { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdated property is set.
        /// </summary>
        internal bool IsSetLastUpdated() => this.LastUpdated.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the assessment control. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
