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
    /// Container for the parameters to the GetEvidence operation. Gets information about
    /// a specified evidence item.
    /// </summary>
    public partial class GetEvidenceRequest : AmazonAuditManagerRequest
    {
        /// <summary>
        /// Gets and sets the property AssessmentId. 
        /// <para>
        ///  The unique identifier for the assessment. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string AssessmentId { get; set; }

        /// <summary>
        /// Checks to see if the AssessmentId property is set.
        /// </summary>
        internal bool IsSetAssessmentId() => this.AssessmentId != null;

        /// <summary>
        /// Gets and sets the property ControlSetId. 
        /// <para>
        ///  The unique identifier for the control set. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 300)]
        public string ControlSetId { get; set; }

        /// <summary>
        /// Checks to see if the ControlSetId property is set.
        /// </summary>
        internal bool IsSetControlSetId() => this.ControlSetId != null;

        /// <summary>
        /// Gets and sets the property EvidenceFolderId. 
        /// <para>
        ///  The unique identifier for the folder that the evidence is stored in. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string EvidenceFolderId { get; set; }

        /// <summary>
        /// Checks to see if the EvidenceFolderId property is set.
        /// </summary>
        internal bool IsSetEvidenceFolderId() => this.EvidenceFolderId != null;

        /// <summary>
        /// Gets and sets the property EvidenceId. 
        /// <para>
        ///  The unique identifier for the evidence. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string EvidenceId { get; set; }

        /// <summary>
        /// Checks to see if the EvidenceId property is set.
        /// </summary>
        internal bool IsSetEvidenceId() => this.EvidenceId != null;
    }
}
