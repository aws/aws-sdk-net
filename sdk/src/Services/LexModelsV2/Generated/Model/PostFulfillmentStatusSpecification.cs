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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
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
namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Provides a setting that determines whether the post-fulfillment response is sent to
    /// the user. For more information, see <a href="https://docs.aws.amazon.com/lexv2/latest/dg/streaming-progress.html#progress-complete">https://docs.aws.amazon.com/lexv2/latest/dg/streaming-progress.html#progress-complete</a>
    /// </summary>
    public partial class PostFulfillmentStatusSpecification
    {
        private ConditionalSpecification _failureConditional;
        private DialogState _failureNextStep;
        private ResponseSpecification _failureResponse;
        private ConditionalSpecification _successConditional;
        private DialogState _successNextStep;
        private ResponseSpecification _successResponse;
        private ConditionalSpecification _timeoutConditional;
        private DialogState _timeoutNextStep;
        private ResponseSpecification _timeoutResponse;

        /// <summary>
        /// Gets and sets the property FailureConditional. 
        /// <para>
        /// A list of conditional branches to evaluate after the fulfillment code hook throws
        /// an exception or returns with the <c>State</c> field of the <c>Intent</c> object set
        /// to <c>Failed</c>.
        /// </para>
        /// </summary>
        public ConditionalSpecification FailureConditional
        {
            get { return this._failureConditional; }
            set { this._failureConditional = value; }
        }

        // Check to see if FailureConditional property is set
        internal bool IsSetFailureConditional()
        {
            return this._failureConditional != null;
        }

        /// <summary>
        /// Gets and sets the property FailureNextStep. 
        /// <para>
        /// Specifies the next step the bot runs after the fulfillment code hook throws an exception
        /// or returns with the <c>State</c> field of the <c>Intent</c> object set to <c>Failed</c>.
        /// </para>
        /// </summary>
        public DialogState FailureNextStep
        {
            get { return this._failureNextStep; }
            set { this._failureNextStep = value; }
        }

        // Check to see if FailureNextStep property is set
        internal bool IsSetFailureNextStep()
        {
            return this._failureNextStep != null;
        }

        /// <summary>
        /// Gets and sets the property FailureResponse.
        /// </summary>
        public ResponseSpecification FailureResponse
        {
            get { return this._failureResponse; }
            set { this._failureResponse = value; }
        }

        // Check to see if FailureResponse property is set
        internal bool IsSetFailureResponse()
        {
            return this._failureResponse != null;
        }

        /// <summary>
        /// Gets and sets the property SuccessConditional. 
        /// <para>
        /// A list of conditional branches to evaluate after the fulfillment code hook finishes
        /// successfully.
        /// </para>
        /// </summary>
        public ConditionalSpecification SuccessConditional
        {
            get { return this._successConditional; }
            set { this._successConditional = value; }
        }

        // Check to see if SuccessConditional property is set
        internal bool IsSetSuccessConditional()
        {
            return this._successConditional != null;
        }

        /// <summary>
        /// Gets and sets the property SuccessNextStep. 
        /// <para>
        /// Specifies the next step in the conversation that Amazon Lex invokes when the fulfillment
        /// code hook completes successfully.
        /// </para>
        /// </summary>
        public DialogState SuccessNextStep
        {
            get { return this._successNextStep; }
            set { this._successNextStep = value; }
        }

        // Check to see if SuccessNextStep property is set
        internal bool IsSetSuccessNextStep()
        {
            return this._successNextStep != null;
        }

        /// <summary>
        /// Gets and sets the property SuccessResponse.
        /// </summary>
        public ResponseSpecification SuccessResponse
        {
            get { return this._successResponse; }
            set { this._successResponse = value; }
        }

        // Check to see if SuccessResponse property is set
        internal bool IsSetSuccessResponse()
        {
            return this._successResponse != null;
        }

        /// <summary>
        /// Gets and sets the property TimeoutConditional. 
        /// <para>
        /// A list of conditional branches to evaluate if the fulfillment code hook times out.
        /// </para>
        /// </summary>
        public ConditionalSpecification TimeoutConditional
        {
            get { return this._timeoutConditional; }
            set { this._timeoutConditional = value; }
        }

        // Check to see if TimeoutConditional property is set
        internal bool IsSetTimeoutConditional()
        {
            return this._timeoutConditional != null;
        }

        /// <summary>
        /// Gets and sets the property TimeoutNextStep. 
        /// <para>
        /// Specifies the next step that the bot runs when the fulfillment code hook times out.
        /// </para>
        /// </summary>
        public DialogState TimeoutNextStep
        {
            get { return this._timeoutNextStep; }
            set { this._timeoutNextStep = value; }
        }

        // Check to see if TimeoutNextStep property is set
        internal bool IsSetTimeoutNextStep()
        {
            return this._timeoutNextStep != null;
        }

        /// <summary>
        /// Gets and sets the property TimeoutResponse.
        /// </summary>
        public ResponseSpecification TimeoutResponse
        {
            get { return this._timeoutResponse; }
            set { this._timeoutResponse = value; }
        }

        // Check to see if TimeoutResponse property is set
        internal bool IsSetTimeoutResponse()
        {
            return this._timeoutResponse != null;
        }

    }
}