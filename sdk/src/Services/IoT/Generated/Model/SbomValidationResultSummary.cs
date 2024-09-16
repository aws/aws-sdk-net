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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
        private SbomValidationErrorCode _errorCode;
        private string _errorMessage;
        private string _fileName;
        private SbomValidationResult _validationResult;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The <c>errorCode</c> representing the validation failure error if the SBOM validation
        /// failed.
        /// </para>
        /// </summary>
        public SbomValidationErrorCode ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this._errorCode != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// The <c>errorMessage</c> representing the validation failure error if the SBOM validation
        /// failed.
        /// </para>
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property FileName. 
        /// <para>
        /// The name of the SBOM file.
        /// </para>
        /// </summary>
        public string FileName
        {
            get { return this._fileName; }
            set { this._fileName = value; }
        }

        // Check to see if FileName property is set
        internal bool IsSetFileName()
        {
            return this._fileName != null;
        }

        /// <summary>
        /// Gets and sets the property ValidationResult. 
        /// <para>
        /// The end result of the SBOM validation.
        /// </para>
        /// </summary>
        public SbomValidationResult ValidationResult
        {
            get { return this._validationResult; }
            set { this._validationResult = value; }
        }

        // Check to see if ValidationResult property is set
        internal bool IsSetValidationResult()
        {
            return this._validationResult != null;
        }

    }
}