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
    /// An error entity for the <c>BatchImportEvidenceToAssessmentControl</c> API. This is
    /// used to provide more meaningful errors than a simple string message.
    /// </summary>
    public partial class BatchImportEvidenceToAssessmentControlError
    {
        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        ///  The error code that the <c>BatchImportEvidenceToAssessmentControl</c> API returned.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 3)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCode property is set.
        /// </summary>
        internal bool IsSetErrorCode() => this.ErrorCode != null;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        ///  The error message that the <c>BatchImportEvidenceToAssessmentControl</c> API returned.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 300)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property ManualEvidence. 
        /// <para>
        ///  Manual evidence that can't be collected automatically by Audit Manager. 
        /// </para>
        /// </summary>
        public ManualEvidence ManualEvidence { get; set; }

        /// <summary>
        /// Checks to see if the ManualEvidence property is set.
        /// </summary>
        internal bool IsSetManualEvidence() => this.ManualEvidence != null;
    }
}
