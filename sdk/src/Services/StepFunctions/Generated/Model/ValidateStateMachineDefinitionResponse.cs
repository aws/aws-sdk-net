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
 * Do not modify this file. This file is generated from the states-2016-11-23.normal.json service model.
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
namespace Amazon.StepFunctions.Model
{
    /// <summary>
    /// This is the response object from the ValidateStateMachineDefinition operation.
    /// </summary>
    public partial class ValidateStateMachineDefinitionResponse : AmazonWebServiceResponse
    {
        private List<ValidateStateMachineDefinitionDiagnostic> _diagnostics = AWSConfigs.InitializeCollections ? new List<ValidateStateMachineDefinitionDiagnostic>() : null;
        private ValidateStateMachineDefinitionResultCode _result;

        /// <summary>
        /// Gets and sets the property Diagnostics. 
        /// <para>
        /// If the result is <c>OK</c>, this field will be empty. When there are errors, this
        /// field will contain an array of <b>Diagnostic</b> objects to help you troubleshoot.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ValidateStateMachineDefinitionDiagnostic> Diagnostics
        {
            get { return this._diagnostics; }
            set { this._diagnostics = value; }
        }

        // Check to see if Diagnostics property is set
        internal bool IsSetDiagnostics()
        {
            return this._diagnostics != null && (this._diagnostics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Result. 
        /// <para>
        /// The result value will be <c>OK</c> when no syntax errors are found, or <c>FAIL</c>
        /// if the workflow definition does not pass verification.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ValidateStateMachineDefinitionResultCode Result
        {
            get { return this._result; }
            set { this._result = value; }
        }

        // Check to see if Result property is set
        internal bool IsSetResult()
        {
            return this._result != null;
        }

    }
}