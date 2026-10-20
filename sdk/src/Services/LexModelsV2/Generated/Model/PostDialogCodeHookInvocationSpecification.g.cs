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

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Specifies next steps to run after the dialog code hook finishes.
    /// </summary>
    public partial class PostDialogCodeHookInvocationSpecification
    {
        /// <summary>
        /// Gets and sets the property FailureConditional. 
        /// <para>
        /// A list of conditional branches to evaluate after the dialog code hook throws an exception
        /// or returns with the <c>State</c> field of the <c>Intent</c> object set to <c>Failed</c>.
        /// </para>
        /// </summary>
        public ConditionalSpecification FailureConditional { get; set; }

        /// <summary>
        /// Checks to see if the FailureConditional property is set.
        /// </summary>
        internal bool IsSetFailureConditional() => this.FailureConditional != null;

        /// <summary>
        /// Gets and sets the property FailureNextStep. 
        /// <para>
        /// Specifies the next step the bot runs after the dialog code hook throws an exception
        /// or returns with the <c>State</c> field of the <c>Intent</c> object set to <c>Failed</c>.
        /// </para>
        /// </summary>
        public DialogState FailureNextStep { get; set; }

        /// <summary>
        /// Checks to see if the FailureNextStep property is set.
        /// </summary>
        internal bool IsSetFailureNextStep() => this.FailureNextStep != null;

        /// <summary>
        /// Gets and sets the property FailureResponse.
        /// </summary>
        public ResponseSpecification FailureResponse { get; set; }

        /// <summary>
        /// Checks to see if the FailureResponse property is set.
        /// </summary>
        internal bool IsSetFailureResponse() => this.FailureResponse != null;

        /// <summary>
        /// Gets and sets the property SuccessConditional. 
        /// <para>
        /// A list of conditional branches to evaluate after the dialog code hook finishes successfully.
        /// </para>
        /// </summary>
        public ConditionalSpecification SuccessConditional { get; set; }

        /// <summary>
        /// Checks to see if the SuccessConditional property is set.
        /// </summary>
        internal bool IsSetSuccessConditional() => this.SuccessConditional != null;

        /// <summary>
        /// Gets and sets the property SuccessNextStep. 
        /// <para>
        /// Specifics the next step the bot runs after the dialog code hook finishes successfully.
        /// 
        /// </para>
        /// </summary>
        public DialogState SuccessNextStep { get; set; }

        /// <summary>
        /// Checks to see if the SuccessNextStep property is set.
        /// </summary>
        internal bool IsSetSuccessNextStep() => this.SuccessNextStep != null;

        /// <summary>
        /// Gets and sets the property SuccessResponse.
        /// </summary>
        public ResponseSpecification SuccessResponse { get; set; }

        /// <summary>
        /// Checks to see if the SuccessResponse property is set.
        /// </summary>
        internal bool IsSetSuccessResponse() => this.SuccessResponse != null;

        /// <summary>
        /// Gets and sets the property TimeoutConditional. 
        /// <para>
        /// A list of conditional branches to evaluate if the code hook times out.
        /// </para>
        /// </summary>
        public ConditionalSpecification TimeoutConditional { get; set; }

        /// <summary>
        /// Checks to see if the TimeoutConditional property is set.
        /// </summary>
        internal bool IsSetTimeoutConditional() => this.TimeoutConditional != null;

        /// <summary>
        /// Gets and sets the property TimeoutNextStep. 
        /// <para>
        /// Specifies the next step that the bot runs when the code hook times out.
        /// </para>
        /// </summary>
        public DialogState TimeoutNextStep { get; set; }

        /// <summary>
        /// Checks to see if the TimeoutNextStep property is set.
        /// </summary>
        internal bool IsSetTimeoutNextStep() => this.TimeoutNextStep != null;

        /// <summary>
        /// Gets and sets the property TimeoutResponse.
        /// </summary>
        public ResponseSpecification TimeoutResponse { get; set; }

        /// <summary>
        /// Checks to see if the TimeoutResponse property is set.
        /// </summary>
        internal bool IsSetTimeoutResponse() => this.TimeoutResponse != null;
    }
}
