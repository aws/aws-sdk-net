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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the StartEvaluationFormValidation operation. Starts
    /// an asynchronous validation process for an evaluation form version in the specified
    /// Connect Customer instance. The validation first performs structural checks on the
    /// form content (such as verifying required fields, valid scoring configuration, and
    /// correct conditional logic), then asynchronously analyzes questions configured for
    /// generative AI evaluation against a set of best practices. Use <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_GetEvaluationFormValidation.html">GetEvaluationFormValidation</a>
    /// to retrieve the status and results once the validation completes.
    /// </summary>
    public partial class StartEvaluationFormValidationRequest : AmazonConnectRequest
    {
        /// <summary>
        /// Gets and sets the property EvaluationFormId. 
        /// <para>
        /// The unique identifier for the evaluation form.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 500)]
        public string EvaluationFormId { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationFormId property is set.
        /// </summary>
        internal bool IsSetEvaluationFormId() => this.EvaluationFormId != null;

        /// <summary>
        /// Gets and sets the property EvaluationFormVersion. 
        /// <para>
        /// The version of the evaluation form to validate.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? EvaluationFormVersion { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationFormVersion property is set.
        /// </summary>
        internal bool IsSetEvaluationFormVersion() => this.EvaluationFormVersion.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Connect Customer instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;
    }
}
