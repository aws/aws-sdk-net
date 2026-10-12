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

namespace Amazon.StepFunctions.Model
{
    /// <summary>
    /// Contains additional details about the state's execution, including its input and output
    /// data processing flow, and HTTP request and response information.
    /// </summary>
    public partial class InspectionData
    {
        /// <summary>
        /// Gets and sets the property AfterArguments. 
        /// <para>
        /// The input after Step Functions applies an Arguments filter. This event will only be
        /// present when QueryLanguage for the state machine or individual states is set to JSONata.
        /// For more info, see <a href="https://docs.aws.amazon.com/step-functions/latest/dg/data-transform.html">Transforming
        /// data with Step Functions</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 262144)]
        public string AfterArguments { get; set; }

        /// <summary>
        /// Checks to see if the AfterArguments property is set.
        /// </summary>
        internal bool IsSetAfterArguments() => this.AfterArguments != null;

        /// <summary>
        /// Gets and sets the property AfterInputPath. 
        /// <para>
        /// The input after Step Functions applies the <a href="https://docs.aws.amazon.com/step-functions/latest/dg/input-output-inputpath-params.html#input-output-inputpath">InputPath</a>
        /// filter. Not populated when QueryLanguage is JSONata.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 262144)]
        public string AfterInputPath { get; set; }

        /// <summary>
        /// Checks to see if the AfterInputPath property is set.
        /// </summary>
        internal bool IsSetAfterInputPath() => this.AfterInputPath != null;

        /// <summary>
        /// Gets and sets the property AfterItemBatcher. 
        /// <para>
        /// The effective input after the ItemBatcher filter is applied in a Map state.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 262144)]
        public string AfterItemBatcher { get; set; }

        /// <summary>
        /// Checks to see if the AfterItemBatcher property is set.
        /// </summary>
        internal bool IsSetAfterItemBatcher() => this.AfterItemBatcher != null;

        /// <summary>
        /// Gets and sets the property AfterItemSelector. 
        /// <para>
        /// An array containing the inputs for each Map iteration, transformed by the ItemSelector
        /// specified in a Map state.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 262144)]
        public string AfterItemSelector { get; set; }

        /// <summary>
        /// Checks to see if the AfterItemSelector property is set.
        /// </summary>
        internal bool IsSetAfterItemSelector() => this.AfterItemSelector != null;

        /// <summary>
        /// Gets and sets the property AfterItemsPath. 
        /// <para>
        /// The effective input after the ItemsPath filter is applied. Not populated when the
        /// QueryLanguage is JSONata.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 262144)]
        public string AfterItemsPath { get; set; }

        /// <summary>
        /// Checks to see if the AfterItemsPath property is set.
        /// </summary>
        internal bool IsSetAfterItemsPath() => this.AfterItemsPath != null;

        /// <summary>
        /// Gets and sets the property AfterItemsPointer. 
        /// <para>
        /// The effective input after the ItemsPointer filter is applied in a Map state.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 262144)]
        public string AfterItemsPointer { get; set; }

        /// <summary>
        /// Checks to see if the AfterItemsPointer property is set.
        /// </summary>
        internal bool IsSetAfterItemsPointer() => this.AfterItemsPointer != null;

        /// <summary>
        /// Gets and sets the property AfterParameters. 
        /// <para>
        /// The effective input after Step Functions applies the <a href="https://docs.aws.amazon.com/step-functions/latest/dg/input-output-inputpath-params.html#input-output-parameters">Parameters</a>
        /// filter. Not populated when QueryLanguage is JSONata.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 262144)]
        public string AfterParameters { get; set; }

        /// <summary>
        /// Checks to see if the AfterParameters property is set.
        /// </summary>
        internal bool IsSetAfterParameters() => this.AfterParameters != null;

        /// <summary>
        /// Gets and sets the property AfterResultPath. 
        /// <para>
        /// The effective result combined with the raw state input after Step Functions applies
        /// the <a href="https://docs.aws.amazon.com/step-functions/latest/dg/input-output-resultpath.html">ResultPath</a>
        /// filter. Not populated when QueryLanguage is JSONata.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 262144)]
        public string AfterResultPath { get; set; }

        /// <summary>
        /// Checks to see if the AfterResultPath property is set.
        /// </summary>
        internal bool IsSetAfterResultPath() => this.AfterResultPath != null;

        /// <summary>
        /// Gets and sets the property AfterResultSelector. 
        /// <para>
        /// The effective result after Step Functions applies the <a href="https://docs.aws.amazon.com/step-functions/latest/dg/input-output-inputpath-params.html#input-output-resultselector">ResultSelector</a>
        /// filter. Not populated when QueryLanguage is JSONata.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 262144)]
        public string AfterResultSelector { get; set; }

        /// <summary>
        /// Checks to see if the AfterResultSelector property is set.
        /// </summary>
        internal bool IsSetAfterResultSelector() => this.AfterResultSelector != null;

        /// <summary>
        /// Gets and sets the property ErrorDetails. 
        /// <para>
        /// An object containing data about a handled exception in the tested state.
        /// </para>
        /// </summary>
        public InspectionErrorDetails ErrorDetails { get; set; }

        /// <summary>
        /// Checks to see if the ErrorDetails property is set.
        /// </summary>
        internal bool IsSetErrorDetails() => this.ErrorDetails != null;

        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        /// The raw state input.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 262144)]
        public string Input { get; set; }

        /// <summary>
        /// Checks to see if the Input property is set.
        /// </summary>
        internal bool IsSetInput() => this.Input != null;

        /// <summary>
        /// Gets and sets the property MaxConcurrency. 
        /// <para>
        /// The max concurrency of the Map state.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0)]
        public int? MaxConcurrency { get; set; }

        /// <summary>
        /// Checks to see if the MaxConcurrency property is set.
        /// </summary>
        internal bool IsSetMaxConcurrency() => this.MaxConcurrency.HasValue;

        /// <summary>
        /// Gets and sets the property Request. 
        /// <para>
        /// The raw HTTP request that is sent when you test an HTTP Task.
        /// </para>
        /// </summary>
        public InspectionDataRequest Request { get; set; }

        /// <summary>
        /// Checks to see if the Request property is set.
        /// </summary>
        internal bool IsSetRequest() => this.Request != null;

        /// <summary>
        /// Gets and sets the property Response. 
        /// <para>
        /// The raw HTTP response that is returned when you test an HTTP Task.
        /// </para>
        /// </summary>
        public InspectionDataResponse Response { get; set; }

        /// <summary>
        /// Checks to see if the Response property is set.
        /// </summary>
        internal bool IsSetResponse() => this.Response != null;

        /// <summary>
        /// Gets and sets the property Result. 
        /// <para>
        /// The state's raw result.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 262144)]
        public string Result { get; set; }

        /// <summary>
        /// Checks to see if the Result property is set.
        /// </summary>
        internal bool IsSetResult() => this.Result != null;

        /// <summary>
        /// Gets and sets the property ToleratedFailureCount. 
        /// <para>
        /// The tolerated failure threshold for a Map state as defined in number of Map state
        /// iterations.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0)]
        public int? ToleratedFailureCount { get; set; }

        /// <summary>
        /// Checks to see if the ToleratedFailureCount property is set.
        /// </summary>
        internal bool IsSetToleratedFailureCount() => this.ToleratedFailureCount.HasValue;

        /// <summary>
        /// Gets and sets the property ToleratedFailurePercentage. 
        /// <para>
        /// The tolerated failure threshold for a Map state as defined in percentage of Map state
        /// iterations.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 100)]
        public float? ToleratedFailurePercentage { get; set; }

        /// <summary>
        /// Checks to see if the ToleratedFailurePercentage property is set.
        /// </summary>
        internal bool IsSetToleratedFailurePercentage() => this.ToleratedFailurePercentage.HasValue;

        /// <summary>
        /// Gets and sets the property Variables. 
        /// <para>
        /// JSON string that contains the set of workflow variables after execution of the state.
        /// The set will include variables assigned in the state and variables set up as test
        /// state input.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 262144)]
        public string Variables { get; set; }

        /// <summary>
        /// Checks to see if the Variables property is set.
        /// </summary>
        internal bool IsSetVariables() => this.Variables != null;
    }
}
