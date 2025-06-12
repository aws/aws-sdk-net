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
        private bool? _truncated;

        /// <summary>
        /// Gets and sets the property Diagnostics. 
        /// <para>
        /// An array of diagnostic errors and warnings found during validation of the state machine
        /// definition. Since <b>warnings</b> do not prevent deploying your workflow definition,
        /// the <b>result</b> value could be <c>OK</c> even when warning diagnostics are present
        /// in the response.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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

        /// <summary>
        /// Gets and sets the property Truncated. 
        /// <para>
        /// The result value will be <c>true</c> if the number of diagnostics found in the workflow
        /// definition exceeds <c>maxResults</c>. When all diagnostics results are returned, the
        /// value will be <c>false</c>.
        /// </para>
        /// </summary>
        public bool? Truncated
        {
            get { return this._truncated; }
            set { this._truncated = value; }
        }

        // Check to see if Truncated property is set
        internal bool IsSetTruncated()
        {
            return this._truncated.HasValue; 
        }

    }
}