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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
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
namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Container for the parameters to the ProvideAnomalyFeedback operation.
    /// Modifies the feedback property of a given cost anomaly.
    /// </summary>
    public partial class ProvideAnomalyFeedbackRequest : AmazonCostExplorerRequest
    {
        private string _anomalyId;
        private AnomalyFeedbackType _feedback;

        /// <summary>
        /// Gets and sets the property AnomalyId. 
        /// <para>
        /// A cost anomaly ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
        public string AnomalyId
        {
            get { return this._anomalyId; }
            set { this._anomalyId = value; }
        }

        // Check to see if AnomalyId property is set
        internal bool IsSetAnomalyId()
        {
            return this._anomalyId != null;
        }

        /// <summary>
        /// Gets and sets the property Feedback. 
        /// <para>
        /// Describes whether the cost anomaly was a planned activity or you considered it an
        /// anomaly. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AnomalyFeedbackType Feedback
        {
            get { return this._feedback; }
            set { this._feedback = value; }
        }

        // Check to see if Feedback property is set
        internal bool IsSetFeedback()
        {
            return this._feedback != null;
        }

    }
}