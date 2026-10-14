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
    /// The context behind the remediation target's existence and guidance.
    /// </summary>
    public partial class RemediationGuidanceContext
    {
        /// <summary>
        /// Gets and sets the property AffectedScope. 
        /// <para>
        /// The scope of the resources affected by the resolution of the remediation target.
        /// </para>
        /// </summary>
        public string AffectedScope { get; set; }

        /// <summary>
        /// Checks to see if the AffectedScope property is set.
        /// </summary>
        internal bool IsSetAffectedScope() => this.AffectedScope != null;

        /// <summary>
        /// Gets and sets the property Prerequisites. 
        /// <para>
        /// An array of prerequisite steps in resolving the remediation target.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<string> Prerequisites { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Prerequisites property is set.
        /// </summary>
        internal bool IsSetPrerequisites() => this.Prerequisites != null && (this.Prerequisites.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProblemStatement. 
        /// <para>
        /// Explains the cause which directly created the remediation target.
        /// </para>
        /// </summary>
        public string ProblemStatement { get; set; }

        /// <summary>
        /// Checks to see if the ProblemStatement property is set.
        /// </summary>
        internal bool IsSetProblemStatement() => this.ProblemStatement != null;

        /// <summary>
        /// Gets and sets the property RiskAssessment. 
        /// <para>
        /// An assessment of the existing risk the remediation target creates.
        /// </para>
        /// </summary>
        public string RiskAssessment { get; set; }

        /// <summary>
        /// Checks to see if the RiskAssessment property is set.
        /// </summary>
        internal bool IsSetRiskAssessment() => this.RiskAssessment != null;
    }
}
