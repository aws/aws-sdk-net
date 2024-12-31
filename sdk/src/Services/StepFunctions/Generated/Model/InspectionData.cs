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
    /// Contains additional details about the state's execution, including its input and output
    /// data processing flow, and HTTP request and response information.
    /// </summary>
    public partial class InspectionData
    {
        private string _afterArguments;
        private string _afterInputPath;
        private string _afterParameters;
        private string _afterResultPath;
        private string _afterResultSelector;
        private string _input;
        private InspectionDataRequest _request;
        private InspectionDataResponse _response;
        private string _result;
        private string _variables;

        /// <summary>
        /// Gets and sets the property AfterArguments. 
        /// <para>
        /// The input after Step Functions applies an Arguments filter. This event will only be
        /// present when QueryLanguage for the state machine or individual states is set to JSONata.
        /// For more info, see <a href="https://docs.aws.amazon.com/step-functions/latest/dg/data-transform.html">Transforming
        /// data with Step Functions</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=262144)]
        public string AfterArguments
        {
            get { return this._afterArguments; }
            set { this._afterArguments = value; }
        }

        // Check to see if AfterArguments property is set
        internal bool IsSetAfterArguments()
        {
            return this._afterArguments != null;
        }

        /// <summary>
        /// Gets and sets the property AfterInputPath. 
        /// <para>
        /// The input after Step Functions applies the <a href="https://docs.aws.amazon.com/step-functions/latest/dg/input-output-inputpath-params.html#input-output-inputpath">InputPath</a>
        /// filter. Not populated when QueryLanguage is JSONata.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=262144)]
        public string AfterInputPath
        {
            get { return this._afterInputPath; }
            set { this._afterInputPath = value; }
        }

        // Check to see if AfterInputPath property is set
        internal bool IsSetAfterInputPath()
        {
            return this._afterInputPath != null;
        }

        /// <summary>
        /// Gets and sets the property AfterParameters. 
        /// <para>
        /// The effective input after Step Functions applies the <a href="https://docs.aws.amazon.com/step-functions/latest/dg/input-output-inputpath-params.html#input-output-parameters">Parameters</a>
        /// filter. Not populated when QueryLanguage is JSONata.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=262144)]
        public string AfterParameters
        {
            get { return this._afterParameters; }
            set { this._afterParameters = value; }
        }

        // Check to see if AfterParameters property is set
        internal bool IsSetAfterParameters()
        {
            return this._afterParameters != null;
        }

        /// <summary>
        /// Gets and sets the property AfterResultPath. 
        /// <para>
        /// The effective result combined with the raw state input after Step Functions applies
        /// the <a href="https://docs.aws.amazon.com/step-functions/latest/dg/input-output-resultpath.html">ResultPath</a>
        /// filter. Not populated when QueryLanguage is JSONata.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=262144)]
        public string AfterResultPath
        {
            get { return this._afterResultPath; }
            set { this._afterResultPath = value; }
        }

        // Check to see if AfterResultPath property is set
        internal bool IsSetAfterResultPath()
        {
            return this._afterResultPath != null;
        }

        /// <summary>
        /// Gets and sets the property AfterResultSelector. 
        /// <para>
        /// The effective result after Step Functions applies the <a href="https://docs.aws.amazon.com/step-functions/latest/dg/input-output-inputpath-params.html#input-output-resultselector">ResultSelector</a>
        /// filter. Not populated when QueryLanguage is JSONata.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=262144)]
        public string AfterResultSelector
        {
            get { return this._afterResultSelector; }
            set { this._afterResultSelector = value; }
        }

        // Check to see if AfterResultSelector property is set
        internal bool IsSetAfterResultSelector()
        {
            return this._afterResultSelector != null;
        }

        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        /// The raw state input.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=262144)]
        public string Input
        {
            get { return this._input; }
            set { this._input = value; }
        }

        // Check to see if Input property is set
        internal bool IsSetInput()
        {
            return this._input != null;
        }

        /// <summary>
        /// Gets and sets the property Request. 
        /// <para>
        /// The raw HTTP request that is sent when you test an HTTP Task.
        /// </para>
        /// </summary>
        public InspectionDataRequest Request
        {
            get { return this._request; }
            set { this._request = value; }
        }

        // Check to see if Request property is set
        internal bool IsSetRequest()
        {
            return this._request != null;
        }

        /// <summary>
        /// Gets and sets the property Response. 
        /// <para>
        /// The raw HTTP response that is returned when you test an HTTP Task.
        /// </para>
        /// </summary>
        public InspectionDataResponse Response
        {
            get { return this._response; }
            set { this._response = value; }
        }

        // Check to see if Response property is set
        internal bool IsSetResponse()
        {
            return this._response != null;
        }

        /// <summary>
        /// Gets and sets the property Result. 
        /// <para>
        /// The state's raw result.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=262144)]
        public string Result
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
        /// Gets and sets the property Variables. 
        /// <para>
        /// JSON string that contains the set of workflow variables after execution of the state.
        /// The set will include variables assigned in the state and variables set up as test
        /// state input.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=262144)]
        public string Variables
        {
            get { return this._variables; }
            set { this._variables = value; }
        }

        // Check to see if Variables property is set
        internal bool IsSetVariables()
        {
            return this._variables != null;
        }

    }
}