/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the frauddetector-2019-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FraudDetector.Model
{
    /// <summary>
    /// This is the response object from the BatchGetVariable operation.
    /// </summary>
    public partial class BatchGetVariableResponse : AmazonWebServiceResponse
    {
        private List<BatchGetVariableError> _errors = new List<BatchGetVariableError>();
        private List<Variable> _variables = new List<Variable>();

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// The errors from the request.
        /// </para>
        /// </summary>
        public List<BatchGetVariableError> Errors
        {
            get { return this._errors; }
            set { this._errors = value; }
        }

        // Check to see if Errors property is set
        internal bool IsSetErrors()
        {
            return this._errors != null && this._errors.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Variables. 
        /// <para>
        /// The returned variables.
        /// </para>
        /// </summary>
        public List<Variable> Variables
        {
            get { return this._variables; }
            set { this._variables = value; }
        }

        // Check to see if Variables property is set
        internal bool IsSetVariables()
        {
            return this._variables != null && this._variables.Count > 0; 
        }

    }
}