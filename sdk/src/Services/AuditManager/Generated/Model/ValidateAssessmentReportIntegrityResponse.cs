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
 * Do not modify this file. This file is generated from the auditmanager-2017-07-25.normal.json service model.
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
    /// This is the response object from the ValidateAssessmentReportIntegrity operation.
    /// </summary>
    public partial class ValidateAssessmentReportIntegrityResponse : AmazonWebServiceResponse
    {
        private string _signatureAlgorithm;
        private string _signatureDateTime;
        private string _signatureKeyId;
        private bool? _signatureValid;
        private List<string> _validationErrors = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property SignatureAlgorithm. 
        /// <para>
        ///  The signature algorithm that's used to code sign the assessment report file. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string SignatureAlgorithm
        {
            get { return this._signatureAlgorithm; }
            set { this._signatureAlgorithm = value; }
        }

        // Check to see if SignatureAlgorithm property is set
        internal bool IsSetSignatureAlgorithm()
        {
            return this._signatureAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property SignatureDateTime. 
        /// <para>
        ///  The date and time signature that specifies when the assessment report was created.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string SignatureDateTime
        {
            get { return this._signatureDateTime; }
            set { this._signatureDateTime = value; }
        }

        // Check to see if SignatureDateTime property is set
        internal bool IsSetSignatureDateTime()
        {
            return this._signatureDateTime != null;
        }

        /// <summary>
        /// Gets and sets the property SignatureKeyId. 
        /// <para>
        ///  The unique identifier for the validation signature key. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string SignatureKeyId
        {
            get { return this._signatureKeyId; }
            set { this._signatureKeyId = value; }
        }

        // Check to see if SignatureKeyId property is set
        internal bool IsSetSignatureKeyId()
        {
            return this._signatureKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property SignatureValid. 
        /// <para>
        ///  Specifies whether the signature key is valid. 
        /// </para>
        /// </summary>
        public bool? SignatureValid
        {
            get { return this._signatureValid; }
            set { this._signatureValid = value; }
        }

        // Check to see if SignatureValid property is set
        internal bool IsSetSignatureValid()
        {
            return this._signatureValid.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ValidationErrors. 
        /// <para>
        ///  Represents any errors that occurred when validating the assessment report. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ValidationErrors
        {
            get { return this._validationErrors; }
            set { this._validationErrors = value; }
        }

        // Check to see if ValidationErrors property is set
        internal bool IsSetValidationErrors()
        {
            return this._validationErrors != null && (this._validationErrors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}