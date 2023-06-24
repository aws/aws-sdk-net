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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// This is the response object from the GetResourceEvaluationSummary operation.
    /// </summary>
    public partial class GetResourceEvaluationSummaryResponse : AmazonWebServiceResponse
    {
        private ComplianceType _compliance;
        private EvaluationContext _evaluationContext;
        private EvaluationMode _evaluationMode;
        private DateTime? _evaluationStartTimestamp;
        private EvaluationStatus _evaluationStatus;
        private ResourceDetails _resourceDetails;
        private string _resourceEvaluationId;

        /// <summary>
        /// Gets and sets the property Compliance. 
        /// <para>
        /// The compliance status of the resource evaluation summary.
        /// </para>
        /// </summary>
        public ComplianceType Compliance
        {
            get { return this._compliance; }
            set { this._compliance = value; }
        }

        // Check to see if Compliance property is set
        internal bool IsSetCompliance()
        {
            return this._compliance != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluationContext. 
        /// <para>
        /// Returns an <code>EvaluationContext</code> object.
        /// </para>
        /// </summary>
        public EvaluationContext EvaluationContext
        {
            get { return this._evaluationContext; }
            set { this._evaluationContext = value; }
        }

        // Check to see if EvaluationContext property is set
        internal bool IsSetEvaluationContext()
        {
            return this._evaluationContext != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluationMode. 
        /// <para>
        /// Lists results of the mode that you requested to retrieve the resource evaluation summary.
        /// The valid values are Detective or Proactive.
        /// </para>
        /// </summary>
        public EvaluationMode EvaluationMode
        {
            get { return this._evaluationMode; }
            set { this._evaluationMode = value; }
        }

        // Check to see if EvaluationMode property is set
        internal bool IsSetEvaluationMode()
        {
            return this._evaluationMode != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluationStartTimestamp. 
        /// <para>
        /// The start timestamp when Config rule starts evaluating compliance for the provided
        /// resource details.
        /// </para>
        /// </summary>
        public DateTime EvaluationStartTimestamp
        {
            get { return this._evaluationStartTimestamp.GetValueOrDefault(); }
            set { this._evaluationStartTimestamp = value; }
        }

        // Check to see if EvaluationStartTimestamp property is set
        internal bool IsSetEvaluationStartTimestamp()
        {
            return this._evaluationStartTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EvaluationStatus. 
        /// <para>
        /// Returns an <code>EvaluationStatus</code> object.
        /// </para>
        /// </summary>
        public EvaluationStatus EvaluationStatus
        {
            get { return this._evaluationStatus; }
            set { this._evaluationStatus = value; }
        }

        // Check to see if EvaluationStatus property is set
        internal bool IsSetEvaluationStatus()
        {
            return this._evaluationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceDetails. 
        /// <para>
        /// Returns a <code>ResourceDetails</code> object.
        /// </para>
        /// </summary>
        public ResourceDetails ResourceDetails
        {
            get { return this._resourceDetails; }
            set { this._resourceDetails = value; }
        }

        // Check to see if ResourceDetails property is set
        internal bool IsSetResourceDetails()
        {
            return this._resourceDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceEvaluationId. 
        /// <para>
        /// The unique <code>ResourceEvaluationId</code> of Amazon Web Services resource execution
        /// for which you want to retrieve the evaluation summary.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ResourceEvaluationId
        {
            get { return this._resourceEvaluationId; }
            set { this._resourceEvaluationId = value; }
        }

        // Check to see if ResourceEvaluationId property is set
        internal bool IsSetResourceEvaluationId()
        {
            return this._resourceEvaluationId != null;
        }

    }
}