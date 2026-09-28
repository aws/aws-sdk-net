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
    /// This is the response object from the ValidateAssessmentReportIntegrity operation.
    /// </summary>
    public partial class ValidateAssessmentReportIntegrityResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property SignatureAlgorithm. 
        /// <para>
        ///  The signature algorithm that's used to code sign the assessment report file. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string SignatureAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the SignatureAlgorithm property is set.
        /// </summary>
        internal bool IsSetSignatureAlgorithm() => this.SignatureAlgorithm != null;

        /// <summary>
        /// Gets and sets the property SignatureDateTime. 
        /// <para>
        ///  The date and time signature that specifies when the assessment report was created.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string SignatureDateTime { get; set; }

        /// <summary>
        /// Checks to see if the SignatureDateTime property is set.
        /// </summary>
        internal bool IsSetSignatureDateTime() => this.SignatureDateTime != null;

        /// <summary>
        /// Gets and sets the property SignatureKeyId. 
        /// <para>
        ///  The unique identifier for the validation signature key. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string SignatureKeyId { get; set; }

        /// <summary>
        /// Checks to see if the SignatureKeyId property is set.
        /// </summary>
        internal bool IsSetSignatureKeyId() => this.SignatureKeyId != null;

        /// <summary>
        /// Gets and sets the property SignatureValid. 
        /// <para>
        ///  Specifies whether the signature key is valid. 
        /// </para>
        /// </summary>
        public bool? SignatureValid { get; set; }

        /// <summary>
        /// Checks to see if the SignatureValid property is set.
        /// </summary>
        internal bool IsSetSignatureValid() => this.SignatureValid.HasValue;

        /// <summary>
        /// Gets and sets the property ValidationErrors. 
        /// <para>
        ///  Represents any errors that occurred when validating the assessment report. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ValidationErrors { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ValidationErrors property is set.
        /// </summary>
        internal bool IsSetValidationErrors() => this.ValidationErrors != null && (this.ValidationErrors.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
