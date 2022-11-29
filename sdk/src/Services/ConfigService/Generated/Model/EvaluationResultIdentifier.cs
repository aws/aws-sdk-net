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
    /// Uniquely identifies an evaluation result.
    /// </summary>
    public partial class EvaluationResultIdentifier
    {
        private EvaluationResultQualifier _evaluationResultQualifier;
        private DateTime? _orderingTimestamp;
        private string _resourceEvaluationId;

        /// <summary>
        /// Gets and sets the property EvaluationResultQualifier. 
        /// <para>
        /// Identifies an Config rule used to evaluate an Amazon Web Services resource, and provides
        /// the type and ID of the evaluated resource.
        /// </para>
        /// </summary>
        public EvaluationResultQualifier EvaluationResultQualifier
        {
            get { return this._evaluationResultQualifier; }
            set { this._evaluationResultQualifier = value; }
        }

        // Check to see if EvaluationResultQualifier property is set
        internal bool IsSetEvaluationResultQualifier()
        {
            return this._evaluationResultQualifier != null;
        }

        /// <summary>
        /// Gets and sets the property OrderingTimestamp. 
        /// <para>
        /// The time of the event that triggered the evaluation of your Amazon Web Services resources.
        /// The time can indicate when Config delivered a configuration item change notification,
        /// or it can indicate when Config delivered the configuration snapshot, depending on
        /// which event triggered the evaluation.
        /// </para>
        /// </summary>
        public DateTime OrderingTimestamp
        {
            get { return this._orderingTimestamp.GetValueOrDefault(); }
            set { this._orderingTimestamp = value; }
        }

        // Check to see if OrderingTimestamp property is set
        internal bool IsSetOrderingTimestamp()
        {
            return this._orderingTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceEvaluationId. 
        /// <para>
        /// A Unique ID for an evaluation result.
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