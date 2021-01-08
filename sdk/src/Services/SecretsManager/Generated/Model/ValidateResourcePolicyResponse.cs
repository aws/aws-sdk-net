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
 * Do not modify this file. This file is generated from the secretsmanager-2017-10-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecretsManager.Model
{
    /// <summary>
    /// This is the response object from the ValidateResourcePolicy operation.
    /// </summary>
    public partial class ValidateResourcePolicyResponse : AmazonWebServiceResponse
    {
        private bool? _policyValidationPassed;
        private List<ValidationErrorsEntry> _validationErrors = new List<ValidationErrorsEntry>();

        /// <summary>
        /// Gets and sets the property PolicyValidationPassed. 
        /// <para>
        /// Returns a message stating that your Reource Policy passed validation. 
        /// </para>
        /// </summary>
        public bool PolicyValidationPassed
        {
            get { return this._policyValidationPassed.GetValueOrDefault(); }
            set { this._policyValidationPassed = value; }
        }

        // Check to see if PolicyValidationPassed property is set
        internal bool IsSetPolicyValidationPassed()
        {
            return this._policyValidationPassed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ValidationErrors. 
        /// <para>
        /// Returns an error message if your policy doesn't pass validatation.
        /// </para>
        /// </summary>
        public List<ValidationErrorsEntry> ValidationErrors
        {
            get { return this._validationErrors; }
            set { this._validationErrors = value; }
        }

        // Check to see if ValidationErrors property is set
        internal bool IsSetValidationErrors()
        {
            return this._validationErrors != null && this._validationErrors.Count > 0; 
        }

    }
}