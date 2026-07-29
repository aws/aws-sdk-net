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
    /// This is the response object from the GetEvaluationFormValidation operation.
    /// </summary>
    public partial class GetEvaluationFormValidationResponse : AmazonWebServiceResponse
    {
        private string _evaluationFormId;
        private int? _evaluationFormVersion;
        private string _failureReason;
        private List<EvaluationFormValidationFinding> _findings = AWSConfigs.InitializeCollections ? new List<EvaluationFormValidationFinding>() : null;
        private DateTime? _startedTime;
        private EvaluationFormValidationStatus _status;

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
        /// A version of the evaluation form.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason the validation failed. This field is populated only when the status is
        /// <c>FAILED</c>.
        /// </para>
        /// </summary>
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property Findings. 
        /// <para>
        /// A list of findings from the validation process. Each finding identifies a structural
        /// issue or quality improvement for the evaluation form, and may include a suggested
        /// fix. This field is populated when the status is <c>COMPLETED</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EvaluationFormValidationFinding> Findings
        {
            get { return this._findings; }
            set { this._findings = value; }
        }

        // Check to see if Findings property is set
        internal bool IsSetFindings()
        {
            return this._findings != null && (this._findings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StartedTime. 
        /// <para>
        /// The timestamp when the validation process was started.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? StartedTime
        {
            get { return this._startedTime; }
            set { this._startedTime = value; }
        }

        // Check to see if StartedTime property is set
        internal bool IsSetStartedTime()
        {
            return this._startedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the validation process. Valid values: <c>IN_PROGRESS</c>, <c>COMPLETED</c>,
        /// <c>FAILED</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EvaluationFormValidationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}