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
    /// Summary information about an evaluation acknowledgement.
    /// </summary>
    public partial class EvaluationAcknowledgementSummary
    {
        private string _acknowledgedBy;
        private DateTime? _acknowledgedTime;
        private string _acknowledgerComment;

        /// <summary>
        /// Gets and sets the property AcknowledgedBy. 
        /// <para>
        /// The agent who acknowledged the evaluation.
        /// </para>
        /// </summary>
        public string AcknowledgedBy
        {
            get { return this._acknowledgedBy; }
            set { this._acknowledgedBy = value; }
        }

        // Check to see if AcknowledgedBy property is set
        internal bool IsSetAcknowledgedBy()
        {
            return this._acknowledgedBy != null;
        }

        /// <summary>
        /// Gets and sets the property AcknowledgedTime. 
        /// <para>
        /// The time when an agent acknowledged the evaluation.
        /// </para>
        /// </summary>
        public DateTime AcknowledgedTime
        {
            get { return this._acknowledgedTime.GetValueOrDefault(); }
            set { this._acknowledgedTime = value; }
        }

        // Check to see if AcknowledgedTime property is set
        internal bool IsSetAcknowledgedTime()
        {
            return this._acknowledgedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AcknowledgerComment. 
        /// <para>
        /// A comment from the agent when they confirmed they acknowledged the evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=3072)]
        public string AcknowledgerComment
        {
            get { return this._acknowledgerComment; }
            set { this._acknowledgerComment = value; }
        }

        // Check to see if AcknowledgerComment property is set
        internal bool IsSetAcknowledgerComment()
        {
            return this._acknowledgerComment != null;
        }

    }
}