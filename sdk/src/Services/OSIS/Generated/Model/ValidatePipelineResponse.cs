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
 * Do not modify this file. This file is generated from the osis-2022-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OSIS.Model
{
    /// <summary>
    /// This is the response object from the ValidatePipeline operation.
    /// </summary>
    public partial class ValidatePipelineResponse : AmazonWebServiceResponse
    {
        private List<ValidationMessage> _errors = AWSConfigs.InitializeCollections ? new List<ValidationMessage>() : null;
        private bool? _isValid;

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// A list of errors if the configuration is invalid.
        /// </para>
        /// </summary>
        public List<ValidationMessage> Errors
        {
            get { return this._errors; }
            set { this._errors = value; }
        }

        // Check to see if Errors property is set
        internal bool IsSetErrors()
        {
            return this._errors != null && (this._errors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IsValid. 
        /// <para>
        /// A boolean indicating whether or not the pipeline configuration is valid.
        /// </para>
        /// </summary>
        public bool IsValid
        {
            get { return this._isValid.GetValueOrDefault(); }
            set { this._isValid = value; }
        }

        // Check to see if IsValid property is set
        internal bool IsSetIsValid()
        {
            return this._isValid.HasValue; 
        }

    }
}