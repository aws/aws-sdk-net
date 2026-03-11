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
        private string _afterItemBatcher;
        private string _afterItemSelector;
        private string _afterItemsPath;
        private string _afterItemsPointer;
        private string _afterParameters;
        private string _afterResultPath;
        private string _afterResultSelector;
        private InspectionErrorDetails _errorDetails;
        private string _input;
        private int? _maxConcurrency;
        private InspectionDataRequest _request;
        private InspectionDataResponse _response;
        private string _result;
        private int? _toleratedFailureCount;
        private float? _toleratedFailurePercentage;
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
        /// Gets and sets the property AfterItemBatcher. 
        /// <para>
        /// The effective input after the ItemBatcher filter is applied in a Map state.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=262144)]
        public string AfterItemBatcher
        {
            get { return this._afterItemBatcher; }
            set { this._afterItemBatcher = value; }
        }

        // Check to see if AfterItemBatcher property is set
        internal bool IsSetAfterItemBatcher()
        {
            return this._afterItemBatcher != null;
        }

        /// <summary>
        /// Gets and sets the property AfterItemSelector. 
        /// <para>
        /// An array containing the inputs for each Map iteration, transformed by the ItemSelector
        /// specified in a Map state.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=262144)]
        public string AfterItemSelector
        {
            get { return this._afterItemSelector; }
            set { this._afterItemSelector = value; }
        }

        // Check to see if AfterItemSelector property is set
        internal bool IsSetAfterItemSelector()
        {
            return this._afterItemSelector != null;
        }

        /// <summary>
        /// Gets and sets the property AfterItemsPath. 
        /// <para>
        /// The effective input after the ItemsPath filter is applied. Not populated when the
        /// QueryLanguage is JSONata.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=262144)]
        public string AfterItemsPath
        {
            get { return this._afterItemsPath; }
            set { this._afterItemsPath = value; }
        }

        // Check to see if AfterItemsPath property is set
        internal bool IsSetAfterItemsPath()
        {
            return this._afterItemsPath != null;
        }

        /// <summary>
        /// Gets and sets the property AfterItemsPointer. 
        /// <para>
        /// The effective input after the ItemsPointer filter is applied in a Map state.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=262144)]
        public string AfterItemsPointer
        {
            get { return this._afterItemsPointer; }
            set { this._afterItemsPointer = value; }
        }

        // Check to see if AfterItemsPointer property is set
        internal bool IsSetAfterItemsPointer()
        {
            return this._afterItemsPointer != null;
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
        /// Gets and sets the property ErrorDetails. 
        /// <para>
        /// An object containing data about a handled exception in the tested state.
        /// </para>
        /// </summary>
        public InspectionErrorDetails ErrorDetails
        {
            get { return this._errorDetails; }
            set { this._errorDetails = value; }
        }

        // Check to see if ErrorDetails property is set
        internal bool IsSetErrorDetails()
        {
            return this._errorDetails != null;
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
        /// Gets and sets the property MaxConcurrency. 
        /// <para>
        /// The max concurrency of the Map state.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0)]
        public int? MaxConcurrency
        {
            get { return this._maxConcurrency; }
            set { this._maxConcurrency = value; }
        }

        // Check to see if MaxConcurrency property is set
        internal bool IsSetMaxConcurrency()
        {
            return this._maxConcurrency.HasValue; 
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
        /// Gets and sets the property ToleratedFailureCount. 
        /// <para>
        /// The tolerated failure threshold for a Map state as defined in number of Map state
        /// iterations.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0)]
        public int? ToleratedFailureCount
        {
            get { return this._toleratedFailureCount; }
            set { this._toleratedFailureCount = value; }
        }

        // Check to see if ToleratedFailureCount property is set
        internal bool IsSetToleratedFailureCount()
        {
            return this._toleratedFailureCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ToleratedFailurePercentage. 
        /// <para>
        /// The tolerated failure threshold for a Map state as defined in percentage of Map state
        /// iterations.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=100)]
        public float? ToleratedFailurePercentage
        {
            get { return this._toleratedFailurePercentage; }
            set { this._toleratedFailurePercentage = value; }
        }

        // Check to see if ToleratedFailurePercentage property is set
        internal bool IsSetToleratedFailurePercentage()
        {
            return this._toleratedFailurePercentage.HasValue; 
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