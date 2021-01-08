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
 * Do not modify this file. This file is generated from the datapipeline-2012-10-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataPipeline.Model
{
    /// <summary>
    /// Contains the output of ValidatePipelineDefinition.
    /// </summary>
    public partial class ValidatePipelineDefinitionResponse : AmazonWebServiceResponse
    {
        private bool? _errored;
        private List<ValidationError> _validationErrors = new List<ValidationError>();
        private List<ValidationWarning> _validationWarnings = new List<ValidationWarning>();

        /// <summary>
        /// Gets and sets the property Errored. 
        /// <para>
        /// Indicates whether there were validation errors.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool Errored
        {
            get { return this._errored.GetValueOrDefault(); }
            set { this._errored = value; }
        }

        // Check to see if Errored property is set
        internal bool IsSetErrored()
        {
            return this._errored.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ValidationErrors. 
        /// <para>
        /// Any validation errors that were found.
        /// </para>
        /// </summary>
        public List<ValidationError> ValidationErrors
        {
            get { return this._validationErrors; }
            set { this._validationErrors = value; }
        }

        // Check to see if ValidationErrors property is set
        internal bool IsSetValidationErrors()
        {
            return this._validationErrors != null && this._validationErrors.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ValidationWarnings. 
        /// <para>
        /// Any validation warnings that were found.
        /// </para>
        /// </summary>
        public List<ValidationWarning> ValidationWarnings
        {
            get { return this._validationWarnings; }
            set { this._validationWarnings = value; }
        }

        // Check to see if ValidationWarnings property is set
        internal bool IsSetValidationWarnings()
        {
            return this._validationWarnings != null && this._validationWarnings.Count > 0; 
        }

    }
}