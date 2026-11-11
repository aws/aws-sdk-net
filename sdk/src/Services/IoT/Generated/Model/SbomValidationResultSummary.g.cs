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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// A summary of the validation results for a specific software bill of materials (SBOM)
    /// attached to a software package version.
    /// </summary>
    public partial class SbomValidationResultSummary
    {
        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The <c>errorCode</c> representing the validation failure error if the SBOM validation
        /// failed.
        /// </para>
        /// </summary>
        public SbomValidationErrorCode ErrorCode { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCode property is set.
        /// </summary>
        internal bool IsSetErrorCode() => this.ErrorCode != null;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// The <c>errorMessage</c> representing the validation failure error if the SBOM validation
        /// failed.
        /// </para>
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property FileName. 
        /// <para>
        /// The name of the SBOM file.
        /// </para>
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Checks to see if the FileName property is set.
        /// </summary>
        internal bool IsSetFileName() => this.FileName != null;

        /// <summary>
        /// Gets and sets the property ValidationResult. 
        /// <para>
        /// The end result of the SBOM validation.
        /// </para>
        /// </summary>
        public SbomValidationResult ValidationResult { get; set; }

        /// <summary>
        /// Checks to see if the ValidationResult property is set.
        /// </summary>
        internal bool IsSetValidationResult() => this.ValidationResult != null;
    }
}
