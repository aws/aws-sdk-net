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
 * Do not modify this file. This file is generated from the nova-act-2025-08-22.normal.json service model.
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
namespace Amazon.NovaAct.Model
{
    /// <summary>
    /// This is the response object from the InvokeActStep operation.
    /// </summary>
    public partial class InvokeActStepResponse : AmazonWebServiceResponse
    {
        private List<Call> _calls = AWSConfigs.InitializeCollections ? new List<Call>() : null;
        private string _stepId;

        /// <summary>
        /// Gets and sets the property Calls. 
        /// <para>
        /// A list of tool calls that the act wants to execute in this step.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Call> Calls
        {
            get { return this._calls; }
            set { this._calls = value; }
        }

        // Check to see if Calls property is set
        internal bool IsSetCalls()
        {
            return this._calls != null && (this._calls.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StepId. 
        /// <para>
        /// The unique identifier for this execution step.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string StepId
        {
            get { return this._stepId; }
            set { this._stepId = value; }
        }

        // Check to see if StepId property is set
        internal bool IsSetStepId()
        {
            return this._stepId != null;
        }

    }
}