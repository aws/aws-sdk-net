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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
    /// Container for the parameters to the GetEvaluationFormValidation operation.
    /// Retrieves the status and results of a validation process started by <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_StartEvaluationFormValidation.html">StartEvaluationFormValidation</a>.
    /// Returns the current execution status (<c>IN_PROGRESS</c>, <c>COMPLETED</c>, or <c>FAILED</c>),
    /// the validated form version, and when completed, a list of findings that identify structural
    /// issues and quality improvements for the evaluation form, and may include suggested
    /// fixes. If the validation failed, a reason is provided indicating the cause of the
    /// failure.
    /// </summary>
    public partial class GetEvaluationFormValidationRequest : AmazonConnectRequest
    {
        private string _evaluationFormId;
        private int? _evaluationFormVersion;
        private string _instanceId;

        /// <summary>
        /// Gets and sets the property EvaluationFormId. 
        /// <para>
        /// The unique identifier for the evaluation form.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
        public string EvaluationFormId
        {
            get { return this._evaluationFormId; }
            set { this._evaluationFormId = value; }
        }

        // Check to see if EvaluationFormId property is set
        internal bool IsSetEvaluationFormId()
        {
            return this._evaluationFormId != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluationFormVersion. 
        /// <para>
        /// The version of the evaluation form to retrieve validation results for.
        /// </para>
        /// </summary>
        public int? EvaluationFormVersion
        {
            get { return this._evaluationFormVersion; }
            set { this._evaluationFormVersion = value; }
        }

        // Check to see if EvaluationFormVersion property is set
        internal bool IsSetEvaluationFormVersion()
        {
            return this._evaluationFormVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Connect Customer instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

    }
}