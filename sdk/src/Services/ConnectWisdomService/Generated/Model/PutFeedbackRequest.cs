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
 * Do not modify this file. This file is generated from the wisdom-2020-10-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConnectWisdomService.Model
{
    /// <summary>
    /// Container for the parameters to the PutFeedback operation.
    /// Submits feedback to Wisdom. The feedback is used to improve future recommendations
    /// from <a href="https://docs.aws.amazon.com/wisdom/latest/APIReference/API_GetRecommendations.html">GetRecommendations</a>
    /// or results from <a href="https://docs.aws.amazon.com/wisdom/latest/APIReference/API_QueryAssistant.html">QueryAssistant</a>.
    /// Feedback can be resubmitted up to 6 hours after submission.
    /// </summary>
    public partial class PutFeedbackRequest : AmazonConnectWisdomServiceRequest
    {
        private string _assistantId;
        private FeedbackData _feedback;
        private string _targetId;
        private TargetType _targetType;

        /// <summary>
        /// Gets and sets the property AssistantId. 
        /// <para>
        /// The identifier of the Wisdom assistant. Can be either the ID or the ARN. URLs cannot
        /// contain the ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AssistantId
        {
            get { return this._assistantId; }
            set { this._assistantId = value; }
        }

        // Check to see if AssistantId property is set
        internal bool IsSetAssistantId()
        {
            return this._assistantId != null;
        }

        /// <summary>
        /// Gets and sets the property Feedback. 
        /// <para>
        /// The feedback.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FeedbackData Feedback
        {
            get { return this._feedback; }
            set { this._feedback = value; }
        }

        // Check to see if Feedback property is set
        internal bool IsSetFeedback()
        {
            return this._feedback != null;
        }

        /// <summary>
        /// Gets and sets the property TargetId. 
        /// <para>
        /// The identifier of a recommendation. or The identifier of the result data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TargetId
        {
            get { return this._targetId; }
            set { this._targetId = value; }
        }

        // Check to see if TargetId property is set
        internal bool IsSetTargetId()
        {
            return this._targetId != null;
        }

        /// <summary>
        /// Gets and sets the property TargetType. 
        /// <para>
        /// The type of the targetId for which The feedback. is targeted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TargetType TargetType
        {
            get { return this._targetType; }
            set { this._targetType = value; }
        }

        // Check to see if TargetType property is set
        internal bool IsSetTargetType()
        {
            return this._targetType != null;
        }

    }
}